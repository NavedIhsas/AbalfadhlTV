using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbalfadhlTV.Persistence.EntitiesConfiguration.Beqa;

public class CameraMapping : IEntityTypeConfiguration<Domain.BeqaAgg.Camera>
{
    public void Configure(EntityTypeBuilder<Domain.BeqaAgg.Camera> builder)
    {
        builder.ToTable("Cameras", "beqa");
        builder.HasKey(x => x.Id);
    }

}