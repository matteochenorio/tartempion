using System;
using System.Collections.Generic;

namespace tartempion.Models;

public partial class FraisForfait
{
    public string Id { get; set; } = null!;

    public string? Libelle { get; set; }

    public bool? Mensuel { get; set; }

    public int IdTypeFraisForfait { get; set; }

    public virtual ICollection<HistoriqueFrai> HistoriqueFrais { get; set; } = new List<HistoriqueFrai>();

    public virtual TypeFraisForfait IdTypeFraisForfaitNavigation { get; set; } = null!;

    public virtual ICollection<LigneFraisForfait> LigneFraisForfaits { get; set; } = new List<LigneFraisForfait>();
}
