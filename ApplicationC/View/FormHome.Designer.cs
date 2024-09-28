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
            labelAdmin = new Label();
            labelOrganisation = new Label();
            pictureBoxLogo = new PictureBox();
            panelWest = new Panel();
            panelAbout = new Panel();
            panelQuitter = new Panel();
            panelHackathon = new Panel();
            panelSettings = new Panel();
            panelMembreEquipe = new Panel();
            panelHome = new Panel();
            buttonSettings = new Button();
            buttonAbout = new Button();
            buttonQuitter = new Button();
            buttonEquipe = new Button();
            buttonHackathon = new Button();
            buttonHome = new Button();
            panelAffichage = new Panel();
            panelNorth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelWest.SuspendLayout();
            SuspendLayout();
            // 
            // panelNorth
            // 
            panelNorth.BackColor = Color.FromArgb(35, 40, 45);
            panelNorth.Controls.Add(labelAdmin);
            panelNorth.Controls.Add(labelOrganisation);
            panelNorth.Controls.Add(pictureBoxLogo);
            panelNorth.Dock = DockStyle.Top;
            panelNorth.Location = new Point(0, 0);
            panelNorth.Name = "panelNorth";
            panelNorth.Size = new Size(882, 91);
            panelNorth.TabIndex = 0;
            // 
            // labelAdmin
            // 
            labelAdmin.AutoSize = true;
            labelAdmin.Font = new Font("SimSun-ExtB", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAdmin.ForeColor = Color.SeaGreen;
            labelAdmin.Location = new Point(606, 32);
            labelAdmin.Name = "labelAdmin";
            labelAdmin.RightToLeft = RightToLeft.Yes;
            labelAdmin.Size = new Size(269, 30);
            labelAdmin.TabIndex = 4;
            labelAdmin.Text = "Prenom Nom Admin";
            // 
            // labelOrganisation
            // 
            labelOrganisation.AutoSize = true;
            labelOrganisation.Font = new Font("SimSun-ExtB", 28F, FontStyle.Bold | FontStyle.Italic);
            labelOrganisation.ForeColor = Color.SeaGreen;
            labelOrganisation.Location = new Point(125, 20);
            labelOrganisation.Name = "labelOrganisation";
            labelOrganisation.Size = new Size(345, 47);
            labelOrganisation.TabIndex = 3;
            labelOrganisation.Text = "HACKAT' INNOV";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(122, 91);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // panelWest
            // 
            panelWest.BackColor = Color.FromArgb(45, 50, 55);
            panelWest.Controls.Add(panelAbout);
            panelWest.Controls.Add(panelQuitter);
            panelWest.Controls.Add(panelHackathon);
            panelWest.Controls.Add(panelSettings);
            panelWest.Controls.Add(panelMembreEquipe);
            panelWest.Controls.Add(panelHome);
            panelWest.Controls.Add(buttonSettings);
            panelWest.Controls.Add(buttonAbout);
            panelWest.Controls.Add(buttonQuitter);
            panelWest.Controls.Add(buttonEquipe);
            panelWest.Controls.Add(buttonHackathon);
            panelWest.Controls.Add(buttonHome);
            panelWest.Dock = DockStyle.Left;
            panelWest.Location = new Point(0, 91);
            panelWest.MaximumSize = new Size(122, 462);
            panelWest.MinimumSize = new Size(62, 52);
            panelWest.Name = "panelWest";
            panelWest.Size = new Size(122, 462);
            panelWest.TabIndex = 1;
            // 
            // panelAbout
            // 
            panelAbout.BackColor = Color.SeaGreen;
            panelAbout.Location = new Point(0, 357);
            panelAbout.Name = "panelAbout";
            panelAbout.Size = new Size(6, 52);
            panelAbout.TabIndex = 5;
            // 
            // panelQuitter
            // 
            panelQuitter.BackColor = Color.SeaGreen;
            panelQuitter.Location = new Point(0, 406);
            panelQuitter.Name = "panelQuitter";
            panelQuitter.Size = new Size(6, 52);
            panelQuitter.TabIndex = 6;
            // 
            // panelHackathon
            // 
            panelHackathon.BackColor = Color.SeaGreen;
            panelHackathon.Location = new Point(0, 53);
            panelHackathon.Name = "panelHackathon";
            panelHackathon.Size = new Size(6, 52);
            panelHackathon.TabIndex = 1;
            // 
            // panelSettings
            // 
            panelSettings.BackColor = Color.SeaGreen;
            panelSettings.Location = new Point(0, 306);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new Size(6, 52);
            panelSettings.TabIndex = 4;
            // 
            // panelMembreEquipe
            // 
            panelMembreEquipe.BackColor = Color.SeaGreen;
            panelMembreEquipe.Location = new Point(0, 102);
            panelMembreEquipe.Name = "panelMembreEquipe";
            panelMembreEquipe.Size = new Size(6, 52);
            panelMembreEquipe.TabIndex = 3;
            // 
            // panelHome
            // 
            panelHome.BackColor = Color.SeaGreen;
            panelHome.Location = new Point(0, 2);
            panelHome.Name = "panelHome";
            panelHome.Size = new Size(6, 52);
            panelHome.TabIndex = 0;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(45, 50, 55);
            buttonSettings.BackgroundImage = Properties.Resources.parametres;
            buttonSettings.BackgroundImageLayout = ImageLayout.Center;
            buttonSettings.FlatStyle = FlatStyle.Popup;
            buttonSettings.Location = new Point(6, 306);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(116, 52);
            buttonSettings.TabIndex = 2;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.FromArgb(45, 50, 55);
            buttonAbout.BackgroundImage = Properties.Resources.info_52px;
            buttonAbout.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAbout.FlatStyle = FlatStyle.Popup;
            buttonAbout.Location = new Point(6, 357);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(116, 52);
            buttonAbout.TabIndex = 2;
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = Color.FromArgb(45, 50, 55);
            buttonQuitter.BackgroundImage = Properties.Resources.quit_icon_149882;
            buttonQuitter.BackgroundImageLayout = ImageLayout.Zoom;
            buttonQuitter.FlatStyle = FlatStyle.Popup;
            buttonQuitter.Location = new Point(6, 408);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(116, 52);
            buttonQuitter.TabIndex = 2;
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonEquipe
            // 
            buttonEquipe.BackColor = Color.FromArgb(45, 50, 55);
            buttonEquipe.BackgroundImage = Properties.Resources.icons8_member_32;
            buttonEquipe.BackgroundImageLayout = ImageLayout.Center;
            buttonEquipe.FlatStyle = FlatStyle.Popup;
            buttonEquipe.Location = new Point(6, 102);
            buttonEquipe.Name = "buttonEquipe";
            buttonEquipe.Size = new Size(116, 52);
            buttonEquipe.TabIndex = 1;
            buttonEquipe.UseVisualStyleBackColor = false;
            buttonEquipe.Click += buttonEquipe_Click;
            // 
            // buttonHackathon
            // 
            buttonHackathon.BackColor = Color.FromArgb(45, 50, 55);
            buttonHackathon.BackgroundImage = Properties.Resources.hackathon;
            buttonHackathon.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHackathon.FlatStyle = FlatStyle.Popup;
            buttonHackathon.Location = new Point(6, 53);
            buttonHackathon.Name = "buttonHackathon";
            buttonHackathon.Size = new Size(116, 52);
            buttonHackathon.TabIndex = 1;
            buttonHackathon.UseVisualStyleBackColor = false;
            buttonHackathon.Click += buttonHackathon_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(45, 50, 55);
            buttonHome.BackgroundImage = Properties.Resources.icons8_home_32;
            buttonHome.BackgroundImageLayout = ImageLayout.Center;
            buttonHome.FlatStyle = FlatStyle.Popup;
            buttonHome.Location = new Point(6, 2);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(116, 52);
            buttonHome.TabIndex = 0;
            buttonHome.TextAlign = ContentAlignment.MiddleRight;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // panelAffichage
            // 
            panelAffichage.BackColor = Color.Transparent;
            panelAffichage.Dock = DockStyle.Fill;
            panelAffichage.Location = new Point(122, 91);
            panelAffichage.Name = "panelAffichage";
            panelAffichage.Size = new Size(760, 462);
            panelAffichage.TabIndex = 2;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(882, 553);
            ControlBox = false;
            Controls.Add(panelAffichage);
            Controls.Add(panelWest);
            Controls.Add(panelNorth);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormHome";
            Text = "HACKAT' INNOV";
            panelNorth.ResumeLayout(false);
            panelNorth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelWest.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelNorth;
        private Panel panelWest;
        private Panel panelAffichage;
        private Button buttonHackathon;
        private Button buttonEquipe;
        private Label labelOrganisation;
        private Button buttonAbout;
        private Button buttonQuitter;
        private Button buttonSettings;
        private Label labelAdmin;
        private PictureBox pictureBoxLogo;
        private Button buttonHome;
        private Panel panelHome;
        private Panel panelAbout;
        private Panel panelQuitter;
        private Panel panelHackathon;
        private Panel panelSettings;
        private Panel panelMembreEquipe;
    }
}