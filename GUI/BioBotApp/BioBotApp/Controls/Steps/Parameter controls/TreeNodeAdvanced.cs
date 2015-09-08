using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Controls.Parameter_controls
{
    public class TreeNodeProtocolType : System.Windows.Forms.TreeNode
    {
        private String _protocolType = String.Empty;
        private DataSets.dsModuleStructure2.dtStepLeafRow _stepValue;

        public TreeNodeProtocolType()
        {
           
        }

        public String getNodeType()
        {
            return _protocolType;
        }

        public DataSets.dsModuleStructure2.dtStepLeafRow getStepValue()
        {
            return _stepValue;
        }

        public void setNodeType(String nodeType)
        {
            _protocolType = nodeType;
        }

        public void setStepValue(DataSets.dsModuleStructure2.dtStepLeafRow StepValue)
        {
            _stepValue = StepValue;
        }

        public void setText(String text)
        {
            base.Text = text;
        }
    }
}
