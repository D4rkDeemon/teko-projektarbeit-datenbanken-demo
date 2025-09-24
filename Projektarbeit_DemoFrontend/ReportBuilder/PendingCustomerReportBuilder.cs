using Projektarbeit_DemoFrontend.Interface;
using Projektarbeit_DemoFrontend.Service;

namespace Projektarbeit_DemoFrontend.ReportBuilder
{
    internal class PendingCustomerReportBuilder : IReport
    {
        public const string ReportName = "Liste aller ausstehenden Kundenzahlungen";

        private static StoredProcedureService _storedProcedureService = new StoredProcedureService();

        public static void GenerateReport(int TypeId)
        {
            _storedProcedureService.ExecuteProcedure("Auswertung_Offene_Debitoren");
        }
    }
}
