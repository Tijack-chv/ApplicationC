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
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembreEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembreEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfoEquipe).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMembreEquipe
            // 
            dataGridViewMembreEquipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMembreEquipe.Location = new Point(12, 38);
            dataGridViewMembreEquipe.Name = "dataGridViewMembreEquipe";
            dataGridViewMembreEquipe.RowHeadersWidth = 51;
            dataGridViewMembreEquipe.Size = new Size(736, 289);
            dataGridViewMembreEquipe.TabIndex = 0;
            // 
            // labelListeMembreEquipe
            // 
            labelListeMembreEquipe.AutoSize = true;
            labelListeMembreEquipe.BackColor = Color.Transparent;
            labelListeMembreEquipe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListeMembreEquipe.Location = new Point(12, 9);
            labelListeMembreEquipe.Margin = new Padding(5, 0, 5, 0);
            labelListeMembreEquipe.Name = "labelListeMembreEquipe";
            labelListeMembreEquipe.Size = new Size(356, 29);
            labelListeMembreEquipe.TabIndex = 3;
            labelListeMembreEquipe.Text = "Liste Des Membres / Equipes";
            // 
            // textBoxPage
            // 
            textBoxPage.Font = new Font("Britannic Bold", 12F);
            textBoxPage.Location = new Point(347, 327);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(70, 30);
            textBoxPage.TabIndex = 19;
            textBoxPage.Text = "1";
            textBoxPage.TextAlign = HorizontalAlignment.Center;
            textBoxPage.TextChanged += textBoxPage_TextChanged;
            textBoxPage.KeyPress += textBoxPage_KeyPress;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(30, 35, 40);
            panelLeft.Location = new Point(12, 327);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(208, 29);
            panelLeft.TabIndex = 18;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.FromArgb(30, 35, 40);
            panelRight.Location = new Point(542, 327);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(206, 29);
            panelRight.TabIndex = 17;
            // 
            // buttonSuiv
            // 
            buttonSuiv.BackColor = Color.FromArgb(35, 40, 45);
            buttonSuiv.FlatStyle = FlatStyle.Popup;
            buttonSuiv.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSuiv.ForeColor = Color.White;
            buttonSuiv.Location = new Point(416, 327);
            buttonSuiv.Name = "buttonSuiv";
            buttonSuiv.Size = new Size(126, 29);
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
            buttonPrec.Location = new Point(221, 327);
            buttonPrec.Name = "buttonPrec";
            buttonPrec.Size = new Size(126, 29);
            buttonPrec.TabIndex = 15;
            buttonPrec.Text = "Précédent";
            buttonPrec.UseVisualStyleBackColor = false;
            buttonPrec.Click += buttonPrec_Click;
            // 
            // labelInfoEquipe
            // 
            labelInfoEquipe.AutoSize = true;
            labelInfoEquipe.BackColor = Color.Transparent;
            labelInfoEquipe.Font = new Font("SimSun-ExtB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfoEquipe.ForeColor = SystemColors.ActiveCaptionText;
            labelInfoEquipe.Location = new Point(19, 392);
            labelInfoEquipe.Margin = new Padding(5, 0, 5, 0);
            labelInfoEquipe.Name = "labelInfoEquipe";
            labelInfoEquipe.Size = new Size(641, 20);
            labelInfoEquipe.TabIndex = 14;
            labelInfoEquipe.Text = "click droit sur l'équipe sélectionné pour voir ses membres";
            // 
            // pictureBoxFermer
            // 
            pictureBoxFermer.BackColor = Color.Transparent;
            pictureBoxFermer.Image = Properties.Resources.icons8_multiply_32;
            pictureBoxFermer.Location = new Point(722, 4);
            pictureBoxFermer.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFermer.Name = "pictureBoxFermer";
            pictureBoxFermer.Size = new Size(32, 32);
            pictureBoxFermer.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFermer.TabIndex = 20;
            pictureBoxFermer.TabStop = false;
            // 
            // dataGridViewInfoEquipe
            // 
            dataGridViewInfoEquipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfoEquipe.Location = new Point(445, 38);
            dataGridViewInfoEquipe.Name = "dataGridViewInfoEquipe";
            dataGridViewInfoEquipe.RowHeadersWidth = 51;
            dataGridViewInfoEquipe.Size = new Size(303, 289);
            dataGridViewInfoEquipe.TabIndex = 21;
            dataGridViewInfoEquipe.Visible = false;
            // 
            // FormMembreEquipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(760, 429);
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
            Name = "FormMembreEquipe";
            Text = "FormMembreEquipe";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMembreEquipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembreEquipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFermer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfoEquipe).EndInit();
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
    }
}