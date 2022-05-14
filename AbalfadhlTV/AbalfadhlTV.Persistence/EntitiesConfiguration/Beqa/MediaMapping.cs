using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbalfadhlTV.Persistence.EntitiesConfiguration.Beqa;

public class MediaMapping : IEntityTypeConfiguration<Domain.BeqaAgg.Media>
{
    public void Configure(EntityTypeBuilder<Domain.BeqaAgg.Media> builder)
    {
        builder.ToTable("Medias", "beqa");
        builder.HasKey(x => x.Id);
    }

}