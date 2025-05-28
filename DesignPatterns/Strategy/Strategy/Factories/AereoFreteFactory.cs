using Strategy.Classes;

namespace Strategy.Factories;

public class AereoFreteFactory : FreteFactory
{
    public override ICalculadoraFrete Criar() => new AereoFrete();
}