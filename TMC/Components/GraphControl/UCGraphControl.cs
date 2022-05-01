using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using DevExpress.XtraEditors;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using TMC.Components.GraphControl.DSGraphControlTableAdapters;

namespace TMC.Components.GraphControl
{
    public enum GraphMarc
    {
        Plus,
        X,
        Square,
        Multiply,
        Circule,
        Diamond
    } ;

    public enum GraphState
    {
        Ready, WaitingForClick, ManagingAxis, ManagingStartPoint,
        EndManagingAxis,ManagingSeriePoints
    } ;

    public partial class UCGraphControl : DevExpress.XtraEditors.XtraUserControl
    {

        public UCGraphControl()
        {
            InitializeComponent();
            ManagingAxis = null;
            _graphObj = new GraphicObject();
            UseOrtogonal = true;
            LineWidth = 2;
            AxisLineWidth = 3;
            MoveColor = Color.Red;
            MarkerLineWidth = 4;
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            //   toolTipController1.SetTitle(this, "Valores");
        }
        public delegate bool ClickEventHandler(UCGraphControl sender);
        public delegate void StateEventHandler(UCGraphControl sender, GraphState state);

        public StateEventHandler OnStateChange { get; set; }
        public ClickEventHandler OnClicked { get; set; }
        private GraphicObject _graphObj;

        public void LoadFromStream(Stream stream)
        {
            _graphObj = LoadFromStreamGeneral(stream);
            GraphObject.Series.ClearSelected();
            Refresh();
        }
        public static GraphicObject LoadFromStreamGeneral(Stream stream)
        {
            IFormatter formatter = new BinaryFormatter();
            var r = (GraphicObject)formatter.Deserialize(stream);
            return r;
        }
        public bool UseOrtogonal { get; set; }

        public void  LoadFromFile(string filename)
        {
            var file = new FileStream(filename, FileMode.Open);
            LoadFromStream(file);
            file.Close();
            State = GraphState.Ready;
        }

        public int LineWidth { get; set; }
        public int AxisLineWidth { get; set; }
        public int MarkerLineWidth { get; set; }
        public void SaveToStream(Stream stream)
        {

            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, GraphObject);
        }
        public void SaveToFile(string filename)
        {
            var file = new FileStream(filename, FileMode.Create);
            SaveToStream(file);
            file.Close();
        }
        public GraphicObject GraphObject { get { return _graphObj; } }
     //   public ImageController ImageController { get; set; }
        private void UCGraphControl_Paint(object sender, PaintEventArgs e)
        {
            var bit = new Bitmap(Width, Height);
            var g = Graphics.FromImage(bit);
            if (GraphObject.ImageController != null)
               GraphObject. ImageController.Draw(g);


            if (!GraphObject.Point.IsEmpty)
            {
                var p = GraphObject.Point;
                p.X -= 2;
                p.Y -= 2;
                g.FillRectangle(Brushes.Black, new Rectangle(p, new Size(4, 4)));

            }
            foreach (Axis Axis in GraphObject.Axiss)
                Axis.Draw(g, this);
            GraphObject.Series.Draw(g, this);
            if (ManagingSerie != null)
                ManagingSerie.Points.Draw(g, this);

            e.Graphics.DrawImage(bit, new Point());
        }


        public static RectangleF GetRectangle(PointF p1, PointF p2)
        {
            float top = Math.Min(p1.Y, p2.Y);
            float bottom = Math.Max(p1.Y, p2.Y);
            float left = Math.Min(p1.X, p2.X);
            float right = Math.Max(p1.X, p2.X);

            RectangleF rect = RectangleF.FromLTRB(left, top, right, bottom);

            return rect;
        }
        private Rectangle _bitrectangle = new Rectangle(0, 0, 0, 0);
        public Rectangle BitmapRectangle
        {
            get
            {

                return _bitrectangle;

            }
            set
            {
                _bitrectangle = value;
                Refresh();
            }
        }

        private GraphState _state = GraphState.Ready;
        public GraphState State
        {
            get { return _state; }
            set
            {
                var temp = _state;
                _state = value;
                ChangeState(_state,temp);
                if (OnStateChange != null)
                    OnStateChange(this, temp);

            }
        }
        private void UCGraphControl_Click(object sender, EventArgs e)
        {

            //if (State == GraphState.WaitingForClick)
            //{

            //    if (OnClicked != null)

            //    if (OnClicked(this) && State==GraphState.WaitingForClick)
            //    State = GraphState.Ready;
            //}
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = true;

            popupMenu1.ShowPopup(System.Windows.Forms.Cursor.Position);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            State = barButtonItem1.Down ? GraphState.ManagingStartPoint  : GraphState.Ready;
        }

