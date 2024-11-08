using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC.Model
{
    public static class ModeleEquipeJury
    {
        public static List<Equipejury> ListesEquipeJury()
        {
            return Modele.MonModel.Equipejuries.ToList();
        }

        public static List<Jury> ListeJuryParEquipe(int idEJ)
        {
            Equipejury equipe = Modele.MonModel.Equipejuries.Include(x => x.Idjuries).First(x => x.Idequipejury == idEJ);

            List<Jury> lJ = equipe.Idjuries.ToList();

            return lJ;
        }
    }
}
