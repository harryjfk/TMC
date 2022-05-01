using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace TMC.Components.TemperatureControl
{
 

    public partial class UCTemperatureControl : UCSelectableControl
    {
        public delegate void MoverMoved(TemperatureItem item);

        protected  TemperatureItemList _templist ;
        public UCTemperatureControl()
        {
            InitializeComponent();
            _templist = new TemperatureItemList(this);
            SetStyle(ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }
        public TemperatureItemList TempList { get { return _templist; } }

        
        private void UCTemperatureControl_Paint(object sender, PaintEventArgs e)
        {
            foreach (var t  in TempList)
             t.Paint(e.Graphics);
            foreach (TemperatureItem temperatureItem in TempList)
                if (temperatureItem.Selected)
                    temperatureItem.Paint(e.Graphics);
        }

        protected bool Moving = false;

        protected virtual void HandleMover(MouseEventArgs e)
        {
            var t = TempList.Selected;
            if (t != null)
                if (t.MoverRectangle.Contains(e.Location) || Moving)
                {
                    Cursor.Current = Cursors.VSplit;
                    if (e.Button == MouseButtons.Left)
                    {
                        var k = 0;
                        var p = 0;
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
                        //if (TempList.IndexOf(t) != TempList.Count - 1)
                        t.EndValue = (int) Math.Round(ACINOX.Functions.Math.Percent.Part(TempList.EndValue, w));
                        //else


                        var q = ACINOX.Functions.Math.Percent.Part(TempList.EndValue, w);
                        Invalidate(true);
                        //if(k<0)
                        //{
                        //Application.OpenForms[0].Text = k.ToString();
                        //}
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
            //Application.OpenForms[0].Text = e.Location.ToString();

        }

        private void UCTemperatureControl_MouseMove(object sender, MouseEventArgs e)
        {
            var t = TempList.HasPoint(e.Location);
            foreach (TemperatureItem temperatureItem in TempList)
                temperatureItem.Hovered = false;
            if (t != null)
                t.Hovered = true;
            Invalidate();
           HandleMover(e);
            
        }

        private void UCTemperatureControl_Click(object sender, EventArgs e)
        {

        }

        private void UCTemperatureControl_MouseDown(object sender, MouseEventArgs e)
        {
            var t = TempList.HasPoint(e.Location);
            foreach (TemperatureItem temperatureItem in TempList)
                temperatureItem.Selected = false;
            if (t != null)
                t.Selected = true;
        //    HandleMover(e);
            Invalidate();
        }
        protected virtual void MouseUpEv()
        {
            Moving = false;
            DoSelectedResize(TempList.Selected);

        }
        public void UCTemperatureControl_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUpEv();
        }

        internal int ChangeSide;
        public void UCTemperatureControl_KeyDown(object sender, KeyEventArgs e)
        {
           ChangeSide = 0;
            var s = 0;
            if (e.KeyCode == Keys.Left)
                if (e.Control)
                    ChangeSide = -2;
                else
                    s = -1;
            else
                if (e.KeyCode == Keys.Right)
                    if (e.Control)
                        ChangeSide = 2;
                    else
                        s = 1;

            if (TempList.Selected != null)
            {
                if(e.Control)
                {
                    Moving = true;
                TempList.Selected.EndValue += ChangeSide;
                    MouseUpEv();
                    Moving = false;
                }
                else
                {
                    var t = TempList.IndexOf(TempList.Selected);
                    if(t+s>=0)
                    {
                    TempList.Selected.Selected = false;
                        var q = t + s;
                        if (q > TempList.Count)
                            q = TempList.Count-1;
                    TempList[q].Selected = true;
                    }
                }
                Invalidate();
            }
                
        }
    }

  [Serializable]
    public class TemperatureItem:SelectableObject
    {
        private readonly TemperatureItemList _list;
        public Color BeginColor { get; set; }
        public int BeginValue { get; set; }
        public Color EndColor { get; set; }
        public TemperatureItem(UCSelectableControl control):base(control){}
        public virtual int EndValue { get { return _endvalue; } set { _endvalue = value;
            if(value==0)
                return;
            var i = List.IndexOf(this);
            if(i!=-1)
            if (i == List.Count - 1)

                List.Control.TempList.EndValue = value;
            else
                List[i + 1].BeginValue = value;
        } }
        public Color MiddleColor { get; set; }
        public TemperatureItem(UCSelectableControl control,TemperatureItemList list):base(control)
        {
            _list = list;
        }
        public int Width()
        {
            return EndValue - BeginValue;
        }

        protected Control c;
        protected int _endvalue;

        public virtual Control GetInformation()
        {
            if (c == null)
                c = new Label();
            c.Text = GetInformationText();
                          
            return c;
        }
         private Control GetControl()
         {
             var t = GetInformation();
             if (t.Parent != List.Control)
                 t.Parent = List.Control;
             return t;
         }
        public virtual Rectangle GetInformationRect()
        {
            var result = new Rectangle
                             {
                                 X = PrevWidth() + (WidthPixels()/2) - (List.DefaultInformationSize().Width/2),
                                 Y = List.GetHeight() + List.IndexOf(this)*List.DefaultInformationSize().Height+1,
                                 Size = List.DefaultInformationSize()
                             };
            return result;
        }
        public virtual String GetInformationText()
        {
            return BeginValue+"->"+EndValue;
        }
        public TemperatureItemList List {get { return _list; }}

        private int PrevWidth()
        {
            var r = 0;
            foreach (var temperatureItem in List)
                if (temperatureItem == this)
                    break;
                else
                    r += temperatureItem.WidthPixels();
            return r;
        }
        public virtual Rectangle Rectangle
        {
            get
            {
                return new Rectangle(PrevWidth(), 0, WidthPixels(), List.GetHeight());
            }
        }
        private double ValuePercent()
        {
            return Math.Round(ACINOX.Functions.Math.Percent.Percen(List.Control.TempList.StartValue + List.Control.TempList.EndValue, Width()));
        }
        public int WidthPixels()
        {
           return (int)(ACINOX.Functions.Math.Percent.Part(List.Control.Width, ValuePercent()));
        }
        private void PaintMover(Graphics g)
        {
            //var wv = WidthPixels();
            g.FillRectangle(new SolidBrush(Color.Black),MoverRectangle);
        }
        public virtual Rectangle MoverRectangle
        {
            get { return new Rectangle(PrevWidth() + WidthPixels() - 5, 0, 5, List.GetHeight()); }
        }
        private int PaintDegradee(Graphics g)
        {

            var wv = WidthPixels();

            try
            {
                var bBackground
               = new LinearGradientBrush(Rectangle, BeginColor, EndColor, 0.0);

                var colorBlend = new ColorBlend
                {
                    Colors = new[]
                                                  {
                                                      BeginColor,
                                                      MiddleColor,
                                                      MiddleColor,
                                                      MiddleColor,
                                                      MiddleColor,
                                                      MiddleColor,
                                                      EndColor,
                                                  },
                    Positions = new[]
                                                     {
                                                         0f, 3/6f, 3/6f, 3/6f, 3/6f, 3/6f, 1f
                                                     }
                };
                bBackground.InterpolationColors = colorBlend;
                g.FillRectangle(bBackground, Rectangle);
                bBackground.Dispose();
            }
            catch (Exception)
            {
                
                //throw;
            }
           
            return wv;
        }

        internal void PaintRectangle(Graphics g, Color color)
        {
            try
            {
                g.DrawRectangle(new Pen(color), Rectangle);
            }
            catch
            { }
        }
        private void PaintInfo()
        {
            if(GetInformation()!=null)
            {
                var t = GetInformationRect();
                GetControl().SetBounds(t.X,t.Y,t.Width,t.Height);
            }
                
               
        }
        public virtual int  Paint(Graphics g)
        {

            var w = PaintDegradee(g);

            if (Selected)
            {
                PaintRectangle(g, SelectColor);
                PaintMover(g);
            }
            else
                if (Hovered)
                    PaintRectangle(g, HoverColor);

            PaintInfo();
            return w;
        }

        public int PrevEndValue { get
        {
            var r = 0;
            foreach (TemperatureItem temperatureItem in List)
                if (temperatureItem == this)
                    break;
                else
                    r += temperatureItem.EndValue;

            return r;
        }}
    }
    [Serializable]
    public class TemperatureItemList : List<TemperatureItem>
    {
        public virtual int EndValue { get; set; }
        public int StartValue { get; set; }
        public virtual Size DefaultInformationSize()
        {
            return new Size(50, 25);
        }
        public int GetHeight()
        {
            var hl = DefaultInformationSize().Height;
            return Control.Height - (Count*hl)-5;
        }

        [NonSerialized]
        protected readonly UCTemperatureControl _control;
        public TemperatureItemList(UCTemperatureControl c)
        {
            _control = c;
        }
        public  TemperatureItem HasPoint(Point p)
        {
         
            return this.FirstOrDefault(t => t.Rectangle.Contains(p));
        }
     
        public UCTemperatureControl Control { get { return _control; } }

        public TemperatureItem Selected
        {
            get { return this.FirstOrDefault(t => t.Selected); }
            set {  }
        }
    }
}

