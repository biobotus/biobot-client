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
    public partial class ctrlParity : UserControl
    {
        Dictionary<string, Parity> parityBitValues = new Dictionary<string, Parity>
        {
            { "Even", Parity.Even },
            { "Mark", Parity.Mark },
            {"None", Parity.None },
            {"Odd", Parity.Odd },
            {"Space", Parity.Space }
        };

        public ctrlParity()
        {
            InitializeComponent();

            this.cmbParity.DataSource = new BindingSource(parityBitValues, null);
            this.cmbParity.DisplayMember = "Key";
            this.cmbParity.ValueMember = "Value";
        }


        public Parity selectedValue
        {
            get { return (Parity)this.cmbParity.SelectedValue; }
            set { this.cmbParity.SelectedValue = value; }
        }
    }
}
