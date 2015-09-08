using BioBotApp.Controls.Parameter_controls;
namespace BioBotApp.Controls.Steps
{
    partial class frmNewStep
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
            this.moduleParameters = new BioBotApp.Controls.Parameter_controls.ctrlModuleParameters();
            this.SuspendLayout();
            // 
            // moduleParameters
            // 
            this.moduleParameters.AutoSize = true;
            this.moduleParameters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.moduleParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moduleParameters.Location = new System.Drawing.Point(0, 0);
            this.moduleParameters.Name = "moduleParameters";
            this.moduleParameters.Size = new System.Drawing.Size(693, 261);
            this.moduleParameters.TabIndex = 0;
            // 
            // frmStep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 261);
            this.Controls.Add(this.moduleParameters);
            this.Name = "frmStep";
            this.Text = "Step";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlModuleParameters moduleParameters;
    }
}