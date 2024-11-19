using ApplicationC.Entities;
using HarfBuzzSharp;
using iTextSharp.text.xml.xmp;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC.Model
{
    public enum EtatTypeGestion
    {
        Membre,
        Equipe
    }

    public static class ModeleMembreEquipe
    {
        #region listeMembre & listeEquipe
        public static List<Membre> listeMembre()
        {
            return Modele.MonModel.Membres.Include(a => a.IdequipeNavigation).OrderBy(b => b.Idmembre).ToList();
        }

        public static List<Membre> listeMembreSimple()
        {
            return Modele.MonModel.Membres.ToList();
        }

        public static List<Equipe> listeEquipeSimple()
        {
            return Modele.MonModel.Equipes.ToList();
        }

        public static List<Equipe> listeEquipe()
        {
            return Modele.MonModel.Equipes.OrderBy(b => b.Idequipe).ToList();
        }
        #endregion

        #region listeMembre & Equipe Par page
        public static List<Membre> listeMembreParPage(int position)
        {
            return Modele.MonModel.Membres.Where(c => c.Idmembre >= (position - 1) * 10).Include(a => a.IdequipeNavigation).OrderBy(b => b.Idmembre).ToList();
        }

        public static List<Equipe> listeEquipeParPage(int position)
        {
            return Modele.MonModel.Equipes.Where(c => c.Idequipe >= (position - 1) * 10).OrderBy(b => b.Idequipe).ToList();
        }
        #endregion

        #region CompteMembreEquipe
        public static int CompteMembreEquipe(string choix)
        {
            int nb = 0;

            if (choix == "membre")
            {
                nb = Modele.MonModel.Membres.Count();
            }
            else
            {
                nb = Modele.MonModel.Equipes.Count();
            }
            return nb;
        }
        #endregion

        #region listeMembreParEquipe
        public static List<Membre> listeMembreParEquipe(int idEquipe)
        {
            return Modele.MonModel.Membres.Include(p => p.IdequipeNavigation).Where(x => x.Idequipe == idEquipe).ToList();
        }
        #endregion

        public static Membre RecupererMembre(int idM)
        {
            Membre membre = new();
            try
            {
                membre = Modele.MonModel.Membres.First(x => x.Idmembre == idM);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return membre;  
        }

        public static List<Membre> RecupererMembres(int idE)
        {
            return Modele.MonModel.Membres.Where(x => x.Idequipe == idE).ToList();
        }

        public static bool ModificationMembre(int idmembre, string nom, string prenom, string email, string telephone, DateTime datenaiss, string lienportfolio)
        {
            Membre unMembre;
            bool modif = true;
            try
            {
                unMembre = RecupererMembre(idmembre);

                unMembre.Nom = nom;
                unMembre.Email = email;
                unMembre.Prenom = prenom;
                unMembre.Datenaissance = datenaiss;
                unMembre.Lienportfolio = lienportfolio;
                unMembre.Telephone = telephone;

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                modif = false;
                MessageBox.Show(ex.Message);
            }
            return modif;
        }

        public static bool AjoutMembre(string nom, string prenom, string email, string telephone, DateTime datenaiss, string lienportfolio)
        {
            Membre unMembre = new();
            bool modif = true;
            try
            {
                unMembre.Nom = nom;
                unMembre.Email = email;
                unMembre.Prenom = prenom;
                unMembre.Datenaissance = datenaiss;
                unMembre.Lienportfolio = lienportfolio;
                unMembre.Telephone = telephone;

                Modele.MonModel.Membres.Add(unMembre);
                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                modif = false;
                MessageBox.Show(ex.Message);
            }
            return modif;
        }

        public static Equipe RecupererEquipe(string login)
        {
            Equipe equipe = new();

            try
            {
                equipe = Modele.MonModel.Equipes.First(x => x.Login == login);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return equipe;
        }

        public static Equipe RecupererEquipe(int id)
        {
            Equipe equipe = new();

            try
            {
                equipe = Modele.MonModel.Equipes.First(x => x.Idequipe == id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return equipe;
        }

        public static bool ModificationEquipe(string logEq, string nomEq, string lienProto)
        {
            Equipe uneEquipe;
            bool modif = true;

            try
            {
                uneEquipe = RecupererEquipe(logEq);
                uneEquipe.Lienprototype = lienProto;
                uneEquipe.Nomequipe = nomEq;

                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                modif = false;
                MessageBox.Show(ex.Message);
            }
            return modif;
        }

        public static bool AjoutEquipe(string login, string nomEq, string lienProto)
        {
            Equipe equipe = new();
            bool crea = true;

            try
            {
                equipe.Login = login;
                equipe.Lienprototype = lienProto;
                equipe.Nomequipe = nomEq;

                Modele.MonModel.Equipes.Add(equipe);
                Modele.MonModel.SaveChanges();
            } catch (Exception ex)
            {
                crea = false;
                MessageBox.Show(ex.Message);
            }
            return crea;
        }

        public static double NombreMoyenEquipeParHackathon()
        {
            int val = 0;
            int countTotal = 0;
            int nbHackNonNull = 0;
            List<Hackathon> lesH = ModeleHackathon.HackathonsList();
            
            foreach (Hackathon h in lesH)
            {
                val = Modele.MonModel.Inscrires.Where(x=> x.Idhackathon == h.Idhackathon).Count();
                if (val > 0)
                {
                    countTotal += val;
                    nbHackNonNull++;
                    val = 0;
                }
            }
            if (nbHackNonNull == 0) return 0.0; // Éviter une division par zéro
            double value = (double)countTotal / nbHackNonNull;
            return Math.Round(value,2);
        }

        public static double NombreMoyenMembreParEquipe()
        {
            List<Equipe> lesE = Modele.MonModel.Equipes.ToList();
            List<Membre> lesM = Modele.MonModel.Membres.ToList();

            int nbEquipeConcerne = 0;
            int nbMembreE;
            foreach (Equipe equipe in lesE)
            {
                nbMembreE = 0;
                foreach (Membre membre in lesM)
                {
                    if (equipe.Idequipe == membre.Idequipe)
                    {
                        nbMembreE++;
                    }
                }
                if (nbMembreE > 0)
                {
                    nbEquipeConcerne++;
                }

            }

            int nbM = Modele.MonModel.Membres.Where(x=>x.Idequipe != null).Count();

            double value = (double)nbM / nbEquipeConcerne;
            return Math.Round(value,2);
        }

        public static double NbEquipeMoyenDesinscription()
        {
            return Math.Round(((double)Modele.MonModel.Inscrires.Where(x => x.Datedesinscription != null).Count() / Modele.MonModel.Inscrires.Count())*100,2);
        }

        public static List<Membre> ListMembreSansEquipe()
        {
            return Modele.MonModel.Membres.Where(x => x.Idequipe == null).ToList();
        }

        public static bool AjoutMembreInEquipe(Membre membre, int idEquipe)
        {
            bool ajout = true;

            try
            {
                Membre leMembre = membre;
                leMembre.Idequipe = idEquipe;
                Modele.MonModel.SaveChanges();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                ajout = false;
            }

            return ajout;
        }

        public static bool SuppMembreInEquipe(Membre membre)
        {
            bool supp = true;

            try
            {
                Membre leMembre = membre;
                leMembre.Idequipe = null;
                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                supp = false;
            }
            return supp;
        }
    }
}
