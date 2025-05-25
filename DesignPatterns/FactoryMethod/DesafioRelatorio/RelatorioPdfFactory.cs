namespace DesafioRelatorio;

public class RelatorioPdfFactory : RelatorioFactory
{
    public override IRelatorio CriarRelatorio() => new RelatorioPdf();
}