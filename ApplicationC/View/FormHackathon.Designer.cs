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
            dgvEquipesJury = new DataGridView();
            contextMenuStripEquipe = new ContextMenuStrip(components);
            désinscrireEquipeToolStripMenuItem = new ToolStripMenuItem();
            buttonPrec = new Button();
            buttonSuiv = new Button();
            panel1 = new Panel();
            textBoxPage = new TextBox();
            label1 = new Label();
            pictureBoxFermer = new PictureBox();
            panel2 = new Panel();
            pictureBoxAffiche = new PictureBox();
            panelPictureBoxAffiche = new Panel();
            textBoxThematique = new TextBox();
            dateTimePickerDatePrec = new DateTimePicker();
            dateTimePickerDateSuiv = new DateTimePicker();
            textBoxVille = new TextBox();
            comboBoxEquipe = new ComboBox();
            numericUpDownPlacesRestantes = new NumericUpDown();
            buttonRenitialiserFiltre = new Button();
            labelThematique = new Label();
            labelRecherche = new Label();
            labelDate = new Label();
            labelVille = new Label();
            labelEquipe = new Label();
            label7 = new Label();
            bindingSourceAllEquipeCombo = new BindingSource(components);
            visualiserLeJuryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvHackathon).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSHackathon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipesJury).BeginInit();
            contextMenuStripEquipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAffiche).BeginInit();
            panelPictureBoxAffiche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPlacesRestantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAllEquipeCombo).BeginInit();
            SuspendLayout();
            // 
            // dgvHackathon
            // 
            dgvHackathon.AllowUserToAddRows = false;
            dgvHackathon.AllowUserToDeleteRows = false;
            dgvHackathon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHackathon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHackathon.ContextMenuStrip = contextMenuStrip1;
            dgvHackathon.Location = new Point(10, 38);
            dgvHackathon.Margin = new Padding(5);
            dgvHackathon.MultiSelect = false;
            dgvHackathon.Name = "dgvHackathon";
            dgvHackathon.ReadOnly = true;
            dgvHackathon.RowHeadersWidth = 51;
            dgvHackathon.Size = new Size(783, 358);
            dgvHackathon.TabIndex = 0;
            dgvHackathon.CellClick += DgvHackathon_CellContentClick;
            dgvHackathon.CellContentClick += DgvHackathon_CellContentClick;
            dgvHackathon.CellMouseClick += DgvHackathon_CellMouseClick;
            dgvHackathon.DoubleClick += dgvHackathon_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = Color.FromArgb(50, 55, 60);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { VoirEquipeToolStripMenuItem, modifierToolStripMenuItem, visualiserLAfficheToolStripMenuItem, visualiserLeJuryToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(209, 108);
            // 
            // VoirEquipeToolStripMenuItem
            // 
            VoirEquipeToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            VoirEquipeToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            VoirEquipeToolStripMenuItem.ForeColor = Color.White;
            VoirEquipeToolStripMenuItem.Image = (Image)resources.GetObject("VoirEquipeToolStripMenuItem.Image");
            VoirEquipeToolStripMenuItem.Name = "VoirEquipeToolStripMenuItem";
            VoirEquipeToolStripMenuItem.Size = new Size(208, 26);
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
            modifierToolStripMenuItem.Size = new Size(208, 26);
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
            visualiserLAfficheToolStripMenuItem.Size = new Size(208, 26);
            visualiserLAfficheToolStripMenuItem.Text = "Visualiser l'Affiche";
            visualiserLAfficheToolStripMenuItem.Click += visualiserLAfficheToolStripMenuItem_Click;
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
            labelInfo.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.ForeColor = SystemColors.ActiveCaptionText;
            labelInfo.Location = new Point(10, 444);
            labelInfo.Margin = new Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(492, 14);
            labelInfo.TabIndex = 4;
            labelInfo.Text = "click droit sur l'hackathon sélectionné pour voir ses équipes";
            // 
            // dgvEquipesJury
            // 
            dgvEquipesJury.AllowUserToAddRows = false;
            dgvEquipesJury.AllowUserToDeleteRows = false;
            dgvEquipesJury.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipesJury.ContextMenuStrip = contextMenuStripEquipe;
            dgvEquipesJury.Location = new Point(546, 38);
            dgvEquipesJury.Margin = new Padding(5);
            dgvEquipesJury.Name = "dgvEquipesJury";
            dgvEquipesJury.ReadOnly = true;
            dgvEquipesJury.RowHeadersWidth = 51;
            dgvEquipesJury.Size = new Size(247, 358);
            dgvEquipesJury.TabIndex = 5;
            dgvEquipesJury.Visible = false;
            // 
            // contextMenuStripEquipe
            // 
            contextMenuStripEquipe.BackColor = Color.FromArgb(30, 35, 40);
            contextMenuStripEquipe.ImageScalingSize = new Size(20, 20);
            contextMenuStripEquipe.Items.AddRange(new ToolStripItem[] { désinscrireEquipeToolStripMenuItem });
            contextMenuStripEquipe.Name = "contextMenuStripEquipe";
            contextMenuStripEquipe.Size = new Size(195, 30);
            // 
            // désinscrireEquipeToolStripMenuItem
            // 
            désinscrireEquipeToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            désinscrireEquipeToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            désinscrireEquipeToolStripMenuItem.ForeColor = Color.White;
            désinscrireEquipeToolStripMenuItem.Image = Properties.Resources.arrow_right_15604;
            désinscrireEquipeToolStripMenuItem.Name = "désinscrireEquipeToolStripMenuItem";
            désinscrireEquipeToolStripMenuItem.Size = new Size(194, 26);
            désinscrireEquipeToolStripMenuItem.Text = "Désinscrire Equipe";
            désinscrireEquipeToolStripMenuItem.Click += désinscrireEquipeToolStripMenuItem_Click;
            // 
            // buttonPrec
            // 
            buttonPrec.BackColor = Color.FromArgb(35, 40, 45);
            buttonPrec.FlatStyle = FlatStyle.Popup;
            buttonPrec.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrec.ForeColor = Color.White;
            buttonPrec.Location = new Point(259, 395);
            buttonPrec.Margin = new Padding(3, 2, 3, 2);
            buttonPrec.Name = "buttonPrec";
            buttonPrec.Size = new Size(110, 22);
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
            buttonSuiv.Location = new Point(430, 395);
            buttonSuiv.Margin = new Padding(3, 2, 3, 2);
            buttonSuiv.Name = "buttonSuiv";
            buttonSuiv.Size = new Size(110, 22);
            buttonSuiv.TabIndex = 8;
            buttonSuiv.Text = "Suivant";
            buttonSuiv.UseVisualStyleBackColor = false;
            buttonSuiv.Click += buttonSuiv_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(536, 395);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 22);
            panel1.TabIndex = 11;
            // 
            // textBoxPage
            // 
            textBoxPage.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPage.Location = new Point(369, 395);
            textBoxPage.Margin = new Padding(3, 2, 3, 2);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(62, 25);
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
            label1.Location = new Point(10, 426);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(478, 14);
            label1.TabIndex = 14;
            label1.Text = "double click gauche sur l'hackathon afin d'archivé celui-ci";
            // 
            // pictureBoxFermer
            // 
            pictureBoxFermer.BackColor = Color.Transparent;
            pictureBoxFermer.Image = Properties.Resources.icons8_multiply_32;
            pictureBoxFermer.Location = new Point(981, 0);
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
            panel2.Location = new Point(10, 395);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 22);
            panel2.TabIndex = 15;
            // 
            // pictureBoxAffiche
            // 
            pictureBoxAffiche.BackColor = Color.Ivory;
            pictureBoxAffiche.Location = new Point(3, 2);
            pictureBoxAffiche.Margin = new Padding(3, 2, 3, 2);
            pictureBoxAffiche.Name = "pictureBoxAffiche";
            pictureBoxAffiche.Size = new Size(255, 319);
            pictureBoxAffiche.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAffiche.TabIndex = 31;
            pictureBoxAffiche.TabStop = false;
            // 
            // panelPictureBoxAffiche
            // 
            panelPictureBoxAffiche.BackColor = Color.Black;
            panelPictureBoxAffiche.Controls.Add(pictureBoxAffiche);
            panelPictureBoxAffiche.Location = new Point(505, 57);
            panelPictureBoxAffiche.Margin = new Padding(3, 2, 3, 2);
            panelPictureBoxAffiche.Name = "panelPictureBoxAffiche";
            panelPictureBoxAffiche.Size = new Size(260, 323);
            panelPictureBoxAffiche.TabIndex = 32;
            panelPictureBoxAffiche.Visible = false;
            // 
            // textBoxThematique
            // 
            textBoxThematique.Location = new Point(802, 79);
            textBoxThematique.Name = "textBoxThematique";
            textBoxThematique.Size = new Size(200, 23);
            textBoxThematique.TabIndex = 33;
            textBoxThematique.TextChanged += textBoxThematique_TextChanged;
            // 
            // dateTimePickerDatePrec
            // 
            dateTimePickerDatePrec.Location = new Point(803, 134);
            dateTimePickerDatePrec.Name = "dateTimePickerDatePrec";
            dateTimePickerDatePrec.Size = new Size(200, 23);
            dateTimePickerDatePrec.TabIndex = 34;
            dateTimePickerDatePrec.ValueChanged += dateTimePickerDatePrec_ValueChanged;
            // 
            // dateTimePickerDateSuiv
            // 
            dateTimePickerDateSuiv.Location = new Point(803, 163);
            dateTimePickerDateSuiv.Name = "dateTimePickerDateSuiv";
            dateTimePickerDateSuiv.Size = new Size(200, 23);
            dateTimePickerDateSuiv.TabIndex = 35;
            dateTimePickerDateSuiv.ValueChanged += dateTimePickerDateSuiv_ValueChanged;
            // 
            // textBoxVille
            // 
            textBoxVille.Location = new Point(802, 220);
            textBoxVille.Name = "textBoxVille";
            textBoxVille.Size = new Size(200, 23);
            textBoxVille.TabIndex = 37;
            textBoxVille.TextChanged += textBoxVille_TextChanged;
            // 
            // comboBoxEquipe
            // 
            comboBoxEquipe.FormattingEnabled = true;
            comboBoxEquipe.Location = new Point(802, 282);
            comboBoxEquipe.Name = "comboBoxEquipe";
            comboBoxEquipe.Size = new Size(200, 23);
            comboBoxEquipe.TabIndex = 38;
            comboBoxEquipe.SelectedIndexChanged += comboBoxEquipe_SelectedIndexChanged;
            // 
            // numericUpDownPlacesRestantes
            // 
            numericUpDownPlacesRestantes.Location = new Point(802, 341);
            numericUpDownPlacesRestantes.Name = "numericUpDownPlacesRestantes";
            numericUpDownPlacesRestantes.Size = new Size(200, 23);
            numericUpDownPlacesRestantes.TabIndex = 39;
            numericUpDownPlacesRestantes.ValueChanged += numericUpDownPlacesRestantes_ValueChanged;
            // 
            // buttonRenitialiserFiltre
            // 
            buttonRenitialiserFiltre.BackColor = Color.FromArgb(30, 35, 40);
            buttonRenitialiserFiltre.FlatStyle = FlatStyle.Popup;
            buttonRenitialiserFiltre.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRenitialiserFiltre.ForeColor = Color.White;
            buttonRenitialiserFiltre.Location = new Point(833, 394);
            buttonRenitialiserFiltre.Name = "buttonRenitialiserFiltre";
            buttonRenitialiserFiltre.Size = new Size(138, 23);
            buttonRenitialiserFiltre.TabIndex = 40;
            buttonRenitialiserFiltre.Text = "Rénitialiser Filtre";
            buttonRenitialiserFiltre.UseVisualStyleBackColor = false;
            buttonRenitialiserFiltre.Click += buttonRenitialiserFiltre_Click;
            // 
            // labelThematique
            // 
            labelThematique.AutoSize = true;
            labelThematique.BackColor = Color.Transparent;
            labelThematique.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelThematique.Location = new Point(847, 60);
            labelThematique.Name = "labelThematique";
            labelThematique.Size = new Size(114, 16);
            labelThematique.TabIndex = 41;
            labelThematique.Text = "Thématique :";
            // 
            // labelRecherche
            // 
            labelRecherche.AutoSize = true;
            labelRecherche.BackColor = Color.Transparent;
            labelRecherche.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRecherche.Location = new Point(811, 38);
            labelRecherche.Name = "labelRecherche";
            labelRecherche.Size = new Size(174, 19);
            labelRecherche.TabIndex = 42;
            labelRecherche.Text = "Recherche Filtré";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = Color.Transparent;
            labelDate.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDate.Location = new Point(872, 115);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(70, 16);
            labelDate.TabIndex = 43;
            labelDate.Text = "Date : ";
            // 
            // labelVille
            // 
            labelVille.AutoSize = true;
            labelVille.BackColor = Color.Transparent;
            labelVille.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelVille.Location = new Point(871, 201);
            labelVille.Name = "labelVille";
            labelVille.Size = new Size(70, 16);
            labelVille.TabIndex = 44;
            labelVille.Text = "Ville :";
            // 
            // labelEquipe
            // 
            labelEquipe.AutoSize = true;
            labelEquipe.BackColor = Color.Transparent;
            labelEquipe.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEquipe.Location = new Point(822, 263);
            labelEquipe.Name = "labelEquipe";
            labelEquipe.Size = new Size(160, 16);
            labelEquipe.TabIndex = 45;
            labelEquipe.Text = "Equipe Inscrite :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(817, 322);
            label7.Name = "label7";
            label7.Size = new Size(169, 16);
            label7.TabIndex = 46;
            label7.Text = "Nombre de Places :";
            // 
            // visualiserLeJuryToolStripMenuItem
            // 
            visualiserLeJuryToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            visualiserLeJuryToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            visualiserLeJuryToolStripMenuItem.ForeColor = Color.White;
            visualiserLeJuryToolStripMenuItem.Image = Properties.Resources.arrow_right_15604;
            visualiserLeJuryToolStripMenuItem.Name = "visualiserLeJuryToolStripMenuItem";
            visualiserLeJuryToolStripMenuItem.Size = new Size(208, 26);
            visualiserLeJuryToolStripMenuItem.Text = "Visualiser le Jury";
            // 
            // FormHackathon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1013, 464);
            Controls.Add(label7);
            Controls.Add(labelEquipe);
            Controls.Add(labelVille);
            Controls.Add(labelDate);
            Controls.Add(labelRecherche);
            Controls.Add(labelThematique);
            Controls.Add(buttonRenitialiserFiltre);
            Controls.Add(numericUpDownPlacesRestantes);
            Controls.Add(comboBoxEquipe);
            Controls.Add(textBoxVille);
            Controls.Add(dateTimePickerDateSuiv);
            Controls.Add(dateTimePickerDatePrec);
            Controls.Add(textBoxThematique);
            Controls.Add(panelPictureBoxAffiche);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(textBoxPage);
            Controls.Add(panel1);
            Controls.Add(buttonSuiv);
            Controls.Add(buttonPrec);
            Controls.Add(pictureBoxFermer);
            Controls.Add(dgvEquipesJury);
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
            ((System.ComponentModel.ISupportInitialize)dgvEquipesJury).EndInit();
            contextMenuStripEquipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAffiche).EndInit();
            panelPictureBoxAffiche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownPlacesRestantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceAllEquipeCombo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource BSHackathon;
        private System.Windows.Forms.DataGridView dgvHackathon;
        private System.Windows.Forms.Label labelListe;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.BindingSource BSEquipe;
        private System.Windows.Forms.DataGridView dgvEquipesJury;
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
        private ContextMenuStrip contextMenuStripEquipe;
        private ToolStripMenuItem désinscrireEquipeToolStripMenuItem;
        private TextBox textBoxThematique;
        private DateTimePicker dateTimePickerDatePrec;
        private DateTimePicker dateTimePickerDateSuiv;
        private TextBox textBoxVille;
        private ComboBox comboBoxEquipe;
        private NumericUpDown numericUpDownPlacesRestantes;
        private Button buttonRenitialiserFiltre;
        private Label labelThematique;
        private Label labelRecherche;
        private Label labelDate;
        private Label labelVille;
        private Label labelEquipe;
        private Label label7;
        private BindingSource bindingSourceAllEquipeCombo;
        private ToolStripMenuItem visualiserLeJuryToolStripMenuItem;
    }
}