        private void UCGraphControl_MouseDown(object sender, MouseEventArgs e)
        {
            switch (State)
            {
                case GraphState.Ready:
                    {

                        break;
                    }
                case GraphState.WaitingForClick:
                    {
                        ReturnPoint = e.Location;
                        State = GraphState.Ready;
                        break;
                    }
                case GraphState.ManagingAxis:
                    {
                        if (ManagingAxis == null)
                        {
                            ManagingAxis = new Axis(GraphObject);
                            GraphObject.Axiss.Add(ManagingAxis);
                        }

                        if (ManagingAxis.RealPointInitial.IsEmpty)
                        {
                            ManagingAxis.RealPointInitial = e.Location;
                            barStaticItem1.Caption = @"Establezca el punto de final del eje";
                        }
                        else
                            if (ManagingAxis.RealPointFinal.IsEmpty)
                            {
                                var p = PointToClient(Cursor.Position);
                                if (UseOrtogonal)
                                {
                                    var t = new Point(Math.Abs(ManagingAxis.RealPointInitial.X - p.X), Math.Abs(ManagingAxis.RealPointInitial.Y - p.Y));
                                    if (t.X > t.Y)
                                        p.Y = ManagingAxis.RealPointInitial.Y;
                                    else
                                        p.X = ManagingAxis.RealPointInitial.X;
                                }
                                ManagingAxis.RealPointFinal = p;
                                State = GraphState.EndManagingAxis;
                            }

                        break;

                    }
                case GraphState.ManagingStartPoint:
                    {

                        GraphObject.Point = e.Location;

                        State = GraphState.Ready;
                        break;
                    }
                //case GraphState.ManagingSeriePoints:
                //    {

                //        ReturnPoint = e.Location;
                //        State = GraphState.Ready;
                //        break;
                //    }
                default:
                    break;
            }
            Refresh();
        }

        public Axis ManagingAxis { get; set; }
        public Point ReturnPoint { get; set; }
       private Random random = new Random();
        private Color _lastcolor;
        public Color GetColors()
        {
            var r = new List<int>();
            
            var value = 0;
            do
                value = random.Next(255);
            while (value == _lastcolor.R);
            r.Add(value);
            do
                value = random.Next(255);
            while (value == _lastcolor.G);
            r.Add(value);
            do
                value = random.Next(255);
            while (value == _lastcolor.B);
            r.Add(value);
         var   temp = Color.FromArgb(255,r[0], r[1], r[2]);
            _lastcolor = temp;
            return _lastcolor;
        }

        public Color SelectColor { get; set; }

        private Serie _serie;
        public Serie ManagingSerie
        {
            get { return _serie; }
            set
            {
                if (value == null && _serie != null)
                    _serie.Points.ClearSelected();
                _serie = value;
            }
        }

        private Point tp;
        private void UCGraphControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (State!=GraphState.ManagingSeriePoints && State != GraphState.WaitingForClick)
            {
                var t = Cursor.Position;
                toolTipController1.ShowHint(GraphObject.Axiss.GetValueFromPointAsString(e.Location), "Valores ejes", t);
                tp = e.Location;
            }
            if (Cursor == Cursors.Cross)
                barStaticItem2.Caption = e.Location.ToString();
            else
                barStaticItem2.Caption = "";
            if (State == GraphState.ManagingAxis && ManagingAxis != null)
                if (ManagingAxis.RealPointFinal.IsEmpty )

