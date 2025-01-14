using Arc6.Lexer;
using Arc6.Parser;
using Arc6.Compiler;

string file = File.ReadAllText("test.txt");

List<Token> tokens = new Lexer(file).Analyze();

Block tree = new Parser(tokens).Analyze();

string compile = Compiler.Compile(tree);

Console.WriteLine(compile);

return 0;