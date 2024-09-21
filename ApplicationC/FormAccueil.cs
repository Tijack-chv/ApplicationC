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
    public partial class FormAccueil : Form
    {
        public FormAccueil(bool test)
        {
            InitializeComponent();
            panelDecoArret.BackColor = Color.FromArgb(120, 127, 127, 127);
            panelDecoArret.Visible = false;

            if (!test)
            {
                panelDecoArret.Visible = true;
            }
        }

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            panelDecoArret.Visible=false;
        }
    }
}
