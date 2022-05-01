using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace TMC.Components.GraphControl
{
    public partial class UCGraphDesigner : DevExpress.XtraEditors.XtraUserControl
    {
        public UCGraphDesigner()
        {
            InitializeComponent();
            SetEnabled(true,false);
            SetEnabled(false,false);
            //  UpdateEdit(ucGraphControl1.BitmapRectangle);
            ucGraphControl1.SelectColor = Color.Black;
            ucGraphControl1.OnClicked += OnClicked;
            ucGraphControl1.OnStateChange += OnChange;
            barEditItem1.EditValue = true;
            pointEditItem1.OnButtonClick += OnModifiyCoordClick;
            pointEditItem1.OnChange += OnChangePoint;
            pointEditItem1.Data = ucGraphControl1;
            ucGraphControl1.OnPointButtonClick += OnModifiyCoordClick;
            ucGraphControl1.OnPointChange += OnChangePoint;
         //   ucGraphControl1.GraphObject.ImageController = ucImageController1.Controller;
        }
        public void SaveToFile(String FileName )
        {
            ucGraphControl1.SaveToFile(FileName);
        }
        public void SaveToStream(Stream stream)
        {
            ucGraphControl1.SaveToStream(stream);
        }
        public void LoadFromFile(String FileName)
        {
            ucGraphControl1.LoadFromFile(FileName); ExecuteLoad();
        }
        public void LoadFromStream(Stream stream)
        { ucGraphControl1.LoadFromStream(stream); ExecuteLoad(); }

        public GraphicObject GraphObject { get { return ucGraphControl1.GraphObject; } }
        private GraphState _bef = GraphState.Ready;
        private PointEditItem _edititem = null;
        public void OnModifiyCoordClick(object sender, EventArgs e)
        {
            if (ucGraphControl1.State == GraphState.WaitingForClick)
                return;
            
           if(sender == pointEditItem1 )
            ucGraphControl1.State = GraphState.ManagingStartPoint;
            _bef = ucGraphControl1.State;
            _edititem = (PointEditItem) sender;
            //if(     ucGraphControl1.State!= GraphState.ManagingStartPoint)
            ucGraphControl1.State = GraphState.WaitingForClick;
        }
        public void OnChangePoint(object sender, EventArgs e)
        {
            var edit = _edititem ?? (PointEditItem) sender;
            if (edit.Data is UCGraphControl)
            {
                ucGraphControl1.GraphObject.Point = edit.Point;
                SetEnabled(true,true);
            }
            else
                if (edit.Data is Axis)
                {
                    if (edit.Tag.ToString() == "I")
                        ((Axis)edit.Data).RealPointInitial = edit.Point;
                    else
                        ((Axis)edit.Data).RealPointFinal = edit.Point;
                }
                else
                    if (edit.Data is AxisPoint)
                        ((AxisPoint) edit.Data).Point = edit.Point;
                    else
                        if(edit.Data is SeriePoint)
                            ((SeriePoint)edit.Data).Point = edit.Point;
         //   else
           // if(edit.Data is )
         //   ucGraphControl1.ChangeState(_bef);
            ucGraphControl1.ReturnPoint = new Point();
            ucGraphControl1.Refresh();
        }

        private AxisList GetAxisVerified() {
            return ucGraphControl1.GraphObject.Axiss;
        }
        private void CreateData()
        {
            var data = ucGraphControl1.GraphObject.CreateData();
            var v = ((GridView) gridControl3.FocusedView);
            v.Columns.Clear();
            foreach (DataColumn dataColumn in data.Columns)
            {
                var column = new GridColumn();
                column.Caption = dataColumn.ColumnName;
                column.FieldName = dataColumn.ColumnName;
                column.Visible = true;
               v.Columns.Add(column);
            }
            bindingSource3.DataSource = data;
            bindingSource3.ResetBindings(true);
            

        }

        private void UpdateAxiss()
        {
            if (bindingSource1.DataSource == null)
                bindingSource1.DataSource = ucGraphControl1.GraphObject.Axiss;
            else

                bindingSource1.ResetBindings(false);
            SetEnabled(true,ucGraphControl1.GraphObject.Axiss.Count>0 && !ucGraphControl1.GraphObject.Point.IsEmpty);
            SetEnabled(false, ucGraphControl1.GraphObject.Axiss.Count > 0);
            var dr = ((DevExpress.XtraCharts.XYDiagram)chartControl1.Diagram);
            if(dr!=null)
            {
            dr.AxisX.Title.Text = "Eje de argumentos";
            dr.AxisY.Title.Text = "Eje de valores";
            dr.SecondaryAxesX.Clear();
            dr.SecondaryAxesY.Clear();
            foreach (Axis item in GetAxisVerified())
            {
                switch (item.Orientation)
                {
                    case AxisOrientation.Unknown:
                        break;
                    case AxisOrientation.Horizontal:
                        {
                            DevExpress.XtraCharts.AxisXBase r = null;

                            if (dr.AxisX.Title.Text == "Eje de argumentos")
                                r = dr.AxisX;
                            else
                            {
                                r = new DevExpress.XtraCharts.SecondaryAxisX();
                                dr.SecondaryAxesX.Add((DevExpress.XtraCharts.SecondaryAxisX)r);

                            }
                            r.Title.Text = item.Name;
                            r.Color = item.Color;
                            r.Range.Auto = false;
                            if (item.Scale == AxisScale.Logaritmic)
                            {
                                r.Logarithmic = true;
                                r.LogarithmicBase = 10;
                            }
                            r.Range.MaxValue = item.ValueMax;
                            r.Range.MinValue = item.ValueMin;

                            break;

                        }
                    case AxisOrientation.Vertical:
                        {
                            DevExpress.XtraCharts.AxisYBase r = null;
                            if (dr.AxisY.Title.Text == "Eje de valores")
                                r = dr.AxisY;
                            else
                            {
                                r = new DevExpress.XtraCharts.SecondaryAxisY();
                                dr.SecondaryAxesY.Add((DevExpress.XtraCharts.SecondaryAxisY)r);

                            }
                            r.Title.Text = item.Name;
                            r.Color = item.Color;
                            r.Range.Auto = false;
                            r.Range.MaxValue = item.ValueMax;
                            r.Range.MinValue = item.ValueMin;
                            break;

                        }
                    default:
                        break;
                }
            }
            }
         CreateData();
        }
        private void SetEnabled(bool Axs, bool value)
        {
            if(Axs)
            {
                gridControl1.Enabled = value;
                simpleButton4.Enabled = gridControl1.Enabled;
            }
            else
            {
                gridControl2.Enabled = value;
                simpleButton1.Enabled = gridControl2.Enabled;
            }
        }

        private void OnAceptar(object sender, EventArgs e)
        {
            if (sender is FrmAxisManager)
            {
                ((FrmAxisManager)sender).SaveToAxis();

                ucGraphControl1.State = GraphState.Ready;
                UpdateAxiss();
            }
            else
                if (sender is FrmManageSerie)
                {
                    ((FrmManageSerie)sender).SaveToSerie();
                    ucImageController1.Enabled = false;
                    if (!((FrmManageSerie)sender).Edit)
                        ucGraphControl1.GraphObject.Series.Add(((FrmManageSerie)sender).Serie);
                    UpdateSerie();
                    ucGraphControl1.ManagingSerie = null;
                }
            ManageForm((XtraUserControl) sender, "Configurar", false);
            ucGraphControl1.Refresh();
          }

        private void UpdateSerie()
        {
            if (bindingSource2.DataSource == null)
                bindingSource2.DataSource = ucGraphControl1.GraphObject.Series;
            else

                bindingSource2.ResetBindings(false);
            SetEnabled(false, ucGraphControl1.GraphObject.Axiss.Count > 0);
            ucImageController1.Enabled = ucGraphControl1.GraphObject.Series.Count==0;
            var ps = ucGraphControl1.GraphObject.Axiss.GetPrincipals();
            if (ps.Count > 0)
            {
                chartControl1.Series.Clear();
                foreach (Serie item in ucGraphControl1.GraphObject.Series)
                {var s = new DevExpress.XtraCharts.Series(item.Name, DevExpress.XtraCharts.ViewType.ScatterLine);
                    chartControl1
                        .Series.Add(s);
                    s.View.Color = item.Color;
                    foreach (SeriePoint pt in item.Points)
                    {

                        var px = ps[0].ValueFromPoint(pt.Point);
                        var py = ps[1].ValueFromPoint(pt.Point);
                        if (px != null && py != null)
                            s.Points.Add(new DevExpress.XtraCharts.SeriesPoint(px, py));
                    }
                }
            }
            CreateData();
        }
        private void OnCancelar(object sender, EventArgs e)
        {
            if (sender is FrmAxisManager)
            {
                if (!((FrmAxisManager)sender).Edit)
                    ucGraphControl1.GraphObject.Axiss.Remove(((FrmAxisManager)sender).Axis);
            
            }
            else
                if (sender is FrmManageSerie)
                    ucGraphControl1.ManagingSerie = null;
            ucGraphControl1.State = GraphState.Ready;
            ManageForm((XtraUserControl)sender, "Configurar", false);
            ucGraphControl1.Refresh();      
        }

        public void OnChange(UCGraphControl sender, GraphState state)
        {
            if (sender.State == GraphState.Ready)
            {
                if (state == GraphState.WaitingForClick
                    /*&& _edititem != null*/)
                {
                    _edititem.Point = ucGraphControl1.ReturnPoint;
                    if ((/*_bef == GraphState.ManagingStartPoint || */_bef == GraphState.EndManagingAxis))
                        ucGraphControl1.ChangeState(_bef);
                }


            }
            else if (sender.State == GraphState.EndManagingAxis)
            {
                var Axisman = (FrmAxisManager) ManageForm(new FrmAxisManager(), "Editar Eje");

                Axisman.Control = ucGraphControl1;
                Axisman.Edit = state == GraphState.Ready;
                Axisman.Axis = ucGraphControl1.ManagingAxis;
           
            
                Axisman.OnAceptar += OnAceptar;
                Axisman.OnCancelar += OnCancelar;
            }

            ucGraphControl1.Refresh();

        }

        public bool OnClicked(UCGraphControl sender)
        {
            return false;
        }
        private void ucGraphControl1_Resize(object sender, EventArgs e)
        {
            //UpdateEdit(ucGraphControl1.BitmapRectangle);
        }



        private void simpleButton4_Click(object sender, EventArgs e)
        {
            ucGraphControl1.ManagingAxis = null;
            ucGraphControl1.State = GraphState.ManagingAxis;


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(openFileDialog1.ShowDialog(this)==DialogResult.OK)
            {
            bindingSource1.Clear();
            bindingSource2.Clear();
            bindingSource1.DataSource = null;
            bindingSource2.DataSource = null;
              
                //ucImageController1.OnChangeImage -= ucImageController1_OnChangeBitmap;
            ManageForm(null, "Configurar", false);
            ucGraphControl1.LoadFromFile(openFileDialog1.FileName);
                ucImageController1.UpdateEdit();
            //    ucImageController1.Controller = ucGraphControl1.GraphObject.ImageController;
           ExecuteLoad();
            //ucImageController1.OnChangeImage += ucImageController1_OnChangeBitmap;
            }
        }
        private void ExecuteLoad()
        {
             UpdateAxiss();
            UpdateSerie();
            pointEditItem1.Point = ucGraphControl1.GraphObject.Point;
            foreach (Serie item in ucGraphControl1.GraphObject.Series)
            
                item.SelectColor = ucGraphControl1.SelectColor;
        }
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = @"Archivo de gráfico|*.grph";
            if(saveFileDialog1.ShowDialog(this)==DialogResult.OK)
            {
               // ucImageController1.SetMethod(false);
                ucGraphControl1.SaveToFile(saveFileDialog1.FileName);
                UpdateAxiss();
                UpdateSerie();    
            }
            
        }
        private Axis CurrentAxis { get { return ((Axis)bindingSource1.Current); } }
        private Serie CurrentSerie { get { return ((Serie)bindingSource2.Current); } }
        private void repositoryItemButtonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                ucGraphControl1.ManagingAxis = CurrentAxis;
                ucGraphControl1.State = GraphState.EndManagingAxis;

            }
            else
                if (XtraMessageBox.Show("Esta seguro que desea eliminar este eje?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(ucGraphControl1.GraphObject.Axiss.Count==1)
                    {
                        if (
                            XtraMessageBox.Show(
                                @"Si elimina este eje se eliminaran todas las series creadas \n Desea continuar?",
                                "Eliminar series", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
                            ucGraphControl1.GraphObject.Series.Clear();
                        else
                            return;
                    }  
                    ucGraphControl1.GraphObject.Axiss.Remove(CurrentAxis);}
                    UpdateAxiss();
                    ucGraphControl1.Refresh();
               
        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ucImageController1_OnChangeBitmap(object sender, EventArgs e)
        {
        //    ucGraphControl1.GraphObject.ImageController = ucImageController1.Controller;
            ucGraphControl1.Refresh();
        }
  
        private XtraUserControl ManageForm(XtraUserControl f, String c,bool show=true)
        {
            if (dockPanel2.Controls[0].Controls.Count > 2)
                f = (XtraUserControl) dockPanel2.Controls[0].Controls[1];
            if(show)
            {
            f.Parent = dockPanel2;
            f.Dock = DockStyle.Fill;
            }
            else
                if(f!=null)
                
                dockPanel2.Controls[0].Controls.Remove(f);

            dockPanel2.Text = c;
            layoutControl1.Visible = !show;
            return f;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ucGraphControl1.GraphObject.Series.ClearSelected();
           var seriemman =  (FrmManageSerie)ManageForm(new FrmManageSerie(),"Editar Serie");
            
            seriemman.Control = ucGraphControl1;
            seriemman.Edit = false;
            seriemman.Serie= new Serie();
            ucGraphControl1.ManagingSerie = seriemman.Serie;
            
          
         //   seriemman.Axis = ucGraphControl1.ManagingAxis;
            seriemman.OnAceptar += OnAceptar;
            seriemman.OnCancelar += OnCancelar;
           // seriemman.Show(this);
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit2_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                ucGraphControl1.GraphObject.Series.ClearSelected();
                var seriemman = (FrmManageSerie)ManageForm(new FrmManageSerie(), "Editar Serie");

                seriemman.Edit = true;
                seriemman.Control = ucGraphControl1;
                seriemman.Serie = CurrentSerie;
           

                //   seriemman.Axis = ucGraphControl1.ManagingAxis;
                seriemman.OnAceptar += OnAceptar;
                seriemman.OnCancelar += OnCancelar;
                //seriemman.Show(this);

            }
            else
                if (XtraMessageBox.Show("Esta seguro que desea eliminar esta serie?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ucGraphControl1.GraphObject.Series.Remove(CurrentSerie);
                    UpdateSerie();
                    ucGraphControl1.Refresh();
                }
        }

        private void ucImageController1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void repositoryItemColorEdit1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            e.DisplayText = "";
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridControl3.ShowPrintPreview();
          
         
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = @"Archivo CSV|*.csv";
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                var f = saveFileDialog1.FileName;
                gridControl3.ExportToCsv(f);
                var fileContents = System.IO.File.ReadAllText(f);

                fileContents = fileContents.Replace(",", ";");

                fileContents = fileContents.Replace(".", ",");
                System.IO.File.WriteAllText(f, fileContents);
            }
        }

    

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            ucGraphControl1.GraphObject.ExportToDB();
        }
    }
}
