using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Controls.Steps.Parameter_controls
{
    [Serializable]
    class StepLeafNode : System.Windows.Forms.TreeNode , ISerializable
    {
        DataSets.dsModuleStructure2.dtStepLeafRow _stepLeaf;
        DataSets.dsModuleStructure2TableAdapters.taStepLeaf taStepLeaf ;
        DataSets.dsModuleStructure2.dtStepLeafDataTable stepLeafDataTable;
        DataSets.dsModuleStructure2TableAdapters.taActionValue taActionValue;
        DataSets.dsModuleStructure2.dtActionValueDataTable ActionValueDataValue;

        public StepLeafNode(DataSets.dsModuleStructure2.dtStepLeafRow stepLeaf)
        {
            if(stepLeaf == null)
            {
                return;
            }

            if(stepLeaf.pk_id < 0)
            {
                //return;
            }

            _stepLeaf = stepLeaf;
            this.Text = stepLeaf.description;
            this.BackColor = Color.LightBlue;


        }

        protected StepLeafNode(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            stepLeafDataTable = new DataSets.dsModuleStructure2.dtStepLeafDataTable();
            taActionValue = new DataSets.dsModuleStructure2TableAdapters.taActionValue();
            ActionValueDataValue = new DataSets.dsModuleStructure2.dtActionValueDataTable();

            taStepLeaf = new DataSets.dsModuleStructure2TableAdapters.taStepLeaf();
            int id = info.GetInt16("StepLeafRowId");
            taStepLeaf.Select(stepLeafDataTable, id);
            if (stepLeafDataTable.Rows.Count == 0 || stepLeafDataTable.Rows.Count == 1)
            {
                System.Windows.Forms.MessageBox.Show("An error occured while loading Steps !");
            }
            _stepLeaf = stepLeafDataTable.FindBypk_id(id);

            taActionValue.SelectById(ActionValueDataValue, id);
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("StepLeafRowId", _stepLeaf.pk_id);
        }
        public DataSets.dsModuleStructure2.dtStepLeafRow getStepLeaf()
        {
            return _stepLeaf;
        }
    }
}
