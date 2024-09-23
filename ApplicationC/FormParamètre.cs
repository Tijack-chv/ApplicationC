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
    public partial class FormParamètre : Form
    {
        Administrateur administrateur = new();
        //location panel pour affichage : 172; 52
        public FormParamètre(Administrateur admin)
        {
            InitializeComponent();
            administrateur = admin;
            progressBarMdp.Value = 1;
            panelMdp.Visible = false;
            panelInfoPers.Visible = false;
        }

        private void motDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInfoPers.Visible = false;
            panelInfoPers.Location = new Point(420, 52);
            panelMdp.Visible = true;
        }

        private void informationsPersonnelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMdp.Visible = false;
            panelInfoPers.Location = new Point(172, 52);
            panelInfoPers.Visible = true;
            textBoxEmail.Text = administrateur.Email;
            textBoxFirstName.Text = administrateur.Nom;
            textBoxName.Text = administrateur.Prenom;
        }

        #region Placeholder
        private void textBoxAncienMdp_Enter(object sender, EventArgs e)
        {
            if (textBoxAncienMdp.Text == "mot de passe")
            {
                textBoxAncienMdp.Text = "";
            }
        }

        private void textBoxAncienMdp_Leave(object sender, EventArgs e)
        {
            if (textBoxAncienMdp.Text == "")
            {
                textBoxAncienMdp.Text = "mot de passe";
            }
        }

        private void textBoxNvMdp_Enter(object sender, EventArgs e)
        {
            if (textBoxNvMdp.Text == "mot de passe")
            {
                textBoxNvMdp.Text = "";
            }
        }

        private void textBoxNvMdp_Leave(object sender, EventArgs e)
        {
            if (textBoxNvMdp.Text == "")
            {
                textBoxNvMdp.Text = "mot de passe";
            }
        }

        private void textBox2NvMdp_Enter(object sender, EventArgs e)
        {
            if (textBox2NvMdp.Text == "mot de passe")
            {
                textBox2NvMdp.Text = "";
            }
        }

        private void textBox2NvMdp_Leave(object sender, EventArgs e)
        {
            if (textBox2NvMdp.Text == "")
            {
                textBox2NvMdp.Text = "mot de passe";
            }
        }
        #endregion

        private void buttonValiderMdp_Click(object sender, EventArgs e)
        {
            if (textBoxAncienMdp.Text == "" || textBoxAncienMdp.Text == "mot de passe" || textBoxNvMdp.Text == "" || textBoxNvMdp.Text == "mot de passe" || textBox2NvMdp.Text == "" || textBox2NvMdp.Text == "mot de passe")
            {
                MessageBox.Show("Vous devez saisir tous les champs présentés !");
            }
            else
            {
                if (textBoxNvMdp.Text != textBox2NvMdp.Text)
                {
                    MessageBox.Show("Le nouveau mot de passe n'est pas le même que la vérification !");
                }
                else
                {
                    if (textBoxNvMdp.Text.Length < 8)
                    {
                        MessageBox.Show("Le nouveau mot de passe n'a pas la sécurité nécessaire pour être modifié !");
                    }
                    else
                    {
                        if (ModeleAdministrateur.ModificationMdpAdmin(administrateur.Email, textBoxNvMdp.Text))
                        {
                            MessageBox.Show("Mot de passe modifié !");
                        }
                    }
                }
            }
        }

        private void buttonAnnulerMdp_Click(object sender, EventArgs e)
        {
            panelMdp.Visible = false;
        }

        private void buttonValiderInfoPers_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnnulerInfoPers_Click(object sender, EventArgs e)
        {
            panelInfoPers.Visible = false;
        }

        private void textBoxNvMdp_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNvMdp.Text != "mot de passe")
            {
                if (textBoxNvMdp.Text.Length >= 6)
                {
                    if (textBoxNvMdp.Text.Length >= 8)
                    {
                        if (textBoxNvMdp.Text.Length >= 10)
                        {
                            if (textBoxNvMdp.Text.Length >= 12)
                            {
                                progressBarMdp.Value = 10;
                            }
                            else { progressBarMdp.Value = 8; }
                        }
                        else { progressBarMdp.Value = 5; }
                    }
                    else { progressBarMdp.Value = 3; }
                }
                else { progressBarMdp.Value = 1; }
            }
        }

        private void labelShow_Click(object sender, EventArgs e)
        {
            if (labelShow.Text == "Show")
            {
                labelShow.Text = "Hide";
                textBoxAncienMdp.PasswordChar = '\0';
                textBoxNvMdp.PasswordChar = '\0';
                textBox2NvMdp.PasswordChar = '\0';
            }
            else
            {
                labelShow.Text = "Show";
                textBoxAncienMdp.PasswordChar = '*';
                textBoxNvMdp.PasswordChar = '*';
                textBox2NvMdp.PasswordChar = '*';
            }
        }
    }
}
