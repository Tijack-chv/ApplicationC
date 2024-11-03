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
    public partial class FormMenuJury : Form
    {
        SFormulaire sousF;

        public FormMenuJury()
        {
            InitializeComponent();
            sousF = new(panelSousAffichage);
            sousF.openChildForm(new FormJury());
        }

        private void ListeJuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormJury());
        }

        private void AjoutJuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormGestionJury());
        }

        private void ModificationJuryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormGestionJury());
        }
    }
}
