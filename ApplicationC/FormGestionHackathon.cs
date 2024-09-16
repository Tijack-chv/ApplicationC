﻿using ApplicationC.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationC
{
    public enum EtatGestion
    {
        Create, 
        Update
    }
    public partial class FormGestionHackathon : Form
    {
        private EtatGestion etat;
        public FormGestionHackathon(EtatGestion etat)
        {
            InitializeComponent();
            dtDebut.MinDate = DateTime.Now;
            dtFin.MinDate = DateTime.Now;
            dtFinInscription.MinDate = DateTime.Now;
            this.etat = etat;
        }

        private void dtDebut_ValueChanged(object sender, EventArgs e)
        {
            if (dtFin.Value < dtDebut.Value)
            {
                dtFin.Value = dtDebut.Value;
            }
            dtFin.MinDate = dtDebut.Value;
        }

        private void dtpFinInscription_ValueChanged(object sender, EventArgs e)
        {
            if (dtDebut.Value < dtFinInscription.Value)
            {
                dtDebut.Value = dtFinInscription.Value;
            }
            if (dtFin.Value < dtFinInscription.Value)
            {
                dtFin.Value = dtFinInscription.Value;
            }
            dtDebut.MinDate = dtFinInscription.Value;
            dtFin.MinDate = dtFinInscription.Value;
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void RemplirListeHackathons()
        {
            cbListe.ValueMember = "idhackathon";//permet de stocker l'identifiant
            cbListe.DisplayMember = "thematique";
            BSListeH.DataSource = ModeleHackathon.listeHackathonsParDateMin(DateTime.Now);
            cbListe.DataSource = BSListeH;
            cbListe.SelectedIndex = -1;
        }

        public void RemplirListeOrganisateurs()
        {
            cbOrganisateur.ValueMember = "idorganisateur";//permet de stocker l'identifiant
            cbOrganisateur.DisplayMember = "nom";
            BSOrganisateur.DataSource = ModeleOrganisateur.listeOrganisateurs();
            cbOrganisateur.DataSource = BSOrganisateur;
            cbOrganisateur.SelectedIndex = -1;
        }

        private void FormGestionHackathon_Load(object sender, EventArgs e)
        {
            RemplirListeOrganisateurs();
            if (etat == EtatGestion.Create) // cas etat create
            {
                labelAjoutHack.Text = "Ajout d'un Hackathon";
                BtnAction.Text = "AJOUTER";
                gbInfo.Visible = true;
                cbListe.Visible = false;

            }
            else // cas etat update
            {
                labelAjoutHack.Text = "Modification d'un Hackathon";
                BtnAction.Text = "MODIFIER";
                gbInfo.Visible = false;
                cbListe.Visible = true;
                RemplirListeHackathons();
            }
        }

        private void Annuler()
        {
            dtFinInscription.Value = DateTime.Now;
            dtDebut.Value = DateTime.Now;
            dtFin.Value = DateTime.Now;
            tbAffiche.Clear();
            tbLieu.Clear();
            tbVille.Clear();
            tbObjectifs.Clear();
            tbConditions.Clear();
            tbThematique.Clear();
            cbOrganisateur.SelectedIndex = -1;
            tbLieu.Focus();
            nudNbMaxEquipe.Value = 2;
        }

        private void ButtonAjout_Click(object sender, EventArgs e)
        {
            int idOrga = -1;
            int nbPlaceMaxEquipe = 2; // 2 étant le nombre minimum d'équipe pour initié un hackathon
            string lieu, ville, thematique, objectifs, conditions, affiche;
            DateTime dateDeb, dateFin, dateFinInscription;

            if (tbLieu.Text != "" && tbVille.Text != "" && tbThematique.Text != "")
            {
                // ajout possible si les champs lieu, ville et thématique au moins remplis
                lieu = tbLieu.Text;
                ville = tbVille.Text;
                thematique = tbThematique.Text;
                objectifs = tbObjectifs.Text;
                conditions = tbConditions.Text;
                affiche = tbAffiche.Text;
                dateDeb = dtDebut.Value;
                dateFin = dtFin.Value;
                dateFinInscription = dtFinInscription.Value;
                nbPlaceMaxEquipe = Convert.ToInt32(nudNbMaxEquipe.Value);
                if (cbOrganisateur.SelectedIndex != -1)
                {
                    idOrga = Convert.ToInt32(cbOrganisateur.SelectedValue.ToString());
                }

                if (etat == EtatGestion.Create) // cas de l'ajout
                {
                    if (ModeleHackathon.AjoutHackathon(lieu, ville, thematique, objectifs, conditions, affiche, dateDeb, dateFin, nbPlaceMaxEquipe, dateFinInscription, idOrga))
                    {
                        MessageBox.Show("Hackathon ajouté " + ModeleHackathon.RetourneDernierHackathonSaisi());
                        Annuler();
                    }
                }
                if (etat == EtatGestion.Update) // cas de la mise à jour
                {
                    Hackathon H = (Hackathon)BSListeH.Current;
                    if (ModeleHackathon.ModificationHackathon(H.Idhackathon, lieu, ville, thematique, objectifs, conditions, affiche, dateDeb, dateFin, nbPlaceMaxEquipe, dateFinInscription, idOrga))
                    {
                        MessageBox.Show("Hackathon modifié");
                        gbInfo.Visible = false;
                        cbListe.SelectedIndex = -1;
                        // Annuler();
                    }
                }

            }
            else
            {
                MessageBox.Show("Ajout impossible : Il faut saisir au moins le lieu, la ville et la thématique", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAjoutOrganisateur_Click(object sender, EventArgs e)
        {
            FormAjoutOrganisateur FAO = new FormAjoutOrganisateur();
            FAO.Show();

            // (System.Windows.Forms.Application.OpenForms["FormMenu"] as FormMenu).openChildForm(new FormAjoutOrganisateur());

        }

        private void BSListeH_CurrentChanged(object sender, EventArgs e)
        {
            // si un hackathon est sélectionné dans la liste des hackathons
            if (cbListe.SelectedIndex != -1)
            {
                // récupération de l'hackathon sélectionné
                Hackathon H = (Hackathon)BSListeH.Current;

                // mise à jour des champs de l'hackathon sélectionné
                tbThematique.Text = H.Thematique;
                tbLieu.Text = H.Lieu;
                tbVille.Text = H.Ville;
                tbObjectifs.Text = H.Objectifs;
                tbConditions.Text = H.Conditions;
                tbAffiche.Text = H.Affiche;


                dtFinInscription.MinDate = H.Datefininscription;
                dtFinInscription.Value = H.Datefininscription;

                if (dtFinInscription.Value < DateTime.Now && dtDebut.Value >= DateTime.Now)
                {
                    dtFinInscription.MinDate = new DateTime(2000, 01, 01, 00, 00, 00); // permet d'éviter les erreurs sur le premier parcours de la méthode 
                    // la date min ne conduira pas à changer les valeurs des dates ou autres
                    dtDebut.Enabled = false;
                    dtFin.Enabled = false;
                    dtFinInscription.Enabled = false;
                }
                else
                {
                    dtFinInscription.MinDate = H.Datefininscription;
                }

                dtDebut.MinDate = H.Datefininscription;
                dtDebut.Value = H.Dateheuredebuth;
                dtFin.MinDate = H.Dateheuredebuth;
                dtFin.Value = H.Dateheurefinh;
                nudNbMaxEquipe.Value = H.Nbplaceeqmax;

                if (H.Idorganisateur != null)
                {
                    cbOrganisateur.Text = H.IdorganisateurNavigation.Nom;
                }
                gbInfo.Visible = true;
            }
            else
                gbInfo.Visible = false;
        }

        private void CbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            BSListeH_CurrentChanged(sender, e);
        }
    }
}
