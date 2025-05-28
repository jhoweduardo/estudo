namespace Strategy;

public class FreteService
{
    private static readonly FreteService _instance = new FreteService();

    public static FreteService Instance => _instance;
    
    private FreteService() { }

    public decimal CalcularFrete(ICalculadoraFrete calculadoraFrete, decimal peso)
    {
        return calculadoraFrete.Calcular(peso);
    }
}