using Projektarbeit_DemoFrontend.DBContext;
using Projektarbeit_DemoFrontend.Entity;

namespace Projektarbeit_DemoFrontend.Service
{
    public class VendorService
    {
        public List<Vendor> All()
        {
            using(var db = new LittleFlowerContext())
            {
                return db.Vendor.ToList();
            }
        }
    }
}
