namespace ApplicationC
{
    partial class FormParamètre
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
            menuStrip1 = new MenuStrip();
            compteToolStripMenuItem = new ToolStripMenuItem();
            informationsPersonnelsToolStripMenuItem = new ToolStripMenuItem();
            motDePasseToolStripMenuItem = new ToolStripMenuItem();
            panelMdp = new Panel();
            labelShow = new Label();
            progressBarMdp = new ProgressBar();
            label2NvMdp = new Label();
            labelNvMdp = new Label();
            labelAncienMdp = new Label();
            textBox2NvMdp = new TextBox();
            textBoxNvMdp = new TextBox();
            textBoxAncienMdp = new TextBox();
            buttonValiderMdp = new Button();
            buttonAnnulerMdp = new Button();
            panelInfoPers = new Panel();
            labelFirstName = new Label();
            labelName = new Label();
            labelEmail = new Label();
            textBoxFirstName = new TextBox();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            menuStrip1.SuspendLayout();
            panelMdp.SuspendLayout();
            panelInfoPers.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(50, 55, 60);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { compteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(760, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // compteToolStripMenuItem
            // 
            compteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informationsPersonnelsToolStripMenuItem, motDePasseToolStripMenuItem });
            compteToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            compteToolStripMenuItem.ForeColor = Color.White;
            compteToolStripMenuItem.Image = Properties.Resources._1486395884_account_80606;
            compteToolStripMenuItem.ImageTransparentColor = Color.Black;
            compteToolStripMenuItem.Name = "compteToolStripMenuItem";
            compteToolStripMenuItem.Size = new Size(105, 26);
            compteToolStripMenuItem.Text = "Compte";
            // 
            // informationsPersonnelsToolStripMenuItem
            // 
            informationsPersonnelsToolStripMenuItem.BackColor = Color.FromArgb(50, 55, 60);
            informationsPersonnelsToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            informationsPersonnelsToolStripMenuItem.ForeColor = Color.White;
            informationsPersonnelsToolStripMenuItem.Image = Properties.Resources.personal_computer_monitor_desktop_pc_icon_179104;
            informationsPersonnelsToolStripMenuItem.Name = "informationsPersonnelsToolStripMenuItem";
            informationsPersonnelsToolStripMenuItem.Size = new Size(287, 26);
            informationsPersonnelsToolStripMenuItem.Text = "Informations personnels";
            informationsPersonnelsToolStripMenuItem.Click += informationsPersonnelsToolStripMenuItem_Click;
            // 
            // motDePasseToolStripMenuItem
            // 
            motDePasseToolStripMenuItem.BackColor = Color.FromArgb(50, 55, 60);
            motDePasseToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            motDePasseToolStripMenuItem.ForeColor = Color.White;
            motDePasseToolStripMenuItem.Image = Properties.Resources.password_1325;
            motDePasseToolStripMenuItem.Name = "motDePasseToolStripMenuItem";
            motDePasseToolStripMenuItem.Size = new Size(287, 26);
            motDePasseToolStripMenuItem.Text = "Mot de passe";
            motDePasseToolStripMenuItem.Click += motDePasseToolStripMenuItem_Click;
            // 
            // panelMdp
            // 
            panelMdp.BackColor = Color.White;
            panelMdp.Controls.Add(labelShow);
            panelMdp.Controls.Add(progressBarMdp);
            panelMdp.Controls.Add(label2NvMdp);
            panelMdp.Controls.Add(labelNvMdp);
            panelMdp.Controls.Add(labelAncienMdp);
            panelMdp.Controls.Add(textBox2NvMdp);
            panelMdp.Controls.Add(textBoxNvMdp);
            panelMdp.Controls.Add(textBoxAncienMdp);
            panelMdp.Controls.Add(buttonValiderMdp);
            panelMdp.Controls.Add(buttonAnnulerMdp);
            panelMdp.Location = new Point(197, 69);
            panelMdp.Margin = new Padding(3, 4, 3, 4);
            panelMdp.Name = "panelMdp";
            panelMdp.Size = new Size(266, 355);
            panelMdp.TabIndex = 1;
            // 
            // labelShow
            // 
            labelShow.AutoSize = true;
            labelShow.BackColor = Color.Transparent;
            labelShow.ForeColor = Color.Black;
            labelShow.Location = new Point(112, 284);
            labelShow.Name = "labelShow";
            labelShow.Size = new Size(45, 20);
            labelShow.TabIndex = 6;
            labelShow.Text = "Show";
            labelShow.Click += labelShow_Click;
            // 
            // progressBarMdp
            // 
            progressBarMdp.ForeColor = Color.Red;
            progressBarMdp.Location = new Point(25, 181);
            progressBarMdp.Margin = new Padding(3, 4, 3, 4);
            progressBarMdp.Maximum = 10;
            progressBarMdp.Minimum = 1;
            progressBarMdp.Name = "progressBarMdp";
            progressBarMdp.Size = new Size(218, 13);
            progressBarMdp.Step = 1;
            progressBarMdp.Style = ProgressBarStyle.Continuous;
            progressBarMdp.TabIndex = 11;
            progressBarMdp.Value = 1;
            // 
            // label2NvMdp
            // 
            label2NvMdp.AutoSize = true;
            label2NvMdp.BackColor = Color.Transparent;
            label2NvMdp.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2NvMdp.ForeColor = Color.Black;
            label2NvMdp.Location = new Point(3, 211);
            label2NvMdp.Name = "label2NvMdp";
            label2NvMdp.Size = new Size(284, 28);
            label2NvMdp.TabIndex = 10;
            label2NvMdp.Text = "Confirmez le mot de passe :";
            // 
            // labelNvMdp
            // 
            labelNvMdp.AutoSize = true;
            labelNvMdp.BackColor = Color.Transparent;
            labelNvMdp.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNvMdp.ForeColor = Color.Black;
            labelNvMdp.Location = new Point(24, 109);
            labelNvMdp.Name = "labelNvMdp";
            labelNvMdp.Size = new Size(246, 28);
            labelNvMdp.TabIndex = 9;
            labelNvMdp.Text = "Nouveau mot de passe :";
            // 
            // labelAncienMdp
            // 
            labelAncienMdp.AutoSize = true;
            labelAncienMdp.BackColor = Color.Transparent;
            labelAncienMdp.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAncienMdp.ForeColor = Color.Black;
            labelAncienMdp.Location = new Point(30, 35);
            labelAncienMdp.Name = "labelAncienMdp";
            labelAncienMdp.Size = new Size(228, 28);
            labelAncienMdp.TabIndex = 3;
            labelAncienMdp.Text = "Ancien mot de passe :";
            // 
            // textBox2NvMdp
            // 
            textBox2NvMdp.BackColor = Color.FromArgb(35, 40, 45);
            textBox2NvMdp.BorderStyle = BorderStyle.None;
            textBox2NvMdp.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2NvMdp.ForeColor = Color.White;
            textBox2NvMdp.Location = new Point(15, 244);
            textBox2NvMdp.Name = "textBox2NvMdp";
            textBox2NvMdp.PasswordChar = '*';
            textBox2NvMdp.Size = new Size(239, 32);
            textBox2NvMdp.TabIndex = 8;
            textBox2NvMdp.Text = "mot de passe";
            textBox2NvMdp.TextAlign = HorizontalAlignment.Center;
            textBox2NvMdp.Enter += textBox2NvMdp_Enter;
            textBox2NvMdp.Leave += textBox2NvMdp_Leave;
            // 
            // textBoxNvMdp
            // 
            textBoxNvMdp.BackColor = Color.FromArgb(35, 40, 45);
            textBoxNvMdp.BorderStyle = BorderStyle.None;
            textBoxNvMdp.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxNvMdp.ForeColor = Color.White;
            textBoxNvMdp.Location = new Point(16, 141);
            textBoxNvMdp.Name = "textBoxNvMdp";
            textBoxNvMdp.PasswordChar = '*';
            textBoxNvMdp.Size = new Size(239, 32);
            textBoxNvMdp.TabIndex = 7;
            textBoxNvMdp.Text = "mot de passe";
            textBoxNvMdp.TextAlign = HorizontalAlignment.Center;
            textBoxNvMdp.TextChanged += textBoxNvMdp_TextChanged;
            textBoxNvMdp.Enter += textBoxNvMdp_Enter;
            textBoxNvMdp.Leave += textBoxNvMdp_Leave;
            // 
            // textBoxAncienMdp
            // 
            textBoxAncienMdp.BackColor = Color.FromArgb(35, 40, 45);
            textBoxAncienMdp.BorderStyle = BorderStyle.None;
            textBoxAncienMdp.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxAncienMdp.ForeColor = Color.White;
            textBoxAncienMdp.Location = new Point(15, 68);
            textBoxAncienMdp.Name = "textBoxAncienMdp";
            textBoxAncienMdp.PasswordChar = '*';
            textBoxAncienMdp.Size = new Size(239, 32);
            textBoxAncienMdp.TabIndex = 6;
            textBoxAncienMdp.Text = "mot de passe";
            textBoxAncienMdp.TextAlign = HorizontalAlignment.Center;
            textBoxAncienMdp.Enter += textBoxAncienMdp_Enter;
            textBoxAncienMdp.Leave += textBoxAncienMdp_Leave;
            // 
            // buttonValiderMdp
            // 
            buttonValiderMdp.BackColor = Color.FromArgb(35, 40, 45);
            buttonValiderMdp.FlatStyle = FlatStyle.Popup;
            buttonValiderMdp.Font = new Font("Stencil", 12F);
            buttonValiderMdp.ForeColor = Color.White;
            buttonValiderMdp.Location = new Point(24, 309);
            buttonValiderMdp.Margin = new Padding(3, 4, 3, 4);
            buttonValiderMdp.Name = "buttonValiderMdp";
            buttonValiderMdp.Size = new Size(105, 41);
            buttonValiderMdp.TabIndex = 5;
            buttonValiderMdp.Text = "Valider";
            buttonValiderMdp.UseVisualStyleBackColor = false;
            buttonValiderMdp.Click += buttonValiderMdp_Click;
            // 
            // buttonAnnulerMdp
            // 
            buttonAnnulerMdp.BackColor = Color.FromArgb(35, 40, 45);
            buttonAnnulerMdp.FlatStyle = FlatStyle.Popup;
            buttonAnnulerMdp.Font = new Font("Stencil", 12F);
            buttonAnnulerMdp.ForeColor = Color.White;
            buttonAnnulerMdp.Location = new Point(137, 309);
            buttonAnnulerMdp.Margin = new Padding(3, 4, 3, 4);
            buttonAnnulerMdp.Name = "buttonAnnulerMdp";
            buttonAnnulerMdp.Size = new Size(105, 41);
            buttonAnnulerMdp.TabIndex = 4;
            buttonAnnulerMdp.Text = "Annuler";
            buttonAnnulerMdp.UseVisualStyleBackColor = false;
            buttonAnnulerMdp.Click += buttonAnnulerMdp_Click;
            // 
            // panelInfoPers
            // 
            panelInfoPers.BackColor = Color.White;
            panelInfoPers.Controls.Add(labelFirstName);
            panelInfoPers.Controls.Add(labelName);
            panelInfoPers.Controls.Add(labelEmail);
            panelInfoPers.Controls.Add(textBoxFirstName);
            panelInfoPers.Controls.Add(textBoxName);
            panelInfoPers.Controls.Add(textBoxEmail);
            panelInfoPers.Location = new Point(480, 69);
            panelInfoPers.Margin = new Padding(3, 4, 3, 4);
            panelInfoPers.Name = "panelInfoPers";
            panelInfoPers.Size = new Size(266, 355);
            panelInfoPers.TabIndex = 2;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.BackColor = Color.Transparent;
            labelFirstName.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelFirstName.ForeColor = Color.Black;
            labelFirstName.Location = new Point(77, 249);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(104, 28);
            labelFirstName.TabIndex = 17;
            labelFirstName.Text = "Prénom :";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Transparent;
            labelName.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelName.ForeColor = Color.Black;
            labelName.Location = new Point(93, 145);
            labelName.Name = "labelName";
            labelName.Size = new Size(73, 28);
            labelName.TabIndex = 16;
            labelName.Text = "Nom :";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.Black;
            labelEmail.Location = new Point(63, 35);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(153, 28);
            labelEmail.TabIndex = 12;
            labelEmail.Text = "Adresse mail :";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.BackColor = Color.FromArgb(35, 40, 45);
            textBoxFirstName.BorderStyle = BorderStyle.None;
            textBoxFirstName.Enabled = false;
            textBoxFirstName.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxFirstName.ForeColor = Color.White;
            textBoxFirstName.Location = new Point(10, 283);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(239, 32);
            textBoxFirstName.TabIndex = 15;
            textBoxFirstName.Text = "Prénom admin";
            textBoxFirstName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.FromArgb(35, 40, 45);
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Enabled = false;
            textBoxName.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxName.ForeColor = Color.White;
            textBoxName.Location = new Point(10, 177);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(239, 32);
            textBoxName.TabIndex = 14;
            textBoxName.Text = "Nom admin";
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(35, 40, 45);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Enabled = false;
            textBoxEmail.Font = new Font("Times New Roman", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.Location = new Point(8, 68);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(239, 32);
            textBoxEmail.TabIndex = 13;
            textBoxEmail.Text = "email";
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // FormParamètre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(760, 463);
            Controls.Add(panelInfoPers);
            Controls.Add(panelMdp);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormParamètre";
            Text = "FormParamètre";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelMdp.ResumeLayout(false);
            panelMdp.PerformLayout();
            panelInfoPers.ResumeLayout(false);
            panelInfoPers.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem compteToolStripMenuItem;
        private ToolStripMenuItem informationsPersonnelsToolStripMenuItem;
        private ToolStripMenuItem motDePasseToolStripMenuItem;
        private Panel panelMdp;
        private Panel panelInfoPers;
        private Button buttonValiderMdp;
        private Button buttonAnnulerMdp;
        private TextBox textBox2NvMdp;
        private TextBox textBoxNvMdp;
        private TextBox textBoxAncienMdp;
        private Label label2NvMdp;
        private Label labelNvMdp;
        private Label labelAncienMdp;
        private ProgressBar progressBarMdp;
        private Label labelShow;
        private Label labelFirstName;
        private Label labelName;
        private Label labelEmail;
        private TextBox textBoxFirstName;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
    }
}