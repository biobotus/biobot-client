namespace BioBotApp.Controls.Option
{
    partial class frmOptions
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
<<<<<<< HEAD
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Action types");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Action value types");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Module types");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Module types action types");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Labware types labware parameters");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Labware types");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Labware parameter types");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Database", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Gcode Serial");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("serial -> can");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Communication", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Movements");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Protocol");
=======
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Action types");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Action value types");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Module types");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Module types action types");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Labware types labware parameters");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Labware types");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Labware parameter types");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Module type labware parameter type");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Database", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Gcode Serial");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("serial -> can");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Communication", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Movement");
>>>>>>> 963be7c05d1b56f36f540f7d91a3fbc651c0b05c
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlvOptions = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.dsModuleStructure = new BioBotApp.DataSets.dsModuleStructure2();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlvOptions);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
<<<<<<< HEAD
            this.panel1.Size = new System.Drawing.Size(150, 352);
=======
            this.panel1.Size = new System.Drawing.Size(225, 395);
>>>>>>> 963be7c05d1b56f36f540f7d91a3fbc651c0b05c
            this.panel1.TabIndex = 0;
            // 
            // tlvOptions
            // 
            this.tlvOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlvOptions.Location = new System.Drawing.Point(0, 0);
            this.tlvOptions.Margin = new System.Windows.Forms.Padding(2);
            this.tlvOptions.Name = "tlvOptions";
<<<<<<< HEAD
            treeNode14.Name = "nodeActionTypes";
            treeNode14.Tag = "actionTypes";
            treeNode14.Text = "Action types";
            treeNode15.Name = "nodeActionValueTypes";
            treeNode15.Tag = "actionValueTypes";
            treeNode15.Text = "Action value types";
            treeNode16.Name = "nodeModuleTypes";
            treeNode16.Tag = "moduleType";
            treeNode16.Text = "Module types";
            treeNode17.Name = "nodeModuleTypesActionTypes";
            treeNode17.Tag = "moduleTypeActionType";
            treeNode17.Text = "Module types action types";
            treeNode18.Name = "nodeLabwareTypesLabwareParameterTypes";
            treeNode18.Text = "Labware types labware parameters";
            treeNode19.Name = "nodeLabwareTypes";
            treeNode19.Text = "Labware types";
            treeNode20.Name = "nodeLabwareParameterTypes";
            treeNode20.Text = "Labware parameter types";
            treeNode21.Name = "nodeDB";
            treeNode21.Text = "Database";
            treeNode22.Name = "nodeGCode";
            treeNode22.Text = "Gcode Serial";
            treeNode23.Name = "nodeCan";
            treeNode23.Text = "serial -> can";
            treeNode24.Name = "nodeCom";
            treeNode24.Text = "Communication";
            treeNode25.Name = "nodeMovement";
            treeNode25.Text = "Movements";
            treeNode26.Name = "nodeProtocol";
            treeNode26.Text = "Protocol";
            this.tlvOptions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode24,
            treeNode25,
            treeNode26});
            this.tlvOptions.Size = new System.Drawing.Size(150, 352);
=======
            treeNode1.Name = "nodeActionTypes";
            treeNode1.Tag = "actionTypes";
            treeNode1.Text = "Action types";
            treeNode2.Name = "nodeActionValueTypes";
            treeNode2.Tag = "actionValueTypes";
            treeNode2.Text = "Action value types";
            treeNode3.Name = "nodeModuleTypes";
            treeNode3.Tag = "moduleType";
            treeNode3.Text = "Module types";
            treeNode4.Name = "nodeModuleTypesActionTypes";
            treeNode4.Tag = "moduleTypeActionType";
            treeNode4.Text = "Module types action types";
            treeNode5.Name = "nodeLabwareTypesLabwareParameterTypes";
            treeNode5.Text = "Labware types labware parameters";
            treeNode6.Name = "nodeLabwareTypes";
            treeNode6.Text = "Labware types";
            treeNode7.Name = "nodeLabwareParameterTypes";
            treeNode7.Text = "Labware parameter types";
            treeNode8.Name = "nodeModuleTypeLabwareParameterType";
            treeNode8.Tag = "";
            treeNode8.Text = "Module type labware parameter type";
            treeNode9.Name = "nodeDB";
            treeNode9.Text = "Database";
            treeNode10.Name = "nodeGCode";
            treeNode10.Text = "Gcode Serial";
            treeNode11.Name = "nodeCan";
            treeNode11.Text = "serial -> can";
            treeNode12.Name = "nodeCom";
            treeNode12.Text = "Communication";
            treeNode13.Name = "nodeMovement";
            treeNode13.Text = "Movement";
            this.tlvOptions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode12,
            treeNode13});
            this.tlvOptions.Size = new System.Drawing.Size(225, 395);
>>>>>>> 963be7c05d1b56f36f540f7d91a3fbc651c0b05c
            this.tlvOptions.TabIndex = 0;
            this.tlvOptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tlvOptions_AfterSelect);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
<<<<<<< HEAD
            this.panel2.Location = new System.Drawing.Point(152, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 37);
=======
            this.panel2.Location = new System.Drawing.Point(228, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 58);
>>>>>>> 963be7c05d1b56f36f540f7d91a3fbc651c0b05c
            this.panel2.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
<<<<<<< HEAD
            this.lblTitle.Size = new System.Drawing.Size(452, 37);
=======
            this.lblTitle.Size = new System.Drawing.Size(534, 58);
>>>>>>> 963be7c05d1b56f36f540f7d91a3fbc651c0b05c
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
<<<<<<< HEAD
            this.mainPanel.Location = new System.Drawing.Point(152, 37);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(452, 281);
=======
            this.mainPanel.Location = new System.Drawing.Point(228, 58);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(534, 285);
>>>>>>> 963be7c05d1b56f36f540f7d91a3fbc651c0b05c
            this.mainPanel.TabIndex = 2;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // dsModuleStructure
            // 
            this.dsModuleStructure.DataSetName = "dsModuleStructure2";
            this.dsModuleStructure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitter1
            // 
<<<<<<< HEAD
            this.splitter1.Location = new System.Drawing.Point(150, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 352);
=======
            this.splitter1.Location = new System.Drawing.Point(225, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 395);
>>>>>>> 963be7c05d1b56f36f540f7d91a3fbc651c0b05c
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
<<<<<<< HEAD
            this.panel3.Location = new System.Drawing.Point(152, 318);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(452, 34);
=======
            this.panel3.Location = new System.Drawing.Point(228, 343);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(534, 52);
>>>>>>> 963be7c05d1b56f36f540f7d91a3fbc651c0b05c
            this.panel3.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
<<<<<<< HEAD
            this.btnClose.Location = new System.Drawing.Point(386, 5);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 24);
=======
            this.btnClose.Location = new System.Drawing.Point(436, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 38);
>>>>>>> 963be7c05d1b56f36f540f7d91a3fbc651c0b05c
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // frmOptions
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(604, 352);
=======
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 395);
>>>>>>> 963be7c05d1b56f36f540f7d91a3fbc651c0b05c
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmOptions";
            this.Text = "Options";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsModuleStructure)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tlvOptions;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel mainPanel;
        private DataSets.dsModuleStructure2 dsModuleStructure;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClose;
    }
}