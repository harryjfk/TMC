using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//using ACATTA.Reportes;
using DevExpress.XtraEditors;

namespace TMC.ACATTA.Tareas
{
    public partial class FrmDeterminarTT : DevExpress.XtraEditors.XtraForm
    {
        public FrmDeterminarTT()
        {
            InitializeComponent();
        }

        private void FrmDeterminarTT_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoPropiedadSol' Puede moverla o quitarla según sea necesario.
            this.t_TipoPropiedadSolTableAdapter.Fill(this.dSDatos.T_TipoPropiedadSol);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Acero' Puede moverla o quitarla según sea necesario.
            this.t_AceroTableAdapter.Fill(this.dSDatos.T_Acero);
            t_NormaTableAdapter1.Fill(dSDatos.T_Norma);
            t_AceroNormaTableAdapter1.Fill(dSDatos.T_AceroNorma);
            dSDatos.T_Acero.FillName(Properties.Settings.Default.Norma);
        }
        public DSACATTA.T_AceroRow Acero { get { return (DSACATTA.T_AceroRow)((DataRowView)tAceroBindingSource.Current).Row; } }
        public DSACATTA.T_TipoPropiedadSolRow Propiedad { get { return (DSACATTA.T_TipoPropiedadSolRow)((DataRowView)tTipoPropiedadSolBindingSource.Current).Row; } }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {
                t_TipoTratamientoTableAdapter1.Fill(dSDatos.T_TipoTratamiento);
                t_TratamientoTableAdapter1.Fill(dSDatos.T_Tratamiento);
                t_TratamientoDeslozeTableAdapter1.Fill(dSDatos.T_TratamientoDesloze);
                //t_TipoPropiedadSolTableAdapter.Fill(dSDatos.T_TipoPropiedadSol);


                var t = Acero.DeterminarTT(Propiedad, int.Parse(textEdit1.EditValue.ToString()));
                if (t.Count == 0)
                    XtraMessageBox.Show(@"La propiedad seleccionada no está definida para este tipo de acero");
                else
                {

                 var frmreport = ((MasterForm) Application.OpenForms[MasterForm.Index]).ReporteForm;
                 frmreport.Text = "Reporte de determinación de tratamiento termico";
                 frmreport.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\DetTratamiento.repx", t,null);
                      frmreport.ShowDialog(this);
                }
            }
        }

        private void gridLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            tAceroBindingSource.Position = tAceroBindingSource.Find("idacero", gridLookUpEdit1.EditValue);
        }

        private void gridLookUpEdit2_Properties_EditValueChanged(object sender, EventArgs e)
        {
            tTipoPropiedadSolBindingSource.Position = tTipoPropiedadSolBindingSource.Find("idtipopropiedad", gridLookUpEdit2.EditValue);
        }
    }
}