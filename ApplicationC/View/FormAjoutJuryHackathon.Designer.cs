namespace ApplicationC.View
{
    partial class FormAjoutJuryHackathon
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
            buttonFermer = new Button();
            buttonAjouter = new Button();
            labelTitle = new Label();
            labelMembresJury = new Label();
            bindingSourceEquipeJury = new BindingSource(components);
            checkedListBoxJury = new CheckedListBox();
            textBoxRecherche = new TextBox();
            labelRecherche = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSourceEquipeJury).BeginInit();
            SuspendLayout();
            // 
            // buttonFermer
            // 
            buttonFermer.BackColor = Color.Black;
            buttonFermer.FlatStyle = FlatStyle.Popup;
            buttonFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFermer.ForeColor = SystemColors.ControlLightLight;
            buttonFermer.Location = new Point(217, 389);
            buttonFermer.Margin = new Padding(5);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Size = new Size(127, 57);
            buttonFermer.TabIndex = 36;
            buttonFermer.Text = "FERMER";
            buttonFermer.UseVisualStyleBackColor = false;
            buttonFermer.Click += buttonFermer_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.BackColor = Color.Black;
            buttonAjouter.FlatStyle = FlatStyle.Popup;
            buttonAjouter.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAjouter.ForeColor = SystemColors.ControlLightLight;
            buttonAjouter.Location = new Point(49, 389);
            buttonAjouter.Margin = new Padding(5);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(127, 57);
            buttonAjouter.TabIndex = 35;
            buttonAjouter.Text = "AJOUTER";
            buttonAjouter.UseVisualStyleBackColor = false;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(38, 9);
            labelTitle.Margin = new Padding(5, 0, 5, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(318, 29);
            labelTitle.TabIndex = 28;
            labelTitle.Text = "Choix Jury d'un Hackathon";
            // 
            // labelMembresJury
            // 
            labelMembresJury.AutoSize = true;
            labelMembresJury.BackColor = Color.Transparent;
            labelMembresJury.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMembresJury.ForeColor = Color.White;
            labelMembresJury.Location = new Point(114, 55);
            labelMembresJury.Margin = new Padding(5, 0, 5, 0);
            labelMembresJury.Name = "labelMembresJury";
            labelMembresJury.Size = new Size(162, 22);
            labelMembresJury.TabIndex = 38;
            labelMembresJury.Text = "Membres du Jury";
            // 
            // checkedListBoxJury
            // 
            checkedListBoxJury.FormattingEnabled = true;
            checkedListBoxJury.Location = new Point(36, 82);
            checkedListBoxJury.Name = "checkedListBoxJury";
            checkedListBoxJury.Size = new Size(318, 202);
            checkedListBoxJury.TabIndex = 40;
            // 
            // textBoxRecherche
            // 
            textBoxRecherche.Location = new Point(36, 339);
            textBoxRecherche.Name = "textBoxRecherche";
            textBoxRecherche.Size = new Size(316, 27);
            textBoxRecherche.TabIndex = 41;
            textBoxRecherche.TextChanged += textBoxRecherche_TextChanged;
            textBoxRecherche.KeyPress += textBoxRecherche_KeyPress;
            // 
            // labelRecherche
            // 
            labelRecherche.AutoSize = true;
            labelRecherche.BackColor = Color.Transparent;
            labelRecherche.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRecherche.ForeColor = Color.White;
            labelRecherche.Location = new Point(102, 314);
            labelRecherche.Margin = new Padding(5, 0, 5, 0);
            labelRecherche.Name = "labelRecherche";
            labelRecherche.Size = new Size(182, 22);
            labelRecherche.TabIndex = 42;
            labelRecherche.Text = "Barre de recherche";
            labelRecherche.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAjoutJuryHackathon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé1;
            ClientSize = new Size(389, 471);
            Controls.Add(labelRecherche);
            Controls.Add(textBoxRecherche);
            Controls.Add(checkedListBoxJury);
            Controls.Add(labelMembresJury);
            Controls.Add(buttonFermer);
            Controls.Add(buttonAjouter);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FormAjoutJuryHackathon";
            Text = "Hackathon Jury";
            ((System.ComponentModel.ISupportInitialize)bindingSourceEquipeJury).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFermer;
        private Button buttonAjouter;
        private Label labelTitle;
        private Label labelMembresJury;
        private BindingSource bindingSourceEquipeJury;
        private CheckedListBox checkedListBoxJury;
        private TextBox textBoxRecherche;
        private Label labelRecherche;
    }
}