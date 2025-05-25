namespace DesafioRelatorio;

public class RelatorioExcel : IRelatorio
{
    public void Gerar(string conteudo)
    {
        Console.WriteLine($"[Excel] Relatório gerado com o conteúdo: {conteudo}");
    }
}