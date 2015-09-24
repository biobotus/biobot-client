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
    class StepCompositeNode : System.Windows.Forms.TreeNode, ISerializable
    {
        DataSets.dsModuleStructure2.dtStepCompositeRow _stepCompositeRow;
        DataSets.dsModuleStructure2TableAdapters.taStepComposite taStepComposite;
        DataSets.dsModuleStructure2.dtStepCompositeDataTable stepCompositeDataTable;

        public StepCompositeNode(DataSets.dsModuleStructure2.dtStepCompositeRow stepCompositeRow)
        {
            if (stepCompositeRow == null)
            {
                return;
            }

            if (stepCompositeRow.pk_id < 0)
            {
                //return;
            }

            _stepCompositeRow = stepCompositeRow;
            this.Text = stepCompositeRow.description;
            this.BackColor = Color.Yellow;

            
        }
        protected StepCompositeNode(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            stepCompositeDataTable = new DataSets.dsModuleStructure2.dtStepCompositeDataTable();

            taStepComposite = new DataSets.dsModuleStructure2TableAdapters.taStepComposite();
            int id = info.GetInt16("StepCompositeRowId");
            taStepComposite.Select(stepCompositeDataTable, id);
            if (stepCompositeDataTable.Rows.Count != 1)
            {
                System.Windows.Forms.MessageBox.Show("An error occured while loading protols !");
            }
            _stepCompositeRow = stepCompositeDataTable.FindBypk_id(id);
           // this(_stepCompositeRow);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("StepCompositeRowId", _stepCompositeRow.pk_id);
        }


        public DataSets.dsModuleStructure2.dtStepCompositeRow getStepCompositeRow()
        {
            return _stepCompositeRow;
        }
    }
}
