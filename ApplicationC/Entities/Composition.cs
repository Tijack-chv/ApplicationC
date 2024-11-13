using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Composition
{
    public int Idjury { get; set; }

    public int Idhackathon { get; set; }

    public DateTime DateConvocation { get; set; }

    public virtual Hackathon IdhackathonNavigation { get; set; } = null!;

    public virtual Jury IdjuryNavigation { get; set; } = null!;
}
