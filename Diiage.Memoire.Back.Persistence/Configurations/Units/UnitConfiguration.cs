using Diiage.Memoire.Back.Domain.Entities.Units;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.Units;

public class VariableConfiguration : IEntityTypeConfiguration<UnitDao>
{
    public void Configure(EntityTypeBuilder<UnitDao> builder)
    {
        builder.ToTable(TablesName.UnitsTables.Units);

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Name);
        
        builder.Property(b => b.Code);
    }
}