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
    public partial class FormMenuHackathon : Form
    {

        SousFormulaire sousF;
        public FormMenuHackathon()
        {
            InitializeComponent();
            sousF = new(panelSousAffichage);
        }

        private void ListeHackathonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormHackathon());
        }

        private void AjoutHackathonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormGestionHackathon(EtatGestion.Create));
        }

        private void ModificationHackathonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sousF.openChildForm(new FormGestionHackathon(EtatGestion.Update));
        }

        private void rechercheHackathonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Lot2-5 Consultation filtrée des hackathons 
        }
    }
}
