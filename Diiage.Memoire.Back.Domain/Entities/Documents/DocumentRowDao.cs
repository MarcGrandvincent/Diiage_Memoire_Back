using Diiage.Memoire.Back.Domain.Entities.Tanks;

namespace Diiage.Memoire.Back.Domain.Entities.Documents;

public class DocumentRowDao
{
    public int Id { get; set; }
    public int Price { get; set; }
    public int DocumentId { get; set; }
    public DocumentDao Document { get; set; }
    public int TankId { get; set; }
    public TankDao Tank { get; set; }
}