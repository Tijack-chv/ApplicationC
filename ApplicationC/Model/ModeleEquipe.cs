using ApplicationC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC.Model
{
    public static class ModeleEquipe
    {
        public static List<Equipe> DemandeSuppression2FA()
        {
            return Modele.MonModel.Equipes.Where(x => x.CleSecretVerif != null).ToList();
        }

        public static int DemandeSuppression2FACount()
        {
            return Modele.MonModel.Equipes.Where(x => x.CleSecretVerif != null).Count();
        }

        public static bool VerifSuppression2FA(int idEquipe)
        {
            string message;
            bool supp = true;
            try
            {
                Equipe eq = ModeleMembreEquipe.RecupererEquipe(idEquipe);

                if (eq.CleSecretVerif == eq.CleSecret)
                {
                    eq.CleSecretVerif = null;
                    eq.CleSecret = null;
                    eq.Google2faSecret = null;
                    eq.Active = false;

                    message = "La suppression de la double authentification a bien été validé !";
                }
                else
                {
                    supp = false;
                    eq.CleSecretVerif = null;
                    message = "Le code fourni est incorrect, la demande de suppression de la double authentification a été annulé !";
                }
                ModeleLog.AjouterLog("equipe", idEquipe, DateTime.Now, message);

                Modele.MonModel.SaveChanges();


            }
            catch
            {
                MessageBox.Show("Erreur de vérification de la suppression 2FA !");
                supp = false;
            }

            return supp;
        }
    }
}
