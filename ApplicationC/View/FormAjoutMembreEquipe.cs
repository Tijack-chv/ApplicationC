using ApplicationC.Controller;
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
    public partial class FormAjoutMembreEquipe : Form
    {
        Equipe equipe;
        List<Membre> lesM;

        public FormAjoutMembreEquipe(Equipe equipe)
        {
            InitializeComponent();
            labelEquipe.Text = equipe.Nomequipe;
            this.equipe = equipe;

            lesM = ModeleMembreEquipe.ListMembreSansEquipe();
            foreach (Membre membre in lesM)
            {
                checkedListBoxMembres.Items.Add(membre.Nom + " " + membre.Prenom);
            }
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (checkedListBoxMembres.CheckedItems.Count >= 1)
            {
                List<Membre> ajoutMembreE = new List<Membre>();

                foreach (var items in checkedListBoxMembres.CheckedItems)
                {
                    foreach (Membre membre in lesM)
                    {
                        if (items.Equals(membre.Nom + " " + membre.Prenom))
                        {
                            ajoutMembreE.Add(membre);
                        }
                    }
                }

                foreach (Membre membre in ajoutMembreE)
                {
                    if (!ModeleMembreEquipe.AjoutMembreInEquipe(membre, equipe.Idequipe))
                    {
                        MessageBox.Show("Ajout impossible du membre " + membre.Nom + " " + membre.Prenom + " !");
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Aucun Membre n'a été ajouté !");
            }
        }
    }
}
