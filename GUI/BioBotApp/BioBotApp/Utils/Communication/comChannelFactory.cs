using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Utils.Communication
{
    class ComChannelFactory
    {

        public static CustomSerial getGCodeSerial()
        {
            if (gCodeSerialChannel == null)
            {
                gCodeSerialChannel = new CustomSerial();
            }
            return gCodeSerialChannel;
        }

        private static CustomSerial gCodeSerialChannel;
    }
}
