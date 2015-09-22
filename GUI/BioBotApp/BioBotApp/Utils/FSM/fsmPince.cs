using BioBotApp.Utils.Communication.pcan.Dynamixel;
using BioBotApp.Utils.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.FSM
{
    public class fsmPince
    {

        public fsmPince()
        {

        }

        public void executeAction(DataSets.dsModuleStructure2.dtActionValueRow row)
        {
            if (row.dtActionTypeRow.pk_id == DBManager.ActionTypes.OPEN)
            {
                DynamixelCom.sendInstruction(1);
            }
            else if (row.dtActionTypeRow.pk_id == DBManager.ActionTypes.CLOSE)
            {
                DynamixelCom.sendInstruction(2);
            }
            else if (row.dtActionTypeRow.pk_id == DBManager.ActionTypes.DELAY_MS)
            {
                System.Threading.Thread.Sleep(Int32.Parse(row.description));
            }
        }

    }
}
