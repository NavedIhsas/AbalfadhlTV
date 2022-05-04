using AbalfadhlTV.Domain.ImamzadehaAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbalfadhlTV.Persistence.EntitiesConfiguration.Imamzadeha
{
    public class CountryImamzadehConfiguration : IEntityTypeConfiguration<CountryImamzadeh>
    {
        public void Configure(EntityTypeBuilder<CountryImamzadeh> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.HasMany(x => x.CitiesImamzadeh).WithOne(x => x.CountryImamzadeh).HasForeignKey(x => x.CountryId);
        }
    }
    public class CitiesImamzadehConfiguration : IEntityTypeConfiguration<CitiesImamzadeh>
    {
        public void Configure(EntityTypeBuilder<CitiesImamzadeh> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.HasOne(x => x.CountryImamzadeh).WithMany(x => x.CitiesImamzadeh).HasForeignKey(x => x.CountryId);
            builder.HasMany(x => x.ItemsImamzadeh).WithOne(x => x.CitiesImamzadeh).HasForeignKey(x => x.CityId);
        }
    }

    public class ItemsImamzadehConfiguration : IEntityTypeConfiguration<ItemsImamzadeh>
    {
        public void Configure(EntityTypeBuilder<ItemsImamzadeh> builder)
        {
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.HasOne(x => x.CitiesImamzadeh).WithMany(x => x.ItemsImamzadeh).HasForeignKey(x => x.CityId);
        }
    }
}
