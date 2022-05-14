using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbalfadhlTV.Persistence.EntitiesConfiguration.Beqa;

public class BeqaTagTypeMapping : IEntityTypeConfiguration<Domain.BeqaAgg.BeqaTagType>
{
    public void Configure(EntityTypeBuilder<Domain.BeqaAgg.BeqaTagType> builder)
    {
        builder.ToTable("BeqaTagTypes", "beqa");
        builder.HasKey(x => x.Id);
    }

}