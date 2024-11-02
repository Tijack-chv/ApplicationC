using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Hackathon
{
    public int Idhackathon { get; set; }

    public DateTime Dateheuredebuth { get; set; }

    public DateTime Dateheurefinh { get; set; }

    public string Lieu { get; set; } = null!;

    public string Ville { get; set; } = null!;

    public string? Conditions { get; set; }

    public string? Thematique { get; set; }

    public byte[]? Affiche { get; set; }

    public string? Objectifs { get; set; }

    public int Nbplaceeqmax { get; set; }

    public DateTime Datefininscription { get; set; }

    public int? Idorganisateur { get; set; }

    public bool Estarchive { get; set; }

    public virtual Organisateur? IdorganisateurNavigation { get; set; }

    public virtual ICollection<Inscrire> Inscrires { get; set; } = new List<Inscrire>();

    public virtual ICollection<Jury> Idjuries { get; set; } = new List<Jury>();
}
