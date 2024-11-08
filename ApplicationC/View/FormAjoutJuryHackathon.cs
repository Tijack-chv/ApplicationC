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
    public partial class FormAjoutJuryHackathon : Form
    {
        public FormAjoutJuryHackathon()
        {
            InitializeComponent();

            comboBoxEquipeJury.ValueMember = "idequipejury";
            comboBoxEquipeJury.DisplayMember = "details";

            bindingSourceEquipeJury.DataSource = (ModeleEquipeJury.ListesEquipeJury());
            comboBoxEquipeJury.DataSource = bindingSourceEquipeJury;
            comboBoxEquipeJury.SelectedIndex = -1;
            textboxMembresJury.Text = "";
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // Ajouter l'équipe dans hackathon avec envoie de la convocation pour informer les membres
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxEquipeJury_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idEJ = Convert.ToInt32(comboBoxEquipeJury.SelectedValue);
            textboxMembresJury.Text = "";
            if (idEJ != 0)
            {
                List<Jury> listeJury = ModeleEquipeJury.ListeJuryParEquipe(idEJ);

                // Utiliser une liste temporaire pour les noms complets
                List<string> nomsJurys = new List<string>();
                int i = 1;
                foreach (Jury jury in listeJury)
                {
                    nomsJurys.Add(i + "- " + jury.Nomjury + " " + jury.Prenomjury);
                    i++;
                }

                // Joindre les noms avec un retour à la ligne, sans ajout supplémentaire à la fin
                textboxMembresJury.Text = string.Join(Environment.NewLine, nomsJurys);
            }
        }
    }
}
