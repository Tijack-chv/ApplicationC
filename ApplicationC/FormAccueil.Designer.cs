namespace ApplicationC
{
    partial class FormAccueil
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
            panelDecoArret = new Panel();
            buttonAnnuler = new Button();
            buttonExit = new Button();
            buttonDeconnexion = new Button();
            panelDecoArret.SuspendLayout();
            SuspendLayout();
            // 
            // panelDecoArret
            // 
            panelDecoArret.Controls.Add(buttonAnnuler);
            panelDecoArret.Controls.Add(buttonExit);
            panelDecoArret.Controls.Add(buttonDeconnexion);
            panelDecoArret.Location = new Point(227, 43);
            panelDecoArret.Name = "panelDecoArret";
            panelDecoArret.Size = new Size(200, 265);
            panelDecoArret.TabIndex = 0;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.BackColor = Color.FromArgb(35, 40, 45);
            buttonAnnuler.FlatStyle = FlatStyle.Popup;
            buttonAnnuler.Font = new Font("Stencil", 12F);
            buttonAnnuler.ForeColor = Color.White;
            buttonAnnuler.Location = new Point(27, 193);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(151, 31);
            buttonAnnuler.TabIndex = 3;
            buttonAnnuler.Text = "Annuler";
            buttonAnnuler.UseVisualStyleBackColor = false;
            buttonAnnuler.Click += buttonAnnuler_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(35, 40, 45);
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.Font = new Font("Stencil", 12F);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(27, 117);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(151, 31);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Quitter";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonDeconnexion
            // 
            buttonDeconnexion.BackColor = Color.FromArgb(35, 40, 45);
            buttonDeconnexion.FlatStyle = FlatStyle.Popup;
            buttonDeconnexion.Font = new Font("Stencil", 12F);
            buttonDeconnexion.ForeColor = Color.White;
            buttonDeconnexion.Location = new Point(27, 45);
            buttonDeconnexion.Name = "buttonDeconnexion";
            buttonDeconnexion.Size = new Size(151, 31);
            buttonDeconnexion.TabIndex = 1;
            buttonDeconnexion.Text = "Se déconnecter";
            buttonDeconnexion.UseVisualStyleBackColor = false;
            buttonDeconnexion.Click += buttonDeconnexion_Click;
            // 
            // FormAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(665, 347);
            Controls.Add(panelDecoArret);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAccueil";
            Text = "FormAccueil";
            panelDecoArret.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDecoArret;
        private Button buttonAnnuler;
        private Button buttonExit;
        private Button buttonDeconnexion;
    }
}