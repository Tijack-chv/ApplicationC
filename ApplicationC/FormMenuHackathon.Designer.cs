﻿namespace ApplicationC
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
            panelSousAffichage = new Panel();
            menuStripHackathon.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripHackathon
            // 
            menuStripHackathon.BackColor = Color.FromArgb(50, 55, 60);
            menuStripHackathon.ImageScalingSize = new Size(20, 20);
            menuStripHackathon.Items.AddRange(new ToolStripItem[] { ListeHackathonToolStripMenuItem, AjoutHackathonToolStripMenuItem, ModificationHackathonToolStripMenuItem });
            menuStripHackathon.Location = new Point(0, 0);
            menuStripHackathon.Name = "menuStripHackathon";
            menuStripHackathon.Padding = new Padding(8, 3, 0, 3);
            menuStripHackathon.Size = new Size(760, 32);
            menuStripHackathon.TabIndex = 0;
            menuStripHackathon.Text = "menu";
            // 
            // ListeHackathonToolStripMenuItem
            // 
            ListeHackathonToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListeHackathonToolStripMenuItem.ForeColor = Color.White;
            ListeHackathonToolStripMenuItem.Name = "ListeHackathonToolStripMenuItem";
            ListeHackathonToolStripMenuItem.Size = new Size(152, 26);
            ListeHackathonToolStripMenuItem.Text = "Liste Hackathon";
            ListeHackathonToolStripMenuItem.Click += ListeHackathonToolStripMenuItem_Click;
            // 
            // AjoutHackathonToolStripMenuItem
            // 
            AjoutHackathonToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            AjoutHackathonToolStripMenuItem.ForeColor = Color.White;
            AjoutHackathonToolStripMenuItem.Name = "AjoutHackathonToolStripMenuItem";
            AjoutHackathonToolStripMenuItem.Size = new Size(157, 26);
            AjoutHackathonToolStripMenuItem.Text = "Ajout Hackathon";
            AjoutHackathonToolStripMenuItem.Click += AjoutHackathonToolStripMenuItem_Click;
            // 
            // ModificationHackathonToolStripMenuItem
            // 
            ModificationHackathonToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            ModificationHackathonToolStripMenuItem.ForeColor = Color.White;
            ModificationHackathonToolStripMenuItem.Name = "ModificationHackathonToolStripMenuItem";
            ModificationHackathonToolStripMenuItem.Size = new Size(216, 26);
            ModificationHackathonToolStripMenuItem.Text = "Modification Hackathon";
            ModificationHackathonToolStripMenuItem.Click += ModificationHackathonToolStripMenuItem_Click;
            // 
            // panelSousAffichage
            // 
            panelSousAffichage.BackColor = Color.Transparent;
            panelSousAffichage.BackgroundImageLayout = ImageLayout.Center;
            panelSousAffichage.Dock = DockStyle.Fill;
            panelSousAffichage.Location = new Point(0, 32);
            panelSousAffichage.Margin = new Padding(5, 5, 5, 5);
            panelSousAffichage.Name = "panelSousAffichage";
            panelSousAffichage.Size = new Size(760, 431);
            panelSousAffichage.TabIndex = 1;
            // 
            // FormMenuHackathon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(760, 463);
            ControlBox = false;
            Controls.Add(panelSousAffichage);
            Controls.Add(menuStripHackathon);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStripHackathon;
            Margin = new Padding(5, 5, 5, 5);
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
        private System.Windows.Forms.Panel panelSousAffichage;
        private ToolStripMenuItem AjoutHackathonToolStripMenuItem;
        private ToolStripMenuItem ModificationHackathonToolStripMenuItem;
    }
}