﻿namespace ApplicationC.View
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
            bindingSourceJury = new BindingSource(components);
            checkedListBoxJury = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)bindingSourceJury).BeginInit();
            SuspendLayout();
            // 
            // buttonFermer
            // 
            buttonFermer.BackColor = Color.Black;
            buttonFermer.FlatStyle = FlatStyle.Popup;
            buttonFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFermer.ForeColor = SystemColors.ControlLightLight;
            buttonFermer.Location = new Point(190, 292);
            buttonFermer.Margin = new Padding(4, 4, 4, 4);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Size = new Size(111, 43);
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
            buttonAjouter.Location = new Point(43, 292);
            buttonAjouter.Margin = new Padding(4, 4, 4, 4);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(111, 43);
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
            labelTitle.Location = new Point(33, 7);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(261, 24);
            labelTitle.TabIndex = 28;
            labelTitle.Text = "Choix Jury d'un Hackathon";
            // 
            // labelMembresJury
            // 
            labelMembresJury.AutoSize = true;
            labelMembresJury.BackColor = Color.Transparent;
            labelMembresJury.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMembresJury.ForeColor = Color.White;
            labelMembresJury.Location = new Point(100, 41);
            labelMembresJury.Margin = new Padding(4, 0, 4, 0);
            labelMembresJury.Name = "labelMembresJury";
            labelMembresJury.Size = new Size(138, 18);
            labelMembresJury.TabIndex = 38;
            labelMembresJury.Text = "Membres du Jury";
            // 
            // checkedListBoxJury
            // 
            checkedListBoxJury.FormattingEnabled = true;
            checkedListBoxJury.Location = new Point(32, 62);
            checkedListBoxJury.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxJury.Name = "checkedListBoxJury";
            checkedListBoxJury.Size = new Size(279, 148);
            checkedListBoxJury.TabIndex = 40;
            // 
            // FormAjoutJuryHackathon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé1;
            ClientSize = new Size(340, 353);
            Controls.Add(checkedListBoxJury);
            Controls.Add(labelMembresJury);
            Controls.Add(buttonFermer);
            Controls.Add(buttonAjouter);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAjoutJuryHackathon";
            Text = "Hackathon Jury";
            ((System.ComponentModel.ISupportInitialize)bindingSourceJury).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonFermer;
        private Button buttonAjouter;
        private Label labelTitle;
        private Label labelMembresJury;
        private BindingSource bindingSourceJury;
        private CheckedListBox checkedListBoxJury;
    }
}