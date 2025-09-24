using Projektarbeit_DemoFrontend.DBContext;
using Projektarbeit_DemoFrontend.Entity;

namespace Projektarbeit_DemoFrontend.Service
{
    public class ReportService
    {
        public List<Report> All()
        {
            using(var db = new LittleFlowerContext())
            {
                return db.Report.ToList();
            }
        }

        public void Save(Report report)
        {
            using(var db = new LittleFlowerContext())
            {
                db.Report.Add(report);
                db.SaveChanges();
            }
        }
    }
}
