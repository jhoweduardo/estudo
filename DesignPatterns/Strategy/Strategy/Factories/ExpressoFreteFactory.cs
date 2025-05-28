using Strategy.Classes;

namespace Strategy.Factories;

public class ExpressoFreteFactory : FreteFactory
{
    public override ICalculadoraFrete Criar() => new ExpressoFrete();
}