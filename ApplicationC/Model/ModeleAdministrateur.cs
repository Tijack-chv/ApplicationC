﻿using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using BC = BCrypt.Net.BCrypt;

namespace ApplicationC.Model
{
    public static class ModeleAdministrateur
    {
        #region RecupererAdmin
        public static Administrateur RecupererAdmin(string login)
        {
            Administrateur admin = new();
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

        public static Administrateur RecupererAdmin(int id)
        {
            Administrateur admin = new();
            try
            {
                admin = Modele.MonModel.Administrateurs.First(a => a.Idadministrateur == id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("L'adresse mail saisie n'est pas reconnu !");
            }
            return admin;
        }
        #endregion

        #region ConnexionAdmin
        public static bool ConnexionAdmin(string mail, string mdp)
        {
            bool connexion = true;

            Administrateur admin = new();

            admin = RecupererAdmin(mail);

            if (admin.Idadministrateur == 0)
            {
                connexion = false;
            }
            else if (!BC.Verify(mdp, admin.Motpasse))
            {
                MessageBox.Show("Le mot de passe est incorrect !");
                connexion = false;
            }
            return connexion;
        }
        #endregion

        #region ModificationMdpAdmin
        public static bool ModificationMdpAdmin(string mail, string mdp)
        {
            bool modification = true;

            Administrateur administrateur = new();
            try
            {
                administrateur = RecupererAdmin(mail);

                string mdpHash = BC.HashPassword(mdp);

                administrateur.Motpasse = mdpHash;

                Modele.MonModel.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                modification = false;
            }
            return modification;
        }
        #endregion

        #region Update2FA
        public static bool update2FA(string mail, String sharedSecret)
        {
            bool update = true;
            try
            {
                Administrateur admin = RecupererAdmin(mail);
                admin.SharedSecret = sharedSecret;
                Modele.MonModel.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                update = false;
            }
            return update;
        }
        #endregion
    }
}
