using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Controls.Steps.Parameter_controls
{
    class StepCompositeNode : System.Windows.Forms.TreeNode
    {
        DataSets.dsModuleStructure2.dtStepCompositeRow _stepCompositeRow;

        public StepCompositeNode(DataSets.dsModuleStructure2.dtStepCompositeRow stepCompositeRow)
        {
            if(stepCompositeRow == null)
            {
                return;
            }

            if(stepCompositeRow.pk_id < 0)
            {
                return;
            }

            _stepCompositeRow = stepCompositeRow;
            this.Text = stepCompositeRow.description;
        }

        public DataSets.dsModuleStructure2.dtStepCompositeRow getStepCompositeRow()
        {
            return _stepCompositeRow;
        }
    }
}
