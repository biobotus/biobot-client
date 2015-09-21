using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace BioBotApp.Utils.Communication
{
    public class CustomSerial : SerialPort
    {
        private string serialName;
        public CustomSerial(string name)
        {
            serialName = name;
        }

        public bool configure(string portName, int baudRate, int dataBits, StopBits stopBits, Parity parityBits, Handshake handshake, bool useRts)
        {
            isConfigured = false;
            if (this.IsOpen == true)
            {
                this.Close();
            }

            this.StopBits = stopBits;
            this.BaudRate = baudRate;
            this.DataBits = dataBits;
            this.PortName = portName;
            this.Parity =  parityBits;
            this.Handshake = handshake;
            this.RtsEnable = useRts;
            
            //@Todo find another way to stroe those data (custom xml?) or to test against setting existance
            // I dislike this solution because we need to create the settings manually at design
            // and lose a bit of versatility (and Reusability)
            Properties.SerialComunication.Default[serialName + "StopBits"] = this.StopBits;
            Properties.SerialComunication.Default[serialName + "BaudRate"] = this.BaudRate;
            Properties.SerialComunication.Default[serialName + "DataBits"] = this.DataBits;
            Properties.SerialComunication.Default[serialName + "PortName"] = this.PortName;
            Properties.SerialComunication.Default[serialName + "Parity"] = this.Parity;
            Properties.SerialComunication.Default[serialName + "Handshake"] = this.Handshake;
            Properties.SerialComunication.Default[serialName + "RtsEnable"] = this.RtsEnable;
            Properties.SerialComunication.Default.Save();

            isConfigured = true;
            return true;
        }

        public new bool Open()
        {
            if (this.IsOpen)
            {
                this.Close();
            }
            if (isConfigured)
            {
                try
                {
                    base.Open();
                    return this.IsOpen;
                }
                catch (Exception ex)
                {
                    //TODO gestion des exceptions?
                    Console.WriteLine(ex.ToString());
                    return false;
                }
            }
            else
            {
                return false;
            }          
        }

        private bool isConfigured = false;
        
    }
}
