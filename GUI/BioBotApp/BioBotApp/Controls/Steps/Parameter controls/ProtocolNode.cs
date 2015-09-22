using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioBotApp.Controls.Steps.Parameter_controls
{
    class ProtocolNode : System.Windows.Forms.TreeNode
    {

        public ProtocolNode(String title)
        {
            this.Text = title;
            this.BackColor = Color.LightGreen;
        }
    }
}
