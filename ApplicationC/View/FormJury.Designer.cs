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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
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
            panel2.Location = new Point(10, 415);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(153, 22);
            panel2.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(10, 451);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 14);
            label1.TabIndex = 55;
            // 
            // textBoxPage
            // 
            textBoxPage.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPage.Location = new Point(274, 415);
            textBoxPage.Margin = new Padding(3, 2, 3, 2);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(62, 25);
            textBoxPage.TabIndex = 54;
            textBoxPage.Text = "1";
            textBoxPage.TextAlign = HorizontalAlignment.Center;
            textBoxPage.TextChanged += textBoxPage_TextChanged;
            textBoxPage.KeyPress += textBoxPage_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(441, 415);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(161, 22);
            panel1.TabIndex = 53;
            // 
            // buttonSuiv
            // 
            buttonSuiv.BackColor = Color.FromArgb(35, 40, 45);
            buttonSuiv.FlatStyle = FlatStyle.Popup;
            buttonSuiv.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSuiv.ForeColor = Color.White;
            buttonSuiv.Location = new Point(334, 415);
            buttonSuiv.Margin = new Padding(3, 2, 3, 2);
            buttonSuiv.Name = "buttonSuiv";
            buttonSuiv.Size = new Size(110, 22);
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
            buttonPrec.Location = new Point(164, 415);
            buttonPrec.Margin = new Padding(3, 2, 3, 2);
            buttonPrec.Name = "buttonPrec";
            buttonPrec.Size = new Size(110, 22);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewHackathons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewHackathons.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 85, 90);
            dataGridViewCellStyle2.Font = new Font("Rockwell", 11.25F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewHackathons.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewHackathons.EnableHeadersVisualStyles = false;
            dataGridViewHackathons.GridColor = Color.Black;
            dataGridViewHackathons.Location = new Point(106, 35);
            dataGridViewHackathons.Margin = new Padding(5);
            dataGridViewHackathons.MultiSelect = false;
            dataGridViewHackathons.Name = "dataGridViewHackathons";
            dataGridViewHackathons.ReadOnly = true;
            dataGridViewHackathons.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewHackathons.RowHeadersVisible = false;
            dataGridViewHackathons.RowHeadersWidth = 51;
            dataGridViewHackathons.Size = new Size(375, 380);
            dataGridViewHackathons.TabIndex = 50;
            dataGridViewHackathons.Visible = false;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.BackColor = Color.Transparent;
            labelInfo.Font = new Font("SimSun-ExtB", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInfo.ForeColor = SystemColors.ActiveCaptionText;
            labelInfo.Location = new Point(10, 464);
            labelInfo.Margin = new Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(629, 14);
            labelInfo.TabIndex = 49;
            labelInfo.Text = "click droit sur le Jury sélectionné pour voir les hackathons dont il participe";
            // 
            // labelListe
            // 
            labelListe.AutoSize = true;
            labelListe.BackColor = Color.Transparent;
            labelListe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelListe.Location = new Point(17, 8);
            labelListe.Margin = new Padding(4, 0, 4, 0);
            labelListe.Name = "labelListe";
            labelListe.Size = new Size(138, 24);
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle3.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewJury.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewJury.ColumnHeadersHeight = 30;
            dataGridViewJury.ContextMenuStrip = contextMenuStripJury;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(80, 85, 90);
            dataGridViewCellStyle4.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewJury.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewJury.EnableHeadersVisualStyles = false;
            dataGridViewJury.GridColor = Color.Black;
            dataGridViewJury.Location = new Point(10, 35);
            dataGridViewJury.Margin = new Padding(5);
            dataGridViewJury.MultiSelect = false;
            dataGridViewJury.Name = "dataGridViewJury";
            dataGridViewJury.ReadOnly = true;
            dataGridViewJury.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(80, 85, 90);
            dataGridViewCellStyle5.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewJury.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewJury.RowHeadersVisible = false;
            dataGridViewJury.RowHeadersWidth = 55;
            dataGridViewJury.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewJury.Size = new Size(592, 380);
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
            contextMenuStripJury.Size = new Size(233, 30);
            // 
            // visualiserLesHackathonsToolStripMenuItem
            // 
            visualiserLesHackathonsToolStripMenuItem.BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé1;
            visualiserLesHackathonsToolStripMenuItem.Font = new Font("Book Antiqua", 9.75F, FontStyle.Bold);
            visualiserLesHackathonsToolStripMenuItem.ForeColor = Color.White;
            visualiserLesHackathonsToolStripMenuItem.Image = Properties.Resources.arrow_right_156041;
            visualiserLesHackathonsToolStripMenuItem.Name = "visualiserLesHackathonsToolStripMenuItem";
            visualiserLesHackathonsToolStripMenuItem.Size = new Size(232, 26);
            visualiserLesHackathonsToolStripMenuItem.Text = "Visualiser les hackathons";
            visualiserLesHackathonsToolStripMenuItem.Click += visualiserLesHackathonsToolStripMenuItem_Click;
            // 
            // buttonCreateJury
            // 
            buttonCreateJury.BackColor = Color.FromArgb(45, 50, 55);
            buttonCreateJury.FlatStyle = FlatStyle.Popup;
            buttonCreateJury.Font = new Font("Stencil", 10.8F);
            buttonCreateJury.ForeColor = Color.White;
            buttonCreateJury.Location = new Point(631, 6);
            buttonCreateJury.Margin = new Padding(3, 2, 3, 2);
            buttonCreateJury.Name = "buttonCreateJury";
            buttonCreateJury.Size = new Size(155, 27);
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
            buttonUpdateJury.Location = new Point(799, 6);
            buttonUpdateJury.Margin = new Padding(3, 2, 3, 2);
            buttonUpdateJury.Name = "buttonUpdateJury";
            buttonUpdateJury.Size = new Size(162, 27);
            buttonUpdateJury.TabIndex = 59;
            buttonUpdateJury.Text = "Modifier un Jury ";
            buttonUpdateJury.UseVisualStyleBackColor = false;
            buttonUpdateJury.Click += buttonUpdateJury_Click;
            // 
            // panelGestionJury
            // 
            panelGestionJury.BackColor = Color.Transparent;
            panelGestionJury.Location = new Point(631, 37);
            panelGestionJury.Margin = new Padding(3, 2, 3, 2);
            panelGestionJury.Name = "panelGestionJury";
            panelGestionJury.Size = new Size(330, 400);
            panelGestionJury.TabIndex = 58;
            panelGestionJury.Visible = false;
            // 
            // FormJury
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1012, 486);
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