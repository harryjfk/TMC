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
    public partial class FrmParametros : DevExpress.XtraEditors.XtraForm
    {
        public FrmParametros()
        {
            InitializeComponent();
        }

        private void t_ParametrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_ParametrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmParametros_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Parametros' Puede moverla o quitarla según sea necesario.
            this.t_ParametrosTableAdapter.Fill(this.dSDatos.T_Parametros);

        }

       
        private void FrmParametros_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_ParametrosTableAdapter.Update(dSDatos.T_Parametros);
        }

 

        private void gridView1_RowUpdated_1(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_ParametrosTableAdapter.Update(dSDatos.T_Parametros);
        }
    }
}