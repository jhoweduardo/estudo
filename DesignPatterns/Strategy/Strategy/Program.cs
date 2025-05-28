using Strategy;
using Strategy.Factories;

var factory = new CorreiosFreteFactory();
var estrategia = factory.Criar();

var manager = FreteService.Instance;
var custo = manager.CalcularFrete(estrategia, 12.5m);

Console.WriteLine($"Custo do frete: {custo}");