using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.Communication
{
    public class ComChannelFactory
    {
        public enum CustomSerialChan { gCodeSerial, canSerial};
        public static CustomSerial getSerialChannel(CustomSerialChan chan)
        {
            if (!serialChanDict.ContainsKey(chan))
            {
                serialChanDict[chan] = new CustomSerial(chan.ToString());
            }
            return serialChanDict[chan];
        }
        private static Dictionary<CustomSerialChan, CustomSerial> serialChanDict = new Dictionary<CustomSerialChan, CustomSerial>();
    }
}
