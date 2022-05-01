using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TMC.Components.GraphControl
{

    [Serializable]
    public class Serie : SelectableObject
    {
        public Serie()
        {
            _points = new SeriePointList(this);

        }

        public String Name { get; set; }
        public Color Color { get; set; }
        public GraphMarc Marca { get; set; }

        private readonly SeriePointList _points;

        public SeriePointList Points { get { return _points; } }



    }
    [Serializable]
    public class SerieList : List<Serie>
    {
        public SerieList ByName(string name)
        {
            var r = new SerieList();
            foreach (Serie serie in this)
                if (serie.Name.IndexOf(name)!=-1)
                    r.Add(serie);
            return r;
        }
        internal void Draw(Graphics e, UCGraphControl uCGraphControl)
        {
            foreach (Serie serie in this)
                serie.Points.Draw(e, uCGraphControl);
        }

        internal void ClearSelected()
        {
            foreach (Serie item in this)
                item.Points.ClearSelected();
        }
        private SerieList GetSerieCreate(String name)
        {
            var s = ByName(name);
            if (s.Count == 0)
            {
                var s1 = new Serie();
                s1.Name = name;
                Add(s1); ;
                
            }
            return this;
        }
        public SerieList Intercepts(bool ejex)
        {
            var r = new SerieList();
            for (int index = 0; index < this.Count; index++)
            {
                Serie serie = this[index];
               
                    for (int i = 0; i < this.Count; i++)
                        if (i != index)
                        {
                            Serie serie1 = this[i];
                            foreach (SeriePoint seriePoint in serie.Points)
                            {
                                //seriePoint.GetValue()
                               var t= serie1.Points.Intercept(seriePoint.Point,ejex);
                                if(t.Count>0)
                                {
                                    var s1 = r.GetSerieCreate(serie.Name);
                                    var s2 = r.GetSerieCreate(serie1.Name);

                                    if(s1[0].Points.IndexOf(seriePoint)==-1)
                                        s1[0].Points.Add(seriePoint);
                                    foreach (SeriePoint point in t)
                                    {
                                        if (s2[1].Points.IndexOf(point) == -1)
                                            s2[1].Points.Add(point); 
                                    }
                                   
                                }
                            }
                        }
                
            }
            return r;
        }
    }
      [Serializable]
    public class Parameter
      {

          public String Name { get; set; }
          public String UM { get; set; }
          public double Value { get; set; }
      }
      [Serializable]
      public class ParameterList:List<Parameter>
      {

          public void CopyTo(ParameterList parameterList)
          {
              parameterList.Clear();
              foreach (Parameter param in this)
                  parameterList.Add(param);
          }
          public DataTable AsDataTable()
          {
              var r = new DataTable("Parameters");
              r.Columns.Add("Name");
              r.Columns.Add("UM");
              r.Columns.Add("Value");

              for (int index = 0; index < this.Count; index++)
              {
                  Parameter parameter = this[index];
                  var row = r.NewRow();
                  row.ItemArray = new object[] {parameter.Name, parameter.UM, parameter.Value };
                  r.Rows.Add(row);
              }

              return r;
          }
          public void CopyFromDataTable(DataTable dataTable)
          {
              Clear();
              foreach (DataRow dataRow in dataTable.Rows)
                  Add(new Parameter
                          {
                              Name = dataRow.ItemArray[0].ToString(),
                              UM = dataRow.ItemArray[1].ToString(),
                              Value = Convert.ToDouble(dataRow.ItemArray[2].ToString())
                          });
          }

          internal int IndexOfByName(string p)
          {
              for (int index = 0; index < this.Count; index++)
              {
                  Parameter parameter = this[index];
                  if (parameter.Name == p)
                      return index;
              }
              return -1;
          }
      }
    [Serializable]
    public class SeriePoint : GraphPoint
    {
        private SeriePointList _list;
        public SeriePoint(SeriePointList Serie)
            : base(new Point())
        {
            _list = Serie;
        }
        public SeriePointList PointList { get { return _list; } }
        public SeriePoint(SeriePointList Serie, Point p)
            : base(p)
        {
            _list = Serie;

        }
        public Dictionary<Axis,double?> GetValue(UCGraphControl control)
        {
         
            return control.GraphObject.Axiss.GetValueFromPoint(Point); 
        }
        private readonly ParameterList _params = new ParameterList();
        public ParameterList Params { get { return _params; } }
    }
    [Serializable]

    public class SeriePointList : List<SeriePoint>
    {
      
        private Serie _serie;
        public Serie Serie { get { return _serie; } }
        public SeriePointList(Serie s) { _serie = s; }
        private void DrawPoint(Graphics g, Point p, Pen pen, UCGraphControl control)
        {
            switch (Serie.Marca)
            {
                case GraphMarc.Plus:
                    {
                        g.DrawLine(pen, new Point(p.X - control.MarkerLineWidth, p.Y), new Point(p.X + control.MarkerLineWidth, p.Y));
                        g.DrawLine(pen, new Point(p.X, p.Y - control.MarkerLineWidth), new Point(p.X, p.Y + control.MarkerLineWidth));

                        break;
                    }
                case GraphMarc.X:
                    {
                        g.DrawLine(pen, new Point(p.X - control.MarkerLineWidth, p.Y - control.MarkerLineWidth), new Point(p.X + control.MarkerLineWidth, p.Y + control.MarkerLineWidth));
                        g.DrawLine(pen, new Point(p.X - control.MarkerLineWidth, p.Y + control.MarkerLineWidth), new Point(p.X + control.MarkerLineWidth, p.Y - control.MarkerLineWidth));

                        break;
                    }
                case GraphMarc.Square:
                    {
                        g.DrawLine(pen, new Point(p.X - control.MarkerLineWidth, p.Y - control.MarkerLineWidth), new Point(p.X + control.MarkerLineWidth, p.Y - control.MarkerLineWidth));
                        g.DrawLine(pen, new Point(p.X - control.MarkerLineWidth, p.Y - control.MarkerLineWidth), new Point(p.X - control.MarkerLineWidth, p.Y + control.MarkerLineWidth));
                        g.DrawLine(pen, new Point(p.X - control.MarkerLineWidth, p.Y + control.MarkerLineWidth), new Point(p.X + control.MarkerLineWidth, p.Y + control.MarkerLineWidth));
                        g.DrawLine(pen, new Point(p.X + control.MarkerLineWidth, p.Y + control.MarkerLineWidth), new Point(p.X + control.MarkerLineWidth, p.Y - control.MarkerLineWidth));

                        break;
                    }
                case GraphMarc.Multiply:
                    {
                        g.DrawLine(pen, new Point(p.X - control.MarkerLineWidth, p.Y - control.MarkerLineWidth), new Point(p.X + control.MarkerLineWidth, p.Y + control.MarkerLineWidth));
                        g.DrawLine(pen, new Point(p.X - control.MarkerLineWidth, p.Y + control.MarkerLineWidth), new Point(p.X + control.MarkerLineWidth, p.Y - control.MarkerLineWidth));
                        g.DrawLine(pen, new Point(p.X - control.MarkerLineWidth, p.Y), new Point(p.X + control.MarkerLineWidth, p.Y));
                        g.DrawLine(pen, new Point(p.X, p.Y - control.MarkerLineWidth), new Point(p.X, p.Y + control.MarkerLineWidth));

                        break;
                    }
                case GraphMarc.Circule:
                    {
                        g.DrawEllipse(pen, new Rectangle(new Point(p.X - control.MarkerLineWidth, p.Y - control.MarkerLineWidth), new Size(control.MarkerLineWidth * 2, control.MarkerLineWidth * 2)));

                        break;
                    }
                case GraphMarc.Diamond:
                    {
                        g.DrawLine(pen, new Point(p.X - control.MarkerLineWidth, p.Y), new Point(p.X, p.Y - control.MarkerLineWidth));
                        g.DrawLine(pen, new Point(p.X, p.Y - control.MarkerLineWidth), new Point(p.X + control.MarkerLineWidth, p.Y));
                        g.DrawLine(pen, new Point(p.X + control.MarkerLineWidth, p.Y), new Point(p.X, p.Y + control.MarkerLineWidth));
                        g.DrawLine(pen, new Point(p.X, p.Y + control.MarkerLineWidth), new Point(p.X - control.MarkerLineWidth, p.Y));

                        break;
                    }
                default:
                    break;
            }

        }
        public int IndexOf(Point p)
        {
            for (int i = 0; i < Count; i++)
                if (this[i].Point == p)
                    return i;
            return -1;
        }
    
        public Point TempPoint { get; set; }
        internal void Draw(Graphics e, UCGraphControl uCGraphControl)
        {
            var c = new Pen(Serie.Color, uCGraphControl.LineWidth);
            c.LineJoin = System.Drawing.Drawing2D.LineJoin.Round;

            c.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            var s = new Pen(Serie.SelectColor, 2);

            Pen p = null;
            var sel = new List<Point>();
          
            for (int i = 0; i < Count; i++)
            {
                SeriePoint p1 = this[i];
                SeriePoint p2 = null;
                Point pt1 = p1.Point;
                Point pt2;
                if (i + 1 < Count)
                    p2 = this[i + 1];
                 if (p1.Selected )

                        DrawPoint(e, p1.Point, s, uCGraphControl);
           
                if (p2 != null)
                {
                    pt2 = p2.Point;
                    if(p2.Selected)
                      DrawPoint(e, p1.Point, s, uCGraphControl);
                    e.DrawLine(c, pt1, pt2);
                }
            }
            if(Count>0 && !Serie.Points.TempPoint.IsEmpty)
  DrawPoint(e, this[Count-1].Point, s, uCGraphControl);
            if (!Serie.Points.TempPoint.IsEmpty)
            {
                if (Count > 0)
                    e.DrawLine(c, this[Count - 1].Point, Serie.Points.TempPoint);
                DrawPoint(e, Serie.Points.TempPoint, s, uCGraphControl);
            }
            //for (int i = 0; i < sel.Count; i++)
            //{
            //    Point p1 = sel[i];
            //    Point? p2 = null;
            //    if (i + 1 < sel.Count)
            //        p2 = sel[i + 1];
            //    if (p2 != null)
            //    {
            //        p = s;

            //        DrawPoint(e, p1, p, uCGraphControl);
            //        DrawPoint(e, (Point)p2, p, uCGraphControl);
            //        e.DrawLine(s, p1, (Point)p2);
            //    }
            //}



            if( uCGraphControl.ManagingSerie==Serie)
            if (uCGraphControl.State == GraphState.WaitingForClick)
            {
                if (p == null)
                    p = new Pen(Color.Black, uCGraphControl.LineWidth);
                if (Count > 0)
                {
                    var pc = uCGraphControl.PointToClient(Cursor.Position);
                    Point src;
                    if (TempPoint.IsEmpty)

                        src = this[Count - 1].Point;
                    else
                    {
                        var i = IndexOf(TempPoint);
                        if (i < Count - 1)
                        {
                            src = this[i + 1].Point;
                            p = new Pen(uCGraphControl.MoveColor, uCGraphControl.LineWidth);
                        }
                        else
                            src = TempPoint;
                    }



                    e.DrawLine(p, src, pc);
                }


            }
            else
                if (uCGraphControl.State == GraphState.ManagingSeriePoints)
                {
                    if (uCGraphControl.ManagingSerie != null)

                        if (Count > 0 && !TempPoint.IsEmpty)
                        {
                            if (p == null)
                                p = new Pen(Color.Black, uCGraphControl.LineWidth);
                            Point p1 = this[Count - 1].Point;
                            Point p2 = TempPoint;
                            DrawPoint(e, p1, p, uCGraphControl);
                            DrawPoint(e, p2, p, uCGraphControl);
                            e.DrawLine(s, p1, p2);
                        }
                }
        }


        internal void ClearSelected()
        {
            foreach (SeriePoint p in this)
                p.Selected = false;
            TempPoint = new Point();
        }
        
        internal SeriePointList Intercept(Point point,bool ejex)
        {
            var r = new SeriePointList(null);
            for (int index = 0; index < this.Count; index++)
            {
                SeriePoint seriePoint = this[index];
                if ((seriePoint.Point.X == point.X && ejex) || (seriePoint.Point.Y == point.Y && !ejex))
                    r.Add(seriePoint);
                if(index+1<this.Count)
                {
                    SeriePoint seriePoint2 = this[index+1];    
                    if(IsInside(seriePoint,seriePoint2,point,ejex))
                    {
                        r.Add(seriePoint);
                        r.Add(seriePoint2);

                    }
        
                }
            }

            return r;
        }

        private bool IsInside(SeriePoint seriePoint, SeriePoint seriePoint2, Point point,bool ejex)
        {
            var p1 = new Point();
            var p2 = new Point();
            if((seriePoint.Point.X<seriePoint2.Point.X && ejex)||(seriePoint.Point.Y<seriePoint2.Point.Y && !ejex))
            {
                p1 = seriePoint.Point;
                p2 = seriePoint2.Point;
            }
            else
            {
                p1 = seriePoint2.Point;
                p2 = seriePoint.Point;
            }

            return (((ejex) && (p1.X <= point.X && p2.X >= point.X)) ||
                    ((!ejex) && (p1.Y <= point.Y && p2.Y >= point.Y)));

        }
    }
}
