using System.ComponentModel.DataAnnotations.Schema;

namespace Projektarbeit_DemoFrontend.Entity
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
