namespace DesafioRelatorio;

public class RelatorioManager
{
    private static readonly object _lock = new object();
    private static RelatorioManager _instance;
    private IRelatorio _relatorio;

    public static RelatorioManager Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new RelatorioManager();
                
                return _instance;
            }
        }
    }
    
    public void ProcessarRelatorio(RelatorioFactory factory, string conteudo)
    {
        _relatorio = factory.CriarRelatorio();
        _relatorio.Gerar(conteudo);
    }
}