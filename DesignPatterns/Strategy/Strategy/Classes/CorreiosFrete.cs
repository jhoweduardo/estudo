namespace Strategy.Classes;

public class CorreiosFrete : ICalculadoraFrete
{
    public decimal Calcular(decimal peso)
    {
        return peso * 1.2m + 10;
    }
}