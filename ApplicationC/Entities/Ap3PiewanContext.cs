﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace ApplicationC.Entities;

public partial class Ap3PiewanContext : DbContext
{
    public Ap3PiewanContext()
    {
    }

    public Ap3PiewanContext(DbContextOptions<Ap3PiewanContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrateur> Administrateurs { get; set; }

    public virtual DbSet<Collecter> Collecters { get; set; }

    public virtual DbSet<Equipe> Equipes { get; set; }

    public virtual DbSet<Hackathon> Hackathons { get; set; }

    public virtual DbSet<Inscrire> Inscrires { get; set; }

    public virtual DbSet<Jury> Juries { get; set; }

    public virtual DbSet<Membre> Membres { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<Organisateur> Organisateurs { get; set; }

    public virtual DbSet<Token> Tokens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=192.168.10.16;port=3306;user=ap3_piewan-4;password=C0hPzQMB;database=ap3_piewan", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.4.1-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Administrateur>(entity =>
        {
            entity.HasKey(e => e.Idadministrateur).HasName("PRIMARY");

            entity
                .ToTable("ADMINISTRATEUR")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_bin");

            entity.Property(e => e.Idadministrateur).HasColumnName("idadministrateur");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Motpasse)
                .HasMaxLength(255)
                .HasColumnName("motpasse");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("prenom");
        });

        modelBuilder.Entity<Collecter>(entity =>
        {
            entity.HasKey(e => new { e.Idequipe, e.Idadministrateur, e.Date })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

            entity
                .ToTable("COLLECTER")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.Idadministrateur, "collecter_idadministrateur_foreign");

            entity.Property(e => e.Idequipe).HasColumnName("idequipe");
            entity.Property(e => e.Idadministrateur).HasColumnName("idadministrateur");
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Commentaire)
                .HasColumnType("text")
                .HasColumnName("commentaire");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");

            entity.HasOne(d => d.IdadministrateurNavigation).WithMany(p => p.Collecters)
                .HasForeignKey(d => d.Idadministrateur)
                .HasConstraintName("collecter_idadministrateur_foreign");

