using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TMC.Components.TemperatureControl;

namespace TMC.RD.Tareas
{
    public partial class FrmTempInicial : DevExpress.XtraEditors.XtraForm
    {
        private SIARAlgorithm _algorithm;
        public SIARAlgorithm Algorithm { get { return _algorithm; } set { _algorithm = value;
            textEdit1.EditValue = Algorithm.Project.tempdise;

        } }
        public double Temperatura{get
        {
            if (checkEdit1.Checked)
                return Algorithm.Project.tempamb;
            return (double) textEdit1.EditValue;
        }}
        public FrmTempInicial()
        {
            InitializeComponent();
        }
    }
}