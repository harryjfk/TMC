using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace TMC.Components.GraphControl
{
    [Serializable]
    public class GraphPoint : SelectableObject
    {
       public GraphPoint(Point p)
       { Point = p; }
       public Point Point { get; set; }
    }
}
