using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Http;
using System.Drawing.Drawing2D;
using System.Security.Policy;
using ApplicationC.Entities;
using System.Xml.Linq;
using iTextSharp.text.pdf;
using iTextSharp.text;
using ApplicationC.Model;

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

        public static void EmailSend(List<string> dests, string subject, string body)
        {
            string from = "HackathonOrga@hackatinnov.com";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(from);
            message.Subject = subject;
            message.Body = body;

            if (subject == "Convocation Jury")
            {
                //Attachment attachment = new Attachment();
                //message.Attachments.Add(attachment);
            }

            foreach (string dest in dests)
            {
                message.To.Add(new MailAddress(dest));
            }

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

        public static void EmailSend(List<string> dests, string subject, string body, int idHack, string path)
        {
            string from = "HackathonOrga@hackatinnov.com";
            MailMessage message = new MailMessage();
            message.From = new MailAddress(from);
            message.Subject = subject;
            message.Body = body;

            Hackathon hackathon = ModeleHackathon.RecupererHackathon(idHack);
            Organisateur organisateur = ModeleOrganisateur.RecupererOrganisateur(Convert.ToInt32(hackathon.Idorganisateur));
            
            GenererConvocationPDF(hackathon.Thematique, hackathon.Dateheuredebuth, hackathon.Dateheurefinh, hackathon.Ville, hackathon.Lieu, organisateur.Nom, organisateur.Prenom, organisateur.Email,path);

            Attachment attachment = new(path);
            message.Attachments.Add(attachment);
  
            foreach (string dest in dests)
            {
                message.To.Add(new MailAddress(dest));
            }

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

        public static void GenererConvocationPDF(string thematique, DateTime dateDebut, DateTime dateFin, string ville, string lieu, string nomOrganisateur, string prenomOrganisateur, string contactOrganisateur, string path)
        {
            Document document = new Document();
            try
            {
                PdfWriter.GetInstance(document, new FileStream(path, FileMode.Create));
                document.Open();

                // Titre
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
                Paragraph title = new Paragraph("Convocation de Jury\n\n", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                document.Add(title);

                // Thématique
                var contentFont = FontFactory.GetFont(FontFactory.HELVETICA, 12);
                Paragraph thematiquePara = new Paragraph($"Thématique de l'évènement : {thematique}\n\n", contentFont);
                document.Add(thematiquePara);

                // Salutation
                Paragraph salutation = new Paragraph($"Monsieur/Madame,\n\n", contentFont);
                document.Add(salutation);

                // Corps de texte
                string corpsTexte = $"Nous avons le plaisir de vous convoquer pour participer au jury de l'évènement qui se tiendra selon les informations suivantes :\n\n" +
                                    $"- Date de début : {dateDebut}\n" +
                                    $"- Date de fin : {dateFin}\n" +
                                    $"- Ville : {ville}\n" +
                                    $"- Lieu : {lieu}\n\n" +
                                    "Vous êtes invité(e) en tant que membre du jury pour évaluer et délibérer sur les projets présentés dans le cadre de cette thématique. " +
                                    "Votre expertise et vos connaissances seront essentielles pour le bon déroulement des évaluations et pour assurer un jugement de qualité.\n\n" +
                                    $"Merci de bien vouloir confirmer votre présence avant le [Date limite de confirmation] en contactant l'organisateur aux coordonnées suivantes :\n\n";
                document.Add(new Paragraph(corpsTexte, contentFont));

                // Informations de l'organisateur
                Paragraph organisateur = new Paragraph($"Organisateur :\nNom : {nomOrganisateur}\nPrénom : {prenomOrganisateur}\nContact : {contactOrganisateur}\n\n", contentFont);
                document.Add(organisateur);

                // Remerciements
                Paragraph remerciements = new Paragraph("Nous vous remercions de votre engagement et espérons vous compter parmi nous pour cet évènement important.\n\nCordialement,\n\nL'équipe organisatrice", contentFont);
                document.Add(remerciements);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de la création du PDF : {ex.Message}");
            }
            finally
            {
                document.Close();
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
    }
}
