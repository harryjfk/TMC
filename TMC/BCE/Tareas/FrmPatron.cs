using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using TMC.BCE.Codificadores;

namespace TMC.BCE.Tareas
{
    public partial class FrmPatron : DevExpress.XtraEditors.XtraForm
    {
        public FrmPatron()
        {
            InitializeComponent();
        }
        public int idpatron
        {
            get { return ((DSBCE.T_Patron_BalanceRow)((DataRowView)tPatronBalanceBindingSource.Current).Row).idpatron; }
            set
            {
                this.t_Patron_BalanceTableAdapter.Fill(this.dSBCE.T_Patron_Balance);
                tPatronBalanceBindingSource.Position = tPatronBalanceBindingSource.Find("idpatron", value);
            }
        }
        private void FrmPatron_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'dSBCE.T_Elemento' Puede moverla o quitarla según sea necesario.
            this.t_ElementoTableAdapter.Fill(this.dSBCE.T_Elemento);
            t_Balance_PropiedadTableAdapter1.Fill(dSBCE.T_Balance_Propiedad);
            var Default_Carga = new Dictionary<String, Double>()
                            {
                                  {"Peso_Cal", 44.28571},
                                  {"Peso_Dolomita", 1.071429},
                                  {"Peso_Carbon", 2.0},
                                  {"Peso_Carga_MetalicaTotal", 1072.857},
                                  {"Cal_MasaTotal", 3.1}, {"Dolomita_MasaTotal", 0.0},
                                
                            };
            var Default_Escoria = new Dictionary<String, double>()
                              {
                                  {"SiO2", 19.9},
                                  {"CaO", 33.0},
                                  {"MgO", 6.8},
                                  {"Al2O3", 7.3},
                                  {"MnO", 5.7},
                                  {"FeO", 20.58},
                                  {"P2O5", 0.3427398},
                                  {"S", 0.07463172},
                                  {"Cr2O3", 0.9261},
                                  {"C", 0.0},
                                  {"Mn",0.1},{"Fe",99.796},
                              };
            var Default_Metal = new Dictionary<String, double>()
                            {
                                {"Si", 0.01},
                                {"Al", 0.0},
                                {"Mn", 0.1},
                                {"Fe", 99.64},
                                {"P", 0.02},
                                {"S", 0.05},
                                {"Cr", 0.09},
                                {"C", 0.09},{"SiO2",19.9},{"CaO", 33.0},
                                  {"MgO", 6.8},
                                  {"Al2O3", 7.3},
                                  {"MnO", 5.7},
                                  {"FeO", 20.58},
                                  {"P2O5", 0.0},
                            };
            SetDataView(bindingSource1, Default_Carga);
            SetDataView(tempElementoBindingSource, Default_Metal);
            SetDataView(tempElementoBindingSource1, Default_Escoria);
            //var General = new Dictionary<String, Double>
            //                  {


            //                      {"BaseAcero", 1000.0},   {"AcLiquido", 1000.0}

            //                  };

            //var DefaultGases = new Dictionary<String, Double>()
            //                {
            //                    {"Masa", 187.75},
            //                    {"Peso", 0.0}
            //                };
        }
        private void SetDataView(BindingSource gridView, Dictionary<String, double> value)
        {
            foreach (KeyValuePair<string, double> keyValuePair in value)
            {
                var t = (DSBCE.TempElementoRow)((DataRowView)gridView.AddNew()).Row;
                gridView.MoveLast();
                if (keyValuePair.Key.IndexOf('_') == -1)
                    t.idelemento = ((DSBCE.T_ElementoRow)dSBCE.T_Elemento.Select("codelemento=" + "'" + keyValuePair.Key + "'")[0]).idelemento;
                else
                    t.propiedad = keyValuePair.Key;
                t.valor = keyValuePair.Value;
                t.EndEdit();

            }
        }

        public EventHandler OnCalculated { get; set; }
        private Dictionary<string, double> _t;
        public Dictionary<string, double> lastCalculated { get { return _t; } set { _t = value;
            this.Tag = _t;if (OnCalculated != null)
            OnCalculated(this, null);
        } }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Algorithm s = new Algorithm();

            var Settings = FrmSettings.GetSettingsAll();
            var Carga = GetDictionaryFromGridView(gridView4);
            var Metal = GetDictionaryFromGridView(gridView1);
            var Escoria = GetDictionaryFromGridView(gridView2);
            lastCalculated = s.Carga_Segun_Escoria_Metal(idpatron, Settings["General"], Metal, Escoria, Carga, Settings["Gases"]);
            foreach (KeyValuePair<string, double> keyValuePair in lastCalculated)
            {
                var k = dSBCE.T_Patron_Balance_Desc.NewT_Patron_Balance_DescRow();
                var q = keyValuePair.Key.Split('_');
                k.idpatron = idpatron;
                k.idelemento = ((DSBCE.T_ElementoRow)dSBCE.T_Elemento.Select("codelemento=" + "'" + q[0] + "'")[0]).idelemento;
                k.idpropiedad = ((DSBCE.T_Balance_PropiedadRow)dSBCE.T_Balance_Propiedad.Select("name_Balance_P=" + "'" + q[1] + "'")[0]).idBalance_Propiedad;
                k.valor = keyValuePair.Value;
                dSBCE.T_Patron_Balance_Desc.AddT_Patron_Balance_DescRow(k);

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
                        k = ((DSBCE.T_ElementoRow)dSBCE.T_Elemento.Select("idelemento=" + "'" + q + "'")[0]).codelemento;
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
        private void ucPieFormulario1_Aceptar(object sender)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Desea eliminar los datos de este patrón?", "Eliminar datos", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                t_Patron_Balance_DescTableAdapter.DeleteData(idpatron);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Desea eliminar este patrón?", "Eliminar patrón", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tPatronBalanceBindingSource.RemoveCurrent();
                t_Patron_BalanceTableAdapter.Update(dSBCE.T_Patron_Balance);
                Close();
            }

        }

        private void FrmPatron_FormClosed(object sender, FormClosedEventArgs e)
        {
            lastCalculated = null;
        }
    }
}