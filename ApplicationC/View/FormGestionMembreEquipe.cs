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

        #region Attribut
        private string etatGest;
        private string etatTypeGest;
        private int idModifChoix = -1;
        #endregion

        public FormGestionMembreEquipe(EtatGestion etatGestion, EtatTypeGestion etatTypeGestion)
        {
            InitializeComponent();

            etatGest = etatGestion.ToString();
            etatTypeGest = etatTypeGestion.ToString();

            affichage(etatGestion, etatTypeGestion);
            panelGestionMembre.BackColor = Color.FromArgb(140, 127, 127, 127);
        }

        public FormGestionMembreEquipe(EtatGestion etatGestion, EtatTypeGestion etatTypeGestion, int id)
        {
            InitializeComponent();

            etatGest = etatGestion.ToString();
            etatTypeGest = etatTypeGestion.ToString();

            idModifChoix = id;

            affichage(etatGestion, etatTypeGestion);
            panelGestionMembre.BackColor = Color.FromArgb(140, 127, 127, 127);
        }

        public void affichage(EtatGestion etatGestion, EtatTypeGestion etatTypeGestion)
        {
            if (etatTypeGestion == EtatTypeGestion.Membre)
            {
                groupBoxMembreEquipe.Text = "Gestion du Membre";
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
                    groupBoxMembreEquipe.Visible = true;
                }
                else
                {
                    labelAjoutModifMembreEquipe.Text = "Modification d'un membre";
                    comboBoxModificationMembreEquipe.Visible = true;

                    comboBoxModificationMembreEquipe.ValueMember = "idmembre";
                    comboBoxModificationMembreEquipe.DisplayMember = "nom";

                    bindingSourceMembreEquipe.DataSource = (ModeleMembreEquipe.listeMembreSimple());
                    comboBoxModificationMembreEquipe.DataSource = bindingSourceMembreEquipe;
                    comboBoxModificationMembreEquipe.SelectedIndex = -1;

                    if (idModifChoix != -1)
                    {
                        comboBoxModificationMembreEquipe.SelectedValue = idModifChoix;
                        groupBoxMembreEquipe.Visible = true;
                    }
                    else
                    {
                        groupBoxMembreEquipe.Visible = false;
                    }
                }
            }
            else
            {
                groupBoxMembreEquipe.Text = "Gestion de l'équipe";
                panelEquipe.Location = new Point(155, 65);
                panelEquipe.Visible = true;
                panelMembre.Location = new Point(1200, 1200);
                panelMembre.Visible = false;

                if (etatGestion == EtatGestion.Create)
                {
                    textBoxEmailEquipe.Enabled = true;
                    labelAjoutModifMembreEquipe.Text = "Ajout d'une équipe";
                    comboBoxModificationMembreEquipe.Visible = false;
                }
                else
                {
                    labelAjoutModifMembreEquipe.Text = "Modification d'une équipe";
                    comboBoxModificationMembreEquipe.Visible = true;

                    comboBoxModificationMembreEquipe.ValueMember = "idequipe";
                    comboBoxModificationMembreEquipe.DisplayMember = "nomequipe";

                    bindingSourceMembreEquipe.DataSource = (ModeleMembreEquipe.listeEquipeSimple());
                    comboBoxModificationMembreEquipe.DataSource = bindingSourceMembreEquipe;
                    comboBoxModificationMembreEquipe.SelectedIndex = -1;

                    if (idModifChoix != -1)
                    {
                        comboBoxModificationMembreEquipe.SelectedValue = idModifChoix;
                        groupBoxMembreEquipe.Visible = true;
                    }
                    else
                    {
                        groupBoxMembreEquipe.Visible = false;
                    }
                }
            }
        }

        #region textBoxTelephone_KeyPress
        private void textBoxTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        private async void buttonAction_ClickAsync(object sender, EventArgs e)
        {
            bool test = true;
            if (etatTypeGest == EtatTypeGestion.Membre.ToString())
            {
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
                if (textBoxLienPortfolio.Text != "")
                {
                    string url = textBoxLienPortfolio.Text.Trim();
                    string verif = "";
                    if (Controleur.IsValidUrl(url))
                    {
                        if (await Controleur.IsUrlAccessible(url))
                        {
                            verif = "Le lien du portfolio est accessible !";
                        }
                        else
                        {
                            verif = "La modification peut se faire mais le le lien du portfolio n'est pas accessible !";
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
            }
            else
            {
                if (textBoxEmailEquipe.Text == "")
                {
                    test = false;
                    labelEmailEq.ForeColor = Color.Red;
                    textBoxEmailEquipe.ForeColor = Color.Red;

                    if (textBoxNomEquipe.Text == "")
                    {
                        test = false;
                        labelNomEquipe.ForeColor = Color.Black;
                        textBoxNomEquipe.ForeColor = Color.Black;
                    }
                }
                if (textBoxNomEquipe.Text == "")
                {
                    test = false;
                    labelNomEquipe.ForeColor = Color.Red;
                    textBoxNomEquipe.ForeColor = Color.Red;

                    if (textBoxEmailEquipe.Text == "")
                    {
                        test = false;
                        labelEmailEq.ForeColor = Color.Black;
                        textBoxEmailEquipe.ForeColor = Color.Black;
                    }
                }

                if (textBoxLienPrototype.Text != "")
                {
                    string url = textBoxLienPrototype.Text.Trim();
                    string verif = "";
                    if (Controleur.IsValidUrl(url))
                    {
                        if (await Controleur.IsUrlAccessible(url))
                        {
                            verif = "Le lien du prototype est accessible !";
                        }
                        else
                        {
                            verif = "La modification peut se faire mais le le lien du prototype n'est pas accessible !";
                        }

                        labelLienPrototype.ForeColor = Color.Black;
                        textBoxLienPrototype.ForeColor = Color.Black;

                        MessageBox.Show(verif);
                    }
                    else
                    {
                        labelLienPrototype.ForeColor = Color.Red;
                        textBoxLienPrototype.ForeColor = Color.Red;
                        test = false;
                    }
                }
            }
            if (test)
            {
                labelErrorInfo.Visible = false;
                if (etatTypeGest == EtatTypeGestion.Membre.ToString())
                {
                    labelPrenom.ForeColor = Color.Black;
                    textBoxPrenom.ForeColor = Color.Black;
                    labelNom.ForeColor = Color.Black;
                    textboxNom.ForeColor = Color.Black;

                    if (etatGest == EtatGestion.Create.ToString())
                    {
                        if (ModeleMembreEquipe.AjoutMembre(textboxNom.Text, textBoxPrenom.Text, textBoxEmail.Text, textBoxTelephone.Text, dateTimePickerDatenaiss.Value, textBoxLienPortfolio.Text))
                        {
                            MessageBox.Show("Membre ajouté");
                            annuler(EtatTypeGestion.Membre);
                        }
                    }
                    else
                    {
                        Membre M = (Membre)bindingSourceMembreEquipe.Current;
                        if (ModeleMembreEquipe.ModificationMembre(M.Idmembre, textboxNom.Text, textBoxPrenom.Text, textBoxEmail.Text, textBoxTelephone.Text, dateTimePickerDatenaiss.Value, textBoxLienPortfolio.Text))
                        {
                            MessageBox.Show("Membre modifié");
                            groupBoxMembreEquipe.Visible = false;
                            comboBoxModificationMembreEquipe.SelectedIndex = -1;
                        }
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
            else
            {
                labelErrorInfo.Visible = true;
            }
        }

        #region buttonFermer_Click
        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region textBoxTelephone_TextChanged
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
        #endregion

        #region textboxNomPrenom_KeyPress
        private void textBoxNomPrenom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region comboBoxModificationMembreEquipe_SelectedIndexChanged
        private void comboBoxModificationMembreEquipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            bindingSourceMembreEquipe_CurrentChanged(sender, e);
        }
        #endregion

        private void annuler(EtatTypeGestion etatTypeGestion)
        {
            if (etatTypeGestion == EtatTypeGestion.Membre)
            {
                textBoxEmail.Text = "";
                textBoxLienPortfolio.Text = "";
                textboxNom.Text = "";
                textBoxPrenom.Text = "";
                textBoxTelephone.Text = "";
                dateTimePickerDatenaiss.Value = dateTimePickerDatenaiss.MaxDate;
            }
            else
            {
                textBoxEmailEquipe.Text = "";
                textBoxNomEquipe.Text = "";
                textBoxLienPrototype.Text = "";
            }
        }

        private void bindingSourceMembreEquipe_CurrentChanged(object sender, EventArgs e)
        {
            if (comboBoxModificationMembreEquipe.SelectedIndex != -1)
            {
                if (etatTypeGest == EtatTypeGestion.Membre.ToString())
                {
                    Membre membre = (Membre)bindingSourceMembreEquipe.Current;

                    textboxNom.Text = membre.Nom;
                    textBoxPrenom.Text = membre.Prenom;
                    textBoxTelephone.Text = membre.Telephone;
                    textBoxEmail.Text = membre.Email;
                    textBoxLienPortfolio.Text = membre.Lienportfolio;
                    dateTimePickerDatenaiss.Value = membre.Datenaissance;

                    groupBoxMembreEquipe.Visible = true;
                } else
                {
                    Equipe equipe = (Equipe)bindingSourceMembreEquipe.Current;

                    textBoxEmailEquipe.Text = equipe.Login;
                    textBoxNomEquipe.Text = equipe.Nomequipe;
                    textBoxLienPrototype.Text = equipe.Lienprototype;

                    groupBoxMembreEquipe.Visible = true;
                }
            }
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
