namespace ArduinoMail
{
    partial class ArduinoMail
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.portArduinoComboBox = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sourcesLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.srvImapTextBox = new System.Windows.Forms.TextBox();
            this.portImapTextBox = new System.Windows.Forms.TextBox();
            this.sllCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // portArduinoComboBox
            // 
            this.portArduinoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portArduinoComboBox.FormattingEnabled = true;
            this.portArduinoComboBox.Location = new System.Drawing.Point(95, 12);
            this.portArduinoComboBox.Name = "portArduinoComboBox";
            this.portArduinoComboBox.Size = new System.Drawing.Size(100, 21);
            this.portArduinoComboBox.TabIndex = 1;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(209, 157);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "Valider";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port Arduino :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(95, 39);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(189, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(95, 68);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.PasswordChar = '•';
            this.passTextBox.Size = new System.Drawing.Size(189, 20);
            this.passTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mot de passe :";
            // 
            // sourcesLinkLabel
            // 
            this.sourcesLinkLabel.AutoSize = true;
            this.sourcesLinkLabel.Location = new System.Drawing.Point(12, 162);
            this.sourcesLinkLabel.Name = "sourcesLinkLabel";
            this.sourcesLinkLabel.Size = new System.Drawing.Size(55, 13);
            this.sourcesLinkLabel.TabIndex = 6;
            this.sourcesLinkLabel.TabStop = true;
            this.sourcesLinkLabel.Text = "Sources...";
            this.sourcesLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourcesLinkLabel_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Serveur IMAP :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Port du serveur :";
            // 
            // srvImapTextBox
            // 
            this.srvImapTextBox.Location = new System.Drawing.Point(95, 94);
            this.srvImapTextBox.Name = "srvImapTextBox";
            this.srvImapTextBox.Size = new System.Drawing.Size(189, 20);
            this.srvImapTextBox.TabIndex = 5;
            // 
            // portImapTextBox
            // 
            this.portImapTextBox.Location = new System.Drawing.Point(95, 120);
            this.portImapTextBox.Name = "portImapTextBox";
            this.portImapTextBox.Size = new System.Drawing.Size(64, 20);
            this.portImapTextBox.TabIndex = 5;
            // 
            // sllCheckBox
            // 
            this.sllCheckBox.AutoSize = true;
            this.sllCheckBox.Checked = true;
            this.sllCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sllCheckBox.Location = new System.Drawing.Point(157, 161);
            this.sllCheckBox.Name = "sllCheckBox";
            this.sllCheckBox.Size = new System.Drawing.Size(46, 17);
            this.sllCheckBox.TabIndex = 7;
            this.sllCheckBox.Text = "SSL";
            this.sllCheckBox.UseVisualStyleBackColor = true;
            // 
            // ArduinoMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 190);
            this.Controls.Add(this.sllCheckBox);
            this.Controls.Add(this.sourcesLinkLabel);
            this.Controls.Add(this.portImapTextBox);
            this.Controls.Add(this.srvImapTextBox);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.portArduinoComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ArduinoMail";
            this.Text = "Arduino Mail";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArduinoMail_FormClosed);
            this.Load += new System.EventHandler(this.ArduinoMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox portArduinoComboBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel sourcesLinkLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox srvImapTextBox;
        private System.Windows.Forms.TextBox portImapTextBox;
        private System.Windows.Forms.CheckBox sllCheckBox;
    }
}

