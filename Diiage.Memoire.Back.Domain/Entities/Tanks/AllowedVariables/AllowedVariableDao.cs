using Diiage.Memoire.Back.Domain.Entities.Variables;
using Diiage.Memoire.Back.Domain.Enums;

namespace Diiage.Memoire.Back.Domain.Entities.Tanks.AllowedVariables;

public abstract class AllowedVariableDao
{
    public int Id { get; set; }
    public int VariableId { get; set; }
    public VariableDao Variable { get; set; }
    
    public VariableKind Kind { get; set; }
}