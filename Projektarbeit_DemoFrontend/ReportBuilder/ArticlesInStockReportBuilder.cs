using Projektarbeit_DemoFrontend.Entity;
using Projektarbeit_DemoFrontend.Interface;
using Projektarbeit_DemoFrontend.Service;
using System.Text.Json;

namespace Projektarbeit_DemoFrontend.ReportBuilder
{
    public class ArticlesInStockReportBuilder: IReport
    {
        public const string ReportName = "ABC-Liste aller Artikel im Lager";

        public static Report GenerateReport(int TypeId)
        {
            ArticleService articleService = new ArticleService();
            var allArticles = articleService.All().OrderBy(q => q.Name).ToList();

            return new Report()
            {
                ReportTypeId = TypeId,
                CreationDate = DateTime.Now,
                Content = JsonSerializer.Serialize(allArticles)
            };
        }
    }
}
