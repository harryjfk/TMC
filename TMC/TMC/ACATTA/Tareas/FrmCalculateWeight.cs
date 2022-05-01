using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.ACATTA.Tareas
{
    public partial class FrmCalculateWeight : DevExpress.XtraEditors.XtraForm
    {
        public FrmCalculateWeight()
        {
            InitializeComponent();
        }
        public float Weight { get { return 0; } }
    }
}