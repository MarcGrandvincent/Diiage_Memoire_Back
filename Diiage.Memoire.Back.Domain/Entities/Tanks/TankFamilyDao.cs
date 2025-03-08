namespace Diiage.Memoire.Back.Domain.Entities.Tanks;

public class TankFamilyDao
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? IconName { get; set; }
    public int ParentFamilyId { get; set; }
    public TankFamilyDao ParentFamily { get; set; }
    public ICollection<TankFamilyDao> ChildrenFamilies { get; set; }
    public IEnumerable<TankDao> Tanks { get; set; }
}