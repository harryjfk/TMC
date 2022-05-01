using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.BCE.Codificadores
{
    public partial class FrmPropiedades : DevExpress.XtraEditors.XtraForm
    {
        public FrmPropiedades()
        {
            InitializeComponent();
        }

        private void t_Balance_PropiedadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_Balance_PropiedadBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSBCE);

        }

        private void SetTrace()
        {
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.DataSets.Add(dSBCE);
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.LoadList();
        }

        private void FrmPropiedades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSBCE.T_Balance_Propiedad' Puede moverla o quitarla según sea necesario.
            this.t_Balance_PropiedadTableAdapter.Fill(this.dSBCE.T_Balance_Propiedad);
            SetTrace();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_Balance_PropiedadTableAdapter.Update(dSBCE.T_Balance_Propiedad);
        }
    }
}