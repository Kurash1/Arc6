using Arc6.Lexer;
using Arc6.Compiler;
using System.Collections.Generic;

namespace Arc6.Parser;

public interface IPossibleVariable { }
public struct Block : IPossibleVariable
{
    public List<IStatement> statements;

    public Block(List<IStatement> statements)
    {
        this.statements = statements;
    }
}
public interface IStatement { }
public struct Scope : IStatement
{
    public Token scope;
    public Block block;

    public Scope(Token scope, Block block)
    {
        this.scope = scope;
        this.block = block;
    }
}
public struct FunctionDefinition : IStatement
{
    public Token returnValue;
    public Token callIdentifier;
    public ArgumentList argumentList;
    public Block executionBlock;

    public FunctionDefinition(Token returnValue, Token callIdentifier, ArgumentList argumentList, Block executionBlock)
    {
        this.returnValue = returnValue;
        this.callIdentifier = callIdentifier;
        this.argumentList = argumentList;
        this.executionBlock = executionBlock;
    }
}
public struct ArgumentList
{
    public List<ArgumentDefinition> list;

    public ArgumentList(List<ArgumentDefinition> list)
    {
        this.list = list;
    }
}
public struct ArgumentDefinition
{
    public Token type;
    public Token id;

    public ArgumentDefinition(Token type, Token id)
    {
        this.type = type;
        this.id = id;
    }
}
public struct Argument
{
    public Token? id;
    public IPossibleVariable value;

    public Argument(Token? id, IPossibleVariable value)
    {
        this.id = id;
        this.value = value;
    }
}
public struct FunctionCall : IStatement
{
    public Token name;
    public List<Argument> arguments;

    public FunctionCall(Token name, List<Argument> arguments)
    {
        this.name = name;
        this.arguments = arguments;
    }
}
public struct VariableCall : IStatement
{
    public List<Token> locator;
    public VariableCall(List<Token> name)
    {
        locator = name;
    }
}