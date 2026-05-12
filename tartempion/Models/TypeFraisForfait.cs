using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class TypeFraisForfait
{
    public int IdTypeFraisForfait { get; set; }

    public string Libelle { get; set; } = null!;

    public virtual ICollection<FraisForfait> FraisForfaits { get; set; } = new List<FraisForfait>();
}
