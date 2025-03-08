using Diiage.Memoire.Back.Domain.Entities.Tanks.AllowedVariables;
using Diiage.Memoire.Back.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.Tanks.AllowedVariables;

public class AllowedVariableConfiguration : IEntityTypeConfiguration<AllowedVariableDao>
{
    public void Configure(EntityTypeBuilder<AllowedVariableDao> builder)
    {
        builder.ToTable(TablesName.AllowedVariableTables.AllowedVariables);

        builder.HasKey(b => b.Id);

        builder.HasOne(b => b.Variable)
            .WithMany()
            .HasForeignKey(e => e.VariableId);

        builder.HasDiscriminator(t => t.Kind)
            .HasValue<AllowedVariableNumericDao>(VariableKind.Numeric)
            .HasValue<AllowedVariableStringDao>(VariableKind.String)
            .HasValue<AllowedVariableBooleanDao>(VariableKind.Boolean);
        
        builder.HasIndex(t => t.Kind);
    }
}