using Arc6.Compiler;

namespace Arc6.Types;

/// <summary>
/// Represents all Compile Time Variables
/// </summary>
public interface Variable
{
	public CodeReturn Compile();
}
