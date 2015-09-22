using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Utils.Communication;

namespace BioBotApp.Controls.Option.Options
{
    public partial class optionProtocol : UserControl
    {
        public optionProtocol()
        {
            InitializeComponent();
        }
        public optionProtocol(DataSets.dsModuleStructure2 dsModuleStructure) : this()
        {

            this.dsModuleStructureGUI = dsModuleStructure;
            this.dtStepCompositeBindingSource.DataSource = dsModuleStructureGUI;
            this.bs_dtStepLeafBindingSource.DataSource = dsModuleStructureGUI;
            this.dtActionValueBindingSource.DataSource = dsModuleStructureGUI;
            this.dtModuleBindingSource.DataSource = dsModuleStructureGUI;
            this.ModuleStepComposite.DataMember = "dtModule_dtStepComposite";
            this.ModuleStepComposite.DataSource = dtModuleBindingSource;
            this.StepLeafStepComposite.DataMember = "dtStepComposite_dtStepLeaf";
            this.StepLeafStepComposite.DataSource = ModuleStepComposite;
            this.StepLeafActionValue.DataMember = "dtStepLeaf_dtActionValue";
            this.StepLeafActionValue.DataSource = StepLeafStepComposite;

        }
        private void dtModuleBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            //UpdateProtocolGrid();
            //UpdateStepGrid();
            //UpdateActionGrid();

        }
        private void dtStepCompositeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //UpdateProtocolGrid();
            //UpdateStepGrid();
            //UpdateActionGrid();

        }
        private void bs_dtStepLeafBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //UpdateProtocolGrid();
            //UpdateStepGrid();
            //UpdateActionGrid();

        }
        private void crudOptionsStep_AddClickHandler(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure2.dtStepCompositeRow ProtocolSelectedRow = getSelectedProtocolRow();

            abstractDialog dialog = new abstractDialog("Add Step", "For the " + ProtocolSelectedRow.description + " protocol");

            //ComboBox ProtocolID = new ComboBox();
            namedInputTextBox description = new namedInputTextBox("Description");

            //ProtocolID.DataSource = dsModuleStructureGUI.dtStepComposite;
            //ProtocolID.DisplayMember = "description";
            

            dialog.addNamedInputTextBox(description);
            //dialog.addControl(ProtocolID);
            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                DataSets.dsModuleStructure2.dtStepLeafRow row;
                row = dsModuleStructureGUI.dtStepLeaf.NewdtStepLeafRow();
                row.description = description.getInputTextValue();
                row.fk_step_composite = ProtocolSelectedRow.pk_id;
                dsModuleStructureGUI.dtStepLeaf.AdddtStepLeafRow(row);
                updateStepRow(row);
            }
        }

        private void crudOptionsStep_DeleteClickHandler(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure2.dtStepLeafRow row;
            row = getSelectedStepRow();

            DialogResult result = MessageBox.Show("Delete : " + row.description + " ?", "Delete action type ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.No)
                && row != null)
            {
                return;
            }

            row.Delete();
            updateStepRow(row);
        }

        private void crudOptionsStep_ModifyClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Action type", "Modify");
            DataSets.dsModuleStructure2.dtStepLeafRow row = getSelectedStepRow();

            if (row == null)
            {
                return;
            }

            namedInputTextBox description = new namedInputTextBox("Description", row.description);
            dialog.addNamedInputTextBox(description);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                row.description = description.getInputTextValue();
                updateStepRow(row);
            }
        }
        private void crudOptionsProto_AddClickHandler(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure2.dtModuleRow ModuleSelectedRow = getSelectedModuleRow();

            abstractDialog dialog = new abstractDialog("Add Protocol", "Add Protocol for the " + ModuleSelectedRow.pk_id + " module");

            //ComboBox ProtocolID = new ComboBox();
            namedInputTextBox description = new namedInputTextBox("Description");

            //ProtocolID.DataSource = dsModuleStructureGUI.dtStepComposite;
            //ProtocolID.DisplayMember = "description";


            dialog.addNamedInputTextBox(description);
            //dialog.addControl(ProtocolID);
            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                DataSets.dsModuleStructure2.dtStepCompositeRow row;
                row = dsModuleStructureGUI.dtStepComposite.NewdtStepCompositeRow();
                row.description = description.getInputTextValue();
                row.fk_module_id = ModuleSelectedRow.pk_id;
                dsModuleStructureGUI.dtStepComposite.AdddtStepCompositeRow(row);
                updateProtoRow(row);
            }
        }

        private void crudOptionsProto_DeleteClickHandler(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure2.dtStepLeafRow row;
            row = getSelectedStepRow();

            DialogResult result = MessageBox.Show("Delete : " + row.description + " ?", "Delete action type ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.No)
                && row != null)
            {
                return;
            }

            row.Delete();
            updateStepRow(row);
        }

        private void crudOptionsProto_ModifyClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Action type", "Modify");
            DataSets.dsModuleStructure2.dtStepLeafRow row = getSelectedStepRow();

            if (row == null)
            {
                return;
            }

            namedInputTextBox description = new namedInputTextBox("Description", row.description);
            dialog.addNamedInputTextBox(description);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                row.description = description.getInputTextValue();
                updateStepRow(row);
            }
        }
        private void crudOptionsAction_AddClickHandler(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure2.dtStepLeafRow StepSelectedRow = getSelectedStepRow();

            abstractDialog dialog = new abstractDialog("Add Protocol", "Add Protocol for the " + StepSelectedRow.description + " module");

            ComboBox ActionType = new ComboBox();
            ComboBox ActionValueType = new ComboBox();
            namedInputTextBox description = new namedInputTextBox("Description");

            ActionType.DataSource = dsModuleStructureGUI.dtActionType;
            ActionType.DisplayMember = "description";
            ActionType.Text = "Action Type";

            ActionValueType.DataSource = dsModuleStructureGUI.dtActionValueType;
            ActionValueType.DisplayMember = "description";
            ActionValueType.Text = "Action Value Type";


            dialog.addNamedInputTextBox(description);
            dialog.addControl(ActionType);
            dialog.addControl(ActionValueType);
            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                DataSets.dsModuleStructure2.dtActionValueRow row;
                row = dsModuleStructureGUI.dtActionValue.NewdtActionValueRow();
                row.description = description.getInputTextValue();
                row.fk_step_leaf_id = StepSelectedRow.pk_id;
                dsModuleStructureGUI.dtActionValue.AdddtActionValueRow(row);
                updateActionRow(row);
            }
        }

        private void crudOptionsAction_DeleteClickHandler(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure2.dtStepLeafRow row;
            row = getSelectedStepRow();

            DialogResult result = MessageBox.Show("Delete : " + row.description + " ?", "Delete action type ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.No)
                && row != null)
            {
                return;
            }

            row.Delete();
            updateStepRow(row);
        }

        private void crudOptionsAction_ModifyClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Action type", "Modify");
            DataSets.dsModuleStructure2.dtStepLeafRow row = getSelectedStepRow();

            if (row == null)
            {
                return;
            }

            namedInputTextBox description = new namedInputTextBox("Description", row.description);
            dialog.addNamedInputTextBox(description);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                row.description = description.getInputTextValue();
                updateStepRow(row);
            }
        }
        public DataSets.dsModuleStructure2.dtStepLeafRow getSelectedStepRow()
        {
            DataSets.dsModuleStructure2.dtStepLeafRow row;

            if (bs_dtStepLeafBindingSource.Current == null)
            {
                return null;
            }
            
            DataRowView rowView = StepLeafStepComposite.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure2.dtStepLeafRow;
            return row;
        }
        public DataSets.dsModuleStructure2.dtStepCompositeRow getSelectedProtocolRow()
        {
            DataSets.dsModuleStructure2.dtStepCompositeRow row;

            if (dtStepCompositeBindingSource.Current == null)
            {
                return null;
            }

            DataRowView rowView = dtStepCompositeBindingSource.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure2.dtStepCompositeRow;
            return row;
        }
        public DataSets.dsModuleStructure2.dtModuleRow getSelectedModuleRow()
        {
            DataSets.dsModuleStructure2.dtModuleRow row;

            if (dtModuleBindingSource.Current == null)
            {
                return null;
            }

            DataRowView rowView = dtModuleBindingSource.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure2.dtModuleRow;
            
            return row;
        }
        public void updateProtoRow(DataSets.dsModuleStructure2.dtStepCompositeRow updateRow)
        {
            try
            {
                taStepComposite.Update(updateRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid action type, try again !",
                    "Error !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsModuleStructureGUI.RejectChanges();
            }
        }
        public void updateStepRow(DataSets.dsModuleStructure2.dtStepLeafRow updateRow)
        {
            try
            {
                ta_StepLeaf.Update(updateRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid action type, try again !",
                    "Error !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsModuleStructureGUI.RejectChanges();
            }
        }
        public void updateActionRow(DataSets.dsModuleStructure2.dtActionValueRow updateRow)
        {
            try
            {
                taActionValue1.Update(updateRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid action type, try again !",
                    "Error !",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dsModuleStructureGUI.RejectChanges();
            }
        }


    }
}
