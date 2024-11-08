namespace ApplicationC.View
{
    partial class FormJury
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel2 = new Panel();
            label1 = new Label();
            textBoxPage = new TextBox();
            panel1 = new Panel();
            buttonSuiv = new Button();
            buttonPrec = new Button();
            dataGridViewHackathons = new DataGridView();
            labelInfo = new Label();
            labelListe = new Label();
            dataGridViewJury = new DataGridView();
            contextMenuStripJury = new ContextMenuStrip(components);
            visualiserLesHackathonsToolStripMenuItem = new ToolStripMenuItem();
            bindingSourceJury = new BindingSource(components);
            bindingSourceHackathons = new BindingSource(components);
            buttonCreateJury = new Button();
            buttonUpdateJury = new Button();
            panelGestionJury = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHackathons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJury).BeginInit();
            contextMenuStripJury.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceJury).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceHackathons).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 35, 40);
            panel2.Location = new Point(12, 553);
            panel2.Name = "panel2";
            panel2.Size = new Size(175, 29);
            panel2.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 601);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 17);
            label1.TabIndex = 55;
            // 
            // textBoxPage
            // 
            textBoxPage.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPage.Location = new Point(313, 553);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(70, 30);
            textBoxPage.TabIndex = 54;
            textBoxPage.Text = "1";
            textBoxPage.TextAlign = HorizontalAlignment.Center;
            textBoxPage.TextChanged += textBoxPage_TextChanged;
            textBoxPage.KeyPress += textBoxPage_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(504, 553);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 29);
            panel1.TabIndex = 53;
            // 
            // buttonSuiv
            // 
            buttonSuiv.BackColor = Color.FromArgb(35, 40, 45);
            buttonSuiv.FlatStyle = FlatStyle.Popup;
            buttonSuiv.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSuiv.ForeColor = Color.White;
            buttonSuiv.Location = new Point(382, 553);
            buttonSuiv.Name = "buttonSuiv";
            buttonSuiv.Size = new Size(126, 29);
            buttonSuiv.TabIndex = 52;
            buttonSuiv.Text = "Suivant";
            buttonSuiv.UseVisualStyleBackColor = false;
            buttonSuiv.Click += buttonSuiv_Click;
            // 
            // buttonPrec
            // 
            buttonPrec.BackColor = Color.FromArgb(35, 40, 45);
            buttonPrec.FlatStyle = FlatStyle.Popup;
            buttonPrec.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPrec.ForeColor = Color.White;
            buttonPrec.Location = new Point(187, 553);
            buttonPrec.Name = "buttonPrec";
            buttonPrec.Size = new Size(126, 29);
            buttonPrec.TabIndex = 51;
            buttonPrec.Text = "Précédent";
            buttonPrec.UseVisualStyleBackColor = false;
            buttonPrec.Click += buttonPrec_Click;
            // 
            // dataGridViewHackathons
            // 
            dataGridViewHackathons.AllowUserToAddRows = false;
            dataGridViewHackathons.AllowUserToDeleteRows = false;
            dataGridViewHackathons.AllowUserToOrderColumns = true;
            dataGridViewHackathons.AllowUserToResizeRows = false;
            dataGridViewHackathons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewHackathons.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewHackathons.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewHackathons.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle6.Font = new Font("Rockwell", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewHackathons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewHackathons.ColumnHeadersHeight = 30;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(80, 85, 90);
            dataGridViewCellStyle7.Font = new Font("Rockwell", 11.25F);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewHackathons.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewHackathons.EnableHeadersVisualStyles = false;
            dataGridViewHackathons.GridColor = Color.Black;
            dataGridViewHackathons.Location = new Point(121, 47);
            dataGridViewHackathons.Margin = new Padding(6, 7, 6, 7);
            dataGridViewHackathons.MultiSelect = false;
            dataGridViewHackathons.Name = "dataGridViewHackathons";
            dataGridViewHackathons.ReadOnly = true;
            dataGridViewHackathons.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewHackathons.RowHeadersVisible = false;
            dataGridViewHackathons.RowHeadersWidth = 51;
            dataGridViewHackathons.Size = new Size(429, 507);
            dataGridViewHackathons.TabIndex = 50;
            dataGridViewHackathons.Visible = false;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.ForeColor = SystemColors.ActiveCaptionText;
            labelInfo.Location = new Point(12, 618);
            labelInfo.Margin = new Padding(5, 0, 5, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(784, 17);
            labelInfo.TabIndex = 49;
            labelInfo.Text = "click droit sur le Jury sélectionné pour voir les hackathons dont il participe";
            // 
            // labelListe
            // 
            labelListe.AutoSize = true;
            labelListe.BackColor = Color.Transparent;
            labelListe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListe.Location = new Point(19, 11);
            labelListe.Margin = new Padding(5, 0, 5, 0);
            labelListe.Name = "labelListe";
            labelListe.Size = new Size(174, 29);
            labelListe.TabIndex = 48;
            labelListe.Text = "Liste des Jury";
            // 
            // dataGridViewJury
            // 
            dataGridViewJury.AllowUserToAddRows = false;
            dataGridViewJury.AllowUserToDeleteRows = false;
            dataGridViewJury.AllowUserToOrderColumns = true;
            dataGridViewJury.AllowUserToResizeRows = false;
            dataGridViewJury.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewJury.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewJury.BorderStyle = BorderStyle.None;
            dataGridViewJury.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle8.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewJury.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewJury.ColumnHeadersHeight = 30;
            dataGridViewJury.ContextMenuStrip = contextMenuStripJury;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(80, 85, 90);
            dataGridViewCellStyle9.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewJury.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewJury.EnableHeadersVisualStyles = false;
            dataGridViewJury.GridColor = Color.Black;
            dataGridViewJury.Location = new Point(12, 47);
            dataGridViewJury.Margin = new Padding(6, 7, 6, 7);
            dataGridViewJury.MultiSelect = false;
            dataGridViewJury.Name = "dataGridViewJury";
            dataGridViewJury.ReadOnly = true;
            dataGridViewJury.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(80, 85, 90);
            dataGridViewCellStyle10.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridViewJury.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewJury.RowHeadersVisible = false;
            dataGridViewJury.RowHeadersWidth = 55;
            dataGridViewJury.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewJury.Size = new Size(676, 507);
            dataGridViewJury.TabIndex = 47;
            dataGridViewJury.CellContentClick += dataGridViewJury_CellContentClick;
            dataGridViewJury.CellMouseClick += dataGridViewJury_CellMouseClick;
            dataGridViewJury.Click += dataGridViewJury_Click;
            // 
            // contextMenuStripJury
            // 
            contextMenuStripJury.ImageScalingSize = new Size(20, 20);
            contextMenuStripJury.Items.AddRange(new ToolStripItem[] { visualiserLesHackathonsToolStripMenuItem });
            contextMenuStripJury.Name = "contextMenuStripJury";
            contextMenuStripJury.Size = new Size(286, 30);
            // 
            // visualiserLesHackathonsToolStripMenuItem
            // 
            visualiserLesHackathonsToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé1;
            visualiserLesHackathonsToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            visualiserLesHackathonsToolStripMenuItem.ForeColor = Color.White;
            visualiserLesHackathonsToolStripMenuItem.Image = Properties.Resources.arrow_right_156041;
            visualiserLesHackathonsToolStripMenuItem.Name = "visualiserLesHackathonsToolStripMenuItem";
            visualiserLesHackathonsToolStripMenuItem.Size = new Size(285, 26);
            visualiserLesHackathonsToolStripMenuItem.Text = "Visualiser les hackathons";
            visualiserLesHackathonsToolStripMenuItem.Click += visualiserLesHackathonsToolStripMenuItem_Click;
            // 
            // buttonCreateJury
            // 
            buttonCreateJury.BackColor = Color.FromArgb(45, 50, 55);
            buttonCreateJury.FlatStyle = FlatStyle.Popup;
            buttonCreateJury.Font = new Font("Stencil", 10.8F);
            buttonCreateJury.ForeColor = Color.White;
            buttonCreateJury.Location = new Point(721, 38);
            buttonCreateJury.Name = "buttonCreateJury";
            buttonCreateJury.Size = new Size(177, 36);
            buttonCreateJury.TabIndex = 57;
            buttonCreateJury.Text = "Ajouter un Jury ";
            buttonCreateJury.UseVisualStyleBackColor = false;
            buttonCreateJury.Click += buttonCreateJury_Click;
            // 
            // buttonUpdateJury
            // 
            buttonUpdateJury.BackColor = Color.FromArgb(45, 50, 55);
            buttonUpdateJury.FlatStyle = FlatStyle.Popup;
            buttonUpdateJury.Font = new Font("Stencil", 10.8F);
            buttonUpdateJury.ForeColor = Color.White;
            buttonUpdateJury.Location = new Point(913, 38);
            buttonUpdateJury.Name = "buttonUpdateJury";
            buttonUpdateJury.Size = new Size(185, 36);
            buttonUpdateJury.TabIndex = 59;
            buttonUpdateJury.Text = "Modifier un Jury ";
            buttonUpdateJury.UseVisualStyleBackColor = false;
            buttonUpdateJury.Click += buttonUpdateJury_Click;
            // 
            // panelGestionJury
            // 
            panelGestionJury.BackColor = Color.Transparent;
            panelGestionJury.Location = new Point(721, 80);
            panelGestionJury.Name = "panelGestionJury";
            panelGestionJury.Size = new Size(377, 534);
            panelGestionJury.TabIndex = 58;
            panelGestionJury.Visible = false;
            // 
            // FormJury
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1154, 640);
            Controls.Add(panelGestionJury);
            Controls.Add(buttonUpdateJury);
            Controls.Add(buttonCreateJury);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(textBoxPage);
            Controls.Add(panel1);
            Controls.Add(buttonSuiv);
            Controls.Add(buttonPrec);
            Controls.Add(dataGridViewHackathons);
            Controls.Add(labelInfo);
            Controls.Add(labelListe);
            Controls.Add(dataGridViewJury);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormJury";
            Text = "FormJury";
            Load += FormJury_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHackathons).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewJury).EndInit();
            contextMenuStripJury.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSourceJury).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceHackathons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private TextBox textBoxPage;
        private Panel panel1;
        private Button buttonSuiv;
        private Button buttonPrec;
        private DataGridView dataGridViewHackathons;
        private Label labelInfo;
        private Label labelListe;
        private DataGridView dataGridViewJury;
        private BindingSource bindingSourceJury;
        private ContextMenuStrip contextMenuStripJury;
        private BindingSource bindingSourceHackathons;
        private ToolStripMenuItem visualiserLesHackathonsToolStripMenuItem;
        private Button buttonCreateJury;
        private Button buttonUpdateJury;
        private Panel panelGestionJury;
    }
}