namespace BioBotApp.Controls.Option.Options
{
    partial class namedComboBox
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
            this.txtInputName = new System.Windows.Forms.Label();
            this.cbData = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtInputName
            // 
            this.txtInputName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtInputName.Location = new System.Drawing.Point(6, 6);
            this.txtInputName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(179, 27);
            this.txtInputName.TabIndex = 2;
            this.txtInputName.Text = "InputName";
            this.txtInputName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbData
            // 
            this.cbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(185, 6);
            this.cbData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(298, 28);
            this.cbData.TabIndex = 3;
            // 
            // namedComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbData);
            this.Controls.Add(this.txtInputName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "namedComboBox";
            this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Size = new System.Drawing.Size(489, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label txtInputName;
        private System.Windows.Forms.ComboBox cbData;
    }
}
