using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.ACATTA.Tareas
{
    public partial class FrmEvalHorno : DevExpress.XtraEditors.XtraForm
    {
        public FrmEvalHorno()
        {
            InitializeComponent();
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmEvalHorno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_TipoMaterial' Puede moverla o quitarla según sea necesario.
            this.t_TipoMaterialTableAdapter.Fill(this.dSDatos.T_TipoMaterial);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Acero' Puede moverla o quitarla según sea necesario.
            this.t_AceroTableAdapter.Fill(this.dSDatos.T_Acero);
            t_AceroNormaTableAdapter1.Fill(dSDatos.T_AceroNorma);
            t_NormaTableAdapter1.Fill(dSDatos.T_Norma);
            //   dSDatos.T_T.FillName(Properties.Settings.Default.Norma);
            t_TipoHornoTableAdapter1.Fill(dSDatos.T_TipoHorno);
            t_HornoTableAdapter1.Fill(dSDatos.T_Horno);
            t_CapacidadCalorificaTableAdapter1.Fill(dSDatos.T_CapacidadCalorifica);
            t_CapacidadDeslozeTableAdapter1.Fill(dSDatos.T_CapacidadDesloze);
            FillTree();

        }

        private void FillTree()
        {
            foreach (DSACATTA.T_TipoHornoRow tipoHornoRow in dSDatos.T_TipoHorno)
            {
                var npnode = treeList1.AppendNode(new object[] { tipoHornoRow.nametipohorno }, null);
                foreach (DSACATTA.T_HornoRow tHornoRow in tipoHornoRow.GetT_HornoRows())
                {
                    var node = treeList1.AppendNode(new object[] { tHornoRow.namehorno, tHornoRow }, npnode);
                    node.Tag = tHornoRow;
                }

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var calculateweight = new FrmCalculateWeight();
            if (calculateweight.ShowDialog(this) == DialogResult.OK)
                pesoedit.EditValue = calculateweight.Weight;
        }

        public DSACATTA.T_TipoMaterialRow Material { get { return dSDatos.T_TipoMaterial.FindByidtipomaterial((int)aceroedit.EditValue); } }

        public DSACATTA.T_HornoRow Horno { get
        {
            
          
            return treeList1.FocusedNode.Tag as DSACATTA.T_HornoRow;
        } }
        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {
                var res = Horno.Evaluate(Material, int.Parse(cantpiezasedit.EditValue.ToString()), int.Parse(tempinicialedit.EditValue.ToString()), int.Parse(tempfinaledit.EditValue.ToString()),
                                      float.Parse( potenciaedit.EditValue.ToString()), float.Parse( eficienciaedit.EditValue.ToString()), float.Parse( pesoedit.EditValue.ToString()));
              //  var res = Horno.Evaluate(Material, 20, 50, 850, 50, 59, 2);
             if(res.ContainsKey("mess"))
                 XtraMessageBox.Show(res["mess"].ToString(),"Información",MessageBoxButtons.OK,MessageBoxIcon.Information);

             else
             {
              var frmreport = ((MasterForm) Application.OpenForms[MasterForm.Index]).ReporteForm;
                frmreport.Text = "Reporte de evaluación de horno";
                frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\EvalHorno.repx", res);
                frmreport.ShowDialog(this);
             }
             }
        }

        private void eficienciaedit_KeyDown(object sender, KeyEventArgs e)
        {
        //    e.SuppressKeyPress = !ACINOX.Functions.Validation.IsNum(e.KeyValue);
        }

        private void treeList1_DoubleClick(object sender, EventArgs e)
        {
            var node = treeList1.FocusedNode;
            if (node.Level != 1) return;
            Hornoedit.Text = node.GetValue(0).ToString();
            Hornoedit.Tag = node.GetValue(1);
            Hornoedit.ClosePopup();
            labelControl1.Text = Horno.namehorno;
            labelControl2.Text = Horno.Largo.ToString();
            labelControl3.Text = Horno.Ancho_Diametro.ToString();
            labelControl4.Text = Horno.Altura.ToString();
            labelControl5.Text = Horno.PowerRating.ToString();
            labelControl6.Text = Horno.Eficiencia.ToString();
        }
    }
}