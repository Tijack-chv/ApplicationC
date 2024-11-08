using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Equipejury
{
    public int Idequipejury { get; set; }

    public string Details { get; set; } = null!;

    public virtual ICollection<Hackathon> Hackathons { get; set; } = new List<Hackathon>();

    public virtual ICollection<Jury> Idjuries { get; set; } = new List<Jury>();
}
