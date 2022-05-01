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
    public partial class FrmCirculacion_AM : DevExpress.XtraEditors.XtraForm
    {
        public FrmCirculacion_AM()
        {
            InitializeComponent();
        }

        private void FrmCirculacion_AM_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Palanquilla' Puede moverla o quitarla según sea necesario.
            this.t_PalanquillaTableAdapter.Fill(this.dSDatos.T_Palanquilla);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Circulacion_AM' Puede moverla o quitarla según sea necesario.
            this.t_Circulacion_AMTableAdapter.Fill(this.dSDatos.T_Circulacion_AM);

        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_Circulacion_AMTableAdapter.Update(dSDatos.T_Circulacion_AM);
        }
    }
}