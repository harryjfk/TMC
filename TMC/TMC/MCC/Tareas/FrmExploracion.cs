using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System.IO;
using System.Drawing.Imaging;

namespace TMC.MCC.Tareas
{
    public partial class FrmExploracion : DevExpress.XtraEditors.XtraForm
    {
        public FrmExploracion()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            simpleButton2.Enabled = false;
            if (ExplorationAlgorithm.Qcaz(Tiempo, Densidad) < 78000)

            {
            if(dxValidationProvider1.Validate() && (!timer1.Enabled))
            {
                var s = "";
                _wf = new ExplorationAlgorithm.Simulate(Lineas, Tiempo,Altura);
                 
                _wf.Execute();
                for (int j = 0; j < _wf.Lineas; j++)
                {
                    if (_wf.Variables[1].td[j] < 0)
                        s += (j+1) + ", ";

                }
                if (s != "")
                {
                    if (s[s.Length - 2] == ',')
                        s = s.Substring(0, s.Length - 2);
                    UpdateStaticLabel(0, "TD(s) " + s + " es negativo debe disminuir las lineas de vaciado");
                }
                StartAnimation();

            }
                }
            else
            {
                XtraMessageBox.Show("Los minutos a colar exeden la capacidad de acero en la Cazuela","Ciudado",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void StartAnimation()
        {
            arcScaleComponent1.MaxValue = Tiempo;
            //((DevExpress.XtraCharts.XYDiagram)chartControl1.Diagram).AxisY.Range.MaxValue = 7800;
            ((DevExpress.XtraCharts.XYDiagram)chartControl1.Diagram).AxisX.Range.MaxValue = Tiempo;
            
            ((DevExpress.XtraCharts.XYDiagram)chartControl3.Diagram).AxisX.Range.MaxValue = _wf.Variables.Count;
            ((DevExpress.XtraCharts.XYDiagram)chartControl4.Diagram).AxisX.Range.MaxValue = Tiempo;
            ((DevExpress.XtraCharts.XYDiagram)chartControl4.Diagram).AxisY.Range.MaxValue = Lineas+1;
            chartControl1.Series[0].Points.Clear();
            chartControl4.Series.Clear();


            simpleButton2.Enabled = true;
            simpleButton3.Enabled = true;
            simpleButton4.Enabled = true;

            for (int i = 0; i < _wf.Lineas; i++)
            {
                var s = new Series((_wf.Lineas-i).ToString(), ViewType.StepLine);
                ((StepLineSeriesView) s.View).LineMarkerOptions.Size = 5;
                chartControl4.Series.Add(s);
            }
            chartControl3.Series[0].Points.Clear();
            GenerateDTH();
            timer1.Enabled = true;
            simpleButton1.Enabled = false;
            
        }

        private ExplorationAlgorithm.Simulate _wf;
      
        private void UpdateStaticLabel(int imgindex, string text)
        {
            barStaticItem1.ImageIndex = imgindex;
            barStaticItem1.Caption = text;
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            int cl = 0;
            int cn = 0;
            if (int.TryParse(textEdit2.Text, out cn))
            {
                cn = ExplorationAlgorithm.CantLineasNeeded(cn);
               
                int.TryParse(textEdit1.Text, out cl);
                if (cl < cn)
                    UpdateStaticLabel(1, "Para " + textEdit2.Text + " minutos como minimo deben ser " + cn + " Lineas de vaciado");
                else
                    UpdateStaticLabel(2, "La cantidad de lineas a utilizar son correctas");
            }
        }

        private void FrmExploracion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Tecnologia' Puede moverla o quitarla según sea necesario.
            this.t_TecnologiaTableAdapter.Fill(this.dSDatos.T_Tecnologia);
            t_MaquinaTableAdapter1.Fill(dSDatos.T_Maquina);
            t_ParametrosTableAdapter1.Fill(dSDatos.T_Parametros);
            t_MaquinaParametroTableAdapter1.Fill(dSDatos.T_ParametroValor);
        }

        private int i = 0;
      //  private int k = 80;
        private int Tiempo { get { return int.Parse(textEdit2.Text);; } }
        private int Lineas { get { return int.Parse(textEdit1.Text); ; } }
        private double Altura { get { return double .Parse(textEdit3.Text); ; } }
        private DSMCC.T_TecnologiaRow Tecnologia { get { return  (DSMCC.T_TecnologiaRow) ((DataRowView)tTecnologiaBindingSource.Current).Row;  } }
        private void GenerateAceroCazuela(int tf)
        {
            chartControl1.Series[0].Points.Add(new SeriesPoint(tf, ExplorationAlgorithm.Qcaz(Tiempo - tf, Densidad)));
        }
        private void GenerateDTH()
        {
            for (int i = 0; i < _wf.Iterations.Count; i++)
            {
                chartControl3.Series[0].Points.Add(new SeriesPoint(i, _wf.Iterations[i].deltah));

                chartControl3.Series[1].Points.Add(new SeriesPoint(i, _wf.Iterations[i].fo));
            }
        }

        //   chartControl1.Series[0].Points.Add(new SeriesPoint(tf, ExplorationAlgorithm.Qcaz(Tiempo - tf, Densidad)));
       

        

        private void GenerateLinea(int tf)
        {
           
            var i = GetLineaIndex(tf);
               
              chartControl4.Series[i].Points.Add(new SeriesPoint(tf,Lineas-i));
        }

        private int GetLineaIndex(int tf)
        {
            double s = 0;
            for (int i = 0; i < _wf.Lineas; i++)
            {
                s+=_wf.Variables[1].td[i];
                if (s > tf)

                    return i;
            }
            return _wf.Lineas-1;
        }
        private int Densidad
        {
            get
            {

                return int.Parse(Tecnologia.T_PalanquillaRow.T_MaquinaRow.GetParametroValue("pAliq"));
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (i <=  Tiempo)
            {
               int t= (int)(arcScaleComponent1.MaxValue/Tiempo)*(i);
                arcScaleComponent1.Value = t;
                digitalGauge1.Text = t+"mn";
                GenerateAceroCazuela(t);
                GenerateLinea(t);
              //  GenerateDTH(t);
                i++;
            }
            else
            {
                i = 0;
                timer1.Enabled = false;
                simpleButton1.Enabled = true;
            }
        }

        private void chartControl4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var t = _wf.ExportToReport();
            var frmreport = ((MasterForm) Application.OpenForms[MasterForm.Index]).ReporteForm;
            frmreport.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\RepDTH.repx", t[1], null);
            frmreport.ShowDialog(this);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var t = _wf.ExportToReport();
            var frmreport = ((MasterForm)Application.OpenForms[MasterForm.Index]).ReporteForm;

            

            
            var param = new List<DevExpress.XtraReports.Parameters.Parameter>();
            var p = new DevExpress.XtraReports.Parameters.Parameter();
            p.Name = "CL";
            p.Value = Lineas;
            param.Add(p);

            p = new DevExpress.XtraReports.Parameters.Parameter();
            p.Name = "TF";
            p.Value = Tiempo;
            param.Add(p);

            p = new DevExpress.XtraReports.Parameters.Parameter();
            p.Name = "AA";
            p.Value = Altura;
            param.Add(p);
            frmreport.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\RepIteration.repx", t[0], param.ToArray());
            frmreport.ShowDialog(this);

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            var frmreport = ((MasterForm)Application.OpenForms[MasterForm.Index]).ReporteForm;
            var param = new List<DevExpress.XtraReports.Parameters.Parameter>();
            var p = new DevExpress.XtraReports.Parameters.Parameter();
            p.Name = "CL";
            p.Value = Lineas;
            param.Add(p);
            var mem = new MemoryStream();
            p = new DevExpress.XtraReports.Parameters.Parameter();
            p.Name = "TF";
            p.Value = Tiempo;
            param.Add(p);
            p = new DevExpress.XtraReports.Parameters.Parameter();
            p.Name = "AA";
            p.Value = Altura;
            param.Add(p);

            //

            chartControl1.ExportToImage(mem,ImageFormat.Bmp);
            p = new DevExpress.XtraReports.Parameters.Parameter();
            p.Name = "Graph_CAC";
            p.Value = mem.ToArray();
            param.Add(p);
            mem.SetLength(0);

            chartControl3.ExportToImage(mem,ImageFormat.Bmp);
            p = new DevExpress.XtraReports.Parameters.Parameter();
            p.Name = "Graph_Iteration";
            p.Value = mem.ToArray();
            param.Add(p);
            mem.SetLength(0);

            chartControl4.ExportToImage(mem,ImageFormat.Bmp);
            p = new DevExpress.XtraReports.Parameters.Parameter();
            p.Name = "Graph_Lines";
            p.Value = mem.ToArray();
            param.Add(p);
            mem.SetLength(0);

            frmreport.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\RepGraphs.repx", null,param.ToArray());
            frmreport.ShowDialog(this);
            
        }
    }
}