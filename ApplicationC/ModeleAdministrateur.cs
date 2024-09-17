using ApplicationC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC
{
    public static class ModeleAdministrateur
    {
        public static Administrateur ConnexionAdmin(string mail, string mdp)
        {
            //revoir cette partie pour la recherche d'un élément dans la bdd 
            
            Administrateur admin = new Administrateur();

            admin = Modele.MonModel.Administrateurs.Find(mail, mdp);

            return admin;
        }
    }
}
