namespace ApplicationC
{
    partial class FormMenuHackathon
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
            menuStripHackathon = new MenuStrip();
            ListeHackathonToolStripMenuItem = new ToolStripMenuItem();
            AjoutHackathonToolStripMenuItem = new ToolStripMenuItem();
            ModificationHackathonToolStripMenuItem = new ToolStripMenuItem();
            rechercheHackathonToolStripMenuItem = new ToolStripMenuItem();
            panelSousAffichage = new Panel();
            menuStripHackathon.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripHackathon
            // 
            menuStripHackathon.BackColor = Color.FromArgb(50, 55, 60);
            menuStripHackathon.ImageScalingSize = new Size(20, 20);
            menuStripHackathon.Items.AddRange(new ToolStripItem[] { ListeHackathonToolStripMenuItem, AjoutHackathonToolStripMenuItem, ModificationHackathonToolStripMenuItem, rechercheHackathonToolStripMenuItem });
            menuStripHackathon.Location = new Point(0, 0);
            menuStripHackathon.Name = "menuStripHackathon";
            menuStripHackathon.Padding = new Padding(7, 2, 0, 2);
            menuStripHackathon.Size = new Size(1013, 26);
            menuStripHackathon.TabIndex = 0;
            menuStripHackathon.Text = "menu";
            // 
            // ListeHackathonToolStripMenuItem
            // 
            ListeHackathonToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListeHackathonToolStripMenuItem.ForeColor = Color.White;
            ListeHackathonToolStripMenuItem.Name = "ListeHackathonToolStripMenuItem";
            ListeHackathonToolStripMenuItem.Size = new Size(118, 22);
            ListeHackathonToolStripMenuItem.Text = "Liste Hackathon";
            ListeHackathonToolStripMenuItem.Click += ListeHackathonToolStripMenuItem_Click;
            // 
            // AjoutHackathonToolStripMenuItem
            // 
            AjoutHackathonToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            AjoutHackathonToolStripMenuItem.ForeColor = Color.White;
            AjoutHackathonToolStripMenuItem.Name = "AjoutHackathonToolStripMenuItem";
            AjoutHackathonToolStripMenuItem.Size = new Size(122, 22);
            AjoutHackathonToolStripMenuItem.Text = "Ajout Hackathon";
            AjoutHackathonToolStripMenuItem.Click += AjoutHackathonToolStripMenuItem_Click;
            // 
            // ModificationHackathonToolStripMenuItem
            // 
            ModificationHackathonToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            ModificationHackathonToolStripMenuItem.ForeColor = Color.White;
            ModificationHackathonToolStripMenuItem.Name = "ModificationHackathonToolStripMenuItem";
            ModificationHackathonToolStripMenuItem.Size = new Size(166, 22);
            ModificationHackathonToolStripMenuItem.Text = "Modification Hackathon";
            ModificationHackathonToolStripMenuItem.Click += ModificationHackathonToolStripMenuItem_Click;
            // 
            // rechercheHackathonToolStripMenuItem
            // 
            rechercheHackathonToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            rechercheHackathonToolStripMenuItem.ForeColor = Color.White;
            rechercheHackathonToolStripMenuItem.Name = "rechercheHackathonToolStripMenuItem";
            rechercheHackathonToolStripMenuItem.Size = new Size(152, 22);
            rechercheHackathonToolStripMenuItem.Text = "Recherche Hackathon";
            rechercheHackathonToolStripMenuItem.Click += rechercheHackathonToolStripMenuItem_Click;
            // 
            // panelSousAffichage
            // 
            panelSousAffichage.BackColor = Color.Transparent;
            panelSousAffichage.BackgroundImageLayout = ImageLayout.Center;
            panelSousAffichage.Dock = DockStyle.Fill;
            panelSousAffichage.Location = new Point(0, 26);
            panelSousAffichage.Margin = new Padding(4, 4, 4, 4);
            panelSousAffichage.Name = "panelSousAffichage";
            panelSousAffichage.Size = new Size(1013, 464);
            panelSousAffichage.TabIndex = 1;
            // 
            // FormMenuHackathon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1013, 490);
            ControlBox = false;
            Controls.Add(panelSousAffichage);
            Controls.Add(menuStripHackathon);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripHackathon;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormMenuHackathon";
            Text = "HACKAT'INNOV";
            menuStripHackathon.ResumeLayout(false);
            menuStripHackathon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripHackathon;
        private System.Windows.Forms.ToolStripMenuItem ListeHackathonToolStripMenuItem;
        private ToolStripMenuItem AjoutHackathonToolStripMenuItem;
        private ToolStripMenuItem ModificationHackathonToolStripMenuItem;
        private ToolStripMenuItem rechercheHackathonToolStripMenuItem;
        public Panel panelSousAffichage;
    }
}