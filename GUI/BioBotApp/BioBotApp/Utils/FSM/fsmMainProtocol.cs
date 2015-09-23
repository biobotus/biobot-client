using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.FSM
{
    class fsmMainProtocol
    {
        private const int TAC                       = 1;
        private const int CENTRI                    = 2;
        private const int PINCE                     = 3;
        private const int MC96                      = 5;
        private const int MC1_5                     = 6;
        private const int TOOL_HOLDER               = 7;
        private const int SNGLE_CHANNEL_PIPETTE     = 8;


        fsmMovement movement;
        fsmPince pince;
        fsmSingleChannelPipette singleChannePipette;

        public fsmMainProtocol()
        {
            movement = new fsmMovement();
            pince = new fsmPince();
            singleChannePipette = new fsmSingleChannelPipette();
        }

        public void executeAction(DataSets.dsModuleStructure2.dtActionValueRow action)
        {
            int moduleTypeId = action.dtStepLeafRow.dtStepCompositeRow.dtModuleRow.dtModuleTypeRow.pk_id;
            if (moduleTypeId == TOOL_HOLDER)
            {
                movement.move(action);
            }
            else if(moduleTypeId == PINCE)
            {
                pince.executeAction(action);
            }
            else if(moduleTypeId == SNGLE_CHANNEL_PIPETTE)
            {
                singleChannePipette.executeAction(action);
            }
        }
    }
}
