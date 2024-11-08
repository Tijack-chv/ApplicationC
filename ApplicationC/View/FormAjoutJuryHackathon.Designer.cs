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
            textboxMembresJury = new TextBox();
            labelTitle = new Label();
            comboBoxEquipeJury = new ComboBox();
            labelMembresJury = new Label();
            labelEquipeJury = new Label();
            bindingSourceEquipeJury = new BindingSource(components);
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
            // textboxMembresJury
            // 
            textboxMembresJury.BorderStyle = BorderStyle.FixedSingle;
            textboxMembresJury.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            textboxMembresJury.Location = new Point(49, 199);
            textboxMembresJury.Margin = new Padding(5);
            textboxMembresJury.Multiline = true;
            textboxMembresJury.Name = "textboxMembresJury";
            textboxMembresJury.ReadOnly = true;
            textboxMembresJury.ScrollBars = ScrollBars.Vertical;
            textboxMembresJury.Size = new Size(297, 102);
            textboxMembresJury.TabIndex = 30;
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
            // comboBoxEquipeJury
            // 
            comboBoxEquipeJury.FlatStyle = FlatStyle.Popup;
            comboBoxEquipeJury.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            comboBoxEquipeJury.FormattingEnabled = true;
            comboBoxEquipeJury.Location = new Point(49, 97);
            comboBoxEquipeJury.Name = "comboBoxEquipeJury";
            comboBoxEquipeJury.Size = new Size(297, 31);
            comboBoxEquipeJury.TabIndex = 37;
            comboBoxEquipeJury.SelectedIndexChanged += comboBoxEquipeJury_SelectedIndexChanged;
            // 
            // labelMembresJury
            // 
            labelMembresJury.AutoSize = true;
            labelMembresJury.BackColor = Color.Transparent;
            labelMembresJury.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMembresJury.ForeColor = Color.White;
            labelMembresJury.Location = new Point(118, 172);
            labelMembresJury.Margin = new Padding(5, 0, 5, 0);
            labelMembresJury.Name = "labelMembresJury";
            labelMembresJury.Size = new Size(162, 22);
            labelMembresJury.TabIndex = 38;
            labelMembresJury.Text = "Membres du Jury";
            // 
            // labelEquipeJury
            // 
            labelEquipeJury.AutoSize = true;
            labelEquipeJury.BackColor = Color.Transparent;
            labelEquipeJury.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEquipeJury.ForeColor = Color.White;
            labelEquipeJury.Location = new Point(143, 72);
            labelEquipeJury.Margin = new Padding(5, 0, 5, 0);
            labelEquipeJury.Name = "labelEquipeJury";
            labelEquipeJury.Size = new Size(116, 22);
            labelEquipeJury.TabIndex = 39;
            labelEquipeJury.Text = "Equipe Jury";
            // 
            // FormAjoutJuryHackathon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé1;
            ClientSize = new Size(389, 471);
            Controls.Add(labelEquipeJury);
            Controls.Add(labelMembresJury);
            Controls.Add(comboBoxEquipeJury);
            Controls.Add(buttonFermer);
            Controls.Add(buttonAjouter);
            Controls.Add(textboxMembresJury);
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
        private TextBox textboxMembresJury;
        private Label labelTitle;
        private ComboBox comboBoxEquipeJury;
        private Label labelMembresJury;
        private Label labelEquipeJury;
        private BindingSource bindingSourceEquipeJury;
    }
}