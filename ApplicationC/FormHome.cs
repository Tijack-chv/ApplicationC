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
    public partial class FormHome : Form
    {
        SousFormulaire sousF;

        public FormHome()
        {
            InitializeComponent();
            sousF = new(panelAffichage);
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void buttonHackathon_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormMenuHackathon());
        }

        private void buttonEquipe_Click(object sender, EventArgs e)
        {

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