                    Refresh();
            if(ManagingSerie!=null)
                Refresh();
        }

        public Color MoveColor { get; set; }
        public event EventHandler OnPointChange;
        public event EventHandler OnPointButtonClick;

        public void InvokeOnPointButtonClick(object sender, EventArgs eventArgs)
        {

            if (OnPointButtonClick != null) OnPointButtonClick(sender, eventArgs);
        }
        public void InvokeOnPointChange(object sender, EventArgs eventArgs)
        {

            if (OnPointChange != null) OnPointChange(sender, eventArgs);
        }

        internal void ChangeState(GraphState _bef,GraphState temp=GraphState.Ready)
        {
            if (_state != _bef)
                _state = _bef;
            barButtonItem1.Down = _state == GraphState.ManagingStartPoint;
            switch (_state)
            {
                case GraphState.Ready:
                    {
                        if (temp == GraphState.ManagingAxis)
                        { 
                           GraphObject.Axiss.Remove(ManagingAxis);
                           ManagingAxis = null;
                        }
                        Cursor = Cursors.Default;
                        barStaticItem1.Caption = @"Listo.";
                        break;
                    }
                case GraphState.ManagingStartPoint:
                    {
                        barStaticItem1.Caption = @"Establezca el punto de inicio del grafico";
                        Cursor = Cursors.Cross;
                        break;
                    }
                case GraphState.ManagingAxis:
                    {
                        barStaticItem1.Caption = @"Establezca el punto de inicio del eje";
                        Cursor = Cursors.Cross;
                        break;
                    }
                case GraphState.WaitingForClick:
                    {
                        if(temp==GraphState.ManagingStartPoint)
                            barStaticItem1.Caption = @"Establezca el punto de inicio del grafico";
                        else
                        barStaticItem1.Caption = @"Establezca el punto";
                        Cursor = Cursors.Cross;
                        break;
                    }
                case GraphState.EndManagingAxis:
                    {
                        barStaticItem1.Caption = @"Establezca las propiedades del eje";
                        Cursor = Cursors.Cross;
                        break;
                    }
                case GraphState.ManagingSeriePoints:
                    {
                        barStaticItem1.Caption = @"Establezca el punto de la serie";
                        Cursor = Cursors.Default;
                        break;
                    }
                default:
                    throw new ArgumentOutOfRangeException("value");
            }
        }

   

        private void UCGraphControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                State = GraphState.Ready;
        }

        private void UCGraphControl_Leave(object sender, EventArgs e)
        {
     
        }

        private void UCGraphControl_MouseLeave(object sender, EventArgs e)
        {
            toolTipController1.HideHint();
        }
    }
   
    [Serializable]
    public class GraphicObject
    {
        public GraphicObject()
        {
            _point = new Point();
          ImageController = new ImageController();
        }
        private AxisList _Axiss = new AxisList();
        private SerieList _series = new SerieList();

        private Point _point;


        public AxisList Axiss { get { return _Axiss; } }
        public SerieList Series { get { return _series; } }
        public Point Point { get { return _point; } set { _point = value; } }

        public ImageController ImageController
        {
            get; set; }
        private ParameterList GetParams()
        {
            var r = new ParameterList();
            foreach (Serie serie in Series)
                foreach (SeriePoint point in serie.Points)
                    foreach (Parameter param in point.Params)
                        if (r.IndexOfByName(param.Name) == -1)
                            r.Add(param);
            return r;
        }
        public DataTable CreateData()
        {
            var R = new DataTable("");
            R.Columns.Add("No");
            R.Columns.Add("Serie");
            var p = GetParams();
            foreach (Axis axis in Axiss)
                R.Columns.Add(axis.Name + "(" + axis.UM + ")");
            foreach (Parameter axis in p)
                R.Columns.Add(axis.Name+"("+axis.UM+")");
            var values = new List<object>();
            for (int index = 0; index < Series.Count; index++)
            {
                Serie series = Series[index];

                for (int i = 0; i < series.Points.Count; i++)
                {
                    SeriePoint value = series.Points[i];
                    values.Add(i + 1);
                    values.Add(series.Name);
                    foreach (Axis axis in Axiss)
                        values.Add(axis.ValueFromPoint(value.Point));
                    foreach (Parameter axis in p)
                        if (value.Params.IndexOfByName(axis.Name) == -1)
                            values.Add(null);
                        else
                            values.Add(axis.Value);



                    var rw = R.NewRow();
                    rw.ItemArray = values.ToArray();
                    R.Rows.Add(rw);
                    values.Clear();
                }

            }


           

            return R;
        }

        internal void ExportToDB()
        {
            var dsgraphcontrol = new DSGraphControl();
            var axistableadapter = new T_GraphAxisTableAdapter();
            var axispts = new T_GraphAxisPointTableAdapter();
            foreach (Axis item in Axiss)
            {
             var ar=   dsgraphcontrol.T_GraphAxis.NewT_GraphAxisRow();
             ar.color = item.Color.ToArgb();
             ar.nameaxis = item.Name;
             ar.valuemax = item.ValueMax;
             ar.valuemin = item.ValueMin;
             ar.pxi = item.RealPointInitial.X;
             ar.pyi = item.RealPointInitial.Y;
             ar.pxf = item.RealPointFinal.X;
             ar.pyf = item.RealPointFinal.Y;
             dsgraphcontrol.T_GraphAxis.AddT_GraphAxisRow(ar);
          //   ar.SetAdded();
             foreach (AxisPoint item2 in item.Points)
             {
                 var arp = dsgraphcontrol.T_GraphAxisPoint.NewT_GraphAxisPointRow();
                 arp.idaxis = ar.idaxis;
                 arp.px = item2.Point.X;
                 arp.py = item2.Point.Y;
                 arp.value = item2.Value;
              //   arp.SetAdded();
                 dsgraphcontrol.T_GraphAxisPoint.AddT_GraphAxisPointRow(arp);
                 dsgraphcontrol.T_GraphAxisPoint.AcceptChanges();
             }
             dsgraphcontrol.T_GraphAxis.AcceptChanges();
            }
            dsgraphcontrol.AcceptChanges();
            axistableadapter.Update(dsgraphcontrol.T_GraphAxis);
            axispts.Update(dsgraphcontrol.T_GraphAxisPoint);
        }
    }



}