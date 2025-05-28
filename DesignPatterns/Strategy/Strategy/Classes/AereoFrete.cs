namespace Strategy.Classes;

public class AereoFrete : ICalculadoraFrete
{
    public decimal Calcular(decimal peso)
    {
        return peso * 3.0m + 20;
    }
}