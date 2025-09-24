using System.ComponentModel.DataAnnotations.Schema;

namespace Projektarbeit_DemoFrontend.Entity
{
    [Table("Debitor")]
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Column("Mail")]
        public string Email { get; set; }

        [Column("Telefon")]
        public string Phone { get; set; }

        [Column("Strasse")]
        public string Address { get; set; }

        [Column("Ort")]
        public string City { get; set; }

        [Column("Plz")]
        public string Zip { get; set; }

        [Column("Land")]
        public string Country { get; set; }

        [Column("Erstellungsdatum")]
        public DateTime CreationDate { get; set; }
    }
}
