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
            dataGridViewMembreEquipe = new DataGridView();
            contextMenuStripInfoEquipe = new ContextMenuStrip(components);
            voirLesMembresToolStripMenuItem = new ToolStripMenuItem();
            modifierLéquipeToolStripMenuItem = new ToolStripMenuItem();
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
            bindingSourceInfoEquipe = new BindingSource(components);
            labelSuppEquipeMembre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembreEquipe).BeginInit();
            contextMenuStripInfoEquipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembreEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfoEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceInfoEquipe).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMembreEquipe
            // 
            dataGridViewMembreEquipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMembreEquipe.ContextMenuStrip = contextMenuStripInfoEquipe;
            dataGridViewMembreEquipe.Location = new Point(10, 40);
            dataGridViewMembreEquipe.Margin = new Padding(3, 2, 3, 2);
            dataGridViewMembreEquipe.Name = "dataGridViewMembreEquipe";
            dataGridViewMembreEquipe.RowHeadersWidth = 51;
            dataGridViewMembreEquipe.Size = new Size(991, 360);
            dataGridViewMembreEquipe.TabIndex = 0;
            dataGridViewMembreEquipe.CellClick += dataGridViewMembreEquipe_CellClick;
            dataGridViewMembreEquipe.CellContentClick += dataGridViewMembreEquipe_CellContentClick;
            dataGridViewMembreEquipe.CellMouseClick += dataGridViewMembreEquipe_CellMouseClick;
            // 
            // contextMenuStripInfoEquipe
            // 
            contextMenuStripInfoEquipe.ImageScalingSize = new Size(20, 20);
            contextMenuStripInfoEquipe.Items.AddRange(new ToolStripItem[] { voirLesMembresToolStripMenuItem, modifierLéquipeToolStripMenuItem });
            contextMenuStripInfoEquipe.Name = "contextMenuStripInfoEquipe";
            contextMenuStripInfoEquipe.Size = new Size(165, 48);
            // 
            // voirLesMembresToolStripMenuItem
            // 
            voirLesMembresToolStripMenuItem.Name = "voirLesMembresToolStripMenuItem";
            voirLesMembresToolStripMenuItem.Size = new Size(164, 22);
            voirLesMembresToolStripMenuItem.Text = "Voir les membres";
            voirLesMembresToolStripMenuItem.Click += voirLesMembresToolStripMenuItem_Click;
            // 
            // modifierLéquipeToolStripMenuItem
            // 
            modifierLéquipeToolStripMenuItem.Name = "modifierLéquipeToolStripMenuItem";
            modifierLéquipeToolStripMenuItem.Size = new Size(164, 22);
            modifierLéquipeToolStripMenuItem.Text = "Modifier l'équipe";
            modifierLéquipeToolStripMenuItem.Click += modifierLéquipeToolStripMenuItem_Click;
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
            textBoxPage.Location = new Point(462, 399);
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
            panelLeft.Location = new Point(10, 399);
            panelLeft.Margin = new Padding(3, 2, 3, 2);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(340, 22);
            panelLeft.TabIndex = 18;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(30, 35, 40);
            panelRight.Location = new Point(632, 399);
            panelRight.Margin = new Padding(3, 2, 3, 2);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(369, 22);
            panelRight.TabIndex = 17;
            // 
            // buttonSuiv
            // 
            buttonSuiv.BackColor = Color.FromArgb(35, 40, 45);
            buttonSuiv.FlatStyle = FlatStyle.Popup;
            buttonSuiv.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSuiv.ForeColor = Color.White;
            buttonSuiv.Location = new Point(522, 399);
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
            buttonPrec.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrec.ForeColor = Color.White;
            buttonPrec.Location = new Point(351, 399);
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
            dataGridViewInfoEquipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfoEquipe.Location = new Point(736, 40);
            dataGridViewInfoEquipe.Margin = new Padding(3, 2, 3, 2);
            dataGridViewInfoEquipe.Name = "dataGridViewInfoEquipe";
            dataGridViewInfoEquipe.RowHeadersWidth = 51;
            dataGridViewInfoEquipe.Size = new Size(265, 360);
            dataGridViewInfoEquipe.TabIndex = 21;
            dataGridViewInfoEquipe.Visible = false;
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
    }
}