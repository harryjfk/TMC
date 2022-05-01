using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout.Utils;
using TMC.Components.GraphControl;

namespace TMC.ACATTA.Prediccion
{
    public partial class FrmPredecir : NormaForm
    {
        public FrmPredecir()
        {
            InitializeComponent();
        }
        public override void RefreshData()
        {
            dSDatos.T_Acero.FillName(Properties.Settings.Default.Norma);
            
        }
        private Dictionary<String,double > _default = new Dictionary<string, double>(); 
        private void FrmPredecir_Load(object sender, EventArgs e)
        {
            t_AceroPuntoTableAdapter1.Fill(dSDatos.T_AceroPunto);
            t_AceroTipoPuntoTableAdapter1.Fill(dSDatos.T_AceroTipoPunto);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Elemento' Puede moverla o quitarla según sea necesario.))
            this.t_ElementoTableAdapter.Fill(this.dSDatos.T_Elemento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_AceroElemento' Puede moverla o quitarla según sea necesario.
            this.t_AceroElementoTableAdapter.Fill(this.dSDatos.T_AceroElemento);
            // TODO: esta línea de código carga datos en la tabla 'dSDatos.T_Acero' Puede moverla o quitarla según sea necesario.
            this.t_AceroTableAdapter.Fill(this.dSDatos.T_Acero);
            t_AceroNormaTableAdapter1.Fill(dSDatos.T_AceroNorma);
            t_NormaTableAdapter1.Fill(dSDatos.T_Norma);
            dSDatos.T_Acero.FillName(Properties.Settings.Default.Norma);
            t_ConstanteTableAdapter1.Fill(dSDatos.T_Constante);
            t_CurvaTableAdapter1.Fill(dSDatos.T_Curva);
            _default.Add("C",0.8);
            _default.Add("Cr", 0.01);
            _default.Add("Mo", 0.01);
            _default.Add("Ni", 0.01);
            _default.Add("Si", 0.01);
            _default.Add("Mn", 0.01);
            ElementRanges.Add("C","<2.3");
            ElementRanges.Add("Fe", ">75");
            ElementRanges.Add("Si", "<3.8");
            ElementRanges.Add("Mn", "<1.9");
            ElementRanges.Add("Ni", "<8.9");
            ElementRanges.Add("Cr", "<13.3");
            ElementRanges.Add("Mo", "<4.7");
            ElementRanges.Add("V", "<2.1");
            ElementRanges.Add("W", "<18.6");
            ElementRanges.Add("Al", "<1.3");
            ElementRanges.Add("Cu", "<1.5");
            ElementRanges.Add("Co", "<5.0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
        var s =    PreditionAlgorithm.IntegralK(0.66, 0.01, 0.97, false);
        }
    
        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                var db = dSDatos.AceroPredec.AsDictionary();


                foreach (DSACATTA.T_ConstanteRow constanteRow in dSDatos.T_Constante)
                    db.Add(constanteRow.nameconstante, constanteRow.Value());
                db.Add("E", Math.E);
                db = Strings.OrderDictionary(db);
                var forms = new FrmChooseFormula();

                forms.Pto = ((DevExpress.XtraEditors.ButtonEdit) sender).Tag.ToString();
                forms.DB = db;
                if (forms.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)

                    ((DevExpress.XtraEditors.ButtonEdit) sender).EditValue = forms.Value;


            }
        }
        public DSACATTA.T_AceroRow Acero { get { return (DSACATTA.T_AceroRow)((DataRowView)tAceroBindingSource.Current).Row; } }

       
        
