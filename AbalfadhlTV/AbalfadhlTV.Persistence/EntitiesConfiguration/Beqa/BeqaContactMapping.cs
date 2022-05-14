using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AbalfadhlTV.Persistence.EntitiesConfiguration.Beqa;

public class BeqaContactMapping : IEntityTypeConfiguration<Domain.BeqaAgg.BeqaContact>
{
    public void Configure(EntityTypeBuilder<Domain.BeqaAgg.BeqaContact> builder)
    {
        builder.ToTable("BeqaContacts", "beqa");
        builder.HasKey(x => x.Id);
    }

}