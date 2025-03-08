using Diiage.Memoire.Back.Domain.Entities.Tanks.AllowedVariables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.Tanks.AllowedVariables;

public class AllowedVariableNumericConfiguration : IEntityTypeConfiguration<AllowedVariableNumericDao>
{
    public void Configure(EntityTypeBuilder<AllowedVariableNumericDao> builder)
    {
        builder.Property(b => b.Value);

        builder.HasOne(b => b.Unit)
            .WithMany()
            .HasForeignKey(b => b.UnitId);
    }
}