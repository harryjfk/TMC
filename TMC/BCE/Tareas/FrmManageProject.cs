using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.BCE.Tareas
{
    public partial class FrmManageProject : DevExpress.XtraEditors.XtraForm
    {
        public FrmManageProject()
        {
            InitializeComponent();
        }

        private int _edit;
        public int edit
        {
            get { return _edit; }
            set
            {
                _edit = value;
                this.t_Patron_BalanceTableAdapter.Fill(this.dSBCE.T_Patron_Balance);

                if (value != -1)
                {
                    Text = "Editar Proyecto";
                    this.t_Project_BalanceTableAdapter.FillBy(this.dSBCE.T_Project_Balance, edit);
                }
                    
                else
                {
                    Text = "Crear Proyecto";
                    tProjectBalanceBindingSource.AddNew();
                    tProjectBalanceBindingSource.MoveLast();
                }}
        }
        private void FrmManageProject_Load(object sender, EventArgs e)
        {
             
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if(dxValidationProvider1.Validate())
            {
                tProjectBalanceBindingSource.EndEdit();
                t_Project_BalanceTableAdapter.Update(dSBCE.T_Project_Balance);
                edit = ((DSBCE.T_Project_BalanceRow)((DataRowView)tProjectBalanceBindingSource.Current).Row).
                idprojectbalance;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}