using Arc6.Compiler;

namespace Arc6.Types;

/// <summary>
/// Represents a whole number.
/// </summary>
public class ArcInt : Number, Variable
{
    int Value;

	public CodeReturn Compile() => $"{Value:0}";
}
