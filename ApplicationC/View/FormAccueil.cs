using ApplicationC.Controller;
using ApplicationC.Entities;
using ApplicationC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ApplicationC
{
    public partial class FormAccueil : Form
    {
        List<Equipe> lesE;
        public FormAccueil(bool test)
        {
            InitializeComponent();
            panelDecoArret.BackColor = Color.FromArgb(120, 127, 127, 127);
            panelDecoArret.Visible = false;

            if (!test)
            {
                panelDecoArret.Location = new Point(440, 121);
                panelDecoArret.Visible = true;
            }
        }

        public FormAccueil(string demande)
        {
            InitializeComponent();
            panelDecoArret.Visible = false;

            if (demande == "demande")
            {
                lesE = ModeleEquipe.DemandeSuppression2FA();
                foreach (Equipe equipe in lesE)
                {
                    checkedListBoxDemande.Items.Add(equipe.Idequipe + ". " + equipe.Nomequipe);
                }
                buttonToutVerif.Visible = true;
                checkedListBoxDemande.Visible = true;
            }
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            panelDecoArret.Visible = false;
        }

        private void checkedListBoxDemande_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < lesE.Count)
            {
                int selectedIndex = e.Index;
                int idEquipe = lesE[selectedIndex].Idequipe;
                Equipe eq = ModeleMembreEquipe.RecupererEquipe(idEquipe);

                Suppression2FAMod(eq);
                if (ModeleEquipe.DemandeSuppression2FACount() > 0)
                {
                    //checkedListBoxDemande.Items.RemoveAt(e.Index);
                }
                else
                {
                    buttonToutVerif.Visible = false;
                    checkedListBoxDemande.Visible = false;
                }
            } else
            {
                MessageBox.Show("Indice invalide pour la sélection");
            }
        }

        private void buttonToutVerif_Click(object sender, EventArgs e)
        {
            foreach (Equipe eq in lesE)
            {
                Suppression2FAMod(eq);
            }
            buttonToutVerif.Visible = false;
            checkedListBoxDemande.Visible = false;
        }

        public void Suppression2FAMod(Equipe eq)
        {
            string subject;
            string body;

            if (ModeleEquipe.VerifSuppression2FA(eq.Idequipe))
            {
                subject = "Désactivation double authentification";
                body = "Bonjour, La demande de désactivation de la double authentification de votre équipe '" + eq.Nomequipe + "' a été accepté !";
            }
            else
            {
                subject = "Désactivation double authentification";
                body = "Bonjour, La demande de désactivation de la double authentification de votre équipe '" + eq.Nomequipe + "' a été annulé!\nle code était incorrect !";
            }
            List<Membre> membres = ModeleMembreEquipe.RecupererMembres(eq.Idequipe);
            List<string> dests = membres.Select(x => x.Email).ToList();
            dests.Add(eq.Login);
            Controleur.EmailSend(dests, subject, body);
        }
    }
}
