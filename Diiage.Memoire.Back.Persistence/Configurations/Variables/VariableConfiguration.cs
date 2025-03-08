using Diiage.Memoire.Back.Domain.Entities.Variables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.Variables;

public class VariableConfiguration : IEntityTypeConfiguration<VariableDao>
{
    public void Configure(EntityTypeBuilder<VariableDao> builder)
    {
        builder.ToTable(TablesName.VariableTables.Variables);

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Name);
        
        builder.Property(b => b.Kind);
    }
}