namespace Diiage.Memoire.Back.Persistence.Configurations;

public static class TablesName
{
    public class TanksTables
    {
        public const string TankFamilies = nameof(TankFamilies);
        public const string Tanks = nameof(Tanks);
    }

    public class DocumentsTables
    {
        public const string Documents = nameof(Documents);
        public const string DocumentRows = nameof(DocumentRows);
    }

    public class ThirdPartiesTables
    {
        public const string ThirdParties = nameof(ThirdParties);
    }

    public class VariableTables
    {
        public const string Variables = nameof(Variables);
    }
    
    public class UnitsTables
    {
        public const string Units = nameof(Units);
    }
    
    public class AllowedVariableTables
    {
        public const string AllowedVariables = nameof(AllowedVariables);
        public const string AllowedVariablesBoolean = nameof(AllowedVariablesBoolean);
        public const string AllowedVariablesNumeric = nameof(AllowedVariablesNumeric);
        public const string AllowedVariablesString = nameof(AllowedVariablesString);
    }
}