using Projektarbeit_DemoFrontend.Interface;
using Projektarbeit_DemoFrontend.Service;

namespace Projektarbeit_DemoFrontend.ReportBuilder
{
    internal class VendorReportBuilder : IReport
    {
        public const string ReportName = "ABC-Liste aller Lieferanten";

        private static StoredProcedureService _storedProcedureService = new StoredProcedureService();

        public static void GenerateReport(int TypeId)
        {
            _storedProcedureService.ExecuteProcedure("Auswertung_ABC-Liste_Lieferanten");
        }
    }
}
