using Diiage.Memoire.Back.Domain.Entities.ThirdParties;

namespace Diiage.Memoire.Back.Domain.Entities.Documents;

public class DocumentDao
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public DateOnly Date { get; set; } 
    public int ThirdPartyId { get; set; }
    public ThirdPartyDao ThirdParty { get; set; }
    public IEnumerable<DocumentRowDao> Rows { get; set; } 
}