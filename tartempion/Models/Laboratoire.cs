using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class Laboratoire
{
    public int IdLabo { get; set; }

    public string? NomLabo { get; set; }

    public virtual ICollection<Visiteur> Visiteurs { get; set; } = new List<Visiteur>();
}
