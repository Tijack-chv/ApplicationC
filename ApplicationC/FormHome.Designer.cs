namespace ApplicationC
{
    partial class FormHome
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
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            panelNorth = new Panel();
            panel2 = new Panel();
            pictureBoxLogo = new PictureBox();
            panelAffichage = new Panel();
            buttonHome = new Button();
            buttonHackathon = new Button();
            button1 = new Button();
            panelNorth.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // panelNorth
            // 
            panelNorth.BackColor = Color.FromArgb(35, 40, 45);
            panelNorth.Controls.Add(pictureBoxLogo);
            panelNorth.Dock = DockStyle.Top;
            panelNorth.Location = new Point(0, 0);
            panelNorth.Name = "panelNorth";
            panelNorth.Size = new Size(882, 90);
            panelNorth.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 50, 55);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(buttonHackathon);
            panel2.Controls.Add(buttonHome);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(122, 463);
            panel2.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(122, 90);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 2;
            pictureBoxLogo.TabStop = false;
            // 
            // panelAffichage
            // 
            panelAffichage.BackColor = SystemColors.ActiveBorder;
            panelAffichage.Dock = DockStyle.Fill;
            panelAffichage.Location = new Point(122, 90);
            panelAffichage.Name = "panelAffichage";
            panelAffichage.Size = new Size(760, 463);
            panelAffichage.TabIndex = 2;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(45, 50, 55);
            buttonHome.BackgroundImage = Properties.Resources.icons8_home_32;
            buttonHome.BackgroundImageLayout = ImageLayout.Center;
            buttonHome.FlatStyle = FlatStyle.Popup;
            buttonHome.Location = new Point(0, 44);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(122, 52);
            buttonHome.TabIndex = 0;
            buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonHackathon
            // 
            buttonHackathon.BackColor = Color.FromArgb(45, 50, 55);
            buttonHackathon.BackgroundImage = Properties.Resources.hackathon;
            buttonHackathon.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHackathon.FlatStyle = FlatStyle.Popup;
            buttonHackathon.Location = new Point(0, 95);
            buttonHackathon.Name = "buttonHackathon";
            buttonHackathon.Size = new Size(122, 52);
            buttonHackathon.TabIndex = 1;
            buttonHackathon.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(45, 50, 55);
            button1.BackgroundImage = Properties.Resources.icons8_member_32;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(0, 146);
            button1.Name = "button1";
            button1.Size = new Size(122, 52);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(panelAffichage);
            Controls.Add(panel2);
            Controls.Add(panelNorth);
            Name = "FormHome";
            Text = "FormHome";
            panelNorth.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Panel panelNorth;
        private Panel panel2;
        private PictureBox pictureBoxLogo;
        private Panel panelAffichage;
        private Button buttonHome;
        private Button buttonHackathon;
        private Button button1;
    }
}