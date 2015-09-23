using BioBotApp.Utils.Communication.pcan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BioBotApp.Utils.Communication.pcan.MultiChannelPipette;

namespace BioBotApp.Utils.FSM
{
    class fsmMultiChannelPipette
    {
        private const int PIPETTE = 0x24;
        private const int DISPENSE = 0x25;
        AutoResetEvent wait = new AutoResetEvent(false);
        public fsmMultiChannelPipette()
        {
            PCANCom.Instance.OnMessageReceived += Instance_OnMessageReceived;
        }

        private void Instance_OnMessageReceived(object sender, PCANComEventArgs e)
        {
            wait.Set();
        }

        public void executeAction(DataSets.dsModuleStructure2.dtActionValueRow row)
        {
            if (row.dtActionValueTypeRow.pk_id == PIPETTE)
            {
                MultiChannelPipette.sendInstruction(0x00, Convert.ToChar(row.description));
            }
            else if (row.dtActionValueTypeRow.pk_id == DISPENSE)
            {
                MultiChannelPipette.sendInstruction(0x01, Convert.ToChar(row.description));
            }

            wait.Reset();
            wait.WaitOne();

        }
    }
}
