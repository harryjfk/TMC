using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.ACATTA.Prediccion
{
    public partial class FrmCurveEdit : DevExpress.XtraEditors.XtraForm
    {
        public FrmCurveEdit()
        {
            InitializeComponent();
        }

        private byte[] _data;
        public byte[] data
        {
            get { return _data; }
            set { _data = value;
                if(_data==null)
                    return;
                var mem = new MemoryStream(_data);
                ucGraphDesigner1.LoadFromStream(mem);
            }
        }
        private void ucPieFormulario1_Aceptar(object sender)
        {
            if(IsValid())
            {
               
                var Mem = new MemoryStream();
                ucGraphDesigner1.SaveToStream(Mem);
                _data = Mem.ToArray();
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("aaa");
            }
        }

        private bool IsValid()
        {

            return true;
        }
    }
}