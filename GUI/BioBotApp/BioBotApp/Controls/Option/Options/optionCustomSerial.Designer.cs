namespace BioBotApp.Controls.Option.Options
{
    partial class optionCustomSerial
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(optionCustomSerial));
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaudeRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnSendTest = new System.Windows.Forms.Button();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.cmbStop = new BioBotApp.Controls.Utils.stopBitComboBox();
            this.cmbParity = new BioBotApp.Controls.Utils.parityBitComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHandshake = new BioBotApp.Controls.Utils.handshakeComboBox();
            this.cbRtsEnable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPortName
            // 
            this.cmbPortName.Location = new System.Drawing.Point(138, 9);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(121, 21);
            this.cmbPortName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port name";
            // 
            // txtBaudeRate
            // 
            this.txtBaudeRate.Location = new System.Drawing.Point(138, 62);
            this.txtBaudeRate.Name = "txtBaudeRate";
            this.txtBaudeRate.Size = new System.Drawing.Size(121, 20);
            this.txtBaudeRate.TabIndex = 5;
            this.txtBaudeRate.Text = "250000";
            this.txtBaudeRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtBaudeRate_Validating);
            this.txtBaudeRate.Validated += new System.EventHandler(this.txtBaudeRate_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stop bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Parity bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Baud rate";
            // 
            // txtTest
            // 
            this.txtTest.Location = new System.Drawing.Point(19, 336);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(192, 20);
            this.txtTest.TabIndex = 12;
            // 
            // btnSendTest
            // 
            this.btnSendTest.Location = new System.Drawing.Point(217, 333);
            this.btnSendTest.Name = "btnSendTest";
            this.btnSendTest.Size = new System.Drawing.Size(63, 23);
            this.btnSendTest.TabIndex = 13;
            this.btnSendTest.Text = "Send test";
            this.btnSendTest.UseVisualStyleBackColor = true;
            this.btnSendTest.Click += new System.EventHandler(this.btnSendTest_Click);
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(138, 36);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(121, 20);
            this.txtDataBits.TabIndex = 14;
            this.txtDataBits.Text = "8";
            this.txtDataBits.Validating += new System.ComponentModel.CancelEventHandler(this.txtDataBits_Validating);
            this.txtDataBits.Validated += new System.EventHandler(this.txtDataBits_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(184, 194);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 15;
            this.btnValidate.Text = "Valider";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(19, 228);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(192, 93);
            this.txtConsole.TabIndex = 16;
            // 
            // cmbStop
            // 
            this.cmbStop.DataSource = ((object)(resources.GetObject("cmbStop.DataSource")));
            this.cmbStop.DisplayMember = "Item1";
            this.cmbStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStop.FormattingEnabled = true;

            this.cmbStop.Location = new System.Drawing.Point(138, 116);
            this.cmbStop.Name = "cmbStop";
            this.cmbStop.Size = new System.Drawing.Size(121, 21);
            this.cmbStop.TabIndex = 18;
            // 
            // cmbParity
            // 
            this.cmbParity.DataSource = ((object)(resources.GetObject("cmbParity.DataSource")));
            this.cmbParity.DisplayMember = "Item1";
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;

            this.cmbParity.Location = new System.Drawing.Point(138, 89);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(121, 21);
            this.cmbParity.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Handshake";
            // 
            // cmbHandshake
            // 
            this.cmbHandshake.DataSource = ((object)(resources.GetObject("cmbHandshake.DataSource")));
            this.cmbHandshake.DisplayMember = "Item1";
            this.cmbHandshake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHandshake.FormattingEnabled = true;

            this.cmbHandshake.Location = new System.Drawing.Point(138, 144);
            this.cmbHandshake.Name = "cmbHandshake";
            this.cmbHandshake.Size = new System.Drawing.Size(121, 21);
            this.cmbHandshake.TabIndex = 21;
            // 
            // cbRtsEnable
            // 
            this.cbRtsEnable.AutoSize = true;
            this.cbRtsEnable.Location = new System.Drawing.Point(179, 171);
            this.cbRtsEnable.Name = "cbRtsEnable";
            this.cbRtsEnable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbRtsEnable.Size = new System.Drawing.Size(32, 17);
            this.cbRtsEnable.TabIndex = 23;
            this.cbRtsEnable.Text = "  ";
            this.cbRtsEnable.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Location = new System.Drawing.Point(48, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Rts enable    ";
            // 
            // optionCustomSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbRtsEnable);
            this.Controls.Add(this.cmbHandshake);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbParity);
            this.Controls.Add(this.cmbStop);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.btnSendTest);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBaudeRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPortName);
            this.Name = "optionCustomSerial";
            this.Size = new System.Drawing.Size(303, 380);
            this.Tag = "Custom";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaudeRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnSendTest;
        private System.Windows.Forms.TextBox txtDataBits;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtConsole;
        private Utils.stopBitComboBox cmbStop;
        private Utils.parityBitComboBox cmbParity;
        private System.Windows.Forms.Label label1;
        private Utils.handshakeComboBox cmbHandshake;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbRtsEnable;
    }
}
