using Kurashi.Extensions;
using Arc6.Lexer;

namespace Arc6.Parser;

public class Parser
{
    List<Token> tokenList;
    private List<Token>.Enumerator enumerator;

    public Parser(List<Token> tokens)
    {
        tokenList = tokens;
        enumerator = tokenList.GetEnumerator();
    }

    public Block Analyze(int indent = 1)
    {
        List<IStatement> statements = [];

        while (enumerator.MoveNext())
        {
            top:
            // Seperators
            if (Current == '{')
                indent++;
            else if (Current == '}')
                indent--;

            // Keywords
            else if (Current.Match("KEYWORD:func"))
                statements.Add(KeywordFunc());

            else if (Current.Match("KEYWORD:any"))
                statements.Add(KeywordScopes());
            else if (Current.Match("KEYWORD:all"))
                statements.Add(KeywordScopes());
            else if (Current.Match("KEYWORD:none"))
                statements.Add(KeywordScopes());

            // Identifier Guessing
            else if (Current.type == TokenType.IDENTIFIER)
            {
                Token identifier = Current;

                if (!TryMove())
                {
                    VariableCall call = new(identifier);
                    statements.Add(call);
                }
                else
                {
                    Token next = Current;

                    // Function call
                    if (next == '(')
                    {
                        FunctionCall call = GetArguments(identifier);
                        statements.Add(call);
                    }
                    // Next is Unrelated, could be:
                    // - A Variable
                    else
                    {
                        VariableCall call = new(identifier);
                        statements.Add(call);
                        goto top;
                    }
                }
            }

            // Exit in internal blocks
            if (indent <= 0)
                break;
        }

        Block tree = new(statements);
        return tree;
    }
    private FunctionCall GetArguments(Token identifier)
    {
        Assert("(");
        List<Argument> arguments = [];

        do
        {
            ForceMove();
            if (Current == ')')
                break;
            Token? first = null;
            IPossibleVariable second;

            if (Current == '{')
            {
                second = GetBlock();
                goto end;
            }

            first = Current;
            ForceMove();

            if (Current == '=')
            {
                ForceMove();

                if (Current == '{')
                {
                    second = GetBlock();
                    ForceMove();
                }
                else
                    second = Current;
            }
            else
            {
                second = first;
                first = null;
            }

        end:
            Argument argument = new(first, second);
            arguments.Add(argument);
        } while (Current == ',');


        return new FunctionCall(identifier, arguments);
    }
    private Scope KeywordScopes()
    {
        Token scope = Current;
        Block block = GetBlock();

        return new(scope, block);
    }
    private FunctionDefinition KeywordFunc()
    {
        AssertNext("<");
        Token returnValue = GetNext();
        AssertNext(">");
        Token callIdentifier = GetNext();
        AssertNext("(");
        ForceMove();
        ArgumentList argumentList = new([]);
        while (Current.value != ")")
        {
            Token type = Current;
            Token id = GetNext();
            argumentList.list.Add(new(type, id));
            ForceMove();
        }
        Assert(")");
        AssertNext("=");
        Block executionBlock = GetBlock();

        return new(returnValue, callIdentifier, argumentList, executionBlock);
    }
    Block GetBlock()
    {
        return Analyze(0);
    }
    Token Current => enumerator.Current;
    Token GetNext()
    {
        ForceMove();
        return enumerator.Current;
    }
    void AssertNext(string value)
    {
        ForceMove();
        Assert(value);
    }
    void Assert(string value)
    {
        if (enumerator.Current.value != value)
            throw new Exception();
    }
    void ForceMove()
    {
        if (!enumerator.MoveNext())
            throw new IndexOutOfRangeException();
    }
    bool TryMove()
    {
        return enumerator.MoveNext();
    }
}