using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class Remplacant
{
    public int IdRemplacant { get; set; }

    public int IdMedecin { get; set; }

    public bool EstRemplacant { get; set; }

    public DateOnly? DateDebut { get; set; }

    public DateOnly? DateFin { get; set; }

    public virtual Medecin IdMedecinNavigation { get; set; } = null!;
}
