using System;

namespace TMC.Components.TemperatureControl
{
    public partial class FrmSettings : DevExpress.XtraEditors.XtraForm
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Degradee' Puede moverla o quitarla según sea necesario.
            //this.t_DegradeeTableAdapter.Fill(this.dSDatos.T_Degradee);
            //if (Properties.Settings.Default.DegradeSelect != -1)
            //    gridLookUpEdit1.EditValue = Properties.Settings.Default.DegradeSelect;
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            //t_DegradeeTableAdapter.Update(dSDatos.T_Degradee);
            //if(gridLookUpEdit1.EditValue is int)
            //Properties.Settings.Default.DegradeSelect = (int)gridLookUpEdit1.EditValue;
            //Properties.Settings.Default.Save();
            //DialogResult = System.Windows.Forms.DialogResult.OK;
            //Close();
        }
    }
}