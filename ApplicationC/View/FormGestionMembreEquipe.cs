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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ApplicationC.View
{
    public partial class FormGestionMembreEquipe : Form
    {
        private string etatGest;
        private string etatTypeGest;
        public FormGestionMembreEquipe(EtatGestion etatGestion, EtatTypeGestion etatTypeGestion)
        {
            InitializeComponent();
            affichage(etatGestion, etatTypeGestion);
            panelGestionMembre.BackColor = Color.FromArgb(140, 127, 127, 127);
            etatGest = etatGestion.ToString();
            etatTypeGest = etatTypeGestion.ToString();
        }

        public void affichage(EtatGestion etatGestion, EtatTypeGestion etatTypeGestion)
        {
            // 155; 65   location panel Modif
            // 754; 330  size panel modif

            if (etatTypeGestion == EtatTypeGestion.Membre)
            {
                groupBoxMembre.Text = "Gestion du Membre";
                panelMembre.Location = new Point(155, 65);
                panelMembre.Visible = true;
                panelEquipe.Location = new Point(1200, 1200);
                panelEquipe.Visible = false;

                dateTimePickerDatenaiss.MaxDate = DateTime.Now.AddYears(-18);
                dateTimePickerDatenaiss.MinDate = DateTime.Now.AddYears(-122);


                if (etatGestion == EtatGestion.Create)
                {
                    labelAjoutModifMembreEquipe.Text = "Ajout d'un Membre";
                    comboBoxModificationMembreEquipe.Visible = false;
                }
                else
                {
                    labelAjoutModifMembreEquipe.Text = "Modification d'une équipe";
                    comboBoxModificationMembreEquipe.Visible = true;

                    comboBoxModificationMembreEquipe.ValueMember = "Idmembre";
                    comboBoxModificationMembreEquipe.DisplayMember = "nomComplet";

                    bindingSourceMembreEquipe.DataSource = (ModeleMembreEquipe.listeMembreSimple()).Select(x => new
                    {
                        x.Idmembre,
                        nomComplet = x.Nom + " " + x.Prenom,
                    });
                    comboBoxModificationMembreEquipe.DataSource = bindingSourceMembreEquipe;
                    comboBoxModificationMembreEquipe.SelectedIndex = -1;
                }
            }
            else
            {
                groupBoxMembre.Text = "Gestion de l'équipe";
                panelEquipe.Location = new Point(155, 65);
                panelEquipe.Visible = true;
                panelMembre.Location = new Point(1200, 1200);
                panelMembre.Visible = false;

                if (etatGestion == EtatGestion.Create)
                {
                    labelAjoutModifMembreEquipe.Text = "Ajout d'une équipe";
                    comboBoxModificationMembreEquipe.Visible = false;
                }
                else
                {
                    labelAjoutModifMembreEquipe.Text = "Modification d'une équipe";
                    comboBoxModificationMembreEquipe.Visible = true;
                }
            }
        }

        private void textBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void buttonAction_ClickAsync(object sender, EventArgs e)
        {
            bool test = true;

            if (etatTypeGest == "Membre")
            {
                if (etatGest == "Create")
                {
                    // Crea Membre
                    if (textBoxPrenom.Text == "")
                    {
                        test = false;

                        labelPrenom.ForeColor = Color.Red;
                        textBoxPrenom.ForeColor = Color.Red;

                        if (textboxNom.Text != "")
                        {
                            labelNom.ForeColor = Color.Black;
                            textboxNom.ForeColor = Color.Black;
                        }
                    }
                    if (textboxNom.Text == "")
                    {
                        test = false;

                        labelNom.ForeColor = Color.Red;
                        textboxNom.ForeColor = Color.Red;

                        if (textBoxPrenom.Text != "")
                        {
                            labelPrenom.ForeColor = Color.Black;
                            textBoxPrenom.ForeColor = Color.Black;
                        }
                    }
                    if (test)
                    {
                        labelPrenom.ForeColor = Color.Black;
                        textBoxPrenom.ForeColor = Color.Black;
                        labelNom.ForeColor = Color.Black;
                        textboxNom.ForeColor = Color.Black;

                        if (textBoxLienPortfolio.Text != "")
                        {
                            string url = textBoxLienPortfolio.Text.Trim();
                            string verif = "";
                            if (Controleur.IsValidUrl(url))
                            {
                                if (await Controleur.IsUrlAccessible(url))
                                {
                                    verif = "accessible";
                                }
                                else
                                {
                                    verif = "pas accessible";
                                }

                                labelLienPortfolio.ForeColor = Color.Black;
                                textBoxLienPortfolio.ForeColor = Color.Black;

                                MessageBox.Show(verif);
                            }
                            else
                            {
                                labelLienPortfolio.ForeColor = Color.Red;
                                textBoxLienPortfolio.ForeColor = Color.Red;
                                test = false;
                            }
                        }
                        if (textBoxEmail.Text != "")
                        {
                            if (!Controleur.ValidMail(textBoxEmail.Text))
                            {
                                labelEmail.ForeColor = Color.Red;
                                textBoxEmail.ForeColor = Color.Red;
                                test = false;
                            }
                            else
                            {
                                labelEmail.ForeColor = Color.Black;
                                textBoxEmail.ForeColor = Color.Black;
                            }
                        }
                        if (textBoxTelephone.Text != "")
                        {
                            if (textBoxTelephone.Text.Count() != 10)
                            {
                                labelTelephone.ForeColor = Color.Red;
                                textBoxTelephone.ForeColor = Color.Red;
                                test = false;
                            }
                            else
                            {
                                labelTelephone.ForeColor = Color.Black;
                                textBoxTelephone.ForeColor = Color.Black;
                            }
                        }

                        if (test)
                        {
                            labelErrorInfo.Visible = false;
                        }
                        else
                        {
                            labelErrorInfo.Visible = true;
                        }
                    }
                    else
                    {
                        labelErrorInfo.Visible = true;
                    }
                }
                else
                {
                    // Modif Membre
                }
            }
            else
            {
                if (etatGest == "Create")
                {
                    // Crea Equipe
                }
                else
                {
                    // Modif Equipe
                }
            }
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTelephone_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTelephone.Text != "" && textBoxTelephone.Text[0].ToString() != "0")
            {
                textBoxTelephone.Text = "";
            }
            else if (textBoxTelephone.Text.Count() >= 2 && textBoxTelephone.Text[1].ToString() == "0")
            {
                textBoxTelephone.Text = textBoxTelephone.Text.Remove(1, 1);
            }
        }

        private void textboxNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bindingSourceMembreEquipe_CurrentChanged(object sender, EventArgs e)
        {
            
            if (comboBoxModificationMembreEquipe.SelectedIndex != -1)
            {
                Membre membre = (Membre)bindingSourceMembreEquipe.Current;

                textboxNom.Text = membre.Nom;
                textBoxPrenom.Text = membre.Prenom;
                textBoxTelephone.Text = membre.Telephone;
                textBoxEmail.Text = membre.Email;
                textBoxLienPortfolio.Text = membre.Lienportfolio;
                dateTimePickerDatenaiss.Value = membre.Datenaissance;                
            }
            
        }

        private void comboBoxModificationMembreEquipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSourceMembreEquipe_CurrentChanged(sender, e);
        }



        /* Permet au moment du click de chercher le chemin d'accès au fichier et de le retranscrire sur une textbox
         
        private void label1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Sélectionner un fichier";
                openFileDialog.Filter = "Tous les fichiers (*.*)|*.*"; // Modifier le filtre selon les besoins

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Afficher le chemin du fichier dans le TextBox
                    textBox1.Text = openFileDialog.FileName;
                }
            }
        }

        */
    }
}
