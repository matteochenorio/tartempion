using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class Etat
{
    public string Id { get; set; } = null!;

    public string? Libelle { get; set; }

    public virtual ICollection<Fichefrai> Fichefrais { get; set; } = new List<Fichefrai>();
}
