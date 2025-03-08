using Diiage.Memoire.Back.Domain.Entities.Tanks.AllowedVariables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.Tanks.AllowedVariables;

public class AllowedVariableStringConfiguration : IEntityTypeConfiguration<AllowedVariableStringDao>
{
    public void Configure(EntityTypeBuilder<AllowedVariableStringDao> builder)
    {
        builder.Property(b => b.Value);
    }
}