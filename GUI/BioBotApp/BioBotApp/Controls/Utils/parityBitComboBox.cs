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
    public partial class parityBitComboBox : ComboBox
    {
        Dictionary<string, Parity> parityBitValues = new Dictionary<string, Parity>
        {
            { "Even", Parity.Even },
            { "Mark", Parity.Mark },
            {"None", Parity.None },
            {"Odd", Parity.Odd },
            {"Space", Parity.Space }
        };

        public parityBitComboBox()
        {
            InitializeComponent();
            this.DataSource = parityBitValues.Keys.ToList();
            this.DisplayMember = "Item1";
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public Parity getParityBitsValue()
        {
            return parityBitValues[this.SelectedValue.ToString()];
        }
    }
}
