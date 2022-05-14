using AbalfadhlTV.Domain.BeqaAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbalfadhlTV.Persistence.EntitiesConfiguration.Beqa
{
    public class BeqaMapping:IEntityTypeConfiguration<Domain.BeqaAgg.Beqa>
    {
        public void Configure(EntityTypeBuilder<Domain.BeqaAgg.Beqa> builder)
        {
            builder.ToTable("Beqas", "beqa");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Address).HasMaxLength(500);
            builder.Property(x => x.City).HasMaxLength(250);
            builder.Property(x => x.Country).HasMaxLength(100);
            builder.Property(x => x.Name).HasMaxLength(250);
            builder.HasMany(x => x.Beqas).WithOne(x => x.ParentBeqa)
                .HasForeignKey(x => x.ParentId)
                .OnDelete(DeleteBehavior.Cascade);
        
            builder.HasMany(x => x.Cameras).WithOne(x => x.Beqa)
                .HasForeignKey(x => x.BeqaId)
                .OnDelete(DeleteBehavior.Cascade);
        
          builder.HasMany(x => x.BeqaContacts).WithOne(x => x.Beqa)
                .HasForeignKey(x => x.BeqaId)
                .OnDelete(DeleteBehavior.Cascade);
        
           builder.HasMany(x => x.BeqaCoordinatesCollection).WithOne(x => x.Beqa)
                .HasForeignKey(x => x.BeqaId)
                .OnDelete(DeleteBehavior.Cascade);

           builder.HasMany(x => x.BeqaTagTypes).WithMany(x => x.Beqas);

            builder.HasMany(x => x.PersonBeqas).WithOne(x => x.Beqa)
                .HasForeignKey(x => x.BeqaId)
                .OnDelete(DeleteBehavior.Cascade);

              builder.HasMany(x => x.Medias).WithOne(x => x.Beqa)
                .HasForeignKey(x => x.BeqaId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}
