namespace ApplicationC
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            panelNorth = new Panel();
            pictureBoxDemande = new PictureBox();
            buttonMenu = new Button();
            labelOrganisation = new Label();
            pictureBoxLogo = new PictureBox();
            panelWest = new Panel();
            panelJury = new Panel();
            buttonJury = new Button();
            panelAbout = new Panel();
            panelHackathon = new Panel();
            panelMembreEquipe = new Panel();
            buttonAbout = new Button();
            panelQuitter = new Panel();
            labelAdmin = new Label();
            buttonQuitter = new Button();
            panelSettings = new Panel();
            buttonSettings = new Button();
            buttonHome = new Button();
            buttonHackathon = new Button();
            panelHome = new Panel();
            buttonEquipe = new Button();
            panelAffichage = new Panel();
            panelNorth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDemande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelWest.SuspendLayout();
            SuspendLayout();
            // 
            // panelNorth
            // 
            panelNorth.BackColor = Color.FromArgb(35, 40, 45);
            panelNorth.Controls.Add(pictureBoxDemande);
            panelNorth.Controls.Add(buttonMenu);
            panelNorth.Controls.Add(labelOrganisation);
            panelNorth.Controls.Add(pictureBoxLogo);
            panelNorth.Dock = DockStyle.Top;
            panelNorth.Location = new Point(0, 0);
            panelNorth.Margin = new Padding(3, 2, 3, 2);
            panelNorth.Name = "panelNorth";
            panelNorth.Size = new Size(1012, 83);
            panelNorth.TabIndex = 0;
            // 
            // pictureBoxDemande
            // 
            pictureBoxDemande.Image = (Image)resources.GetObject("pictureBoxDemande.Image");
            pictureBoxDemande.Location = new Point(92, 9);
            pictureBoxDemande.Margin = new Padding(3, 2, 3, 2);
            pictureBoxDemande.Name = "pictureBoxDemande";
            pictureBoxDemande.Size = new Size(82, 64);
            pictureBoxDemande.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxDemande.TabIndex = 0;
            pictureBoxDemande.TabStop = false;
            pictureBoxDemande.Click += pictureBoxDemande_Click;
            // 
            // buttonMenu
            // 
            buttonMenu.BackColor = Color.Transparent;
            buttonMenu.BackgroundImage = (Image)resources.GetObject("buttonMenu.BackgroundImage");
            buttonMenu.BackgroundImageLayout = ImageLayout.Center;
            buttonMenu.FlatStyle = FlatStyle.Popup;
            buttonMenu.Location = new Point(0, 0);
            buttonMenu.Margin = new Padding(3, 2, 3, 2);
            buttonMenu.Name = "buttonMenu";
            buttonMenu.Size = new Size(87, 83);
            buttonMenu.TabIndex = 5;
            buttonMenu.TextAlign = ContentAlignment.MiddleRight;
            buttonMenu.UseVisualStyleBackColor = false;
            buttonMenu.Click += buttonMenu_Click;
            // 
            // labelOrganisation
            // 
            labelOrganisation.AutoSize = true;
            labelOrganisation.Font = new Font("SimSun-ExtB", 28F, FontStyle.Bold | FontStyle.Italic);
            labelOrganisation.ForeColor = Color.SeaGreen;
            labelOrganisation.Location = new Point(581, 23);
            labelOrganisation.Name = "labelOrganisation";
            labelOrganisation.Size = new Size(277, 38);
            labelOrganisation.TabIndex = 3;
            labelOrganisation.Text = "HACKAT' INNOV";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(887, 1);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(123, 79);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // panelWest
            // 
            panelWest.BackColor = Color.FromArgb(45, 50, 55);
            panelWest.Controls.Add(panelJury);
            panelWest.Controls.Add(buttonJury);
            panelWest.Controls.Add(panelAbout);
            panelWest.Controls.Add(panelHackathon);
            panelWest.Controls.Add(panelMembreEquipe);
            panelWest.Controls.Add(buttonAbout);
            panelWest.Controls.Add(panelQuitter);
            panelWest.Controls.Add(labelAdmin);
            panelWest.Controls.Add(buttonQuitter);
            panelWest.Controls.Add(panelSettings);
            panelWest.Controls.Add(buttonSettings);
            panelWest.Controls.Add(buttonHome);
            panelWest.Controls.Add(buttonHackathon);
            panelWest.Controls.Add(panelHome);
            panelWest.Controls.Add(buttonEquipe);
            panelWest.Dock = DockStyle.Left;
            panelWest.Location = new Point(0, 83);
            panelWest.Margin = new Padding(3, 2, 3, 2);
            panelWest.MaximumSize = new Size(223, 490);
            panelWest.Name = "panelWest";
            panelWest.Size = new Size(223, 486);
            panelWest.TabIndex = 1;
            // 
            // panelJury
            // 
            panelJury.BackColor = Color.SeaGreen;
            panelJury.Location = new Point(1, 239);
            panelJury.Margin = new Padding(3, 2, 3, 2);
            panelJury.Name = "panelJury";
            panelJury.Size = new Size(3, 59);
            panelJury.TabIndex = 4;
            // 
            // buttonJury
            // 
            buttonJury.BackColor = Color.FromArgb(45, 50, 55);
            buttonJury.BackgroundImageLayout = ImageLayout.Center;
            buttonJury.FlatStyle = FlatStyle.Popup;
            buttonJury.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonJury.ForeColor = Color.White;
            buttonJury.Image = (Image)resources.GetObject("buttonJury.Image");
            buttonJury.ImageAlign = ContentAlignment.MiddleLeft;
            buttonJury.Location = new Point(4, 238);
            buttonJury.Margin = new Padding(3, 2, 3, 2);
            buttonJury.Name = "buttonJury";
            buttonJury.Size = new Size(218, 59);
            buttonJury.TabIndex = 2;
            buttonJury.Text = "       Jury";
            buttonJury.TextAlign = ContentAlignment.MiddleLeft;
            buttonJury.UseVisualStyleBackColor = false;
            buttonJury.Click += buttonJury_Click;
            // 
            // panelAbout
            // 
            panelAbout.BackColor = Color.SeaGreen;
            panelAbout.Location = new Point(1, 364);
            panelAbout.Margin = new Padding(3, 2, 3, 2);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(3, 59);
            panelAbout.TabIndex = 5;
            // 
            // panelHackathon
            // 
            panelHackathon.BackColor = Color.SeaGreen;
            panelHackathon.Location = new Point(1, 113);
            panelHackathon.Margin = new Padding(3, 2, 3, 2);
            panelHackathon.Name = "panelHackathon";
            panelHackathon.Size = new Size(3, 59);
            panelHackathon.TabIndex = 1;
            // 
            // panelMembreEquipe
            // 
            panelMembreEquipe.BackColor = Color.SeaGreen;
            panelMembreEquipe.Location = new Point(1, 176);
            panelMembreEquipe.Margin = new Padding(3, 2, 3, 2);
            panelMembreEquipe.Name = "panelMembreEquipe";
            panelMembreEquipe.Size = new Size(3, 59);
            panelMembreEquipe.TabIndex = 3;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.FromArgb(45, 50, 55);
            buttonAbout.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAbout.FlatStyle = FlatStyle.Popup;
            buttonAbout.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            buttonAbout.ForeColor = Color.White;
            buttonAbout.Image = (Image)resources.GetObject("buttonAbout.Image");
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(3, 364);
            buttonAbout.Margin = new Padding(3, 2, 3, 2);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(218, 59);
            buttonAbout.TabIndex = 2;
            buttonAbout.Text = "       Information";
            buttonAbout.TextAlign = ContentAlignment.MiddleLeft;
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // panelQuitter
            // 
            panelQuitter.BackColor = Color.SeaGreen;
            panelQuitter.Location = new Point(1, 427);
            panelQuitter.Margin = new Padding(3, 2, 3, 2);
            panelQuitter.Name = "panelQuitter";
            panelQuitter.Size = new Size(3, 59);
            panelQuitter.TabIndex = 6;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAdmin.ForeColor = Color.SeaGreen;
            labelAdmin.Location = new Point(3, 14);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.RightToLeft = RightToLeft.Yes;
            labelAdmin.Size = new Size(140, 24);
            labelAdmin.TabIndex = 4;
            labelAdmin.Text = "Nom Prenom";
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = Color.FromArgb(45, 50, 55);
            buttonQuitter.BackgroundImageLayout = ImageLayout.Zoom;
            buttonQuitter.FlatStyle = FlatStyle.Popup;
            buttonQuitter.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            buttonQuitter.ForeColor = Color.White;
            buttonQuitter.Image = (Image)resources.GetObject("buttonQuitter.Image");
            buttonQuitter.ImageAlign = ContentAlignment.MiddleLeft;
            buttonQuitter.Location = new Point(3, 427);
            buttonQuitter.Margin = new Padding(3, 2, 3, 2);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(218, 59);
            buttonQuitter.TabIndex = 2;
            buttonQuitter.Text = "       Quitter";
            buttonQuitter.TextAlign = ContentAlignment.MiddleLeft;
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.SeaGreen;
            panelSettings.Location = new Point(1, 302);
            panelSettings.Margin = new Padding(3, 2, 3, 2);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(3, 59);
            panelSettings.TabIndex = 4;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(45, 50, 55);
            buttonSettings.BackgroundImageLayout = ImageLayout.Center;
            buttonSettings.FlatStyle = FlatStyle.Popup;
            buttonSettings.Font = new Font("Sylfaen", 12F, FontStyle.Bold);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.Image = (Image)resources.GetObject("buttonSettings.Image");
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(3, 301);
            buttonSettings.Margin = new Padding(3, 2, 3, 2);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(218, 59);
            buttonSettings.TabIndex = 2;
            buttonSettings.Text = "       Paramètre";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(45, 50, 55);
            buttonHome.BackgroundImageLayout = ImageLayout.None;
            buttonHome.FlatStyle = FlatStyle.Popup;
            buttonHome.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = Color.White;
            buttonHome.Image = (Image)resources.GetObject("buttonHome.Image");
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(3, 50);
            buttonHome.Margin = new Padding(3, 2, 3, 2);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(218, 59);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "       Accueil";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonHackathon
            // 
            buttonHackathon.BackColor = Color.FromArgb(45, 50, 55);
            buttonHackathon.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHackathon.FlatStyle = FlatStyle.Popup;
            buttonHackathon.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHackathon.ForeColor = Color.White;
            buttonHackathon.Image = (Image)resources.GetObject("buttonHackathon.Image");
            buttonHackathon.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHackathon.Location = new Point(3, 113);
            buttonHackathon.Margin = new Padding(3, 2, 3, 2);
            buttonHackathon.Name = "buttonHackathon";
            buttonHackathon.Size = new Size(218, 59);
            buttonHackathon.TabIndex = 1;
            buttonHackathon.Text = "       Hackathon";
            buttonHackathon.TextAlign = ContentAlignment.MiddleLeft;
            buttonHackathon.UseVisualStyleBackColor = false;
            buttonHackathon.Click += buttonHackathon_Click;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.SeaGreen;
            panelHome.Location = new Point(0, 50);
            panelHome.Margin = new Padding(3, 2, 3, 2);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(3, 59);
            panelHome.TabIndex = 0;
            // 
            // buttonEquipe
            // 
            buttonEquipe.BackColor = Color.FromArgb(45, 50, 55);
            buttonEquipe.BackgroundImageLayout = ImageLayout.Center;
            buttonEquipe.FlatStyle = FlatStyle.Popup;
            buttonEquipe.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEquipe.ForeColor = Color.White;
            buttonEquipe.Image = (Image)resources.GetObject("buttonEquipe.Image");
            buttonEquipe.ImageAlign = ContentAlignment.MiddleLeft;
            buttonEquipe.Location = new Point(3, 176);
            buttonEquipe.Margin = new Padding(3, 2, 3, 2);
            buttonEquipe.Name = "buttonEquipe";
            buttonEquipe.Size = new Size(218, 59);
            buttonEquipe.TabIndex = 1;
            buttonEquipe.Text = "       Equipe Membre";
            buttonEquipe.TextAlign = ContentAlignment.MiddleLeft;
            buttonEquipe.UseVisualStyleBackColor = false;
            buttonEquipe.Click += buttonEquipe_Click;
            // 
            // panelAffichage
            // 
            panelAffichage.BackColor = Color.Transparent;
            panelAffichage.Dock = DockStyle.Fill;
            panelAffichage.Location = new Point(0, 83);
            panelAffichage.Margin = new Padding(3, 2, 3, 2);
            panelAffichage.Name = "panelAffichage";
            panelAffichage.Size = new Size(1012, 486);
            panelAffichage.TabIndex = 2;
            panelAffichage.Click += panelAffichage_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1012, 569);
            ControlBox = false;
            Controls.Add(panelWest);
            Controls.Add(panelAffichage);
            Controls.Add(panelNorth);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(1028, 608);
            MinimumSize = new Size(1028, 608);
            Name = "FormHome";
            Text = "HACKAT' INNOV";
            panelNorth.ResumeLayout(false);
            panelNorth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDemande).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelWest.ResumeLayout(false);
            panelWest.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelNorth;
        private Panel panelWest;
        private Button buttonHackathon;
        private Button buttonEquipe;
        private Label labelOrganisation;
        private Button buttonAbout;
        private Button buttonQuitter;
        private Button buttonSettings;
        private Label labelAdmin;
        private PictureBox pictureBoxLogo;
        private Button buttonHome;
        private Panel panelAbout;
        private Panel panelQuitter;
        private Panel panelSettings;
        private Button buttonMenu;
        private Button buttonJury;
        public Panel panelJury;
        public Panel panelHome;
        public Panel panelHackathon;
        public Panel panelMembreEquipe;
        private PictureBox pictureBoxDemande;
        private Panel panelAffichage;
    }
}