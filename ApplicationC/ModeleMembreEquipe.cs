using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC
{
    public static class ModeleMembreEquipe
    {

        #region listeMembre & listeEquipe
        public static List<Membre> listeMembre()
        {
            return Modele.MonModel.Membres.Include(a => a.IdequipeNavigation).OrderBy(b => b.Idmembre).ToList();
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

        public static int CompteMembreEquipe ()
        {
            int nb = Modele.MonModel.Membres.Count();

            return nb;
        }
    }
}
