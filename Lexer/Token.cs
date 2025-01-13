namespace Arc6.Lexer;
public enum TokenType
{
    IDENTIFIER,
    KEYWORD,
    SEPERATOR,
    OPERATOR,
    LITERAL
}
public struct Token
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
        string[] values = match.Split(':');
        return type.ToString() == values[0] && value == values[1];
    }
    public override readonly string ToString() => value;
}