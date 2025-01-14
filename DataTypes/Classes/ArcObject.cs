using Arc6.Compiler;

namespace Arc6.Types;

/// <summary>
/// Represents a structured object.
/// </summary>
public class ArcObject : Variable
{
    Variable[] Variables;
    Blueprint blueprint;

	public CodeReturn Compile()
	{
		throw new NotImplementedException();
	}

	public class Blueprint
    {
        string[] Keys;
        Type[] Types;
    }
}