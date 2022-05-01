using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TMC.SIAR.Codificadores
{
    public partial class FrmTipo_Formato : Form
    {
        public FrmTipo_Formato()
        {
            InitializeComponent();
        }

        private void t_Tipo_FormatoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_Tipo_FormatoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSDatos);

        }

        private void SetTrace()
        {
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.DataSets.Add(dSDatos);
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.LoadList();
        }

        private void FrmTipo_Formato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tipo_Formato' Puede moverla o quitarla según sea necesario.
            this.t_Tipo_FormatoTableAdapter.Fill(this.dSDatos.T_Tipo_Formato);
            SetTrace();
        }
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_Tipo_FormatoTableAdapter.Update(dSDatos.T_Tipo_Formato);
        }
    }
}
