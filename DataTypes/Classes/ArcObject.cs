namespace Arc6.Types;

/// <summary>
/// Represents a structured object.
/// </summary>
public class ArcObject : Variable
{
    Variable[] Variables;
    Blueprint blueprint;
    public class Blueprint
    {
        string[] Keys;
        Type[] Types;
    }
}