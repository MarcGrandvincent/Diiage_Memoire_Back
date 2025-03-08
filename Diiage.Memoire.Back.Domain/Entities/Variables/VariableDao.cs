using Diiage.Memoire.Back.Domain.Enums;

namespace Diiage.Memoire.Back.Domain.Entities.Variables;

public class VariableDao
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public VariableKind Kind { get; set; }
}