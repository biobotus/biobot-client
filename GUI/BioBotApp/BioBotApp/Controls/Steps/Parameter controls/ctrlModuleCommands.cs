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
using BioBotApp.Controls.Steps.Parameter_controls;
using BioBotApp.DataSets;

namespace BioBotApp.Controls.Parameter_controls
{
    public partial class ctrlModuleParameters : UserControl
    {
        dsModuleStructure2 _dsModuleStructure;
        dsModuleStructure2.dtModuleRow _moduleRow;
        List<ParameterActions> _moduleParametersStop = new List<ParameterActions>();
        List<ParameterActions> _moduleParametersStart = new List<ParameterActions>();

        public ctrlModuleParameters()
        {
            InitializeComponent();
        }

        public ctrlModuleParameters(dsModuleStructure2.dtModuleRow moduleRow, 
            dsModuleStructure2 dsModuleStructure) : this()
        {
            _moduleRow = moduleRow;
            _dsModuleStructure = dsModuleStructure;

            setParameterActions(_dsModuleStructure, _moduleRow);
        }

        public void setParameterActions(dsModuleStructure2 dsModuleStructure, dsModuleStructure2.dtModuleRow module)
        {
            Dictionary<dsModuleStructure2.dtActionValueTypeRow, ctrlCommand> actionTypeDict = new Dictionary<dsModuleStructure2.dtActionValueTypeRow, ctrlCommand>();

            _dsModuleStructure = dsModuleStructure;
            
            dsModuleStructure2.dtModuleTypeActionTypeRow[] moduleTypeActionTypeRows = module.dtModuleTypeRow.GetdtModuleTypeActionTypeRows();
            foreach (dsModuleStructure2.dtModuleTypeActionTypeRow moduleTypeActionTypeRow in moduleTypeActionTypeRows)
            {
                ctrlCommand command;

                if(actionTypeDict.ContainsKey(moduleTypeActionTypeRow.dtActionValueTypeRow))
                {
                    command = actionTypeDict[moduleTypeActionTypeRow.dtActionValueTypeRow];
                }
                else
                {
                    command = new ctrlCommand();
                    command.init(moduleTypeActionTypeRow.dtActionValueTypeRow.description);
                    actionTypeDict.Add(moduleTypeActionTypeRow.dtActionValueTypeRow, command);
                }
                command.addCommand(moduleTypeActionTypeRow.dtActionTypeRow);
            }
            
            foreach(ctrlCommand commands in actionTypeDict.Values)
            {
                commands.Dock = DockStyle.Top;
                layoutMainPanel.Controls.Add(commands);
            }
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

        public dsModuleStructure2.dtStepLeafRow getStepLeaf()
        {
            dsModuleStructure2.dtStepLeafRow slf = dsModuleStructure.dtStepLeaf.NewdtStepLeafRow();
            slf.description = edtStepName.Text;

            return slf;
        }
    }
}
