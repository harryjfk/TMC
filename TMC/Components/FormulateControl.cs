using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NCalc;

namespace TMC.Components
{
    public partial class FormulateControl : DevExpress.XtraEditors.XtraScrollableControl
    {
        private List<Ecuation> _ecuations = new List<Ecuation>();
        public Color FontColor { get; set; }
        public FormulateControl()
        {
            
            InitializeComponent();
            Paint += new PaintEventHandler(FormulateControl_Paint);
        }

        void FormulateControl_Paint(object sender, PaintEventArgs e)
        {
            var p = new Point(0, 0);
    foreach (Ecuation ecuation in Ecuations)
            {
                var graph = ecuation.GetGraphic(Font, FontColor);
                e.Graphics.DrawImage(graph,p);
                p.Y+= graph.Height+Separator;
            }

         
        }
        public List<Ecuation> Ecuations { get { return _ecuations; } }
        public int Separator { get; set; }
    }


    public class Parameter
    {

        public Parameter(string t, float? value)
        {
            Text = t;
            Value = value;
        }

        public String Text { get; set; }
        
        public virtual string GetCalculatedValue(bool real = false)
        {
            if (Value == null)

                return Text.Replace(',', '.');
            return ((double)Value).ToString().Replace(',', '.');
        }
        public float? Value { get; set; }
        public String Operation { get; set; }

        public static bool IsBreak(char ch)
        {
            return ch == '+' || ch == '/' || ch == '*' || ch == '-' || ch == '^' || ch == '√' || ch=='@';
        }
        private static int GetEndOfToken(string str, int pos)
        {
            int token = 0;
            for (int i = pos; i < str.Length; i++)
            {
                if (str[i] == '(')
                    token++;
                else
                    if (str[i] == ')')
                        token--;
                if (token == 0)
                    return i;

            }
            return -1;
        }
        public static ParameterList ParseParamters(string str)
        {
            var res = new ParameterList();
            string t = "";
            string tempc = "";
            int i = 0;
            while (i < str.Length)
            {
                var c = str[i];
                if (c == '(')
                {
                    var end = GetEndOfToken(str, i);
                    if (end != -1)
                    {
                        t = str.Substring(i + 1, end - i - 1);

                        res.Add(new ComplexParameter(t, null));
                        if (tempc != "")
                        {
                            res[res.Count - 1].Operation = tempc;
                            tempc = "";
                        }
                        t = "";
                        i = end;
                    }

                }
                else
                    if (IsBreak(c))
                    {
                        if (t != "")
                            res.Add(new Parameter(t, null));

                        //     else
                        if (res.Count > 0 || tempc!="")
                        {
                            if(tempc=="")
                                tempc = c.ToString();
                            res[res.Count - 1].Operation =tempc ;
                            tempc = "";
                        }
                        else
                            tempc = c.ToString();
                        t = "";
                    }

                    else
                    {
                        t += c;
                    }

                i++;
            }
            if (t != "")
            {
                res.Add(new Parameter(t, null));
                res[res.Count - 1].Operation = tempc;
            }



            return res;
        }

     
       

        public virtual Size GetSize(Font f)
        {
                   var v = GetCalculatedValue();
            if (Operation != "/")
                v += Operation;
            return ACINOX.Functions.Image. GetTextSize(v, f);
        }
        public virtual Bitmap GetGraphic(Font f, Color c)
        {
                var s = GetCalculatedValue();
            if (Operation != "/")
                s += Operation;
            return ACINOX.Functions.Image.GetTextAsGraphic(s, f, c);
        }

    }
    public class ParameterList : List<Parameter>
    {

        public String AsString()
        {
            var s = "";
            foreach (Parameter item in this)
                s += item.GetCalculatedValue() + item.Operation;
            return s;
        }
        public String AsCalculableString()
        {
            var s = "";
            Parameter ant = null;
            foreach (Parameter item in this)
            {
                var v= item.GetCalculatedValue(true);
                if (item.Operation == "^")
                {
                    ant = item;

                }
                else
                    if (item.Operation == "√")
                    {
                        s += "Sqrt(" + item.GetCalculatedValue(true) + ")";

                    }
                    else
                    {
                        if (ant != null)
                        {
                            s += "Pow(" + ant.GetCalculatedValue(true) + "," + item.GetCalculatedValue(true) + ")"; 
                            ant = null;
                        }
                        else

                            s += v+ item.Operation;
                    }

            }
              
            return s;
        }
        public double AsDouble()
        {
            try
            {
                return (double)new Expression(AsCalculableString()).Evaluate();
            }
            catch
            {
                return 0; 
            }

         
        }
        public int CountString(String str, char c)
        {
            var i = 0;
            foreach (char item in str)
                if (item == c)
                    i++;
            return i;
        }
 

