using Diiage.Memoire.Back.Domain.Entities.Documents;

namespace Diiage.Memoire.Back.Domain.Entities.ThirdParties;

public class ThirdPartyDao
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public IEnumerable<DocumentDao> Documents { get; set; }
}