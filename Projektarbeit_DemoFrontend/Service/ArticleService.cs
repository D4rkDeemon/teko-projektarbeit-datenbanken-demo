using Projektarbeit_DemoFrontend.DBContext;
using Projektarbeit_DemoFrontend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
