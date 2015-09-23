using BioBotApp.Utils.Communication.pcan;
using BioBotApp.Utils.Communication.pcan.MultiChannelPipette;
using System;
using System.Threading;

namespace BioBotApp.Utils.FSM
{
    class fsmMultiChannelPipette
    {
        private const int PIPETTE = 24;
        private const int DISPENSE = 25;
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
            if (row.dtActionTypeRow.pk_id == PIPETTE)
            {
                MultiChannelPipette.sendInstruction(0x00, Convert.ToInt16(row.description));
            }
            else if (row.dtActionTypeRow.pk_id == DISPENSE)
            {
                MultiChannelPipette.sendInstruction(0x01, Convert.ToInt16(row.description));
            }

            wait.Reset();
            wait.WaitOne();

        }
    }
}
