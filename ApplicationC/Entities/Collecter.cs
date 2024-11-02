using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Collecter
{
    public int Idequipe { get; set; }

    public int Idadministrateur { get; set; }

    public DateTime Date { get; set; }

    public string? Commentaire { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Administrateur IdadministrateurNavigation { get; set; } = null!;

    public virtual Equipe IdequipeNavigation { get; set; } = null!;
}
