﻿using ApplicationC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationC.Model
{
    public static class ModeleLog
    {
        public static void AjouterLog(string adminOuEquipe,int id,DateTime timestamp,string message)
        {
            //String timeStamp = GetTimestamp(DateTime.Now);

            try
            {
                Log log = new Log();

                if (adminOuEquipe == "admin")
                {
                    log.Idadmin = id;
                } else
                {
                    log.Idequipe = id;
                }
                log.CreatedAt = timestamp;
                log.UpdatedAt = timestamp;
                log.Description = message;

                Modele.MonModel.Logs.Add(log);
                Modele.MonModel.SaveChanges();

            } catch
            {
                MessageBox.Show("Erreur affichage log");
            }
        }
    }
}
