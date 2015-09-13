using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BioBotApp.DataSets;
using BioBotApp.Controls.Option.Options;

namespace BioBotApp.Controls.Steps.Parameter_controls
{
    public partial class ctrlCommand : UserControl
    {
        Dictionary<dsModuleStructure2.dtActionTypeRow, namedInputTextBox> actionTypeInputBoxDict;
        public ctrlCommand()
        {
            InitializeComponent();
            actionTypeInputBoxDict = new Dictionary<dsModuleStructure2.dtActionTypeRow,namedInputTextBox>();
        }

        public void init(String title)
        {
            txtCommandTypeName.Text = title;
        }

        public void addCommand(dsModuleStructure2.dtActionTypeRow actionType)
        {
            namedInputTextBox inputBox = new namedInputTextBox(actionType.description);
            actionTypeInputBoxDict.Add(actionType, inputBox);
            layoutModuleParametersStop.Controls.Add(inputBox);
        }

        public String getActionValue(dsModuleStructure2.dtActionTypeRow actionType)
        {
            String actionValue = String.Empty;
           
            if(actionType == null)
            {
                return null;
            }
            if(!actionTypeInputBoxDict.ContainsKey(actionType))
            {
                return null;
            }

            actionValue = actionTypeInputBoxDict[actionType].getInputTextValue();
            if(actionValue.Length == 0)
            {
                return null;
            }
            else
            {
                return actionValue;
            }
        }
    }
}
