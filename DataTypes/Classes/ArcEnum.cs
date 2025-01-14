using Arc6.Compiler;

namespace Arc6.Types;

/// <summary>
/// Represents a specific value from a list of strings.
/// </summary>
public class ArcEnum : Variable
{
    int Value;
    Blueprint blueprint;

	public CodeReturn Compile()
	{
		throw new NotImplementedException();
	}

	public class Blueprint
    {
        string[] Values;
    }
}
