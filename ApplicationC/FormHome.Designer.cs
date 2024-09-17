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
            labelOrganisation = new Label();
            pictureBoxLogo = new PictureBox();
            panelWest = new Panel();
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
            panelNorth.Controls.Add(labelOrganisation);
            panelNorth.Controls.Add(pictureBoxLogo);
            panelNorth.Dock = DockStyle.Top;
            panelNorth.Location = new Point(0, 0);
            panelNorth.Name = "panelNorth";
            panelNorth.Size = new Size(882, 91);
            panelNorth.TabIndex = 0;
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
            panelWest.Controls.Add(buttonAbout);
            panelWest.Controls.Add(buttonQuitter);
            panelWest.Controls.Add(buttonEquipe);
            panelWest.Controls.Add(buttonHackathon);
            panelWest.Controls.Add(buttonHome);
            panelWest.Dock = DockStyle.Left;
            panelWest.Location = new Point(0, 91);
            panelWest.Name = "panelWest";
            panelWest.Size = new Size(122, 462);
            panelWest.TabIndex = 1;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.FromArgb(45, 50, 55);
            buttonAbout.BackgroundImage = Properties.Resources.info_52px;
            buttonAbout.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAbout.FlatStyle = FlatStyle.Popup;
            buttonAbout.Location = new Point(0, 345);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(122, 52);
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
            buttonQuitter.Location = new Point(0, 396);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(122, 52);
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
            buttonEquipe.Location = new Point(0, 144);
            buttonEquipe.Name = "buttonEquipe";
            buttonEquipe.Size = new Size(122, 52);
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
            buttonHackathon.Location = new Point(0, 95);
            buttonHackathon.Name = "buttonHackathon";
            buttonHackathon.Size = new Size(122, 52);
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
            buttonHome.Location = new Point(0, 44);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(122, 52);
            buttonHome.TabIndex = 0;
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
        private PictureBox pictureBoxLogo;
        private Panel panelAffichage;
        private Button buttonHome;
        private Button buttonHackathon;
        private Button buttonEquipe;
        private Label labelOrganisation;
        private Button buttonAbout;
        private Button buttonQuitter;
    }
}