﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using BioBotApp.Utils.Communication;

namespace BioBotApp.Controls.Option.Options
{
    
    public partial class optionCustomSerial : UserControl
    {
        private CustomSerial serialChan;
        public optionCustomSerial(string tag, ComChannelFactory.CustomSerialChan chan)
        {
            InitializeComponent();

            this.Tag = tag;

            string[] ports = SerialPort.GetPortNames();
            this.cmbPortName.Items.AddRange(ports);
            this.cmbPortName.SelectedIndex = 0;
            this.cmbParity.SelectedValue = Parity.None;
            this.serialChan = ComChannelFactory.getSerialChannel(chan);
        }

        private void txtDataBits_Validating(object sender, CancelEventArgs e)
        {
            int data = 0;
            if (!int.TryParse(txtDataBits.Text, out data))
            {
                e.Cancel = true;
                txtDataBits.Select(0, txtDataBits.Text.Length);
                this.errorProvider1.SetError(txtDataBits, "Data bits field only accept number");
            }
        }

        private void txtDataBits_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtDataBits, "");
        }

        private void txtBaudeRate_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(txtBaudeRate, "");
        }

        private void txtBaudeRate_Validating(object sender, CancelEventArgs e)
        {
            int data = 0;
            if (!int.TryParse(txtBaudeRate.Text, out data))
            {
                e.Cancel = true;
                txtDataBits.Select(0, txtBaudeRate.Text.Length);
                this.errorProvider1.SetError(txtBaudeRate, "Baude rate field only accept number");
            }
        }

        private void btnSendTest_Click(object sender, EventArgs e)
        {   
            if (!serialChan.IsOpen)
            {
                serialChan.Open();
            }

            if (serialChan.IsOpen)
            {
                txtConsole.Text += txtTest.Text + Environment.NewLine;
                serialChan.WriteLine(txtTest.Text);
            }
            else
            {
                //afficher que l'on est pas connecte
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            this.ConfigureSerialPort(serialChan);
            serialChan.Open();
        }

        private void ConfigureSerialPort(CustomSerial serialChan)
        {
            string portName = cmbPortName.SelectedItem.ToString();
            int baudRate = 0;
            int.TryParse(txtBaudeRate.Text, out baudRate);
            int dataBits = 0;
            int.TryParse(txtDataBits.Text, out dataBits);
            StopBits stopBits = cmbStop.getStopBitsValue();
            Parity parityBits = cmbParity.getParityBitsValue();
            Handshake handshake = cmbHandshake.getHandshakeValue();
            bool rtsUse = cbRtsEnable.Checked;

            serialChan.configure(portName, baudRate, dataBits, stopBits, parityBits, handshake, rtsUse);
        }

    }
}
