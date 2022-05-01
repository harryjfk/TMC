using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
//using ACATTA.Reportes;
using DevExpress.Charts.Native;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace TMC.ACATTA.Prediccion
{
    public partial class FrmPredictPropiedades : DevExpress.XtraEditors.XtraForm
    {
        public FrmPredictPropiedades()
        {
            InitializeComponent();
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
        }

        public double te { get { return double.Parse(textEdit1.Text.ToString()); } }

        public double dt { get { return double.Parse(textEdit2.Text.ToString()); } }

        public double mf { get { return double.Parse(textEdit3.Text.ToString()); } }

        public double Vle { get { return double.Parse(textEdit6.Text.ToString()); } }

        public double retTiempo { get { return double.Parse(textEdit5.Text.ToString()); } }

        public double To { get { return double.Parse(textEdit4.Text.ToString()); } }

        public PreditionAlgorithm.PredictSeries Serie { get; set; }
        public Dictionary<String, double> ResultDB { get; set; }
        private void CreateSerieResult()
        {
            int i = 0;
            while (i< chartControl1.Series.Count)
            {
                if (!(chartControl1.Series[i].Tag is PreditionAlgorithm.Properties.PropertiesCalculated))
                    chartControl1.Series.RemoveAt(i);
                else
                    i++;
            }
            var t = GetSeriesOrdered();
            foreach (PreditionAlgorithm.CalculatedPointList calculatedPointList in t)
            {
                var s = new DevExpress.XtraCharts.Series(calculatedPointList.Name, DevExpress.XtraCharts.ViewType.ScatterLine);
                ((DevExpress.XtraCharts.ScatterLineSeriesView)s.View).LineStyle.DashStyle = DashStyle.Dash;
                foreach (PreditionAlgorithm.CalculatedPoint calculatedPoint in calculatedPointList)
                    s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Inicial,
                                                                       calculatedPoint.Temp));
                chartControl1.Series.Add(s);
            }
        }
        private static int CompareDinosByLength(PreditionAlgorithm.CalculatedPoint x, PreditionAlgorithm.CalculatedPoint y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // lengths of the two strings.
                    //
                    if (x.Temp > y.Temp)
                        return 1;
                     if (x.Temp < y.Temp)
                        return -1;
                    return 0
                        ;
                }
            }
        }
        private PreditionAlgorithm.CalculatedPointList GetSerieInitialPoint(String name)
        {
            var r = new PreditionAlgorithm.CalculatedPointList();
            r.Name = name;
            foreach (Series series in chartControl1.Series)
                if (((DevExpress.XtraCharts.Series)series).Tag is PreditionAlgorithm.Properties.PropertiesCalculated)
                {
                    var p = ((PreditionAlgorithm.Properties.PropertiesCalculated)
                             ((DevExpress.XtraCharts.Series)series).Tag);
                    if (p.PtoInicio.ContainsKey(name))
                        r.Add(

                           p.PtoInicio[name]);
                }

            r.Sort(CompareDinosByLength);
            return r;
        }
        private List<PreditionAlgorithm.CalculatedPointList> GetSeriesOrdered()
        {
            var r = new List<PreditionAlgorithm.CalculatedPointList>();
            var t = GetSerieInitialPoint("Ferrita");
            if (t.Count>0)
           r.Add(t);
            t = GetSerieInitialPoint("Perlita");
           if (t.Count > 0)
               r.Add(t);
           t = GetSerieInitialPoint("Bainita");
           if (t.Count > 0)
               r.Add(t);
            return r;
        }

        private DateTime t = DateTime.Now;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(dxValidationProvider1.Validate())
            {
                t = DateTime.Now;

            var result = PreditionAlgorithm.Properties.PredictionFraccion(Serie, ResultDB, te, dt, mf,
                                                     To, retTiempo, Vle,checkEdit2.Checked);
                var w = (DateTime) DateTime.Now - t;

            MessageBox.Show(w.Milliseconds.ToString());
                //results.Add(result);
            //var result = PreditionAlgorithm.Properties.PredictionFraccion(Serie, ResultDB, 25, 5, 50,
            //                                                              900, 3, 0.1);
            var s = new DevExpress.XtraCharts.Series(result.Points.Name, ViewType.ScatterLine);
                ((DevExpress.XtraCharts.ScatterLineSeriesView) s.View).LineMarkerOptions.Size = 2;
            //((DevExpress.XtraCharts.ScatterLineSeriesView)s.View).LineStyle.DashStyle = DashStyle.Dash;
            s.Tag = result;
            chartControl1
                .Series.Add(s);
            foreach (var VARIABLE in result.Points)
                s.Points.Add(new SeriesPoint(VARIABLE.Inicial,
                                                                   VARIABLE.Temp));
            //  if (chartControl2.Series.Count == 0)
           
            UpdateChart(result);
            CreateSerieResult();
            GenerateCurvesCTT();
            } 
        }
        private List<PreditionAlgorithm.Properties.PropertiesCalculated> results =new List<PreditionAlgorithm.Properties.PropertiesCalculated>();
        private  void UpdateChart(PreditionAlgorithm.Properties.PropertiesCalculated calculated)
        {
            selected=calculated;
            chartControl2.Series.Clear();
            var f = new Series("Ferrita", ViewType.Pie)
                        {
                            LegendPointOptions = {PointView = PointView.Argument}
                        };
            chartControl2.Series.Add(f);
            if (calculated.Percents["Ferrita"] > 0)
            f.Points.Add(new SeriesPoint("Ferrita", calculated.Percents["Ferrita"]*100));
            if (calculated.Percents["Perlita"] > 0)
                f.Points.Add(new SeriesPoint("Perlita", calculated.Percents["Perlita"] * 100));
            if (calculated.Percents["Bainita"] > 0)
                f.Points.Add(new SeriesPoint("Bainita", calculated.Percents["Bainita"] * 100));
            if (calculated.Percents["Martensita"] > 0)
                f.Points.Add(new SeriesPoint("Martensita", calculated.Percents["Martensita"] * 100));
            var t = Math.Round(PreditionAlgorithm.Properties.Dureza.Final(ResultDB, calculated.VelocidadExtraction), 2);
            labelControl1.Text = "Dureza Vickers(HV): " +t ;
            labelControl2.Text = "Velocidad de extracción(°C/s): " + calculated.VelocidadExtraction;
            labelControl3.Text = "Dureza RockwellC: " + Math.Round(PreditionAlgorithm.Properties.Dureza.RokwellC(t),2);
        }

        public PreditionAlgorithm.Properties.PropertiesCalculated selected = null;
        private void chartControl1_ObjectSelected(object sender, HotTrackEventArgs e)
        {
            if (e.Object is DevExpress.XtraCharts.Series)
                if (((DevExpress.XtraCharts.Series) e.Object).Tag is PreditionAlgorithm.Properties.PropertiesCalculated)

                    UpdateChart(
                        (PreditionAlgorithm.Properties.PropertiesCalculated)
                        ((DevExpress.XtraCharts.Series) e.Object).Tag);
        }

        private void GenerateCurvesCTT()
        {
            if(checkEdit1.Checked)
            {
               FrmPredecir.FillChartControl(chartControl1,Serie);
            }
            else
            {
                var i = 0;
                while (i<chartControl1.Series.Count)
                {
                    if (chartControl1.Series[i].Tag is PreditionAlgorithm.PredictSeries)
                        chartControl1.Series.RemoveAt(i);
                    else
                        i++;
                }
            }
        }
        private void checkEdit1_Click(object sender, EventArgs e)
        {
        
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            GenerateCurvesCTT();   
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if(selected==null)
                return;
            var view = new FrmViewPredecir();
            view.ParentPredecir = this;
            view.FillChart(Serie,selected);
            view.ShowDialog(this);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var i = 0;
            while (i < chartControl1.Series.Count)
            {
                if (!(chartControl1.Series[i].Tag is PreditionAlgorithm.PredictSeries))
                    chartControl1.Series.RemoveAt(i);
                else
                    i++;
            }
          //  GenerateCurvesCTT();
        }

        public FrmPredecir ParentPredecir { get;set;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            var res = new Dictionary<string, object>();
            res.Add("alg", ParentPredecir.radioGroup1.Properties.Items[ParentPredecir.radioGroup1.SelectedIndex].Description);
            res.Add("acero", ParentPredecir.Acero.nameacero);
            res.Add("norma", ParentPredecir.Norma.namenorma);
            var t = ParentPredecir.layoutControlItem5.Text.Replace("(°C):", "");
            res.Add("acmtext", t);
            res.Add("acm", ResultDB[t]);
            res.Add("ae1", ResultDB["Ae1"]);
            res.Add("bs", ResultDB["Bs"]);

            res.Add("ms", ResultDB["Ms"]);
            var stream = new MemoryStream();
            chartControl1.ExportToImage(stream, ImageFormat.Png);
            res.Add("graphic", stream.ToArray());

            res.Add("g", ResultDB["G"]);

            var hv = Math.Round(PreditionAlgorithm.Properties.Dureza.Final(ResultDB, Vle), 2);
            //labelControl1.Text = "Dureza Vickers(HV): " + t;
            //labelControl2.Text = "Velocidad de extracción(°C/s): " + calculated.VelocidadExtraction;
            //labelControl3.Text = "Dureza RockwellC: " + PreditionAlgorithm.Properties.Dureza.RokwellC(t);
            res.Add("hv",hv);
            res.Add("vle",selected.VelocidadExtraction);
            res.Add("hrc", PreditionAlgorithm.Properties.Dureza.RokwellC(hv));
           var frmreport = ((MasterForm) Application.OpenForms[MasterForm.Index]).ReporteForm;
            frmreport.Text = "Reporte de predicción de dureza";
            ParentPredecir.dSDatos.AceroPredec.FillNames();
            frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\CurvaCCT.repx", res, ParentPredecir.dSDatos.AceroPredec);
            frmreport.ShowDialog(this);
        }
    }
}
