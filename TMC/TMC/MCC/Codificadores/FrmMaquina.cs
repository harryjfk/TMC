using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.MCC.Codificadores
{
    public partial class FrmMaquina : DevExpress.XtraEditors.XtraForm
    {
        public FrmMaquina()
        {
            InitializeComponent();
        }

        private void t_MaquinaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_MaquinaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmMaquina_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Circulacion_AM' Puede moverla o quitarla según sea necesario.
            this.t_Circulacion_AMTableAdapter.Fill(this.dSDatos.T_Circulacion_AM);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Parametros' Puede moverla o quitarla según sea necesario.
            this.t_ParametrosTableAdapter.Fill(this.dSDatos.T_Parametros);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_MaquinaParametro' Puede moverla o quitarla según sea necesario.
            this.t_MaquinaParametroTableAdapter.Fill(this.dSDatos.T_ParametroValor);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Maquina' Puede moverla o quitarla según sea necesario.
            t_PalanquillaTableAdapter1.Fill(dSDatos.T_Palanquilla);
            this.t_MaquinaTableAdapter.Fill(this.dSDatos.T_Maquina);
            dSDatos.T_ParametroValor.maquinaColumn.DefaultValue = true;

        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_MaquinaParametroTableAdapter.Update(dSDatos.T_ParametroValor);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_MaquinaTableAdapter.Update(dSDatos.T_Maquina);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //var s = ((DSDatos.T_MaquinaRow)((DataRowView)t_MaquinaBindingSource.Current).Row).LongitudMetCalc(0.0155, 0.6, 2, 28.5);// para cambiar la dimension cambia la palanquilla en este caso el ultimo 2
           // var s = ((DSDatos.T_MaquinaRow) ((DataRowView) t_MaquinaBindingSource.Current).Row).LargoMetalurgico();
        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_PalanquillaTableAdapter1.Update(dSDatos.T_Palanquilla);

        }

        private void gridView4_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_Circulacion_AMTableAdapter.Update(dSDatos.T_Circulacion_AM);
        }

        private void FrmMaquina_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_MaquinaTableAdapter.Update(dSDatos.T_Maquina);
            t_MaquinaParametroTableAdapter.Update(dSDatos.T_ParametroValor);
            t_PalanquillaTableAdapter1.Update(dSDatos.T_Palanquilla);
            t_Circulacion_AMTableAdapter.Update(dSDatos.T_Circulacion_AM);
        }
    }
}