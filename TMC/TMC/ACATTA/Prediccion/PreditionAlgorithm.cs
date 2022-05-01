using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using TMC.Components.GraphControl;


namespace TMC.ACATTA.Prediccion
{
    public class PreditionAlgorithm
    {
        public static double IntegralK(double K, double X0, double Xn, bool first)
        {
            var value = 8000;
            var h = (Xn - X0) / value;
            var y = new List<double>();
            var si = 0.0;
            var s2i = 0.0;
            for (int i = 0; i <= value; i++)
            {
                var x = X0 + h * i;
                if (first)
                    y.Add(1 / (Math.Pow(x, (K * (1 - x))) * Math.Pow((1 - x), (K * x))));
                else
                    y.Add(Math.Pow(Math.E, K * x * x) / (Math.Pow(x, (2 * (1 - x) / 3)) * Math.Pow((1 - x), (2 * x / 3))));
            }

            var E = (y[y.Count - 1] + y[0]) / 2;
            for (int i = 1; i <= value - 3; i += 2)
            {
                si = si + y[i];
                s2i = s2i + y[i + 1];
            }

            si = si + y[y.Count - 2];
            var s = (E + 4 * si + 2 * s2i) * h / 3;
            return s;
        }

        private static bool IsValidDB(Dictionary<string, double> Db, bool method)
        {
            var s = Db.ContainsKey("C") && Db.ContainsKey("Mn") && Db.ContainsKey("Ni") && Db.ContainsKey("Cr") &&
                    Db.ContainsKey("Mo");
            if (!method)
                s = s && Db.ContainsKey("Si");
            return s;
        }
        private static bool IsValidTemp(Dictionary<string, double> DB)
        {
            var t = new List<double>();
            if (DB.ContainsKey("Ae3"))
                t.Add(DB["Ae3"]);
            else
                t.Add(DB["Acm"]);
            t.Add(DB["Ae1"]);
            t.Add(DB["Bs"]);
            t.Add(DB["Ms"]);
            //  t.Add(DB["Mf"]);
            double o = double.MaxValue;
            foreach (double c in t)
            {
                if (c > o)
                    return false;

                o = c;
            }
            return true;
        }
        public static double MaxValue(List<CalculatedPoint> ferr, List<CalculatedPoint> bai, List<CalculatedPoint> perl)
        {
            var rf = 0.0;
            var ri = 0.0;

            if (ferr != null)
                foreach (CalculatedPoint calculatedPoint in ferr)
                {
                    if (calculatedPoint.Inicial > ri)
                        ri = calculatedPoint.Inicial;
                    if (calculatedPoint.Final > rf)
                        rf = calculatedPoint.Final;
                }
            if (bai != null)
                foreach (CalculatedPoint calculatedPoint in bai)
                {
                    if (calculatedPoint.Inicial > ri)
                        ri = calculatedPoint.Inicial;
                    if (calculatedPoint.Final > rf)
                        rf = calculatedPoint.Final;
                }
            if (perl != null)
                foreach (CalculatedPoint calculatedPoint in perl)
                {
                    if (calculatedPoint.Inicial > ri)
                        ri = calculatedPoint.Inicial;
                    if (calculatedPoint.Final > rf)
                        rf = calculatedPoint.Final;
                }

            if (ri > rf)
                return ri;
            return rf;
        }
        public static /*GraphicObject*/ PredictSeries Calculate(Dictionary<string, double> DB, bool method, int pasotemp)
        {
            UserAlgorithm algorithm = null;
            if (method)
                algorithm = new KirkaldyAlgorithm();
            else
                algorithm = new LietalAlgorithm();
            var result = new PredictSeries();
            CalculatedPointList ferrita = null;
            CalculatedPointList perlita = null;
            CalculatedPointList bainita = null;
            CalculatedPointList asintota = new CalculatedPointList();
            if (IsValidDB(DB, method) && IsValidTemp(DB))
            {
                //var top = 0.0;


                var c = DB["C"];

                if (c <= 0.25 || (c > 0.25 && c < 0.8))
                    ferrita = algorithm.CalculateFerrita(DB, c <= 0.25, pasotemp);
                if (c > 0.25 && c < 0.8 || c > 0.8)
                {
                    bainita = algorithm.CalculateBainita(DB, pasotemp);
                    perlita = algorithm.CalculatePerlita(DB, pasotemp);
                }


            }
            else
                throw new Exception("Faltan parámetros necesarios");
            result.Add(ferrita);
            result.Add(bainita);
            result.Add(perlita);
            var t = MaxValue(ferrita, bainita, perlita);
            var ac = DB.ContainsKey("Ae3") ? DB["Ae3"] : DB["Acm"];

            if (DB["C"] < 0.8)
            {
                asintota.Add(new CalculatedPoint() { Final = t, Inicial = 0, Temp = ac });
                asintota.Name = DB.ContainsKey("Ae3") ? "Ae3" : "Acm";
                result.Add(asintota);
                asintota = new CalculatedPointList();
            }
            asintota.Add(new CalculatedPoint() { Final = t, Inicial = 0, Temp = DB["Ae1"] });
            asintota.Name = "Ae1";
            result.Add(asintota);
            asintota = new CalculatedPointList();
            if (DB["C"] > 0.25)
            {
                asintota.Add(new CalculatedPoint() { Final = t, Inicial = 0, Temp = DB["Bs"] });
                asintota.Name = "Bs";
                result.Add(asintota);
                asintota = new CalculatedPointList();
                asintota.Add(new CalculatedPoint() { Final = t, Inicial = 0, Temp = DB["Ms"] });
                asintota.Name = "Ms";
                result.Add(asintota);
                asintota = new CalculatedPointList();

            }
            //var max = DB.ContainsKey("Ae3") ? DB["Ae3"] : DB["Acm"];
            //    max += 273;
            //var temp = new Axis(null);
            //temp.Name = "Temperatura";
            //temp.ValueMin = 0;
            //temp.ValueMax = max;
            //temp.RealPointInitial = new Point(20, 20);
            //temp.RealPointFinal = new Point(20,(int) max+20);

            //result.Axiss.Add(temp);
            //var tiempo = new Axis(null);
            //tiempo.Name = "Tiempo";
            //tiempo.Scale = AxisScale.Logaritmic;
            //tiempo.ValueMin = 0;
            //tiempo.ValueMax = MaxValue(ferrita, bainita, perlita);
            //tiempo.RealPointInitial = new Point(20, (int)max + 20);
            //tiempo.RealPointFinal = new Point(10000, (int)max + 20);
            //result.Axiss.Add(tiempo);
            //result.Point = new Point(20, (int)max + 20);
            //if (ferrita != null)
            //{
            //    var seriinicial = new Serie();
            //    var seriefinal = new Serie();
            //    seriinicial.Name = "Ferrita Inicial";
            //    seriefinal.Name = "Ferrita Final";
            //    foreach (CalculatedPoint calculatedPoint in ferrita)
            //    {
            //        int x = tiempo.PointFromValue(calculatedPoint.Inicial).X;
            //        int y = temp.PointFromValue(calculatedPoint.Temp-273).Y;


            //        seriinicial.Points.Add(new SeriePoint(seriinicial.Points,
            //                                              new Point(x, y)));
            //        x = tiempo.PointFromValue(calculatedPoint.Final).X;
            //        seriefinal.Points.Add(new SeriePoint(seriefinal.Points,
            //                                             new Point(x,
            //                                                       y)));

            //    }
            //    result.Series.Add(seriinicial);
            //    result.Series.Add(seriefinal);
            //}
            //if (bainita != null)
            //{
            //    var seriinicial = new Serie();
            //    var seriefinal = new Serie();
            //    seriinicial.Name = "Bainita Inicial";
            //    seriefinal.Name = "Bainita Final";
            //    foreach (CalculatedPoint calculatedPoint in bainita)
            //    {
            //        int x = tiempo.PointFromValue(calculatedPoint.Inicial).X;
            //        int y = temp.PointFromValue(calculatedPoint.Temp).Y;


            //        seriinicial.Points.Add(new SeriePoint(seriinicial.Points,
            //                                              new Point(x, y)));
            //        x = tiempo.PointFromValue(calculatedPoint.Final).X;
            //        seriefinal.Points.Add(new SeriePoint(seriefinal.Points,
            //                                             new Point(x,
            //                                                       y)));

            //    }
            //    result.Series.Add(seriinicial);
            //    result.Series.Add(seriefinal);
            //}
            //if (perlita != null)
            //{
            //    var seriinicial = new Serie();
            //    var seriefinal = new Serie();
            //    seriinicial.Name = "Perlita Inicial";
            //    seriefinal.Name = "Perlita Final";
            //    foreach (CalculatedPoint calculatedPoint in perlita)
            //    {
            //        int x = tiempo.PointFromValue(calculatedPoint.Inicial).X;
            //        int y = temp.PointFromValue(calculatedPoint.Temp).Y;


            //        seriinicial.Points.Add(new SeriePoint(seriinicial.Points,
            //                                              new Point(x, y)));
            //        x = tiempo.PointFromValue(calculatedPoint.Final).X;
            //        seriefinal.Points.Add(new SeriePoint(seriefinal.Points,
            //                                             new Point(x,
            //                                                       y)));

            //    }
            //    result.Series.Add(seriinicial);
            //    result.Series.Add(seriefinal);
            //}
            //  result = new List<List<CalculatedPoint>>();

            result.Add(asintota);
            return result;
        }

