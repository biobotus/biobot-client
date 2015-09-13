using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
//////////////////////
using BioBotApp.Utils;
using BioBotApp.Utils.TCP;
using BioBotApp.Controls.Parameter_control;
using BioBotApp.Controls.Parameter_controls;
using BioBotApp.Controls.Tools_controls;
using BioBotApp.Controls.Option;
using BioBotApp.Controls.Utils;
using BioBotApp.Utils.Form;
using BioBotApp.Controls.Steps;
using BioBotApp.DataSets;

namespace BioBotApp
{
    public partial class frmMain : Form
    {
        AsyncTcpClient _tcpClient;
        //DataSets.dsModuleStructure.dtActionTypeRow row;
        //DataSets.dsModuleStructure.dtActionTypeDataTable dtActionType;

        public frmMain()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(ApplicationExeptionHandlers.Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(ApplicationExeptionHandlers.CurrentDomain_UnhandledException);


            InitializeComponent();
            initData();
            initControls();

            _tcpClient = Utils.TCP.AsyncTcpClient.getInstance();
            _tcpClient.tcpClientAsyncResult += OnTcpClientResultCallback;
        }

        public void initData()
        {
            taModule.Fill(dsModuleStructure.dtModule);
            taModuleType.Fill(dsModuleStructure.dtModuleType);
            taModuleTypeActionType.Fill(dsModuleStructure.dtModuleTypeActionType);
            taActionType.Fill(dsModuleStructure.dtActionType);
            taActionValueType.Fill(dsModuleStructure.dtActionValueType);
            taLabwareType.Fill(dsModuleStructure.dtLabwareType);
            taLabwareParameterType.Fill(dsModuleStructure.dtLabwareParameterType);
            taLabwareTypeLabwareParameterType.Fill(dsModuleStructure.dtLabwareTypeLabwareParameterType);
            taStepLeaf.Fill(dsModuleStructure.dtStepLeaf);
            taStepComposite.Fill(dsModuleStructure.dtStepComposite);
        }

        public void initControls()
        {
            bsModule.CurrentChanged += bsModule_CurrentChanged;
            ctrlSteps.initControl(this.dsModuleStructure, bsModule);
            ctrlTools.initControl(this.dsModuleStructure, bsModule);
        }

        void bsModule_CurrentChanged(object sender, EventArgs e)
        {

        }

        public DataSets.dsModuleStructure2.dtActionTypeRow addActionTypeRow(String description)
        {
            DataSets.dsModuleStructure2.dtActionTypeRow actionTypeRow = this.dsModuleStructure.dtActionType.NewdtActionTypeRow();
            actionTypeRow.description = description;
            this.dsModuleStructure.dtActionType.AdddtActionTypeRow(actionTypeRow);
            return actionTypeRow;
        }

        public void OnTcpClientResultCallback(object o, TCPClientAsyncResultEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _tcpClient.connect("10.43.156.129", 3001);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String a = "";
            a = a.PadRight(2000, '2');
            _tcpClient.send(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _tcpClient.connect("127.0.0.1", 3000);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String a = "";
            a = a.PadRight(2000, '2');
            a += '\n';
            _tcpClient.send(a);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure2.dtModuleRow mr = dsModuleStructure.dtModule.NewdtModuleRow();

            mr.fk_module_type = 1;
            mr.pk_id = Guid.NewGuid().ToString();
            this.dsModuleStructure.dtModule.AdddtModuleRow(mr);
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            DataSets.dsModuleStructure2.dtModuleRow mr = dsModuleStructure.dtModule.NewdtModuleRow();

            mr.fk_module_type = 1;
            mr.pk_id = Guid.NewGuid().ToString().Substring(0, 7);

            dsModuleStructure.dtModule.AdddtModuleRow(mr);
        }

        private void ctrlTools_ToolSelectionChanged(object sender, ModuleTypeSelectionEventArgs e)
        {
            ctrlConsole.Log("Selection node: " + e.SelectedTreeNode.Text);
            if (e.SelectedTreeNode.Tag is DataSets.dsModuleStructure2.dtModuleTypeRow)
            {
                DataSets.dsModuleStructure2.dtModuleTypeRow moduleRow = e.SelectedTreeNode.Tag as DataSets.dsModuleStructure2.dtModuleTypeRow;
                DataSets.dsModuleStructure2.dtActionTypeDataTable actionTypeTable =
                    new DataSets.dsModuleStructure2.dtActionTypeDataTable();

                //ctrlSteps.setSelectedModule(moduleRow);
            }
        }

        private void parametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOptions o = new frmOptions(this.dsModuleStructure);
            o.ShowDialog();
        }
    }
}
