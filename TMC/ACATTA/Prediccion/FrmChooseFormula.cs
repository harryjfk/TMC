using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace TMC.ACATTA.Prediccion
{
    public partial class FrmChooseFormula : DevExpress.XtraEditors.XtraForm
    {
        public FrmChooseFormula()
        {
            InitializeComponent();
        }

        private String _pto;

        public String Pto
        {
            get { return _pto; }
            set
            {
                _pto = value;
                t_FormulaTableAdapter.FillBy(dSDatos.T_Formula, value);
                if (dSDatos.T_Formula.Count == 0)
                    t_FormulaTableAdapter.FillBy1(dSDatos.T_Formula, value);
                layoutControlItem5.Visibility = value == "G" ? LayoutVisibility.Always : LayoutVisibility.Never;
                layoutControlItem6.Visibility = layoutControlItem5.Visibility;
            }
        }
        public Dictionary<string, double> DB { get; set; }
        private void FrmChooseFormula_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_AceroPuntoFormula' Puede moverla o quitarla según sea necesario.
                    // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Formula' Puede moverla o quitarla según sea necesario.
         //   this.t_FormulaTableAdapter.Fill(this.dSDatos.T_Formula);

        }
        public double? Value { get; set; }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Value = null;
            try
            {
                if (dxValidationProvider1.Validate())
                {
                if (layoutControlItem5.Visibility == LayoutVisibility.Always)
                   
                {
                    if (DB.ContainsKey("T"))
                        DB["T"] = double.Parse(textEdit2.EditValue.ToString());
                    else
                        DB.Add("T", double.Parse(textEdit2.EditValue.ToString()));
                    if (DB.ContainsKey("t"))
                        DB["t"] = double.Parse(textEdit1.EditValue.ToString());
                    else
                        DB.Add("t", double.Parse(textEdit1.EditValue.ToString()));
                    DB["T"] += 273;
                    DB["t"]*=60;
                }

                Value = Math.Round(Formula.ExecuteCalc(DB),2);
                labelControl1.Text = Value.ToString();
                }
            }
            catch
            {
                labelControl1.Text = "Error en el calculo.\nVerifique que se encuentren todos los datos necesarios para el calculo";
            }


        }
        private DSACATTA.T_FormulaRow Formula { get { return (DSACATTA.T_FormulaRow)((DataRowView)tFormulaBindingSource.Current).Row; } }
        private void gridLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if(gridLookUpEdit1.EditValue is int)
            tFormulaBindingSource.Position = tFormulaBindingSource.Find("idformula",gridLookUpEdit1.EditValue.ToString());
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (Value != null)
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Existen errores en la seleccion de la formula a calcular","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}