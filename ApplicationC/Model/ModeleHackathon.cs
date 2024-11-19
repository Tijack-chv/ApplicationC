using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationC.Model
{
    public static class ModeleHackathon
    {
        #region listeHackathons
        /// <summary>
        /// Retourne la liste des hackathons en incluant l'organisateur
        /// </summary>
        /// <returns></returns>
        public static List<Hackathon> listeHackathons()
        {
            return Modele.MonModel.Hackathons.Include(a => a.IdorganisateurNavigation).OrderBy(b => b.Idhackathon).ToList();
        }
        #endregion

        #region listeHackathonsParPage
        /// <summary>
        /// Nouvelle référence de la méthode d'affichage des hackathons en incluant l'organisateur mais également en incluant le système d'affichage par page
        /// estArchive inclus dans le tri de l'affichage
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static List<Hackathon> listeHackathonsParPage(int position)
        {
            int elementsParPage = 20;

            // Filtrer les hackathons non archivés
            var query = Modele.MonModel.Hackathons
                .Where(c => c.Estarchive == false)
                .Include(a => a.IdorganisateurNavigation)
                .OrderBy(b => b.Idhackathon);

            // Appliquer la pagination
            return query.Skip((position - 1) * elementsParPage)
                        .Take(elementsParPage)
                        .ToList();
        }
        #endregion

        #region CountPlaceRestantes
        public static int CountPlaceRestantes(int idH)
        {
            int value = 0;

            value = Modele.MonModel.Inscrires.Where(x => x.Idhackathon == idH).Where(x=> x.Datedesinscription == null).Count();

            return value;
        }
        #endregion

        #region CountHackathon
        /// <summary>
        /// Pour savoir le nombre de page max à avoir pour éviter toute erreur
        /// estArchive inclus dans le count
        /// </summary>
        /// <returns></returns>
        public static int CountHackathon()
        {
            return Modele.MonModel.Hackathons.Where(c => c.Estarchive == false).Count();
        }
        #endregion

        #region hachathonEstArchive
        /// <summary>
        /// Permet d'archiver un hackathon afin de pouvoir l'enlever de l'affichage
        /// </summary>
        /// <param name="idh"></param>
        /// <returns></returns>
        public static bool hackathonEstArchive(int idh)
        {
            bool estArchive = true;
            Hackathon unHackathon;

            try
            {
                unHackathon = RecupererHackathon(idh);

                unHackathon.Estarchive = true;

                Modele.MonModel.SaveChanges();
            }
            catch (Exception e)
            {
                estArchive = false;
                MessageBox.Show(e.Message.ToString());
            }

            return estArchive;
        }
        #endregion

        #region listeHackathonsParDateMin
        /// <summary>
        /// Retourne la liste des hackathons en incluant l'organisateur et avec une date minimum
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<Hackathon> listeHackathonsParDateMin(DateTime date)
        {
            return Modele.MonModel.Hackathons.Where(p => p.Dateheuredebuth >= date).OrderBy(a => a.Idhackathon).Include(a => a.IdorganisateurNavigation).ToList();
        }
        #endregion

        #region listeEquipesParHackathon
        /// <summary>
        /// Retourne la liste des équipes inscrites à l'hackathon dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idH"></param>
        /// <returns></returns>
        public static List<Equipe> listeEquipesParHackathon(int idH)
        {
            Hackathon h = Modele.MonModel.Hackathons.Include(p => p.Inscrires).ThenInclude(p => p.IdequipeNavigation).First(x => x.Idhackathon == idH);

            List<Inscrire> lesI = h.Inscrires.Where(x=> x.Datedesinscription == null).ToList();

            List<Equipe> lesE = new List<Equipe>();
            foreach (Inscrire I in lesI)
            {
                lesE.Add(I.IdequipeNavigation);
            }

            return lesE;
        }
        #endregion

        #region ListeMembreJuryParHackathon
        public static List<Jury> ListeMembresJuryParHackathon(int idH)
        {
             Hackathon H = Modele.MonModel.Hackathons.Include(x => x.Compositions).First(x => x.Idhackathon == idH);

            List<Composition> lesC = H.Compositions.ToList();

            List<Jury> jurys = ModeleJury.ListJury();

            List<Jury> lesJ = new List<Jury>();
            foreach (Composition compo in lesC)
            {
                foreach (Jury jury in jurys)
                {
                    if (compo.Idjury == jury.Idjury)
                    {
                        lesJ.Add(jury);
                    }
                }
            }

            return lesJ;
        }
        #endregion

        #region listeHackathonParEquipe
        public static List<Hackathon> listeHackathonParEquipe(int idE)
        {
            Equipe e = Modele.MonModel.Equipes.Include(p=> p.Inscrires).ThenInclude(p=> p.IdhackathonNavigation).First(x=> x.Idequipe == idE); 

            List<Inscrire> lesI = e.Inscrires.Where(x=> x.Datedesinscription==null).ToList();

            List<Hackathon> lesH = new List<Hackathon>();
            foreach (Inscrire I in lesI)
            {
                lesH.Add(I.IdhackathonNavigation);
            }

            return lesH;
        }
        #endregion

        #region desinscriptionEquipe
        public static bool desinscriptionEquipe(int idHackathon, int idEquipe)
        {
            bool modif = true;
            try
            {
                Inscrire inscriptionEquipe = RecupererInscriptionEquipe(idHackathon, idEquipe);
                inscriptionEquipe.Datedesinscription = DateTime.Now;

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                modif = false;
                MessageBox.Show(ex.Message.ToString());
            }

            return modif;
        }
        #endregion

        #region RetourneDernierHackathonSaisi
        /// <summary>
        /// Retourne l'identifiant du dernier hackathon saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetourneDernierHackathonSaisi()
        {
            return Modele.MonModel.Hackathons.Max(x => x.Idhackathon);
        }
        #endregion

        #region AjoutHackathon
        /// <summary>
        /// Retourne vrai si l'ajout d'un hackathon a pu avoir lieu en BD
        /// Faux sinon
        /// </summary>
        /// <param name="lieu"></param>
        /// <param name="ville"></param>
        /// <param name="thematique"></param>
        /// <param name="objectifs"></param>
        /// <param name="conditions"></param>
        /// <param name="affiche"></param>
        /// <param name="dateD"></param>
        /// <param name="dateF"></param>
        /// <param name="nbPlaceMaxEq"></param>
        /// <param name="dateFinInscription"></param>
        /// <param name="idOrganisateur"></param>
        /// <returns></returns>
        public static bool AjoutHackathon(string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int nbPlaceMaxEquipe, DateTime dateFinInscription, int idOrganisateur)
        {
            Hackathon unHackathon;
            bool vretour = true;
            try
            {
                // ajout dans la table commande
                unHackathon = new Hackathon();
                unHackathon.Lieu = lieu;
                unHackathon.Ville = ville;
                unHackathon.Thematique = thematique;
                unHackathon.Conditions = conditions;
                unHackathon.Objectifs = objectifs;
                unHackathon.Affiche = affiche;
                unHackathon.Dateheuredebuth = dateD;
                unHackathon.Dateheurefinh = dateF;
                unHackathon.Nbplaceeqmax = nbPlaceMaxEquipe;
                unHackathon.Datefininscription = dateFinInscription;
                unHackathon.Idorganisateur = idOrganisateur;

                Modele.MonModel.Hackathons.Add(unHackathon);
                Modele.MonModel.SaveChanges();

            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        #endregion

        #region RecupererHackathon
        /// <summary>
        /// Fonction qui retourne l'objet hackathon qui correspond à l'identifiant passé en paramètre 
        /// </summary>
        /// <param name="idH">identifiant de l'hackathon</param>
        /// <returns></returns>
        public static Hackathon RecupererHackathon(int idH)
        {
            Hackathon unHackathon = new Hackathon();
            try
            {
                unHackathon = Modele.MonModel.Hackathons.First(x => x.Idhackathon == idH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return unHackathon;
        }
        #endregion

        #region RecupererInscriptionEquipe
        public static Inscrire RecupererInscriptionEquipe(int idH, int idE)
        {
            Inscrire uneInscription = new();

            try
            {
                uneInscription = Modele.MonModel.Inscrires.First(x => x.Idhackathon == idH && x.Idequipe == idE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return uneInscription;
        }
        #endregion

        #region ModificationHackathon
        /// <summary>
        /// Retourne vrai si la modification de l'hackathon dont l'identifiant est passé en paramètre a pu avoir lieu
        /// </summary>
        /// <param name="idH"></param>
        /// <param name="lieu"></param>
        /// <param name="ville"></param>
        /// <param name="thematique"></param>
        /// <param name="objectifs"></param>
        /// <param name="conditions"></param>
        /// <param name="affiche"></param>
        /// <param name="dateD"></param>
        /// <param name="dateF"></param>
        /// <param name="nbPlaceMaxEquipe"></param>
        /// <param name="dateFinInscription"></param>
        /// <param name="idOrganisateur"></param>
        /// <returns></returns>
        public static bool ModificationHackathon(int idH, string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int nbPlaceMaxEquipe, DateTime dateFinInscription, int idOrganisateur)
        {
            Hackathon unHackathon;
            bool vretour = true;
            try
            {
                // récupération de l'hackathon à modifier
                unHackathon = RecupererHackathon(idH);

                // mise à jour des champs de l'hackathon
                unHackathon.Lieu = lieu;
                unHackathon.Ville = ville;
                unHackathon.Thematique = thematique;
                unHackathon.Conditions = conditions;
                unHackathon.Objectifs = objectifs;
                unHackathon.Affiche = affiche;
                unHackathon.Dateheuredebuth = dateD;
                unHackathon.Dateheurefinh = dateF;
                unHackathon.Nbplaceeqmax = nbPlaceMaxEquipe;
                unHackathon.Datefininscription = dateFinInscription;
                unHackathon.Idorganisateur = idOrganisateur;

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                vretour = false;
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
            return vretour;
        }
        #endregion

        #region FirstDate
        public static DateTime FirstDate()
        {
            
            DateTime date = Modele.MonModel.Hackathons.Where(x=> !x.Estarchive).Min(x=> x.Datefininscription);

            return date;
        }
        #endregion

        #region LastDate
        public static DateTime LastDate()
        {
            DateTime date = Modele.MonModel.Hackathons.Where(x => !x.Estarchive).Max(x => x.Datefininscription);

            return date;
        }
        #endregion

        #region NombreHackathonsParAnEtParMois
        public static Dictionary<(int Year, int Month), int> NombreHackathonsParAnEtParMois()
        {
            var hackathons = Modele.MonModel.Hackathons
                              .GroupBy(x => new { x.Dateheuredebuth.Year, x.Dateheuredebuth.Month }) // Grouper par année et mois
                              .Select(g => new { g.Key.Year, g.Key.Month, Count = g.Count() }) // Compter par groupe
                              .ToDictionary(g => (g.Year, g.Month), g => g.Count); // Transformer en dictionnaire

            return hackathons; // Renvoie un dictionnaire : clé = (année, mois), valeur = nombre de hackathons
        }
        #endregion

        #region NombreHackathons
        public static int NombreHackathons()
        {
            return Modele.MonModel.Hackathons.Count();
        }
        #endregion

        #region HackathonsList
        public static List<Hackathon> HackathonsList()
        {
            return Modele.MonModel.Hackathons.ToList();
        }
        #endregion

        #region HackathonLePlusRecentInscription
        public static Hackathon HackathonLePlusRecentInscription()
        {
            var today = DateTime.Now;

            // Récupérer d'abord les hackathons en mémoire
            var hackathons = Modele.MonModel.Hackathons
                                  .Where(x => !x.Estarchive) // Filtrer par hackathons non archivés
                                  .ToList(); // Charger tous les hackathons en mémoire

            // Trouver l'hackathon avec la date la plus proche en utilisant LINQ côté client
            var hackathonProche = hackathons
                                  .OrderBy(x => Math.Abs((x.Datefininscription - today).Ticks)) // Trier par la différence en ticks
                                  .FirstOrDefault(); // Prendre le premier (le plus proche)

            return hackathonProche;
        }
        #endregion

        #region NbInscriptionsRestantesHackathon
        public static int NbInscriptionsRestantesHackathon(Hackathon hack)
        {
            int nbPlaceMax = hack.Nbplaceeqmax;

            int nbPlacesPrises = hack.Inscrires.Count();

            return nbPlaceMax-nbPlacesPrises;
        }
        #endregion

        #region NbInscriptionsHackathon
        public static int NbInscriptionsHackathon(Hackathon hack)
        {
            return Modele.MonModel.Inscrires.Where(x=>x.Idhackathon == hack.Idhackathon).Count();
        }
        #endregion
    }
}
