namespace DesafioRelatorio;

public class RelatorioCsvFactory : RelatorioFactory
{
    public override IRelatorio CriarRelatorio() => new RelatorioCsv();
}