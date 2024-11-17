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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ApplicationC
{
    public partial class FormAccueil : Form
    {
        List<Equipe> lesE;
        public FormAccueil(bool test)
        {
            InitializeComponent();
            panelDecoArret.BackColor = Color.FromArgb(120, 127, 127, 127);
            panelDecoArret.Visible = false;

            if (!test)
            {
                panelDecoArret.Location = new Point(440, 121);
                panelDecoArret.Visible = true;
            }
            else
            {
                panel2.Visible = true;
                panel3.Visible = true;
                panel4.Visible = true;
                panel5.Visible = true;
                dataGridViewHackRecent.Visible = true;

                var stats = ModeleHackathon.NombreHackathonsParAnEtParMois();

                var chart = new Chart
                {
                    Location = new Point(256, 198),
                    Size = new(744, 276)
                };

                var chartArea = new ChartArea("MainArea");
                chart.ChartAreas.Add(chartArea);

                var series = new Series("ExampleSeries")
                {
                    Name = "Hackathons",
                    ChartType = SeriesChartType.FastLine
                };

                chart.Series.Clear();
                chart.Series.Add(series);

                foreach (var stat in stats.OrderBy(x => x.Key.Year).ThenBy(x => x.Key.Month))
                {
                    string label = $"{stat.Key.Year}-{stat.Key.Month:D2}";
                    series.Points.AddXY(label, stat.Value);
                }

                chart.Titles.Clear();
                chart.Titles.Add("Nombre d'Hackathons par Mois et Année");
                chart.ChartAreas[0].AxisX.Title = "Mois et Année";
                chart.ChartAreas[0].AxisY.Title = "Nombre de Hackathons";

                this.Controls.Add(chart);

                labelNbEquipeMoyenParHack.Text = ModeleMembreEquipe.NombreMoyenEquipeParHackathon().ToString() + "/Hackathon";
                labelNbMembreMoyenParEquipe.Text = ModeleMembreEquipe.NombreMoyenMembreParEquipe().ToString() + "/Equipe";
                labelNbMoyenDesinscriptions.Text = ModeleMembreEquipe.NbEquipeMoyenDesinscription().ToString() + " %";
                labelNbHackathons.Text = ModeleHackathon.NombreHackathons().ToString() + " Hackathons";

                Hackathon recentHack = ModeleHackathon.HackathonLePlusRecentInscription();

                var data = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("Nom de l'hackathon", recentHack.Thematique),
                    new KeyValuePair<string, string>("Lieu de l'hackathon", recentHack.Lieu),
                    new KeyValuePair<string, string>("Ville de l'hackathon", recentHack.Ville),
                    new KeyValuePair<string, string>("Date de début", recentHack.Dateheuredebuth.ToString()),
                    new KeyValuePair<string, string>("Date de fin", recentHack.Dateheurefinh.ToString()),
                    new KeyValuePair<string, string>("Date de fin d'inscription", recentHack.Datefininscription.ToString()),
                    new KeyValuePair<string, string>("Nombre de places restantes", ModeleHackathon.NbInscriptionsRestantesHackathon(recentHack).ToString()),
                    new KeyValuePair<string,string>("Nombre d'équipes inscrite",ModeleHackathon.NbInscriptionsHackathon(recentHack).ToString()),
                };
                dataGridViewHackRecent.DataSource = data.Select(kvp => new { Titre = kvp.Key, Valeur = kvp.Value }).ToList();
            }
        }

        public FormAccueil(string demande)
        {
            InitializeComponent();
            panelDecoArret.Visible = false;

            if (demande == "demande")
            {
                lesE = ModeleEquipe.DemandeSuppression2FA();
                foreach (Equipe equipe in lesE)
                {
                    checkedListBoxDemande.Items.Add(equipe.Idequipe + ". " + equipe.Nomequipe);
                }
                panelCheckBoxList.Location = new Point(350, 10);
                panelCheckBoxList.Visible = true;
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
            panelDecoArret.Visible = false;
        }

        private void checkedListBoxDemande_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index >= 0 && e.Index < lesE.Count)
            {
                int selectedIndex = e.Index;
                int idEquipe = lesE[selectedIndex].Idequipe;
                Equipe eq = ModeleMembreEquipe.RecupererEquipe(idEquipe);

                Suppression2FAMod(eq);
                if (ModeleEquipe.DemandeSuppression2FACount() <= 0)
                {
                    panelCheckBoxList.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Indice invalide pour la sélection");
            }
        }

        private void buttonToutVerif_Click(object sender, EventArgs e)
        {
            foreach (Equipe eq in lesE)
            {
                Suppression2FAMod(eq);
            }
            panelCheckBoxList.Visible = false;
        }

        public void Suppression2FAMod(Equipe eq)
        {
            string subject;
            string body;

            if (ModeleEquipe.VerifSuppression2FA(eq.Idequipe))
            {
                subject = "Désactivation double authentification";
                body = "Bonjour, La demande de désactivation de la double authentification de votre équipe '" + eq.Nomequipe + "' a été accepté !";
            }
            else
            {
                subject = "Désactivation double authentification";
                body = "Bonjour, La demande de désactivation de la double authentification de votre équipe '" + eq.Nomequipe + "' a été annulé!\nle code était incorrect !";
            }
            List<Membre> membres = ModeleMembreEquipe.RecupererMembres(eq.Idequipe);
            List<string> dests = membres.Select(x => x.Email).ToList();
            dests.Add(eq.Login);
            Controleur.EmailSend(dests, subject, body);
        }
    }
}
