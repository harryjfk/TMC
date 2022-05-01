using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC
{
    public partial class FrmAbout : DevExpress.XtraEditors.XtraForm
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void ucPieFormulario1_Cancelar(object sender, ACINOX.Components.CancelarArgs e)
        {
            Close();
        }

        
    }
}