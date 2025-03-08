using Diiage.Memoire.Back.Domain.Entities.Tanks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.Tanks;

public class TankFamilyConfigurations : IEntityTypeConfiguration<TankFamilyDao>
{
    public void Configure(EntityTypeBuilder<TankFamilyDao> builder)
    {
        builder.ToTable(TablesName.TanksTables.TankFamilies);

        builder.HasKey(b => b.Id);

        builder.Property(b => b.Name);
        
        builder.Property(b => b.IconName);

        builder.HasOne(b => b.ParentFamily)
            .WithMany(p => p.ChildrenFamilies)
            .HasForeignKey(e => e.ParentFamilyId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}