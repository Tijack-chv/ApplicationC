namespace ApplicationC
{
    partial class FormMembreEquipe
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dataGridViewMembreEquipe = new DataGridView();
            contextMenuStripInfoEquipe = new ContextMenuStrip(components);
            voirLesMembresToolStripMenuItem = new ToolStripMenuItem();
            modifierLéquipeToolStripMenuItem = new ToolStripMenuItem();
            ajouterMembresToolStripMenuItem = new ToolStripMenuItem();
            labelListeMembreEquipe = new Label();
            textBoxPage = new TextBox();
            panelLeft = new Panel();
            panelRight = new Panel();
            buttonSuiv = new Button();
            buttonPrec = new Button();
            labelInfoEquipe = new Label();
            bindingSourceMembreEquipe = new BindingSource(components);
            pictureBoxFermer = new PictureBox();
            dataGridViewInfoEquipe = new DataGridView();
            contextMenuStripArchivageMembreEq = new ContextMenuStrip(components);
            supprimerLeMembreDeLéquipeToolStripMenuItem = new ToolStripMenuItem();
            bindingSourceInfoEquipe = new BindingSource(components);
            labelSuppEquipeMembre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembreEquipe).BeginInit();
            contextMenuStripInfoEquipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembreEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfoEquipe).BeginInit();
            contextMenuStripArchivageMembreEq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceInfoEquipe).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMembreEquipe
            // 
            dataGridViewMembreEquipe.AllowUserToAddRows = false;
            dataGridViewMembreEquipe.AllowUserToDeleteRows = false;
            dataGridViewMembreEquipe.AllowUserToOrderColumns = true;
            dataGridViewMembreEquipe.AllowUserToResizeRows = false;
            dataGridViewMembreEquipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMembreEquipe.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewMembreEquipe.BorderStyle = BorderStyle.None;
            dataGridViewMembreEquipe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle1.Font = new Font("Rockwell", 11.25F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewMembreEquipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewMembreEquipe.ColumnHeadersHeight = 30;
            dataGridViewMembreEquipe.ContextMenuStrip = contextMenuStripInfoEquipe;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle2.Font = new Font("Rockwell", 11.25F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewMembreEquipe.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewMembreEquipe.EnableHeadersVisualStyles = false;
            dataGridViewMembreEquipe.Location = new Point(145, 37);
            dataGridViewMembreEquipe.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMembreEquipe.MultiSelect = false;
            dataGridViewMembreEquipe.Name = "dataGridViewMembreEquipe";
            dataGridViewMembreEquipe.ReadOnly = true;
            dataGridViewMembreEquipe.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle3.Font = new Font("Rockwell", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewMembreEquipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewMembreEquipe.RowHeadersVisible = false;
            dataGridViewMembreEquipe.RowHeadersWidth = 55;
            dataGridViewMembreEquipe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMembreEquipe.Size = new Size(626, 360);
            dataGridViewMembreEquipe.TabIndex = 0;
            dataGridViewMembreEquipe.CellClick += dataGridViewMembreEquipe_CellClick;
            dataGridViewMembreEquipe.CellContentClick += dataGridViewMembreEquipe_CellContentClick;
            dataGridViewMembreEquipe.CellMouseClick += dataGridViewMembreEquipe_CellMouseClick;
            // 
            // contextMenuStripInfoEquipe
            // 
            contextMenuStripInfoEquipe.ImageScalingSize = new Size(20, 20);
            contextMenuStripInfoEquipe.Items.AddRange(new ToolStripItem[] { voirLesMembresToolStripMenuItem, modifierLéquipeToolStripMenuItem, ajouterMembresToolStripMenuItem });
            contextMenuStripInfoEquipe.Name = "contextMenuStripInfoEquipe";
            contextMenuStripInfoEquipe.Size = new Size(186, 82);
            // 
            // voirLesMembresToolStripMenuItem
            // 
            voirLesMembresToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé1;
            voirLesMembresToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            voirLesMembresToolStripMenuItem.ForeColor = Color.White;
            voirLesMembresToolStripMenuItem.Image = Properties.Resources.arrow_right_15604;
            voirLesMembresToolStripMenuItem.Name = "voirLesMembresToolStripMenuItem";
            voirLesMembresToolStripMenuItem.Size = new Size(185, 26);
            voirLesMembresToolStripMenuItem.Text = "Voir les membres";
            voirLesMembresToolStripMenuItem.Click += voirLesMembresToolStripMenuItem_Click;
            // 
            // modifierLéquipeToolStripMenuItem
            // 
            modifierLéquipeToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé1;
            modifierLéquipeToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            modifierLéquipeToolStripMenuItem.ForeColor = Color.White;
            modifierLéquipeToolStripMenuItem.Image = Properties.Resources.arrow_right_15604;
            modifierLéquipeToolStripMenuItem.Name = "modifierLéquipeToolStripMenuItem";
            modifierLéquipeToolStripMenuItem.Size = new Size(185, 26);
            modifierLéquipeToolStripMenuItem.Text = "Modifier l'équipe";
            modifierLéquipeToolStripMenuItem.Click += modifierLéquipeToolStripMenuItem_Click;
            // 
            // ajouterMembresToolStripMenuItem
            // 
            ajouterMembresToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            ajouterMembresToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            ajouterMembresToolStripMenuItem.ForeColor = Color.White;
            ajouterMembresToolStripMenuItem.Image = Properties.Resources.arrow_right_15604;
            ajouterMembresToolStripMenuItem.Name = "ajouterMembresToolStripMenuItem";
            ajouterMembresToolStripMenuItem.Size = new Size(185, 26);
            ajouterMembresToolStripMenuItem.Text = "Ajouter membres";
            ajouterMembresToolStripMenuItem.Click += ajouterMembresToolStripMenuItem_Click;
            // 
            // labelListeMembreEquipe
            // 
            labelListeMembreEquipe.AutoSize = true;
            labelListeMembreEquipe.BackColor = Color.Transparent;
            labelListeMembreEquipe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListeMembreEquipe.Location = new Point(10, 7);
            labelListeMembreEquipe.Margin = new Padding(4, 0, 4, 0);
            labelListeMembreEquipe.Name = "labelListeMembreEquipe";
            labelListeMembreEquipe.Size = new Size(283, 24);
            labelListeMembreEquipe.TabIndex = 3;
            labelListeMembreEquipe.Text = "Liste Des Membres / Equipes";
            // 
            // textBoxPage
            // 
            textBoxPage.Font = new Font("Britannic Bold", 12F);
            textBoxPage.Location = new Point(431, 396);
            textBoxPage.Margin = new Padding(3, 2, 3, 2);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(62, 25);
            textBoxPage.TabIndex = 19;
            textBoxPage.Text = "1";
            textBoxPage.TextAlign = HorizontalAlignment.Center;
            textBoxPage.TextChanged += textBoxPage_TextChanged;
            textBoxPage.KeyPress += textBoxPage_KeyPress;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(30, 35, 40);
            panelLeft.Location = new Point(145, 396);
            panelLeft.Margin = new Padding(3, 2, 3, 2);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(175, 22);
            panelLeft.TabIndex = 18;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(30, 35, 40);
            panelRight.Location = new Point(601, 396);
            panelRight.Margin = new Padding(3, 2, 3, 2);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(170, 22);
            panelRight.TabIndex = 17;
            // 
            // buttonSuiv
            // 
            buttonSuiv.BackColor = Color.FromArgb(35, 40, 45);
            buttonSuiv.FlatStyle = FlatStyle.Popup;
            buttonSuiv.Font = new Font("Rockwell", 12F, FontStyle.Bold);
            buttonSuiv.ForeColor = Color.White;
            buttonSuiv.Location = new Point(491, 396);
            buttonSuiv.Margin = new Padding(3, 2, 3, 2);
            buttonSuiv.Name = "buttonSuiv";
            buttonSuiv.Size = new Size(110, 22);
            buttonSuiv.TabIndex = 16;
            buttonSuiv.Text = "Suivant";
            buttonSuiv.UseVisualStyleBackColor = false;
            buttonSuiv.Click += buttonSuiv_Click;
            // 
            // buttonPrec
            // 
            buttonPrec.BackColor = Color.FromArgb(35, 40, 45);
            buttonPrec.FlatStyle = FlatStyle.Popup;
            buttonPrec.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPrec.ForeColor = Color.White;
            buttonPrec.ImageAlign = ContentAlignment.TopCenter;
            buttonPrec.Location = new Point(320, 396);
            buttonPrec.Margin = new Padding(3, 2, 3, 2);
            buttonPrec.Name = "buttonPrec";
            buttonPrec.Size = new Size(110, 22);
            buttonPrec.TabIndex = 15;
            buttonPrec.Text = "Précédent";
            buttonPrec.UseVisualStyleBackColor = false;
            buttonPrec.Click += buttonPrec_Click;
            // 
            // labelInfoEquipe
            // 
            labelInfoEquipe.AutoSize = true;
            labelInfoEquipe.BackColor = Color.Transparent;
            labelInfoEquipe.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Bold);
            labelInfoEquipe.ForeColor = SystemColors.ActiveCaptionText;
            labelInfoEquipe.Location = new Point(10, 443);
            labelInfoEquipe.Margin = new Padding(4, 0, 4, 0);
            labelInfoEquipe.Name = "labelInfoEquipe";
            labelInfoEquipe.Size = new Size(468, 14);
            labelInfoEquipe.TabIndex = 14;
            labelInfoEquipe.Text = "click droit sur l'équipe sélectionné pour voir ses membres";
            // 
            // pictureBoxFermer
            // 
            pictureBoxFermer.BackColor = Color.Transparent;
            pictureBoxFermer.Image = Properties.Resources.icons8_multiply_32;
            pictureBoxFermer.Location = new Point(982, -1);
            pictureBoxFermer.Name = "pictureBoxFermer";
            pictureBoxFermer.Size = new Size(32, 32);
            pictureBoxFermer.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFermer.TabIndex = 20;
            pictureBoxFermer.TabStop = false;
            // 
            // dataGridViewInfoEquipe
            // 
            dataGridViewInfoEquipe.AllowUserToAddRows = false;
            dataGridViewInfoEquipe.AllowUserToDeleteRows = false;
            dataGridViewInfoEquipe.AllowUserToOrderColumns = true;
            dataGridViewInfoEquipe.AllowUserToResizeRows = false;
            dataGridViewInfoEquipe.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewInfoEquipe.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewInfoEquipe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle4.Font = new Font("Rockwell", 11.25F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewInfoEquipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewInfoEquipe.ColumnHeadersHeight = 30;
            dataGridViewInfoEquipe.ContextMenuStrip = contextMenuStripArchivageMembreEq;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle5.Font = new Font("Rockwell", 11.25F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewInfoEquipe.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewInfoEquipe.EnableHeadersVisualStyles = false;
            dataGridViewInfoEquipe.GridColor = Color.Black;
            dataGridViewInfoEquipe.Location = new Point(453, 37);
            dataGridViewInfoEquipe.Margin = new Padding(3, 2, 3, 2);
            dataGridViewInfoEquipe.MultiSelect = false;
            dataGridViewInfoEquipe.Name = "dataGridViewInfoEquipe";
            dataGridViewInfoEquipe.ReadOnly = true;
            dataGridViewInfoEquipe.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle6.Font = new Font("Rockwell", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewInfoEquipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewInfoEquipe.RowHeadersVisible = false;
            dataGridViewInfoEquipe.RowHeadersWidth = 51;
            dataGridViewInfoEquipe.Size = new Size(318, 360);
            dataGridViewInfoEquipe.TabIndex = 21;
            dataGridViewInfoEquipe.Visible = false;
            // 
            // contextMenuStripArchivageMembreEq
            // 
            contextMenuStripArchivageMembreEq.Items.AddRange(new ToolStripItem[] { supprimerLeMembreDeLéquipeToolStripMenuItem });
            contextMenuStripArchivageMembreEq.Name = "contextMenuStripArchivageMembreEq";
            contextMenuStripArchivageMembreEq.Size = new Size(279, 26);
            // 
            // supprimerLeMembreDeLéquipeToolStripMenuItem
            // 
            supprimerLeMembreDeLéquipeToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé1;
            supprimerLeMembreDeLéquipeToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            supprimerLeMembreDeLéquipeToolStripMenuItem.ForeColor = Color.White;
            supprimerLeMembreDeLéquipeToolStripMenuItem.Image = Properties.Resources.arrow_right_15604;
            supprimerLeMembreDeLéquipeToolStripMenuItem.Name = "supprimerLeMembreDeLéquipeToolStripMenuItem";
            supprimerLeMembreDeLéquipeToolStripMenuItem.Size = new Size(278, 22);
            supprimerLeMembreDeLéquipeToolStripMenuItem.Text = "Supprimer le membre de l'équipe";
            supprimerLeMembreDeLéquipeToolStripMenuItem.Click += supprimerLeMembreDeLéquipeToolStripMenuItem_Click;
            // 
            // labelSuppEquipeMembre
            // 
            labelSuppEquipeMembre.AutoSize = true;
            labelSuppEquipeMembre.BackColor = Color.Transparent;
            labelSuppEquipeMembre.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Bold);
            labelSuppEquipeMembre.ForeColor = SystemColors.ActiveCaptionText;
            labelSuppEquipeMembre.Location = new Point(10, 425);
            labelSuppEquipeMembre.Margin = new Padding(4, 0, 4, 0);
            labelSuppEquipeMembre.Name = "labelSuppEquipeMembre";
            labelSuppEquipeMembre.Size = new Size(484, 14);
            labelSuppEquipeMembre.TabIndex = 22;
            labelSuppEquipeMembre.Text = "double click gauche sur l'équipe sélectioné pour la suppimer";
            // 
            // FormMembreEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1013, 464);
            Controls.Add(labelSuppEquipeMembre);
            Controls.Add(dataGridViewInfoEquipe);
            Controls.Add(pictureBoxFermer);
            Controls.Add(textBoxPage);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            Controls.Add(buttonSuiv);
            Controls.Add(buttonPrec);
            Controls.Add(labelInfoEquipe);
            Controls.Add(labelListeMembreEquipe);
            Controls.Add(dataGridViewMembreEquipe);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMembreEquipe";
            Text = "FormMembreEquipe";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembreEquipe).EndInit();
            contextMenuStripInfoEquipe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembreEquipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfoEquipe).EndInit();
            contextMenuStripArchivageMembreEq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceInfoEquipe).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMembreEquipe;
        private Label labelListeMembreEquipe;
        private TextBox textBoxPage;
        private Panel panelLeft;
        private Panel panelRight;
        private Button buttonSuiv;
        private Button buttonPrec;
        private Label labelInfoEquipe;
        private BindingSource bindingSourceMembreEquipe;
        private PictureBox pictureBoxFermer;
        private DataGridView dataGridViewInfoEquipe;
        private BindingSource bindingSourceInfoEquipe;
        private ContextMenuStrip contextMenuStripInfoEquipe;
        private ToolStripMenuItem voirLesMembresToolStripMenuItem;
        private ToolStripMenuItem modifierLéquipeToolStripMenuItem;
        private Label labelSuppEquipeMembre;
        private ToolStripMenuItem ajouterMembresToolStripMenuItem;
        private ContextMenuStrip contextMenuStripArchivageMembreEq;
        private ToolStripMenuItem supprimerLeMembreDeLéquipeToolStripMenuItem;
    }
}