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
        namedInputTextBox inputBox;
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
            inputBox = new namedInputTextBox(actionType.description);
            layoutModuleParametersStop.Controls.Add(inputBox);
        }

        public String getValue()
        {
            return inputBox.getInputTextValue();
        }
    }
}
