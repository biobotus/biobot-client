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

            dsModuleStructureGUI = dsModuleStructure;
            dtStepCompositeBindingSource.DataSource = dsModuleStructureGUI.dtStepComposite;
            bs_dtStepLeafBindingSource.DataSource = dsModuleStructureGUI.dtStepLeaf;



        }
        private void dtStepCompositeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            UpdateStepGrid();

        }
        public void UpdateStepGrid()
        {

            DataSets.dsModuleStructure2.dtStepCompositeRow row = getSelectedCompositeRow();
            if (row == null)
            {
                dsModuleStructureGUI.dtStepLeaf.DefaultView.RowFilter = String.Empty;
                return;
            }
            dsModuleStructureGUI.dtStepLeaf.DefaultView.RowFilter = "fk_step_composite = " + row.pk_id;

        }
        public DataSets.dsModuleStructure2.dtStepCompositeRow getSelectedCompositeRow()
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
                updateRow(row);
            }
        }

        private void crudOptionsStep_DeleteClickHandler(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure2.dtStepLeafRow row;
            row = getSelectedRow();

            DialogResult result = MessageBox.Show("Delete : " + row.description + " ?", "Delete action type ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.No)
                && row != null)
            {
                return;
            }

            row.Delete();
            updateRow(row);
        }

        private void crudOptionsStep_ModifyClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Action type", "Modify");
            DataSets.dsModuleStructure2.dtStepLeafRow row = getSelectedRow();

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
                updateRow(row);
            }
        }
        private void crudOptionsProto_AddClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Action type", "Add");

            namedInputTextBox description = new namedInputTextBox("Description");
            dialog.addNamedInputTextBox(description);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                DataSets.dsModuleStructure2.dtStepLeafRow row;
                row = dsModuleStructureGUI.dtStepLeaf.NewdtStepLeafRow();
                row.description = description.getInputTextValue();
                dsModuleStructureGUI.dtStepLeaf.AdddtStepLeafRow(row);
                updateRow(row);
            }
        }

        private void crudOptionsProto_DeleteClickHandler(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure2.dtStepLeafRow row;
            row = getSelectedRow();

            DialogResult result = MessageBox.Show("Delete : " + row.description + " ?", "Delete action type ?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result.Equals(DialogResult.No)
                && row != null)
            {
                return;
            }

            row.Delete();
            updateRow(row);
        }

        private void crudOptionsProto_ModifyClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Action type", "Modify");
            DataSets.dsModuleStructure2.dtStepLeafRow row = getSelectedRow();

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
                updateRow(row);
            }
        }
        public DataSets.dsModuleStructure2.dtStepLeafRow getSelectedRow()
        {
            DataSets.dsModuleStructure2.dtStepLeafRow row;
            DataRowView rowView = bs_dtStepLeafBindingSource.Current as DataRowView;
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
        public void updateRow(DataSets.dsModuleStructure2.dtStepLeafRow updateRow)
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
    }
}
