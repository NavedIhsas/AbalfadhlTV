using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbalfadhlTV.Persistence.EntitiesConfiguration.Beqa;

public class BeqaCoordinatesMapping : IEntityTypeConfiguration<Domain.BeqaAgg.BeqaCoordinates>
{
    public void Configure(EntityTypeBuilder<Domain.BeqaAgg.BeqaCoordinates> builder)
    {
        builder.ToTable("BeqaCoordinates", "beqa");
        builder.HasKey(x => x.Id);
    }

}