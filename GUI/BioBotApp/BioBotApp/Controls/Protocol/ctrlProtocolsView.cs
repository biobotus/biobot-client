using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Controls.Steps;
using BioBotApp.Controls.Steps.Parameter_controls;
using BioBotApp.Utils.FSM;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BioBotApp.Controls.Protocol
{
    
    public partial class ctrlProtocolsView : UserControl
    {
        fsmMainProtocol mainProtocol; 
        public ctrlProtocolsView()
        {
            InitializeComponent();
            mainProtocol = new fsmMainProtocol();
        }

        private void tlvProtocol_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = tlvProtocol.PointToClient(new Point(e.X, e.Y));

            // Retrieve the node at the drop location.
            TreeNode targetNode = tlvProtocol.GetNodeAt(targetPoint);
            TreeNode dropNode = new TreeNode();
            StepCompositeNode treeNodeStepComposite = (StepCompositeNode)e.Data.GetData(typeof(StepCompositeNode));
        
            if (treeNodeStepComposite != null)
            {
                addNodes(treeNodeStepComposite.getStepCompositeRow(), targetNode);
            }
        }

        public void addNodes(DataSets.dsModuleStructure2.dtStepCompositeRow row, TreeNode parentNode)
        {
            TreeNode treeNode = new StepCompositeNode(row);

            if (parentNode == null)
            {
                tlvProtocol.Nodes.Add(treeNode);
            }
            else
            {
                parentNode.Nodes.Add(treeNode);
            }

            foreach (DataSets.dsModuleStructure2.dtStepCompositeRow childRows in row.GetdtStepCompositeRows())
            {
                addNodes(childRows, treeNode);
            }
        }


        private void tlvProtocol_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewProtocol frmProtocolAdd = new frmNewProtocol();
            DialogResult dialogResultAddNode = DialogResult.Cancel;
            dialogResultAddNode = frmProtocolAdd.ShowDialog();
            if (dialogResultAddNode == DialogResult.OK)
            {
                if (dialogResultAddNode.Equals(DialogResult.OK))
                {
                    ProtocolNode treeNode = new ProtocolNode(frmProtocolAdd.getStepName());
                    if (tlvProtocol.SelectedNode != null)
                    {
                        tlvProtocol.SelectedNode.Nodes.Add(treeNode);
                    }
                    else
                    {
                        tlvProtocol.Nodes.Add(treeNode);
                    }
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(tlvProtocol.SelectedNode == null)
            {
                return;
            }

            executeAction(tlvProtocol.SelectedNode);
        }

        public void executeAction(TreeNode treeNode)
        {
            if(treeNode is StepCompositeNode || treeNode is TreeNode)
            {
                foreach(TreeNode childNodes in treeNode.Nodes)
                {
                    executeAction(childNodes);
                }
            }
/*
TODO: add algo for the execution of the actionvalues
            if(treeNode is ActionValue)
            {
                StepLeafNode stepLeafNode = treeNode as StepLeafNode;

                DataSets.dsModuleStructure2.dtActionValueDataTable table = stepLeafNode.getActionValueDataTable();
                foreach (DataSets.dsModuleStructure2.dtActionValueRow actionValueRow in table)
                {
                    mainProtocol.executeAction(actionValueRow);
                }

               
            }
            */
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tlvProtocol.Nodes.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tlvProtocol.Nodes.Remove(tlvProtocol.SelectedNode);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogue = new SaveFileDialog();
            dialogue.Filter = "Biobot file (.biobot) | *.biobot";
            DialogResult result = dialogue.ShowDialog();

            if(result == DialogResult.OK)
            {
                SaveTree(tlvProtocol, dialogue.FileName);
            }
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogue = new OpenFileDialog();
            dialogue.Filter = "Biobot file (.biobot) | *.biobot";
            DialogResult result = dialogue.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadTree(tlvProtocol, dialogue.FileName);
            }
        }
        public static void SaveTree(TreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(file, tree.Nodes.Cast<TreeNode>().ToList());
            }
        }

        public static void LoadTree(TreeView tree, string filename)
        {
            using (Stream file = File.Open(filename, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                object obj = bf.Deserialize(file);

                TreeNode[] nodeList = (obj as IEnumerable<TreeNode>).ToArray();
                tree.Nodes.AddRange(nodeList);
            }
        }

        private void tlvProtocol_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }
    }
}
