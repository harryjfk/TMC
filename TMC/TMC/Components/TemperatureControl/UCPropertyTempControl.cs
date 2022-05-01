using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Linq;
using DevExpress.XtraTreeList.Nodes;
using MCC;
using TMC.RD;

namespace TMC.Components.TemperatureControl
{

    public partial class UCPropertyTempControl : UCTemperatureControl
    {
      //  UCPropertyTempControl ControlTemp = new UCPropertyTempControl();
        public UCPropertyTempControl()
        {
            InitializeComponent();
            _templist = new PropertyItemList(this);
        }
        
        private void AddMaterial(DSRD.T_MaterialRow materialRow, Point pos)
        {
            
        }
        internal SIARAlgorithm Algorithm = new SIARAlgorithm();
   
      protected override void HandleMover(MouseEventArgs e)
        {
          
            var t = TempList.Selected;
            if (t != null)
                if (t.MoverRectangle.Contains(e.Location) || Moving)
                {
                    Cursor.Current = Cursors.VSplit;
                    if (e.Button == MouseButtons.Left)
                    {
                        int k;
                        int p;
                        if (TempList.IndexOf(t) != TempList.Count - 1)
                        {
                            p = t.WidthPixels();
                            k = -(p - 5 - e.Location.X);

                            Moving = true;

                        }
                        else
                        {
                            p = Width;
                            k = -(p - 4 - e.Location.X);

                        }


                        
                        var w = ACINOX.Functions.Math.Percent.Percen(Width, p + k);
                       if(w<=100)
                        //w = 102
                        //if (w < 0)
                        //    MessageBox.Show("a");
                        
                        //    MessageBox.Show("aa");)
                        if (TempList.IndexOf(t) == TempList.Count - 1)
                            t.EndValue = (int) Math.Round(ACINOX.Functions.Math.Percent.Part(t.EndValue, w));
                        else
                            t.EndValue = (int) Math.Round(ACINOX.Functions.Math.Percent.Part(TempList.EndValue, w))-t.PrevEndValue;
                  
                     
                    }
                }
                else
                    Cursor.Current = Cursors.Default;
            else
            {
                if (e.Button != MouseButtons.Left)
                    Moving = false;
            }
            //if(t!=null)
            
            
        }

        public void SaveToStream(Stream stream)
        {
            var s = Project.ConvertFromDataSet(this);
            s.AsStream(stream);
        }

        public void SaveToFile(String filename)
        {
            var s = new FileStream(filename, FileMode.Create);
            SaveToStream(s);
        }
        private void UCPropertyTempControl_Paint(object sender, PaintEventArgs e)
        {

           

           
        }
        
        internal void CalculateInvalidate(int pos)
        {
            if (pos < 0 || TempList.Count<=pos)
                return;

            var temp = ((PropertyTempItem)TempList[pos]).PrevEndTempValue;
            var t = Algorithm.SiSParcial(temp, ((PropertyItemList)TempList).TemperaturaAmbiente);
            for (int i = 1; i <= Algorithm.Materiales.Count; i++)
            {
                var material = Algorithm.Materiales[i - 1];
                Color c = (i == 1) ? ((DSRD)material.Table.DataSet).T_Degradee.GetColor(((PropertyItemList)TempList).TemperaturaInterna) : TempList[i - 2].EndColor;
                var d = ((DSRD)material.Table.DataSet).T_Degradee.GetColor((int)((List<double>)t["TMTP"])[i]);
                var w = ((DSRD)material.Table.DataSet).T_Degradee.GetColor((int)((List<double>)t["TEXP"])[i]);
                TempList[i - 1].BeginColor = c;
                TempList[i - 1].MiddleColor = d;
                TempList[i - 1].EndColor = w;
                ((PropertyTempItem)TempList[i - 1]).EndTempValue = (int)((List<double>)t["TEXP"])[i];
            }

    
          
        }

       
        internal void AddMaterial(DSRD.T_MaterialRow t_MaterialRow)
        {
            var frmadd = new FrmAddMaterial
                             {
                                 ListaMaterial = Algorithm.Materiales,
                                 Material = t_MaterialRow,
                                 Espesor = 200
                             };
            if (frmadd.ShowDialog(this) == DialogResult.OK)
            {
                Algorithm.Materiales.Add(t_MaterialRow);
                Algorithm.Spesor.Add((double) frmadd.Espesor/1000);
                TempList.Add(new PropertyTempItem(this, TempList, t_MaterialRow, /*frmadd.Formato*/null)
                                 {BeginValue = 0, EndValue = frmadd.Espesor,});
                CalculateInvalidate(Algorithm.Materiales.Count - 1);
            }
            else
                return;
        }

