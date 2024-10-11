using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
    }
}
