using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ApplicationC.Controller;
using ApplicationC.Entities;
using ApplicationC.Model;
using SousFormulaire;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ApplicationC
{ 
    public partial class FormHackathon : Form
    {
        #region Attribut
        private int maxPage;
        private int minPage;
        private bool filtre = false;
        #endregion

        #region Constructeur FormHackathon
        public FormHackathon()
        {
            InitializeComponent();
            
            dateTimePickerDatePrec.MinDate = ModeleHackathon.FirstDate();
            dateTimePickerDatePrec.MaxDate = ModeleHackathon.LastDate();

            dateTimePickerDatePrec.Value = dateTimePickerDatePrec.MinDate;

            dateTimePickerDateSuiv.MinDate = dateTimePickerDatePrec.Value;
            dateTimePickerDateSuiv.MaxDate = ModeleHackathon.LastDate();

            dateTimePickerDateSuiv.Value = dateTimePickerDateSuiv.MaxDate;

            minPage = 1;
            buttonPrec.Enabled = false;

            comboBoxEquipe.ValueMember = "idequipe";
            comboBoxEquipe.DisplayMember = "nomequipe";

            bindingSourceAllEquipeCombo.DataSource = (ModeleMembreEquipe.listeEquipeSimple());
            comboBoxEquipe.DataSource = bindingSourceAllEquipeCombo;
            comboBoxEquipe.SelectedIndex = -1;
        }
        #endregion

        #region nbPages
        /// <summary>
        /// Permet de compter le nombre de page max disponible afin de poser une limite 
        /// </summary>
        private void nbPages()
        {
            int count = ModeleHackathon.CountHackathon();
            if (count % 20 == 0)
            {
                maxPage = count / 20;
            }
            else
            {
                maxPage = (count / 20) + 1;
            }
        }
        #endregion

        private void nbPagesFiltre(List<Hackathon> liste)
        {
            int count = liste.Count();
            if (count % 20 == 0)
            {
                maxPage = count / 20;
            }
            else
            {
                maxPage = (count / 20) + 1;
            }
        }

        #region Form1_Load
        /// <summary>
        /// Permet l'affichage de la liste des Hackathons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            BSHackathon.DataSource = ModeleHackathon.listeHackathonsParPage(Convert.ToInt32(textBoxPage.Text)).Select(static x => new
            {
                x.Idhackathon,
                x.Thematique,
                x.Lieu,
                x.Ville,
                x.Dateheuredebuth,
                x.Dateheurefinh,
                x.Objectifs,
                x.Nbplaceeqmax,
                x.Datefininscription,
                x.IdorganisateurNavigation.Nom,
                x.IdorganisateurNavigation.Prenom,
                x.Affiche,
            });


            dgvHackathon.DataSource = BSHackathon;
            dgvHackathon.Columns[0].HeaderText = "Identifiant";
            dgvHackathon.Columns[1].HeaderText = "Thématique";
            dgvHackathon.Columns[2].HeaderText = "Lieu";
            dgvHackathon.Columns[3].HeaderText = "Ville";
            dgvHackathon.Columns[4].HeaderText = "Date de début";
            dgvHackathon.Columns[5].HeaderText = "Date de fin";
            dgvHackathon.Columns[6].HeaderText = "Objectifs";
            dgvHackathon.Columns[7].HeaderText = "Nombre de Places Maximum";
            dgvHackathon.Columns[8].HeaderText = "Date butoir inscription";
            dgvHackathon.Columns[9].HeaderText = "Nom Organisateur";
            dgvHackathon.Columns[10].HeaderText = "Prénom Organisateur";
            dgvHackathon.Columns[11].Visible = false;

            nbPages();
        }
        #endregion

        private void FormFiltre_Load(List<Hackathon> liste)
        {
            BSHackathon.DataSource = liste.Select(static x => new
            {
                x.Idhackathon,
                x.Thematique,
                x.Lieu,
                x.Ville,
                x.Dateheuredebuth,
                x.Dateheurefinh,
                x.Objectifs,
                x.Nbplaceeqmax,
                x.Datefininscription,
                x.IdorganisateurNavigation.Nom,
                x.IdorganisateurNavigation.Prenom,
                x.Affiche,
            });

            dgvHackathon.DataSource = BSHackathon;
            dgvHackathon.Columns[0].HeaderText = "Identifiant";
            dgvHackathon.Columns[1].HeaderText = "Thématique";
            dgvHackathon.Columns[2].HeaderText = "Lieu";
            dgvHackathon.Columns[3].HeaderText = "Ville";
            dgvHackathon.Columns[4].HeaderText = "Date de début";
            dgvHackathon.Columns[5].HeaderText = "Date de fin";
            dgvHackathon.Columns[6].HeaderText = "Objectifs";
            dgvHackathon.Columns[7].HeaderText = "Nombre de Places Maximum";
            dgvHackathon.Columns[8].HeaderText = "Date butoir inscription";
            dgvHackathon.Columns[9].HeaderText = "Nom Organisateur";
            dgvHackathon.Columns[10].HeaderText = "Prénom Organisateur";
            dgvHackathon.Columns[11].Visible = false;

            filtre = true;
            nbPagesFiltre(liste);
        }

        #region voirLesEquipesToolStripMenuItem_Click
        /// <summary>
        /// Au click droit sur la dgv, permet de voir toutes les équipes pour l'hackathon choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VoirLesÉquipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = BSHackathon.Current.GetType();
            int idH = (int)type.GetProperty("Idhackathon").GetValue(BSHackathon.Current, null);

            List<Equipe> lesEquipes = ModeleHackathon.listeEquipesParHackathon(idH);
            if (lesEquipes.Count != 0)
            {
                BSEquipe.DataSource = (lesEquipes).Select(static x => new
                {
                    x.Idequipe,
                    x.Nomequipe
                });

                dgvEquipesJury.DataSource = BSEquipe;
                dgvEquipesJury.Visible = true;

            }
            else
            {
                dgvEquipesJury.Visible = false;
                MessageBox.Show("Pas d'équipe pour cet hackathon");
            }

        }
        #endregion

        #region DgvHackathon_AllClick
        /// <summary>
        /// Pour les 3 méthodes ci-dessous, permet de rendre invisible la liste des équipes de l'hackathon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvHackathon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvEquipesJury.Visible = false;
            panelPictureBoxAffiche.Visible = false;
        }

        private void DgvHackathon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEquipesJury.Visible = false;
            panelPictureBoxAffiche.Visible = false;
        }

        private void DgvHackathon_Click(object sender, EventArgs e)
        {
            dgvEquipesJury.Visible = false;
            panelPictureBoxAffiche.Visible = false;
        }
        #endregion

        #region pictureBoxFermer_Click
        private void pictureBoxFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region buttonPrec_Click
        private void buttonPrec_Click(object sender, EventArgs e)
        {
            int tempPage = Convert.ToInt32(textBoxPage.Text);
            tempPage--;
            textBoxPage.Text = tempPage.ToString();
        }
        #endregion

        #region buttonSuiv_Click
        private void buttonSuiv_Click(object sender, EventArgs e)
        {
            int tempPage = Convert.ToInt32(textBoxPage.Text);
            tempPage++;
            textBoxPage.Text = tempPage.ToString();
        }
        #endregion

        #region textBoxPage_KeyPress
        private void textBoxPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region textboxPage_TextChanged
        private void textBoxPage_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPage.Text != "")
            {
                if (Convert.ToInt32(textBoxPage.Text) <= 0)
                {
                    textBoxPage.Text = "1";
                }

                if (Convert.ToInt32(textBoxPage.Text) >= maxPage)
                {
                    textBoxPage.Text = maxPage.ToString();
                    buttonSuiv.Enabled = false;
                }
                else
                {
                    buttonSuiv.Enabled = true;
                }
                if (Convert.ToInt32(textBoxPage.Text) == minPage)
                {
                    buttonPrec.Enabled = false;
                }
                else
                {
                    buttonPrec.Enabled = true;
                }
            }
            else
            {
                textBoxPage.Text = "1";
            }

            if (!filtre)
            {
                nbPages();
                Form1_Load(this, EventArgs.Empty);
            }
        }
        #endregion

        #region dgvHackathon_DoubleClick
        /// <summary>
        /// Permet au double click sur la dgv d'archiver l'hackathon sélectionner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvHackathon_DoubleClick(object sender, EventArgs e)
        {
            System.Type type = BSHackathon.Current.GetType();
            int idH = (int)type.GetProperty("Idhackathon").GetValue(BSHackathon.Current, null);
            string name = (String)type.GetProperty("Thematique").GetValue(BSHackathon.Current, null);

            DialogResult dialogResult = MessageBox.Show("Voulez-vous archiver l'Hackathon '" + name + "' ? ", "Archivage de l'hackathon n°" + idH + " ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (ModeleHackathon.hackathonEstArchive(idH))
                {
                    MessageBox.Show("Archivage de l'hackathon '" + name + "' a correctement été effectué !");
                    Form1_Load(sender, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("L'archivage de l'élément n'a pas été effectué !");
                }
            }
        }
        #endregion

        #region modifierToolStripMenuItem_Click
        /// <summary>
        /// Permet d'aller sur la page modifier Hackathon avec l'hackathon sélectionné pour la modif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = BSHackathon.Current.GetType();
            int idH = (int)type.GetProperty("Idhackathon").GetValue(BSHackathon.Current, null);

            Hackathon hack = ModeleHackathon.RecupererHackathon(idH);

            if (hack.Dateheuredebuth <= DateTime.Now)
            {
                MessageBox.Show("Cette Hackathon étant en cours ou terminé, il ne peut donc pas être modifié !");
            }
            else
            {
                SFormulaire sousF = new((System.Windows.Forms.Application.OpenForms["FormMenuHackathon"] as FormMenuHackathon).panelSousAffichage);
                sousF.openChildForm(new FormGestionHackathon(EtatGestion.Update, idH));
            }
        }
        #endregion

        private void visualiserLAfficheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = BSHackathon.Current.GetType();
            byte[] affiche = (byte[])type.GetProperty("Affiche").GetValue(BSHackathon.Current, null);

            if (affiche != null)
            {
                using (MemoryStream ms = new MemoryStream(affiche))
                {
                    // Convertir le MemoryStream en Image
                    Image image = Image.FromStream(ms);

                    // Assigner l'image au PictureBox
                    pictureBoxAffiche.Image = image;
                }

                panelPictureBoxAffiche.Visible = true;
            }
            else
            {
                MessageBox.Show("Il n'y a pas d'affiche pour cet événement !");
            }
        }

        private void désinscrireEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type typeE = BSEquipe.Current.GetType();
            int idE = (int)typeE.GetProperty("Idequipe").GetValue(BSEquipe.Current, null);
            Equipe eq = ModeleMembreEquipe.RecupererEquipe(idE);

            DialogResult dialogResult = MessageBox.Show("Voulez-vous désinscrire l'équipe " + eq.Nomequipe + " ? ", "Désinscription de l'équipe n°" + idE + " ", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                System.Type typeH = BSHackathon.Current.GetType();
                int idH = (int)typeH.GetProperty("Idhackathon").GetValue(BSHackathon.Current, null);

                if (ModeleHackathon.desinscriptionEquipe(idH, idE))
                {
                    string subject = "Désinscription Equipe";
                    string body = "Bonjour, Votre équipe '" + eq.Nomequipe + "' a été désinscrite !\nSi cela est une erreur, veuillez informer l'administration de l'Hackathon en question.";

                    List<Membre> membres = ModeleMembreEquipe.RecupererMembres(eq.Idequipe);
                    List<string> dests = membres.Select(x => x.Email).ToList();
                    dests.Add(eq.Login);

                    Controleur.EmailSend(dests, subject, body);
                    MessageBox.Show("L'équipe " + eq.Nomequipe + " a bien été désinscrite !\nUn email a bien été envoyé à cette équipe !");

                    dgvEquipesJury.Visible = false;
                    panelPictureBoxAffiche.Visible = false;
                }
            }
        }

        private void textBoxThematique_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        private void buttonRenitialiserFiltre_Click(object sender, EventArgs e)
        {
            filtre = false;
            textBoxThematique.Text = "";
            Form1_Load(sender, EventArgs.Empty);
            buttonSuiv.Enabled = true;
        }

        private void textBoxVille_TextChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        private void dateTimePickerDatePrec_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerDateSuiv.MinDate = dateTimePickerDatePrec.Value;
            AppliquerFiltres();
        }

        private void dateTimePickerDateSuiv_ValueChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        private void comboBoxEquipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        private void numericUpDownPlacesRestantes_ValueChanged(object sender, EventArgs e)
        {
            AppliquerFiltres();
        }

        private void AppliquerFiltres()
        {
            List<Hackathon> query1 = ModeleHackathon.listeHackathons();
            List<Hackathon> query = new List<Hackathon>();

            if (!string.IsNullOrEmpty(textBoxThematique.Text))
                query1 = query1.Where(x => x.Thematique.Contains(textBoxThematique.Text)).ToList();
            if (!string.IsNullOrEmpty(textBoxVille.Text))
                query1 = query1.Where(x => x.Ville.Contains(textBoxVille.Text)).ToList();
            if (dateTimePickerDatePrec.Value != dateTimePickerDatePrec.MinDate)
                query1 = query1.Where(x => x.Datefininscription >= dateTimePickerDatePrec.Value).ToList();
            if (dateTimePickerDateSuiv.Value != dateTimePickerDateSuiv.MaxDate)
                query1 = query1.Where(x => x.Datefininscription <= dateTimePickerDatePrec.Value).ToList();
            if (numericUpDownPlacesRestantes.Value != 0)
                query1 = query1.Where(x => x.Nbplaceeqmax == numericUpDownPlacesRestantes.Value).ToList();
            if (comboBoxEquipe.SelectedIndex != -1)
            {
                List<Hackathon> query2 = ModeleHackathon.listeHackathonParEquipe(Convert.ToInt32(comboBoxEquipe.SelectedValue));
                query = query1.Intersect(query2).ToList();
            } else
            {
                query = query1;
            }

            if (query.Any())
            {
                // Charge la liste filtrée dans le DataGridView si elle n'est pas vide
                FormFiltre_Load(query);
            }
            else
            {
                // Si la liste est vide, vide le DataGridView et affiche un message
                dgvHackathon.DataSource = null;
                MessageBox.Show("Aucun hackathon ne correspond aux critères des filtres !", "Aucun résultat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
