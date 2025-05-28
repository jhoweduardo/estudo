namespace Strategy.Classes;

public class ExpressoFrete : ICalculadoraFrete
{
    public decimal Calcular(decimal peso)
    {
        return peso * 2.0m + 15;
    }
}