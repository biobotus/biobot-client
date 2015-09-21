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
        public CustomSerial()
        {

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
                    // Genere parfois des exceptions que je ne comprend pas sur de mauvais arguments 
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
