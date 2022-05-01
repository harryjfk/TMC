using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace TMC.ACATTA.Prediccion
{
    public partial class FrmCurveManager : DevExpress.XtraEditors.XtraForm
    {
        public FrmCurveManager()
        {
            InitializeComponent();
        }

        private void FrmCurveManager_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Acero' Puede moverla o quitarla según sea necesario.
            this.t_AceroTableAdapter.Fill(this.dSDatos.T_Acero);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Curva' Puede moverla o quitarla según sea necesario.
            this.t_CurvaTableAdapter.Fill(this.dSDatos.T_Curva);
            t_NormaTableAdapter1.Fill(dSDatos.T_Norma);
            t_AceroNormaTableAdapter1.Fill(dSDatos.T_AceroNorma);
            dSDatos.T_Acero.FillName(Properties.Settings.Default.Norma);
        }

        private void repositoryItemButtonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == ButtonPredefines.Ellipsis)
            {
                var edit = new FrmCurveEdit();
                var g =
                    ((DevExpress.XtraGrid.Views.Grid.GridView)
                     ((DevExpress.XtraGrid.GridControl) ((DevExpress.XtraEditors.ButtonEdit) sender).Parent).FocusedView);
                edit.data = g.FocusedRowHandle < 0
                                ? null
                                : ((DSACATTA.T_CurvaRow)((System.Data.DataRowView)g.GetRow(g.FocusedRowHandle)).Row).datacurva;
                if (edit.ShowDialog(this) == DialogResult.OK)
                    ((DevExpress.XtraEditors.ButtonEdit) sender).EditValue = edit.data;
            }
            else
            {

            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            t_CurvaTableAdapter.Update(dSDatos.T_Curva);
        }
    }
}