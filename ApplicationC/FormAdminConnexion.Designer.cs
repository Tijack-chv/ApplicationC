namespace ApplicationC
{
    partial class FormAdminConnexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminConnexion));
            textBoxMail = new TextBox();
            labelConnexion = new Label();
            labelMail = new Label();
            labelMdp = new Label();
            textBoxMdp = new TextBox();
            labelShow = new Label();
            buttonConnecter = new Button();
            labelErreurEmail = new Label();
            labelErreurMdp = new Label();
            labelMdpOublie = new Label();
            groupBoxConnection = new GroupBox();
            groupBoxConnection.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxMail
            // 
            textBoxMail.BackColor = Color.FromArgb(35, 40, 45);
            textBoxMail.BorderStyle = BorderStyle.None;
            textBoxMail.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxMail.ForeColor = Color.White;
            textBoxMail.Location = new Point(221, 23);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(288, 32);
            textBoxMail.TabIndex = 0;
            textBoxMail.Text = "email";
            textBoxMail.Enter += textBoxMail_Enter;
            textBoxMail.Leave += textBoxMail_Leave;
            // 
            // labelConnexion
            // 
            labelConnexion.AutoSize = true;
            labelConnexion.BackColor = Color.Transparent;
            labelConnexion.Font = new Font("SimSun-ExtB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelConnexion.ForeColor = Color.White;
            labelConnexion.Location = new Point(50, 20);
            labelConnexion.Name = "labelConnexion";
            labelConnexion.Size = new Size(497, 37);
            labelConnexion.TabIndex = 1;
            labelConnexion.Text = "Connexion Administrateur";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.BackColor = Color.Transparent;
            labelMail.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMail.ForeColor = Color.White;
            labelMail.Location = new Point(23, 23);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(178, 32);
            labelMail.TabIndex = 2;
            labelMail.Text = "Adresse mail :";
            // 
            // labelMdp
            // 
            labelMdp.AutoSize = true;
            labelMdp.BackColor = Color.Transparent;
            labelMdp.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMdp.ForeColor = Color.White;
            labelMdp.Location = new Point(22, 97);
            labelMdp.Name = "labelMdp";
            labelMdp.Size = new Size(179, 32);
            labelMdp.TabIndex = 4;
            labelMdp.Text = "Mot de passe :";
            // 
            // textBoxMdp
            // 
            textBoxMdp.BackColor = Color.FromArgb(35, 40, 45);
            textBoxMdp.BorderStyle = BorderStyle.None;
            textBoxMdp.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxMdp.ForeColor = Color.White;
            textBoxMdp.Location = new Point(221, 97);
            textBoxMdp.Name = "textBoxMdp";
            textBoxMdp.PasswordChar = '*';
            textBoxMdp.Size = new Size(237, 32);
            textBoxMdp.TabIndex = 3;
            textBoxMdp.Text = "password";
            textBoxMdp.Enter += textBoxMdp_Enter;
            textBoxMdp.Leave += textBoxMdp_Leave;
            // 
            // labelShow
            // 
            labelShow.AutoSize = true;
            labelShow.BackColor = Color.Transparent;
            labelShow.ForeColor = Color.White;
            labelShow.Location = new Point(464, 103);
            labelShow.Name = "labelShow";
            labelShow.Size = new Size(45, 20);
            labelShow.TabIndex = 5;
            labelShow.Text = "Show";
            labelShow.Click += labelShow_Click;
            // 
            // buttonConnecter
            // 
            buttonConnecter.BackColor = Color.Black;
            buttonConnecter.FlatStyle = FlatStyle.Popup;
            buttonConnecter.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConnecter.ForeColor = SystemColors.ControlLightLight;
            buttonConnecter.Location = new Point(217, 289);
            buttonConnecter.Margin = new Padding(5);
            buttonConnecter.Name = "buttonConnecter";
            buttonConnecter.Size = new Size(152, 57);
            buttonConnecter.TabIndex = 26;
            buttonConnecter.Text = "Se connecter";
            buttonConnecter.UseVisualStyleBackColor = false;
            buttonConnecter.Click += buttonConnecter_Click;
            // 
            // labelErreurEmail
            // 
            labelErreurEmail.AutoSize = true;
            labelErreurEmail.BackColor = Color.Transparent;
            labelErreurEmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErreurEmail.ForeColor = Color.Red;
            labelErreurEmail.Location = new Point(44, 58);
            labelErreurEmail.Name = "labelErreurEmail";
            labelErreurEmail.Size = new Size(307, 23);
            labelErreurEmail.TabIndex = 27;
            labelErreurEmail.Text = "Erreur : l'adresse mail est manquante";
            // 
            // labelErreurMdp
            // 
            labelErreurMdp.AutoSize = true;
            labelErreurMdp.BackColor = Color.Transparent;
            labelErreurMdp.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelErreurMdp.ForeColor = Color.Red;
            labelErreurMdp.Location = new Point(44, 132);
            labelErreurMdp.Name = "labelErreurMdp";
            labelErreurMdp.Size = new Size(314, 23);
            labelErreurMdp.TabIndex = 28;
            labelErreurMdp.Text = "Erreur : le mot de passe est manquant";
            // 
            // labelMdpOublie
            // 
            labelMdpOublie.AutoSize = true;
            labelMdpOublie.BackColor = Color.Transparent;
            labelMdpOublie.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMdpOublie.ForeColor = Color.White;
            labelMdpOublie.Location = new Point(217, 264);
            labelMdpOublie.Name = "labelMdpOublie";
            labelMdpOublie.Size = new Size(163, 20);
            labelMdpOublie.TabIndex = 29;
            labelMdpOublie.Text = "Mot de passe oublié ?";
            labelMdpOublie.Click += labelMdpOublie_Click;
            // 
            // groupBoxConnection
            // 
            groupBoxConnection.BackColor = Color.Transparent;
            groupBoxConnection.Controls.Add(labelMail);
            groupBoxConnection.Controls.Add(textBoxMail);
            groupBoxConnection.Controls.Add(labelErreurMdp);
            groupBoxConnection.Controls.Add(labelShow);
            groupBoxConnection.Controls.Add(textBoxMdp);
            groupBoxConnection.Controls.Add(labelErreurEmail);
            groupBoxConnection.Controls.Add(labelMdp);
            groupBoxConnection.Location = new Point(27, 69);
            groupBoxConnection.Name = "groupBoxConnection";
            groupBoxConnection.Size = new Size(532, 184);
            groupBoxConnection.TabIndex = 30;
            groupBoxConnection.TabStop = false;
            // 
            // FormAdminConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(599, 366);
            Controls.Add(groupBoxConnection);
            Controls.Add(labelMdpOublie);
            Controls.Add(buttonConnecter);
            Controls.Add(labelConnexion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormAdminConnexion";
            Text = "Connexion Hackat'Innov";
            groupBoxConnection.ResumeLayout(false);
            groupBoxConnection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMail;
        private Label labelConnexion;
        private Label labelMail;
        private Label labelMdp;
        private TextBox textBoxMdp;
        private Label labelShow;
        private Button buttonConnecter;
        private Label labelErreurEmail;
        private Label labelErreurMdp;
        private Label labelMdpOublie;
        private GroupBox groupBoxConnection;
    }
}