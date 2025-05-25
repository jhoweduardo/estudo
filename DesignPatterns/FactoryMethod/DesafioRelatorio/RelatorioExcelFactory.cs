namespace DesafioRelatorio;

public class RelatorioExcelFactory : RelatorioFactory
{
    public override IRelatorio CriarRelatorio() => new RelatorioExcel();
}