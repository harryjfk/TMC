using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace TMC.BCE.Codificadores
{
    public partial class FrmSettings : DevExpress.XtraEditors.XtraForm
    {
        public FrmSettings()
        {
            InitializeComponent();
        }
        private void SetTrace()
        {
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.DataSets.Add(dSBCE);
            ((TMC.FrmMain)Application.OpenForms[MasterForm.Index]).traceComponent1.LoadList();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSBCE.T_Elemento' Puede moverla o quitarla según sea necesario.
            this.t_ElementoTableAdapter.Fill(this.dSBCE.T_Elemento);
            // TODO: esta línea de código carga datos en la tabla 'dSBCE.T_Balance_Propiedad' Puede moverla o quitarla según sea necesario.
            this.t_Balance_PropiedadTableAdapter.Fill(this.dSBCE.T_Balance_Propiedad);
            // TODO: esta línea de código carga datos en la tabla 'dSBCE.T_Balance_CompDefaultAll' Puede moverla o quitarla según sea necesario.
             this.t_Balance_CompDefaultTableAdapter.Fill(this.dSBCE.T_Balance_CompDefault);
            SetTrace();
            if(System.IO.File.Exists(_filename))
            {
                var binary = new BinaryFormatter();
                var file = new FileStream(_filename, FileMode.Open);
                Settings = (PatronSettings) binary.Deserialize(file);
                file.Close();
            }
        }
        public PatronSettings Settings
        {
            get { return _settings; }
            set
            {
                _settings = value;
                textEdit1.EditValue = _settings.BaseAcero;
                textEdit2.EditValue = _settings.BaseEscoria;
                textEdit6.EditValue = _settings.AcLiquido;
                textEdit3.EditValue = _settings.DensidadAire;
                textEdit4.EditValue = _settings.VolumenAire;
                textEdit5.EditValue = _settings.ComposicionAire;
                textEdit7.EditValue = _settings.Masa;
            }
        }

        private String _filename = Application.StartupPath + @"\psettings.dat";
 
        public Dictionary<String, Dictionary<String, double>> GetSettings()
        {
            var res = _settings.AsDictionary();
        
            foreach (var value in dSBCE.T_Balance_CompDefault)
                res["Gases"].Add(value.T_Balance_PropiedadRow.name_Balance_P+value.T_ElementoRow.nameelemento, value.valor);
            return res;
        }
        public static Dictionary<String, Dictionary<String, double>> GetSettingsAll()
        {
            var s = new FrmSettings();
            s.FrmSettings_Load(s,null);
            return s.GetSettings();
        }
        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {

                _settings.BaseAcero = float.Parse(textEdit1.EditValue.ToString());
                _settings.BaseEscoria = float.Parse(textEdit2.EditValue.ToString());
                _settings.AcLiquido = float.Parse(textEdit6.EditValue.ToString());
                _settings.DensidadAire = float.Parse(textEdit3.EditValue.ToString());
                _settings.VolumenAire = float.Parse(textEdit4.EditValue.ToString());
                _settings.ComposicionAire = float.Parse(textEdit5.EditValue.ToString());
                _settings.Masa = float.Parse(textEdit7.EditValue.ToString());
                var f = new FileStream(_filename
                                       , FileMode.Create);
                _settings.Save(f);
                f.Close();
                t_Balance_CompDefaultTableAdapter.Update(dSBCE.T_Balance_CompDefault);

                DialogResult = DialogResult.OK;
                Close();

            }
        }

        private PatronSettings _settings =new PatronSettings() ;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            GetSettings();
        }
        //private void Load()
        //{
            
        //}
    }
    [Serializable]
     public class PatronSettings
    {
        public void Save(Stream f)
        {
            var Binary = new BinaryFormatter();
            Binary.Serialize(f,this);
        }

        public float BaseAcero { get; set; }
        public float BaseEscoria { get; set; }
        public float DensidadAire { get; set; }
        public float VolumenAire { get; set; }
        public float ComposicionAire { get; set; }
        public float AcLiquido { get; set; }
        public float Masa { get; set; }
        public Dictionary<string, Dictionary<string, double>> AsDictionary()
        {
            var r = new Dictionary<String, Dictionary<String, double>>();
            r.Add("General",new Dictionary<string, double>());
            r["General"].Add("BaseAcero", BaseAcero);
            r["General"].Add("BaseEscoria",BaseEscoria);
            r["General"].Add("AcLiquido", AcLiquido);
            r.Add("Gases",new Dictionary<string, double>());
            r["Gases"].Add("DensidadAire", DensidadAire);
            r["Gases"].Add("ComposicionAire", ComposicionAire);
            r["Gases"].Add("VolumenAire", VolumenAire);
            r["Gases"].Add("Masa",Masa);
            return r;
        }
    }
}