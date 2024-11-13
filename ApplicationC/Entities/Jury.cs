using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Jury
{
    public int Idjury { get; set; }

    public string Nomjury { get; set; } = null!;

    public string Prenomjury { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Composition> Compositions { get; set; } = new List<Composition>();
}
