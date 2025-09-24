using Projektarbeit_DemoFrontend.DBContext;
using Projektarbeit_DemoFrontend.Entity;

namespace Projektarbeit_DemoFrontend.Service
{
    public class ArticleService
    {
        public List<Article> All()
        {
            using(var db = new LittleFlowerContext())
            {
                return db.Article.ToList();
            }
        }
    }
}
