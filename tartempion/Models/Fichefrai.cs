using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class Fichefrai
{
    public string IdVisiteur { get; set; } = null!;

    public string Mois { get; set; } = null!;

    public int? NbJustificatifs { get; set; }

    public decimal? MontantValide { get; set; }

    public DateOnly? DateModif { get; set; }

    public string IdEtat { get; set; } = null!;

    public virtual Etat IdEtatNavigation { get; set; } = null!;

    public virtual Visiteur IdVisiteurNavigation { get; set; } = null!;

    public virtual ICollection<LigneFraisForfait> LigneFraisForfaits { get; set; } = new List<LigneFraisForfait>();

    public virtual ICollection<LigneFraisHorsForfait> LigneFraisHorsForfaits { get; set; } = new List<LigneFraisHorsForfait>();
}
