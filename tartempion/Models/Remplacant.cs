using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class Remplacant
{
    public int IdRemplacant { get; set; }

    public int IdMedecin { get; set; }

    public bool EstRemplacant { get; set; }

    public int IdRapport { get; set; }

    public virtual Medecin IdMedecinNavigation { get; set; } = null!;
}
