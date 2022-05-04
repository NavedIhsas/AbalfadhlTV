using AbalfadhlTV.Application.Interfaces.Contexts;
using AbalfadhlTV.Domain.Attributes;
using AbalfadhlTV.Domain.ImamzadehaAgg;
using Microsoft.EntityFrameworkCore;

namespace AbalfadhlTV.Persistence.Contexts
{
    public class DatabaseContext:DbContext,IDatabaseContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options){}

        public DbSet<CountryImamzadeh> CountriesImamzadehs { get; set; }
        public DbSet<CitiesImamzadeh> CitiesImamzadehs { get; set; }
        public DbSet<ItemsImamzadeh> ItemsImamzadehs { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            var assembly = typeof(CountryImamzadeh).Assembly;
            builder.ApplyConfigurationsFromAssembly(assembly);

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.GetCustomAttributes(typeof(AuditableAttribute), true).Length <= 0) continue;
                builder.Entity(entityType.Name).Property<DateTime>("InsertTime");
                builder.Entity(entityType.Name).Property<DateTime?>("UpdateTime");
                builder.Entity(entityType.Name).Property<DateTime?>("RemoveTime");
                builder.Entity(entityType.Name).Property<bool>("IsRemoved");
            }

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(p => p.State is EntityState.Modified or EntityState.Added or EntityState.Deleted
                );
            foreach (var item in modifiedEntries)
            {
                var entityType = item.Context.Model.FindEntityType(item.Entity.GetType());

                var inserted = entityType?.FindProperty("InsertTime");
                var updated = entityType?.FindProperty("UpdateTime");
                var removeTime = entityType?.FindProperty("RemoveTime");
                var isRemoved = entityType?.FindProperty("IsRemoved");
                if (item.State == EntityState.Added && inserted != null)
                {
                    item.Property("InsertTime").CurrentValue = DateTime.Now;
                }
                if (item.State == EntityState.Modified && updated != null)
                {
                    item.Property("UpdateTime").CurrentValue = DateTime.Now;
                }

                if (item.State != EntityState.Deleted || removeTime == null || isRemoved == null) continue;
                item.Property("RemoveTime").CurrentValue = DateTime.Now;
                item.Property("IsRemoved").CurrentValue = true;
                item.State=EntityState.Modified;
            }
            return base.SaveChanges();
        }

    }
}
