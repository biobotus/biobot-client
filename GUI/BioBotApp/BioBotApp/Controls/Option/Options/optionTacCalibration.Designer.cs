namespace BioBotApp.Controls.Option.Options
{
    partial class optionTacCalibration
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
            this.crudOptions1 = new BioBotApp.Controls.Utils.crudOptions();
            this.btnValidation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbTacSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // crudOptions1
            // 
            this.crudOptions1.ButtonRefreshVisible = false;
            this.crudOptions1.Dock = System.Windows.Forms.DockStyle.Top;
            this.crudOptions1.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptions1.Location = new System.Drawing.Point(0, 0);
            this.crudOptions1.MinimumSize = new System.Drawing.Size(37, 37);
            this.crudOptions1.Name = "crudOptions1";
            this.crudOptions1.Size = new System.Drawing.Size(347, 37);
            this.crudOptions1.TabIndex = 0;
            // 
            // btnValidation
            // 
            this.btnValidation.Location = new System.Drawing.Point(164, 3);
            this.btnValidation.Name = "btnValidation";
            this.btnValidation.Size = new System.Drawing.Size(67, 31);
            this.btnValidation.TabIndex = 0;
            this.btnValidation.Text = "validate";
            this.btnValidation.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 256);
            this.dataGridView1.TabIndex = 2;
            // 
            // cmbTacSelector
            // 
            this.cmbTacSelector.FormattingEnabled = true;
            this.cmbTacSelector.Location = new System.Drawing.Point(12, 10);
            this.cmbTacSelector.Name = "cmbTacSelector";
            this.cmbTacSelector.Size = new System.Drawing.Size(146, 21);
            this.cmbTacSelector.TabIndex = 3;
            // 
            // optionTacCalibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnValidation);
            this.Controls.Add(this.cmbTacSelector);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.crudOptions1);
            this.Name = "optionTacCalibration";
            this.Size = new System.Drawing.Size(347, 293);
            this.Tag = "Tac calibration";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.crudOptions crudOptions1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnValidation;
        private System.Windows.Forms.ComboBox cmbTacSelector;
    }
}
