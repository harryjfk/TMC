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
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace TMC.ACATTA.Prediccion
{
    public partial class FrmViewPredecir : DevExpress.XtraEditors.XtraForm
    {
        public FrmViewPredecir()
        {
            InitializeComponent();
        }
        public void FillChart(PreditionAlgorithm.PredictSeries series, PreditionAlgorithm.Properties.PropertiesCalculated calculated)
        {
            FrmPredecir.FillChartControl(chartControl1,series);
        
            //results.Add(result);
            //var result = PreditionAlgorithm.Properties.PredictionFraccion(Serie, ResultDB, 25, 5, 50,
            //                                                              900, 3, 0.1);
            var s = new DevExpress.XtraCharts.Series(calculated.Points.Name, ViewType.ScatterLine);
            //((DevExpress.XtraCharts.ScatterLineSeriesView)s.View).LineStyle.DashStyle = DashStyle.Dash;
            ((DevExpress.XtraCharts.ScatterLineSeriesView)s.View).LineMarkerOptions.Size = 2;
            s.Tag = calculated;
            chartControl1
                .Series.Add(s);
            foreach (var VARIABLE in calculated.Points)
                s.Points.Add(new SeriesPoint(VARIABLE.Inicial,
                                                                   VARIABLE.Temp));
        }
        public FrmPredictPropiedades ParentPredecir { get; set; }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var res = new Dictionary<string, object>();
            res.Add("alg", ParentPredecir.ParentPredecir.radioGroup1.Properties.Items[ParentPredecir.ParentPredecir.radioGroup1.SelectedIndex].Description);
            res.Add("acero", ParentPredecir.ParentPredecir.Acero.nameacero);
            res.Add("norma", ParentPredecir.ParentPredecir.Norma.namenorma);
            var t = ParentPredecir.ParentPredecir.layoutControlItem5.Text.Replace("(°C):", "");
            res.Add("acmtext", t);
            res.Add("acm", ParentPredecir.ResultDB[t]);
            res.Add("ae1", ParentPredecir.ResultDB["Ae1"]);
            res.Add("bs", ParentPredecir.ResultDB["Bs"]);

            res.Add("ms", ParentPredecir.ResultDB["Ms"]);
            var stream = new MemoryStream();
            chartControl1.ExportToImage(stream, ImageFormat.Png);
            res.Add("graphic", stream.ToArray());

            res.Add("g", ParentPredecir.ResultDB["G"]);

            var hv = Math.Round(PreditionAlgorithm.Properties.Dureza.Final(ParentPredecir.ResultDB, ParentPredecir.Vle), 2);
            //labelControl1.Text = "Dureza Vickers(HV): " + t;
            //labelControl2.Text = "Velocidad de extracción(°C/s): " + calculated.VelocidadExtraction;
            //labelControl3.Text = "Dureza RockwellC: " + PreditionAlgorithm.Properties.Dureza.RokwellC(t);
            res.Add("hv", hv);
            res.Add("vle", ParentPredecir.selected.VelocidadExtraction);
            res.Add("hrc", PreditionAlgorithm.Properties.Dureza.RokwellC(hv));
       var frmreport = ((MasterForm) Application.OpenForms[MasterForm.Index]).ReporteForm;
            frmreport.Text = "Reporte de predicción de dureza";
            ParentPredecir.ParentPredecir.dSDatos.AceroPredec.FillNames();
            frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\CurvaCCT.repx", res, ParentPredecir.ParentPredecir.dSDatos.AceroPredec);
            frmreport.ShowDialog(this);
        }
    }
}