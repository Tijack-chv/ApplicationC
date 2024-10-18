using ApplicationC.Entities;
using ApplicationC.Model;
using ApplicationC.View;
using SousFormulaire;
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
    public partial class FormMembreEquipe : Form
    {
        #region Attribut
        private int maxPage;
        private int minPage;
        private string choix;
        #endregion

        #region Constructeur FormMembreEquipe
        public FormMembreEquipe()
        {
            InitializeComponent();
            choix = "";
        }

        public FormMembreEquipe(EtatTypeGestion etatType)
        {
            InitializeComponent();

            if (etatType == EtatTypeGestion.Equipe)
            {
                choix = "equipe";
            }
            else
            {
                choix = "membre";
                labelInfoEquipe.Visible = false;
                dataGridViewMembreEquipe.ContextMenuStrip = null;
            }

            nbPages(choix);

            minPage = 1;
            buttonPrec.Enabled = false;

            affichageLoad(choix);
        }
        #endregion

        #region nbPages
        /// <summary>
        /// Permet de mettre une limite sur le nombre de page possible
        /// </summary>
        /// <param name="typeChoix"></param>
        private void nbPages(string typeChoix)
        {
            int count = ModeleMembreEquipe.CompteMembreEquipe(typeChoix);
            if (count % 10 == 0)
            {
                maxPage = count / 10;
            }
            else
            {
                maxPage = (count / 10) + 1;
            }
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
            nbPages(choix);
            affichageLoad(choix);
        }
        #endregion

        #region afficheLoad
        /// <summary>
        /// Permet l'affichage des données équipes ou membres
        /// </summary>
        /// <param name="typeChoix"></param>
        public void affichageLoad(string typeChoix)
        {
            if (typeChoix == "membre")
            {
                bindingSourceMembreEquipe.DataSource = ModeleMembreEquipe.listeMembreParPage(Convert.ToInt32(textBoxPage.Text)).Select(static x => new
                {
                    x.Idmembre,
                    x.Prenom,
                    x.Nom,
                    x.Email,
                    x.Telephone,
                    x.Datenaissance,
                    x.IdequipeNavigation.Idequipe,
                    x.IdequipeNavigation.Nomequipe,
                });

                dataGridViewMembreEquipe.DataSource = bindingSourceMembreEquipe;
                dataGridViewMembreEquipe.Columns[0].HeaderText = "Identifiant du membre";
                dataGridViewMembreEquipe.Columns[1].HeaderText = "Prénom";
                dataGridViewMembreEquipe.Columns[2].HeaderText = "Nom";
                dataGridViewMembreEquipe.Columns[3].HeaderText = "Adresse-mail";
                dataGridViewMembreEquipe.Columns[4].HeaderText = "Téléphone";
                dataGridViewMembreEquipe.Columns[5].HeaderText = "Date de naissance";
                dataGridViewMembreEquipe.Columns[6].HeaderText = "Identifiant de l'Equipe";
                dataGridViewMembreEquipe.Columns[7].HeaderText = "Nom de l'équipe";
            }
            else
            {
                bindingSourceMembreEquipe.DataSource = ModeleMembreEquipe.listeEquipeParPage(Convert.ToInt32(textBoxPage.Text)).Select(static z => new
                {
                    z.Idequipe,
                    z.Nomequipe,
                    z.Login,
                    z.Lienprototype,
                });

                dataGridViewMembreEquipe.DataSource = bindingSourceMembreEquipe;
                dataGridViewMembreEquipe.Columns[0].HeaderText = "Identifiant de l'équipe";
                dataGridViewMembreEquipe.Columns[1].HeaderText = "Nom de l'équipe";
                dataGridViewMembreEquipe.Columns[2].HeaderText = "Adresse mail de l'équipe";
                dataGridViewMembreEquipe.Columns[3].HeaderText = "Lien du prototype";

            }
        }
        #endregion

        #region voirLesMembresToolStripMenuItem_Click
        /// <summary>
        /// au click droit sur la dataGridView, permet de voir tous les membres associés à l'équipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void voirLesMembresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bindingSourceMembreEquipe.Current.GetType();
            int idE = (int)type.GetProperty("Idequipe").GetValue(bindingSourceMembreEquipe.Current, null);

            List<Membre> lesMembres = ModeleMembreEquipe.listeMembreParEquipe(idE);

            if (lesMembres.Count != 0)
            {
                bindingSourceInfoEquipe.DataSource = (lesMembres).Select(static x => new
                {
                    x.Idmembre,
                    x.Prenom,
                    x.Nom,
                    x.Telephone,
                    x.Email,
                });

                dataGridViewInfoEquipe.DataSource = bindingSourceInfoEquipe;
                dataGridViewInfoEquipe.Visible = true;
            }
            else
            {
                dataGridViewInfoEquipe.Visible = false;
                MessageBox.Show("Pas de membre pour cette équipe");
            }
        }
        #endregion

        #region modifierLéquipeToolStripMenuItem_Click
        private void modifierLéquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Type type = bindingSourceMembreEquipe.Current.GetType();
            string loginE = (string)type.GetProperty("Login").GetValue(bindingSourceMembreEquipe.Current, null);

            Equipe equipe = ModeleMembreEquipe.RecupererEquipe(loginE);

            SFormulaire sousF = new((System.Windows.Forms.Application.OpenForms["FormMenuMembreEquipe"] as FormMenuMembreEquipe).panelSousAffichage);
            sousF.openChildForm(new FormGestionMembreEquipe(EtatGestion.Update, EtatTypeGestion.Equipe, equipe.Idequipe));
        }
        #endregion

        #region dataGridViewMembreEquipe_AllClick
        /// <summary>
        /// Enlève l'affichage de la datagridviewInfoEquipe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewMembreEquipe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewInfoEquipe.Visible = false;
        }

        private void dataGridViewMembreEquipe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewInfoEquipe.Visible = false;
        }

        private void dataGridViewMembreEquipe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewInfoEquipe.Visible = false;
        }
        #endregion
    }
}
