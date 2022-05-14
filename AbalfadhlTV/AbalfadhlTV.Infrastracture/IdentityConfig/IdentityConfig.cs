
using AbalfadhlTV.Persistence.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AbalfadhlTV.infrastructure.IdentityConfig
{
   
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityService(this IServiceCollection services,IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("AbalfadhlTVConnection");
            services.AddDbContext<IdentityDatabaseContext>(option => option.UseSqlServer(connectionString));
           
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<IdentityDatabaseContext>()
                .AddDefaultTokenProviders().AddRoles<IdentityRole>().AddErrorDescriber<CustomIdentityErrors>();

           
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 2;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredUniqueChars = 1;
                options.Password.RequireNonAlphanumeric = false;
                options.User.RequireUniqueEmail = true;
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
            });

            return services;
        }
    }
}
