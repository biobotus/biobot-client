using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Controls.Parameter_control;

namespace BioBotApp.Controls.Parameter_controls
{
    public partial class ctrlModuleParameters : UserControl
    {
        DataSets.dsModuleStructure2 _dsModuleStructure;
        DataSets.dsModuleStructure2.dtModuleRow _moduleRow;
        List<ParameterActions> _moduleParametersStop = new List<ParameterActions>();
        List<ParameterActions> _moduleParametersStart = new List<ParameterActions>();

        public ctrlModuleParameters()
        {
            InitializeComponent();
        }

        public ctrlModuleParameters(DataSets.dsModuleStructure2.dtModuleRow moduleRow, 
            DataSets.dsModuleStructure2 dsModuleStructure) : this()
        {

            _moduleRow = moduleRow;
            _dsModuleStructure = dsModuleStructure;
            setParameterActions(_dsModuleStructure, _moduleRow);
        }

        public void setParameterActions(DataSets.dsModuleStructure2 dsModuleStructure, DataSets.dsModuleStructure2.dtModuleRow module)
        {
            _dsModuleStructure = dsModuleStructure;
            DataSets.dsModuleStructure2.dtModuleRow row = _dsModuleStructure.dtModule.FindBypk_id(module.pk_id);

            //DataRow moduleTypeRow = r
            DataSets.dsModuleStructure2.dtModuleTypeRow data = row.GetParentRow("dtModule_dtModuleType") as DataSets.dsModuleStructure2.dtModuleTypeRow;
            DataSets.dsModuleStructure2.dtModuleTypeActionTypeRow[] m = data.GetChildRows("dtModuleTypeActionType_dtModuleType") as DataSets.dsModuleStructure2.dtModuleTypeActionTypeRow[];
            

            
            //  DataRow[] r = row.GetParentRows("dtModuleTypeActionType_dtModuleType");

            /*
            foreach (DataSets.dsModuleStructure2.dtActionTypeRow row in actionTypes)
            {
                
                ParameterActions parameter = new ParameterActions(row);
                layoutModuleParametersStop.Controls.Add(parameter);
                _moduleParametersStop.Add(parameter);
                parameter = new ParameterActions(row);
                layoutModuleParametersStart.Controls.Add(parameter);
                _moduleParametersStart.Add(parameter);
            }
            */
        }

        public List<ParameterActions> getParameterStartActions()
        {
            return _moduleParametersStart;
        }

        public List<ParameterActions> getParameterStopActions()
        {
            return _moduleParametersStop;
        }

        public Button getAcceptButton()
        {
            return btnApply;
        }

        public Button getCancelButton()
        {
            return btnCancel;
        }

        public DataSets.dsModuleStructure2.dtStepLeafRow getStepLeaf()
        {
            DataSets.dsModuleStructure2.dtStepLeafRow slf = dsModuleStructure.dtStepLeaf.NewdtStepLeafRow();
            slf.description = edtStepName.Text;

            return slf;
        }
    }
}
