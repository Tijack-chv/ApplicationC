using ApplicationC.Entities;
using ApplicationC.Model;
using ApplicationC.View;
using Org.BouncyCastle.Asn1.Cmp;
using OtpNet;
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
    public partial class FormAdminConnexion : Form
    {

        public FormAdminConnexion()
        {
            InitializeComponent();
            labelErreurEmail.Visible = false;
            labelErreurMdp.Visible = false;
        }

        #region PlaceHolder

        private void textBoxMdp_Enter(object sender, EventArgs e)
        {
            if (textBoxMdp.Text == "password")
            {
                textBoxMdp.Text = "";
            }
        }

        private void textBoxMail_Enter(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "email")
            {
                textBoxMail.Text = "";
            }
        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "")
            {
                textBoxMail.Text = "email";
            }
        }

        private void textBoxMdp_Leave(object sender, EventArgs e)
        {
            if (textBoxMdp.Text == "")
            {
                textBoxMdp.Text = "password";
            }
        }

        #endregion

        #region labelShow
        private void labelShow_Click(object sender, EventArgs e)
        {
            if (textBoxMdp.PasswordChar == '*')
            {
                textBoxMdp.PasswordChar = '\0';
                labelShow.Text = "Hide";
            }
            else
            {
                textBoxMdp.PasswordChar = '*';
                labelShow.Text = "Show";

            }
        }
        #endregion

        private void buttonConnecter_Click(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "" || textBoxMdp.Text == "" || textBoxMail.Text == "email" || textBoxMdp.Text == "password") //revoir si verif de l'adresse mail et du nombre de caractère dans le mdp
            {
                if (textBoxMail.Text == "" || textBoxMail.Text == "email")
                {
                    labelErreurEmail.Visible = true;
                } else
                {
                    labelErreurEmail.Visible = false;
                }
                if (textBoxMdp.Text == "" || textBoxMdp.Text == "password")
                {
                    labelErreurMdp.Visible = true;
                } else
                {
                    labelErreurMdp.Visible = false;
                }
            }
            else
            {
                 labelErreurEmail.Visible=false;
                 labelErreurMdp.Visible=false;

                if(ModeleAdministrateur.ConnexionAdmin(textBoxMail.Text, textBoxMdp.Text))
                {
                    Administrateur administrateur = new();
                    administrateur = ModeleAdministrateur.RecupererAdmin(textBoxMail.Text);

                    Form2FATest form2FA = new(administrateur);
                    form2FA.Show();
                    this.Hide();
                }
            }
        }
    }
}
