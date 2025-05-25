namespace DesafioRelatorio;

public class RelatorioCsv : IRelatorio
{
    public void Gerar(string conteudo)
    {
        Console.WriteLine($"[CSV] Relatório gerado com o conteúdo: {conteudo}");
    }
}