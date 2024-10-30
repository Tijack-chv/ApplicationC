using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Inscrire
{
    public int Idhackathon { get; set; }

    public int Idequipe { get; set; }

    public DateOnly Dateinscription { get; set; }

    public DateTime? Datedesinscription { get; set; }

    public string? Commentaire { get; set; }

    public virtual Equipe IdequipeNavigation { get; set; } = null!;

    public virtual Hackathon IdhackathonNavigation { get; set; } = null!;
}
