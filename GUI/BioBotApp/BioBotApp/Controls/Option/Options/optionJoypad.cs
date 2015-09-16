using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Utils.Communication;
using BioBotApp.DataSets;

namespace BioBotApp.Controls.Option.Options
{
    //public class RoundButton : Button
    //{
    //    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    //    {
    //        GraphicsPath grPath = new GraphicsPath();
    //        grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
    //        this.Region = new System.Drawing.Region(grPath);
    //        base.OnPaint(e);
    //    }
    //}

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    this.ResumeLayout(false);

        //}
    ////}
    public partial class optionJoypad : UserControl
    {
        public optionJoypad()
        {
            InitializeComponent(); 
        }

        public optionJoypad(dsModuleStructure2 dsModuleStructure)
        {
            this.dsModuleStructure = dsModuleStructure;
        }

        double xcoor;
        double ycoor;
        double z1coor;
        double z2coor;
        double z3coor;
        Double varCoor=0;
        string GCode;
        private dsModuleStructure2 dsModuleStructure;

        private void button1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void optionJoypad_Load(object sender, EventArgs e)
        {
            Refresh();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            ycoor = ycoor - 0.1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            ycoor = ycoor - 1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            xcoor = xcoor + 0.1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private int getNumber(int xcoord)
        {
            throw new NotImplementedException();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            xcoor = xcoor + 1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            sendGCode(GCode);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (varCoor != 0) { 
            xcoor = GetValue("x");
            xcoor = xcoor + varCoor;
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            sendGCode(GCode);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            xcoor = xcoor + varCoor;
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            xcoor = xcoor - 1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            ycoor = ycoor + 0.1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (varCoor != 0)
            {
                xcoor = GetValue("x");
                ycoor = GetValue("y");
                ycoor = ycoor - varCoor;
                z1coor = GetValue("z1");
                z2coor = GetValue("z2");
                z3coor = GetValue("z3");
                setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (varCoor != 0)
            {
                xcoor = GetValue("x");
                xcoor = xcoor - varCoor;
                ycoor = GetValue("y");
                z1coor = GetValue("z1");
                z2coor = GetValue("z2");
                z3coor = GetValue("z3");
                setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            ycoor = ycoor + 1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (varCoor != 0)
            {
                xcoor = GetValue("x");
                ycoor = GetValue("y");
                ycoor = ycoor + varCoor;
                z1coor = GetValue("z1");
                z2coor = GetValue("z2");
                z3coor = GetValue("z3");
                setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (varCoor != 0)
            {
                xcoor = GetValue("x");
                ycoor = GetValue("y");
                z1coor = GetValue("z1");
                z2coor = GetValue("z2");
                z3coor = GetValue("z3");
                z3coor = z3coor + varCoor;
                setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z3coor = z3coor + 1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z3coor = z3coor + 0.1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (varCoor != 0)
            {
                xcoor = GetValue("x");
                ycoor = GetValue("y");
                z1coor = GetValue("z1");
                z2coor = GetValue("z2");
                z2coor = z2coor + varCoor;
                z3coor = GetValue("z3");
                setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z2coor = z2coor + 1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z2coor = z2coor + 0.1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (varCoor != 0)
            {
                xcoor = GetValue("x");
                ycoor = GetValue("y");
                z1coor = GetValue("z1");
                z1coor = z1coor + varCoor;
                z2coor = GetValue("z2");
                z3coor = GetValue("z3");
                setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z1coor = z1coor + 1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z1coor = z1coor + 0.1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z3coor = z3coor - 0.1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z3coor = z3coor -1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (varCoor != 0)
            {
                xcoor = GetValue("x");
                ycoor = GetValue("y");
                z1coor = GetValue("z1");
                z2coor = GetValue("z2");
                z3coor = GetValue("z3");
                z3coor = z3coor - varCoor;
                setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z2coor = z2coor - 0.1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z2coor = z2coor - 1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (varCoor != 0)
            {
                xcoor = GetValue("x");
                ycoor = GetValue("y");
                z1coor = GetValue("z1");
                z2coor = GetValue("z2");
                z2coor = z2coor - varCoor;
                z3coor = GetValue("z3");
                setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z1coor = z1coor - 0.1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            xcoor = GetValue("x");
            ycoor = GetValue("y");
            z1coor = GetValue("z1");
            z2coor = GetValue("z2");
            z3coor = GetValue("z3");
            z1coor = z1coor -1;
            setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (varCoor != 0)
            {
                xcoor = GetValue("x");
                ycoor = GetValue("y");
                z1coor = GetValue("z1");
                z1coor = z1coor - varCoor;
                z2coor = GetValue("z2");
                z3coor = GetValue("z3");
                setupGCode(xcoor,ycoor,z1coor,z2coor,z3coor);
            }
        }

        private void ycoord_Click(object sender, EventArgs e)
        {

        }

        private void z1coord_Click(object sender, EventArgs e)
        {
            
        }

        private void z2coord_Click(object sender, EventArgs e)
        {

        }
        private Double getNumber(string coord)
        {
            String myInt = coord.Remove(0, 4);
            Double N = Int32.Parse(myInt);
            return N;
        }
        public void sendGCode(string text)
        {

            Console.Out.WriteLine(text);
            CustomSerial movementSerial = ComChannelFactory.getGCodeSerial();
            movementSerial.configure("COM3", "115200", "8", "One", "None");
            movementSerial.Open();
            //movementSerial.WriteLine(text);
            movementSerial.Write("M105\n");
            //movementSerial.WriteLine("T1\n");

            System.Threading.Thread.Sleep(1000);
            movementSerial.Write("G91\n");
            movementSerial.Write("G1 X-300 F6000\n");
            System.Threading.Thread.Sleep(1000);
            movementSerial.ReadExisting();
            //movementSerial.ReadLine();
            movementSerial.Close();

        }
        public void setupGCode(double x,double y,double z1,double z2,double z3)
        {
            GCode = "X" + x + "Y" + y + "Z1" + z1 + "Z2" + z2 + "Z3" + z3;
            sendGCode(GCode);
        }

        private void xcoord_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        { 
         varCoor = double.Parse(textBox6.Text);
        }
    }
}
