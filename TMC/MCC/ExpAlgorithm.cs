using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace TMC.MCC
{
    public class ExplorationAlgorithm
    {

        public static int CantLineasNeeded(int tf)
        {
            return (int)((7800/(tf*0.00321699*2.75*7600)) + 1);
      
        }
        public static int Qcaz(int tf,int densidad)
        {
            return (int) (((0.63*densidad*Math.Sqrt(Math.PI)*Math.Pow(0.06, 2))/(4*2.4))*Math.Sqrt((2*9.8))*tf * 60);
        }
        public static int Qsal(int n,int largo,int densidad,int vc,int tf)
        {
            return n*largo*densidad*vc*tf;
        }
        public class Variable : IEquatable<Variable>
        {
            private List<double> _td = new List<double>();
            public List<double> td { get { return _td; } }

            private List<double> _tsup = new List<double>();
            public List<double> tsup { get { return _tsup; } }

            private List<double> _tinf = new List<double>();
            public List<double> tinf { get { return _tinf; } }

            private List<double> _II = new List<double>();
            public List<double> II { get { return _II; } }
            public double fo { get; set; }
            public double deltah { get; set; }
            public double deltat { get; set; }
            private void Init(double tf)
            {
                deltat = tf * 0.8 / 3;

                fo = 0;

            }
            public String IterationsAsString()
            {
                var s = "";
                for (int i = 0; i < II.Count; i++)
                    s += II[i];
                return s;
            }
            public Variable()
            { }
            public static bool operator ==(Variable c1, Variable c2)
            {
                return c1.fo == c2.fo && c1.deltah == c2.deltah && c1.deltat == c2.deltat && c1.IterationsAsString() == c2.IterationsAsString();
            }

            public static bool operator !=(Variable c1, Variable c2)
            {
                return !(c1 == c2);
            }

            public Variable(double tf)
            {
                Init(tf);
            }
            public Variable(int lineas, double tf)
            {
                Init(tf);
                for (int i = 0; i < lineas; i++)
                {
                    td.Add(0);
                    if (i < lineas - 1)
                    {
                        tinf.Add(0);
                        tsup.Add(tf * 0.7 * (tf / 100));

                        II.Add(0);
                    }
                }


            }

            public bool Equals(Variable other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Equals(other._td, _td) && Equals(other._tsup, _tsup) && Equals(other._tinf, _tinf) && Equals(other._II, _II) && other.fo.Equals(fo) && other.deltah.Equals(deltah) && other.deltat.Equals(deltat);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != typeof (Variable)) return false;
                return Equals((Variable) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int result = _td.GetHashCode();
                    result = (result*397) ^ _tsup.GetHashCode();
                    result = (result*397) ^ _tinf.GetHashCode();
                    result = (result*397) ^ _II.GetHashCode();
                    result = (result*397) ^ fo.GetHashCode();
                    result = (result*397) ^ deltah.GetHashCode();
                    result = (result*397) ^ deltat.GetHashCode();
                    return result;
                }
            }
        }
        public class TreeNode
        {
            private List<TreeNode> _list = new List<TreeNode>();
            public TreeNode(TreeNode p, EventHandler e, int i, object O)
            {
                Parent = p;
                Event = e;
                MaxIterations = i;
                Object = O;
                CurrentIteration = 0;
                if (p != null)
                    p.List.Add(this);
            }
            public void Run()
            {
                Event(this, null);

            }
            public TreeNode Parent { get; set; }
            public EventHandler Event { get; set; }
            public int MaxIterations { get; set; }
            public List<TreeNode> List { get { return _list; } }
            public int CurrentIteration { get; set; }
            internal void RunChilds()
            {
                foreach (TreeNode item in List)
                    item.Run();
            }
            public List<TreeNode> GetParents()
            {
                var r = new List<TreeNode>();
                var p = Parent;
                while (p != null)
                {
                    r.Insert(0, p);
                    p = p.Parent;
                }
                return r;
            }
            public int GetParentIterationValue(int parent, bool useself = false)
            {
                var r = GetParents();
                if (useself)
                    r.Add(this);
                if (r.Count > parent)
                    return r[parent].CurrentIteration;
                return -1;
            }
            public object Object { get; set; }
        }

        public class Simulate
        {
            private Variable _constante;
            private List<Variable> _vars = new List<Variable>();
            private List<Variable> _iterations = new List<Variable>();
            private int IndexFromIteration(string it)
            {
                for (int i = 0; i < Variables.Count; i++)
                    if (Variables[i].IterationsAsString() == it)
                        return i;


                return -1;
            }
            private void ExecuteOnlyFor(object sender, EventArgs e)
            {
                var node = (TreeNode)sender;

                for (int i = 1; i <= node.MaxIterations; i++)
                {
                    node.CurrentIteration = i;
                    node.RunChilds();
                }
            }
            int k = 0;
            private TreeNode _root = null;
            private bool ExistsVariable(Variable var)
            {
                foreach (Variable variable in Variables)
                    if (variable == var)
                        return true;
                return false;
            }
            public List<Variable> Iterations { get { return _iterations; } }
            private void ExecuteCalcute(object sender, EventArgs e)
            {
                var node = (TreeNode)sender;
                var wf = (Simulate)node.Object;
                double sum = 0, sum2 = 0;

                for (int i = 1; i <= node.MaxIterations; i++)
                {
                    node.CurrentIteration = i;


                    var vars = new Variable(wf.TF);

                    //td5 = t4inf + i4 * deltat;
                    //td4 = t3inf + i3 * deltat;
                    //td3 = t2inf + i2 * deltat;
                    //td2 = t1inf + i1 * deltat;
                    //td1 = tf - (td5 + td4 + td3 + td2);

                    //listaTD.Add(td1);
                    //listaTD.Add(td2);
                    //listaTD.Add(td3);
                    //listaTD.Add(td4);
                    //listaTD.Add(td5);




                    sum = 0;
                    sum2 = 0;
                    vars.td.Add(0);
                    var temtd = new List<double>();
                    var temii = new List<int>();
                    for (int j = 1; j < wf.Lineas; j++)
                    {
                        var itv = node.GetParentIterationValue(j - 1, true);
                        temtd.Add(wf.Constante.deltat * itv + wf.Constante.tinf[j - 1]);
                        temii.Add(itv);
                    }
                    for (int j = temtd.Count - 1; j >= 0; j--)
                    {
                        vars.td.Add(temtd[j]);
                        vars.II.Add(temii[j]);


                    }

                    for (int j = wf.Lineas - 1; j > 0; j--)
                    {
                        sum2 += vars.td[j];
                        sum += wf.Constante.tinf[j - 1];
                    }

                    vars.td[0] = (wf.TF - sum2);


                    double HDD = 0;
                    HDD = delta_h(vars.td, wf.H);

                    for (int j = 0; j < vars.td.Count; j++)
                        sum += Math.Pow((vars.td[j] - wf.TF / (Lineas - 1)), 2);

                    vars.fo = sum + Math.Pow(10, 25) * Math.Pow(HDD, 2);
                    if (vars.td[0] < 0)
                        //     vars.fo = sum + Math.Pow(10, 25) * Math.Pow(vars.td[1], 2);
                        //else
                        vars.fo += Math.Pow(10, 25) * Math.Pow(vars.td[0], 2);


                    for (int j = 0; j < wf.Lineas - 1; j++)
                    {
                        vars.tinf.Add(0);
                        vars.tsup.Add(wf.TF * 0.7 * (wf.TF / 100));
                    }

                    vars.deltah = HDD;
                    // if (wf.Variables.Count < 17)
                    // var ind = IndexFromIteration(vars.IterationsAsString());
                    //  if (ind == -1)
                    if (!ExistsVariable(vars))
                    { wf.Variables.Add(vars);
                    wf.Iterations.Add(vars);
                    }

                    /* else
                         wf.Variables[ind] = vars;*/
                    // else
                    //    wf.Variables[k] = vars;

                    k++;
                }

            }

            public TreeNode Root { get { return _root; } }
            public Simulate(int l, double tf, double h)
            {
                Lineas = l;
                TF = tf;
                H = h;
                _constante = new Variable(l, tf);
                TreeNode last = null;
                for (int i = 0; i < l - 1; i++)
                {
                    var t = new TreeNode(last, ExecuteOnlyFor, 2, this);
                    if (_root == null)
                        _root = t;
                    last = t;
                }

                new TreeNode(last, ExecuteCalcute, 2, this);

            }
            public int Lineas { get; set; }
            public double TF { get; set; }
            public double H { get; set; }
            public Variable Constante { get { return _constante; } }
            public List<Variable> Variables { get { return _vars; } }
            public void Execute()
            {

            retornar:
                //    k = 2;
                Root.Run();

                Variable temp = null;
                for (int z = 1; z < Variables.Count - 1; z++)
                    for (int y = z + 1; y < Variables.Count; y++)
                        if (Variables[z].fo > Variables[y].fo)
                        {
                            temp = Variables[z];
                            Variables[z] = Variables[y];
                            Variables[y] = temp;
                        }

                var t = Variables[1];
                for (int i = 0; i < Lineas - 1; i++)
                {
                    if (t.II[i] == 1)
                        t.tsup[i] += -t.deltat;
                    else
                        t.tinf[i] += t.deltat;
                }

                if (t.deltat > 0.5)
                {
                    t.deltat /= 3;
                    //      Variables.RemoveAt(0);
                    //  while (Variables.Count > 3)
                    //     Variables.RemoveAt(2);
                    goto retornar;
                }
                else
                {
                    var sum = 0.0;
                    for (int i = 1; i < Lineas; i++)
                    {
                        /*if (i < Lineas-1)*/
                        if (i < Lineas - 1) Variables[1].td[i] = (Variables[1].tsup[i] + Variables[1].td[i]) / 2;
                        sum += Variables[1].td[i];
                    }
                    Variables[1].td[0] = TF - sum;

                    //sum = 0;


                }
            }
            public double delta_h(List<double> listaTD, double altura)
            {

                double h = 0;
                for (int i = 1; i < listaTD.Count; i++)
                {
                    h += (Math.Pow(0.13, 2) * 7800 * 2.3 * (i + 1) * listaTD[i]);
                }
                if (listaTD[0] > 0)
                    h += Math.Pow(0.13, 2) * 7800 * 2.3 * 1 * listaTD[listaTD.Count - 1];
                h /= (7800 * 12);
                h -= altura;
                return h;

            }

            public double h_deseada(List<double> listaTD, double altura)
            {
                double h = 0;
                for (int i = 1; i < listaTD.Count; i++)
                {
                    h += (Math.Pow(0.13, 2) * 7800 * 2.3 * (i + 1) * listaTD[i]);
                }
                if (listaTD[0] > 0)
                    h += Math.Pow(0.13, 2) * 7800 * 2.3 * 1 * listaTD[listaTD.Count - 1];
                h /= (7800 * 12);

                return h;
            }

            public List<DataTable> ExportToReport()
            {
                var result = new  List<DataTable>();
                var DataSet = new DSMCC();


                for (int index = 0; index < Iterations.Count; index++)
                {
                    Variable iteration = Iterations[index];
                    var data = DataSet.R_Exploracion_iteracion.NewR_Exploracion_iteracionRow();
                    data.Iteracion = (index + 1).ToString();
                    data.FO = iteration.fo.ToString();
                    data.DT = iteration.deltah.ToString();

                    DataSet.R_Exploracion_iteracion.AddR_Exploracion_iteracionRow(data);
                }


                for (int index = 0; index < Variables[1].td.Count; index++)
                {
                    var iteration = Variables[1];
                    var data = DataSet.R_Exploracion_Lineas.NewR_Exploracion_LineasRow();
                    data.Lineas = (index +1).ToString() ;
                    data.Tiempo = iteration.td[index].ToString();

                    DataSet.R_Exploracion_Lineas.AddR_Exploracion_LineasRow(data);
                }

                result.Add(DataSet.R_Exploracion_iteracion);
                result.Add(DataSet.R_Exploracion_Lineas);

                return result;

            }
        }
    }
}
