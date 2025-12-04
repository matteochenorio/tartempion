using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class Rapport
{
    public int IdRapport { get; set; }

    public DateOnly? DateRapport { get; set; }

    public int IdMotif { get; set; }

    public string? Bilan { get; set; }

    public string IdVisiteur { get; set; } = null!;

    public int IdMedecin { get; set; }

    public bool EstRemplacant { get; set; }

    public int AvisMedecin { get; set; }

    public TimeOnly HeurePrevue { get; set; }

    public TimeOnly HeureReelle { get; set; }

    public int DureeVisite { get; set; }

    public string IdMedicament { get; set; } = null!;

    public virtual Medecin IdMedecinNavigation { get; set; } = null!;

    public virtual Motif IdMotifNavigation { get; set; } = null!;

    public virtual Visiteur IdVisiteurNavigation { get; set; } = null!;

    public virtual ICollection<Offrir> Offrirs { get; set; } = new List<Offrir>();

    public virtual ICollection<Medicament> IdMedicaments { get; set; } = new List<Medicament>();
}
