using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Log
{
    public int Idlog { get; set; }

    public int? Idadmin { get; set; }

    public int? Idequipe { get; set; }

    public string Description { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Administrateur? IdadminNavigation { get; set; }

    public virtual Equipe? IdequipeNavigation { get; set; }
}
