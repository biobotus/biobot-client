using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Controls.Steps.Parameter_controls
{
    class StepLeafNode : System.Windows.Forms.TreeNode
    {
        DataSets.dsModuleStructure2.dtStepLeafRow _stepLeaf;
        public StepLeafNode(DataSets.dsModuleStructure2.dtStepLeafRow stepLeaf)
        {
            if(stepLeaf == null)
            {
                return;
            }

            if(stepLeaf.pk_id < 0)
            {
                return;
            }

            _stepLeaf = stepLeaf;
            this.Text = stepLeaf.description;
        }

        public DataSets.dsModuleStructure2.dtStepLeafRow getStepLeaf()
        {
            return _stepLeaf;
        }
    }
}
