using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class HistoriqueFrai
{
    public int IdHistoriqueFrais { get; set; }

    public double Montant { get; set; }

    public DateOnly DateDebut { get; set; }

    public DateOnly? DateFin { get; set; }

    public string IdFraisForfait { get; set; } = null!;

    public virtual FraisForfait IdFraisForfaitNavigation { get; set; } = null!;
}