        public void ReCalculateAll()
        {
            for (int i = 0; i < Algorithm.Materiales.Count - 1; i++)
                CalculateInvalidate(i);
            Invalidate();
        }
        protected override void MouseUpEv()
        {
            if (Moving)
            {
                for (int index = 0; index < TempList.Count; index++)

                    Algorithm.Spesor[index] = (double) TempList[index].Width()/1000;
                if (TempList.Selected != null)
                {
                    CalculateInvalidate(TempList.IndexOf(TempList.Selected));
                    Invalidate();
                }
            }
            base.MouseUpEv();
        }

        public EventHandler OnComboBoxChanged { get; set; }

        public double Espesor
        {
            get { return Algorithm.Spesor.Sum()*1000; }
        
        }

        public double Volumen
        {
            get
            {
                return Espesor*Algorithm.Project.area;
            }
           
        }

        public double Peso
        {
            get

            {
                return Algorithm.Materiales.Sum(material => GetSpesor(material)*material.GetT_Propiedad_FisicaRows()[0].Densidad*Algorithm.Project.area);
            }
        }

        public double Costo
        {

            get

            {
                return Algorithm.Materiales.Sum(t => t.GetT_Propiedad_ProduccionRows()[0].getCostoProm());
           
            }
         
        }

        public double PerdidaTotal
        {
            get
            {
                if(Algorithm.LastSisParcial!=null)
                return (double )Algorithm.LastSisParcial["QPAR"] * Algorithm.Project.area;
                return 0;
            }
         
        }

        public double FlujoCalorico
        {
            get
            {
                if (Algorithm.LastSisParcial != null)
                    return (double)Algorithm.LastSisParcial["QPAR"]; return 0;
            }
         
        }

        private void UCPropertyTempControl_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        public void UCPropertyTempControl_DragDrop(object sender, DragEventArgs e)
        {
       
            var t = (TreeListNode)e.Data.GetData("DevExpress.XtraTreeList.Nodes.TreeListNode");
            if (t != null)
                if( t.Tag is DSRD.T_MaterialRow)
                AddMaterial((DSRD.T_MaterialRow) t.Tag);
            
        }

        public void UCPropertyTempControl_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        public double GetSpesor(DSRD.T_MaterialRow material)
        {
            var i = Algorithm.Materiales.IndexOf(material);
            if (i != -1)
                return Algorithm.Spesor[i]*1000;
            return -1;
        }




