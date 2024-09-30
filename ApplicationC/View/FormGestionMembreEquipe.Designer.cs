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
            label1 = new Label();
            panelGestionEquipe = new Panel();
            label2 = new Label();
            panelGestionMembre.SuspendLayout();
            panelGestionEquipe.SuspendLayout();
            SuspendLayout();
            // 
            // panelGestionMembre
            // 
            panelGestionMembre.Controls.Add(label1);
            panelGestionMembre.Location = new Point(12, 12);
            panelGestionMembre.Name = "panelGestionMembre";
            panelGestionMembre.Size = new Size(641, 296);
            panelGestionMembre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 131);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Membre";
            // 
            // panelGestionEquipe
            // 
            panelGestionEquipe.Controls.Add(label2);
            panelGestionEquipe.Location = new Point(12, 369);
            panelGestionEquipe.Name = "panelGestionEquipe";
            panelGestionEquipe.Size = new Size(641, 296);
            panelGestionEquipe.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 141);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Equipe";
            // 
            // FormGestionMembreEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(665, 662);
            Controls.Add(panelGestionEquipe);
            Controls.Add(panelGestionMembre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionMembreEquipe";
            Text = "FormGestionMembreEquipe";
            panelGestionMembre.ResumeLayout(false);
            panelGestionMembre.PerformLayout();
            panelGestionEquipe.ResumeLayout(false);
            panelGestionEquipe.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGestionMembre;
        private Panel panelGestionEquipe;
        private Label label1;
        private Label label2;
    }
}