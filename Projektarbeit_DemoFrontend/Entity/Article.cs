using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit_DemoFrontend.Entities
{

    [Table("Artikel")]
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column("Beschreibung")]
        public string Description { get; set; }
        [Column("Preis")]
        public decimal Price {  get; set; }
    }
}
