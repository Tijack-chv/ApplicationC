namespace ApplicationC.View
{
    partial class FormGestionMembreEquipe
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
            panelGestionMembre = new Panel();
            groupBoxMembre = new GroupBox();
            BtnFermer = new Button();
            BtnAction = new Button();
            label4 = new Label();
            tbThematique = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            labelAjoutModifMembreEquipe = new Label();
            panelGestionEquipe = new Panel();
            label2 = new Label();
            panelGestionMembre.SuspendLayout();
            groupBoxMembre.SuspendLayout();
            panelGestionEquipe.SuspendLayout();
            SuspendLayout();
            // 
            // panelGestionMembre
            // 
            panelGestionMembre.Controls.Add(groupBoxMembre);
            panelGestionMembre.Controls.Add(labelAjoutModifMembreEquipe);
            panelGestionMembre.Location = new Point(14, 16);
            panelGestionMembre.Margin = new Padding(3, 4, 3, 4);
            panelGestionMembre.Name = "panelGestionMembre";
            panelGestionMembre.Size = new Size(1132, 592);
            panelGestionMembre.TabIndex = 0;
            // 
            // groupBoxMembre
            // 
            groupBoxMembre.BackColor = Color.Transparent;
            groupBoxMembre.Controls.Add(BtnFermer);
            groupBoxMembre.Controls.Add(BtnAction);
            groupBoxMembre.Controls.Add(label4);
            groupBoxMembre.Controls.Add(tbThematique);
            groupBoxMembre.Controls.Add(textBox1);
            groupBoxMembre.Controls.Add(label1);
            groupBoxMembre.Location = new Point(21, 49);
            groupBoxMembre.Name = "groupBoxMembre";
            groupBoxMembre.Size = new Size(1085, 526);
            groupBoxMembre.TabIndex = 5;
            groupBoxMembre.TabStop = false;
            groupBoxMembre.Text = "Gestion du Membre";
            // 
            // BtnFermer
            // 
            BtnFermer.BackColor = Color.Black;
            BtnFermer.FlatStyle = FlatStyle.Popup;
            BtnFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFermer.ForeColor = SystemColors.ControlLightLight;
            BtnFermer.Location = new Point(246, 461);
            BtnFermer.Margin = new Padding(5);
            BtnFermer.Name = "BtnFermer";
            BtnFermer.Size = new Size(133, 57);
            BtnFermer.TabIndex = 25;
            BtnFermer.Text = "FERMER";
            BtnFermer.UseVisualStyleBackColor = false;
            // 
            // BtnAction
            // 
            BtnAction.BackColor = Color.Black;
            BtnAction.FlatStyle = FlatStyle.Popup;
            BtnAction.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAction.ForeColor = SystemColors.ControlLightLight;
            BtnAction.Location = new Point(43, 461);
            BtnAction.Margin = new Padding(5);
            BtnAction.Name = "BtnAction";
            BtnAction.Size = new Size(143, 57);
            BtnAction.TabIndex = 26;
            BtnAction.Text = "AJOUTER";
            BtnAction.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label4.Location = new Point(8, 62);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 20);
            label4.TabIndex = 16;
            label4.Text = "Thématique";
            // 
            // tbThematique
            // 
            tbThematique.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbThematique.Location = new Point(8, 92);
            tbThematique.Margin = new Padding(5);
            tbThematique.Name = "tbThematique";
            tbThematique.Size = new Size(311, 26);
            tbThematique.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(447, 482);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(538, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(710, 416);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Membre";
            label1.Click += label1_Click;
            // 
            // labelAjoutModifMembreEquipe
            // 
            labelAjoutModifMembreEquipe.AutoSize = true;
            labelAjoutModifMembreEquipe.BackColor = Color.Transparent;
            labelAjoutModifMembreEquipe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAjoutModifMembreEquipe.ForeColor = SystemColors.ActiveCaptionText;
            labelAjoutModifMembreEquipe.Location = new Point(21, 17);
            labelAjoutModifMembreEquipe.Margin = new Padding(5, 0, 5, 0);
            labelAjoutModifMembreEquipe.Name = "labelAjoutModifMembreEquipe";
            labelAjoutModifMembreEquipe.Size = new Size(380, 29);
            labelAjoutModifMembreEquipe.TabIndex = 4;
            labelAjoutModifMembreEquipe.Text = "Ajout/Modification d'un Membre";
            // 
            // panelGestionEquipe
            // 
            panelGestionEquipe.Controls.Add(label2);
            panelGestionEquipe.Location = new Point(12, 656);
            panelGestionEquipe.Margin = new Padding(3, 4, 3, 4);
            panelGestionEquipe.Name = "panelGestionEquipe";
            panelGestionEquipe.Size = new Size(1134, 592);
            panelGestionEquipe.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 188);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Equipe";
            // 
            // FormGestionMembreEquipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1158, 621);
            Controls.Add(panelGestionEquipe);
            Controls.Add(panelGestionMembre);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionMembreEquipe";
            Text = "FormGestionMembreEquipe";
            panelGestionMembre.ResumeLayout(false);
            panelGestionMembre.PerformLayout();
            groupBoxMembre.ResumeLayout(false);
            groupBoxMembre.PerformLayout();
            panelGestionEquipe.ResumeLayout(false);
            panelGestionEquipe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGestionMembre;
        private Panel panelGestionEquipe;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label labelAjoutModifMembreEquipe;
        private GroupBox groupBoxMembre;
        private Label label4;
        private TextBox tbThematique;
        private Button BtnFermer;
        private Button BtnAction;
    }
}