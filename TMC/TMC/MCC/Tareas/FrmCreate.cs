using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.MCC.Tareas
{
    public partial class FrmCreate : DevExpress.XtraEditors.XtraForm
    {
        public FrmCreate()
        {
            InitializeComponent();
        }

        private void FrmCreate_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Palanquilla' Puede moverla o quitarla según sea necesario.
            this.t_PalanquillaTableAdapter.Fill(this.dSDatos.T_Palanquilla);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Maquina' Puede moverla o quitarla según sea necesario.
            this.t_MaquinaTableAdapter.Fill(this.dSDatos.T_Maquina);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Marca' Puede moverla o quitarla según sea necesario.
            this.t_MarcaTableAdapter.Fill(this.dSDatos.T_Acero);
            t_ParametrosTableAdapter1.Fill(dSDatos.T_Parametros);
            t_Circulacion_AMTableAdapter1.Fill(dSDatos.T_Circulacion_AM);
            t_AceroNormaTableAdapter1.Fill(dSDatos.T_AceroNorma);
            dSDatos.T_Acero.FillName(Properties.Settings.Default.Norma);
            t_MaquinaParametroTableAdapter1.FillBy(dSDatos.T_ParametroValor,false);
         
            
          
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {
                var db = new Dictionary<string, double>();
                var s = (DSMCC.T_MaquinaRow)((DataRowView)tMaquinaBindingSource.Current).Row;
                var tect = s.Calculate(int.Parse(idmaquina.EditValue.ToString()),int.Parse(idacero.EditValue.ToString()), int.Parse(idpalanquilla.EditValue.ToString()), int.Parse(largo.EditValue.ToString()),int.Parse(codigo.EditValue.ToString()));
                var w = tect.idtecnologia;
                t_TecnologiaTableAdapter1.Update(dSDatos.T_Tecnologia);
                foreach (DSMCC.T_ParametroValorRow parametroValorRow in dSDatos.T_ParametroValor)
                    if (parametroValorRow.idsource == w)
                        parametroValorRow.idsource = tect.idtecnologia;
                t_ParametroValorTableAdapter1.Update(dSDatos.T_ParametroValor);
                tect.Reporte(null);
            }
        }
    }
}