using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Controls.Steps;
using BioBotApp.Controls.Parameter_controls;

namespace BioBotApp.Controls.Steps
{
    public partial class ctrlStepsView : UserControl
    {
        //Node types
        private const String PROTOCOL_TYPE = "Protocol";
        private const String STEP_TYPE = "Step";

        //Context menu for the Protocol add type
        private ContextMenuStrip _contextMenuAutoFill;
        //List that contains protocol types
        List<String> _protocolAddType = new List<string>(new String[] { PROTOCOL_TYPE, STEP_TYPE });

        //Project's dataset
        DataSets.dsModuleStructure2 _dsModuleStructure;

        //Project's module_type binding source
        BindingSource _bsModuleType;

        public ctrlStepsView()
        {
            InitializeComponent();
            CreateContextMenuStrip();
        }

        public void initControl(DataSets.dsModuleStructure2 dsModuleStructure, BindingSource bsModuleType)
        {
            _dsModuleStructure = dsModuleStructure;
            _bsModuleType = bsModuleType;
            _bsModuleType.CurrentChanged += _bsModuleType_CurrentChanged;
        }

        void _bsModuleType_CurrentChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Changed !!!");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.ContextMenuStrip = _contextMenuAutoFill;
            btnAdd.ContextMenuStrip.Show(btnAdd, new System.Drawing.Point(0, btnAdd.Height));
        }

        private void CreateContextMenuStrip()
        {
            _contextMenuAutoFill = new ContextMenuStrip();
            _contextMenuAutoFill.Items.Add(PROTOCOL_TYPE);
            _contextMenuAutoFill.Items.Add(STEP_TYPE);

            foreach (ToolStripMenuItem mItem in _contextMenuAutoFill.Items)
            {
                mItem.Click += new System.EventHandler(this.AutoFillToolStripMenuItem_Click);
            }
        }

        private void AutoFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String protocolType = ((ToolStripMenuItem)sender).Text;
            //dialog result for adding new node to treeview
            DialogResult dialogResultAddNode = DialogResult.Cancel;
            frmNewProtocol frmStepAdd;
            frmNewStep frmNewStep;
            DataSets.dsModuleStructure2.dtStepLeafRow stepLeafRow = null;
            String treeNodeText = String.Empty;

            TreeNodeProtocolType treeNode = new TreeNodeProtocolType();

            switch (protocolType)
            {
                case PROTOCOL_TYPE:
                    frmStepAdd = new frmNewProtocol();
                    dialogResultAddNode = frmStepAdd.ShowDialog();
                    if (dialogResultAddNode == DialogResult.OK)
                    {
                        treeNodeText = frmStepAdd.getStepName();
                    }

                    break;
                case STEP_TYPE:
                    DataSets.dsModuleStructure2.dtModuleRow moduleRow = getSelectedModuleRow();

                    if (moduleRow == null)
                    {
                        break;
                    }

                    String headerTitle = moduleRow.pk_id;
                    DataSets.dsModuleStructure2.dtActionTypeDataTable actionTypeTable =
                        new DataSets.dsModuleStructure2.dtActionTypeDataTable();



                    foreach (DataSets.dsModuleStructure2.dtModuleTypeActionTypeRow moduleTypeActionTypeRow in _dsModuleStructure.dtModuleTypeActionType)
                    {
                        if (moduleTypeActionTypeRow.fk_module_type_id.Equals(moduleRow.fk_module_type))
                        {
                            DataSets.dsModuleStructure2.dtActionTypeRow row = _dsModuleStructure.dtActionType.FindBypk_id(moduleTypeActionTypeRow.fk_action_type_id);
                            actionTypeTable.LoadDataRow(row.ItemArray, true);
                        }
                    }

                    frmNewStep = new frmNewStep(_dsModuleStructure, moduleRow);

                    dialogResultAddNode = frmNewStep.ShowDialog();
                    if (dialogResultAddNode.Equals(DialogResult.OK))
                    {
                        treeNodeText = frmNewStep.getSteapLeafRow().description;
                        stepLeafRow = frmNewStep.getSteapLeafRow();
                    }

                    break;
                default:
                    break;
            }
            if (dialogResultAddNode.Equals(DialogResult.OK))
            {
                treeNode.setNodeType(protocolType);
                treeNode.setText(treeNodeText);
                if (stepLeafRow != null)
                {
                    treeNode.setStepValue(stepLeafRow);
                }

                if (tlvSteps.SelectedNode != null)
                {
                    tlvSteps.SelectedNode.Nodes.Add(treeNode);
                }
                else
                {
                    tlvSteps.Nodes.Add(treeNode);
                }
            }

        }

        public void setSelectedModule(DataSets.dsModuleStructure2.dtModuleTypeRow moduleTypeRow, DataSets.dsModuleStructure2.dtActionTypeDataTable dtActionType)
        {
            btnAdd.Enabled = (!String.IsNullOrEmpty(moduleTypeRow.description) && dtActionType.Rows.Count > 0);
            btnDelete.Enabled = (!String.IsNullOrEmpty(moduleTypeRow.description) && dtActionType.Rows.Count > 0);
            //_contextMenuAutoFill.Items[STEP_TYPE].Enabled = (!String.IsNullOrEmpty(moduleTypeRow.Description) && dtActionType.Rows.Count > 0);
        }

        public DataSets.dsModuleStructure2.dtModuleRow getSelectedModuleRow()
        {
            if (_bsModuleType.Current == null)
            {
                return null;
            }
            DataRowView rowView = _bsModuleType.Current as DataRowView;
            DataSets.dsModuleStructure2.dtModuleRow moduleRow = rowView.Row
                as DataSets.dsModuleStructure2.dtModuleRow;

            return moduleRow;
        }

        #region JSON converter Section
        public String getJSON()
        {
            String jsonValue = String.Empty;
            foreach (TreeNodeProtocolType treeNodeChilds in tlvSteps.Nodes)
            {
                if (treeNodeChilds.getNodeType().Equals(PROTOCOL_TYPE))
                {
                    jsonValue += getNodeStepValues(treeNodeChilds);
                }

            }

            return jsonValue;
        }

        public String getNodeStepValues(TreeNodeProtocolType treeNode)
        {
            String jsonValue = String.Empty;
            foreach (TreeNodeProtocolType treeNodeChilds in treeNode.Nodes)
            {
                if (treeNodeChilds.getNodeType().Equals(PROTOCOL_TYPE))
                {
                    jsonValue += getNodeStepValues(treeNodeChilds);
                }
                else
                {
                    jsonValue += treeNodeChilds.getStepValue().description;
                }

            }

            return jsonValue;
        }
        #endregion
    }
}
