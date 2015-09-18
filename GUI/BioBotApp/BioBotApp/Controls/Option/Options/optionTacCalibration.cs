using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBotApp.Matrix;

namespace BioBotApp.Controls.Option.Options
{
    public partial class optionTacCalibration : UserControl
    {
        public optionTacCalibration()
        {
            InitializeComponent();
        }

        public optionTacCalibration(DataSets.dsModuleStructure2 dsModuleStruct):this()
        {
            this.dsModuleStructure = dsModuleStruct;
            DataView dv = dsModuleStructure.dtModule.DefaultView;
            DataView dv2 = dsModuleStructure.dtTacCalibrationData.DefaultView;

            dgvTacCalibrationDataView.DataSource = dv2;
            dgvTacCalibrationDataView.Columns["fk_module_id"].Visible = false;

            cmbTacSelector.DataSource = dv;
            cmbTacSelector.ValueMember = "pk_id";
            cmbTacSelector.DisplayMember = "pk_id";
        }

        private void crudOptions_AddClickHandler(object sender, EventArgs e)
        {
            abstractDialog dialog = new abstractDialog("Action type", "Add");

            namedInputTextBox density = new namedInputTextBox("Optical density");
            dialog.addNamedInputTextBox(density);
            namedInputTextBox sample = new namedInputTextBox("Tac value");
            dialog.addNamedInputTextBox(sample);

            dialog.ShowDialog();

            if (dialog.DialogResult.Equals(DialogResult.OK))
            {
                double opticalDensity = 0.0;
                double tacSample = 0.0;

                DataSets.dsModuleStructure2.dtTacCalibrationDataRow row;

                row = dsModuleStructure.dtTacCalibrationData.NewdtTacCalibrationDataRow();

                row.fk_module_id = (string)this.cmbTacSelector.SelectedValue;

                if (!double.TryParse(density.getInputTextValue(), out opticalDensity))
                {
                    MessageBox.Show("The optical density value cannot be parsed");
                    return;
                }
                if (!double.TryParse(sample.getInputTextValue(), out tacSample))
                {
                    MessageBox.Show("The tac semple value cannot be parsed");
                    return;
                }

                row.optical_density = opticalDensity;
                row.tac_sample = tacSample;
                dsModuleStructure.dtTacCalibrationData.AdddtTacCalibrationDataRow(row);
            }
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            int rowCount = dsModuleStructure.dtTacCalibrationData.Rows.Count;

            double[] tacSample = dsModuleStructure.dtTacCalibrationData.AsEnumerable().Select(r => r.Field<double>("tac_sample")).ToArray();
            double[] opticalDesityValue = dsModuleStructure.dtTacCalibrationData.AsEnumerable().Select(r => r.Field<double>("optical_density")).ToArray();
            

            opticalDesityValue = opticalDesityValue.Select(d => Math.Log(d)).ToArray();

            Matrix.Matrix res = Matrix.Matrix.PolyFit(tacSample, opticalDesityValue, 3);

            Console.WriteLine(res);
        }
    }
}