        public Size GetSize(Font f)
        { 
            var op = "";
         
           var r = new Size(0, 0);
            foreach (Parameter item in this)
            {
                var s = item.GetSize(f);
                if (item.Operation == "@")

                    r.Width += ACINOX.Functions.Image.GetTextSize("arcocos(", f).Width + s.Width +
                                        ACINOX.Functions.Image.GetTextSize(")", f).Width;
                if (r.IsEmpty)            
                    r = s;
                if (r.Height == 0)
                    r.Height = s.Height;

                if (op != "" )
                {
                    if (op == "/" )
                        r.Height += s.Height;
                    if(item.Operation != "@")
             r.Width +=s.Width;
                
                }

                op = item.Operation;
              

            }
            return r;
        }
        public Bitmap GetGraphic(Font f,Color c)
        {
            var size = GetSize(f);
            var res = new Bitmap(size.Width, size.Height);
            var g = Graphics.FromImage(res);
            var p = new Point(0, 0);
            var pen = new Pen(c);
            var mx = 0;
            foreach (Parameter parameter in this)
            {
                var t = parameter.GetSize(f);
                if (mx < t.Width)
                    mx = t.Width;
            }
            foreach (Parameter item in this)
            {
                var graph = item.GetGraphic(f,c);
                if (item.Operation=="@")
                {
                    var t = ACINOX.Functions.Image.GetTextAsGraphic("arcocos(", f, c);
                    
                    g.DrawImage(t,p);
                    p.X += t.Width;
                    g.DrawImage(graph, new Rectangle(p.X,p.Y,graph.Width,graph.Height));
                    p.X += graph.Width;
                    t = ACINOX.Functions.Image.GetTextAsGraphic(")", f, c);
                     g.DrawImage(t, new Rectangle(p.X,p.Y,t.Width,t.Height));
                    p.X += t.Width;
                }
                else
                {
                    
                
                g.DrawImage(graph,p);
                if (item.Operation == "/")
                {
                    //mx / 2 - graph.Width /2
                    p.Y += graph.Height;
                    g.DrawLine(pen,new Point(0, graph.Height+2), new Point(mx,graph.Height+2));
                }
                else
                    p.X += graph.Width ;
                }
            }

            return res;
        
        }

    }
    /*Public Function InterpolaMen(x As Single, X0 As Single, X1 As Single, Y0 As Single, Y1 As Single) As Single
  
  InterpolaMen = Y0 + (((Y1 - Y0) / (X1 - X0)) * (x - X0))
  
End Function
*/
    public class ComplexParameter : Parameter
    {
        private readonly ParameterList _param;

        public ComplexParameter(string t, float? value)
            : base(t, value)
        {
            _param = Parameter.ParseParamters(t);
        }

        public override string GetCalculatedValue(bool real = false)
        {
            var s = "";
            if (real)
                s = _param.AsCalculableString();
            else
             s = _param.AsString();
            return "(" + s + ")";

        }
        public override Bitmap GetGraphic(Font f,Color c)
        {
            return Parametres.GetGraphic(f,c);
        }
        public override Size GetSize(Font f)
        {
            return Parametres.GetSize(f);
        }
     
        public ParameterList Parametres { get { return _param; } }
    }
    public class EcuationSide
    {
        private ParameterList param;
        public EcuationSide(string str)
        {
            param = Parameter.ParseParamters(str);
        }

        public ParameterList Parameters { get { return param; } }



    }

    public class Ecuation
    {
         EcuationSide _left = null;
         EcuationSide _right = null;
        private bool IsSideToken(char chr)
        {
            return chr == '=' || chr == '<' || chr == '>';
        }


        public String UnitM { get; set; }
        private void Parse(String str, String UM = "")
        {
            var t = "";
            foreach (char c in str)
            {
                if (IsSideToken(c))
                {
                    Sign = c.ToString();
                    if (LeftSide == null)
                        _left = new EcuationSide(t);

                    t = "";
                }
                else
                    t += c;
            }
            if (t != "")
            {
                _right = new EcuationSide(t);


            }
            UnitM = UM;
        }
        public Ecuation(String str, String UM = "",Dictionary<String, String> Datos =null)
        {
            var s = str;
            if (Datos != null)
                foreach (var k in Datos)
                    s = s.Replace(k.Key, k.Value);
            Parse(s, UM);
       

        }
  
        
        public Bitmap GetGraphic(Font f,Color c)
        {
            var lb = LeftSide.Parameters.GetGraphic(f, c);
            var rb = RightSide.Parameters.GetGraphic(f, c);
            var sb = ACINOX.Functions.Image.GetTextAsGraphic(Sign, f, c);
            var lsb = new List<Bitmap>();
            lsb.Add(lb);
            lsb.Add(sb);
            lsb.Add(rb);
        
            var size =new Size(0,0);
            foreach (Bitmap item in lsb)
            {
                size.Width += item.Width;
                if (size.Height < item.Height)
                    size.Height = item.Height;
            }
            var x =0;
            var result = new Bitmap(size.Width, size.Height);
            var g = Graphics.FromImage(result);
            foreach (Bitmap item in lsb)
            {
                g.DrawImage(item, new Point(x,0));
                x += item.Width;
            }
            g.DrawString(UnitM,f,Brushes.Black, new Point(x,0));
            return result;
        }

        public EcuationSide LeftSide { get { return _left; } }
        public EcuationSide RightSide { get { return _right; } }
        public String Sign { get; set; }

    }


}