        public class CalculatedPoint
        {
            public double Temp { get; set; }
            public double Inicial { get; set; }
            public double Final { get; set; }
        }
        public class CalculatedPointList : List<CalculatedPoint>
        {
            public String Name { get; set; }

            public Dictionary<string, double> GetByTemp(double Temp)
            {
                var res = new Dictionary<string, double>();
                var t = ItemByRange(Temp);
                if (t == null)
                    return null;
                res.Add("Vi", t.Inicial);
                res.Add("Vf", t.Final);

                return res;
            }
            public CalculatedPoint ItemByTemp(double Temp)
            {
                foreach (CalculatedPoint calculatedPoint in this)
                    if (calculatedPoint.Temp == Temp)
                        return calculatedPoint;
                return null;
            }
            public CalculatedPoint ItemByRange(double Temp)
            {
                var t = ItemByTemp(Temp);
                if (t == null)
                {
                    CalculatedPoint max = null;
                    CalculatedPoint min = null;
                    for (int index = 0; index < this.Count; index++)
                    {
                        CalculatedPoint calculatedPoint = this[index];
                        if (calculatedPoint.Temp > Temp)
                            max = calculatedPoint;
                        else
                        {
                            min = calculatedPoint;
                            break;
                        }
                    }
                    if (max != null && min != null)
                    {
                        t = new CalculatedPoint();
                        var m = max.Temp - min.Temp;
                        var mi = Temp - min.Temp;
                        var p = mi / m;

                        t.Temp = Temp;
                        t.Inicial = min.Inicial + p * Math.Abs(max.Inicial - min.Inicial);
                        t.Final = min.Final + p * Math.Abs(max.Final - min.Final);



                    }


                }
                return t;
            }

