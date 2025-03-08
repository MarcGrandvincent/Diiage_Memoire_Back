using Diiage.Memoire.Back.Domain.Entities.ThirdParties;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.ThirdParties;

public class ThirdPartyConfiguration : IEntityTypeConfiguration<ThirdPartyDao>
{
    public void Configure(EntityTypeBuilder<ThirdPartyDao> builder)
    {
        builder.ToTable(TablesName.ThirdPartiesTables.ThirdParties);

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Name);
        
        builder.Property(b => b.ImageUrl);
    }
}