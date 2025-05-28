using Strategy.Classes;

namespace Strategy.Factories;

public class CorreiosFreteFactory : FreteFactory
{
    public override ICalculadoraFrete Criar() => new CorreiosFrete();
}