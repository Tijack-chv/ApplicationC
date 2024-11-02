namespace ApplicationC.View
{
    partial class FormMenuJury
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
            ListeJuryToolStripMenuItem = new ToolStripMenuItem();
            AjoutJuryToolStripMenuItem = new ToolStripMenuItem();
            ModificationJuryToolStripMenuItem = new ToolStripMenuItem();
            panelSousAffichage = new Panel();
            menuStripHackathon.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripHackathon
            // 
            menuStripHackathon.BackColor = Color.FromArgb(50, 55, 60);
            menuStripHackathon.ImageScalingSize = new Size(20, 20);
            menuStripHackathon.Items.AddRange(new ToolStripItem[] { ListeJuryToolStripMenuItem, AjoutJuryToolStripMenuItem, ModificationJuryToolStripMenuItem });
            menuStripHackathon.Location = new Point(0, 0);
            menuStripHackathon.Name = "menuStripHackathon";
            menuStripHackathon.Padding = new Padding(7, 2, 0, 2);
            menuStripHackathon.Size = new Size(1013, 26);
            menuStripHackathon.TabIndex = 1;
            menuStripHackathon.Text = "menu";
            // 
            // ListeJuryToolStripMenuItem
            // 
            ListeJuryToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListeJuryToolStripMenuItem.ForeColor = Color.White;
            ListeJuryToolStripMenuItem.Name = "ListeJuryToolStripMenuItem";
            ListeJuryToolStripMenuItem.Size = new Size(77, 22);
            ListeJuryToolStripMenuItem.Text = "Liste Jury";
            ListeJuryToolStripMenuItem.Click += ListeJuryToolStripMenuItem_Click;
            // 
            // AjoutJuryToolStripMenuItem
            // 
            AjoutJuryToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            AjoutJuryToolStripMenuItem.ForeColor = Color.White;
            AjoutJuryToolStripMenuItem.Name = "AjoutJuryToolStripMenuItem";
            AjoutJuryToolStripMenuItem.Size = new Size(81, 22);
            AjoutJuryToolStripMenuItem.Text = "Ajout Jury";
            AjoutJuryToolStripMenuItem.Click += AjoutJuryToolStripMenuItem_Click;
            // 
            // ModificationJuryToolStripMenuItem
            // 
            ModificationJuryToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            ModificationJuryToolStripMenuItem.ForeColor = Color.White;
            ModificationJuryToolStripMenuItem.Name = "ModificationJuryToolStripMenuItem";
            ModificationJuryToolStripMenuItem.Size = new Size(125, 22);
            ModificationJuryToolStripMenuItem.Text = "Modification Jury";
            ModificationJuryToolStripMenuItem.Click += ModificationJuryToolStripMenuItem_Click;
            // 
            // panelSousAffichage
            // 
            panelSousAffichage.BackColor = Color.Transparent;
            panelSousAffichage.Dock = DockStyle.Fill;
            panelSousAffichage.Location = new Point(0, 26);
            panelSousAffichage.Name = "panelSousAffichage";
            panelSousAffichage.Size = new Size(1013, 464);
            panelSousAffichage.TabIndex = 2;
            // 
            // FormMenuJury
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1013, 490);
            Controls.Add(panelSousAffichage);
            Controls.Add(menuStripHackathon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuJury";
            Text = "FormMenuJury";
            menuStripHackathon.ResumeLayout(false);
            menuStripHackathon.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripHackathon;
        private ToolStripMenuItem ListeJuryToolStripMenuItem;
        private ToolStripMenuItem AjoutJuryToolStripMenuItem;
        private ToolStripMenuItem ModificationJuryToolStripMenuItem;
        private Panel panelSousAffichage;
    }
}