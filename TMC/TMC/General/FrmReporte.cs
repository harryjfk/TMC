using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Parameters;

namespace TMC.General.Reportes
{
    public partial class FrmReporte : DevExpress.XtraEditors.XtraForm
    {
        public FrmReporte()
        {
            InitializeComponent();
        }

        public void LoadFromDictionary(String filename,Dictionary<string, object > res,DataTable dt =null)
        {
            var param = GetParams(res);
           ucReport1.LoadFromFile(filename,dt,param);
        }

        private Parameter[] GetParams(Dictionary<string, object > src)
        {
            var res = new Parameter[src.Count];
            int i = 0;
            foreach (String keyValuePair in src.Keys)
            {
                res[i] =new Parameter();
                res[i].Name = keyValuePair;
                res[i].Value = src[keyValuePair];
                i++;
            }

            return res;
        }
    }
}