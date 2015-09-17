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
            this.bsLabwareParameterType.DataSource = dsModuleStructureGUI;
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

    }
}
