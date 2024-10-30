using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Http;
using System.Drawing.Drawing2D;

namespace ApplicationC.Controller
{
    public static class Controleur
    {
        /// <summary>
        /// méthode qui retourne vrai ou faux selon la validité du format d'un email passé en paramètres
        /// </summary>
        /// <param name="mail"></param>
        /// <returns></returns>
        public static bool ValidMail(string mail)
        {

            string pattern = @"^([a-zA-Z0-9_\.]+)@([a-zA-Z0-9_\-]+)\.([\w]{2,4})$";
            Regex r1 = new Regex(pattern);
            return r1.IsMatch(mail);
        }

        /// <summary>
        /// permet l'envoi d'un mail sur le serveur smtp mis en place pour l'AP
        /// </summary>
        /// <param name="dest"></param>
        public static void CreationEmail(string dest, string nom, string prenom)
        {
            string to = dest;
            string from = "HackathonOrga@hackatinnov.com";
            MailMessage message = new MailMessage(from, to);
            message.Subject = "HACKAT'INNOV : AJOUT D'UN ORGANISATEUR";
            message.Body = "Bonjour " + nom + " " + prenom + ",\n\nNous validons la création de votre compte en tant que nouvel organisateur d'hackathons.\n\nBien Cordialement,\n\nHackat'Innov";
            SmtpClient client = new SmtpClient();

            client.Host = "mail.dombtsig.local";
            client.Port = 1025;

            // Credentials are necessary if the server requires the client
            // to authenticate before it will send email on the client's behalf.
            client.UseDefaultCredentials = true;

            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateEmail(): {0}", ex.ToString());
            }
        }

        /// <summary>
        /// méthode vérifiant si l'url en paramètre est accessible ou non
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static async Task<bool> IsUrlAccessible(string url)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    return response.IsSuccessStatusCode; // 2xx status code
                }
                catch
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// méthode vérifiant si l'url en paramètre est valide ou non
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static bool IsValidUrl(string url)
        {
            // Expression régulière pour valider une URL
            string pattern = @"^(http|https)://[a-zA-Z0-9\-\.]+\.[a-zA-Z]{2,}(/[^ ]*)?$";
            return Regex.IsMatch(url, pattern);
        }



        public static void RoundPanel(Panel panel, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Dessiner les coins arrondis du panel
            path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90); // Coin supérieur gauche
            path.AddArc(new Rectangle(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90); // Coin supérieur droit
            path.AddArc(new Rectangle(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90); // Coin inférieur droit
            path.AddArc(new Rectangle(0, panel.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90); // Coin inférieur gauche
            path.CloseFigure();

            panel.Region = new Region(path);
        }

        public static void RoundButton(Button button, int cornerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Dessiner les coins arrondis du bouton
            path.AddArc(new Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90); // Coin supérieur gauche
            path.AddArc(new Rectangle(button.Width - cornerRadius, 0, cornerRadius, cornerRadius), 270, 90); // Coin supérieur droit
            path.AddArc(new Rectangle(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90); // Coin inférieur droit
            path.AddArc(new Rectangle(0, button.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90); // Coin inférieur gauche
            path.CloseFigure();

            button.Region = new Region(path);
        }
    }
}
