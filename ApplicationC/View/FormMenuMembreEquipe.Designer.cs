namespace ApplicationC
{
    partial class FormMenuMembreEquipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuMembreEquipe));
            menuStripMembreEquipe = new MenuStrip();
            ListeMembreEquipe = new ToolStripMenuItem();
            listeMembreToolStripMenuItem = new ToolStripMenuItem();
            listeEquipeToolStripMenuItem = new ToolStripMenuItem();
            AjoutMembreEquipeToolStripMenuItem = new ToolStripMenuItem();
            ajoutMembreToolStripMenuItem = new ToolStripMenuItem();
            ajoutEquipeToolStripMenuItem = new ToolStripMenuItem();
            ModificationMembreEquipeToolStripMenuItem = new ToolStripMenuItem();
            modificationMembreToolStripMenuItem = new ToolStripMenuItem();
            modificationEquipeToolStripMenuItem = new ToolStripMenuItem();
            rechercheMembreEquipeToolStripMenuItem = new ToolStripMenuItem();
            rechercheMembreToolStripMenuItem = new ToolStripMenuItem();
            rechercheEquipeToolStripMenuItem = new ToolStripMenuItem();
            panelSousAffichage = new Panel();
            menuStripMembreEquipe.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMembreEquipe
            // 
            menuStripMembreEquipe.BackColor = Color.FromArgb(50, 55, 60);
            menuStripMembreEquipe.ImageScalingSize = new Size(20, 20);
            menuStripMembreEquipe.Items.AddRange(new ToolStripItem[] { ListeMembreEquipe, AjoutMembreEquipeToolStripMenuItem, ModificationMembreEquipeToolStripMenuItem, rechercheMembreEquipeToolStripMenuItem });
            menuStripMembreEquipe.Location = new Point(0, 0);
            menuStripMembreEquipe.Name = "menuStripMembreEquipe";
            menuStripMembreEquipe.Padding = new Padding(7, 2, 0, 2);
            menuStripMembreEquipe.Size = new Size(1013, 26);
            menuStripMembreEquipe.TabIndex = 1;
            menuStripMembreEquipe.Text = "menu";
            // 
            // ListeMembreEquipe
            // 
            ListeMembreEquipe.DropDownItems.AddRange(new ToolStripItem[] { listeMembreToolStripMenuItem, listeEquipeToolStripMenuItem });
            ListeMembreEquipe.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListeMembreEquipe.ForeColor = Color.White;
            ListeMembreEquipe.Name = "ListeMembreEquipe";
            ListeMembreEquipe.Size = new Size(49, 22);
            ListeMembreEquipe.Text = "Liste";
            // 
            // listeMembreToolStripMenuItem
            // 
            listeMembreToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            listeMembreToolStripMenuItem.ForeColor = Color.White;
            listeMembreToolStripMenuItem.Image = (Image)resources.GetObject("listeMembreToolStripMenuItem.Image");
            listeMembreToolStripMenuItem.Name = "listeMembreToolStripMenuItem";
            listeMembreToolStripMenuItem.Size = new Size(160, 22);
            listeMembreToolStripMenuItem.Text = "Liste Membre";
            listeMembreToolStripMenuItem.Click += listeMembreToolStripMenuItem_Click;
            // 
            // listeEquipeToolStripMenuItem
            // 
            listeEquipeToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            listeEquipeToolStripMenuItem.ForeColor = Color.White;
            listeEquipeToolStripMenuItem.Image = (Image)resources.GetObject("listeEquipeToolStripMenuItem.Image");
            listeEquipeToolStripMenuItem.Name = "listeEquipeToolStripMenuItem";
            listeEquipeToolStripMenuItem.Size = new Size(160, 22);
            listeEquipeToolStripMenuItem.Text = "Liste Equipe";
            listeEquipeToolStripMenuItem.Click += listeEquipeToolStripMenuItem_Click;
            // 
            // AjoutMembreEquipeToolStripMenuItem
            // 
            AjoutMembreEquipeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajoutMembreToolStripMenuItem, ajoutEquipeToolStripMenuItem });
            AjoutMembreEquipeToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            AjoutMembreEquipeToolStripMenuItem.ForeColor = Color.White;
            AjoutMembreEquipeToolStripMenuItem.Name = "AjoutMembreEquipeToolStripMenuItem";
            AjoutMembreEquipeToolStripMenuItem.Size = new Size(53, 22);
            AjoutMembreEquipeToolStripMenuItem.Text = "Ajout";
            // 
            // ajoutMembreToolStripMenuItem
            // 
            ajoutMembreToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            ajoutMembreToolStripMenuItem.ForeColor = Color.White;
            ajoutMembreToolStripMenuItem.Image = (Image)resources.GetObject("ajoutMembreToolStripMenuItem.Image");
            ajoutMembreToolStripMenuItem.Name = "ajoutMembreToolStripMenuItem";
            ajoutMembreToolStripMenuItem.Size = new Size(164, 22);
            ajoutMembreToolStripMenuItem.Text = "Ajout Membre";
            ajoutMembreToolStripMenuItem.Click += ajoutMembreToolStripMenuItem_Click;
            // 
            // ajoutEquipeToolStripMenuItem
            // 
            ajoutEquipeToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            ajoutEquipeToolStripMenuItem.ForeColor = Color.White;
            ajoutEquipeToolStripMenuItem.Image = (Image)resources.GetObject("ajoutEquipeToolStripMenuItem.Image");
            ajoutEquipeToolStripMenuItem.Name = "ajoutEquipeToolStripMenuItem";
            ajoutEquipeToolStripMenuItem.Size = new Size(164, 22);
            ajoutEquipeToolStripMenuItem.Text = "Ajout Equipe";
            ajoutEquipeToolStripMenuItem.Click += ajoutEquipeToolStripMenuItem_Click;
            // 
            // ModificationMembreEquipeToolStripMenuItem
            // 
            ModificationMembreEquipeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificationMembreToolStripMenuItem, modificationEquipeToolStripMenuItem });
            ModificationMembreEquipeToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            ModificationMembreEquipeToolStripMenuItem.ForeColor = Color.White;
            ModificationMembreEquipeToolStripMenuItem.Name = "ModificationMembreEquipeToolStripMenuItem";
            ModificationMembreEquipeToolStripMenuItem.Size = new Size(97, 22);
            ModificationMembreEquipeToolStripMenuItem.Text = "Modification";
            // 
            // modificationMembreToolStripMenuItem
            // 
            modificationMembreToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            modificationMembreToolStripMenuItem.ForeColor = Color.White;
            modificationMembreToolStripMenuItem.Image = (Image)resources.GetObject("modificationMembreToolStripMenuItem.Image");
            modificationMembreToolStripMenuItem.Name = "modificationMembreToolStripMenuItem";
            modificationMembreToolStripMenuItem.RightToLeft = RightToLeft.No;
            modificationMembreToolStripMenuItem.Size = new Size(208, 22);
            modificationMembreToolStripMenuItem.Text = "Modification Membre";
            modificationMembreToolStripMenuItem.Click += modificationMembreToolStripMenuItem_Click;
            // 
            // modificationEquipeToolStripMenuItem
            // 
            modificationEquipeToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            modificationEquipeToolStripMenuItem.ForeColor = Color.White;
            modificationEquipeToolStripMenuItem.Image = (Image)resources.GetObject("modificationEquipeToolStripMenuItem.Image");
            modificationEquipeToolStripMenuItem.Name = "modificationEquipeToolStripMenuItem";
            modificationEquipeToolStripMenuItem.Size = new Size(208, 22);
            modificationEquipeToolStripMenuItem.Text = "Modification Equipe";
            modificationEquipeToolStripMenuItem.Click += modificationEquipeToolStripMenuItem_Click;
            // 
            // rechercheMembreEquipeToolStripMenuItem
            // 
            rechercheMembreEquipeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rechercheMembreToolStripMenuItem, rechercheEquipeToolStripMenuItem });
            rechercheMembreEquipeToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            rechercheMembreEquipeToolStripMenuItem.ForeColor = Color.White;
            rechercheMembreEquipeToolStripMenuItem.Name = "rechercheMembreEquipeToolStripMenuItem";
            rechercheMembreEquipeToolStripMenuItem.Size = new Size(83, 22);
            rechercheMembreEquipeToolStripMenuItem.Text = "Recherche";
            // 
            // rechercheMembreToolStripMenuItem
            // 
            rechercheMembreToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            rechercheMembreToolStripMenuItem.ForeColor = Color.White;
            rechercheMembreToolStripMenuItem.Image = (Image)resources.GetObject("rechercheMembreToolStripMenuItem.Image");
            rechercheMembreToolStripMenuItem.Name = "rechercheMembreToolStripMenuItem";
            rechercheMembreToolStripMenuItem.Size = new Size(194, 22);
            rechercheMembreToolStripMenuItem.Text = "Recherche Membre";
            rechercheMembreToolStripMenuItem.Click += rechercheMembreToolStripMenuItem_Click;
            // 
            // rechercheEquipeToolStripMenuItem
            // 
            rechercheEquipeToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            rechercheEquipeToolStripMenuItem.ForeColor = Color.White;
            rechercheEquipeToolStripMenuItem.Image = (Image)resources.GetObject("rechercheEquipeToolStripMenuItem.Image");
            rechercheEquipeToolStripMenuItem.Name = "rechercheEquipeToolStripMenuItem";
            rechercheEquipeToolStripMenuItem.Size = new Size(194, 22);
            rechercheEquipeToolStripMenuItem.Text = "Recherche Equipe";
            rechercheEquipeToolStripMenuItem.Click += rechercheEquipeToolStripMenuItem_Click;
            // 
            // panelSousAffichage
            // 
            panelSousAffichage.BackColor = Color.Transparent;
            panelSousAffichage.Dock = DockStyle.Fill;
            panelSousAffichage.Location = new Point(0, 26);
            panelSousAffichage.Margin = new Padding(3, 2, 3, 2);
            panelSousAffichage.Name = "panelSousAffichage";
            panelSousAffichage.Size = new Size(1013, 464);
            panelSousAffichage.TabIndex = 2;
            // 
            // FormMenuMembreEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1013, 490);
            Controls.Add(panelSousAffichage);
            Controls.Add(menuStripMembreEquipe);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMenuMembreEquipe";
            Text = "FormMenuMembreEquipe";
            menuStripMembreEquipe.ResumeLayout(false);
            menuStripMembreEquipe.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMembreEquipe;
        private ToolStripMenuItem ListeMembreEquipe;
        private ToolStripMenuItem listeMembreToolStripMenuItem;
        private ToolStripMenuItem listeEquipeToolStripMenuItem;
        private ToolStripMenuItem AjoutMembreEquipeToolStripMenuItem;
        private ToolStripMenuItem ajoutMembreToolStripMenuItem;
        private ToolStripMenuItem ajoutEquipeToolStripMenuItem;
        private ToolStripMenuItem ModificationMembreEquipeToolStripMenuItem;
        private ToolStripMenuItem rechercheMembreEquipeToolStripMenuItem;
        private ToolStripMenuItem modificationMembreToolStripMenuItem;
        private ToolStripMenuItem modificationEquipeToolStripMenuItem;
        private ToolStripMenuItem rechercheMembreToolStripMenuItem;
        private ToolStripMenuItem rechercheEquipeToolStripMenuItem;
        private Panel panelSousAffichage;
    }
}