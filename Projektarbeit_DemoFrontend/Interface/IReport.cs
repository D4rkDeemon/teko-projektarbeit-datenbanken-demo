using Projektarbeit_DemoFrontend.Entity;

namespace Projektarbeit_DemoFrontend.Interface
{
    internal interface IReport
    {
        public static string ReportName { get; } = "Unbenannter Bericht";

        public static void GenerateReport(int TypeId)
        {
            throw new NotSupportedException("GenerateReport must be implemented in derived classes.");
        }
    }
}
