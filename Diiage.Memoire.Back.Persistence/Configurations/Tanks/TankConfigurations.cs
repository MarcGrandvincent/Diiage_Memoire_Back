using Diiage.Memoire.Back.Domain.Entities.Tanks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.Tanks;

public class TankConfiguration : IEntityTypeConfiguration<TankDao>
{
    public void Configure(EntityTypeBuilder<TankDao> builder)
    {
        builder.ToTable(TablesName.TanksTables.Tanks);

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Name);
        
        builder.Property(b => b.Code);
        
        builder.Property(b => b.Description);
        
        builder.Property(b => b.IconName);

        builder.HasOne(b => b.TankFamily)
            .WithMany(b => b.Tanks)
            .HasForeignKey(e => e.Id);
    }
}