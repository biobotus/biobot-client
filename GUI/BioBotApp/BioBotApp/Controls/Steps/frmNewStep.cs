using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioBotApp.Controls.Steps
{
    public partial class frmNewStep : Form
    {
        public frmNewStep()
        {
            InitializeComponent();
            this.AcceptButton = moduleParameters.getAcceptButton();
            this.CancelButton = moduleParameters.getCancelButton();
        }

        public frmNewStep(DataSets.dsModuleStructure2 dsModuleStructure, DataSets.dsModuleStructure2.dtModuleRow moduleRow)
            : this()
        {
            moduleParameters.setParameterActions(dsModuleStructure, moduleRow);
        }
        public DataSets.dsModuleStructure2.dtStepLeafRow getSteapLeafRow()
        {
            return moduleParameters.getStepLeaf();
        }
    }
}