        internal void LoadFromProject()
        {
            TempList.Clear();
            for (int index = 0; index < Algorithm.Materiales.Count; index++)
            {
                DSRD.T_MaterialRow materialRow = Algorithm.Materiales[index];
                TempList.Add(new PropertyTempItem(this, TempList, materialRow, /*frmadd.Formato*/null)
                                 {BeginValue = 0, EndValue = (int) (Algorithm.Spesor[index]*1000),});
                //CalculateInvalidate(index);
            }
            ReCalculateAll();
        }
    }
[Serializable]
    public class PropertyItemList:TemperatureItemList
    {
        public PropertyItemList(UCTemperatureControl c) : base(c)
        {
        }
        private int _tempinterna;
        private int _tempamb;
        public int TemperaturaInterna
        {
            get { return _tempinterna; }
            set
            {
                _tempinterna = value;
                if(_control!=null)
                ((UCPropertyTempControl)_control).ReCalculateAll();
            }
        }
        public int TemperaturaAmbiente
        {
            get { return _tempamb; }
            set
            {
                _tempamb = value; if (_control != null)
                    ((UCPropertyTempControl)_control).ReCalculateAll();
            }
        }
        public override int EndValue { get { return this.Sum(c => c.EndValue); } }
    }
[Serializable]
    public class PropertyTempItem : TemperatureItem
    {
        public PropertyTempItem(UCSelectableControl control,TemperatureItemList tempList, DSRD.T_MaterialRow materialRow, DSRD.T_Tipo_FormatoRow formatoRow)
            : base(control,tempList)
        {
            Material = materialRow;
            Formato = formatoRow;
        }
        public int PrevEndTempValue { get
        {
            var a = List.IndexOf(this);
            if (a == 0)
                //if (EndTempValue == 0)
                return ((PropertyItemList)List.Control.TempList).TemperaturaInterna;
            //     else
           //         return EndTempValue;
            //else
        
            return ((PropertyTempItem) List[a - 1]).EndTempValue;
            //return 0;
        } }
        private int _endtempvalue;
        public int EndTempValue { get { return _endtempvalue; } set { _endtempvalue = value; } }
        public override int EndValue
        {
            get { return _endvalue; }
            set
            {
                if(value<10)
                    return;
                _endvalue = value;
                if(_combo!=null)
                {
                    _combo.Properties.EditValueChanged -= Properties_EditValueChanged;
                    _combo.EditValue = value;
                    _combo.Properties.EditValueChanged += Properties_EditValueChanged;  
                }
                
                if (value == 0)
                    return;
                //var i = List.IndexOf(this);
                //if (i != -1)
                //    if (i == List.Count - 1)

                //        List.Control.EndValue = value;
                //    else
                //        List[i + 1].BeginValue = value;

           
            }
        }
        public override String GetInformationText()
        {
            return Material.namematerial;
        }
        public override Rectangle GetInformationRect()
        {
            // List.Control.ChangeSide
            var result = base.GetInformationRect();
            var t = ACINOX.Functions.Image.GetTextSize(GetInformationText(), List.Control.Font);
            var li = result.Left;
            var ri = ControlSize.Width + 5;

            if (li > Rectangle.Left && li + ri < _selectControl.Right)
            {
            }
            else

                if (result.Left + ri > _selectControl.Right)
                    //if (result.Width < ri /*&& List.Control.ChangeSide<0*/ )
                    //    li = Rectangle.Left;
                    //else
                    li = _selectControl.Right - ri - 5 ;
              
            else if (li < Rectangle.Left)
                li = Rectangle.Left;
          


                return new Rectangle(li, result.Top, ri, Separator);
            //return result;
        }

        internal int Separator {get { 
 
            return ACINOX.Functions.Image.GetTextSize("a",List.Control.Font).Height + 10;
        }}
        internal String UpperText(bool complete =false)
        {
            return complete ? List.Sum(w => w.EndValue).ToString() : PrevEndValue.ToString();
        }