            entity.HasOne(d => d.IdequipeNavigation).WithMany(p => p.Collecters)
                .HasForeignKey(d => d.Idequipe)
                .HasConstraintName("collecter_idequipe_foreign");
        });

        modelBuilder.Entity<Equipe>(entity =>
        {
            entity.HasKey(e => e.Idequipe).HasName("PRIMARY");

            entity.ToTable("EQUIPE");

            entity.HasIndex(e => e.Login, "ulogin").IsUnique();

            entity.Property(e => e.Idequipe).HasColumnName("idequipe");
            entity.Property(e => e.Lienprototype)
                .HasMaxLength(255)
                .HasColumnName("lienprototype");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Nomequipe)
                .HasMaxLength(255)
                .HasColumnName("nomequipe");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
        });

        modelBuilder.Entity<Hackathon>(entity =>
        {
            entity.HasKey(e => e.Idhackathon).HasName("PRIMARY");

            entity.ToTable("HACKATHON");

            entity.HasIndex(e => e.Idorganisateur, "hackathon_ibfk_1");

            entity.Property(e => e.Idhackathon).HasColumnName("idhackathon");
            entity.Property(e => e.Affiche)
                .HasColumnType("mediumblob")
                .HasColumnName("affiche");
            entity.Property(e => e.Conditions)
                .HasMaxLength(255)
                .HasColumnName("conditions");
            entity.Property(e => e.Datefininscription)
                .HasColumnType("datetime")
                .HasColumnName("datefininscription");
            entity.Property(e => e.Dateheuredebuth)
                .HasColumnType("datetime")
                .HasColumnName("dateheuredebuth");
            entity.Property(e => e.Dateheurefinh)
                .HasColumnType("datetime")
                .HasColumnName("dateheurefinh");
            entity.Property(e => e.Estarchive).HasColumnName("estarchive");
            entity.Property(e => e.Idorganisateur).HasColumnName("idorganisateur");
            entity.Property(e => e.Lieu)
                .HasMaxLength(128)
                .HasColumnName("lieu");
            entity.Property(e => e.Nbplaceeqmax).HasColumnName("nbplaceeqmax");
            entity.Property(e => e.Objectifs)
                .HasMaxLength(255)
                .HasColumnName("objectifs");
            entity.Property(e => e.Thematique)
                .HasMaxLength(128)
                .HasColumnName("thematique");
            entity.Property(e => e.Ville)
                .HasMaxLength(128)
                .HasColumnName("ville");

            entity.HasOne(d => d.IdorganisateurNavigation).WithMany(p => p.Hackathons)
                .HasForeignKey(d => d.Idorganisateur)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hackathon_ibfk_1");

            entity.HasMany(d => d.Idjuries).WithMany(p => p.Idhackathons)
                .UsingEntity<Dictionary<string, object>>(
                    "Composition",
                    r => r.HasOne<Jury>().WithMany()
                        .HasForeignKey("Idjury")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("COMPOSITION_ibfk_2"),
                    l => l.HasOne<Hackathon>().WithMany()
                        .HasForeignKey("Idhackathon")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("COMPOSITION_ibfk_1"),
                    j =>
                    {
                        j.HasKey("Idhackathon", "Idjury")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j.ToTable("COMPOSITION");
                        j.HasIndex(new[] { "Idjury" }, "idjury");
                        j.IndexerProperty<int>("Idhackathon").HasColumnName("idhackathon");
                        j.IndexerProperty<int>("Idjury").HasColumnName("idjury");
                    });
        });

        modelBuilder.Entity<Inscrire>(entity =>
        {
            entity.HasKey(e => new { e.Idhackathon, e.Idequipe })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("INSCRIRE");

            entity.HasIndex(e => e.Idequipe, "i_fk_inscrire_equipe1");

            entity.HasIndex(e => e.Idhackathon, "i_fk_inscrire_hackathon1");

            entity.Property(e => e.Idhackathon).HasColumnName("idhackathon");
            entity.Property(e => e.Idequipe).HasColumnName("idequipe");
            entity.Property(e => e.Commentaire)
                .HasColumnType("text")
                .HasColumnName("commentaire");
            entity.Property(e => e.Datedesinscription)
                .HasColumnType("datetime")
                .HasColumnName("datedesinscription");
            entity.Property(e => e.Dateinscription).HasColumnName("dateinscription");

            entity.HasOne(d => d.IdequipeNavigation).WithMany(p => p.Inscrires)
                .HasForeignKey(d => d.Idequipe)
                .HasConstraintName("inscrire_ibfk_2");

            entity.HasOne(d => d.IdhackathonNavigation).WithMany(p => p.Inscrires)
                .HasForeignKey(d => d.Idhackathon)
                .HasConstraintName("inscrire_ibfk_1");
        });

        modelBuilder.Entity<Jury>(entity =>
        {
            entity.HasKey(e => e.Idjury).HasName("PRIMARY");

            entity.ToTable("JURY");

            entity.HasIndex(e => e.Email, "indexEmailJury").IsUnique();

            entity.Property(e => e.Idjury).HasColumnName("idjury");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Nomjury)
                .HasMaxLength(50)
                .HasColumnName("nomjury");
            entity.Property(e => e.Prenomjury)
                .HasMaxLength(50)
                .HasColumnName("prenomjury");
        });

        modelBuilder.Entity<Membre>(entity =>
        {
            entity.HasKey(e => e.Idmembre).HasName("PRIMARY");

            entity.ToTable("MEMBRE");

            entity.HasIndex(e => e.Idequipe, "i_fk_membre_equipe1");

            entity.Property(e => e.Idmembre).HasColumnName("idmembre");
            entity.Property(e => e.Datenaissance)
                .HasColumnType("datetime")
                .HasColumnName("datenaissance");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Idequipe).HasColumnName("idequipe");
            entity.Property(e => e.Lienportfolio)
                .HasMaxLength(255)
                .HasColumnName("lienportfolio");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("prenom");
            entity.Property(e => e.Telephone)
                .HasMaxLength(128)
                .HasColumnName("telephone");

            entity.HasOne(d => d.IdequipeNavigation).WithMany(p => p.Membres)
                .HasForeignKey(d => d.Idequipe)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("membre_ibfk_2");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("migrations")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Batch).HasColumnName("batch");
            entity.Property(e => e.Migration1)
                .HasMaxLength(255)
                .HasColumnName("migration");
        });

        modelBuilder.Entity<Organisateur>(entity =>
        {
            entity.HasKey(e => e.Idorganisateur).HasName("PRIMARY");

            entity
                .ToTable("ORGANISATEUR")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_bin");

            entity.Property(e => e.Idorganisateur).HasColumnName("idorganisateur");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Nom)
                .HasMaxLength(128)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(128)
                .HasColumnName("prenom");
        });

        modelBuilder.Entity<Token>(entity =>
        {
            entity.HasKey(e => e.Uuid).HasName("PRIMARY");

            entity.ToTable("TOKEN");

            entity.HasIndex(e => e.Idequipe, "i_fk_token_equipe1");

            entity.Property(e => e.Uuid)
                .HasMaxLength(128)
                .HasColumnName("uuid");
            entity.Property(e => e.Idequipe).HasColumnName("idequipe");

            entity.HasOne(d => d.IdequipeNavigation).WithMany(p => p.Tokens)
                .HasForeignKey(d => d.Idequipe)
                .HasConstraintName("token_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
