using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace TMC.ACATTA.Codificadores
{
    public partial class FrmHornos : DevExpress.XtraEditors.XtraForm
    {
        public FrmHornos()
        {
            InitializeComponent();
        }

        private void t_HornoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_HornoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }
        private void SetTrace()
        {
          ((TMC.FrmMain)  Application.OpenForms[MasterForm.Index]).traceComponent1.DataSets.Add(dSDatos);
 ((TMC.FrmMain)  Application.OpenForms[MasterForm.Index]).traceComponent1.LoadList();
        }
        private void FrmHornos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoHorno' Puede moverla o quitarla según sea necesario.
            this.t_TipoHornoTableAdapter.Fill(this.dSDatos.T_TipoHorno);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoFundicion' Puede moverla o quitarla según sea necesario.
            this.t_TipoFundicionTableAdapter.Fill(this.dSDatos.T_TipoFundicion);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Horno' Puede moverla o quitarla según sea necesario.
            this.t_HornoTableAdapter.Fill(this.dSDatos.T_Horno);
            SetTrace();
        }

        private void repositoryItemGridLookUpEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
          
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_HornoTableAdapter.Update(dSDatos.T_Horno);
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TipoHornoTableAdapter.Update(dSDatos.T_TipoHorno);
        }

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {

        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TipoFundicionTableAdapter.Update(dSDatos.T_TipoFundicion);
        }

        private void FrmHornos_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_TipoHornoTableAdapter.Update(dSDatos.T_TipoHorno);
            t_TipoFundicionTableAdapter.Update(dSDatos.T_TipoFundicion);
            t_HornoTableAdapter.Update(dSDatos.T_Horno);
        }
    }
}