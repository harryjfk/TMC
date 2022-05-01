using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace TMC.Components.GraphControl
{
    public partial class FrmPointFromAxis : DevExpress.XtraEditors.XtraForm
    {
        public FrmPointFromAxis()
        {
            InitializeComponent();
        }

        private Point _inicial;
        private Point _final;
        private AxisList _list;
        private Axis _Axis;
        public Axis Axis
        {
            get { return _Axis; }
            set
            {
                _Axis = value;
                _inicial = value.RealPointInitial;
                _final = value.RealPointFinal;
            }
        }
        private void FillCombo(ImageComboBoxEdit combo)
        {
            foreach (Axis axis in _list)
                if(Axis!=axis)
            {
                var item = new ImageComboBoxItem();
                item.Description = axis.Name + " - Inicial";
                item.Value = axis.RealPointInitial;
                combo.Properties.Items.Add(item);
                item = new ImageComboBoxItem();
                item.Description = axis.Name + " - Final";
                item.Value = axis.RealPointFinal;
                combo.Properties.Items.Add(item);
            }
        }

        public UCGraphControl Control { get; set; }
        public AxisList List
        {
            get { return _list; }
            set
            {
                _list = value;
                FillCombo(imageComboBoxEdit1);
                FillCombo(imageComboBoxEdit2);
            }
        }

        private void imageComboBoxEdit1_Properties_EditValueChanged(object sender, EventArgs e)
        {
            if (sender == imageComboBoxEdit1)
                Axis.RealPointInitial = (Point)((ImageComboBoxEdit) sender).EditValue;
            else
                
                    Axis.RealPointFinal = (Point)((ImageComboBoxEdit)sender).EditValue;
            Axis.CheckRects( Control.UseOrtogonal);
            Control.Refresh();
        }

        private void ucPieFormulario1_Cancelar(object sender, ACINOX.Components.CancelarArgs e)
        {
            Axis.RealPointFinal = _final;
            Axis.RealPointInitial = _inicial;
            Control.Refresh();
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (IsValid())
            {
             Close();    
            }
        }

        private bool IsValid()
        {
            return (Axis.RealPointFinal != Axis.RealPointInitial) &&
                   (Axis.RealPointFinal.X != Axis.RealPointInitial.Y && Axis.RealPointFinal.Y != Axis.RealPointInitial.X);
        }
    }
}