            public void Order()
            {
                for (int i = 0; i < Count - 1; i++)
                    for (int j = i; j < Count;j++ )
                        if(this[i].Temp>this[j].Temp)
                        {
                            var t = this[i];
                            this[i] = this[j];
                            this[j] = t;
                        }
            }
        }
        public class PredictSeries : List<CalculatedPointList>
        {

            public CalculatedPointList SerieByName(String name)
            {
                CalculatedPointList r = null;

                foreach (CalculatedPointList calculatedPointList in this)
                    if(calculatedPointList!=null)
                    if (calculatedPointList.Name == name)
                        return calculatedPointList;

                return r;
            }

            public double? MinTempTranf()
            {
                var m = double.MaxValue;
                foreach (CalculatedPointList calculatedPointList in this)
                    if (calculatedPointList!=null)
                    foreach (CalculatedPoint calculatedPoint in calculatedPointList)
                        if (calculatedPoint.Temp < m )
                            m = calculatedPoint.Temp;

                if (m == double.MaxValue)
                    return null;
                return m;
            }
            
            internal static PredictSeries FromGraphObject(GraphicObject graphobject)
            {
                var r = new PredictSeries();
                var result = new CalculatedPointList();
                var Tempetura = graphobject.Axiss.ItemsByName("Temperatura");
                var Tiempo = graphobject.Axiss.ItemsByName("Tiempo");
                var t = graphobject.Series.ByName("Ferrita");


                if (t.Count > 1)
                {
                    result.Name = "Ferrita";

                    var list = t.Intercepts(true);

                    if (list.Count == 2)
                    {
                        var i = 0;
                        var inicial = list[0];
                        var final = list[1];
                        while (i < inicial.Points.Count && i < final.Points.Count)
                        {
                            var res = new CalculatedPoint
                                          {
                                              Temp = (double) Tempetura.ValueFromPoint(inicial.Points[i].Point),
                                              Final = (double) Tiempo.ValueFromPoint(final.Points[i].Point),
                                              Inicial = (double) Tiempo.ValueFromPoint(inicial.Points[i].Point)
                                          };
                            if (result.Count>0)
                            {
                                if (result[result.Count - 1].Temp < res.Temp || result[result.Count - 1].Inicial < res.Inicial || result[result.Count - 1].Final < res.Final)
                                    result.Clear();

                            }
                            result.Add(res);
                            i++;
                        }

                    }
                    //result.Order();
                    r.Add(result);
                }
                return r;
            }
        }
        public class UserAlgorithm
        {
            public virtual double TF(Dictionary<string, double> DB, double Xf)
            {
                return 0;
            }
            private double GetNouseBainita(Dictionary<String, double> DB, int pasotemp)
            {
                var bain = CalculateBainita(DB, pasotemp);
                var max = double.MaxValue;
                CalculatedPoint t = null;
                foreach (CalculatedPoint calculatedPoint in bain)
                    if (calculatedPoint.Inicial < max)
                    {
                        t = calculatedPoint;
                        max = calculatedPoint.Inicial;
                    }
                if (t != null) return t.Temp;
                return 0;
            }
            public CalculatedPointList CalculateFerrita(Dictionary<string, double> DB, bool first, int pasotemp)
            {
                var r = new CalculatedPointList();
                var w = 0.0;
                w = DB.ContainsKey("Ae3") ? DB["Ae3"] : DB["Acm"];
                w++;
                if (DB.ContainsKey("Ae3")) DB["Ae3"] = w; else DB["Acm"] = w;
                var end = 0.0;
                if (first)
                    end = DB["Ae1"];
                else
                    end = GetNouseBainita(DB, pasotemp);

                for (int i = (int)w - 1; i > end; i -= pasotemp)
                {
                    DB["Value"] = i;
                    var t = new CalculatedPoint() { Final = TF(DB, 0.99), Inicial = TF(DB, 0.02), Temp = i };
                    r.Add(t);
                }
                DB["Value"] = end;
                var t2 = new CalculatedPoint() { Final = TF(DB, 0.99), Inicial = TF(DB, 0.02), Temp = end };
                r.Add(t2);
                r.Name = "Ferrita";
                w--;
                if (DB.ContainsKey("Ae3")) DB["Ae3"] = w; else DB["Acm"] = w;
                return r;
            }

