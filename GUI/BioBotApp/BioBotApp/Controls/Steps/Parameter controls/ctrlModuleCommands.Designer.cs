namespace BioBotApp.Controls.Parameter_controls
{
    partial class ctrlModuleParameters
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.edtStepName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModuleName = new System.Windows.Forms.Label();
            this.layoutButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.layoutModuleParametersStart = new System.Windows.Forms.FlowLayoutPanel();
            this.layoutModuleParametersStop = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dsModuleStructure = new BioBotApp.DataSets.dsModuleStructure2();
            label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.layoutButtons.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(0, 0);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(420, 28);
            label2.TabIndex = 0;
            label2.Text = "Stop commands";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtModuleName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 79);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.edtStepName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(849, 31);
            this.panel4.TabIndex = 1;
            // 
            // edtStepName
            // 
            this.edtStepName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtStepName.Location = new System.Drawing.Point(91, 4);
            this.edtStepName.Margin = new System.Windows.Forms.Padding(4);
            this.edtStepName.MaximumSize = new System.Drawing.Size(399, 25);
            this.edtStepName.Name = "edtStepName";
            this.edtStepName.Size = new System.Drawing.Size(399, 22);
            this.edtStepName.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Step name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtModuleName
            // 
            this.txtModuleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModuleName.Location = new System.Drawing.Point(0, 0);
            this.txtModuleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtModuleName.Name = "txtModuleName";
            this.txtModuleName.Size = new System.Drawing.Size(849, 44);
            this.txtModuleName.TabIndex = 0;
            this.txtModuleName.Text = "ModuleName";
            this.txtModuleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutButtons
            // 
            this.layoutButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.layoutButtons.Controls.Add(this.btnApply);
            this.layoutButtons.Controls.Add(this.btnCancel);
            this.layoutButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layoutButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.layoutButtons.Location = new System.Drawing.Point(0, 375);
            this.layoutButtons.Margin = new System.Windows.Forms.Padding(4);
            this.layoutButtons.MinimumSize = new System.Drawing.Size(4, 30);
            this.layoutButtons.Name = "layoutButtons";
            this.layoutButtons.Size = new System.Drawing.Size(853, 37);
            this.layoutButtons.TabIndex = 2;
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(745, 4);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 28);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(637, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // layoutModuleParametersStart
            // 
            this.layoutModuleParametersStart.AutoScroll = true;
            this.layoutModuleParametersStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutModuleParametersStart.Location = new System.Drawing.Point(0, 28);
            this.layoutModuleParametersStart.Margin = new System.Windows.Forms.Padding(4);
            this.layoutModuleParametersStart.Name = "layoutModuleParametersStart";
            this.layoutModuleParametersStart.Size = new System.Drawing.Size(420, 264);
            this.layoutModuleParametersStart.TabIndex = 3;
            // 
            // layoutModuleParametersStop
            // 
            this.layoutModuleParametersStop.AutoScroll = true;
            this.layoutModuleParametersStop.AutoSize = true;
            this.layoutModuleParametersStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutModuleParametersStop.Location = new System.Drawing.Point(0, 31);
            this.layoutModuleParametersStop.Margin = new System.Windows.Forms.Padding(4);
            this.layoutModuleParametersStop.Name = "layoutModuleParametersStop";
            this.layoutModuleParametersStop.Size = new System.Drawing.Size(421, 261);
            this.layoutModuleParametersStop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start commands";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.layoutModuleParametersStop);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 296);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.layoutModuleParametersStart);
            this.panel3.Controls.Add(label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(429, 79);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 296);
            this.panel3.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(425, 79);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 296);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // dsModuleStructure
            // 
            this.dsModuleStructure.DataSetName = "dsModuleStructure2";
            this.dsModuleStructure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ctrlModuleParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.layoutButtons);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlModuleParameters";
            this.Size = new System.Drawing.Size(853, 412);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.layoutButtons.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtModuleName;
        private System.Windows.Forms.FlowLayoutPanel layoutButtons;
        private System.Windows.Forms.FlowLayoutPanel layoutModuleParametersStart;
        private System.Windows.Forms.FlowLayoutPanel layoutModuleParametersStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox edtStepName;
        private System.Windows.Forms.Label label3;
        private DataSets.dsModuleStructure2 dsModuleStructure;
    }
}
