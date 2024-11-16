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
            checkedListBoxDemande = new CheckedListBox();
            buttonToutVerif = new Button();
            panelDecoArret.SuspendLayout();
            SuspendLayout();
            // 
            // panelDecoArret
            // 
            panelDecoArret.Controls.Add(buttonAnnuler);
            panelDecoArret.Controls.Add(buttonExit);
            panelDecoArret.Controls.Add(buttonDeconnexion);
            panelDecoArret.Location = new Point(1006, 482);
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
            buttonAnnuler.Location = new Point(21, 193);
            buttonAnnuler.Name = "buttonAnnuler";
            buttonAnnuler.Size = new Size(162, 31);
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
            buttonExit.Location = new Point(21, 118);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(162, 31);
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
            buttonDeconnexion.Location = new Point(21, 45);
            buttonDeconnexion.Name = "buttonDeconnexion";
            buttonDeconnexion.Size = new Size(162, 31);
            buttonDeconnexion.TabIndex = 1;
            buttonDeconnexion.Text = "Se déconnecter";
            buttonDeconnexion.UseVisualStyleBackColor = false;
            buttonDeconnexion.Click += buttonDeconnexion_Click;
            // 
            // checkedListBoxDemande
            // 
            checkedListBoxDemande.BackColor = Color.FromArgb(45, 50, 55);
            checkedListBoxDemande.BorderStyle = BorderStyle.None;
            checkedListBoxDemande.Dock = DockStyle.Right;
            checkedListBoxDemande.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBoxDemande.ForeColor = Color.White;
            checkedListBoxDemande.FormattingEnabled = true;
            checkedListBoxDemande.Location = new Point(790, 0);
            checkedListBoxDemande.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxDemande.Name = "checkedListBoxDemande";
            checkedListBoxDemande.Size = new Size(222, 486);
            checkedListBoxDemande.TabIndex = 41;
            checkedListBoxDemande.Visible = false;
            checkedListBoxDemande.ItemCheck += checkedListBoxDemande_ItemCheck;
            // 
            // buttonToutVerif
            // 
            buttonToutVerif.BackColor = Color.White;
            buttonToutVerif.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonToutVerif.Location = new Point(805, 451);
            buttonToutVerif.Name = "buttonToutVerif";
            buttonToutVerif.Size = new Size(195, 23);
            buttonToutVerif.TabIndex = 42;
            buttonToutVerif.Text = "Tout vérifier";
            buttonToutVerif.UseVisualStyleBackColor = false;
            buttonToutVerif.Visible = false;
            buttonToutVerif.Click += buttonToutVerif_Click;
            // 
            // FormAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1012, 486);
            Controls.Add(buttonToutVerif);
            Controls.Add(checkedListBoxDemande);
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
        private CheckedListBox checkedListBoxDemande;
        private Button buttonToutVerif;
    }
}