            public CalculatedPointList CalculatePerlita(Dictionary<string, double> DB, int pasotemp)
            {
                var r = new CalculatedPointList();
                DB["Ae1"]++;
                for (int i = (int)DB["Ae1"] - 1; i > DB["Bs"]; i -= pasotemp)
                {
                    DB["Value"] = i;
                    var t = new CalculatedPoint() { Final = TP(DB, 0.99), Inicial = TP(DB, 0.02), Temp = i };
                    r.Add(t);
                }
                DB["Value"] = DB["Bs"];
                var t2 = new CalculatedPoint() { Final = TP(DB, 0.99), Inicial = TP(DB, 0.02), Temp = DB["Bs"] };
                r.Add(t2);
                r.Name = "Perlita";
                DB["Ae1"]--;
                return r;

            }

            public CalculatedPointList CalculateBainita(Dictionary<string, double> DB, int pasotemp)
            {
                var r = new CalculatedPointList();
                DB["Bs"]++;

                for (int i = (int)DB["Bs"] - 1; i > DB["Ms"]; i -= pasotemp)
                {
                    DB["Value"] = i;
                    var t = new CalculatedPoint() { Final = TB(DB, 0.99), Inicial = TB(DB, 0.02), Temp = i };
                    r.Add(t);
                }
                DB["Value"] = DB["Ms"];
                var t2 = new CalculatedPoint() { Final = TB(DB, 0.99), Inicial = TB(DB, 0.02), Temp = DB["Ms"] };
                r.Add(t2);
                r.Name = "Bainita";
                DB["Bs"]--;
                return r;
            }

            public virtual double TP(Dictionary<string, double> DB, double Xf)
            {
                return 0;
            }

            public virtual double TB(Dictionary<string, double> DB, double Xf)
            {
                return 0;
            }

        }
        public class LietalAlgorithm : UserAlgorithm
        {
            public override double TF(Dictionary<string, double> DB, double Xf)
            {
                var t = DB.ContainsKey("Ae3") ? DB["Ae3"] : DB["Acm"];

                return
                    ((Math.Pow(Math.E,
                               (1.00 + 6.31 * DB["C"] + 1.78 * DB["Mn"] + 0.31 * DB["Si"] + 1.12 * DB["Ni"] + 2.70 * DB["Cr"] +
                                4.06 * DB["Mo"]))) /
                     (Math.Pow(2, 0.41 * DB["G"]) * Math.Pow(t - DB["Value"], 3) *
                      Math.Pow(Math.E, -27500 / (DB["R"] * DB["Value"])))) * IntegralK(0.4, 0.01, Xf, true);

            }


            public override double TP(Dictionary<string, double> DB, double Xf)
            {


                return
                    ((Math.Pow(Math.E,
                               (-4.25 + 4.12 * DB["C"] + 4.36 * DB["Mn"] + 0.44 * DB["Si"] + 1.71 * DB["Ni"] + 3.33 * DB["Cr"] +
                                5.19 * Math.Sqrt(DB["Mo"])))) /
                     (Math.Pow(2, 0.32 * DB["G"]) * Math.Pow(DB["Ae1"] - DB["Value"], 3) *
                      Math.Pow(Math.E, -27500 / (DB["R"] * DB["Value"])))) * IntegralK(0.4, 0.01, Xf, true);
                ;

            }

