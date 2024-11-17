using ApplicationC.Model;
namespace ApplicationC.Controller
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Modele.init();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new FormHome());
            //tempo pour les tests admin@hackathon.fr
            Application.Run(new FormAdminConnexion());
        }
    }
}