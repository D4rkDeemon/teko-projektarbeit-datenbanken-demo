using System.ComponentModel.DataAnnotations.Schema;

namespace Projektarbeit_DemoFrontend.Entity
{
    [Table("Auswertungslistentyp")]
    public class ReportType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