            public override double TB(Dictionary<string, double> DB, double Xf)
            {
                return
                     ((Math.Pow(Math.E,
                                (-10.23 + 10.18 * DB["C"] + 0.85 * DB["Mn"] + 0.55 * DB["Ni"] + 0.90 * DB["Cr"] + 0.36 * DB["Mo"]))) /
                      (Math.Pow(2, 0.29 * DB["G"]) * Math.Pow(DB["Bs"] - DB["Value"], 2) *
                       Math.Pow(Math.E, -27500 / (DB["R"] * DB["Value"])))) * IntegralK(0.4, 0.01, Xf, true); ;

            }
        }
        public class KirkaldyAlgorithm : UserAlgorithm
        {
            public override double TF(Dictionary<string, double> DB, double Xf)
            {
                var t = DB.ContainsKey("Ae3") ? DB["Ae3"] : DB["Acm"];

                return
                     ((59.6 * DB["Mn"] + 1.74 * DB["Ni"] + 67.7 * DB["Cr"] + 244 * DB["Mo"]) /
                      ((0.3) * Math.Pow(2, ((DB["G"] - 1) / 2)) * (Math.Pow(t - DB["Value"], 3)) *
                       Math.Pow(Math.E, -23500 / (DB["R"] * DB["Value"]))))
                     * IntegralK(0.66, 0.01, Xf, true);


            }
            public override double TP(Dictionary<string, double> DB, double Xf)
            {

                return ((1.79 + 5.42 * (DB["Cr"]) + DB["Mo"] + 4 * DB["Mo"] * DB["Ni"]) /
                        (Math.Pow(2, (DB["G"] - 1) / 2) * Math.Pow(DB["Ae1"] - DB["Value"], 3) * D(DB))) *
                       IntegralK(0.66, 0.01, Xf, true);



            }

            private double D(Dictionary<string, double> DB)
            {

                return 1 /
                       ((1 / (Math.Pow(Math.E, -27500 / (DB["R"] * DB["Value"])))) +
                        ((0.01 * DB["Cr"] + 0.52 * DB["Mo"]) / Math.Pow(Math.E, -37000 / ((DB["R"] * DB["Value"])))));
            }
            private double Cef(Dictionary<string, double> DB)
            {
                return 1.9 * DB["C"] + 2.5 * DB["Mn"] + 0.9 * DB["Ni"] + 1.7 * DB["Cr"] + 4 * DB["Mo"] - 2.6;
            }
            public override double TB(Dictionary<string, double> DB, double Xf)
            {

                return (((2.34 + 10.1 * DB["C"] + 3.8 * DB["Cr"] + 19 * DB["Mo"]) * Math.Pow(10, -4)) /
                        (Math.Pow(2, ((DB["G"] - 1) / 2)) * Math.Pow(DB["Bs"] - DB["Value"], 2) *
                         Math.Pow(Math.E, -27500 / (DB["R"] * DB["Value"])))) * IntegralK(Cef(DB), 0.01, Xf, false);


            }
        }


        public class Properties
        {

            public class PropertiesCalculated
            {
                private CalculatedPointList _points = new CalculatedPointList();
                private Dictionary<string, CalculatedPoint> _ptoinicio= new Dictionary<string, CalculatedPoint>();
                private Dictionary<string, double> _percents =  new Dictionary<string, double>();

