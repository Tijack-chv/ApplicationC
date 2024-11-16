using ApplicationC.Entities;
using ApplicationC.Model;
using Org.BouncyCastle.Asn1.Cmp;
using OtpNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationC.View
{
    public partial class Form2FATest : Form
    {
        private Administrateur admin;
        private int count = 0;
        public Form2FATest(Administrateur administrateur)
        { 
            InitializeComponent();
            admin = administrateur;

            label1.Text = "Vérifier Connexion\nTOTP";
        }

        private void button2FA_Click(object sender, EventArgs e)
        {
            string userInputCode = textBox1.Text.Trim();

            // Conversion du secret partagé en bytes
            byte[] secretBytes = Base32Encoding.ToBytes(admin.SharedSecret);

            // Génération de l'instance TOTP
            var totp = new Totp(secretBytes);

            // Récupération du code actuel
            string generatedCode = totp.ComputeTotp();

            // Validation du code entré par l'utilisateur
            if (totp.VerifyTotp(userInputCode, out long timeStepMatched, VerificationWindow.RfcSpecifiedNetworkDelay))
            {
                this.Close();
                FormHome formHome = new(admin);
                formHome.Show();
            }
            else
            {
                if (count < 3)
                {
                    label1.Text = "Code TOTP invalide.\nVeuillez réessayer.";
                    label1.ForeColor = System.Drawing.Color.Red;
                    count++;
                } else
                {
                    string message = "L'administrateur a essayé plus de 3 fois la connexion TOTP !";
                    ModeleLog.AjouterLog("admin",admin.Idadministrateur, DateTime.Now, message);
                    Application.Exit();
                }
            }
        }
    }
}
