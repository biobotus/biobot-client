namespace BioBotApp.Controls.Option.Options
{
    partial class optionTAC
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.crudOptions1 = new BioBotApp.Controls.Utils.crudOptions();
            this.bs_dtStepLeafBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsModuleStructureGUI = new BioBotApp.DataSets.dsModuleStructure2();
            this.ta_StepLeaf = new BioBotApp.DataSets.dsModuleStructure2TableAdapters.taStepLeaf();
            this.pkidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_step_composite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_dtStepLeafBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.crudOptions1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAC";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkidDataGridViewTextBoxColumn,
            this.fk_step_composite,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bs_dtStepLeafBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 69);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(321, 144);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "tac";
            // 
            // crudOptions1
            // 
            this.crudOptions1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crudOptions1.ButtonRefreshVisible = false;
            this.crudOptions1.LayoutLeftToRight = System.Windows.Forms.FlowDirection.RightToLeft;
            this.crudOptions1.Location = new System.Drawing.Point(207, 12);
            this.crudOptions1.MinimumSize = new System.Drawing.Size(37, 37);
            this.crudOptions1.Name = "crudOptions1";
            this.crudOptions1.Size = new System.Drawing.Size(118, 41);
            this.crudOptions1.TabIndex = 0;
            this.crudOptions1.AddClickHandler += new System.EventHandler(this.crudOptions_AddClickHandler);
            this.crudOptions1.DeleteClickHandler += new System.EventHandler(this.crudOptions_DeleteClickHandler);
            this.crudOptions1.ModifyClickHandler += new System.EventHandler(this.crudOptions_ModifyClickHandler);
            // 
            // bs_dtStepLeafBindingSource
            // 
            this.bs_dtStepLeafBindingSource.DataMember = "dtStepLeaf";
            this.bs_dtStepLeafBindingSource.DataSource = this.dsModuleStructureGUI;
            // 
            // dsModuleStructureGUI
            // 
            this.dsModuleStructureGUI.DataSetName = "dsModuleStructure2";
            this.dsModuleStructureGUI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ta_StepLeaf
            // 
            this.ta_StepLeaf.ClearBeforeFill = true;
            // 
            // pkidDataGridViewTextBoxColumn
            // 
            this.pkidDataGridViewTextBoxColumn.DataPropertyName = "pk_id";
            this.pkidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pkidDataGridViewTextBoxColumn.Name = "pkidDataGridViewTextBoxColumn";
            this.pkidDataGridViewTextBoxColumn.ReadOnly = true;
            this.pkidDataGridViewTextBoxColumn.Width = 50;
            // 
            // fk_step_composite
            // 
            this.fk_step_composite.DataPropertyName = "fk_step_composite";
            this.fk_step_composite.HeaderText = "Protocol";
            this.fk_step_composite.Name = "fk_step_composite";
            this.fk_step_composite.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optionTAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "optionTAC";
            this.Size = new System.Drawing.Size(330, 219);
            this.Tag = "TAC";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_dtStepLeafBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructureGUI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Utils.crudOptions crudOptions1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bs_dtStepLeafBindingSource;
        private DataSets.dsModuleStructure2 dsModuleStructureGUI;
        private DataSets.dsModuleStructure2TableAdapters.taStepLeaf ta_StepLeaf;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_step_composite;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}