                public Dictionary<string, double> Percents {get { return _percents; }}
                public Dictionary<string ,CalculatedPoint> PtoInicio{get { return _ptoinicio; }}
                public CalculatedPointList Points {get { return _points; }}
                public double VelocidadExtraction { get; set; }
                
            }
            public class Dureza
            {
                public static double Martensita(Dictionary<string, double> DB, double Vle)
                {
                    return 127 + 949 * DB["C"] + 27 * DB["Si"] + 11 * DB["Mn"] + 8 * DB["Ni"] + 16 * DB["Cr"] +
                           21 * Math.Log10(Vle * 60 * 60);
                }
                public static double Bainita(Dictionary<string, double> DB, double Vle)
                {
                    var a = 89 + 53 * DB["C"] - 55 * DB["Si"] - 22 * DB["Mn"] - 10 * DB["Ni"] - 20 * DB["Cr"];
                    if (a < 0)
                        return 0;

                    return -323 + 185 * DB["C"] + 330 * DB["Si"] + 153 * DB["Mn"] + 65 * DB["Ni"] + 144 * DB["Cr"] +
                           191 * DB["Mo"] * Math.Log10(Vle * 60 * 60 * a);
                }
                public static double Ferrita_Perlita(Dictionary<string, double> DB, double Vle)
                {
                    var a = 10 - 19*DB["Si"] + 4*DB["Ni"] + 8*DB["Cr"] + 130*DB["Mo"];
                    if (a < 0)
                        return 0;

                    return 42 + 223 * DB["C"] + 53 * DB["Si"] + 30 * DB["Mn"] + 12.6 * DB["Ni"] + 7 * DB["Cr"] +
                     19*DB["Mo"]+ Math.Log10(Vle * 60 * 60*a);
                }
                public static double Final(Dictionary<string ,double >DB,double Vle)
                {

                    var Hvfp=/*(serie.Percents["Ferrita"] + serie.Percents["Perlita"])**/Ferrita_Perlita(DB,Vle);
                    var Hvb =/* serie.Percents["Bainita"]**/Bainita(DB, Vle);
                    var Hvm = /*serie.Percents["Martensita"]**/Martensita(DB, Vle);
                    return Hvfp + Hvb + Hvm;
                }
                public static double RokwellC(double Hv)
                {
                    return 31.49 + 7.96683*Math.Pow(10, -2)*Hv - 3.55432*Math.Pow(10, -5)*Math.Pow(Hv, 2) -
                           6.72816*Math.Pow(10, 3)*Math.Pow(Hv, -1);
                }
            }
          

            public static double F_Martensita(Dictionary<string, double> Percents, Dictionary<String, double> DB, double T)
            {
                var a = Percents["Ferrita"] + Percents["Perlita"] + Percents["Bainita"];

                return (1 - a) * Math.Pow(Math.E, -0.011 * (DB["Ms"] - T));
            }
            public static double Di(double fi, double b, double n)
            {
                return Math.Pow(Math.Abs((Math.Log(1 - fi) / b)), 1 / n);
            }
            public static double F_Transformada(Dictionary<string, double> tiempos, double dt, Dictionary<string, double> Percents, string valor)
            {
                var n = Math.Log((Math.Log(1 - 0.01)) / (Math.Log(1 - 0.99))) / (Math.Log(tiempos["Vi"] / tiempos["Vf"]));
                var b = -(Math.Log(1 - 0.01) / Math.Pow(tiempos["Vi"], n));
                return 1 - Math.Pow(Math.E, -b * Math.Pow(dt, n));
                //return 1 - Math.Pow(Math.E, -b * Math.Pow(Di(Percents[valor], b, n) + dt, n));
            }

            private static void UpdateDictionary(string name, double valor, Dictionary<string, double> DB)
            {
                if (DB.ContainsKey(name))
                {
                    if (DB[name]<valor)
                        DB[name] = valor;
                }
                else
                    DB.Add(name, valor);
            }
            private static Dictionary<String, double> GetTemp(CalculatedPointList s, double T)
            {
                return s != null ? s.GetByTemp(T) : null;
            }

            

