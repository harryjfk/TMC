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
    public partial class FrmOpenProject : DevExpress.XtraEditors.XtraForm
    {
        public FrmOpenProject()
        {
            InitializeComponent();
        }
        private void SetTrace()
        {
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.DataSets.Add(dSBCE);
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.LoadList();
        }
        public int idproject
        {
            get
            {
                return ((DSBCE.T_Project_BalanceRow
                        ) ((DataRowView) tProjectBalanceBindingSource.Current).Row).idprojectbalance;
            }
        }
        private void FrmOpenProject_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSBCE.T_Project_Balance' Puede moverla o quitarla según sea necesario.
            this.t_Project_BalanceTableAdapter.Fill(this.dSBCE.T_Project_Balance);
            SetTrace();
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dSBCE.T_Project_Balance.Count == 0)
                XtraMessageBox.Show("Debe crear aunque sea un proyecto", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            else
            {  DialogResult = DialogResult.OK;
            Close();
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (dSBCE.T_Project_Balance.Count == 0)
                XtraMessageBox.Show("Debe crear aunque sea un proyecto", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

       

        
    }
}