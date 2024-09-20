﻿using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationC
{
    public static class ModeleHackathon
    {
        /// <summary>
        /// Retourne la liste des hackathons en incluant l'organisateur
        /// </summary>
        /// <returns></returns>
        public static List<Hackathon> listeHackathons()
        {
            return Modele.MonModel.Hackathons.Include(a => a.IdorganisateurNavigation).OrderBy(b=> b.Idhackathon).ToList();
        }


        public static List<Hackathon> listeHackathonsParPage(int position)
        {
            return Modele.MonModel.Hackathons.Include(a => a.IdorganisateurNavigation).OrderBy(a=> a.Idhackathon).Skip(position).Take(5).ToList();
        }


        /// <summary>
        /// Retourne la liste des hackathons en incluant l'organisateur et avec une date minimum
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static List<Hackathon> listeHackathonsParDateMin(DateTime date)
        {
            return Modele.MonModel.Hackathons.Where(p=> p.Dateheuredebuth >= date).OrderBy(a=> a.Idhackathon).Include(a => a.IdorganisateurNavigation).ToList();
        }

        /// <summary>
        /// Retourne la liste des équipes inscrites à l'hackathon dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idH"></param>
        /// <returns></returns>
        public static List<Equipe> listeEquipesParHackathon(int idH)
        {
            // List<Equipe> lesEquipes = Modele.MonModel.Hackathons.Where(p => p.Numcli == idClient).Include(p => p.NumcliNavigation).ToList();

            // parcourir les équipes et récupérer celle de l'hackathon
            Hackathon h = Modele.MonModel.Hackathons.Include(p => p.Inscrires).ThenInclude(p => p.IdequipeNavigation).First(x => x.Idhackathon == idH);
         //   Hackathon h = (Hackathon) Modele.MonModel.Hackathons.Where(p => p.Idhackathon == idH).Include(p => p.Inscrires);

            List<Inscrire> lesI = h.Inscrires.ToList();

            List<Equipe> lesE = new List<Equipe>();
            foreach (Inscrire I in lesI)
            {
                lesE.Add(I.IdequipeNavigation);
            }
          
            return lesE;
        }


        /// <summary>
        /// Retourne l'identifiant du dernier hackathon saisi dans la BD
        /// </summary>
        /// <returns></returns>
        public static int RetourneDernierHackathonSaisi()
        {
            return Modele.MonModel.Hackathons.Max(x => x.Idhackathon);
        }

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

        #region Modification Hackathon
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
        public static bool ModificationHackathon(int idH, string lieu, string ville, string thematique, string objectifs, string conditions, string affiche, DateTime dateD, DateTime dateF, int nbPlaceMaxEquipe, DateTime dateFinInscription,  int idOrganisateur)
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
                MessageBox.Show(ex.Message.ToString());
            }
            return vretour;
        }
        #endregion


    }
}
