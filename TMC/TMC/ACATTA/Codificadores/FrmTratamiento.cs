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
    public partial class FrmTratamiento : DevExpress.XtraEditors.XtraForm
    {
        public FrmTratamiento()
        {
            InitializeComponent();
        }

        private void t_TratamientoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_TratamientoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmTratamiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tratamiento' Puede moverla o quitarla según sea necesario.
            this.t_TratamientoTableAdapter.Fill(this.dSDatos.T_Tratamiento);

        }

        private void FrmTratamiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.t_TratamientoTableAdapter.Update(this.dSDatos.T_Tratamiento);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            this.t_TratamientoTableAdapter.Update(this.dSDatos.T_Tratamiento);
        }
    }
}