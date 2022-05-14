using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbalfadhlTV.Persistence.EntitiesConfiguration.Beqa;

public class PersonBeqaMapping : IEntityTypeConfiguration<Domain.BeqaAgg.PersonBeqa>
{
    public void Configure(EntityTypeBuilder<Domain.BeqaAgg.PersonBeqa> builder)
    {
        builder.ToTable("PersonBeqas", "beqa");
        builder.HasKey(x => x.Id);
    }

}