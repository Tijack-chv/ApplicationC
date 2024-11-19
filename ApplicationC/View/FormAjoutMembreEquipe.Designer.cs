namespace ApplicationC.View
{
    partial class FormAjoutMembreEquipe
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
            checkedListBoxMembres = new CheckedListBox();
            labelMembres = new Label();
            buttonFermer = new Button();
            buttonAjouter = new Button();
            labelTitle = new Label();
            labelEquipe = new Label();
            bindingSourceMembres = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembres).BeginInit();
            SuspendLayout();
            // 
            // checkedListBoxMembres
            // 
            checkedListBoxMembres.FormattingEnabled = true;
            checkedListBoxMembres.Location = new Point(31, 106);
            checkedListBoxMembres.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxMembres.Name = "checkedListBoxMembres";
            checkedListBoxMembres.Size = new Size(279, 148);
            checkedListBoxMembres.TabIndex = 47;
            // 
            // labelMembres
            // 
            labelMembres.AutoSize = true;
            labelMembres.BackColor = Color.Transparent;
            labelMembres.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMembres.ForeColor = Color.White;
            labelMembres.Location = new Point(131, 85);
            labelMembres.Margin = new Padding(4, 0, 4, 0);
            labelMembres.Name = "labelMembres";
            labelMembres.Size = new Size(78, 18);
            labelMembres.TabIndex = 46;
            labelMembres.Text = "Membres";
            // 
            // buttonFermer
            // 
            buttonFermer.BackColor = Color.Black;
            buttonFermer.FlatStyle = FlatStyle.Popup;
            buttonFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFermer.ForeColor = SystemColors.ControlLightLight;
            buttonFermer.Location = new Point(189, 293);
            buttonFermer.Margin = new Padding(4);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Size = new Size(111, 43);
            buttonFermer.TabIndex = 45;
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
            buttonAjouter.Location = new Point(42, 292);
            buttonAjouter.Margin = new Padding(4);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(111, 43);
            buttonAjouter.TabIndex = 44;
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
            labelTitle.Location = new Point(24, 15);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(292, 24);
            labelTitle.TabIndex = 43;
            labelTitle.Text = "Ajouter Membre à une Equipe";
            // 
            // labelEquipe
            // 
            labelEquipe.AutoSize = true;
            labelEquipe.BackColor = Color.Transparent;
            labelEquipe.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEquipe.ForeColor = Color.White;
            labelEquipe.Location = new Point(121, 39);
            labelEquipe.Margin = new Padding(4, 0, 4, 0);
            labelEquipe.Name = "labelEquipe";
            labelEquipe.Size = new Size(98, 18);
            labelEquipe.TabIndex = 48;
            labelEquipe.Text = "Nom équipe";
            // 
            // FormAjoutMembreEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            ClientSize = new Size(340, 353);
            Controls.Add(labelEquipe);
            Controls.Add(checkedListBoxMembres);
            Controls.Add(labelMembres);
            Controls.Add(buttonFermer);
            Controls.Add(buttonAjouter);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FormAjoutMembreEquipe";
            Text = "FormAjoutMembreEquipe";
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembres).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBoxMembres;
        private Label labelMembres;
        private Button buttonFermer;
        private Button buttonAjouter;
        private Label labelTitle;
        private Label labelEquipe;
        private BindingSource bindingSourceMembres;
    }
}