using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Controls.Steps.Parameter_controls
{
    [Serializable()]
    class StepLeafNode : System.Windows.Forms.TreeNode , ISerializable
    {
        private DataSets.dsModuleStructure2.dtStepLeafRow _stepLeaf;
        private DataSets.dsModuleStructure2TableAdapters.taStepLeaf taStepLeaf ;
        private DataSets.dsModuleStructure2.dtStepLeafDataTable stepLeafDataTable;
        private DataSets.dsModuleStructure2TableAdapters.taActionValue taActionValue;
        private DataSets.dsModuleStructure2.dtActionValueDataTable actionValueDataValueTable;

        public StepLeafNode(DataSets.dsModuleStructure2.dtStepLeafRow stepLeaf, DataSets.dsModuleStructure2.dtActionValueDataTable actionValueDataTable)
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
            this.Tag = stepLeaf.pk_id;
            this.actionValueDataValueTable = actionValueDataTable.Clone() as DataSets.dsModuleStructure2.dtActionValueDataTable;
        }

        protected StepLeafNode(SerializationInfo info, StreamingContext context) : base(info,context)
        {
            stepLeafDataTable = new DataSets.dsModuleStructure2.dtStepLeafDataTable();
            taActionValue = new DataSets.dsModuleStructure2TableAdapters.taActionValue();
            actionValueDataValueTable = new DataSets.dsModuleStructure2.dtActionValueDataTable();

            taStepLeaf = new DataSets.dsModuleStructure2TableAdapters.taStepLeaf();
            int id = 0;
            if(Tag is int)
            {
                id = (int)Tag;
            }
            taStepLeaf.Select(stepLeafDataTable, id);
            if (stepLeafDataTable.Rows.Count != 1)
            {
                System.Windows.Forms.MessageBox.Show("An error occured while loading Steps !");
            }
            _stepLeaf = stepLeafDataTable.FindBypk_id(id);

            taActionValue.SelectById(actionValueDataValueTable, id);
        }

        public DataSets.dsModuleStructure2.dtStepLeafRow getStepLeaf()
        {
            return _stepLeaf;
        }

        public DataSets.dsModuleStructure2.dtActionValueDataTable getActionValueDataTable()
        {
            return actionValueDataValueTable;
        }
    }
}
