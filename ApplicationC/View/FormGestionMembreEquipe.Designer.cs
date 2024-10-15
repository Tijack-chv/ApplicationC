namespace ApplicationC.View
{
    partial class FormGestionMembreEquipe
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
            panelGestionMembre = new Panel();
            comboBoxModificationMembreEquipe = new ComboBox();
            groupBoxMembre = new GroupBox();
            panelEquipe = new Panel();
            labelNomEquipe = new Label();
            label2 = new Label();
            textBoxNomEquipe = new TextBox();
            textBoxLienPrototype = new TextBox();
            textBoxEmailEquipe = new TextBox();
            label6 = new Label();
            panelMembre = new Panel();
            labelErrorInfo = new Label();
            dateTimePickerDatenaiss = new DateTimePicker();
            labelNom = new Label();
            labelLienPortfolio = new Label();
            textboxNom = new TextBox();
            textBoxLienPortfolio = new TextBox();
            textBoxPrenom = new TextBox();
            labelDatnaiss = new Label();
            labelPrenom = new Label();
            textBoxEmail = new TextBox();
            labelTelephone = new Label();
            labelEmail = new Label();
            textBoxTelephone = new TextBox();
            buttonFermer = new Button();
            buttonAction = new Button();
            labelAjoutModifMembreEquipe = new Label();
            bindingSourceMembreEquipe = new BindingSource(components);
            label1 = new Label();
            panelGestionMembre.SuspendLayout();
            groupBoxMembre.SuspendLayout();
            panelEquipe.SuspendLayout();
            panelMembre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembreEquipe).BeginInit();
            SuspendLayout();
            // 
            // panelGestionMembre
            // 
            panelGestionMembre.Controls.Add(comboBoxModificationMembreEquipe);
            panelGestionMembre.Controls.Add(groupBoxMembre);
            panelGestionMembre.Controls.Add(labelAjoutModifMembreEquipe);
            panelGestionMembre.Location = new Point(12, 12);
            panelGestionMembre.Name = "panelGestionMembre";
            panelGestionMembre.Size = new Size(990, 444);
            panelGestionMembre.TabIndex = 0;
            // 
            // comboBoxModificationMembreEquipe
            // 
            comboBoxModificationMembreEquipe.FormattingEnabled = true;
            comboBoxModificationMembreEquipe.Location = new Point(613, 16);
            comboBoxModificationMembreEquipe.Margin = new Padding(3, 2, 3, 2);
            comboBoxModificationMembreEquipe.Name = "comboBoxModificationMembreEquipe";
            comboBoxModificationMembreEquipe.Size = new Size(329, 23);
            comboBoxModificationMembreEquipe.TabIndex = 27;
            comboBoxModificationMembreEquipe.SelectedIndexChanged += comboBoxModificationMembreEquipe_SelectedIndexChanged;
            // 
            // groupBoxMembre
            // 
            groupBoxMembre.BackColor = Color.Transparent;
            groupBoxMembre.Controls.Add(panelEquipe);
            groupBoxMembre.Controls.Add(panelMembre);
            groupBoxMembre.Controls.Add(buttonFermer);
            groupBoxMembre.Controls.Add(buttonAction);
            groupBoxMembre.Location = new Point(18, 37);
            groupBoxMembre.Margin = new Padding(3, 2, 3, 2);
            groupBoxMembre.Name = "groupBoxMembre";
            groupBoxMembre.Padding = new Padding(3, 2, 3, 2);
            groupBoxMembre.Size = new Size(949, 394);
            groupBoxMembre.TabIndex = 5;
            groupBoxMembre.TabStop = false;
            groupBoxMembre.Text = "Gestion du Membre";
            // 
            // panelEquipe
            // 
            panelEquipe.Controls.Add(label1);
            panelEquipe.Controls.Add(labelNomEquipe);
            panelEquipe.Controls.Add(label2);
            panelEquipe.Controls.Add(textBoxNomEquipe);
            panelEquipe.Controls.Add(textBoxLienPrototype);
            panelEquipe.Controls.Add(textBoxEmailEquipe);
            panelEquipe.Controls.Add(label6);
            panelEquipe.Location = new Point(6, 20);
            panelEquipe.Margin = new Padding(3, 2, 3, 2);
            panelEquipe.Name = "panelEquipe";
            panelEquipe.Size = new Size(660, 248);
            panelEquipe.TabIndex = 38;
            // 
            // labelNomEquipe
            // 
            labelNomEquipe.AutoSize = true;
            labelNomEquipe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelNomEquipe.Location = new Point(283, 73);
            labelNomEquipe.Margin = new Padding(4, 0, 4, 0);
            labelNomEquipe.Name = "labelNomEquipe";
            labelNomEquipe.Size = new Size(92, 16);
            labelNomEquipe.TabIndex = 16;
            labelNomEquipe.Text = "Nom Equipe";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label2.Location = new Point(273, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 16);
            label2.TabIndex = 35;
            label2.Text = "Lien prototype";
            // 
            // textBoxNomEquipe
            // 
            textBoxNomEquipe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomEquipe.Location = new Point(202, 92);
            textBoxNomEquipe.Margin = new Padding(4, 4, 4, 4);
            textBoxNomEquipe.Name = "textBoxNomEquipe";
            textBoxNomEquipe.Size = new Size(273, 22);
            textBoxNomEquipe.TabIndex = 17;
            // 
            // textBoxLienPrototype
            // 
            textBoxLienPrototype.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLienPrototype.Location = new Point(202, 146);
            textBoxLienPrototype.Margin = new Padding(4, 4, 4, 4);
            textBoxLienPrototype.Name = "textBoxLienPrototype";
            textBoxLienPrototype.Size = new Size(273, 22);
            textBoxLienPrototype.TabIndex = 36;
            // 
            // textBoxEmailEquipe
            // 
            textBoxEmailEquipe.Enabled = false;
            textBoxEmailEquipe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmailEquipe.Location = new Point(202, 43);
            textBoxEmailEquipe.Margin = new Padding(4, 4, 4, 4);
            textBoxEmailEquipe.Name = "textBoxEmailEquipe";
            textBoxEmailEquipe.Size = new Size(273, 22);
            textBoxEmailEquipe.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label6.Location = new Point(304, 24);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 16);
            label6.TabIndex = 29;
            label6.Text = "E-mail";
            // 
            // panelMembre
            // 
            panelMembre.Controls.Add(labelErrorInfo);
            panelMembre.Controls.Add(dateTimePickerDatenaiss);
            panelMembre.Controls.Add(labelNom);
            panelMembre.Controls.Add(labelLienPortfolio);
            panelMembre.Controls.Add(textboxNom);
            panelMembre.Controls.Add(textBoxLienPortfolio);
            panelMembre.Controls.Add(textBoxPrenom);
            panelMembre.Controls.Add(labelDatnaiss);
            panelMembre.Controls.Add(labelPrenom);
            panelMembre.Controls.Add(textBoxEmail);
            panelMembre.Controls.Add(labelTelephone);
            panelMembre.Controls.Add(labelEmail);
            panelMembre.Controls.Add(textBoxTelephone);
            panelMembre.Location = new Point(693, 20);
            panelMembre.Margin = new Padding(3, 2, 3, 2);
            panelMembre.Name = "panelMembre";
            panelMembre.Size = new Size(660, 248);
            panelMembre.TabIndex = 37;
            // 
            // labelErrorInfo
            // 
            labelErrorInfo.AutoSize = true;
            labelErrorInfo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelErrorInfo.ForeColor = Color.Red;
            labelErrorInfo.Location = new Point(120, 221);
            labelErrorInfo.Name = "labelErrorInfo";
            labelErrorInfo.Size = new Size(378, 16);
            labelErrorInfo.TabIndex = 38;
            labelErrorInfo.Text = "Les champs en rouge ne sont pas valide, modifiez-les";
            labelErrorInfo.UseMnemonic = false;
            labelErrorInfo.Visible = false;
            // 
            // dateTimePickerDatenaiss
            // 
            dateTimePickerDatenaiss.Location = new Point(350, 54);
            dateTimePickerDatenaiss.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerDatenaiss.Name = "dateTimePickerDatenaiss";
            dateTimePickerDatenaiss.Size = new Size(273, 23);
            dateTimePickerDatenaiss.TabIndex = 37;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelNom.Location = new Point(36, 32);
            labelNom.Margin = new Padding(4, 0, 4, 0);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(39, 16);
            labelNom.TabIndex = 16;
            labelNom.Text = "Nom";
            // 
            // labelLienPortfolio
            // 
            labelLienPortfolio.AutoSize = true;
            labelLienPortfolio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelLienPortfolio.Location = new Point(350, 97);
            labelLienPortfolio.Margin = new Padding(4, 0, 4, 0);
            labelLienPortfolio.Name = "labelLienPortfolio";
            labelLienPortfolio.Size = new Size(97, 16);
            labelLienPortfolio.TabIndex = 35;
            labelLienPortfolio.Text = "Lien portfolio";
            // 
            // textboxNom
            // 
            textboxNom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxNom.Location = new Point(36, 55);
            textboxNom.Margin = new Padding(4, 4, 4, 4);
            textboxNom.Name = "textboxNom";
            textboxNom.Size = new Size(273, 22);
            textboxNom.TabIndex = 17;
            textboxNom.KeyPress += textBoxNomPrenom_KeyPress;
            // 
            // textBoxLienPortfolio
            // 
            textBoxLienPortfolio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLienPortfolio.Location = new Point(350, 119);
            textBoxLienPortfolio.Margin = new Padding(4, 4, 4, 4);
            textBoxLienPortfolio.Name = "textBoxLienPortfolio";
            textBoxLienPortfolio.Size = new Size(273, 22);
            textBoxLienPortfolio.TabIndex = 36;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPrenom.Location = new Point(36, 119);
            textBoxPrenom.Margin = new Padding(4, 4, 4, 4);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(273, 22);
            textBoxPrenom.TabIndex = 28;
            textBoxPrenom.KeyPress += textBoxNomPrenom_KeyPress;
            // 
            // labelDatnaiss
            // 
            labelDatnaiss.AutoSize = true;
            labelDatnaiss.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelDatnaiss.Location = new Point(350, 32);
            labelDatnaiss.Margin = new Padding(4, 0, 4, 0);
            labelDatnaiss.Name = "labelDatnaiss";
            labelDatnaiss.Size = new Size(137, 16);
            labelDatnaiss.TabIndex = 33;
            labelDatnaiss.Text = "Date de naissance";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelPrenom.Location = new Point(36, 97);
            labelPrenom.Margin = new Padding(4, 0, 4, 0);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(60, 16);
            labelPrenom.TabIndex = 27;
            labelPrenom.Text = "Prénom";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(36, 184);
            textBoxEmail.Margin = new Padding(4, 4, 4, 4);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(273, 22);
            textBoxEmail.TabIndex = 30;
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelTelephone.Location = new Point(350, 161);
            labelTelephone.Margin = new Padding(4, 0, 4, 0);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(82, 16);
            labelTelephone.TabIndex = 31;
            labelTelephone.Text = "Téléphone";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelEmail.Location = new Point(36, 161);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(51, 16);
            labelEmail.TabIndex = 29;
            labelEmail.Text = "E-mail";
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTelephone.Location = new Point(350, 184);
            textBoxTelephone.Margin = new Padding(4, 4, 4, 4);
            textBoxTelephone.MaxLength = 10;
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(273, 22);
            textBoxTelephone.TabIndex = 32;
            textBoxTelephone.TextChanged += textBoxTelephone_TextChanged;
            textBoxTelephone.KeyPress += textBoxTelephone_KeyPress;
            // 
            // buttonFermer
            // 
            buttonFermer.BackColor = Color.Black;
            buttonFermer.FlatStyle = FlatStyle.Popup;
            buttonFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFermer.ForeColor = SystemColors.ControlLightLight;
            buttonFermer.Location = new Point(486, 320);
            buttonFermer.Margin = new Padding(4, 4, 4, 4);
            buttonFermer.Name = "buttonFermer";
            buttonFermer.Size = new Size(116, 43);
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
            buttonAction.Location = new Point(318, 320);
            buttonAction.Margin = new Padding(4, 4, 4, 4);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(125, 43);
            buttonAction.TabIndex = 26;
            buttonAction.Text = "AJOUTER";
            buttonAction.UseVisualStyleBackColor = false;
            buttonAction.Click += buttonAction_ClickAsync;
            // 
            // labelAjoutModifMembreEquipe
            // 
            labelAjoutModifMembreEquipe.AutoSize = true;
            labelAjoutModifMembreEquipe.BackColor = Color.Transparent;
            labelAjoutModifMembreEquipe.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelAjoutModifMembreEquipe.ForeColor = SystemColors.ActiveCaptionText;
            labelAjoutModifMembreEquipe.Location = new Point(18, 13);
            labelAjoutModifMembreEquipe.Margin = new Padding(4, 0, 4, 0);
            labelAjoutModifMembreEquipe.Name = "labelAjoutModifMembreEquipe";
            labelAjoutModifMembreEquipe.Size = new Size(306, 24);
            labelAjoutModifMembreEquipe.TabIndex = 4;
            labelAjoutModifMembreEquipe.Text = "Ajout/Modification d'un Membre";
            // 
            // bindingSourceMembreEquipe
            // 
            bindingSourceMembreEquipe.CurrentChanged += bindingSourceMembreEquipe_CurrentChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(147, 211);
            label1.Name = "label1";
            label1.Size = new Size(378, 16);
            label1.TabIndex = 39;
            label1.Text = "Les champs en rouge ne sont pas valide, modifiez-les";
            label1.UseMnemonic = false;
            label1.Visible = false;
            // 
            // FormGestionMembreEquipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1013, 466);
            Controls.Add(panelGestionMembre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionMembreEquipe";
            Text = "FormGestionMembreEquipe";
            panelGestionMembre.ResumeLayout(false);
            panelGestionMembre.PerformLayout();
            groupBoxMembre.ResumeLayout(false);
            panelEquipe.ResumeLayout(false);
            panelEquipe.PerformLayout();
            panelMembre.ResumeLayout(false);
            panelMembre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembreEquipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGestionMembre;
        private Label labelAjoutModifMembreEquipe;
        private GroupBox groupBoxMembre;
        private Label labelNom;
        private TextBox textboxNom;
        private Button buttonFermer;
        private Button buttonAction;
        private ComboBox comboBoxModificationMembreEquipe;
        private Label labelPrenom;
        private TextBox textBoxPrenom;
        private Label labelLienPortfolio;
        private TextBox textBoxLienPortfolio;
        private Label labelDatnaiss;
        private Label labelTelephone;
        private TextBox textBoxTelephone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Panel panelMembre;
        private Panel panelEquipe;
        private Label labelNomEquipe;
        private Label label2;
        private TextBox textBoxNomEquipe;
        private TextBox textBoxLienPrototype;
        private TextBox textBoxEmailEquipe;
        private Label label6;
        private DateTimePicker dateTimePickerDatenaiss;
        private Label labelErrorInfo;
        private BindingSource bindingSourceMembreEquipe;
        private Label label1;
    }
}