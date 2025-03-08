using Diiage.Memoire.Back.Domain.Entities.Tanks.AllowedVariables;

namespace Diiage.Memoire.Back.Domain.Entities.Tanks;

public class TankDao
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? IconName { get; set; }
    public int TankFamilyId { get; set; }
    public TankFamilyDao TankFamily { get; set; }
    public IEnumerable<AllowedVariableDao> AllowedVariables { get; set; } 
}   