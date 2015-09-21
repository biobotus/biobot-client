using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace BioBotApp.Controls.Utils
{
    public partial class handshakeComboBox : ComboBox
    {
        Dictionary<string, Handshake> handshakeValues = new Dictionary<string, Handshake>
        {
            { "None", Handshake.None },
            { "RequestToSend", Handshake.RequestToSend },
            { "RequestToSendXOnXOff", Handshake.RequestToSendXOnXOff},
            { "XOnXOff", Handshake.XOnXOff},
        };
        public handshakeComboBox()
        {
            InitializeComponent();
            this.DataSource = handshakeValues.Keys.ToList();
            this.DisplayMember = "Item1";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Handshake getHandshakeValue()
        {
            return handshakeValues[this.SelectedValue.ToString()];
        }
    }
}
