using AbalfadhlTV.Application.Services.Beqa;
using AbalfadhlTV.Application.Services.Contexts;
using AbalfadhlTV.infrastructure.Mapper;
using AbalfadhlTV.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

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
#region Connection string

builder.Services.AddDbContext<DatabaseContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("AbalfadhlTVConnection"));
});
builder.Services.AddScoped<IDatabaseContext, DatabaseContext>();
#endregion

#region IOC

builder.Services.AddScoped<IBeqaService, BeqaService>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
