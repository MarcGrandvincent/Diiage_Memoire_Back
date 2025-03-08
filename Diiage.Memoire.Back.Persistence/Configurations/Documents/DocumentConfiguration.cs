using Diiage.Memoire.Back.Domain.Entities.Documents;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Diiage.Memoire.Back.Persistence.Configurations.Documents;

public class DocumentConfiguration : IEntityTypeConfiguration<DocumentDao>
{
    public void Configure(EntityTypeBuilder<DocumentDao> builder)
    {
        builder.ToTable(TablesName.DocumentsTables.Documents);

        builder.HasKey(b => b.Id);
        
        builder.Property(b => b.Code);
        
        builder.Property(b => b.Date);

        builder.HasOne(b => b.ThirdParty)
            .WithMany(b => b.Documents)
            .HasForeignKey(b => b.ThirdPartyId);
        
        builder.HasMany(b => b.Rows)
            .WithOne(b => b.Document)
            .HasForeignKey(e => e.Id);
    }
}