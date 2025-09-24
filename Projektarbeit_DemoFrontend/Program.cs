using Projektarbeit_DemoFrontend.Controller;
using Projektarbeit_DemoFrontend.DBContext;
using System.Data.Entity;

namespace Projektarbeit_DemoFrontend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // stop complaining because of missing tables (dev only)
            Database.SetInitializer<LittleFlowerContext>(null);

            // Start demo
            DemoController demoController = new();            
        }
    }
}
