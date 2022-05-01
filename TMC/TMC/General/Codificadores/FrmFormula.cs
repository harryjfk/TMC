using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.General.Codificadores
{
    public partial class FrmFormula : DevExpress.XtraEditors.XtraForm
    {
        public FrmFormula()
        {
            InitializeComponent();
        }

        private void t_FormulaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_FormulaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmFormula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Constante' Puede moverla o quitarla según sea necesario.
            this.t_ConstanteTableAdapter.Fill(this.dSDatos.T_Constante);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_AceroTipoPunto' Puede moverla o quitarla según sea necesario.
            this.t_AceroTipoPuntoTableAdapter.Fill(this.dSDatos.T_AceroTipoPunto);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_AceroPuntoFormula' Puede moverla o quitarla según sea necesario.
            this.t_AceroPuntoFormulaTableAdapter.Fill(this.dSDatos.T_AceroPuntoFormula);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Formula' Puede moverla o quitarla según sea necesario.
            this.t_FormulaTableAdapter.Fill(this.dSDatos.T_Formula);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_FormulaTableAdapter.Update(dSDatos.T_Formula);
        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_AceroPuntoFormulaTableAdapter.Update(
                dSDatos.T_AceroPuntoFormula);
        }

        private void gridView4_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_ConstanteTableAdapter.Update(dSDatos.T_Constante);
        }
    }
}