﻿using System;
using System.Collections.Generic;

namespace ApplicationC.Entities;

public partial class Equipe
{
    public int Idequipe { get; set; }

    public string Nomequipe { get; set; } = null!;

    public string? Lienprototype { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? Google2faSecret { get; set; }

    public string? CleSecret { get; set; }

    public string? CleSecretVerif { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<Collecter> Collecters { get; set; } = new List<Collecter>();

    public virtual ICollection<Inscrire> Inscrires { get; set; } = new List<Inscrire>();

    public virtual ICollection<Log> Logs { get; set; } = new List<Log>();

    public virtual ICollection<Membre> Membres { get; set; } = new List<Membre>();

    public virtual ICollection<Token> Tokens { get; set; } = new List<Token>();
}
