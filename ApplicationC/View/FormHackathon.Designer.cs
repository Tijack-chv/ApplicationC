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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHackathon));
            dgvHackathon = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            VoirEquipeToolStripMenuItem = new ToolStripMenuItem();
            modifierToolStripMenuItem = new ToolStripMenuItem();
            visualiserLAfficheToolStripMenuItem = new ToolStripMenuItem();
            labelListe = new Label();
            labelInfo = new Label();
            BSHackathon = new BindingSource(components);
            BSEquipe = new BindingSource(components);
            dgvEquipes = new DataGridView();
            buttonPrec = new Button();
            buttonSuiv = new Button();
            panel1 = new Panel();
            textBoxPage = new TextBox();
            label1 = new Label();
            pictureBoxFermer = new PictureBox();
            panel2 = new Panel();
            pictureBoxAffiche = new PictureBox();
            panelPictureBoxAffiche = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvHackathon).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSHackathon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAffiche).BeginInit();
            panelPictureBoxAffiche.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHackathon
            // 
            dgvHackathon.AllowUserToAddRows = false;
            dgvHackathon.AllowUserToDeleteRows = false;
            dgvHackathon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHackathon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHackathon.ContextMenuStrip = contextMenuStrip1;
            dgvHackathon.Location = new Point(11, 51);
            dgvHackathon.Margin = new Padding(6, 7, 6, 7);
            dgvHackathon.MultiSelect = false;
            dgvHackathon.Name = "dgvHackathon";
            dgvHackathon.ReadOnly = true;
            dgvHackathon.RowHeadersWidth = 51;
            dgvHackathon.Size = new Size(1103, 477);
            dgvHackathon.TabIndex = 0;
            dgvHackathon.CellClick += DgvHackathon_CellContentClick;
            dgvHackathon.CellContentClick += DgvHackathon_CellContentClick;
            dgvHackathon.CellMouseClick += DgvHackathon_CellMouseClick;
            dgvHackathon.Click += DgvHackathon_Click;
            dgvHackathon.DoubleClick += dgvHackathon_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(50, 55, 60);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { VoirEquipeToolStripMenuItem, modifierToolStripMenuItem, visualiserLAfficheToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(254, 82);
            // 
            // VoirEquipeToolStripMenuItem
            // 
            VoirEquipeToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            VoirEquipeToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            VoirEquipeToolStripMenuItem.ForeColor = Color.White;
            VoirEquipeToolStripMenuItem.Image = (Image)resources.GetObject("VoirEquipeToolStripMenuItem.Image");
            VoirEquipeToolStripMenuItem.Name = "VoirEquipeToolStripMenuItem";
            VoirEquipeToolStripMenuItem.Size = new Size(253, 26);
            VoirEquipeToolStripMenuItem.Text = "Voir les équipes";
            VoirEquipeToolStripMenuItem.Click += VoirLesÉquipesToolStripMenuItem_Click;
            // 
            // modifierToolStripMenuItem
            // 
            modifierToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            modifierToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            modifierToolStripMenuItem.ForeColor = Color.White;
            modifierToolStripMenuItem.Image = (Image)resources.GetObject("modifierToolStripMenuItem.Image");
            modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            modifierToolStripMenuItem.Size = new Size(253, 26);
            modifierToolStripMenuItem.Text = "Modifier l'Hackathon";
            modifierToolStripMenuItem.Click += modifierToolStripMenuItem_Click;
            // 
            // visualiserLAfficheToolStripMenuItem
            // 
            visualiserLAfficheToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé1;
            visualiserLAfficheToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            visualiserLAfficheToolStripMenuItem.ForeColor = Color.White;
            visualiserLAfficheToolStripMenuItem.Image = Properties.Resources.arrow_right_15604;
            visualiserLAfficheToolStripMenuItem.Name = "visualiserLAfficheToolStripMenuItem";
            visualiserLAfficheToolStripMenuItem.Size = new Size(253, 26);
            visualiserLAfficheToolStripMenuItem.Text = "Visualiser l'Affiche";
            visualiserLAfficheToolStripMenuItem.Click += visualiserLAfficheToolStripMenuItem_Click;
            // 
            // labelListe
            // 
            labelListe.AutoSize = true;
            labelListe.BackColor = Color.Transparent;
            labelListe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListe.Location = new Point(18, 12);
            labelListe.Margin = new Padding(5, 0, 5, 0);
            labelListe.Name = "labelListe";
            labelListe.Size = new Size(261, 29);
            labelListe.TabIndex = 2;
            labelListe.Text = "Liste des Hackathons";
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.ForeColor = SystemColors.ActiveCaptionText;
            labelInfo.Location = new Point(11, 592);
            labelInfo.Margin = new Padding(5, 0, 5, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(612, 17);
            labelInfo.TabIndex = 4;
            labelInfo.Text = "click droit sur l'hackathon sélectionné pour voir ses équipes";
            // 
            // dgvEquipes
            // 
            dgvEquipes.AllowUserToAddRows = false;
            dgvEquipes.AllowUserToDeleteRows = false;
            dgvEquipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipes.Location = new Point(832, 51);
            dgvEquipes.Margin = new Padding(6, 7, 6, 7);
            dgvEquipes.Name = "dgvEquipes";
            dgvEquipes.ReadOnly = true;
            dgvEquipes.RowHeadersWidth = 51;
            dgvEquipes.Size = new Size(282, 477);
            dgvEquipes.TabIndex = 5;
            dgvEquipes.Visible = false;
            // 
            // buttonPrec
            // 
            buttonPrec.BackColor = Color.FromArgb(35, 40, 45);
            buttonPrec.FlatStyle = FlatStyle.Popup;
            buttonPrec.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrec.ForeColor = Color.White;
            buttonPrec.Location = new Point(400, 527);
            buttonPrec.Name = "buttonPrec";
            buttonPrec.Size = new Size(126, 29);
            buttonPrec.TabIndex = 7;
            buttonPrec.Text = "Précédent";
            buttonPrec.UseVisualStyleBackColor = false;
            buttonPrec.Click += buttonPrec_Click;
            // 
            // buttonSuiv
            // 
            buttonSuiv.BackColor = Color.FromArgb(35, 40, 45);
            buttonSuiv.FlatStyle = FlatStyle.Popup;
            buttonSuiv.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSuiv.ForeColor = Color.White;
            buttonSuiv.Location = new Point(595, 527);
            buttonSuiv.Name = "buttonSuiv";
            buttonSuiv.Size = new Size(126, 29);
            buttonSuiv.TabIndex = 8;
            buttonSuiv.Text = "Suivant";
            buttonSuiv.UseVisualStyleBackColor = false;
            buttonSuiv.Click += buttonSuiv_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(721, 527);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 29);
            panel1.TabIndex = 11;
            // 
            // textBoxPage
            // 
            textBoxPage.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPage.Location = new Point(526, 527);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(70, 30);
            textBoxPage.TabIndex = 13;
            textBoxPage.Text = "1";
            textBoxPage.TextAlign = HorizontalAlignment.Center;
            textBoxPage.TextChanged += textBoxPage_TextChanged;
            textBoxPage.KeyPress += textBoxPage_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(11, 568);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(596, 17);
            label1.TabIndex = 14;
            label1.Text = "double click gauche sur l'hackathon afin d'archivé celui-ci";
            // 
            // pictureBoxFermer
            // 
            pictureBoxFermer.BackColor = Color.Transparent;
            pictureBoxFermer.Image = Properties.Resources.icons8_multiply_32;
            pictureBoxFermer.Location = new Point(1121, 0);
            pictureBoxFermer.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFermer.Name = "pictureBoxFermer";
            pictureBoxFermer.Size = new Size(32, 32);
            pictureBoxFermer.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFermer.TabIndex = 6;
            pictureBoxFermer.TabStop = false;
            pictureBoxFermer.Click += pictureBoxFermer_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 35, 40);
            panel2.Location = new Point(11, 527);
            panel2.Name = "panel2";
            panel2.Size = new Size(389, 29);
            panel2.TabIndex = 15;
            // 
            // pictureBoxAffiche
            // 
            pictureBoxAffiche.BackColor = Color.Ivory;
            pictureBoxAffiche.Location = new Point(3, 3);
            pictureBoxAffiche.Name = "pictureBoxAffiche";
            pictureBoxAffiche.Size = new Size(291, 425);
            pictureBoxAffiche.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAffiche.TabIndex = 31;
            pictureBoxAffiche.TabStop = false;
            // 
            // panelPictureBoxAffiche
            // 
            panelPictureBoxAffiche.BackColor = Color.Black;
            panelPictureBoxAffiche.Controls.Add(pictureBoxAffiche);
            panelPictureBoxAffiche.Location = new Point(785, 78);
            panelPictureBoxAffiche.Name = "panelPictureBoxAffiche";
            panelPictureBoxAffiche.Size = new Size(297, 431);
            panelPictureBoxAffiche.TabIndex = 32;
            panelPictureBoxAffiche.Visible = false;
            // 
            // FormHackathon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1158, 619);
            Controls.Add(panelPictureBoxAffiche);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(textBoxPage);
            Controls.Add(panel1);
            Controls.Add(buttonSuiv);
            Controls.Add(buttonPrec);
            Controls.Add(pictureBoxFermer);
            Controls.Add(dgvEquipes);
            Controls.Add(labelInfo);
            Controls.Add(labelListe);
            Controls.Add(dgvHackathon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FormHackathon";
            Text = "Gestion des Hackathons";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHackathon).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BSHackathon).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSEquipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAffiche).EndInit();
            panelPictureBoxAffiche.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource BSHackathon;
        private System.Windows.Forms.DataGridView dgvHackathon;
        private System.Windows.Forms.Label labelListe;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.BindingSource BSEquipe;
        private System.Windows.Forms.DataGridView dgvEquipes;
        private Button buttonPrec;
        private Button buttonSuiv;
        private Panel panel1;
        private TextBox textBoxPage;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem VoirEquipeToolStripMenuItem;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private Label label1;
        private PictureBox pictureBoxFermer;
        private Panel panel2;
        private ToolStripMenuItem visualiserLAfficheToolStripMenuItem;
        private PictureBox pictureBoxAffiche;
        private Panel panelPictureBoxAffiche;
    }
}

