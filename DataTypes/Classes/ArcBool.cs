using Arc6.Compiler;

namespace Arc6.Types;

/// <summary>
/// Represents a true/false state
/// </summary>
public class ArcBool : Variable
{
    bool Value;

	public CodeReturn Compile() => Value?"yes":"no";
}
