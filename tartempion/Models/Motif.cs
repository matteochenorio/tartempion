using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class Motif
{
    public int IdMotif { get; set; }

    public string? LibMotif { get; set; }

    public virtual ICollection<Rapport> Rapports { get; set; } = new List<Rapport>();
}