        private void gridLookUpEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {

            checkEdit1.Checked = false;
            if (gridLookUpEdit1.EditValue is int)
            {
                tAceroBindingSource.Position = tAceroBindingSource.Find("idacero", gridLookUpEdit1.EditValue);
                if (Acero.IsHipo())
                    layoutControlItem5.Text = "Ae3(°C)";
                else
                    layoutControlItem5.Text = "Acm(°C)";
                buttonEdit1.Tag = layoutControlItem5.Text;
                layoutControlItem5.Text += ":";
                var ptos = Acero.GetT_AceroPuntoRows();

                buttonEdit5.Text = GetValor(ptos, "G");
                if (Acero.IsHipo())
                    buttonEdit1.Text = GetValor(ptos, "Ae3");
                else
                    buttonEdit1.Text = GetValor(ptos, "Acm");
                buttonEdit2.Text = GetValor(ptos, "Ae1");
                buttonEdit3.Text = GetValor(ptos, "Bs");
                buttonEdit4.Text = GetValor(ptos, "Ms");
                checkEdit1.Enabled = Acero.GetT_CurvaRows().Length > 0;
                if (checkEdit1.Enabled)
                    checkEdit1.Tag = Acero.GetT_CurvaRows()[0];
                var element = Acero.GetT_AceroElementoRows();
                dSDatos.AceroPredec.Clear();
                dSDatos.AceroPredec.AcceptChanges();
                //aceroPredecBindingSource.EndEdit();
                foreach (DSACATTA.T_AceroElementoRow item in element)
                {
                    var elemen = (DSACATTA.AceroPredecRow)((DataRowView)aceroPredecBindingSource.AddNew()).Row;
                    elemen.idelemento = item.idelemento;
                    elemen.valor = (double) ((item.valorfinal + item.valorinicial)/2);

                } 
                aceroPredecBindingSource.EndEdit();
                foreach (var d in _default)
                {
                    int temp = 0;
                    dSDatos.T_Elemento.DefaultView.RowFilter = "codelemento = '" + d.Key+"'";
                    if (dSDatos.T_Elemento.DefaultView.Count > 0)
                    {
                        temp = ((DSACATTA.T_ElementoRow)((DataRowView)dSDatos.T_Elemento.DefaultView[0]).Row).
                            idelemento;
                 
                        if (aceroPredecBindingSource.Find("idelemento",temp)==-1)
                        {
                            var elemen = (DSACATTA.AceroPredecRow)((DataRowView)aceroPredecBindingSource.AddNew()).Row;
                            elemen.idelemento = temp;
                            elemen.valor = d.Value;
                        }
                    }
                }
                dSDatos.T_Elemento.DefaultView.RowFilter="";
                aceroPredecBindingSource.Filter = "";
                aceroPredecBindingSource.EndEdit();
                
            }



        }

        private string GetValor(DSACATTA.T_AceroPuntoRow[] ptos, string s)
        {
            foreach (DSACATTA.T_AceroPuntoRow aceroPuntoRow in ptos)
                if (aceroPuntoRow.T_AceroTipoPuntoRow.nametipopunto == s)
                    return aceroPuntoRow.valor.ToString();
            return "";
        }
        private int GetindexList(string s)
        {
            for (int index = 0; index < checkedListBoxControl1.Items.Count; index++)
            {
                CheckedListBoxItem item = checkedListBoxControl1.Items[index]; if (item.Description == s)
                    return index;
            }
            return -1;
        }

        private void aceroPredecBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            var v = dSDatos.AceroPredec.FeValue();
            if( v >100)
                labelControl1.Text ="Valor sobrepasado";
            else
                if(v<0)
                     labelControl1.Text ="Valor invalido";
                else
            labelControl1.Text = v.ToString();
            if(dSDatos.AceroPredec.GetCarbono()==null)
            {
                labelControl1.Text = "No existe carbono";
            }
            else
            {
            var r = dSDatos.AceroPredec.PausibleCurves();
            foreach (CheckedListBoxItem item in checkedListBoxControl1.Items)
                item.CheckState = CheckState.Unchecked;
            foreach (string s in r)
                checkedListBoxControl1.Items[GetindexList(s)].CheckState = CheckState.Checked;
        }}

