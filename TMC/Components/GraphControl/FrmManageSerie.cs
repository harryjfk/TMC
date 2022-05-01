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
    public partial class FrmManageSerie : XtraUserControl
    {
        private Serie _serie;
        private bool _edit;

        public Serie Serie
        {
            get { return _serie; }
            set
            {
                _serie = value;
                _serie.SelectColor = Control.SelectColor;
                LoadSerie();
            }
        }

        private void LoadSerie()
        {
            nameedit.Text = Serie.Name;
            if (!Edit)
            {


                Serie.Color = Control.GetColors();
                colorEdit1.EditValue = Serie.Color;
                colorEdit1.Color = Serie.Color;
                colorEdit1.Refresh();
            }
            else
            colorEdit1.Color = Serie.Color;
            marcaedit.EditValue = (int)Serie.Marca;
            bindingSource1.DataSource = Serie.Points;
        }
    

        public bool Edit
        {
            get { return _edit; }
            set
            {
               
                _edit = value;
                }
        }
        public FrmManageSerie()
        {
            InitializeComponent();

        }
        public UCGraphControl Control { get; set; }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var p = new SeriePoint(Serie.Points);
            p.Selected = true;
            Control.State = GraphState.ManagingSeriePoints;
            FrmEditPoint pointform;
            if(sender is FrmEditPoint)
            {
                pointform = (FrmEditPoint) sender;
                pointform.Clicked = true;
                Serie.Points.TempPoint = new Point();
             //   pointform.Point.Selected = false;
                pointform.Point = p;
                pointform.Edit = false;
            }
            else
            {
                pointform = new FrmEditPoint();
                pointform.Clicked = true;
                pointform.Control = Control;
                pointform.Edit = false;
                pointform.Point = p;
             
                Serie.Points.TempPoint = new Point();
                pointform.OnAceptar += new EventHandler(pointedit_OnAceptar);
                pointform.OnCancelar += new EventHandler(pointedit_OnCancelar);
                pointform.pointEditItem1.OnButtonClick += new EventHandler(pointEditItem1_OnChange);
                pointform.pointEditItem1.OnChange += new EventHandler(pointEditItem1_OnChange);
                pointform.Show(this);    
            }
            
            layoutControl1.Enabled = false;
        }

        void pointEditItem1_OnChange(object sender, EventArgs e)
        {
            var s = (PointEditItem)sender;
            Serie.Points.TempPoint = s.Point;
        }

 

        void pointedit_OnCancelar(object sender, EventArgs e)
        {
            Serie.Points.TempPoint = new Point();
            Control.State = GraphState.Ready;
            layoutControl1.Enabled = true;
        }

        void pointedit_OnAceptar(object sender, EventArgs e)
        {
            //    ((SeriePoint)((FrmEditPoint)sender).Point).Params.Add(4);
            //      ((SeriePoint)((FrmEditPoint)sender).Point).Params.Add(34);
            if (!((FrmEditPoint)sender).Edit)

                Serie.Points.Add((SeriePoint)((FrmEditPoint)sender).Point);
            bindingSource1.ResetBindings(false);
            layoutControl1.Enabled = true;
            Control.Refresh();
            ((ButtonBottomArgs)e).
                Cerrar = Edit;
            if (!Edit)
                //     if (MessageBox.Show("Desea agregar otro punto de la serie?", "Agregar punto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)

                simpleButton1_Click(sender, e);
        }

        private void gridView1_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {

        }

        private void ucPieFormulario1_Aceptar(object sender)
        {
            if (dxValidationProvider1.Validate())
            {
                Serie.Points.ClearSelected();
            
                if (OnAceptar != null)
                    OnAceptar(this, null);
                //Close();
            }
        }

        private void gridView2_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

        }

        private void gridView2_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            e.Value = e.Row;
        }

        private void repositoryItemTextEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        bool w = false;

        private void repositoryItemTextEdit1_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {
            e.Handled = true;
            if (e.Value != null)
            {
                double t = double.Parse(e.Value.ToString());
                // t = double.Parse(((DevExpress.XtraEditors.TextEdit)sender).Text);
                var index = ((GridView)gridControl1.FocusedView).FocusedRowHandle;
                var list = ((List<double>)gridControl1.FocusedView.DataSource);
                if (index < list.Count && index >= 0)
                {
                    list[index] = t;
                    w = false;
                }
                else
                    if (!w)
                    {
                        list.Add(t);
                        gridControl1.FocusedView.RefreshData();
                        w = true;
                    }

            }

            w = false;
        }
        public event EventHandler OnAceptar;
        public event EventHandler OnCancelar;
        private void ucPieFormulario1_Cancelar(object sender, ACINOX.Components.CancelarArgs e)
        {
            FrmManageSerie_FormClosed(sender, null);
            if (OnCancelar != null)
                OnCancelar(this, null);
        }

        internal void SaveToSerie()
        {
            Serie.Name = nameedit.Text;
            Serie.Color = colorEdit1.Color;
            Serie.Marca = (GraphMarc)marcaedit.EditValue;
        }
        private SeriePoint CurrentPoint { get { return (SeriePoint)bindingSource1.Current; } }
  
        private void repositoryItemButtonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {

                var pointform = new FrmEditPoint();
                pointform.Control = Control;
                pointform.Edit = true;
                pointform.Point = CurrentPoint;
                Serie.Points.TempPoint = CurrentPoint.Point;
               
                pointform.OnAceptar += new EventHandler(pointedit_OnAceptar);
                pointform.OnCancelar += new EventHandler(pointedit_OnCancelar);
                pointform.Show();
                layoutControl1.Enabled = false;
            }
            else
                if (XtraMessageBox.Show("Esta seguro que desea eliminar este punto?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                   Serie.Points.Remove(CurrentPoint);
                    bindingSource1.ResetBindings(false);
                }
        }

  

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            SeriePoint prev =null;
            if (e.PrevFocusedRowHandle >= 0 && e.PrevFocusedRowHandle < Serie.Points.Count)
                prev = Serie.Points[e.PrevFocusedRowHandle];
            if (e.FocusedRowHandle >= 0)
            {
                var curren = Serie.Points[e.FocusedRowHandle];
                if (prev != null)
                    prev.Selected = false;
                curren.Selected = true;
                Control.Refresh();
            }
        }

        private void FrmManageSerie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serie.Points.ClearSelected();
            Control.Refresh();
        }
    }
}