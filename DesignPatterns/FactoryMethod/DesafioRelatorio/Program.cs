using DesafioRelatorio;

var manager = RelatorioManager.Instance;

manager.ProcessarRelatorio(new RelatorioPdfFactory(), "Dados do mês de abril");
manager.ProcessarRelatorio(new RelatorioExcelFactory(), "Planilha de vendas");
manager.ProcessarRelatorio(new RelatorioCsvFactory(), "Exportação simples");