using System.ComponentModel.DataAnnotations;

namespace tartempion.Models
{
    public class Presentation
    {
        public int IdRapport { get; set; }
        public string IdMedicament { get; set; }

        public virtual Rapport Rapport { get; set; }
        public virtual Medicament Medicament { get; set; }
        //public virtual ICollection<Presentation> Presentations { get; set; } = new List<Presentation>();
    }
}