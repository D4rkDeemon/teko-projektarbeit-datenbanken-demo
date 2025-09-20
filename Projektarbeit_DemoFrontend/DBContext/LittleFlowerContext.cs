using Projektarbeit_DemoFrontend.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit_DemoFrontend.DBContext
{
    public class LittleFlowerContext: DbContext
    {
        public DbSet<Article> Article { get; set; }
        public DbSet<Customer> Customer { get; set; }

        public DbSet<Vendor> Vendor { get; set; }

    }
}
