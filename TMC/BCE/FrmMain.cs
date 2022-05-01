using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using TMC.BCE.Codificadores;
using TMC.BCE.Tareas;
using TMC.Components.GraphControl;
using TMC.Properties;

namespace TMC.BCE
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmMain()
        {
            InitializeComponent();
          
        }
        private Form CreateForm(Form form, bool dialog = false)
        {
       
            return ((MasterForm)Application.OpenForms[MasterForm.Index]).CreateForm(form, dialog);

        }
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmPropiedades(), true);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            CreateForm(new FrmSettings(), true);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var s = new FrmNewPatron();
            s.edit = (bool) e.Item.Tag;
            if(s.ShowDialog(this)==DialogResult.OK)
            {
                _openpatron = new FrmPatron();
                _openpatron.OnCalculated = OnCalculated;
                _openpatron.idpatron = s.idpatron;
                CreateForm(_openpatron, false);    
            }
            
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            var s = new FrmManageProject();
            s.edit = -1;
           
            if (s.ShowDialog(this) == DialogResult.OK)
            {
                _openproject = new FrmProject { idproject = s.edit };
                _openproject.OnCalculated = OnCalculated;
                CreateForm(_openproject, false);
            }
            //barButtonItem1.Enabled = s.DialogResult == DialogResult.OK;
            //barButtonItem3.Enabled = barButtonItem1.Enabled;

        }

        private FrmProject _openproject;
        private FrmPatron _openpatron;
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            var a = new FrmOpenProject();
            if(a.ShowDialog(this)==DialogResult.OK)
            {
                _openproject = new FrmProject { idproject = a.idproject };
                _openproject.OnCalculated = OnCalculated;
                CreateForm(_openproject, false);
                }
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            var report = new Dictionary<String, Object>();
            var cont = 0;
            List<String> name = new List<string>();
            name.Add("HBI");
            name.Add("ChatPes");
            name.Add("Escarp");
            name.Add("HierF");
            name.Add("ChatLig");
            name.Add("Paca");
            name.Add("PieL");
            name.Add("HRD");
            
            foreach (KeyValuePair<string, double> keyValuePair in _openproject.lastCalculated["Masa de la Carga"])
            {
                report.Add(name[cont], keyValuePair.Value);
                cont++;
            }

            var frmreport = ((MasterForm)Application.OpenForms[MasterForm.Index]).ReporteForm;
            frmreport.Text = @"Reporte de Masa de la Carga";
            frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\BCE\MASA_CARGA.repx", report, null);
            frmreport.ShowDialog(this);
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            var report = new Dictionary<String, Object>();
            var cont = 0;
            List<String> name = new List<string>();
            name.Add("PE_C");
            name.Add("PE_Mn");
            name.Add("PE_Si");
            name.Add("PE_P");
            name.Add("PE_S");
            name.Add("PE_Fe");
            name.Add("PE_Al");
            name.Add("PE_Ni");
            name.Add("PE_Cr");
            name.Add("PE_Cu");

            foreach (KeyValuePair<string, double> keyValuePair in _openproject.lastCalculated["Proporción de Elementos kg/TAC"])
            {
                report.Add(name[cont], keyValuePair.Value);
                cont++;
            }

            var frmreport = ((MasterForm)Application.OpenForms[MasterForm.Index]).ReporteForm;
            frmreport.Text = @"Reporte de Proporción de los Elementos en kg/t AL";
            frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\BCE\PROPORCION_ELEMENTOS.repx", report, null);
            frmreport.ShowDialog(this);
        }
        private void OnCalculated(object sender,EventArgs e)
        {
            barButtonItem12.Enabled = (sender is FrmPatron) && (( (Form)sender).Tag!=null);
            barButtonItem7.Enabled = (sender is FrmProject) && (((Form)sender).Tag != null);
            barButtonItem8.Enabled = barButtonItem7.Enabled;
            barButtonItem9.Enabled = barButtonItem7.Enabled;
            barButtonItem10.Enabled = barButtonItem7.Enabled;
            barButtonItem11.Enabled = barButtonItem7.Enabled;
        }
        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            var report = new Dictionary<String, Object>();
            var cont = 0;
            List<String> name = new List<string>();
            name.Add("PEE_C");
            name.Add("PEE_Mn");
            name.Add("PEE_Si");
            name.Add("PEE_P");
            name.Add("PEE_S");
            name.Add("PEE_Fe");
            name.Add("PEE_Al");
            name.Add("PEE_Ni");
            name.Add("PEE_Cr");
            name.Add("PEE_Cu");

            foreach (KeyValuePair<string, double> keyValuePair in _openproject.lastCalculated["Perdida de Elements en kg/t AL"])
            {
                report.Add(name[cont], keyValuePair.Value);
                cont++;
            }

            var frmreport = ((MasterForm)Application.OpenForms[MasterForm.Index]).ReporteForm;
            frmreport.Text = @"Reporte de Perdida de Elementos en kg/t AL";
            frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\BCE\PERDIDA_ELEMENTO.repx", report, null);
            frmreport.ShowDialog(this);
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            var report = new Dictionary<String, Object>();
            var cont = 0;
            List<String> name = new List<string>();
            name.Add("PEP_C");
            name.Add("PEP_Mn");
            name.Add("PEP_Si");
            name.Add("PEP_P");
            name.Add("PEP_S");
            name.Add("PEP_Fe");
            name.Add("PEP_Al");
            name.Add("PEP_Ni");
            name.Add("PEP_Cr");
            name.Add("PEP_Cu");

            foreach (KeyValuePair<string, double> keyValuePair in _openproject.lastCalculated["Perdida de Elementos en %"])
            {
                report.Add(name[cont], keyValuePair.Value);
                cont++;
            }

            var frmreport = ((MasterForm)Application.OpenForms[MasterForm.Index]).ReporteForm;
            frmreport.Text = @"Reporte de Perdida de Elementos en %";
            frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\BCE\PROPORCION_ELEMENTOS_PORCIENT.repx", report,null);
            frmreport.ShowDialog(this);
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            var DateS = new DSBCE();
           
            Algorithm algorithm;
            var TableS = DateS.P_ReporteMaterialesElementos.NewP_ReporteMaterialesElementosRow();
            foreach (KeyValuePair<string, double> keyValuePair in _openpatron.lastCalculated)
            {
                
               
                var words = keyValuePair.Key.Split('_');
                
                if (words[0].IndexOf("O") == -1)
                {
                    if (words[1] == "Carga")
                        if (keyValuePair.Value.ToString() != "NeuN")
                            TableS.Carga = keyValuePair.Value.ToString().Substring(0, keyValuePair.Value.ToString().IndexOf('.')+4);
                        else
                            TableS.Carga = "0";
                    if (words[1] == "CargaPorciento")
                        if (keyValuePair.Value.ToString() != "NeuN")
                            TableS.CargaPorciento = keyValuePair.Value.ToString().Substring(0, keyValuePair.Value.ToString().IndexOf('.') + 4);
                        else
                            TableS.CargaPorciento = "0";
                    if (words[1] == "Perdida")
                        if (keyValuePair.Value.ToString() != "NeuN")
                            TableS.Perdida = keyValuePair.Value.ToString().Substring(0, keyValuePair.Value.ToString().IndexOf('.') + 4);
                        else
                            TableS.Perdida = "0";
                    if (words[1] == "PerdidaPorciento")
                        if (keyValuePair.Value.ToString() != "NeuN")
                            TableS.PerdidaPorciento = keyValuePair.Value.ToString().Substring(0, keyValuePair.Value.ToString().IndexOf('.') + 4);
                        else
                            TableS.PerdidaPorciento = "0";

                    if (TableS.Carga != "" && TableS.CargaPorciento != "" && TableS.Perdida != "" && TableS.PerdidaPorciento != "" )
                    {
                        TableS.Elemento = words[0];
                        DateS.P_ReporteMaterialesElementos.AddP_ReporteMaterialesElementosRow(TableS);
                       TableS = DateS.P_ReporteMaterialesElementos.NewP_ReporteMaterialesElementosRow();
                    }
                }

                
            }
            
            
            var frmreport = ((MasterForm)Application.OpenForms[MasterForm.Index]).ReporteForm;
            frmreport.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\BCE\BALANCE_ELEMENTOS.repx", DateS.P_ReporteMaterialesElementos,null);
            // frmreport.load// (Application.StartupPath + @"\Reportes\BCE\OXIDOS_ESCORIA.repx", DateS.P_ReporteMaterialesElementos, null);
            frmreport.ShowDialog(this);
            
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            var report = new Dictionary<String, Object>();
            var cont = 0;
            List<String> name = new List<string>();
            name.Add("OE_MnO");
            name.Add("OE_SiO2");
            name.Add("OE_P2O5");
            name.Add("OE_FeO");
            name.Add("OE_Al2O3");
            name.Add("OE_Cr2O3");

            foreach (KeyValuePair<string, double> keyValuePair in _openproject.lastCalculated["Oxidos en la escoria"])
            {
                report.Add(name[cont], keyValuePair.Value);
                cont++;
            }

            var frmreport = ((MasterForm)Application.OpenForms[MasterForm.Index]).ReporteForm;
            frmreport.Text = @"Reporte de Perdida de Elementos en %";
            frmreport.LoadFromDictionary(Application.StartupPath + @"\Reportes\BCE\OXIDOS_ESCORIA.repx", report, null);
            frmreport.ShowDialog(this);
        }

       
    }
}