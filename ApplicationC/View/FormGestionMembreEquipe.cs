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

namespace ApplicationC.View
{
    public partial class FormGestionMembreEquipe : Form
    {
        public FormGestionMembreEquipe()
        {
            InitializeComponent();
            // localisation good : 12, 12
            // localisation retrait : 12, 370
            panelGestionMembre.BackColor = Color.FromArgb(120, 127, 127, 127);
            panelGestionEquipe.BackColor = Color.FromArgb(120, 127, 127, 127);
        }

        public FormGestionMembreEquipe(EtatGestion etatGestion, EtatTypeGestion etatTypeGestion)
        {
            InitializeComponent();
            affichage(etatGestion, etatTypeGestion);
            panelGestionMembre.BackColor = Color.FromArgb(140, 127, 127, 127);
            panelGestionEquipe.BackColor = Color.FromArgb(140, 127, 127, 127);
        }

        public void affichage(EtatGestion etatGestion, EtatTypeGestion etatTypeGestion)
        {
            if (etatGestion == EtatGestion.Create)
            {
                if (etatTypeGestion == EtatTypeGestion.Membre)
                {
                    // Crea Membre
                    groupBoxMembre.Text = "Gestion du Membre";
                    labelAjoutModifMembreEquipe.Text = "Ajout d'un Membre";
                    panelGestionMembre.Visible = true;
                    panelGestionMembre.Location = new Point(12, 12);
                    panelGestionEquipe.Location = new Point(12, 370);
                    panelGestionEquipe.Visible = false;
                }
                else
                {
                    // Crea Equipe
                    groupBoxMembre.Text = "Gestion de l'équipe";
                    labelAjoutModifMembreEquipe.Text = "Ajout d'une équipe";
                    panelGestionEquipe.Visible = true;
                    panelGestionEquipe.Location = new Point(12, 12);
                    panelGestionMembre.Location = new Point(12, 370);
                    panelGestionMembre.Visible = false;
                }
            }
            else
            {
                if (etatTypeGestion == EtatTypeGestion.Membre)
                {
                    // Modif Membre
                    groupBoxMembre.Text = "Gestion du Membre";
                    labelAjoutModifMembreEquipe.Text = "Modification d'un Membre";
                    panelGestionMembre.Visible = true;
                    panelGestionMembre.Location = new Point(12, 12);
                    panelGestionEquipe.Location = new Point(12, 370);
                    panelGestionEquipe.Visible = false;
                }
                else
                {
                    // Modif Equipe
                    groupBoxMembre.Text = "Gestion de l'équipe";
                    labelAjoutModifMembreEquipe.Text = "Modification d'une équipe";
                    panelGestionEquipe.Visible = true;
                    panelGestionEquipe.Location = new Point(12, 12);
                    panelGestionMembre.Location = new Point(12, 370);
                    panelGestionMembre.Visible = false;
                }
            }
        }

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
    }
}
