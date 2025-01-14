using Arc6.Compiler;

namespace Arc6.Types;

/// <summary>
/// Represents a string of text.
/// </summary>
public class ArcString : Variable
{
    string Value;

	public CodeReturn Compile() => Value;
}
