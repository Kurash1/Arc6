using Arc6.Compiler;

namespace Arc6.Types;

/// <summary>
/// Represents a set of  instructions.
/// </summary>
class ArcEffect : Variable
{
    List<ArcInstruction> Instructions;

	public CodeReturn Compile()
	{
		throw new NotImplementedException();
	}
}