using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class Medicament
{
    public string IdMedicament { get; set; } = null!;

    public string NomCommercial { get; set; } = null!;

    public string IdFamille { get; set; } = null!;

    public string Composition { get; set; } = null!;

    public string Effets { get; set; } = null!;

    public string ContreIndications { get; set; } = null!;

    public virtual Famille IdFamilleNavigation { get; set; } = null!;

    public virtual ICollection<Offrir> Offrirs { get; set; } = new List<Offrir>();

    public virtual ICollection<Rapport> IdRapports { get; set; } = new List<Rapport>();
}
