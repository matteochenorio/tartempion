using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class Specialite
{
    public string IdSpecialite { get; set; } = null!;

    public string LibSpecialite { get; set; } = null!;

    public virtual ICollection<Medecin> Medecins { get; set; } = new List<Medecin>();
}
