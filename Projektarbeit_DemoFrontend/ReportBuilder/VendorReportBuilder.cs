using Projektarbeit_DemoFrontend.Entity;
using Projektarbeit_DemoFrontend.Interface;

namespace Projektarbeit_DemoFrontend.ReportBuilder
{
    internal class VendorReportBuilder : IReport
    {
        public const string ReportName = "ABC-Liste aller Lieferanten";

        public static Report GenerateReport(int TypeId)
        {
            throw new NotImplementedException();
        }
    }
}
