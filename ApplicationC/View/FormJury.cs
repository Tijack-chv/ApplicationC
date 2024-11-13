using ApplicationC.Entities;
using ApplicationC.Model;
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

namespace ApplicationC.View
{
    public partial class FormJury : Form
    {
        #region Attribut
        private int maxPage;
        private int minPage;
        SFormulaire sousF;
        #endregion

        public FormJury()
        {
            InitializeComponent();

            sousF = new(panelGestionJury);

            minPage = 1;
            buttonPrec.Enabled = false;
            dataGridViewHackathons.Location = new Point(688, 51);
        }

        private void buttonSuiv_Click(object sender, EventArgs e)
        {
            int tempPage = Convert.ToInt32(textBoxPage.Text);
            tempPage++;
            textBoxPage.Text = tempPage.ToString();
        }

        private void buttonPrec_Click(object sender, EventArgs e)
        {
            int tempPage = Convert.ToInt32(textBoxPage.Text);
            tempPage--;
            textBoxPage.Text = tempPage.ToString();
        }

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
            FormJury_Load(this, EventArgs.Empty);

        }

        private void textBoxPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void nbPages()
        {
            int count = ModeleJury.CountJury();
            if (count % 20 == 0)
            {
                maxPage = count / 20;
            }
            else
            {
                maxPage = (count / 20) + 1;
            }
        }

        private void FormJury_Load(object sender, EventArgs e)
        {
            bindingSourceJury.DataSource = ModeleJury.ListJuryParPage(Convert.ToInt32(textBoxPage.Text)).Select(static x => new
            {
                x.Idjury,
                x.Nomjury,
                x.Prenomjury,
                x.Email,
            });

            dataGridViewJury.DataSource = bindingSourceJury;
            dataGridViewJury.Columns[0].HeaderText = "Id Jury";
            dataGridViewJury.Columns[1].HeaderText = "Nom Jury";
            dataGridViewJury.Columns[2].HeaderText = "Prénom Jury";
            dataGridViewJury.Columns[3].HeaderText = "Email";
            dataGridViewJury.Columns[0].Visible = false;

            for (int i = 0; i <= 3; i++)
            {
                dataGridViewJury.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            nbPages();
        }

        private void visualiserLesHackathonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelGestionJury.Visible = false;
            //location classique : 721; 38      ->           721; 10
            //location classique : 913; 38      ->           913; 10
            buttonCreateJury.Location = new Point(721, 10);
            buttonUpdateJury.Location = new Point(913, 10);

            System.Type type = bindingSourceJury.Current.GetType();
            int idJ = (int)type.GetProperty("Idjury").GetValue(bindingSourceJury.Current, null);

            List<Hackathon> lesHackathons = ModeleJury.ListHackathonParJury(idJ);
            if (lesHackathons.Count != 0)
            {
                bindingSourceHackathons.DataSource = (lesHackathons).Select(static x => new
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
                });

                dataGridViewHackathons.DataSource = bindingSourceHackathons;
                dataGridViewHackathons.Columns[1].HeaderText = "Thématique";
                dataGridViewHackathons.Columns[2].HeaderText = "Lieu";
                dataGridViewHackathons.Columns[3].HeaderText = "Ville";
                dataGridViewHackathons.Columns[4].HeaderText = "Date de début";
                dataGridViewHackathons.Columns[5].HeaderText = "Date de fin";
                dataGridViewHackathons.Columns[6].HeaderText = "Objectifs";
                dataGridViewHackathons.Columns[7].HeaderText = "Nombre de Places Maximum";
                dataGridViewHackathons.Columns[8].HeaderText = "Date butoir inscription";
                dataGridViewHackathons.Columns[0].Visible = false;
                dataGridViewHackathons.Visible = true;

            }
            else
            {
                dataGridViewHackathons.Visible = false;
                MessageBox.Show("Aucun Hackathons n'a été choisi pour ce jury !");
            }
        }

        private void dataGridViewJury_Click(object sender, EventArgs e)
        {
            dataGridViewHackathons.Visible = false;
            buttonCreateJury.Location = new Point(721, 38);
            buttonUpdateJury.Location = new Point(913, 38);
        }

        private void dataGridViewJury_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewHackathons.Visible = false;
            buttonCreateJury.Location = new Point(721, 38);
            buttonUpdateJury.Location = new Point(913, 38);
        }

        private void dataGridViewJury_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewHackathons.Visible = false;
            buttonCreateJury.Location = new Point(721, 38);
            buttonUpdateJury.Location = new Point(913, 38);
        }

        private void buttonCreateJury_Click(object sender, EventArgs e)
        {
            dataGridViewHackathons.Visible = false;

            buttonCreateJury.Location = new Point(721, 38);
            buttonUpdateJury.Location = new Point(913, 38);

            panelGestionJury.Visible = true;
            sousF.openChildForm(new FormGestionJury(EtatGestion.Create));
        }

        private void buttonUpdateJury_Click(object sender, EventArgs e)
        {
            dataGridViewHackathons.Visible = false;

            buttonCreateJury.Location = new Point(721, 38);
            buttonUpdateJury.Location = new Point(913, 38);

            panelGestionJury.Visible = true;

            System.Type type = bindingSourceJury.Current.GetType();
            int idJ = (int)type.GetProperty("Idjury").GetValue(bindingSourceJury.Current, null);

            Jury jury = ModeleJury.RecupererJury(idJ);

            sousF.openChildForm(new FormGestionJury(jury,EtatGestion.Update));
        }
    }
}
