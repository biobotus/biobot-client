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
    public partial class stopBitComboBox : ComboBox
    {
        Dictionary<string, StopBits> stopBitValues = new Dictionary<string, StopBits>
        {
            { "One", StopBits.One },
            { "OnePointFive", StopBits.OnePointFive },
            {"Two", StopBits.Two }
        };
        public stopBitComboBox()
        {
            InitializeComponent();
            this.DataSource = stopBitValues.Keys.ToList();
            this.DisplayMember = "Item1";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public StopBits getStopBitsValue()
        {
            return stopBitValues[this.SelectedValue.ToString()];
        }
    }
}
