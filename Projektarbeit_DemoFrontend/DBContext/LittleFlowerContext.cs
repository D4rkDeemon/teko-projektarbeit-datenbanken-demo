using Projektarbeit_DemoFrontend.Entity;
using System.Data.Entity;

namespace Projektarbeit_DemoFrontend.DBContext
{
    public class LittleFlowerContext: DbContext
    {
        public DbSet<Article> Article { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Report> Report { get; set; }
        public DbSet<ReportType> ReportType { get; set; }
    }
}
