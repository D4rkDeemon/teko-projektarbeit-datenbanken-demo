using Projektarbeit_DemoFrontend.DBContext;
using Projektarbeit_DemoFrontend.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit_DemoFrontend.Service
{
    public class CustomerService
    {

        public List<Customer> All()
        {
            using(var db = new LittleFlowerContext())
            {
                return db.Customer.ToList();
            }
        }
    }
}
