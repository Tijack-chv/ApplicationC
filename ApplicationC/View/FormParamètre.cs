using ApplicationC.Entities;
using ApplicationC.Model;
using Org.BouncyCastle.Asn1.Cmp;
using OtpNet;
using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationC
{
    public partial class FormParamètre : Form
    {
        Administrateur administrateur = new();
        private string _sharedSecret;
        public FormParamètre(Administrateur admin)
        {
            InitializeComponent();
            administrateur = admin;
            progressBarMdp.Value = 1;
            panelMdp.Visible = false;
            panelInfoPers.Visible = false;

            textBox2FA.PasswordChar = administrateur.SharedSecret != null ? '*' : '\0';
            button2FA.Text = administrateur.SharedSecret != null ? "Enlever" : "Ajouter";

            if (administrateur.SharedSecret == null)
            {
                GenerateSharedSecret();
                GenerateQRCode(admin.Email);
            }
        }
        private void GenerateSharedSecret()
        {
            // Génération d'une clé aléatoire de 20 octets
            byte[] secretBytes = KeyGeneration.GenerateRandomKey(20);
            _sharedSecret = Base32Encoding.ToString(secretBytes); // Convertir en Base32 pour TOTP
        }

        private void GenerateQRCode(string adminaccount)
        {
            // Création de l'URI pour le TOTP (nom de compte et service personnalisable)
            string accountName = adminaccount; // Nom de l'utilisateur ou email
            string issuer = "ApplicationC"; // Nom de l'application ou service
            string totpUri = $"otpauth://totp/{issuer}:{accountName}?secret={_sharedSecret}&issuer={issuer}";

            // Génération du QR Code
            using (var qrGenerator = new QRCodeGenerator())
            using (var qrCodeData = qrGenerator.CreateQrCode(totpUri, QRCodeGenerator.ECCLevel.Q))
            using (var qrCode = new QRCode(qrCodeData))
            {
                pictureBox2FA.Image = qrCode.GetGraphic(10); // Taille de l'image QR Code
            }
        }

        private void motDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInfoPers.Visible = false;
            panelInfoPers.Location = new Point(420, 52);

            panel2FA.Visible = false;
            panel2FA.Location = new Point(140, 160);


            panelMdp.BackColor = Color.FromArgb(120, 127, 127, 127);
            panelMdp.Visible = true;
        }

        private void informationsPersonnelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMdp.Visible = false;

            panelInfoPers.Location = new Point(433, 160);
            panelInfoPers.BackColor = Color.FromArgb(120, 127, 127, 127);

            panel2FA.Visible = false;
            panel2FA.Location = new Point(140, 160);

            panelInfoPers.Visible = true;
            textBoxEmail.Text = administrateur.Email;
            textBoxFirstName.Text = administrateur.Nom;
            textBoxName.Text = administrateur.Prenom;
        }

        private void sécuritéSuppléToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (administrateur.SharedSecret == null)
            {
                labelInfo2FA.Text = "Saisir le code fourni avec le QrCode\n" +
                                "pour activer la double authentification";

            } else
            {
                labelInfo2FA.Text = "Cliquer sur le bouton pour enlever\n" +
                    "la double authentification !";
            }
            panelInfoPers.Visible = false;
            panelMdp.Visible = false;
                                
            panel2FA.Location = new Point(433, 160);
            panel2FA.BackColor = Color.FromArgb(120, 127, 127, 127);
            panel2FA.Visible = true;
        }

        #region Placeholder
        private void textBoxAncienMdp_Enter(object sender, EventArgs e)
        {
            if (textBoxAncienMdp.Text == "mot de passe")
            {
                textBoxAncienMdp.Text = "";
            }
        }

        private void textBoxAncienMdp_Leave(object sender, EventArgs e)
        {
            if (textBoxAncienMdp.Text == "")
            {
                textBoxAncienMdp.Text = "mot de passe";
            }
        }

        private void textBoxNvMdp_Enter(object sender, EventArgs e)
        {
            if (textBoxNvMdp.Text == "mot de passe")
            {
                textBoxNvMdp.Text = "";
            }
        }

        private void textBoxNvMdp_Leave(object sender, EventArgs e)
        {
            if (textBoxNvMdp.Text == "")
            {
                textBoxNvMdp.Text = "mot de passe";
            }
        }

        private void textBox2NvMdp_Enter(object sender, EventArgs e)
        {
            if (textBox2NvMdp.Text == "mot de passe")
            {
                textBox2NvMdp.Text = "";
            }
        }

        private void textBox2NvMdp_Leave(object sender, EventArgs e)
        {
            if (textBox2NvMdp.Text == "")
            {
                textBox2NvMdp.Text = "mot de passe";
            }
        }
        #endregion

        private void buttonValiderMdp_Click(object sender, EventArgs e)
        {
            if (textBoxAncienMdp.Text == "" || textBoxAncienMdp.Text == "mot de passe" || textBoxNvMdp.Text == "" || textBoxNvMdp.Text == "mot de passe" || textBox2NvMdp.Text == "" || textBox2NvMdp.Text == "mot de passe")
            {
                MessageBox.Show("Vous devez saisir tous les champs présentés !");
            }
            else
            {
                if (textBoxNvMdp.Text != textBox2NvMdp.Text)
                {
                    MessageBox.Show("Le nouveau mot de passe n'est pas le même que la vérification !");
                }
                else
                {
                    if (textBoxNvMdp.Text.Length < 8)
                    {
                        MessageBox.Show("Le nouveau mot de passe n'a pas la sécurité nécessaire pour être modifié !");
                    }
                    else
                    {
                        if (ModeleAdministrateur.ModificationMdpAdmin(administrateur.Email, textBoxNvMdp.Text))
                        {
                            MessageBox.Show("Mot de passe modifié !");
                        }
                    }
                }
            }
        }

        private void buttonAnnulerMdp_Click(object sender, EventArgs e)
        {
            panelMdp.Visible = false;
        }

        private void buttonAnnulerInfoPers_Click(object sender, EventArgs e)
        {
            panelInfoPers.Visible = false;
        }

        private void textBoxNvMdp_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNvMdp.Text != "mot de passe")
            {
                if (textBoxNvMdp.Text.Length >= 6)
                {
                    if (textBoxNvMdp.Text.Length >= 8)
                    {
                        if (textBoxNvMdp.Text.Length >= 10)
                        {
                            if (textBoxNvMdp.Text.Length >= 12)
                            {
                                progressBarMdp.Value = 10;
                            }
                            else { progressBarMdp.Value = 8; }
                        }
                        else { progressBarMdp.Value = 5; }
                    }
                    else { progressBarMdp.Value = 3; }
                }
                else { progressBarMdp.Value = 1; }
            }
        }

        private void labelShow_Click(object sender, EventArgs e)
        {
            if (labelShow.Text == "Show")
            {
                labelShow.Text = "Hide";
                textBoxAncienMdp.PasswordChar = '\0';
                textBoxNvMdp.PasswordChar = '\0';
                textBox2NvMdp.PasswordChar = '\0';
            }
            else
            {
                labelShow.Text = "Show";
                textBoxAncienMdp.PasswordChar = '*';
                textBoxNvMdp.PasswordChar = '*';
                textBox2NvMdp.PasswordChar = '*';
            }
        }

        private void button2FA_Click(object sender, EventArgs e)
        {
            if (administrateur.SharedSecret != null)
            {
                if (ModeleAdministrateur.ConnexionAdmin(administrateur.Email, textBox2FA.Text))
                {
                    ModeleAdministrateur.update2FA(administrateur.Email, null);
                    this.Close();
                } 
            } 
            else
            {
                string userInputCode = textBox2FA.Text.Trim();

                // Conversion du secret partagé en bytes
                byte[] secretBytes = Base32Encoding.ToBytes(_sharedSecret);

                // Création de l'instance TOTP
                var totp = new Totp(secretBytes);

                // Validation du code TOTP entré par l'utilisateur
                if (totp.VerifyTotp(userInputCode, out long timeStepMatched, VerificationWindow.RfcSpecifiedNetworkDelay))
                {
                    if (ModeleAdministrateur.update2FA(administrateur.Email, _sharedSecret))
                    {
                        labelInfo2FA.Text = "Code TOTP valide. Connexion réussie.";
                        labelInfo2FA.ForeColor = Color.Green;
                    }
                }
                else
                {
                    labelInfo2FA.Text = "Code TOTP invalide. Veuillez réessayer.";
                    labelInfo2FA.ForeColor = Color.Red;
                }
            }
            
        }
    }
}
