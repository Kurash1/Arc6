using Kurashi.Extensions;

namespace Arc6.Lexer;
public partial class Lexer
{
    string file;

    public Lexer(string file)
    {
        this.file = file;
    }

    static Token? Tokenize(string value)
    {
        if (keywords.Contains(value))
            return new(TokenType.KEYWORD, value);
        if (float.TryParse(value, out _))
            return new(TokenType.LITERAL, value);
        if (!string.IsNullOrEmpty(value))
            return new(TokenType.IDENTIFIER, value);
        return null;
    }
    public List<Token> Analyze()
    {
        List<Token> tokens = [];

        string value = "";
        for (int i = 0; i < file.Length; i++)
        {
            char cur = file[i];

            if (operators.Contains(cur))
            {
                if (!string.IsNullOrEmpty(value))
                    AddToken(value);
                value = "";
                tokens.Add(new(TokenType.OPERATOR, cur.ToString()));
            }
            else if (seperator.Contains(cur))
            {
                if (!string.IsNullOrEmpty(value))
                    AddToken(value);
                value = "";
                tokens.Add(new(TokenType.SEPERATOR, cur.ToString()));
            }
            else if (cur.IsWhiteSpace())
            {
                AddToken(value);
                value = "";
            }
            else
            {
                value += cur;
            }
        }
        AddToken(value);

        return tokens;

        void AddToken(string v)
        {
            Token? t = Tokenize(v);
            if (t != null)
                tokens.Add((Token)t);
        }
    }
}