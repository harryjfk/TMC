using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using TMC;

namespace TMC.General
{
    public partial class FrmTrazas : XtraForm
    {
        public FrmTrazas()
            
        {
            InitializeComponent();
            ucTraceControl1.ConnectionString = Properties.Settings
                .Default.TMCConnectionString;
        }
        
    }
}