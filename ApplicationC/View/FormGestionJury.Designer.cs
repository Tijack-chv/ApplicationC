namespace ApplicationC.View
{
    partial class FormGestionJury
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
            textBoxPrenom = new TextBox();
            labelNom = new Label();
            labelPrenom = new Label();
            buttonFermer = new Button();
            buttonAction = new Button();
            panel1 = new Panel();
            textBoxNom = new TextBox();
            textBoxEmail = new TextBox();
            labelEmail = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.BackColor = Color.FromArgb(45, 50, 55);
            textBoxPrenom.BorderStyle = BorderStyle.None;
            textBoxPrenom.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPrenom.ForeColor = Color.White;
            textBoxPrenom.Location = new Point(59, 201);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(239, 23);
            textBoxPrenom.TabIndex = 1;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.BackColor = Color.Transparent;
            labelNom.FlatStyle = FlatStyle.Flat;
            labelNom.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNom.ForeColor = Color.FromArgb(25, 30, 35);
            labelNom.Location = new Point(104, 60);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(144, 25);
            labelNom.TabIndex = 3;
            labelNom.Text = "Nom du Jury";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.BackColor = Color.Transparent;
            labelPrenom.FlatStyle = FlatStyle.Flat;
            labelPrenom.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrenom.ForeColor = Color.FromArgb(25, 30, 35);
            labelPrenom.Location = new Point(93, 173);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(175, 25);
            labelPrenom.TabIndex = 9;
            labelPrenom.Text = "Prénom du Jury";
            // 
            // buttonFermer
            // 
            buttonFermer.BackColor = Color.Black;
            buttonFermer.FlatStyle = FlatStyle.Popup;
            buttonFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFermer.ForeColor = SystemColors.ControlLightLight;
            buttonFermer.Location = new Point(228, 460);
            buttonFermer.Margin = new Padding(5);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Size = new Size(133, 57);
            buttonFermer.TabIndex = 25;
            buttonFermer.Text = "FERMER";
            buttonFermer.UseVisualStyleBackColor = false;
            buttonFermer.Click += buttonFermer_Click;
            // 
            // buttonAction
            // 
            buttonAction.BackColor = Color.Black;
            buttonAction.FlatStyle = FlatStyle.Popup;
            buttonAction.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAction.ForeColor = SystemColors.ControlLightLight;
            buttonAction.Location = new Point(12, 460);
            buttonAction.Margin = new Padding(5);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(143, 57);
            buttonAction.TabIndex = 26;
            buttonAction.Text = "AJOUTER";
            buttonAction.UseVisualStyleBackColor = false;
            buttonAction.Click += buttonAction_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            panel1.Controls.Add(labelPrenom);
            panel1.Controls.Add(buttonFermer);
            panel1.Controls.Add(buttonAction);
            panel1.Controls.Add(textBoxPrenom);
            panel1.Controls.Add(labelNom);
            panel1.Controls.Add(labelEmail);
            panel1.Controls.Add(textBoxEmail);
            panel1.Controls.Add(textBoxNom);
            panel1.Location = new Point(2, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 528);
            panel1.TabIndex = 27;
            // 
            // textBoxNom
            // 
            textBoxNom.BackColor = Color.FromArgb(45, 50, 55);
            textBoxNom.BorderStyle = BorderStyle.None;
            textBoxNom.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNom.ForeColor = Color.White;
            textBoxNom.Location = new Point(59, 88);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.Size = new Size(239, 23);
            textBoxNom.TabIndex = 6;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(45, 50, 55);
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.Location = new Point(59, 315);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(239, 23);
            textBoxEmail.TabIndex = 7;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Transparent;
            labelEmail.FlatStyle = FlatStyle.Flat;
            labelEmail.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.FromArgb(25, 30, 35);
            labelEmail.Location = new Point(104, 287);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(152, 25);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "Email du Jury";
            // 
            // FormGestionJury
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(377, 534);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionJury";
            Text = "FormGestionJury";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxPrenom;
        private Label labelNom;
        private Label labelPrenom;
        private Button buttonFermer;
        private Button buttonAction;
        private Panel panel1;
        private TextBox textBoxNom;
        private Label labelEmail;
        private TextBox textBoxEmail;
    }
}