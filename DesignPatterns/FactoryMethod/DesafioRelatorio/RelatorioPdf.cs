namespace DesafioRelatorio;

public class RelatorioPdf : IRelatorio
{
    public void Gerar(string conteudo)
    {
        Console.WriteLine($"[PDF] Relatório gerado com o conteúdo: {conteudo}");
    }
}