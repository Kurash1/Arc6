namespace Arc6.Types;

/// <summary>
/// Represents a specific value from a list of strings.
/// </summary>
public class ArcEnum : Variable
{
    int Value;
    Blueprint blueprint;
    public class Blueprint
    {
        string[] Values;
    }
}
