using Arc6.Compiler;

namespace Arc6.Types;

/// <summary>
/// Represents a set of conditions.
/// </summary>
class ArcTrigger : Variable
{
    List<ArcCondition> Conditions;

	public CodeReturn Compile()
	{
		throw new NotImplementedException();
	}
}
