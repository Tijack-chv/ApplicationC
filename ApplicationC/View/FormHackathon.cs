using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApplicationC.Controller;
using ApplicationC.Entities;
using ApplicationC.Model;

namespace ApplicationC
{
    public partial class FormHackathon : Form
    {
        #region Attribut
        private int maxPage;
        private int minPage;
        #endregion

        #region Constructeur FormHackathon
        public FormHackathon()
        {
            InitializeComponent();
            nbPages();
            minPage = 1;
            buttonPrec.Enabled = false;
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
        }
        #endregion

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

                dgvEquipes.DataSource = BSEquipe;
                dgvEquipes.Visible = true;

            }
            else
            {
                dgvEquipes.Visible = false;
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
            dgvEquipes.Visible = false;
            panelPictureBoxAffiche.Visible = false;
        }

        private void DgvHackathon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEquipes.Visible = false;
            panelPictureBoxAffiche.Visible = false;
        }

        private void DgvHackathon_Click(object sender, EventArgs e)
        {
            dgvEquipes.Visible = false;
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
            nbPages();
            Form1_Load(this, EventArgs.Empty);
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
                SousFormulaire sousF = new((System.Windows.Forms.Application.OpenForms["FormMenuHackathon"] as FormMenuHackathon).panelSousAffichage);
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
            } else
            {
                MessageBox.Show("Il n'y a pas d'affiche pour cet événement !");
            }
        }
    }
}
