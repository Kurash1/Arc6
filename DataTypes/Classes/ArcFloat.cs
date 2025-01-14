using Arc6.Compiler;

namespace Arc6.Types;

/// <summary>
/// Represents a decimal number.
/// </summary>
public class ArcFloat : Number, Variable
{
    decimal Value;

	public CodeReturn Compile() => $"{Value:0.000}";
}
