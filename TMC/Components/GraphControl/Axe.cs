using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TMC.Components.GraphControl
{
    public enum AxisScale { Logaritmic, Lineal };
    public enum AxisOrientation {Unknown,Horizontal,Vertical}
    public enum AxisValueOrientation { Unknown, FrontToBack, BackToFront }
    [Serializable]
    public class Axis : SelectableObject
    {
        private readonly GraphicObject _control;
        private readonly AxisPointList _points;

        public Axis(GraphicObject graphControl)
        {
            _control = graphControl;
            //   SelectColor = graphControl.SelectColor;
            Scale = AxisScale.Lineal;
            Color = Color.Black;
            UM = "";
            _points = new AxisPointList(this);
        }
        public Point RealPointInitial { get; set; }
        public Point RealPointFinal { get; set; }
        public double ValueMax { get; set; }
        public double ValueMin { get; set; }
        public Color Color { get; set; }
        public String Name { get; set; }
        public String UM { get; set; }
        public AxisScale Scale { get; set; }
        public GraphicObject GraphObject { get { return _control; } }
        public AxisPointList Points { get { return _points; } }
        public AxisOrientation Orientation{get
        {
            var pstart = RealPointInitial;
            var pend = RealPointFinal;
            var pdist = new Point(Math.Abs(pstart.X - pend.X), Math.Abs(pstart.Y - pend.Y));

            if (pdist.X == 0)
                return AxisOrientation.Vertical;
            if (pdist.Y == 0)
                return AxisOrientation.Horizontal;
            return AxisOrientation.Unknown;
        }}
        public bool IsPrincipal()
        {
            return (GraphObject.Point.X == RealPointFinal.X && GraphObject.Point.Y == RealPointFinal.Y) || (GraphObject.Point.X == RealPointInitial.X && GraphObject.Point.Y == RealPointInitial.Y);
        }
        public AxisValueOrientation ValueOrientation{get
        {
            switch (Orientation)
            {
                
                case AxisOrientation.Horizontal:
                    return RealPointInitial.X < RealPointFinal.X
                               ? AxisValueOrientation.FrontToBack
                               : AxisValueOrientation.BackToFront;
                case AxisOrientation.Vertical:
                    return RealPointInitial.Y < RealPointFinal.Y
                             ? AxisValueOrientation.FrontToBack
                             : AxisValueOrientation.BackToFront;
            }
            return AxisValueOrientation.Unknown;
        }}
        private double? ValueFromPoint(Point p,AxisPoint p1,AxisPoint p2)
        {
            double? value = null;
            double distancia = Math.Abs(p2.Value - p1.Value);
            double f = 0;
            //  var p = Math.Round(ACINOX.Functions.Math.Percent.Percen(distancia, cant));
            var pstart = p1.Point;
            var pend = p2.Point; 
            var totp = 0.0;
            var partp = 0.0;
            var pdist = new Point(Math.Abs(pstart.X - pend.X), Math.Abs(pstart.Y - pend.Y));
            if (pdist.X == 0)
            {
                totp = pdist.Y;
               if (ValueOrientation==AxisValueOrientation.FrontToBack)
               {
                   partp = Math.Abs(pstart.Y - p.Y);
                  f= p1.Value;
               }
               else
               {
                   partp = Math.Abs(pend.Y - p.Y);
                    f = p2.Value;
               }
            }
            else
            {
             totp = pdist.X;
             if (ValueOrientation == AxisValueOrientation.FrontToBack)
             {
                 partp = Math.Abs(pstart.X - p.X);
                 f = p1.Value;
             }
             else
             {
                 partp = Math.Abs(pend.X - p.X);
                 f = p2.Value;
             }
            }
            var perct = ACINOX.Functions.Math.Percent.Percen(totp, partp);
            if (perct >= 0 && perct <= 100)

                value = ValueMax - ValueMin > 0 ? f + ACINOX.Functions.Math.Percent.Part(distancia, perct) : f - ACINOX.Functions.Math.Percent.Part(distancia, perct);

            if (value != null)
                return (double?) Math.Round((decimal) value, 3);
            return value;
        }
        private static int CompareDinosByLength(AxisPoint x, AxisPoint y)
        {
            if (x.Point == y.Point)
                return 0;
            if (x.Point.X == y.Point.X && x.Point.Y > y.Point.Y || x.Point.Y == y.Point.Y && x.Point.X > y.Point.X)
                return 1;
            if (x.Point.X == y.Point.X && x.Point.Y < y.Point.Y || x.Point.Y == y.Point.Y && x.Point.X < y.Point.X)
                return -1;
            return 0;
        }

        public double? ValueFromPoint(Point p)
        {
            AxisPoint p1 = null;
            AxisPoint p2 = null;
            foreach (AxisPoint axisPoint in Points)
            {
                switch (Orientation)
                {
                    case AxisOrientation.Unknown:
                        break;
                    case AxisOrientation.Horizontal:
                        {
                            if (axisPoint.Point.Y != RealPointFinal.Y)
                                axisPoint.Point = new Point(axisPoint.Point.X, RealPointFinal.Y);
                            break;
                        }
                    case AxisOrientation.Vertical:
                        {
                            if (axisPoint.Point.X != RealPointFinal.X)
                                axisPoint.Point = new Point(RealPointFinal.X, axisPoint.Point.Y);
                            break;
                        }

                    default:
                        break;
                }
            }

            var t = Points.ToList();
            AxisPoint v1 = new AxisPoint(null, RealPointInitial, ValueMin),
                      v2 = new AxisPoint(null, RealPointFinal, ValueMax);


            t.Add(v1);
            t.Add(v2);
            t.Sort(CompareDinosByLength);
            for (int i = 0; i < t.Count; i++)
            {
                p1 = t[i];
                if (i + 1 < t.Count)
                {
                    p2 = t[i + 1];
                     switch (Orientation)
                    {
                        case AxisOrientation.Unknown:
                            break;
                        case AxisOrientation.Horizontal:
                            {
                                if (p1.Point.X <= p.X && p2.Point.X >= p.X)
                                    return ValueFromPoint(p, p1, p2);
                                break;
                            }
                        case AxisOrientation.Vertical:
                            {
                                if (p1.Point.Y <= p.Y && p2.Point.Y >= p.Y)
                                    return ValueFromPoint(p, p1, p2);

                                break;
                            }

                        default:
                            break;
                    }

                }

            }


            return null;
        }

        public void Draw(Graphics e, UCGraphControl control)
        {
            if (!RealPointFinal.IsEmpty && !RealPointInitial.IsEmpty)
            {
                var pen = new Pen(Color,control.LineWidth);
                e.DrawLine(pen, RealPointInitial, RealPointFinal);
                new Size();
                var s = Orientation == AxisOrientation.Horizontal ? new Size(control.LineWidth, control.AxisLineWidth * 2) : new Size(control.AxisLineWidth*2, control.LineWidth);

                foreach (AxisPoint Axispoint in Points)
                {

                    var p = Orientation == AxisOrientation.Horizontal ? new Point(Axispoint.Point.X - control.LineWidth / 2, Axispoint.Point.Y - control.AxisLineWidth ) : new Point(Axispoint.Point.X - control.AxisLineWidth , Axispoint.Point.Y- control.LineWidth);

              

                    e.FillRectangle(Brushes.Black, new Rectangle(p, s));
                }

            }
            else
                if (!RealPointInitial.IsEmpty)
                {
                    var pen = new Pen(Color, control.LineWidth);
                 var p = control.PointToClient(Cursor.Position);
                    if( control.UseOrtogonal)
                    {
                        var t = new Point(Math.Abs(RealPointInitial.X - p.X), Math.Abs(RealPointInitial.Y - p.Y));
                        if (t.X > t.Y)
                            p.Y = RealPointInitial.Y;
                        else
                            p.X = RealPointInitial.X ;
                        }
                    e.DrawLine(pen, RealPointInitial,p );

                }
        }

        public  void CheckRects(bool  useOrtogonal=true)
        {
            if (useOrtogonal)
            {
                var p = new Point();
                p = ValueOrientation==AxisValueOrientation.BackToFront ? RealPointInitial : RealPointFinal;
                
                var t = new Point(Math.Abs(RealPointInitial.X - RealPointFinal.X), Math.Abs(RealPointInitial.Y - RealPointFinal.Y));
                if (t.X > t.Y)
                    p.Y = ValueOrientation == AxisValueOrientation.BackToFront ? RealPointFinal.Y : RealPointInitial.Y; 
                else
                    p.X = ValueOrientation == AxisValueOrientation.BackToFront ? RealPointFinal.X : RealPointInitial.X; 
                RealPointFinal = p;
            }
        }

        public Point PointFromValue(double temp)
        {
            var v = ValueMax - ValueMin;
            var p = ACINOX.Functions.Math.Percent.Percen(v, temp);
            Point pos = new Point();
            if (Orientation == AxisOrientation.Horizontal)
                pos = new Point((int) ACINOX.Functions.Math.Percent.Part( RealPointFinal.X - RealPointInitial.X,p),
                                RealPointFinal.Y);
            else
               pos = new Point(RealPointFinal.X,
                                (int) ACINOX.Functions.Math.Percent.Part( RealPointFinal.Y - RealPointInitial.Y, p));


            return pos;

        }
    }
    [Serializable]
    public class AxisPoint : GraphPoint
    {
        private AxisPointList _list;
        public AxisPoint(AxisPointList Axis)
            : base(new Point())
        {
            _list = Axis;
        }
        public AxisPointList PointList { get { return _list; } }
        public AxisPoint(AxisPointList Axis, Point p, double v)
            : base(p)
        {
            _list = Axis;

            Value = v;
        }

        public double Value { get; set; }
    }
    [Serializable]
    public class AxisPointList : List<AxisPoint>
    {
        private Axis _Axis;
        public AxisPointList(Axis Axis)
        {
            _Axis = Axis;
        }

        public Axis Axis { get { return _Axis; } }
     
        public void Generate(int cant, double max, double min)
        {
            Clear();
            var distancia = Math.Abs(max - min);
            var p = ACINOX.Functions.Math.Percent.Percen(distancia, cant);
            Point pstart = new Point();
            Point pend = new Point();
            if(Axis.ValueOrientation==AxisValueOrientation.FrontToBack)
            {
             pstart = Axis.RealPointInitial;
              pend = Axis.RealPointFinal;
            }
            else
            {
                pstart = Axis.RealPointInitial;
                pend = Axis.RealPointFinal;   
            }
            var pdist = new Point(Math.Abs(pstart.X - pend.X), Math.Abs(pstart.Y - pend.Y));
            switch (Axis.Orientation)
            {
                case AxisOrientation.Unknown:
                    break;
                case AxisOrientation.Horizontal:
                    {
                     var  t = pdist.X;
                        var pw = ACINOX.Functions.Math.Percent.Part(t, p);
                        for (int i = 0; i <= t / pw; i++)
                        {
                            int y = pstart.Y;
                            int t2 = i;
                            if (Axis.ValueOrientation == AxisValueOrientation.FrontToBack)
                                t2 += 1;
                            var c = (t2) * pw;
                            int x = Axis.ValueOrientation == AxisValueOrientation.FrontToBack
                                        ? (int)(pstart.X + c)
                                        : (int)(pend.X + c);
                            var v = Axis.ValueOrientation == AxisValueOrientation.FrontToBack
                                ? max - min > 0 ? i * cant : min - i * cant
                                : max - min > 0 ?max - i * cant:i*cant;
                            var n = new AxisPoint(this, new Point(x, y), v);
                            Add(n);
                        }
                        break;
                    }
                case AxisOrientation.Vertical:
                    {
                        var t = pdist.Y;
                        var pw = ACINOX.Functions.Math.Percent.Part(t, p);
                
                        for (int i = 0; i <= t / pw ; i++)
                        {
                            int x =pstart.X;

                            var c = i * pw;
                            int y = Axis.ValueOrientation == AxisValueOrientation.FrontToBack
                                        ? (int) (pstart.Y + c)
                                        : (int) (pend.Y + c);
                            var v = Axis.ValueOrientation == AxisValueOrientation.FrontToBack
                                        ? i* cant
                                        : max - i*cant; 
                            var n = new AxisPoint(this, new Point(x, y), v);
                            Add(n);
                        }
                        break;
                    }
                default:
                    break;
            }
         

        }
    }
    [Serializable]
    public class AxisList : List<Axis>
    {
      
        public Dictionary<Axis, double?> GetValueFromPoint(Point point)
        {
            var r = new Dictionary<Axis, double?>();
            foreach (Axis Axis in this)
                r.Add(Axis, Axis.ValueFromPoint(point));

            return r;
        }
        public DataTable GetValueFromPointTable(Point point)
        {
            var r = new DataTable();
            r.Columns.Add(new DataColumn("Eje"));
            r.Columns.Add(new DataColumn("Valor"));
            var v = new List<object>();
            foreach (Axis axis in this)
            {
                var row = r.NewRow();
                v.Add(axis.Name);
                v.Add(axis.ValueFromPoint(point));
                row.ItemArray = v.ToArray();
                r.Rows.Add(row);
                v.Clear();
            }

            return r;
        }

        public AxisList GetPrincipals() {

            var r = new AxisList();
            foreach (Axis item in this)
               if(item.IsPrincipal())
            {
                if (item.Orientation == AxisOrientation.Horizontal)
                    r.Insert(0, item);
                else
                    r.Add(item);
            }

            return r;
        }
        public Axis ItemsByName(String name)
        {
            foreach (Axis axis in this)
                if (axis.Name.IndexOf(name)!=-1)
                    return axis;
            return null;
        }
        public String GetValueFromPointAsString(Point point)
        {
            var t = GetValueFromPoint(point);
            var s = "";
            var ks = t.Keys.ToList();
            for (int i = 0; i < ks.Count; i++)
            {
                s += ks[i].Name+ "("+ks[i].UM+") : "+ t[ks[i]] ;
                if (i < ks.Count - 1)
                    s += "\n";
            }
            return s;
        }
    }
}
