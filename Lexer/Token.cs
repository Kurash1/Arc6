using Arc6.Parser;

namespace Arc6.Lexer;
public enum TokenType
{
    IDENTIFIER,
    KEYWORD,
    SEPERATOR,
    OPERATOR,
    LITERAL
}
#pragma warning disable CS0660
#pragma warning disable CS0661
public struct Token : IPossibleVariable
#pragma warning restore CS0661
#pragma warning restore CS0660
{
    public TokenType type;
    public string value;
    public Token(TokenType type, string value)
    {
        this.type = type;
        this.value = value;
    }
    public bool Match(string match)
    {
        return match == $"{type}:{value}";
    }
    public override readonly string ToString() => value;

    // The reason I don't allow strings to be used, is because this should only be used for common seperators or operators, otherwise you should be usinc the Match method.
    public static bool operator ==(Token left, char right) => left.value == right.ToString();
    public static bool operator !=(Token left, char right) => left.value != right.ToString();

}