using System.ComponentModel.DataAnnotations.Schema;

namespace Projektarbeit_DemoFrontend.Entity
{
    [Table("Auswertungsliste")]
    public class Report
    {
        public int Id { get; set; }
        [Column("Auswertungslistentyp_Id")]
        public int ReportTypeId { get; set; }

        [Column("Erstellungsdatum")]
        public DateTime CreationDate { get; set; }

        [Column("Inhalt")]
        public string Content { get; set; }
    }
}
