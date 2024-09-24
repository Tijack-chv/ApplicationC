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

        SousFormulaire sousF;

        public FormHome()
        {
            InitializeComponent();

            administrateur = new Administrateur();
            labelAdmin.Visible = false;

            sousF = new(panelAffichage);
            sousF.openChildForm(new FormAccueil(true));
            buttonAffiche(false);
        }

        public FormHome(Administrateur admin)
        {
            InitializeComponent();
            administrateur = admin;
            sousF = new(panelAffichage);
            labelAdmin.Text = administrateur.Prenom + " " + administrateur.Nom;
            sousF.openChildForm(new FormAccueil(true));
            buttonAffiche(false);
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormAccueil(false));
        }

        private void buttonAffiche(bool test)
        {
            buttonAbout.Visible = test;
            buttonEquipe.Visible = test;
            buttonHackathon.Visible = test;
            buttonQuitter.Visible = test;
            buttonSettings.Visible = test;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //size panelLeft en grand : 122; 462
            //size button en grand : 122; 52
            if (buttonSettings.Visible == true) { 
                buttonAffiche(false);
            } else { 
                buttonAffiche(true);
            }
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormAccueil(true));
        }

        private void buttonHackathon_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormMenuHackathon());
        }

        private void buttonEquipe_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormMenuMembreEquipe());
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {

        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormParamètre(administrateur));
        }
    }
}
