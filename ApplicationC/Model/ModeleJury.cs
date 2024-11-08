using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ApplicationC.Model
{
    public static class ModeleJury
    {
        public static int CountJury()
        {
            return Modele.MonModel.Juries.Count();
        }

        public static List<Jury> ListJury()
        {
            return Modele.MonModel.Juries.ToList();

            return null;
        }

        public static List<Jury> ListJuryParPage(int position)
        {
            int elementsParPage = 20;

            // Filtrer les hackathons non archivés
            var query = Modele.MonModel.Juries;

            // Appliquer la pagination
            return query.Skip((position - 1) * elementsParPage)
                        .Take(elementsParPage)
                        .ToList();
        }

        public static bool ajoutJury(string nom,string prenom,string email)
        {
            Jury unJury;
            bool vretour = true;
            try
            {
                unJury = new Jury();
                unJury.Nomjury = nom;
                unJury.Email = email;
                unJury.Prenomjury = prenom;

                Modele.MonModel.Juries.Add(unJury);
                Modele.MonModel.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static bool modifJury(int id, string nom,string prenom, string email)
        {
            Jury unJury;
            bool vretour = true;
            try
            {
                unJury = RecupererJury(id);
                unJury.Nomjury = nom;
                unJury.Email = email;
                unJury.Prenomjury = prenom;

                Modele.MonModel.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }

        public static List<Hackathon> ListJuryParHackathon(int idJury)
        {
            Jury j = Modele.MonModel.Juries.Include(x => x.Idhackathons).First(x => x.Idjury == idJury);

            List<Hackathon> lesH = j.Idhackathons.ToList();

            return lesH;
        }

        public static Jury RecupererJury(int idJury)
        {
            Jury unJury = new Jury();
            try
            {
                unJury = Modele.MonModel.Juries.First(x=>x.Idjury==idJury);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unJury;
        }
    }
}
