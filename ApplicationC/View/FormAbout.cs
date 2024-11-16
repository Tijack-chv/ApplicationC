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

namespace ApplicationC.View
{
    public partial class FormAbout : Form
    {
        private int maxPage;
        private int minPage;

        public FormAbout()
        {
            InitializeComponent();
            minPage = 1;
            buttonPrec.Enabled = false;
        }

        private void nbPages()
        {
            int count = ModeleLog.CountLogs();
            if (count % 20 == 0)
            {
                maxPage = count / 20;
            }
            else
            {
                maxPage = (count / 20) + 1;
            }
        }


        private void buttonPrec_Click(object sender, EventArgs e)
        {
            int tempPage = Convert.ToInt32(textBoxPage.Text);
            tempPage--;
            textBoxPage.Text = tempPage.ToString();
        }

        private void buttonSuiv_Click(object sender, EventArgs e)
        {
            int tempPage = Convert.ToInt32(textBoxPage.Text);
            tempPage++;
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
            FormAbout_Load(this, EventArgs.Empty);
        }

        private void textBoxPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            bindingSourceLogs.DataSource = ModeleLog.ListLogParPage(Convert.ToInt32(textBoxPage.Text)).Select(static x => new
            {
                x.Idlog,
                x.Idadmin,
                x.Idequipe,
                x.Description,
                x.CreatedAt,
            });

            dataGridViewLogs.DataSource = bindingSourceLogs;
            dataGridViewLogs.Columns[0].Visible = false;
            dataGridViewLogs.Columns[1].Visible = false;
            dataGridViewLogs.Columns[2].Visible = false;
            dataGridViewLogs.Columns[3].HeaderText = "Description";
            dataGridViewLogs.Columns[4].HeaderText = "Date";

            nbPages();
        }

        private void dataGridViewLogs_DoubleClick(object sender, EventArgs e)
        {
            System.Type type = bindingSourceLogs.Current.GetType();
            int idLog = (int)type.GetProperty("Idlog").GetValue(bindingSourceLogs.Current, null);
            Log log = ModeleLog.RecupererLog(idLog);

            if (log.Idadmin == null)
            {
                Equipe equipe = ModeleMembreEquipe.RecupererEquipe(Convert.ToInt32(log.Idequipe));
                MessageBox.Show("Id de l'équipe : " + equipe.Idequipe + "\n" +
                    "Nom de l'équipe en question : " + equipe.Nomequipe + "\n" +
                    "Login de l'équipe : " + equipe.Login);
            } else
            {
                Administrateur admin = ModeleAdministrateur.RecupererAdmin(Convert.ToInt32(log.Idadmin));
                MessageBox.Show("Id de l'admin : " + admin.Idadministrateur + "\n" +
                    "Nom de l'administrateur en question : " + admin.Nom + " " + admin.Prenom + "\n" +
                    "Login de l'admin : " + admin.Email);

            }
        }
    }
}
