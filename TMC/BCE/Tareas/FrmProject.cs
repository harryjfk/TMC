using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using TMC.BCE.Codificadores;

namespace TMC.BCE.Tareas
{
    public partial class FrmProject : DevExpress.XtraEditors.XtraForm
    {
        public FrmProject()
        {
            InitializeComponent();
        }

        private int _idproject;
        public int idproject
        {
            get { return _idproject; }
            set
            {
                _idproject = value;
                t_Project_BalanceTableAdapter1.FillBy(DSBCE.T_Project_Balance, value);
                simpleLabelItem1.Text = Project.name_P;

            }
        }
        public DSBCE.T_Project_BalanceRow Project { get { return (DSBCE.T_Project_BalanceRow)((DataRowView)bindingSource1.Current).Row; } }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var s = new FrmManageProject();
            s.edit = idproject;
            s.ShowDialog(this);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Desea eliminar este proyecto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bindingSource1.RemoveCurrent();
                t_Project_BalanceTableAdapter1.Update(DSBCE.T_Project_Balance);
                Close();
            }
        }

        private void FrmProject_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSBCE.T_Elemento' Puede moverla o quitarla según sea necesario.
            this.t_ElementoTableAdapter.Fill(this.DSBCE.T_Elemento);
            var DefaultMetal = new Dictionary<String, double>()
                            {
                                {"Si", 0.01},
                                {"Al", 0.02},
                                {"Mn", 0.1},
                                {"Fe", 0.0},
                                {"P", 0.004},
                                {"S", 0.045},
                                {"Cr", 0.09},
                                {"C", 0.09},{"SiO2",19.9},{"CaO", 33.0},
                                  {"MgO", 6.8},
                                  {"Al2O3", 7.3},
                                  {"MnO", 5.7},
                                  {"FeO", 20.58},
                                  {"P2O5", 0.0},
                                  {"Ni", 0.01},
                                  {"Cu", 0.26},
                            };
            var DefaultCarga = new Dictionary<String, Double>()
                            {
                                  {"Peso_Cal", 44.28571},
                                  {"Peso_Dolomita", 1.071429},
                                  {"Peso_Carbon", 2.0},
                                  {"Peso_EscoriaRem", 28.57143 },
                                  {"Peso_Carga_MetalicaTotal", 1072.857},
                                  {"Cal_MasaTotal", 3.1}, {"Dolomita_MasaTotal", 0.0},
                                  {"HBI" , 0.0},
                                  {"ChatarraLigera" , 53.1},
                                  {"Escarpa" , 13.1},
                                  {"HierroFundido" , 8.6},
                                  {"ChatarraPesada" , 0.0},
                                  {"Paca" , 0.0},
                                  {"PieLiquido" , 7.0},
                                  {"HRD" , 0.0}

                            };
            SetDataView(tempElementoBindingSource1, DefaultCarga);
            SetDataView(tempElementoBindingSource, DefaultMetal);
        }
        private void SetDataView(BindingSource gridView, Dictionary<String, double> value)
        {
            foreach (KeyValuePair<string, double> keyValuePair in value)
            {
                var t = (DSBCE.TempElementoRow)((DataRowView)gridView.AddNew()).Row;
                gridView.MoveLast();
                if (keyValuePair.Key.IndexOf('_') == -1)
                    try
                    {
                        t.idelemento =
                            ((DSBCE.T_ElementoRow)
                             DSBCE.T_Elemento.Select("codelemento=" + "'" + keyValuePair.Key + "'")[0]).idelemento;
                    }
                    catch
                    {
                        t.propiedad = keyValuePair.Key;
                    }

                else
                    t.propiedad = keyValuePair.Key;
                t.valor = keyValuePair.Value;
                t.EndEdit();

            }

        }
        public Dictionary<String, double> GetDictionaryFromGridView(GridView gridView)
        {
            var r = new Dictionary<String, double>();
            for (int i = 0; i < gridView.RowCount; i++)
            {
                var handle = gridView.GetVisibleRowHandle(i);
                if (handle >= 0)
                {
                    var row = (DSBCE.TempElementoRow)gridView.GetDataRow(handle);
                    var k = "";
                    try
                    {
                        var q = row.idelemento;
                        k = ((DSBCE.T_ElementoRow)DSBCE.T_Elemento.Select("idelemento=" + "'" + q + "'")[0]).codelemento;
                    }
                    catch (Exception)
                    {
                        k = row.propiedad;
                    }


                    r.Add(k, row.valor);
                }

            }
            //gridView.
            return r;
        }

        public EventHandler OnCalculated { get; set; }
        private Dictionary<string, Dictionary<String, double>> _t;
        public Dictionary<string, Dictionary<String, double>> lastCalculated
        {
            get { return _t; }
            set
            {
                _t = value;
                this.Tag = _t; if (OnCalculated != null)
                    OnCalculated(this, null);
            }
        }
  
        
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Algorithm s = new Algorithm();
            //var General = new Dictionary<String, Double>
            //                  {


            //                      {"BaseAcero", 1000.0},  
            //                      {"AcLiquido", 70.0},
            //                      {"CO",0},
            //                      {"CO2",0},
            //                      {"Dens_Aire", 1.29},
            //                      {"Nitrogeno_Aire",79},
            //                      {"Oxigeno_Aire" , 21},
            //                      {"Dens_Nitrogeno",1.29},
            //                      {"Dens_Oxigeno",1.43},
            //                      {"Vol_Aire",29.6},
            //                      {"Vol_Nitrogeno",23.38},
            //                      {"Vol_Oxigeno",6.22},

            //                  };





            //var Gases = new Dictionary<String, Double>()
            //                {
            //                    {"Masa", 187.75},
            //                    {"Peso", 0.0}
            //                };

            var Settings = FrmSettings.GetSettingsAll();
            var Carga = GetDictionaryFromGridView(gridView2);
            var Metal = GetDictionaryFromGridView(gridView1);
            Carga["CO"] = 0;
            Carga["CO2"] = 0;
            //lastCalculated2 = s.Carga_Segun_Escoria_Metal(1, Settings["General"], Metal, Escoria, Carga, Settings["Gases"]);
            lastCalculated = s.Escoria_Segun_Carga_Metal(1, Settings["General"], Metal, Carga, Settings["Gases"],
                                                checkEdit1.Checked);
            var q = new List<String>();
            q.Add("Masa de la Carga");
            q.Add("Proporción de Elementos kg/TAC");
            q.Add("Balance de Metal Fundido ");
            q.Add("Perdida de Elements en kg/t AL");
            q.Add("Perdida de Elementos en %");
            q.Add("Concentración de Hierro en Polvo en Carga Metálica");
            q.Add("Oxidos en la escoria");
            q.Add("Cantidad de Oxigeno requerido por elemento");
            q.Add("Composición de la Escoria por Elemento");
            q.Add("Determinación de Perdida por Ignicion");
            q.Add("Ponderación de Hiero en Post Combustión");
            q.Add("Carga de Óxido de Hierro");
            q.Add("Carbono para Reduccion");
            q.Add("Contenido de Oxigeno");
            q.Add("Datos de los Gases");
            q.Add("Datos de los Metales");
            CreateTabs(q, lastCalculated);
            

        }

        public void CreateTree(XtraTabPage page, object data)
        {
            var xtree = new TreeList();
            xtree.Parent = page;
            xtree.Dock = DockStyle.Fill;
            var prop = xtree.Columns.Add();
            prop.Caption = "Propiedad";
            prop.Visible = true;
            var valor = xtree.Columns.Add();
            valor.Caption = "Valor";
            valor.Visible = true;
            if (data is Dictionary<String, double>)
                foreach (KeyValuePair<string, double> keyValuePair in (Dictionary<String, double>)data)
                {
                    var r = xtree.AppendNode(null, null);
                    var s = keyValuePair.Key.Split('_');
                    var w = s.Length == 2 ? s[0] : keyValuePair.Key;
                    r.SetValue(0, w);
                    r.SetValue(1, keyValuePair.Value);
                }
            else
            {
                var t = (List<KeyValuePair<string, Dictionary<string, double>>>)data;
                foreach (KeyValuePair<string, Dictionary<string, double>> dictionary in t)
                {
                    TreeListNode p = null;

                    foreach (KeyValuePair<string, double> keyValuePair in dictionary.Value)
                    {
                        if (p == null)
                        {
                            p = xtree.AppendNode(null, null);
                            var s = keyValuePair.Key.Split('_');
                            var w = s.Length == 1 ? dictionary.Key : s[1];
                            p.SetValue(0, w);
                        }
                        var r = xtree.AppendNode(null, p);
                        r.SetValue(0, keyValuePair.Key.Split('_')[0]);
                        r.SetValue(1, keyValuePair.Value);
                    }
                }

            }
        }

        private void CreateTabs(List<String> titles, Dictionary<String, Dictionary<String, double>> data)
        {
            xtraTabControl1.TabPages.Clear();
            
            foreach (string title in titles)
            {
                var parent = xtraTabControl1.TabPages.Add(title);
                string title1 = title;
                var q = (from t in data where t.Key.IndexOf(title1) != -1 select t).ToList();
                if (q.Count > 0)
                {
                    if (q.Count == 1)
                        CreateTree(parent, q[0].Value);
                    else
                        CreateTree(parent, q);
                }
               



            }
        }

        private void FrmProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            lastCalculated = null;
        }


    }
}