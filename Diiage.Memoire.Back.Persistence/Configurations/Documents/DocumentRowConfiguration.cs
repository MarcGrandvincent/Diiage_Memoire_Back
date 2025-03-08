using Diiage.Memoire.Back.Domain.Entities.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.Documents;

public class DocumentRowConfiguration : IEntityTypeConfiguration<DocumentRowDao>
{
    public void Configure(EntityTypeBuilder<DocumentRowDao> builder)
    {
        builder.ToTable(TablesName.DocumentsTables.DocumentRows);

        builder.HasKey(b => b.Id);
        
        builder.Property(b => b.Price);

        builder.HasOne(b => b.Tank)
            .WithMany()
            .HasForeignKey(b => b.TankId);
    }
}