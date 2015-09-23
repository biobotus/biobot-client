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
    public partial class ctrlStopbit : UserControl
    {
        Dictionary<string, StopBits> stopBitValues = new Dictionary<string, StopBits>
        {
            { "One", StopBits.One },
            { "OnePointFive", StopBits.OnePointFive },
            {"Two", StopBits.Two }
        };

        public ctrlStopbit()
        {
            InitializeComponent();

            this.cmbStopbit.DataSource = new BindingSource(stopBitValues, null);
            this.cmbStopbit.DisplayMember = "Key";
            this.cmbStopbit.ValueMember = "Value";
        }


    public StopBits selectedValue
    {
        get { return (StopBits)this.cmbStopbit.SelectedValue; }
        set { this.cmbStopbit.SelectedValue = value; }
    }
}
}
