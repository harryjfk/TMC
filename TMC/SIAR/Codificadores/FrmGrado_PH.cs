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
    public partial class FrmGrado_PH : Form
    {
        public FrmGrado_PH()
        {
            InitializeComponent();
        }

        private void t_Grado_PHBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void SetTrace()
        {
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.DataSets.Add(dsDatos1);
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.LoadList();
        }

        private void FrmGrado_PH_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatos1.T_Grado_PH' Puede moverla o quitarla según sea necesario.
            this.t_Grado_PHTableAdapter.Fill(this.dsDatos1.T_Grado_PH);
            SetTrace();

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            this.t_Grado_PHTableAdapter.Update(this.dsDatos1.T_Grado_PH);
        }
    }
}