            // ********************* OSMEL **********************************
            // funcion para retornar la presencia a una temperatura de una microestructura
            private static bool VerificaMicroestructura(PredictSeries series, double Temp, string microestruct)
            {
                var t = series.SerieByName(microestruct);
                if(t!=null)
                       return t.ItemByRange(Temp) != null;
                return false;
            }
          public static PropertiesCalculated  PredictionFraccion(PredictSeries series, Dictionary<String, double> DB, double te, double dt, double mf, double To, double retTiempo, double Vle,bool check=false)
          {
              var result = new PropertiesCalculated();
                UpdateDictionary("Ferrita", 0, result.Percents);
                UpdateDictionary("Perlita", 0, result.Percents);
                UpdateDictionary("Bainita", 0, result.Percents);
                UpdateDictionary("Martensita", 0, result.Percents);
              var w = new Dictionary<double,double>();
              var b = false;
                result.Points.Name = "Curva enfriamiento ("+Vle+")";
                var t = retTiempo; 
                var TFin = series.MinTempTranf();

            Inicio:
                //var T = To - dt * Vle;
                t += dt;
                var T = To - t * Vle;
                
              b = false;
                
            if(check )
                TFin = DB["Ms"];
                if (T >=TFin)

                {
                    // verificar microestructuras presentes
                    if (VerificaMicroestructura(series,T,"Bainita"))
                    {
                        // verifica tiempo de la tranformacion bainitica
                        var ti = GetTemp(series.SerieByName("Bainita"), T);
                        if (ti != null)
                        if (t / ti["Vi"] >= 1)
                        {
                            b = true;
                            // calcular fraccion
                            var s = F_Transformada(ti, t, result.Percents, "Bainita");
                            UpdateDictionary("Bainita", s, result.Percents);
                            var cp = new CalculatedPoint() {Final = 0, Inicial = t, Temp = T};
                            result.Points.Add(cp);
                            if (!result.PtoInicio.ContainsKey("Bainita"))
                                result.PtoInicio.Add("Bainita", cp);
                            w.Add(T,s);
                            // sigue el ciclo

                        }

                    } else
                    if (VerificaMicroestructura(series,T,"Perlita"))
                    {
                        // verifica tiempo de la tranformacion perlitica
                        var ti = GetTemp(series.SerieByName("Perlita"), T);
                        if (ti != null)
                            if (t / ti["Vi"] >= 1)
                            {
                                b = true;
                                // calcular fraccion
                                var s = F_Transformada(ti, t, result.Percents, "Perlita");
                                UpdateDictionary("Perlita", s, result.Percents);
                                var cp = new CalculatedPoint() { Final = 0, Inicial = t, Temp = T };
                                result.Points.Add(cp);
                                if (!result.PtoInicio.ContainsKey("Perlita"))
                                    result.PtoInicio.Add("Perlita", cp);
                                w.Add(T,s);
                                // sigue el ciclo
                            
                            }
                    } else
                    if (VerificaMicroestructura(series,T,"Ferrita") == true)
                    {
                        // verifica tiempo de la tranformacion Ferrita
                        var ti = GetTemp(series.SerieByName("Ferrita"), T);
                        if (ti != null)
                            if (t / ti["Vi"] >= 1)
                            {
                                b = true;
                                // calcular fraccion
                                var s = F_Transformada(ti, t, result.Percents, "Ferrita");
                                UpdateDictionary("Ferrita", s, result.Percents);
                                var cp = new CalculatedPoint() { Final = 0, Inicial = t, Temp = T };
                                result.Points.Add(cp);
                                if (!result.PtoInicio.ContainsKey("Ferrita"))
                                    result.PtoInicio.Add("Ferrita", cp);
                                w.Add(T,s);
                                // sigue el ciclo
                            
                            }
                    }
                    // sigue el ciclo
                    if(!b)
                    { var cp2 = new CalculatedPoint() { Final = 0, Inicial = t, Temp = T };
                    result.Points.Add(cp2);
                    }
                    //To = T;
                    goto Inicio;
                }

             

                //// normalizar las fracciones transformadas
                for (int i = 0; i < 4; i++)
                    Normalize(result.Percents, i, DB);
                UpdateDictionary("Martensita", F_Martensita(result.Percents, DB, mf), result.Percents);
              result.VelocidadExtraction = Vle;
                return result;

             
            }

            public static Dictionary<string, double> Ferritico(PredictSeries series, Dictionary<String, double> DB, double te, double dt, double mf, double To, double retTiempo, double Vle, out CalculatedPointList ser)
            {
                var res = new Dictionary<string, double>();
                UpdateDictionary("Ferrita", 0, res);
                UpdateDictionary("Martensita", 0, res);
                ser = new CalculatedPointList();
                ser.Name = "Curva enfriamiento";
                var t = 0.0;
                Inicio:
                var T = To - dt*Vle;
                 t += dt;
                if( T<=DB["Ae3"] && T>=DB["Ae1"])
                {
                var ti =  GetTemp(series.SerieByName("Ferrita"), T);
                    if(ti!=null)
                    if(t/ti["Vi"]>=1)
                    {
                        //if (T==735)
                        //{
                        //    T = T;
                        //}
                        var s = F_Transformada(ti, t, res, "Ferrita");
                        UpdateDictionary("Ferrita",s , res);
                        ser.Add(new CalculatedPoint() { Final = 0, Inicial = t, Temp = T });
                    }
                 
                        To = T;
                        goto Inicio;
                }
                else if (T < DB["Ae1"]) //(T < DB["Ms"])
                    UpdateDictionary("Martensita", F_Martensita(res, DB, T), res);
                else
                {
                    ser.Add(new CalculatedPoint() { Final = 0, Inicial = t, Temp = T });
                    To = T;
                    goto Inicio;
                }
                //for (  int i = 0; i < res.Keys.Count; i++)
                //    Normalize(res, i);
                return res;
            }

