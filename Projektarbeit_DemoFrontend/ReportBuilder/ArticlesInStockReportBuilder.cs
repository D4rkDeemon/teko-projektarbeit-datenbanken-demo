using Projektarbeit_DemoFrontend.Interface;
using Projektarbeit_DemoFrontend.Service;

namespace Projektarbeit_DemoFrontend.ReportBuilder
{
    public class ArticlesInStockReportBuilder: IReport
    {
        public const string ReportName = "ABC-Liste aller Artikel im Lager";

        private static StoredProcedureService _storedProcedureService = new StoredProcedureService();

        public static void GenerateReport(int TypeId)
        {
            _storedProcedureService.ExecuteProcedure("Auswertung_ABC-Liste_Artikel_pro_Lager");
        }
    }
}
