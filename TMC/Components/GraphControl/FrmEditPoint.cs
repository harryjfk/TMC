using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace TMC.Components.GraphControl
{
  
    public partial class FrmEditPoint : DevExpress.XtraEditors.XtraForm
    {
        private GraphPoint _point;
        public bool Clicked { get; set; }
        public GraphPoint Point
        {
            get { return _point; }
            set
            {
                pointEditItem1.OnButtonClick -= Control.InvokeOnPointButtonClick;
                pointEditItem1.OnChange -= Control.InvokeOnPointChange;
                pointEditItem1.OnChange -= new EventHandler(pointEditItem1_OnChange);
                _point = value;
                pointEditItem1.Point = value.Point;
             
                if (value is AxisPoint)
                {
                    textEdit1.EditValue = ((AxisPoint)value).Value;
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    Height = 134;
                }
                else if (value is SeriePoint)
                {
                    layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem3.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItem4.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    var temp = new ParameterList();
                    if (!Edit)
                    {
                        if (((SeriePoint) value).PointList.Count > 0)
                            temp = ((SeriePoint) value).PointList[((SeriePoint) value).PointList.Count - 1].Params;
                    }
                    else
                        temp = ((SeriePoint) value).Params;
                    temp.CopyTo(Parameters);
                   
                    bindingSource1.DataSource = temp.AsDataTable();
                    RefreshValues();
                    Height = 236;

                }
                pointEditItem1.Data = value;
                pointEditItem1.OnButtonClick += Control.InvokeOnPointButtonClick;
                pointEditItem1.OnChange += Control.InvokeOnPointChange;
                pointEditItem1.OnChange += new EventHandler(pointEditItem1_OnChange);
                if (Clicked)
                    Control.InvokeOnPointButtonClick(pointEditItem1, null);
            }
        }
        private void RefreshValues()
        {
            if (Point is SeriePoint)
            {
                var values = Control.GraphObject.Axiss.GetValueFromPointTable(pointEditItem1.Point);
                bindingSource2.DataSource = values;
                bindingSource2.ResetBindings(true);

            }
        }
        void pointEditItem1_OnChange(object sender, EventArgs e)
        {
          RefreshValues();
        }
        public UCGraphControl Control { get; set; }
        
        public event EventHandler OnAceptar;
        public event EventHandler OnCancelar;
        public FrmEditPoint()
        {
            InitializeComponent();
            dxValidationProvider1.ValidateHiddenControls = false;
        }

        public bool IsValid()
        { 
            if(textEdit1.Visible)
            {   
                 double d = 0;
                 return dxValidationProvider1.Validate() && double.TryParse(textEdit1.EditValue.ToString(), out d) ;
            }
            return !pointEditItem1.Point.IsEmpty;
     
        }
        public ParameterList Parameters = new ParameterList();
        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (IsValid())
            {
                if (Control.State == GraphState.WaitingForClick)
                    Control.State = GraphState.Ready;
                _point.Point = pointEditItem1.Point;
                if (_point is AxisPoint)
                    ((AxisPoint) _point).Value = double.Parse(textEdit1.EditValue.ToString());
                else if (_point is SeriePoint)
                {
                    //   ((SeriePoint)_point).Point = double.Parse(textEdit1.EditValue.ToString());
                   // ((SeriePoint) _point).Params.Clear();
                    ((SeriePoint)_point).Params.CopyFromDataTable((DataTable)bindingSource1.DataSource);
                  
                }
                var s = new ButtonBottomArgs();

                if (OnAceptar != null)
                    OnAceptar(this, s);
                if (s.Cerrar)
                    Close();
            }
            else
                XtraMessageBox.Show(
                    "Por favor revise la localización del punto y que no los datos hayan sido entrados de manera correcta",
                    "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ucPieFormulario1_Cancelar(object sender, ACINOX.Components.CancelarArgs e)
        {
            if (Control.State == GraphState.WaitingForClick)
                Control.State = GraphState.Ready;
            
            if (OnCancelar != null)
                OnCancelar(this, null);
        }

        public bool Edit { get; set; }

        private void FrmEditPoint_FormClosed(object sender, FormClosedEventArgs e)
        {
            ucPieFormulario1_Cancelar(sender, null);
        }
        //bool w = false;
        private void repositoryItemTextEdit1_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            // e.Handled = true;
            //if (e.Value != null)
            //{
            //    double t = double.Parse(e.Value.ToString());
            //    // t = double.Parse(((DevExpress.XtraEditors.TextEdit)sender).Text);
            //    var index = ((GridView)gridControl1.FocusedView).FocusedRowHandle;
            //    var list = Parameters;
            //    if (index < list.Count && index >= 0)
            //    {
            //        list[index] = t;
            //        w = false;
            //    }
            //    else
            //        if (!w)
            //        {
            //            list.Add(t);
            //            bindingSource1.ResetBindings(false);
            //            w = true;
            //        }

            //}
            //w = false;
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
           // if (e.RowHandle >= 0)
           // {
           //     var table = (DataTable) bindingSource1.DataSource;
           //e.DisplayText = table.Rows[e.RowHandle].ItemArray[e.Column.AbsoluteIndex].ToString();
           // //    e.CellValue = Parameters[e.RowHandle].Name;
           // }
        }
    }
    public class ButtonBottomArgs : EventArgs
    {

        public bool Cerrar;
    }
}