            public static Dictionary<string, double> Predict(PredictSeries series, Dictionary<String, double> DB, double te, double dt, double mf, double To, double retTiempo, double Vle, out CalculatedPointList ser)
            {
                var res = new Dictionary<string, double>();
                var Tc = To;
                var tb = 0.0;
                var tp = 0.0;
                var tf = 0.0;
                UpdateDictionary("Ferrita", 0, res);
                UpdateDictionary("Perlita", 0, res);
                UpdateDictionary("Bainita", 0, res);
                UpdateDictionary("Martensita", 0, res);
                ser = new CalculatedPointList();
                ser.Name = "Transofmada";
                for (var i = (int)To; i > mf; i--)
                {

                    var T = Tc - dt * Vle;
                    tb += dt;
                    tf += dt;
                    tp += dt;
                    if (T > te)
                     {
                        if (T > DB["Ms"])
                        {
                            if (T > DB["Bs"])
                            {
                                if (T > DB["Ae1"])
                                {

                                    if (T > (DB.ContainsKey("Ae3")?DB["Ae3"]:DB["Acm"]))
                                    {
                                        ser.Add(new CalculatedPoint() { Final = 0, Inicial = tf, Temp = T });
                                    }
                                    else
                                    {
                                        var t = GetTemp(series.SerieByName("Ferrita"),T);
                                        if (t != null)
                                            if (tf / t["Vi"] >= 1)
                                            {
                                                UpdateDictionary("Ferrita", F_Transformada(t, dt, res, "Ferrita"), res);
                                                ser.Add(new CalculatedPoint(){Final = 0,Inicial = tf,Temp =T});
                                            }
                                        ser.Add(new CalculatedPoint() { Final = 0, Inicial = tf, Temp = T });
                                    }

                                }
                                else
                                {
                                    var t = GetTemp(series.SerieByName("Perlita"), T);
                                    if (t != null)
                                        if (tp / t["Vi"] >= 1){
                                            UpdateDictionary("Perlita", F_Transformada(t, dt, res, "Perlita"), res);
                                                   ser.Add(new CalculatedPoint(){Final = 0,Inicial = tp,Temp =T});
                                            }
                                        else
                                        {
                                            t = GetTemp(series.SerieByName("Ferrita"), T);
                                            if (t != null)
                                                if (tf / t["Vi"] >= 1)
                                                {    UpdateDictionary("Ferrita", F_Transformada(t, dt, res, "Ferrita"),
                                                                     res);
                                                   ser.Add(new CalculatedPoint(){Final = 0,Inicial = tf,Temp =T});
                                            }
                                            ser.Add(new CalculatedPoint() { Final = 0, Inicial = tf, Temp = T });
                                        }
                                }
                            }
                            else
                            {
                                var t = GetTemp(series.SerieByName("Bainita"), T);
                                if (t != null)
                                    if (tb / t["Vi"] >= 1){
                                        UpdateDictionary("Bainita", F_Transformada(t, dt, res, "Bainita"), res);
                                               ser.Add(new CalculatedPoint(){Final = 0,Inicial = tb,Temp =T});
                                            }
                                    else
                                    {
                                        t = GetTemp(series.SerieByName("Perlita"), T);
                                        if (t != null)
                                            if (tp / t["Vi"] >= 1){
                                                UpdateDictionary("Perlita", F_Transformada(t, dt, res, "Perlita"), res);
                                                       ser.Add(new CalculatedPoint(){Final = 0,Inicial = tp,Temp =T});
                                            }
                                            else
                                            {
                                                t = GetTemp(series.SerieByName("Ferrita"), T);
                                                if (t != null)
                                                    if (tf / t["Vi"] >= 1){
                                                        UpdateDictionary("Ferrita",
                                                                         F_Transformada(t, dt, res, "Ferrita"), res);
                                                       ser.Add(new CalculatedPoint(){Final = 0,Inicial = tf,Temp =T});
                                            }
                                                ser.Add(new CalculatedPoint() { Final = 0, Inicial = tf, Temp = T });
                                            }

                                    }
                            }
                        }
                        else
                        {
                            UpdateDictionary("Martensita", F_Martensita(res, DB, T), res);
                            //ser.Add(new CalculatedPoint() { Final = 0, Inicial = tf, Temp = T });
                            break;
                        }
                    }
                    else
                        break;

                    Tc = T;

                }
                for (int i = 0; i < 4; i++)
                    Normalize(res, i,DB);

                return res;
            }

            public static void Normalize(Dictionary<string, double> res, int i,Dictionary<string ,double > DB)
            {
                if (i == 0)
                {
                    // DB["C"] --> sustituir por el %Carbono
                    var a = (0.83 - DB["C"]) / (0.83 - 0.02);
                    if (res["Ferrita"] > a)
                        res["Ferrita"] = a;
                }
                var r = 0.0;
                var t = 0;
                foreach (string key in res.Keys)
                {
                    r += res[key];
                    if (t < i)
                        t++;
                    else
                        break;

                }

                if (i > 0)
                {
                    var arr = res.Keys.ToArray();
                    res[arr[i]] = res[arr[i]] / (1 - r);
                }

            }
        }
    }

}
