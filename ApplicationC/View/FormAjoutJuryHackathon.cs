using ApplicationC.Controller;
using ApplicationC.Entities;
using ApplicationC.Model;
using Microsoft.VisualBasic.ApplicationServices;
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
        int idHackathon;
        List<Jury> lesJ;

        public FormAjoutJuryHackathon(int idH)
        {
            InitializeComponent();

            idHackathon = idH;

            bindingSourceJury.DataSource = (ModeleJury.ListJury());
            lesJ = ModeleJury.ListJury();
            foreach (Jury jury in lesJ)
            {
                checkedListBoxJury.Items.Add(jury.Nomjury + " " + jury.Prenomjury);
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (checkedListBoxJury.CheckedItems.Count >= 5)
            {
                List<Jury> ajoutJuryH = new List<Jury>();

                foreach (var items in checkedListBoxJury.CheckedItems)
                {
                    foreach (Jury jury in lesJ)
                    {
                        if (items.Equals(jury.Nomjury + " " + jury.Prenomjury))
                        {
                            ajoutJuryH.Add(jury);
                        }
                    }
                }

                foreach (Jury jury in ajoutJuryH)
                {
                    ModeleJury.ajoutJuryHackathon(idHackathon, jury.Idjury, DateTime.Now);
                }

                Hackathon hack = ModeleHackathon.RecupererHackathon(idHackathon);

                //Compléter le corps du mail pour un meilleur rendu
                string subject = "Convocation Jury";
                string body = "Bonjour, Le jury a été choisi pour l'hackathon '" + hack.Thematique + "' ! Vous êtes convoquez à participer à cet évènement en tant que Jury le " + hack.Dateheuredebuth + " jusqu'au " + hack.Dateheurefinh + " !";

                List<string> dests = ajoutJuryH.Select(x => x.Email).ToList();
                string path = "..\\..\\..\\public\\pdfHackathon\\ConvocationJury"+idHackathon+".pdf";

                Controleur.EmailSend(dests, subject, body, idHackathon, path);

                MessageBox.Show("Le jury a bien été choisi pour l'hackathon n°" + idHackathon + " !\nLa convocation pour tous les membres du jury est envoyé par mails.");

                this.Close();

            }
            else
            {
                MessageBox.Show("Le nombre de membre pour ce jury est inférieur à 5 !");
            }
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
