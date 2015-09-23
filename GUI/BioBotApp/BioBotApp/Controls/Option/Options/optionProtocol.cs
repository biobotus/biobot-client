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
            this.dtActionTypeBindingSource.DataSource = dsModuleStructureGUI;
            this.dtActionValueTypeBindingSource.DataSource = dsModuleStructureGUI;
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

            DialogResult result = MessageBox.Show("Delete : " + row.description + " ?", "Delete Step ?", MessageBoxButtons.YesNo,
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
            abstractDialog dialog = new abstractDialog("Steps", "Modify");
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
            namedInputTextBox description = new namedInputTextBox("Protocol Name");

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
            if (dataGridView2.SelectedRows.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure2.dtStepCompositeRow row;
            row = getSelectedProtocolRow();

            DialogResult result = MessageBox.Show("Delete : " + row.description + " ?", "Delete protocol ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.No)
                && row != null)
            {
                return;
            }

            row.Delete();
            updateProtoRow(row);
        }

        private void crudOptionsProto_ModifyClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Protocol", "Modify");
            DataSets.dsModuleStructure2.dtStepCompositeRow row = getSelectedProtocolRow();

            if (row == null)
            {
                return;
            }

            namedInputTextBox description = new namedInputTextBox("Protocol Name", row.description);
            dialog.addNamedInputTextBox(description);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                row.description = description.getInputTextValue();
                updateProtoRow(row);
            }
        }
        private void crudOptionsAction_AddClickHandler(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure2.dtStepLeafRow StepSelectedRow = getSelectedStepRow();
            if (StepSelectedRow == null)
            {
                return;
            }

            abstractDialog dialog = new abstractDialog("Add Protocol", "Add Protocol for the " + StepSelectedRow.description + " module");

            ComboBox ActionType = new ComboBox();
            //ActionType.Location = new System.Drawing.Point(0,20);
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

            DataSets.dsModuleStructure2.dtActionTypeRow Actionrow;
            DataRowView ActionCombo = ActionType.SelectedItem as DataRowView;
            Actionrow = ActionCombo.Row as DataSets.dsModuleStructure2.dtActionTypeRow;

            DataSets.dsModuleStructure2.dtActionValueTypeRow ActionValueTyperow;
            DataRowView ActionValueTypecombo = ActionValueType.SelectedItem as DataRowView;
            ActionValueTyperow = ActionValueTypecombo.Row as DataSets.dsModuleStructure2.dtActionValueTypeRow;

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                DataSets.dsModuleStructure2.dtActionValueRow row;
                row = dsModuleStructureGUI.dtActionValue.NewdtActionValueRow();
                row.description = description.getInputTextValue();
                row.fk_step_leaf_id = StepSelectedRow.pk_id;
                row.fk_action_type = Actionrow.pk_id;
                row.fk_action_value_type = ActionValueTyperow.pk_id;
                dsModuleStructureGUI.dtActionValue.AdddtActionValueRow(row);
                updateActionRow(row);
            }
        }
        private void crudOptionsAction_DeleteClickHandler(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure2.dtActionValueRow row;
            row = getSelectedActionRow();

            DialogResult result = MessageBox.Show("Delete : " + row.description + " ?", "Delete action type ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.No)
                && row != null)
            {
                return;
            }

            row.Delete();
            updateActionRow(row);
        }

        private void crudOptionsAction_ModifyClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Action type", "Modify");

            DataSets.dsModuleStructure2.dtActionValueRow row = getSelectedActionRow();
            if (row == null)
            {
                return;
            }
            namedInputTextBox description = new namedInputTextBox("Description", row.description);
            namedComboBox ActionType = new namedComboBox("Action Type: ");
            namedComboBox ActionValueType = new namedComboBox("Action Value Type: ");
 
            ActionType.Text = "Action Type";
            ActionType.getComboBox().DataSource = dsModuleStructureGUI.dtActionType;
            ActionType.getComboBox().ValueMember = "pk_id";
            ActionType.getComboBox().DisplayMember = "description";
            ActionType.getComboBox().SelectedValue = row.fk_action_type;

            ActionValueType.Text = "Action Value Type";
            ActionValueType.getComboBox().DataSource = dsModuleStructureGUI.dtActionValueType;
            ActionValueType.getComboBox().ValueMember = "pk_id";
            ActionValueType.getComboBox().DisplayMember = "description";
            ActionValueType.getComboBox().SelectedValue = row.fk_action_value_type;

            dialog.addNamedInputTextBox(description);
            dialog.addControl(ActionType);
            dialog.addControl(ActionValueType);

            dialog.ShowDialog();

            DataSets.dsModuleStructure2.dtActionTypeRow Actionrow;
            DataRowView ActionCombo = ActionType.getComboBox().SelectedItem as DataRowView;
            Actionrow = ActionCombo.Row as DataSets.dsModuleStructure2.dtActionTypeRow;

            DataSets.dsModuleStructure2.dtActionValueTypeRow ActionValueTyperow;
            DataRowView ActionValueTypecombo = ActionValueType.getComboBox().SelectedItem as DataRowView;
            ActionValueTyperow = ActionValueTypecombo.Row as DataSets.dsModuleStructure2.dtActionValueTypeRow;

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                row.description = description.getInputTextValue();
                row.fk_action_type = Actionrow.pk_id;
                row.fk_action_value_type = ActionValueTyperow.pk_id;
                updateActionRow(row);
            }
        }
        public DataSets.dsModuleStructure2.dtActionValueRow getSelectedActionRow()
        {
            DataSets.dsModuleStructure2.dtActionValueRow row;

            if (StepLeafActionValue.Current == null)
            {
                return null;
            }

            DataRowView rowView = StepLeafActionValue.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure2.dtActionValueRow;
            return row;
        }
        public DataSets.dsModuleStructure2.dtStepLeafRow getSelectedStepRow()
        {
            DataSets.dsModuleStructure2.dtStepLeafRow row;

            if (StepLeafStepComposite.Current == null)
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

            if (ModuleStepComposite.Current == null)
            {
                return null;
            }

            DataRowView rowView = ModuleStepComposite.Current as DataRowView;
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.taActionValue1.Fill(this.dsModuleStructureGUI.dtActionValue);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
