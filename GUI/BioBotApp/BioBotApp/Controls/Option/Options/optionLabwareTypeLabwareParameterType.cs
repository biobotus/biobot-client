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
    public partial class optionLabwareTypeLabwareParameterType : UserControl
    {
        public optionLabwareTypeLabwareParameterType()
        {
            InitializeComponent();
        }

        public optionLabwareTypeLabwareParameterType(DataSets.dsModuleStructure2 dsModuleStructure)
            :this()
        {
            this.dsModuleStructureGUI = dsModuleStructure;
            this.bsLabwareType.DataSource = dsModuleStructureGUI;
            bsLabwareParameterType.DataSource = dsModuleStructureGUI;
            this.bsLabwareTypedtLabwareTypeLabwareParameterType.DataMember = "dtLabwareType_dtLabwareTypeLabwareParameterType";
            this.bsLabwareTypedtLabwareTypeLabwareParameterType.DataSource = this.bsLabwareType;
            /*
            this.dsLabwareStructureGUI = dtLabwareStructure;
            this.dsModuleStructureGUI = dsModuleStructure;

            bsLabwareType.DataSource = dsLabwareStructureGUI;
            bsLabwareTypeLabwareParameterType.DataSource = dsLabwareStructureGUI;

            if(dsLabwareStructureGUI.dtLabwareParameterType.Count == 0)
            {
                taLabwareParameterType.Fill(dsLabwareStructureGUI.dtLabwareParameterType);
            }

            if(dsLabwareStructureGUI.dtLabwareType.Count == 0)
            {
                taLabwareType.Fill(dsLabwareStructureGUI.dtLabwareType);
            }
             * */
        }

        private void bsLabwareType_CurrentChanged(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure2.dtLabwareTypeRow row = getSelectedLabwareTypeRow();
            if(row == null)
            {
                return;
            }
            
        }

        public DataSets.dsModuleStructure2.dtLabwareTypeRow getSelectedLabwareTypeRow()
        {
            DataSets.dsModuleStructure2.dtLabwareTypeRow row;

            if (bsLabwareType.Current == null)
            {
                return null;
            }

            DataRowView rowView = bsLabwareType.Current as DataRowView;
            row = rowView.Row as DataSets.dsModuleStructure2.dtLabwareTypeRow;
            return row;
        }

        private void crudOptions_AddClickHandler(object sender, EventArgs e)
        {
            /*
            DataSets.dsModuleStructure2.dtLabwareTypeLabwareParameterTypeRow labwareParameterType =
                dsModuleStructureGUI.dtLabwareTypeLabwareParameterType.NewdtLabwareTypeLabwareParameterTypeRow();
            DataSets.dsModuleStructure2.dtLabwareTypeRow labwareRow = getSelectedLabwareTypeRow();
            */

            abstractDialog dialog = new abstractDialog("Action type", "Add");

            namedInputTextBox description = new namedInputTextBox("Description: ");
            dialog.addNamedInputTextBox(description);

            namedComboBox cbActionValueTupe = new namedComboBox("Labware parameter: ");

            cbActionValueTupe.getComboBox().DataSource = bsLabwareParameterType;
            cbActionValueTupe.getComboBox().DisplayMember = "description";

            dialog.addControl(cbActionValueTupe);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                DataSets.dsModuleStructure2.dtActionTypeRow row;

                row = dsModuleStructureGUI.dtActionType.NewdtActionTypeRow();
                row.description = description.getInputTextValue();
                dsModuleStructureGUI.dtActionType.AdddtActionTypeRow(row);
                //updateRow(row);
            }


        }

    }
}
