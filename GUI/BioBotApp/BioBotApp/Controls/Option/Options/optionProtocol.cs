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
            bs_dtStepLeafBindingSource.DataSource = dsModuleStructureGUI;
            if (this.dsModuleStructureGUI.dtActionType.Count == 0)
            {
                ta_StepLeaf.Fill(this.dsModuleStructureGUI.dtStepLeaf);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void crudOptions_AddClickHandler(object sender, EventArgs e)
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

        private void crudOptions_DeleteClickHandler(object sender, EventArgs e)
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

        private void crudOptions_ModifyClickHandler(object sender, EventArgs e)
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
