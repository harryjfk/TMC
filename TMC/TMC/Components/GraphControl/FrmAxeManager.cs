using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TMC.Components.GraphControl
{
    public partial class FrmAxisManager : XtraUserControl
    {
        public FrmAxisManager()
        {
            InitializeComponent();
        
        }

        private Axis _Axis;
        public event EventHandler OnAceptar;
        public event EventHandler OnCancelar;
        public Axis Axis { get { return _Axis; } set { _Axis = value; LoadAxis(); } }
        public UCGraphControl Control { get; set; }
        private void LoadAxis()
        {
            if (!Edit) Axis.Color = Control.GetColors();
            colorEdit1.EditValue = Axis.Color;
            namedit.EditValue = Axis.Name;
            umedit.EditValue = Axis.UM;
            valormAxisdit.EditValue = Axis.ValueMax;
            valorminedit.EditValue = Axis.ValueMin;
            escalaedit.EditValue = (int)Axis.Scale;
            pointEditItem1.Point = Axis.RealPointInitial;
            pointEditItem1.Data = Axis;
            pointEditItem1.Tag = "I";
            pointEditItem2.Point = Axis.RealPointFinal;
            pointEditItem2.Data = Axis;
            pointEditItem2.Tag = "F";
            pointEditItem1.OnButtonClick += Control.InvokeOnPointButtonClick;
            pointEditItem2.OnButtonClick += Control.InvokeOnPointButtonClick;
            pointEditItem2.OnChange += Control.InvokeOnPointChange;
            pointEditItem1.OnChange +=Control.InvokeOnPointChange;
            Control.ChangeState(GraphState.EndManagingAxis);
            bindingSource1.DataSource = Axis.Points;
        }

        public void SaveToAxis()
        {
            Axis.Name = namedit.EditValue.ToString();
            Axis.UM = umedit.Text;
            Axis.Scale = (AxisScale)escalaedit.EditValue;
            Axis.ValueMax = double.Parse(valormAxisdit.EditValue.ToString());
            Axis.ValueMin = double.Parse(valorminedit.EditValue.ToString());
            Axis.Color = (Color) colorEdit1.EditValue;
        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if(dxValidationProvider1.Validate())
            {
                if (OnAceptar != null)
                    OnAceptar(this, null);
            
            }
        }

        private void ucPieFormulario1_Cancelar(object sender, ACINOX.Components.CancelarArgs e)
        {
            if (OnCancelar != null)
                OnCancelar(this, null);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Axis.Points.Generate(int.Parse(textEdit2.EditValue.ToString()), double.Parse(valormAxisdit.EditValue.ToString()), double.Parse(valorminedit.EditValue.ToString()));
            bindingSource1.ResetBindings(false);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            var p = new AxisPoint(Axis.Points);
            var pointform = new FrmEditPoint();
            pointform.Control = Control;
            pointform.Point = p;
            pointform.Edit = false;
            pointform.OnAceptar += new EventHandler(pointform_OnAceptar);
            pointform.OnCancelar += new EventHandler(pointform_OnCancelar);
            pointform.Show();
            layoutControl1.Enabled = false;
        }

        void pointform_OnCancelar(object sender, EventArgs e)
        {
            layoutControl1.Enabled = true;
        }

        void pointform_OnAceptar(object sender, EventArgs e)
        {
            if(!((FrmEditPoint) sender).Edit)
            Axis.Points.Add((AxisPoint)((FrmEditPoint) sender).Point);
            bindingSource1.ResetBindings(false);
            layoutControl1.Enabled = true;
            ((ButtonBottomArgs) e).
                Cerrar = true;
        }

        private bool _edit;
        public bool Edit { get { return _edit; } set { _edit = value;  } }
        private AxisPoint CurrentPoint { get { return (AxisPoint)bindingSource1.Current; } }
        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
            
                var pointform = new FrmEditPoint();
                pointform.Control = Control;
                pointform.Point = CurrentPoint;
                pointform.Edit = true;
                pointform.OnAceptar += new EventHandler(pointform_OnAceptar);
                pointform.OnCancelar += new EventHandler(pointform_OnCancelar);
                pointform.Show();
                layoutControl1.Enabled = false;
            }
            else
                if(XtraMessageBox.Show("Esta seguro que desea eliminar este punto?","Eliminar",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
            {
                Axis.Points.Remove(CurrentPoint);
                bindingSource1.ResetBindings(false);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            var coor = new FrmPointFromAxis();
            coor.Axis = Axis;
            coor.Control = Control;
            coor.List = Control.GraphObject.Axiss;
            if(coor.ShowDialog(this)==DialogResult.OK)
            {

            }
        }
    }
}