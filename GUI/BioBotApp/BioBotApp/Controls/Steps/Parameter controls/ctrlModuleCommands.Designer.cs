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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.edtStepName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModuleName = new System.Windows.Forms.Label();
            this.layoutButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dsModuleStructure = new BioBotApp.DataSets.dsModuleStructure2();
            this.layoutMainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.layoutButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).BeginInit();
            this.SuspendLayout();
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
            // dsModuleStructure
            // 
            this.dsModuleStructure.DataSetName = "dsModuleStructure2";
            this.dsModuleStructure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutMainPanel
            // 
            this.layoutMainPanel.AutoScroll = true;
            this.layoutMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMainPanel.Location = new System.Drawing.Point(0, 79);
            this.layoutMainPanel.Name = "layoutMainPanel";
            this.layoutMainPanel.Size = new System.Drawing.Size(853, 296);
            this.layoutMainPanel.TabIndex = 6;
            // 
            // ctrlModuleParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.layoutMainPanel);
            this.Controls.Add(this.layoutButtons);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ctrlModuleParameters";
            this.Size = new System.Drawing.Size(853, 412);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.layoutButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtModuleName;
        private System.Windows.Forms.FlowLayoutPanel layoutButtons;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox edtStepName;
        private System.Windows.Forms.Label label3;
        private DataSets.dsModuleStructure2 dsModuleStructure;
        private System.Windows.Forms.FlowLayoutPanel layoutMainPanel;
    }
}
