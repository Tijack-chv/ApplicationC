namespace ApplicationC
{
    partial class FormHackathon
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvHackathon = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            voirLesÉquipesToolStripMenuItem = new ToolStripMenuItem();
            labelListe = new Label();
            labelInfo = new Label();
            BSHackathon = new BindingSource(components);
            BSEquipe = new BindingSource(components);
            dgvEquipes = new DataGridView();
            pictureBoxFermer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHackathon).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSHackathon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).BeginInit();
            SuspendLayout();
            // 
            // dgvHackathon
            // 
            dgvHackathon.AllowUserToAddRows = false;
            dgvHackathon.AllowUserToDeleteRows = false;
            dgvHackathon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHackathon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHackathon.ContextMenuStrip = contextMenuStrip1;
            dgvHackathon.Location = new Point(9, 42);
            dgvHackathon.Margin = new Padding(4);
            dgvHackathon.MultiSelect = false;
            dgvHackathon.Name = "dgvHackathon";
            dgvHackathon.ReadOnly = true;
            dgvHackathon.RowHeadersWidth = 51;
            dgvHackathon.Size = new Size(647, 253);
            dgvHackathon.TabIndex = 0;
            dgvHackathon.CellClick += DgvHackathon_CellContentClick;
            dgvHackathon.CellContentClick += DgvHackathon_CellContentClick;
            dgvHackathon.CellMouseClick += DgvHackathon_CellMouseClick;
            dgvHackathon.Click += DgvHackathon_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { voirLesÉquipesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(156, 26);
            // 
            // voirLesÉquipesToolStripMenuItem
            // 
            voirLesÉquipesToolStripMenuItem.Name = "voirLesÉquipesToolStripMenuItem";
            voirLesÉquipesToolStripMenuItem.Size = new Size(155, 22);
            voirLesÉquipesToolStripMenuItem.Text = "Voir les équipes";
            voirLesÉquipesToolStripMenuItem.Click += VoirLesÉquipesToolStripMenuItem_Click;
            // 
            // labelListe
            // 
            labelListe.AutoSize = true;
            labelListe.BackColor = Color.Transparent;
            labelListe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListe.Location = new Point(16, 9);
            labelListe.Margin = new Padding(4, 0, 4, 0);
            labelListe.Name = "labelListe";
            labelListe.Size = new Size(208, 24);
            labelListe.TabIndex = 2;
            labelListe.Text = "Liste des Hackathons";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.ForeColor = SystemColors.ActiveCaptionText;
            labelInfo.Location = new Point(9, 299);
            labelInfo.Margin = new Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(553, 16);
            labelInfo.TabIndex = 4;
            labelInfo.Text = "click droit sur l'hackathon sélectionné pour voir ses équipes";
            // 
            // dgvEquipes
            // 
            dgvEquipes.AllowUserToAddRows = false;
            dgvEquipes.AllowUserToDeleteRows = false;
            dgvEquipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipes.Location = new Point(395, 178);
            dgvEquipes.Margin = new Padding(4);
            dgvEquipes.Name = "dgvEquipes";
            dgvEquipes.ReadOnly = true;
            dgvEquipes.RowHeadersWidth = 51;
            dgvEquipes.Size = new Size(261, 117);
            dgvEquipes.TabIndex = 5;
            dgvEquipes.Visible = false;
            // 
            // pictureBoxFermer
            // 
            pictureBoxFermer.BackColor = Color.Transparent;
            pictureBoxFermer.Image = Properties.Resources.icons8_multiply_32;
            pictureBoxFermer.Location = new Point(630, 3);
            pictureBoxFermer.Name = "pictureBoxFermer";
            pictureBoxFermer.Size = new Size(32, 32);
            pictureBoxFermer.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFermer.TabIndex = 6;
            pictureBoxFermer.TabStop = false;
            pictureBoxFermer.Click += pictureBoxFermer_Click;
            // 
            // FormHackathon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(665, 323);
            Controls.Add(pictureBoxFermer);
            Controls.Add(dgvEquipes);
            Controls.Add(labelInfo);
            Controls.Add(labelListe);
            Controls.Add(dgvHackathon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FormHackathon";
            Text = "Gestion des Hackathons";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHackathon).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BSHackathon).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSEquipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource BSHackathon;
        private System.Windows.Forms.DataGridView dgvHackathon;
        private System.Windows.Forms.Label labelListe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voirLesÉquipesToolStripMenuItem;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.BindingSource BSEquipe;
        private System.Windows.Forms.DataGridView dgvEquipes;
        private PictureBox pictureBoxFermer;
    }
}

