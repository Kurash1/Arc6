using Arc6.Lexer;
using Arc6.Parser;
using Arc6.Types;
using System.Linq;
using System.Text;

namespace Arc6.Compiler;

public class ScopeData
{
	readonly private ScopeData? parent;
	readonly private Dictionary<string, Variable> variables;

    public ScopeData(ScopeData? Parent = null)
    {
        parent = Parent;
        variables = [];
    }

    public bool HasVariable(List<Token> locator)
    {
        throw new NotImplementedException();
    }
    public Variable GetVariable(List<Token> locator)
    {
        throw new NotImplementedException();
    }
}
public static class Compiler
{
    public static ScopeData global = new();

    public static string Compile(Block code) => Compile(code, global);
    public static string Compile(Block code, ScopeData data)
    {
        List<string> result = new();

        foreach (IStatement statement in code.statements)
        {
            if (statement is Scope scope)
            {
                ScopeData child = new(data);
                string res = Compile(scope.block, child);

                result.Append(scope.scope.ToString());
                result.Append("=");
                result.Append("{");
                result.Append(res);
                result.Append("}");
            }
            else if (statement is FunctionDefinition functionDefinition)
            {
                throw new NotImplementedException();
            }
            else if (statement is FunctionCall functionCall)
            {
                throw new NotImplementedException();
            }
            else if (statement is VariableCall variableCall)
            {
                Variable variable = data.GetVariable(variableCall.locator);
                throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        return string.Join(' ', result);
    }
}