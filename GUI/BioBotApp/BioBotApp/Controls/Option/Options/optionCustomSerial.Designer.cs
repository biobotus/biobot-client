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
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaudeRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.btnSendTest = new System.Windows.Forms.Button();
            this.txtDataBits = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnValidate = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.cbRtsEnable = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ctrlParity1 = new BioBotApp.Controls.Utils.ctrlParity();
            this.ctrlHandshake1 = new BioBotApp.Controls.Utils.ctrlHandshake();
            this.ctrlStopbit1 = new BioBotApp.Controls.Utils.ctrlStopbit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPortName
            // 
            this.cmbPortName.Location = new System.Drawing.Point(129, 3);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(129, 21);
            this.cmbPortName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port name";
            // 
            // txtBaudeRate
            // 
            this.txtBaudeRate.Location = new System.Drawing.Point(129, 58);
            this.txtBaudeRate.Name = "txtBaudeRate";
            this.txtBaudeRate.Size = new System.Drawing.Size(129, 20);
            this.txtBaudeRate.TabIndex = 5;
            this.txtBaudeRate.Text = "250000";
            this.txtBaudeRate.Validating += new System.ComponentModel.CancelEventHandler(this.txtBaudeRate_Validating);
            this.txtBaudeRate.Validated += new System.EventHandler(this.txtBaudeRate_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 61);
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
            this.txtDataBits.Location = new System.Drawing.Point(129, 32);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(129, 20);
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
            this.label7.Location = new System.Drawing.Point(45, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Rts enable    ";
            // 
            // ctrlParity1
            // 
            this.ctrlParity1.Location = new System.Drawing.Point(40, 111);
            this.ctrlParity1.Name = "ctrlParity1";
            this.ctrlParity1.selectedValue = System.IO.Ports.Parity.Even;
            this.ctrlParity1.Size = new System.Drawing.Size(218, 27);
            this.ctrlParity1.TabIndex = 26;
            // 
            // ctrlHandshake1
            // 
            this.ctrlHandshake1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ctrlHandshake1.Location = new System.Drawing.Point(39, 138);
            this.ctrlHandshake1.Name = "ctrlHandshake1";
            this.ctrlHandshake1.selectedValue = System.IO.Ports.Handshake.XOnXOff;
            this.ctrlHandshake1.Size = new System.Drawing.Size(219, 27);
            this.ctrlHandshake1.TabIndex = 25;
            // 
            // ctrlStopbit1
            // 
            this.ctrlStopbit1.Location = new System.Drawing.Point(38, 81);
            this.ctrlStopbit1.Name = "ctrlStopbit1";
            this.ctrlStopbit1.selectedValue = System.IO.Ports.StopBits.One;
            this.ctrlStopbit1.Size = new System.Drawing.Size(220, 24);
            this.ctrlStopbit1.TabIndex = 27;
            // 
            // optionCustomSerial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctrlStopbit1);
            this.Controls.Add(this.ctrlParity1);
            this.Controls.Add(this.ctrlHandshake1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbRtsEnable);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.btnSendTest);
            this.Controls.Add(this.txtTest);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTest;
        private System.Windows.Forms.Button btnSendTest;
        private System.Windows.Forms.TextBox txtDataBits;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbRtsEnable;
        private Utils.ctrlHandshake ctrlHandshake1;
        private Utils.ctrlParity ctrlParity1;
        private Utils.ctrlStopbit ctrlStopbit1;
    }
}
