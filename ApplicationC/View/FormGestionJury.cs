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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApplicationC.View
{
    public partial class FormGestionJury : Form
    {
        string etatGestion;
        int id;

        public FormGestionJury(EtatGestion etat)
        {
            InitializeComponent();
            etatGestion = (etat == EtatGestion.Create) ? "Create" : "Update";
        }

        public FormGestionJury(Jury jury,EtatGestion etat)
        {
            InitializeComponent();
            id = jury.Idjury;
            textBoxNom.Text = jury.Nomjury;
            textBoxPrenom.Text = jury.Prenomjury;
            textBoxEmail.Text = jury.Email;
            etatGestion = (etat == EtatGestion.Create) ? "Create" : "Update";
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            bool test = true;

            if (!Controleur.ValidMail(textBoxEmail.Text) || textBoxEmail.Text == "")
            {
                labelEmail.ForeColor = Color.Red;
                textBoxEmail.ForeColor = Color.Red;
                test = false;
            }
            else
            {
                labelEmail.ForeColor = Color.Black;
                textBoxEmail.ForeColor = Color.White;
            }
            if (textBoxNom.Text == "")
            {
                labelNom.ForeColor = Color.Red;
                textBoxNom.ForeColor = Color.Red;
                test = false;
            } 
            else
            {
                labelNom.ForeColor = Color.Black;
                textBoxNom.ForeColor = Color.White;
            }
            if (textBoxPrenom.Text == "")
            {
                labelPrenom.ForeColor = Color.Red;
                textBoxPrenom.ForeColor= Color.Red;
                test = false;
            } 
            else
            {
                labelPrenom.ForeColor = Color.Black;
                textBoxPrenom.ForeColor = Color.White;
            }

            if (test)
            {
                if (etatGestion == "Create")
                {
                    if (ModeleJury.ajoutJury(textBoxNom.Text.Trim(), textBoxPrenom.Text.Trim(), textBoxEmail.Text.Trim()))
                    {
                        MessageBox.Show("Le jury a été ajouté !");
                        this.Close();
                    }
                } else
                {
                    if (ModeleJury.modifJury(id,textBoxNom.Text.Trim(), textBoxPrenom.Text.Trim(), textBoxEmail.Text.Trim()))
                    {
                        MessageBox.Show("Le jury a été modifié !");
                        this.Close();
                    }
                }

            }
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
