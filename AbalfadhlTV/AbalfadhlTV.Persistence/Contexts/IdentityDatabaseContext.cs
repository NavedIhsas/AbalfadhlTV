
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AbalfadhlTV.Persistence.Contexts
{
    public class IdentityDatabaseContext:IdentityDbContext
    {
        public IdentityDatabaseContext(DbContextOptions<IdentityDatabaseContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityUserLogin<long>>().HasKey(x => new { x.LoginProvider, x.ProviderKey });
            builder.Entity<IdentityUserRole<long>>().HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserToken<long>>().HasKey(x => new { x.LoginProvider, x.Name });
            builder.Entity<IdentityUser<long>>().ToTable("Users","identity");
            builder.Entity<IdentityRole<long>>().ToTable("Roles","identity");
            builder.Entity<IdentityUserClaim<long>>().ToTable("UserClaims","identity");
            builder.Entity<IdentityRoleClaim<long>>().ToTable("RoleClaims","identity");
            builder.Entity<IdentityUserLogin<long>>().ToTable("UserLogins","identity");
            builder.Entity<IdentityUserToken<long>>().ToTable("UserTokens","identity");
            builder.Entity<IdentityUserRole<long>>().ToTable("UserRoles","identity");
            base.OnModelCreating(builder);
        }
    }
}
