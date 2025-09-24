using Projektarbeit_DemoFrontend.DBContext;
using Projektarbeit_DemoFrontend.Entity;

namespace Projektarbeit_DemoFrontend.Service
{
    public class ReportTypeService
    {
        public List<ReportType> All()
        {
            using(var db = new LittleFlowerContext())
            {
                return db.ReportType.ToList();
            }
        }
    }
}
