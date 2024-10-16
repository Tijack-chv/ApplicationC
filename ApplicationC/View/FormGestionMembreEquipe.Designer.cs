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
            groupBoxMembreEquipe = new GroupBox();
            panelEquipe = new Panel();
            labelErrorInfoEq = new Label();
            labelNomEquipe = new Label();
            labelLienPrototype = new Label();
            textBoxNomEquipe = new TextBox();
            textBoxLienPrototype = new TextBox();
            textBoxEmailEquipe = new TextBox();
            labelEmailEq = new Label();
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
            panelGestionMembre.SuspendLayout();
            groupBoxMembreEquipe.SuspendLayout();
            panelEquipe.SuspendLayout();
            panelMembre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMembreEquipe).BeginInit();
            SuspendLayout();
            // 
            // panelGestionMembre
            // 
            panelGestionMembre.Controls.Add(comboBoxModificationMembreEquipe);
            panelGestionMembre.Controls.Add(groupBoxMembreEquipe);
            panelGestionMembre.Controls.Add(labelAjoutModifMembreEquipe);
            panelGestionMembre.Location = new Point(14, 16);
            panelGestionMembre.Margin = new Padding(3, 4, 3, 4);
            panelGestionMembre.Name = "panelGestionMembre";
            panelGestionMembre.Size = new Size(1131, 592);
            panelGestionMembre.TabIndex = 0;
            // 
            // comboBoxModificationMembreEquipe
            // 
            comboBoxModificationMembreEquipe.FormattingEnabled = true;
            comboBoxModificationMembreEquipe.Location = new Point(701, 21);
            comboBoxModificationMembreEquipe.Name = "comboBoxModificationMembreEquipe";
            comboBoxModificationMembreEquipe.Size = new Size(375, 28);
            comboBoxModificationMembreEquipe.TabIndex = 27;
            comboBoxModificationMembreEquipe.SelectedIndexChanged += comboBoxModificationMembreEquipe_SelectedIndexChanged;
            // 
            // groupBoxMembreEquipe
            // 
            groupBoxMembreEquipe.BackColor = Color.Transparent;
            groupBoxMembreEquipe.Controls.Add(panelEquipe);
            groupBoxMembreEquipe.Controls.Add(panelMembre);
            groupBoxMembreEquipe.Controls.Add(buttonFermer);
            groupBoxMembreEquipe.Controls.Add(buttonAction);
            groupBoxMembreEquipe.Location = new Point(21, 49);
            groupBoxMembreEquipe.Name = "groupBoxMembreEquipe";
            groupBoxMembreEquipe.Size = new Size(1085, 525);
            groupBoxMembreEquipe.TabIndex = 5;
            groupBoxMembreEquipe.TabStop = false;
            groupBoxMembreEquipe.Text = "Gestion du Membre";
            // 
            // panelEquipe
            // 
            panelEquipe.Controls.Add(labelErrorInfoEq);
            panelEquipe.Controls.Add(labelNomEquipe);
            panelEquipe.Controls.Add(labelLienPrototype);
            panelEquipe.Controls.Add(textBoxNomEquipe);
            panelEquipe.Controls.Add(textBoxLienPrototype);
            panelEquipe.Controls.Add(textBoxEmailEquipe);
            panelEquipe.Controls.Add(labelEmailEq);
            panelEquipe.Location = new Point(7, 27);
            panelEquipe.Name = "panelEquipe";
            panelEquipe.Size = new Size(754, 331);
            panelEquipe.TabIndex = 38;
            // 
            // labelErrorInfoEq
            // 
            labelErrorInfoEq.AutoSize = true;
            labelErrorInfoEq.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelErrorInfoEq.ForeColor = Color.Red;
            labelErrorInfoEq.Location = new Point(169, 295);
            labelErrorInfoEq.Name = "labelErrorInfoEq";
            labelErrorInfoEq.Size = new Size(463, 20);
            labelErrorInfoEq.TabIndex = 39;
            labelErrorInfoEq.Text = "Les champs en rouge ne sont pas valide, modifiez-les";
            labelErrorInfoEq.UseMnemonic = false;
            labelErrorInfoEq.Visible = false;
            // 
            // labelNomEquipe
            // 
            labelNomEquipe.AutoSize = true;
            labelNomEquipe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelNomEquipe.Location = new Point(323, 97);
            labelNomEquipe.Margin = new Padding(5, 0, 5, 0);
            labelNomEquipe.Name = "labelNomEquipe";
            labelNomEquipe.Size = new Size(110, 20);
            labelNomEquipe.TabIndex = 16;
            labelNomEquipe.Text = "Nom Equipe";
            // 
            // labelLienPrototype
            // 
            labelLienPrototype.AutoSize = true;
            labelLienPrototype.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelLienPrototype.Location = new Point(312, 169);
            labelLienPrototype.Margin = new Padding(5, 0, 5, 0);
            labelLienPrototype.Name = "labelLienPrototype";
            labelLienPrototype.Size = new Size(129, 20);
            labelLienPrototype.TabIndex = 35;
            labelLienPrototype.Text = "Lien prototype";
            // 
            // textBoxNomEquipe
            // 
            textBoxNomEquipe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxNomEquipe.Location = new Point(231, 123);
            textBoxNomEquipe.Margin = new Padding(5);
            textBoxNomEquipe.Name = "textBoxNomEquipe";
            textBoxNomEquipe.Size = new Size(311, 26);
            textBoxNomEquipe.TabIndex = 17;
            // 
            // textBoxLienPrototype
            // 
            textBoxLienPrototype.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLienPrototype.Location = new Point(231, 195);
            textBoxLienPrototype.Margin = new Padding(5);
            textBoxLienPrototype.Name = "textBoxLienPrototype";
            textBoxLienPrototype.Size = new Size(311, 26);
            textBoxLienPrototype.TabIndex = 36;
            // 
            // textBoxEmailEquipe
            // 
            textBoxEmailEquipe.Enabled = false;
            textBoxEmailEquipe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmailEquipe.Location = new Point(231, 57);
            textBoxEmailEquipe.Margin = new Padding(5);
            textBoxEmailEquipe.Name = "textBoxEmailEquipe";
            textBoxEmailEquipe.Size = new Size(311, 26);
            textBoxEmailEquipe.TabIndex = 30;
            // 
            // labelEmailEq
            // 
            labelEmailEq.AutoSize = true;
            labelEmailEq.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelEmailEq.Location = new Point(347, 32);
            labelEmailEq.Margin = new Padding(5, 0, 5, 0);
            labelEmailEq.Name = "labelEmailEq";
            labelEmailEq.Size = new Size(63, 20);
            labelEmailEq.TabIndex = 29;
            labelEmailEq.Text = "E-mail";
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
            panelMembre.Location = new Point(792, 27);
            panelMembre.Name = "panelMembre";
            panelMembre.Size = new Size(754, 331);
            panelMembre.TabIndex = 37;
            // 
            // labelErrorInfo
            // 
            labelErrorInfo.AutoSize = true;
            labelErrorInfo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelErrorInfo.ForeColor = Color.Red;
            labelErrorInfo.Location = new Point(137, 295);
            labelErrorInfo.Name = "labelErrorInfo";
            labelErrorInfo.Size = new Size(463, 20);
            labelErrorInfo.TabIndex = 38;
            labelErrorInfo.Text = "Les champs en rouge ne sont pas valide, modifiez-les";
            labelErrorInfo.UseMnemonic = false;
            labelErrorInfo.Visible = false;
            // 
            // dateTimePickerDatenaiss
            // 
            dateTimePickerDatenaiss.Location = new Point(400, 72);
            dateTimePickerDatenaiss.Name = "dateTimePickerDatenaiss";
            dateTimePickerDatenaiss.Size = new Size(311, 27);
            dateTimePickerDatenaiss.TabIndex = 37;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelNom.Location = new Point(41, 43);
            labelNom.Margin = new Padding(5, 0, 5, 0);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(47, 20);
            labelNom.TabIndex = 16;
            labelNom.Text = "Nom";
            // 
            // labelLienPortfolio
            // 
            labelLienPortfolio.AutoSize = true;
            labelLienPortfolio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelLienPortfolio.Location = new Point(400, 129);
            labelLienPortfolio.Margin = new Padding(5, 0, 5, 0);
            labelLienPortfolio.Name = "labelLienPortfolio";
            labelLienPortfolio.Size = new Size(120, 20);
            labelLienPortfolio.TabIndex = 35;
            labelLienPortfolio.Text = "Lien portfolio";
            // 
            // textboxNom
            // 
            textboxNom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textboxNom.Location = new Point(41, 73);
            textboxNom.Margin = new Padding(5);
            textboxNom.Name = "textboxNom";
            textboxNom.Size = new Size(311, 26);
            textboxNom.TabIndex = 17;
            textboxNom.KeyPress += textBoxNomPrenom_KeyPress;
            // 
            // textBoxLienPortfolio
            // 
            textBoxLienPortfolio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxLienPortfolio.Location = new Point(400, 159);
            textBoxLienPortfolio.Margin = new Padding(5);
            textBoxLienPortfolio.Name = "textBoxLienPortfolio";
            textBoxLienPortfolio.Size = new Size(311, 26);
            textBoxLienPortfolio.TabIndex = 36;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPrenom.Location = new Point(41, 159);
            textBoxPrenom.Margin = new Padding(5);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.Size = new Size(311, 26);
            textBoxPrenom.TabIndex = 28;
            textBoxPrenom.KeyPress += textBoxNomPrenom_KeyPress;
            // 
            // labelDatnaiss
            // 
            labelDatnaiss.AutoSize = true;
            labelDatnaiss.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelDatnaiss.Location = new Point(400, 43);
            labelDatnaiss.Margin = new Padding(5, 0, 5, 0);
            labelDatnaiss.Name = "labelDatnaiss";
            labelDatnaiss.Size = new Size(166, 20);
            labelDatnaiss.TabIndex = 33;
            labelDatnaiss.Text = "Date de naissance";
            // 
            // labelPrenom
            // 
            labelPrenom.AutoSize = true;
            labelPrenom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelPrenom.Location = new Point(41, 129);
            labelPrenom.Margin = new Padding(5, 0, 5, 0);
            labelPrenom.Name = "labelPrenom";
            labelPrenom.Size = new Size(73, 20);
            labelPrenom.TabIndex = 27;
            labelPrenom.Text = "Prénom";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(41, 245);
            textBoxEmail.Margin = new Padding(5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(311, 26);
            textBoxEmail.TabIndex = 30;
            // 
            // labelTelephone
            // 
            labelTelephone.AutoSize = true;
            labelTelephone.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelTelephone.Location = new Point(400, 215);
            labelTelephone.Margin = new Padding(5, 0, 5, 0);
            labelTelephone.Name = "labelTelephone";
            labelTelephone.Size = new Size(95, 20);
            labelTelephone.TabIndex = 31;
            labelTelephone.Text = "Téléphone";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            labelEmail.Location = new Point(41, 215);
            labelEmail.Margin = new Padding(5, 0, 5, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(63, 20);
            labelEmail.TabIndex = 29;
            labelEmail.Text = "E-mail";
            // 
            // textBoxTelephone
            // 
            textBoxTelephone.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxTelephone.Location = new Point(400, 245);
            textBoxTelephone.Margin = new Padding(5);
            textBoxTelephone.MaxLength = 10;
            textBoxTelephone.Name = "textBoxTelephone";
            textBoxTelephone.Size = new Size(311, 26);
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
            buttonFermer.Location = new Point(555, 427);
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
            buttonAction.Location = new Point(363, 427);
            buttonAction.Margin = new Padding(5);
            buttonAction.Name = "buttonAction";
            buttonAction.Size = new Size(143, 57);
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
            labelAjoutModifMembreEquipe.Location = new Point(21, 17);
            labelAjoutModifMembreEquipe.Margin = new Padding(5, 0, 5, 0);
            labelAjoutModifMembreEquipe.Name = "labelAjoutModifMembreEquipe";
            labelAjoutModifMembreEquipe.Size = new Size(380, 29);
            labelAjoutModifMembreEquipe.TabIndex = 4;
            labelAjoutModifMembreEquipe.Text = "Ajout/Modification d'un Membre";
            // 
            // bindingSourceMembreEquipe
            // 
            bindingSourceMembreEquipe.CurrentChanged += bindingSourceMembreEquipe_CurrentChanged;
            // 
            // FormGestionMembreEquipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cement_concrete_wall_texture_hi_2868537;
            ClientSize = new Size(1158, 621);
            Controls.Add(panelGestionMembre);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionMembreEquipe";
            Text = "FormGestionMembreEquipe";
            panelGestionMembre.ResumeLayout(false);
            panelGestionMembre.PerformLayout();
            groupBoxMembreEquipe.ResumeLayout(false);
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
        private GroupBox groupBoxMembreEquipe;
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
        private Label labelLienPrototype;
        private TextBox textBoxNomEquipe;
        private TextBox textBoxLienPrototype;
        private TextBox textBoxEmailEquipe;
        private Label labelEmailEq;
        private DateTimePicker dateTimePickerDatenaiss;
        private Label labelErrorInfo;
        private BindingSource bindingSourceMembreEquipe;
        private Label labelErrorInfoEq;
    }
}