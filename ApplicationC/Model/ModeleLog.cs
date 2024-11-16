using ApplicationC.Entities;
using Microsoft.EntityFrameworkCore;
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

        public static List<Log> ListLog()
        {
            return Modele.MonModel.Logs.ToList();
        }

        public  static List<Log> ListLogParPage(int position)
        {
            int elementsParPage = 20;

            return Modele.MonModel.Logs.Skip((position - 1) * elementsParPage)
                        .Take(elementsParPage)
                        .ToList();
        }

        public static int CountLogs()
        {
            return Modele.MonModel.Logs.Count();
        }

        public static Log RecupererLog(int id)
        {
            Log log = new();
            try
            {
                log = Modele.MonModel.Logs.First(a => a.Idlog == id);
            }
            catch
            {
                MessageBox.Show("Log non retrouvé !");
            }
            return log;
        }
    }
}
