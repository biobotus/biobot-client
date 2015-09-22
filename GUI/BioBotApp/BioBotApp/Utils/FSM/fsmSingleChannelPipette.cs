using BioBotApp.Utils.Communication.pcan.SingleChannelPipette;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.FSM
{
    class fsmSingleChannelPipette
    {
        private const int PIPETTE = 0x24;
        private const int DISPENSE = 0x25; 

        public fsmSingleChannelPipette()
        {

        }

        public static void executeAction(DataSets.dsModuleStructure2.dtActionValueRow row)
        {
            if(row.dtActionValueTypeRow.pk_id == PIPETTE)
            {
                SingleChannelPipette.sendInstruction(0x00, Convert.ToChar(row.description));
            }
            else if (row.dtActionValueTypeRow.pk_id == DISPENSE)
            {
                SingleChannelPipette.sendInstruction(0x01, Convert.ToChar(row.description));
            }

            //System.Threading.Thread.Sleep(1000);
        }
    }
}
