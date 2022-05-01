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
    public partial class FrmManageProject : DevExpress.XtraEditors.XtraForm
    {
        public FrmManageProject()
        {
            InitializeComponent();
        }

        private void t_Proyecto_Balance_BCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.t_Proyecto_Balance_BCBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSBCE);

        }

        private int _edit=-1;
        public int edit { get { return _edit; } set { _edit = value;

            if(edit!=null)
        this.t_Proyecto_Balance_BCTableAdapter.FillBy(this.dSBCE.T_Proyecto_Balance_BC,edit);
        } }
        private void FrmManageProject_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSBCE.T_Tipo_Propiedad_Balance' Puede moverla o quitarla según sea necesario.
            this.t_Tipo_Propiedad_BalanceTableAdapter.Fill(this.dSBCE.T_Tipo_Propiedad_Balance);
            // TODO: esta línea de código carga datos en la tabla 'dSBCE.T_Balance_Propiedad' Puede moverla o quitarla según sea necesario.
            this.t_Balance_PropiedadTableAdapter.Fill(this.dSBCE.T_Balance_Propiedad);
            // TODO: esta línea de código carga datos en la tabla 'dSBCE.T_Proyecto_Balance_BC' Puede moverla o quitarla según sea necesario.
        

        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            t_Proyecto_Balance_BCTableAdapter.Update(dSBCE.T_Proyecto_Balance_BC);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}