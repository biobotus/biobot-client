﻿using System;
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
            StepLeafNode treeNodeStepLeaf = (StepLeafNode)e.Data.GetData(typeof(StepLeafNode));

            if (treeNodeStepComposite != null)
            {
                addNodes(treeNodeStepComposite.getStepCompositeRow(), targetNode);
            }
            else if (treeNodeStepLeaf != null)
            {
                targetNode.Nodes.Add(new StepLeafNode(treeNodeStepLeaf.getStepLeaf()));
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

            foreach (DataSets.dsModuleStructure2.dtStepLeafRow stepLeafRow in row.GetdtStepLeafRows())
            {
                TreeNode stepLeafNode = new StepLeafNode(stepLeafRow);
                treeNode.Nodes.Add(stepLeafNode);
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
            if(treeNode is StepCompositeNode)
            {
                foreach(TreeNode childNodes in treeNode.Nodes)
                {
                    executeAction(childNodes);
                }
            }

            if(treeNode is StepLeafNode)
            {
                StepLeafNode stepLeafNode = treeNode as StepLeafNode;

                DataSets.dsModuleStructure2.dtStepLeafRow stepLeaf = stepLeafNode.getStepLeaf();
                DataSets.dsModuleStructure2.dtActionValueRow[] actionValueRows = stepLeaf.GetdtActionValueRows();


                foreach (DataSets.dsModuleStructure2.dtActionValueRow actionValueRow in actionValueRows){

                    mainProtocol.executeAction(actionValueRow);
                }

               
            }
        }
    }
}
