using Diiage.Memoire.Back.Domain.Entities.Units;

namespace Diiage.Memoire.Back.Domain.Entities.Tanks.AllowedVariables;

public class AllowedVariableNumericDao : AllowedVariableDao
{
    public int Value { get; set; }
    public int UnitId { get; set; }
    public UnitDao Unit { get; set; }
}