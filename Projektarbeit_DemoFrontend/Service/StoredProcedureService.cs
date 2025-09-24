using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit_DemoFrontend.Service
{
    internal class StoredProcedureService
    {
        public void ExecuteProcedure(string procedureName)
        {
            using (var db = new DBContext.LittleFlowerContext())
            {
                var connection = db.Database.Connection;
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = procedureName;
                    command.CommandType = CommandType.StoredProcedure;

                    if (connection.State != ConnectionState.Open)
                        connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        // Process results if needed
                    }
                }
            }
        }
    }
}
