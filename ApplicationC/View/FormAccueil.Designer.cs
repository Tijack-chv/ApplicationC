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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelDecoArret = new Panel();
            buttonAnnuler = new Button();
            buttonExit = new Button();
            buttonDeconnexion = new Button();
            checkedListBoxDemande = new CheckedListBox();
            buttonToutVerif = new Button();
            panel2 = new Panel();
            labelNbEquipeMoyenParHack = new Label();
            label1 = new Label();
            panel3 = new Panel();
            labelNbMembreMoyenParEquipe = new Label();
            label2 = new Label();
            panel5 = new Panel();
            labelNbHackathons = new Label();
            label4 = new Label();
            panel4 = new Panel();
            labelNbMoyenDesinscriptions = new Label();
            label3 = new Label();
            panelCheckBoxList = new Panel();
            dataGridViewHackRecent = new DataGridView();
            panelDecoArret.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panelCheckBoxList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHackRecent).BeginInit();
            SuspendLayout();
            // 
            // panelDecoArret
            // 
            panelDecoArret.Controls.Add(buttonAnnuler);
            panelDecoArret.Controls.Add(buttonExit);
            panelDecoArret.Controls.Add(buttonDeconnexion);
            panelDecoArret.Location = new Point(1014, 491);
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
            checkedListBoxDemande.Font = new Font("Constantia", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkedListBoxDemande.ForeColor = Color.White;
            checkedListBoxDemande.FormattingEnabled = true;
            checkedListBoxDemande.Location = new Point(0, 0);
            checkedListBoxDemande.Margin = new Padding(3, 2, 3, 2);
            checkedListBoxDemande.Name = "checkedListBoxDemande";
            checkedListBoxDemande.Size = new Size(222, 418);
            checkedListBoxDemande.TabIndex = 41;
            checkedListBoxDemande.ItemCheck += checkedListBoxDemande_ItemCheck;
            // 
            // buttonToutVerif
            // 
            buttonToutVerif.BackColor = Color.White;
            buttonToutVerif.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonToutVerif.Location = new Point(15, 430);
            buttonToutVerif.Name = "buttonToutVerif";
            buttonToutVerif.Size = new Size(195, 23);
            buttonToutVerif.TabIndex = 100;
            buttonToutVerif.Text = "Tout vérifier";
            buttonToutVerif.UseVisualStyleBackColor = false;
            buttonToutVerif.Click += buttonToutVerif_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.CornflowerBlue;
            panel2.Controls.Add(labelNbEquipeMoyenParHack);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(12, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 169);
            panel2.TabIndex = 44;
            panel2.Visible = false;
            // 
            // labelNbEquipeMoyenParHack
            // 
            labelNbEquipeMoyenParHack.AutoSize = true;
            labelNbEquipeMoyenParHack.BackColor = Color.Transparent;
            labelNbEquipeMoyenParHack.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNbEquipeMoyenParHack.ForeColor = Color.White;
            labelNbEquipeMoyenParHack.Location = new Point(12, 97);
            labelNbEquipeMoyenParHack.Name = "labelNbEquipeMoyenParHack";
            labelNbEquipeMoyenParHack.Size = new Size(69, 23);
            labelNbEquipeMoyenParHack.TabIndex = 1;
            labelNbEquipeMoyenParHack.Text = "value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(217, 36);
            label1.TabIndex = 0;
            label1.Text = "Nombre D'équipes Moyen\r\nPar Hackathon\r\n";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkMagenta;
            panel3.Controls.Add(labelNbMembreMoyenParEquipe);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(256, 21);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 169);
            panel3.TabIndex = 45;
            panel3.Visible = false;
            // 
            // labelNbMembreMoyenParEquipe
            // 
            labelNbMembreMoyenParEquipe.AutoSize = true;
            labelNbMembreMoyenParEquipe.BackColor = Color.Transparent;
            labelNbMembreMoyenParEquipe.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            labelNbMembreMoyenParEquipe.ForeColor = Color.White;
            labelNbMembreMoyenParEquipe.Location = new Point(12, 97);
            labelNbMembreMoyenParEquipe.Name = "labelNbMembreMoyenParEquipe";
            labelNbMembreMoyenParEquipe.Size = new Size(69, 23);
            labelNbMembreMoyenParEquipe.TabIndex = 2;
            labelNbMembreMoyenParEquipe.Text = "value";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(234, 36);
            label2.TabIndex = 1;
            label2.Text = "Nombre Moyen de Membre \r\npar Equipe";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkOrange;
            panel5.Controls.Add(labelNbHackathons);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(770, 21);
            panel5.Name = "panel5";
            panel5.Size = new Size(230, 169);
            panel5.TabIndex = 47;
            panel5.Visible = false;
            // 
            // labelNbHackathons
            // 
            labelNbHackathons.AutoSize = true;
            labelNbHackathons.BackColor = Color.Transparent;
            labelNbHackathons.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            labelNbHackathons.ForeColor = Color.White;
            labelNbHackathons.Location = new Point(11, 97);
            labelNbHackathons.Name = "labelNbHackathons";
            labelNbHackathons.Size = new Size(69, 23);
            labelNbHackathons.TabIndex = 2;
            labelNbHackathons.Text = "value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 4);
            label4.Name = "label4";
            label4.Size = new Size(189, 18);
            label4.TabIndex = 1;
            label4.Text = "Nombre d'Hackathons";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SeaGreen;
            panel4.Controls.Add(labelNbMoyenDesinscriptions);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(513, 21);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 169);
            panel4.TabIndex = 49;
            panel4.Visible = false;
            // 
            // labelNbMoyenDesinscriptions
            // 
            labelNbMoyenDesinscriptions.AutoSize = true;
            labelNbMoyenDesinscriptions.BackColor = Color.Transparent;
            labelNbMoyenDesinscriptions.Font = new Font("Verdana", 14.25F, FontStyle.Bold);
            labelNbMoyenDesinscriptions.ForeColor = Color.White;
            labelNbMoyenDesinscriptions.Location = new Point(12, 97);
            labelNbMoyenDesinscriptions.Name = "labelNbMoyenDesinscriptions";
            labelNbMoyenDesinscriptions.Size = new Size(69, 23);
            labelNbMoyenDesinscriptions.TabIndex = 2;
            labelNbMoyenDesinscriptions.Text = "value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(220, 18);
            label3.TabIndex = 1;
            label3.Text = "Nombre de désinscription ";
            // 
            // panelCheckBoxList
            // 
            panelCheckBoxList.BackColor = Color.FromArgb(45, 50, 55);
            panelCheckBoxList.Controls.Add(checkedListBoxDemande);
            panelCheckBoxList.Controls.Add(buttonToutVerif);
            panelCheckBoxList.Location = new Point(789, 501);
            panelCheckBoxList.Name = "panelCheckBoxList";
            panelCheckBoxList.Size = new Size(222, 462);
            panelCheckBoxList.TabIndex = 50;
            panelCheckBoxList.Visible = false;
            // 
            // dataGridViewHackRecent
            // 
            dataGridViewHackRecent.AllowUserToAddRows = false;
            dataGridViewHackRecent.AllowUserToDeleteRows = false;
            dataGridViewHackRecent.AllowUserToOrderColumns = true;
            dataGridViewHackRecent.AllowUserToResizeRows = false;
            dataGridViewHackRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewHackRecent.BackgroundColor = Color.DarkBlue;
            dataGridViewHackRecent.BorderStyle = BorderStyle.None;
            dataGridViewHackRecent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHackRecent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHackRecent.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DarkBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewHackRecent.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHackRecent.EnableHeadersVisualStyles = false;
            dataGridViewHackRecent.GridColor = Color.Black;
            dataGridViewHackRecent.Location = new Point(12, 198);
            dataGridViewHackRecent.MultiSelect = false;
            dataGridViewHackRecent.Name = "dataGridViewHackRecent";
            dataGridViewHackRecent.ReadOnly = true;
            dataGridViewHackRecent.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewHackRecent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHackRecent.RowHeadersVisible = false;
            dataGridViewHackRecent.RowHeadersWidth = 55;
            dataGridViewHackRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHackRecent.Size = new Size(230, 276);
            dataGridViewHackRecent.TabIndex = 51;
            dataGridViewHackRecent.Visible = false;
            // 
            // FormAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1012, 486);
            Controls.Add(dataGridViewHackRecent);
            Controls.Add(panelCheckBoxList);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelDecoArret);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAccueil";
            Text = "FormAccueil";
            panelDecoArret.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panelCheckBoxList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewHackRecent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDecoArret;
        private Button buttonAnnuler;
        private Button buttonExit;
        private Button buttonDeconnexion;
        private CheckedListBox checkedListBoxDemande;
        private Button buttonToutVerif;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label labelNbEquipeMoyenParHack;
        private Label labelNbMembreMoyenParEquipe;
        private Label labelNbHackathons;
        private Label labelNbMoyenDesinscriptions;
        private Panel panelCheckBoxList;
        private DataGridView dataGridViewHackRecent;
    }
}