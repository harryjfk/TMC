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
    public partial class FrmMaterial : DevExpress.XtraEditors.XtraForm
    {
        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void t_MaterialBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_MaterialBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_CapacidadCalorifica' Puede moverla o quitarla según sea necesario.
            this.t_CapacidadCalorificaTableAdapter.Fill(this.dSDatos.T_CapacidadCalorifica);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_CapacidadDesloze' Puede moverla o quitarla según sea necesario.
            this.t_CapacidadDeslozeTableAdapter.Fill(this.dSDatos.T_CapacidadDesloze);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Material' Puede moverla o quitarla según sea necesario.
            this.t_MaterialTableAdapter.Fill(this.dSDatos.T_Material);
            t_TipoMaterialTableAdapter1.Fill(dSDatos.T_TipoMaterial);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_MaterialTableAdapter.Update(dSDatos.T_Material);
        }

        private void FrmMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            t_MaterialTableAdapter.Update(dSDatos.T_Material);
            t_TipoMaterialTableAdapter1.Update(dSDatos.T_TipoMaterial);
        }

        private void gridView2_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_TipoMaterialTableAdapter1.Update(dSDatos.T_TipoMaterial);
        }

        private void gridView4_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_CapacidadDeslozeTableAdapter.Update(dSDatos.T_CapacidadDesloze);
        }

        private void gridView3_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_CapacidadCalorificaTableAdapter.Update(dSDatos.T_CapacidadCalorifica);
        }
    }
}