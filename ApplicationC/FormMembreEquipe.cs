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
    public partial class FormMembreEquipe : Form
    {
        private int maxPage;
        private int minPage;
        private string choix;

        public FormMembreEquipe()
        {
            InitializeComponent();
        }

        public FormMembreEquipe(EtatTypeGestion etatType)
        {
            InitializeComponent();

            if (etatType == EtatTypeGestion.Equipe)
            {
                choix = "equipe";
            } else
            {
                choix = "membre";
                labelInfoEquipe.Visible = false;
            }

            nbPages(choix);
            
            minPage = 1;
            buttonPrec.Enabled = false;
            
            affichageLoad(choix);
        }

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
            } else
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
    }
}
