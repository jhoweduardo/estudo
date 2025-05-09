using Singleton;

Console.WriteLine("Qual seu nome?");
var nome = Console.ReadLine();

Console.WriteLine("Qual seu email?");
var email = Console.ReadLine();

var session = SessionManager.Instance;

session.IniciarSessao(nome, email);

session.ExibirSessao();