        private PreditionAlgorithm.PredictSeries serie = null;
        private Dictionary<String, double> ResultDB = null;
        public static void FillChartControl(ChartControl chart, PreditionAlgorithm.PredictSeries serie  )
        {
            //chart.Series.Clear();
            foreach (var predictSeries in serie)
                if(predictSeries!=null)
            {
               if(predictSeries.Count==1)
               {
                   var s = new DevExpress.XtraCharts.Series(predictSeries.Name, DevExpress.XtraCharts.ViewType.ScatterLine);
                   ((DevExpress.XtraCharts.ScatterLineSeriesView)s.View).LineStyle.DashStyle = DashStyle.Dash;
                   ((DevExpress.XtraCharts.ScatterLineSeriesView)s.View).LineMarkerOptions.Size = 2;
                   chart
                       .Series.Add(s);
                   // s.View.Color = item.Color;
                   foreach (var calculatedPoint in predictSeries)
                   {
                       if (calculatedPoint.Inicial != 0)
                       s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Inicial,
                                                                          calculatedPoint.Temp));
                       if(calculatedPoint.Final!=0)
                       s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Final,
                                                                          calculatedPoint.Temp));
                   }
                   s.Tag = serie;
               }
               else
               {
                           var s = new DevExpress.XtraCharts.Series(predictSeries.Name + " Inicial", DevExpress.XtraCharts.ViewType.ScatterLine);
                s.Tag = serie;
                ((DevExpress.XtraCharts.ScatterLineSeriesView)s.View).LineMarkerOptions.Size = 2;
                  var    f = new DevExpress.XtraCharts.Series(predictSeries.Name + "Final", DevExpress.XtraCharts.ViewType.ScatterLine);
                  ((DevExpress.XtraCharts.ScatterLineSeriesView)f.View).LineMarkerOptions.Size = 2;
                   f.Tag = serie;
                    chart
                      .Series.Add(s);

                  chart
                          .Series.Add(f);
                  // s.View.Color = item.Color;
                  foreach (var calculatedPoint in predictSeries)
                  {
                      if (calculatedPoint.Inicial != 0)
                      s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Inicial,
                                                                         calculatedPoint.Temp));
                      if (calculatedPoint.Final != 0)
                      f.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Final,
                                                                         calculatedPoint.Temp));

                      //if (px != null && py != null)
                      //s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(px, py));
                  }
               }
            }
        }
        private void Test()
        {
            serie = new PreditionAlgorithm.PredictSeries();
            var tserie = new PreditionAlgorithm.CalculatedPointList();
            tserie.Name = "Ferrita";
            tserie.Add(new PreditionAlgorithm.CalculatedPoint(){Final = 0,Inicial = Math.Pow(10,4),Temp = 850});
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = Math.Pow(10, 3.5), Temp = 850 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = Math.Pow(10, 3), Temp = 845 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = Math.Pow(10, 2.5), Temp = 840 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = Math.Pow(10, 2), Temp = 830 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = Math.Pow(10, 1.5), Temp = 820 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = Math.Pow(10, 1), Temp = 800 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 5, Temp = 780 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 1.2, Temp = 740 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.7, Temp = 720 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.5, Temp = 700 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.4, Temp = 680 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.3, Temp = 660 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.2, Temp = 630 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.15, Temp = 600 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.2, Temp = 560 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.3, Temp = 540 });
            tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.5, Temp = 510 });
       serie.Add(tserie);
        tserie = new PreditionAlgorithm.CalculatedPointList();
       tserie.Name = "Perlita";
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = Math.Pow(10, 4), Temp = 700 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = Math.Pow(10, 3.5), Temp = 700 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = Math.Pow(10, 3), Temp = 695 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = Math.Pow(10, 4), Inicial = Math.Pow(10, 1.8), Temp = 665 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = Math.Pow(10, 2), Inicial = 4, Temp = 630 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = Math.Pow(10, 1.2), Inicial = 2.5, Temp = 615 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = Math.Pow(10, 1), Inicial = 2, Temp = 600 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 9, Inicial = 1.8, Temp = 580 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 10, Inicial = 1.8, Temp = 550 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = Math.Pow(10, 1.2), Inicial = 0, Temp = 500 });
       serie.Add(tserie);
       tserie = new PreditionAlgorithm.CalculatedPointList();
       tserie.Name = "Bainita";
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial =9, Temp = 580 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 4, Temp = 570 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 2.5, Temp = 560 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial =1.8, Temp = 550 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 1.3, Temp = 540 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.8, Temp = 525 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = Math.Pow(10, 1.2), Inicial = 0.4, Temp = 500 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 0, Inicial = 0.3, Temp = 490 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 6, Inicial = 0.2, Temp = 470 });
       tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 4, Inicial = 0.15, Temp = 450 });
    //   tserie.Add(new PreditionAlgorithm.CalculatedPoint() { Final = 3, Inicial = 0, Temp = 410 });
       serie.Add(tserie);
    
         FillChartControl(chartControl1,serie);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ResultDB = dSDatos.AceroPredec.AsDictionary();

            ResultDB.Add("Ae1", double.Parse(buttonEdit2.EditValue.ToString()));
            ResultDB.Add("Bs", double.Parse(buttonEdit3.EditValue.ToString()));
            ResultDB.Add("Ms", double.Parse(buttonEdit4.EditValue.ToString()));
            ResultDB.Add("G", double.Parse(buttonEdit5.EditValue.ToString()));
            ResultDB.Add("DT", double.Parse(textEdit1.EditValue.ToString()));
            ResultDB.Add(layoutControlItem5.Text.Replace("(°C):", ""),
                         double.Parse(buttonEdit1.EditValue.ToString()));
            foreach (DSACATTA.T_ConstanteRow VARIABLE in dSDatos.T_Constante)
                ResultDB.Add(VARIABLE.nameconstante, VARIABLE.Value());

            ResultDB = Strings.OrderDictionary(ResultDB);
            Test();
            //simpleButton2.Enabled = false;
            //try
            //{
            //    var b = IsValid();
            //    if (dxValidationProvider1.Validate() && b)
            //    {
            //        ResultDB = dSDatos.AceroPredec.AsDictionary();

            //        ResultDB.Add("Ae1", double.Parse(buttonEdit2.EditValue.ToString()));
            //        ResultDB.Add("Bs", double.Parse(buttonEdit3.EditValue.ToString()));
            //        ResultDB.Add("Ms", double.Parse(buttonEdit4.EditValue.ToString()));
            //        ResultDB.Add("G", double.Parse(buttonEdit5.EditValue.ToString()));
            //        ResultDB.Add("DT", double.Parse(textEdit1.EditValue.ToString()));
            //        ResultDB.Add(layoutControlItem5.Text.Replace("(°C):", ""),
            //                     double.Parse(buttonEdit1.EditValue.ToString()));
            //        foreach (DSDatos.T_ConstanteRow VARIABLE in dSDatos.T_Constante)
            //            ResultDB.Add(VARIABLE.nameconstante, VARIABLE.Value());

            //        ResultDB = Strings.OrderDictionary(ResultDB);
            //        try
            //        {
            //            serie = PreditionAlgorithm.Calculate(ResultDB, (bool) radioGroup1.EditValue,
            //                                                 int.Parse(textEdit1.EditValue.ToString()));
            //            chartControl1.Series.Clear();
            //            for (int index = 0; index < serie.Count; index++)
            //            {
            //                PreditionAlgorithm.CalculatedPointList calculatedPoints = serie[index];
            //                if (index < 3)
            //                {
            //                    if (calculatedPoints != null)
            //                    {
            //                        Series f = null;
            //                        var s = new DevExpress.XtraCharts.Series(calculatedPoints.Name + " Inicial",
            //                                                                 DevExpress.XtraCharts.ViewType.ScatterLine);
            //                        ((DevExpress.XtraCharts.ScatterLineSeriesView) s.View).LineMarkerOptions.Size = 2;
            //                        if (calculatedPoints.Name != "Ferrita" ||
            //                            checkedListBoxControl1.Items[1].CheckState == CheckState.Checked)
            //                            f = new DevExpress.XtraCharts.Series(calculatedPoints.Name + "Final",
            //                                                                 DevExpress.XtraCharts.ViewType.ScatterLine);
            //                        chartControl1
            //                            .Series.Add(s);
            //                        if (f != null)
            //                        {
            //                            chartControl1
            //                                .Series.Add(f);
            //                            ((DevExpress.XtraCharts.ScatterLineSeriesView) f.View).LineMarkerOptions.Size =
            //                                2;
            //                        }
            //                        // s.View.Color = item.Color;
            //                        foreach (var calculatedPoint in calculatedPoints)
            //                        {
            //                            s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Inicial,
            //                                                                               calculatedPoint.Temp));
            //                            if (f != null)
            //                                f.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Final,
            //                                                                                   calculatedPoint.Temp));

            //                            //if (px != null && py != null)
            //                            //s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(px, py));
            //                        }
            //                    }
            //                }
            //                else
            //                {
            //                    if (calculatedPoints != null)
            //                    {
            //                        var s = new DevExpress.XtraCharts.Series(calculatedPoints.Name,
            //                                                                 DevExpress.XtraCharts.ViewType.ScatterLine);
            //                        ((DevExpress.XtraCharts.ScatterLineSeriesView) s.View).LineStyle.DashStyle =
            //                            DashStyle.Dash;
            //                        ((DevExpress.XtraCharts.ScatterLineSeriesView) s.View).LineMarkerOptions.Size = 2;
            //                        chartControl1
            //                            .Series.Add(s);
            //                        // s.View.Color = item.Color;
            //                        foreach (var calculatedPoint in calculatedPoints)
            //                        {
            //                            s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Inicial,
            //                                                                               calculatedPoint.Temp));
            //                            s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Final,
            //                                                                               calculatedPoint.Temp));

            //                            //if (px != null && py != null)
            //                            //s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(px, py));
            //                        }
            //                    }
            //                }
            //            }
            //            //foreach (Serie item in t.Series)
            //            //{
            //            //    var s = new DevExpress.XtraCharts.Series(item.Name, DevExpress.XtraCharts.ViewType.ScatterLine);
            //            //    chartControl1
            //            //        .Series.Add(s);
            //            //    s.View.Color = item.Color;
            //            //    foreach (SeriePoint pt in item.Points)
            //            //    {
            //            //    var px=   t.Axiss[0].ValueFromPoint(pt.Point);
            //            //       var py = t.Axiss[1].ValueFromPoint(pt.Point);
            //            //       if (px != null && py != null)
            //            //        s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(py,px));


            //            //        //if (px != null && py != null)
            //            //        //s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(px, py));
            //            //    }
            //            //}
            //            simpleButton2.Enabled = true;
            //        }
            //        catch (Exception ex)
            //        {
            //            if (ex.Message != "")
            //                MessageBox.Show(ex.Message);
            //            else

            //                MessageBox.Show("Error calculando las curvas");

            //        }


            //    }
            //}
            //catch (Exception ex)
            //{
            //    if (ex.Message != "")
            //        MessageBox.Show(ex.Message);
            //    else

            //        MessageBox.Show("Error calculando las curvas");

            //}
            //simpleButton3.Enabled = simpleButton2.Enabled;
        }

        private  Dictionary<String, String> ElementRanges =new Dictionary<string, string>();
        private bool IsValid()
        {
            foreach (var VARIABLE in dSDatos.AceroPredec)
            {
                if (VARIABLE.T_ElementoRow.codelemento == "C")
                {
                    if (VARIABLE.valor < 0.25)
                        layoutControlItem7.Visibility = LayoutVisibility.Never;
                    else
                        layoutControlItem7.Visibility = LayoutVisibility.Always;
                    break;

                }

            }
            var t = "";

            foreach (DSACATTA.AceroPredecRow aceroElementoRow in dSDatos.AceroPredec)
                if(ElementRanges.ContainsKey(aceroElementoRow.T_ElementoRow.codelemento))
            {
                var r = ElementRanges[aceroElementoRow.T_ElementoRow.codelemento];
                var c = new NCalc.Expression(aceroElementoRow.valor+ r).Evaluate();
                if (((bool) c) != true)
                    t += aceroElementoRow.T_ElementoRow.codelemento + " Rango tiene que ser " + r+"\n";
            }
            if(t!="")
            throw new Exception("Existen elementos fuera de rango :\n"+t);
            return true;
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var prepprop = new FrmPredictPropiedades();
            prepprop.Serie = serie;
            prepprop.ResultDB = ResultDB;
            prepprop.ParentPredecir = this;
            if(prepprop.ShowDialog(this)==DialogResult.OK)
            {
            //PreditionAlgorithm.CalculatedPointList t = null;
            //PreditionAlgorithm.Properties.PredictionFraccion(serie, ResultDB, 25, 5, 50,
            //                                        900, 3, 0.1,out t);
            //    var s = new DevExpress.XtraCharts.Series(t.Name, DevExpress.XtraCharts.ViewType.ScatterLine);
            //    ((DevExpress.XtraCharts.ScatterLineSeriesView)s.View).LineStyle.DashStyle = DashStyle.Dash;

            //    chartControl1
            //        .Series.Add(s);
            //foreach (var VARIABLE in t)
            //{
            //    s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(VARIABLE.Inicial,
            //                                                               VARIABLE.Temp));
            //}
                //PreditionAlgorithm.Properties.Predict(serie, ResultDB, prepprop.te, prepprop.dt, prepprop.mf,
                //                                      prepprop.To, prepprop.retTiempo, prepprop.Vle);
            }
        }

        private void checkEdit1_Click(object sender, EventArgs e)
        {
         
        }

        public DSACATTA.T_NormaRow Norma { get { return dSDatos.T_Norma.FindByidnorma(Properties.Settings.Default.Norma); } }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var res = new Dictionary<string, object>();
            res.Add("alg", radioGroup1.Properties.Items[radioGroup1.SelectedIndex].Description);
            res.Add("acero", Acero.nameacero);
            res.Add("norma", Norma.namenorma);
            var t = layoutControlItem5.Text.Replace("(°C):", "");
            res.Add("acmtext", t);
            res.Add("acm", ResultDB[t]);
            res.Add("ae1", ResultDB["Ae1"]);
            res.Add("bs", ResultDB["Bs"]);

            res.Add("ms", ResultDB["Ms"]);
            var stream = new MemoryStream();
            chartControl1.ExportToImage(stream,ImageFormat.Png);
            res.Add("graphic", stream.ToArray());

            res.Add("g", ResultDB["G"]);


  var frmreport = ((MasterForm) Application.OpenForms[MasterForm.Index]).ReporteForm;
            frmreport.Text = "Reporte de curvas TTT";
            dSDatos.AceroPredec.FillNames();
            frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\CurvaTT.repx", res, dSDatos.AceroPredec);
            frmreport.ShowDialog(this);
        }

        private void checkEdit1_Properties_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkEdit1.CheckState == CheckState.Checked)
            {
                var data = ((DSACATTA.T_CurvaRow) checkEdit1.Tag).datacurva;
                var mem = new MemoryStream(data);
                var graphobject = UCGraphControl.LoadFromStreamGeneral(mem);

                serie = PreditionAlgorithm.PredictSeries.FromGraphObject(graphobject);
                foreach (PreditionAlgorithm.CalculatedPointList calculatedPoints in serie)
                {
                       Series f = null;
                        var s = new DevExpress.XtraCharts.Series(calculatedPoints.Name + " Inicial", DevExpress.XtraCharts.ViewType.ScatterLine);
                        ((DevExpress.XtraCharts.ScatterLineSeriesView)s.View).LineMarkerOptions.Size = 2;
                        if (calculatedPoints.Name != "Ferrita" || checkedListBoxControl1.Items[1].CheckState == CheckState.Checked)
                            f = new DevExpress.XtraCharts.Series(calculatedPoints.Name + "Final", DevExpress.XtraCharts.ViewType.ScatterLine);
                        chartControl1
                            .Series.Add(s);
                        if (f != null)
                        {
                            chartControl1
                             .Series.Add(f);
                            ((DevExpress.XtraCharts.ScatterLineSeriesView)f.View).LineMarkerOptions.Size = 2;
                        }
                     
                        // s.View.Color = item.Color;
                        foreach (var calculatedPoint in calculatedPoints)
                        {
                            s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Inicial,
                                                                               calculatedPoint.Temp));
                            if (f != null)
                                f.Points.Add(new DevExpress.XtraCharts.SeriesPoint(calculatedPoint.Final,
                                                                                   calculatedPoint.Temp));

                            //if (px != null && py != null)
                            //s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(px, py));
                        }
                    
                }
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            try
            {
                IsValid();

                
            }
            catch (Exception ex)
            {
                
                 MessageBox.Show(ex.Message);
            }
        }


    }
}