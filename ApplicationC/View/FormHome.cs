﻿using ApplicationC.Controller;
using ApplicationC.Entities;
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
    public partial class FormHome : Form
    {
        Administrateur administrateur;
        bool sideBarExpend;
        SousFormulaire sousF;

        public FormHome()
        {
            InitializeComponent();
            administrateur = new Administrateur();
            labelAdmin.Text = "Chauveau Pierre";

            sousF = new(panelAffichage);
            sousF.openChildForm(new FormAccueil(true));

            buttonAffiche(false);
            panelVisible();
        }

        public FormHome(Administrateur admin)
        {
            InitializeComponent();
            administrateur = admin;
            sousF = new(panelAffichage);
            labelAdmin.Text = administrateur.Prenom + " " + administrateur.Nom;
            sousF.openChildForm(new FormAccueil(true));

            buttonAffiche(false);
            panelVisible();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);

            panelVisible();
            panelQuitter.Visible = true;
            sousF.openChildForm(new FormAccueil(false));
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);
            panelVisible();
        }

        private void buttonAffiche(bool test)
        {
            
            panelWest.Visible = test;
            buttonAbout.Visible = test;
            buttonEquipe.Visible = test;
            buttonHackathon.Visible = test;
            buttonQuitter.Visible = test;
            buttonSettings.Visible = test;
        }

        private void panelVisible()
        {
            panelAbout.Visible = false;
            panelSettings.Visible = false;
            panelQuitter.Visible = false;
            panelHome.Visible = false;
            panelHackathon.Visible = false;
            panelMembreEquipe.Visible = false;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);

            sousF.openChildForm(new FormAccueil(true));
            panelVisible();
            panelHome.Visible = true;
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            buttonAffiche(false);

            sousF.openChildForm(new FormAccueil(true));
        }

        private void buttonHackathon_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);

            sousF.openChildForm(new FormMenuHackathon());
            panelVisible();
            panelHackathon.Visible = true;
        }

        private void buttonEquipe_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);

            sousF.openChildForm(new FormMenuMembreEquipe());
            panelVisible();
            panelMembreEquipe.Visible = true;
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);

            panelVisible();
            panelAbout.Visible = true;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            buttonAffiche(!buttonSettings.Visible);

            sousF.openChildForm(new FormParamètre(administrateur));
            panelVisible();
            panelSettings.Visible = true;
        }

        private void panelAffichage_Click(object sender, EventArgs e)
        {
            if (panelWest.Visible)
            {
                buttonAffiche(true);
            }
        }
    }
}
