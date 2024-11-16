namespace ApplicationC.View
{
    partial class FormAbout
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
            dataGridViewLogs = new DataGridView();
            panel2 = new Panel();
            textBoxPage = new TextBox();
            panel1 = new Panel();
            buttonSuiv = new Button();
            buttonPrec = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            bindingSourceLogs = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceLogs).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLogs
            // 
            dataGridViewLogs.AllowUserToAddRows = false;
            dataGridViewLogs.AllowUserToDeleteRows = false;
            dataGridViewLogs.AllowUserToOrderColumns = true;
            dataGridViewLogs.AllowUserToResizeRows = false;
            dataGridViewLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewLogs.BackgroundColor = Color.FromArgb(80, 85, 90);
            dataGridViewLogs.BorderStyle = BorderStyle.None;
            dataGridViewLogs.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 45, 50);
            dataGridViewCellStyle1.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewLogs.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 85, 90);
            dataGridViewCellStyle2.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewLogs.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewLogs.EnableHeadersVisualStyles = false;
            dataGridViewLogs.GridColor = Color.Black;
            dataGridViewLogs.Location = new Point(104, 51);
            dataGridViewLogs.Margin = new Padding(5);
            dataGridViewLogs.MultiSelect = false;
            dataGridViewLogs.Name = "dataGridViewLogs";
            dataGridViewLogs.ReadOnly = true;
            dataGridViewLogs.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(80, 85, 90);
            dataGridViewCellStyle3.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewLogs.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewLogs.RowHeadersVisible = false;
            dataGridViewLogs.RowHeadersWidth = 55;
            dataGridViewLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLogs.Size = new Size(783, 358);
            dataGridViewLogs.TabIndex = 1;
            dataGridViewLogs.DoubleClick += dataGridViewLogs_DoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(30, 35, 40);
            panel2.Location = new Point(104, 407);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 22);
            panel2.TabIndex = 20;
            // 
            // textBoxPage
            // 
            textBoxPage.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPage.Location = new Point(463, 407);
            textBoxPage.Margin = new Padding(3, 2, 3, 2);
            textBoxPage.Name = "textBoxPage";
            textBoxPage.Size = new Size(62, 25);
            textBoxPage.TabIndex = 19;
            textBoxPage.Text = "1";
            textBoxPage.TextAlign = HorizontalAlignment.Center;
            textBoxPage.TextChanged += textBoxPage_TextChanged;
            textBoxPage.KeyPress += textBoxPage_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 35, 40);
            panel1.Location = new Point(630, 407);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(257, 22);
            panel1.TabIndex = 18;
            // 
            // buttonSuiv
            // 
            buttonSuiv.BackColor = Color.FromArgb(35, 40, 45);
            buttonSuiv.FlatStyle = FlatStyle.Popup;
            buttonSuiv.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSuiv.ForeColor = Color.White;
            buttonSuiv.Location = new Point(524, 407);
            buttonSuiv.Margin = new Padding(3, 2, 3, 2);
            buttonSuiv.Name = "buttonSuiv";
            buttonSuiv.Size = new Size(110, 22);
            buttonSuiv.TabIndex = 17;
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
            buttonPrec.Location = new Point(353, 407);
            buttonPrec.Margin = new Padding(3, 2, 3, 2);
            buttonPrec.Name = "buttonPrec";
            buttonPrec.Size = new Size(110, 22);
            buttonPrec.TabIndex = 16;
            buttonPrec.Text = "Précédent";
            buttonPrec.UseVisualStyleBackColor = false;
            buttonPrec.Click += buttonPrec_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(30, 35, 40);
            panel3.Location = new Point(79, 27);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(832, 25);
            panel3.TabIndex = 23;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(30, 35, 40);
            panel5.Location = new Point(886, 51);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(25, 378);
            panel5.TabIndex = 25;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(30, 35, 40);
            panel6.Location = new Point(79, 51);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(25, 378);
            panel6.TabIndex = 26;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(100, 105, 110);
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1012, 488);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(textBoxPage);
            Controls.Add(panel1);
            Controls.Add(buttonSuiv);
            Controls.Add(buttonPrec);
            Controls.Add(dataGridViewLogs);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAbout";
            Text = "FormAbout";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewLogs;
        private Panel panel2;
        private TextBox textBoxPage;
        private Panel panel1;
        private Button buttonSuiv;
        private Button buttonPrec;
        private Panel panel3;
        private Panel panel5;
        private Panel panel6;
        private BindingSource bindingSourceLogs;
    }
}