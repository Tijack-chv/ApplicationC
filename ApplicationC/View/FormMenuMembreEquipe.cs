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
using ApplicationC.Model;

namespace ApplicationC
{
    public partial class FormMenuMembreEquipe : Form
    {
        SousFormulaire sousF;

        public FormMenuMembreEquipe()
        {
            InitializeComponent();
            sousF = new(panelSousAffichage);
        }

        private void listeMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormMembreEquipe(EtatTypeGestion.Membre));
        }

        private void listeEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormMembreEquipe(EtatTypeGestion.Equipe));
        }

        private void ajoutMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ajoutEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificationMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificationEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rechercheMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rechercheEquipeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
