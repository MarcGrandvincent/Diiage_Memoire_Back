using Diiage.Memoire.Back.Domain.Entities.Tanks.AllowedVariables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.Tanks.AllowedVariables;

public class AllowedVariableBooleanConfiguration : IEntityTypeConfiguration<AllowedVariableBooleanDao>
{
    public void Configure(EntityTypeBuilder<AllowedVariableBooleanDao> builder)
    {
        builder.Property(b => b.Value);
    }
}