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
            panelDecoArret.Location = new Point(1150, 642);
            panelDecoArret.Margin = new Padding(3, 4, 3, 4);
            panelDecoArret.Name = "panelDecoArret";
            panelDecoArret.Size = new Size(229, 353);
            panelDecoArret.TabIndex = 0;
            // 
            // buttonAnnuler
            // 
            buttonAnnuler.BackColor = Color.FromArgb(35, 40, 45);
            buttonAnnuler.FlatStyle = FlatStyle.Popup;
            buttonAnnuler.Font = new Font("Stencil", 12F);
            buttonAnnuler.ForeColor = Color.White;
            buttonAnnuler.Location = new Point(24, 257);
            buttonAnnuler.Margin = new Padding(3, 4, 3, 4);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(185, 41);
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
            buttonExit.Location = new Point(24, 157);
            buttonExit.Margin = new Padding(3, 4, 3, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(185, 41);
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
            buttonDeconnexion.Location = new Point(24, 60);
            buttonDeconnexion.Margin = new Padding(3, 4, 3, 4);
            buttonDeconnexion.Name = "buttonDeconnexion";
            buttonDeconnexion.Size = new Size(185, 41);
            buttonDeconnexion.TabIndex = 1;
            buttonDeconnexion.Text = "Se déconnecter";
            buttonDeconnexion.UseVisualStyleBackColor = false;
            buttonDeconnexion.Click += buttonDeconnexion_Click;
            // 
            // FormAccueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1158, 653);
            Controls.Add(panelDecoArret);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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