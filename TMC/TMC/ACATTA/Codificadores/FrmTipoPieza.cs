using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.ACATTA.Codificadores
{
    public partial class FrmTipoPieza : DevExpress.XtraEditors.XtraForm
    {
        public FrmTipoPieza()
        {
            InitializeComponent();
        }

        private void t_TipoPiezaGeometriaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_TipoPiezaGeometriaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmTipoPieza_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_SeparacionPieza' Puede moverla o quitarla según sea necesario.
            this.t_SeparacionPiezaTableAdapter.Fill(this.dSDatos.T_SeparacionPieza);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_ColocacionPieza' Puede moverla o quitarla según sea necesario.
            this.t_ColocacionPiezaTableAdapter.Fill(this.dSDatos.T_ColocacionPieza);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoPieza' Puede moverla o quitarla según sea necesario.
            this.t_TipoPiezaTableAdapter.Fill(this.dSDatos.T_TipoPieza);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoPropiedadSol' Puede moverla o quitarla según sea necesario.
            this.t_TipoPropiedadSolTableAdapter.Fill(this.dSDatos.T_TipoPropiedadSol);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoPiezaGeometria' Puede moverla o quitarla según sea necesario.
            this.t_TipoPiezaGeometriaTableAdapter.Fill(this.dSDatos.T_TipoPiezaGeometria);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TipoPiezaGeometriaTableAdapter.Update(dSDatos.T_TipoPiezaGeometria);
        }

        private void FrmTipoPieza_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_TipoPiezaGeometriaTableAdapter.Update(dSDatos.T_TipoPiezaGeometria);
            t_TipoPiezaTableAdapter.Update(dSDatos.T_TipoPieza);
            t_TipoPropiedadSolTableAdapter.Update(dSDatos.T_TipoPropiedadSol);
            t_ColocacionPiezaTableAdapter.Update(dSDatos.T_ColocacionPieza);
            t_SeparacionPiezaTableAdapter.Update(dSDatos.T_SeparacionPieza);
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TipoPropiedadSolTableAdapter.Update(dSDatos.T_TipoPropiedadSol);
        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TipoPiezaTableAdapter.Update(dSDatos.T_TipoPieza);
        }

        private void gridView4_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_ColocacionPiezaTableAdapter.Update(dSDatos.T_ColocacionPieza);
        }

        private void gridView5_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_SeparacionPiezaTableAdapter.Update(dSDatos.T_SeparacionPieza);
        }
    }
}