        internal Rectangle UpperTextRect(bool complete =false) { var t = ACINOX.Functions.Image.GetTextSize(UpperText(complete), List.Control.Font);

            var r = Rectangle;
            return complete ? new Rectangle(r.Right-t.Width,r.Top,t.Width,t.Height) : new Rectangle(r.Left-t.Width/2,r.Top,t.Width,t.Height);
        }
        private bool IntersectUpperText(bool complete =false)
        {
            var r = false;
            if(complete)
            {
                r = UpperTextRect(true).IntersectsWith(UpperTextRect()) ;
            }
            else
            for (int index = 0; index<List.Count;index++)  {
                var temperatureItem = (PropertyTempItem)List[index];
                if (temperatureItem != this)
                {
                    r = temperatureItem.UpperTextRect().IntersectsWith(UpperTextRect()) && index > List.IndexOf(this);
                    if(r )
                        break;
                    
                }
            }
            return r;
        }
        private void DrawSignal(Graphics e,Color c,String Text, Rectangle TextRect,bool complete=false)
        {
            try
            {
                var brush = new SolidBrush(c);
                var pen = new Pen(c);

                if (!IntersectUpperText() && !IntersectUpperText(!complete))
                    e.DrawString(Text, List.Control.Font, brush, TextRect.Left, 0);
                var pt1 = new Point(Rectangle.Location.X, Rectangle.Location.Y / 2 + 5);
                var pt2 = new Point(Rectangle.Right,
                                    Separator / 2 + 5);
                e.DrawLine(pen, pt1, pt2);
                if (complete)
                {
                    pt1 = new Point(Rectangle.Right, Separator - Separator / 2);
                    pt2 = new Point(Rectangle.Right, Separator);
                }
                else
                {
                    pt1 = new Point(Rectangle.Location.X, Separator - Separator / 2);
                    pt2 = new Point(Rectangle.Location.X, Separator);
                }

                e.DrawLine(pen, pt1, pt2);
            }
            catch (Exception)
            {

            }
        }
        public void DrawUpperText(Graphics e,Color c)
        {
    
                DrawSignal(e,c,UpperText(),UpperTextRect());
                if (List.IndexOf(this) == List.Count - 1)
                    DrawSignal(e, c, UpperText(true), UpperTextRect(true),true);
             
        }
        public void DrawIndicator(Graphics e,Color c)
        {
            var i = GetInformationRect();
            var r = Rectangle;
            e.DrawLine(new Pen(c), new Point(r.Left + (r.Width/2), r.Bottom), new Point(r.Left + (r.Width/2), i.Top));

        }
        public override int Paint(Graphics g)
        {
            var t = base.Paint(g);
            DrawUpperText(g, Color.Black);
            PaintRectangle(g, Color.Black);
            DrawIndicator(g,Color.Black);
            ////c.Invalidate();
            //c.BringToFront(););
            return t;
        }
        public override Rectangle MoverRectangle
        {
            get { var t = base.MoverRectangle;
                var i = 3;
                if (List.IndexOf(this) == List.Count - 1)
                    i = -2;
                return new Rectangle(t.Left+i , Separator, t.Width,t.Height-Separator); }
        }
        public override Rectangle Rectangle
        {
            get
            {
                var s = 3;
                var t = base.Rectangle;
                var i = List.IndexOf(this);
            t = new Rectangle(t.Left,Separator,t.Width,t.Height-Separator);
                if(i==0)
                    t =new Rectangle(t.Left+s,t.Top,t.Width,t.Height);
                else
                if(i==List.Count-1)
                
                    t = new Rectangle(t.Left,t.Top,t.Width-s-2,t.Height);

                return t;
            }
        }

        private  Size ControlSize{get
        {
            return new Size(ACINOX.Functions.Image.GetTextSize(GetInformationText(), List.Control.Font).Width+50, 10);
        }} 
    [NonSerialized]
        private Label _labelt;
    [NonSerialized]
        private ComboBoxEdit _combo;
        public DSRD.T_MaterialRow Material { get; set; }
        public DSRD.T_Tipo_FormatoRow Formato { get; set; }
        public void ReloadCombo()
        {
            //_combo.Properties.Items.Clear();
            //var t = Material.GetEspesoresAll(Formato.idTipo_Formato);
            //foreach (var w in t)
            //    _combo.Properties.Items.Add(w);
            if(_combo.Properties.Items.Count==0)
            _combo.Properties.Items.Add("10");
        }
        public override Control GetInformation()
        {
         
            if (c == null)
            {
                c = new Panel();
                c.Width = ControlSize.Width;
                c.Height = ControlSize.Height;
                 _combo = new ComboBoxEdit();
                _combo.EditValue = EndValue;
                 _combo.Properties.EditValueChanged += new EventHandler(Properties_EditValueChanged);
                _combo.KeyDown += List.Control.UCTemperatureControl_KeyDown;
                //_combo.KeyUp +=List.Control.KeyUp
                _combo.Parent = c;
                _combo.Top = 2;
                _combo.Left = 2;
                _combo.Tag = this;
                _combo.Width = 50;
            
                _labelt = new Label();
                _labelt.Width = ControlSize.Width - _combo.Width;
                _labelt.Left = _combo.Left + _combo.Width + 1;
                _labelt.Top = c.Height/2 ;
                
                _labelt.Parent = c;
              
            }
           ReloadCombo();

            _labelt.Text = GetInformationText();

            return c;
        }

        void Properties_EditValueChanged(object sender, EventArgs e)
        {
            var t = (ComboBoxEdit) sender;
            int s;
            if(int.TryParse(t.EditValue.ToString(),out s))
            ((PropertyTempItem) t.Tag).EndValue = s;
        }

      
    }
}
