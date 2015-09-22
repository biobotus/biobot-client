using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Controls.Option.Options;
using BioBotApp.DataSets;

namespace BioBotApp.Controls.Deck
{
    public partial class ctrlDeck : UserControl
    {

        public ctrlDeck()
        {
            InitializeComponent();
        }
        //public ctrlDeck(DataSets.dsModuleStructure2 dsModuleStructure) : this()
        //{

        //    dsModuleStructureGUI = dsModuleStructure;
        //    //.DataSource = dsModuleStructureGUI;
        //    //if (this.dsModuleStructureGUI.dtActionType.Count == 0)
        //    {
        //        //.Fill(this.dsModuleStructureGUI.dtActionType);
        //    }
        //}

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Nouveau module", "Posiion du Module");
            namedInputTextBox description1 = new namedInputTextBox("X: ");
            namedInputTextBox description2 = new namedInputTextBox("Y: ");
            namedInputTextBox description3 = new namedInputTextBox("Rotation: ");
            dialog.addNamedInputTextBox(description1);
            dialog.addNamedInputTextBox(description2);
            dialog.addNamedInputTextBox(description3);

            dialog.ShowDialog();

            //if (dialog.DialogResult.Equals(DialogResult.OK))
            //{
            //    //DataSets.dsModuleStructure2.dtActionTypeRow row1;
            //    //DataSets.dsModuleStructure2.dtActionTypeRow row2;
            //    //DataSets.dsModuleStructure2.dtActionTypeRow row3;

            //    row1 = dsModuleStructureGUI.dtActionType.NewdtActionTypeRow();
            //    row1.description = description1.getInputTextValue();
            //    row2 = dsModuleStructureGUI.dtActionType.NewdtActionTypeRow();
            //    row2.description = description2.getInputTextValue();
            //    row3 = dsModuleStructureGUI.dtActionType.NewdtActionTypeRow();
            //    row3.description = description3.getInputTextValue();
            //    dsModuleStructureGUI.dtActionType.AdddtActionTypeRow(row);
            //    updateRow(row);
            //}
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;

        }
        //        private void module1_DragEnter(object sender,
        //System.Windows.Forms.DragEventArgs e)
        //        {
        //            if (e.Data.GetDataPresent(DataFormats.Module))
        //            {
        //                e.Effect = DragDropEffects.Copy;
        //                abstractDialog dialog = new abstractDialog("Position du Module", "X: ");
        //                //this.addNamedInputTextBox("Y: ");
        //                //this.addNamedInputTextBox("Rotation: ");
        //            }
        //            else
        //                e.Effect = DragDropEffects.None;
        //        }
    }
}
