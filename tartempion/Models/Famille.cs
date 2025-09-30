using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class Famille
{
    public string IdFamille { get; set; } = null!;

    public string LibFamille { get; set; } = null!;

    public virtual ICollection<Medicament> Medicaments { get; set; } = new List<Medicament>();
}
