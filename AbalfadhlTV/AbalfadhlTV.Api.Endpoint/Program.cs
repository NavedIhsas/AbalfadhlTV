using System.Text;
using AbalfadhlTV.Application.Services.Beqa;
using AbalfadhlTV.Application.Services.Contexts;
using AbalfadhlTV.infrastructure.IdentityConfig;
using AbalfadhlTV.infrastructure.Mapper;
using AbalfadhlTV.Persistence.Contexts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(BeqaAutoMapperConfiguration));
builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
});

#region IOC

builder.Services.AddScoped<IBeqaService, BeqaService>();
builder.Services.AddIdentityService(configuration);

#endregion

#region Connection string

var connection = configuration.GetConnectionString("AbalfadhlTVConnection");


builder.Services.AddDbContext<DatabaseContext>(option => option.UseSqlServer(connection));


builder.Services.AddScoped<IDatabaseContext, DatabaseContext>();
#endregion


builder.Services.AddAuthentication(option =>
{
    option.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(configureOptions =>
{
    configureOptions.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidIssuer = configuration["JWtConfig:issuer"],
        ValidAudience = configuration["JWtConfig:audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWtConfig:Key"])),
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
    };
    configureOptions.SaveToken = true; // HttpContext.GetTokenAsunc();
    configureOptions.Events = new JwtBearerEvents
    {
        OnAuthenticationFailed = context =>
        {
            //log 
            //........
            return Task.CompletedTask;
        },
        OnTokenValidated = context =>
        {
            //log
            return Task.CompletedTask;
        },
        OnChallenge = context =>
        {
            return Task.CompletedTask;
        },
        OnMessageReceived = context =>
        {
            return Task.CompletedTask;
        },
        OnForbidden = context =>
        {
            return Task.CompletedTask;
        }
    };
});

builder.Services.ConfigureApplicationCookie(option =>
{
    option.ExpireTimeSpan = TimeSpan.FromDays(1);
    option.LoginPath = "/login";
    option.AccessDeniedPath = "/AccessDenied";
});
var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
