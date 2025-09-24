using Projektarbeit_DemoFrontend.Entity;
using Projektarbeit_DemoFrontend.Interface;

namespace Projektarbeit_DemoFrontend.ReportBuilder
{
    internal class PendingCustomerReportBuilder : IReport
    {
        public const string ReportName = "Liste aller ausstehenden Kundenzahlungen";

        public static Report GenerateReport(int TypeId)
        {
            throw new NotImplementedException();
        }
    }
}
