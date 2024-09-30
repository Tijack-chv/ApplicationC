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
    public partial class FormGestionMembreEquipe : Form
    {
        public FormGestionMembreEquipe()
        {
            InitializeComponent();
            // localisation good : 12, 12
            // localisation retrait : 12, 370
            panelGestionMembre.BackColor = Color.FromArgb(160, 127, 127, 127);
            panelGestionEquipe.BackColor = Color.FromArgb(160, 127, 127, 127);
        }

        public FormGestionMembreEquipe(EtatGestion etatGestion, EtatTypeGestion etatTypeGestion)
        {
            InitializeComponent();
            affichage(etatGestion, etatTypeGestion);
        }

        public void affichage (EtatGestion etatGestion, EtatTypeGestion etatTypeGestion)
        {
            if (etatGestion == EtatGestion.Create)
            {
                if (etatTypeGestion == EtatTypeGestion.Membre)
                {
                    // Crea Membre
                    panelGestionMembre.Visible = true;
                    panelGestionMembre.Location = new Point(12, 12);
                    panelGestionEquipe.Location = new Point(12, 370);
                    panelGestionEquipe.Visible = false;
                }
                else
                {
                    // Crea Equipe
                    panelGestionEquipe.Visible = true;
                    panelGestionEquipe.Location = new Point(12, 12);
                    panelGestionMembre.Location = new Point(12, 370);
                    panelGestionMembre.Visible = false;
                }
            }
            else
            {
                if (etatTypeGestion == EtatTypeGestion.Membre)
                {
                    // Modif Membre
                    panelGestionMembre.Visible = true;
                    panelGestionMembre.Location = new Point(12, 12);
                    panelGestionEquipe.Location = new Point(12, 370);
                    panelGestionEquipe.Visible = false;
                }
                else
                {
                    // Modif Equipe
                    panelGestionEquipe.Visible = true;
                    panelGestionEquipe.Location = new Point(12, 12);
                    panelGestionMembre.Location = new Point(12, 370);
                    panelGestionMembre.Visible = false;
                }
            }
        }
    }
}
