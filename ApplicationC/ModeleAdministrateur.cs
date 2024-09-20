using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using BC = BCrypt.Net.BCrypt;

namespace ApplicationC
{
    public static class ModeleAdministrateur
    {
        public static Administrateur RecupererAdmin(string login)
        {
            Administrateur admin = new ();
            try
            {
                admin = Modele.MonModel.Administrateurs.First(a => a.Email == login);
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'adresse mail saisie n'est pas reconnu !");
            }
            return admin;
        }

        public static bool ConnexionAdmin(string mail, string mdp)
        {
            bool connexion = true;
            
            Administrateur admin = new Administrateur();

            admin = RecupererAdmin(mail);

            if (admin.Idadministrateur == 0)
            {
                connexion = false;
            } else if (!BC.Verify(mdp, admin.Motpasse))
            {
                MessageBox.Show("Le mot de passe est incorrect !");
                connexion = false;
            }
            return connexion;
        }
    }
}
