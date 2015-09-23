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
    public partial class ctrlHandshake : UserControl
    {
        Dictionary<string, Handshake> handshakeValues = new Dictionary<string, Handshake>
        {
            { "None", Handshake.None },
            { "RequestToSend", Handshake.RequestToSend },
            { "RequestToSendXOnXOff", Handshake.RequestToSendXOnXOff},
            { "XOnXOff", Handshake.XOnXOff},
        };

        public ctrlHandshake()
        {
            InitializeComponent();

            this.cmbHandshake.DataSource = new BindingSource(handshakeValues, null);
            this.cmbHandshake.DisplayMember = "Key";
            this.cmbHandshake.ValueMember = "Value";
        }


        public Handshake selectedValue
        {
            get { return (Handshake)this.cmbHandshake.SelectedValue; }
            set { this.cmbHandshake.SelectedValue = value; }
        }

    }
}
