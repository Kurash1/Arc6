using Arc6.Lexer;
using Arc6.Parser;
string file = File.ReadAllText("test.txt");

List<Token> tokens = new Lexer(file).Analyze();

foreach (Token token in tokens)
{
    Console.WriteLine($"{token.type,-15} {token.value}");
}

Block tree = new Parser(tokens).Analyze();