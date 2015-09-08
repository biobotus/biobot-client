using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBotApp.Controls.Option.Options
{
    public partial class optionModuleType : UserControl
    {
        public optionModuleType() 
        {
            InitializeComponent();
        }
        public optionModuleType(DataSets.dsModuleStructure2 dsModuleStructure)
            : this()
        {
            
            dsModuleStructureGUI = dsModuleStructure;
            bsModuleType.DataSource = dsModuleStructureGUI;
            if (this.dsModuleStructureGUI.dtModuleType.Count == 0)
            {
                taModuleType.Fill(this.dsModuleStructureGUI.dtModuleType);
            }
        }

        private void crudOptions_AddClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Module type", "Add");

            namedInputTextBox description = new namedInputTextBox("Description");
            dialog.addNamedInputTextBox(description);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                DataSets.dsModuleStructure2.dtModuleTypeRow row;

                row = dsModuleStructureGUI.dtModuleType.NewdtModuleTypeRow();
                row.description = description.getInputTextValue();
                dsModuleStructureGUI.dtModuleType.AdddtModuleTypeRow(row);
                updateRow(row);
            }
        }

        private void crudOptions_DeleteClickHandler(object sender, EventArgs e)
        {
            if(gvActionType.SelectedRows.Count == 0)
            {
                return;
            }

            DataSets.dsModuleStructure2.dtModuleTypeRow row;
            row = getSelectedRow();

            DialogResult result = MessageBox.Show( "Delete : " + row.description + " ?", "Delete action type ?", MessageBoxButtons.YesNo,
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
            DataSets.dsModuleStructure2.dtModuleTypeRow row = getSelectedRow();

            if(row == null)
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

        public DataSets.dsModuleStructure2.dtModuleTypeRow getSelectedRow()
        {
            DataSets.dsModuleStructure2.dtModuleTypeRow row;
            DataRowView rowView = bsModuleType.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure2.dtModuleTypeRow;
            return row;
        }

        public void updateRow(DataSets.dsModuleStructure2.dtModuleTypeRow updateRow)
        {
            try
            {
                taModuleType.Update(updateRow);
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
