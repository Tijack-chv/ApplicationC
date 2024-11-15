namespace ApplicationC.View
{
    partial class Form2FATest
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
            label1 = new Label();
            textBox1 = new TextBox();
            button2FA = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 5);
            label1.Name = "label1";
            label1.Size = new Size(196, 21);
            label1.TabIndex = 0;
            label1.Text = "Vérifier Connexion";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(35, 40, 45);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(38, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 21);
            textBox1.TabIndex = 1;
            // 
            // button2FA
            // 
            button2FA.BackColor = Color.FromArgb(35, 40, 45);
            button2FA.FlatStyle = FlatStyle.Popup;
            button2FA.Font = new Font("Stencil", 12F);
            button2FA.ForeColor = Color.White;
            button2FA.Location = new Point(51, 104);
            button2FA.Margin = new Padding(3, 4, 3, 4);
            button2FA.Name = "button2FA";
            button2FA.Size = new Size(105, 41);
            button2FA.TabIndex = 9;
            button2FA.Text = "Valider";
            button2FA.UseVisualStyleBackColor = false;
            button2FA.Click += button2FA_Click;
            // 
            // Form2FATest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._131063946_abstrait_de_texture_de_pierre_ardoise_noire_gris_foncé;
            ClientSize = new Size(207, 149);
            Controls.Add(button2FA);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form2FATest";
            Text = "Form2FATest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button2FA;
    }
}