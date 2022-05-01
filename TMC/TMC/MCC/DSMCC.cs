using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TMC.Components;
using TMC.MCC.DSMCCTableAdapters;

namespace TMC.MCC
{
    public enum TLE
    {
        LargoMetalurgico,
        VelocidadColada,
        VelocidadExtraccion,
        VelocidadProduccion,
        TiempPermancAC,
        TiempPermancAD,
        Solidificacion,
        CTT,
        CantAgua,
        VelocidadAgua,
        EspesorPiel,
        OscilacionMolde,
        TiempoSanado,
        DistanciaMarcaOscilacion,
        EnfriamSecZona,
        AceiteLubricacion
    } ;


    

    public static class DSInterpreter
    {

        public static List<float> GetValuesfromParam(string paramvalue, char sep)
        {
            var r = new List<float>();
            var s = "";
            for (int i = 0; i < paramvalue.Length; i++)
                if (Equals(paramvalue[i], sep))
                {
                    r.Add(float.Parse(s));
                    s = "";

                }
                else
                    s += paramvalue[i];
            if (s != "")
                r.Add(float.Parse(s));
            return r;
        }
    }

    public partial class DSMCC
    {
        partial class T_AceroDataTable
        {
            public void FillName(int idnorma)
            {


                foreach (DSMCC.T_AceroRow aceroRow in Rows)
                {
                    var normas = aceroRow.GetT_AceroNormaRows();
                    string s = "";
                    foreach (T_AceroNormaRow aceroNormaRow in normas)
                        if (aceroNormaRow.idnorma == idnorma)
                            s = aceroNormaRow.valor;
                    aceroRow.nameacero = s;
                }

            }
        }
      


       

        /*
        private String GetFormula(String frm)
        {
            var s = Material.GetT_FormulaRows();
            foreach (var t in s)
                if (t.MD == frm)
                    return t.MI;
            return "";
        }
        
        */
     

        partial class T_MaterialRow
        {
         /*   public String GetFormula(String frm)
            {
                var s = GetT_FormulaRows();
                foreach (var t in s)
                    if (t.MD == frm)
                        return t.MI;
                return "";
            }
            */
        


        }

        /*partial class T_FormulaDataTable
        {
            public string GetFormula(string str)
            {
                DefaultView.RowFilter = "MD = '" + str + "'";
                var t = DefaultView.Count;
                DefaultView.RowFilter = "";
                if (t > 0)
                    return ((DSDatos.T_FormulaRow)DefaultView[0].Row).MI;
                return "";
            }
        }
        partial class T_FormulaRow
        {
            static private List<String> GetSeparators()
            {
                var r = new List<String>();
                r.Add("+");
                r.Add("-");
                r.Add("*");
                r.Add("/");

                return r;
            }
            static public List<String> GetStringSeparated(String str)
            {
                var r = new List<String>();
                var t = "";
                var sep = GetSeparators();
                foreach (char c in str)
                    if (sep.IndexOf(c.ToString()) == -1)
                        t += c;
                    else
                    {
                        if (t != "")
                            r.Add(t);
                        t = "";
                    }
                if (t != "")
                    r.Add(t);

                return r;
            }
        }*/

        public List<int> LLenarZonas(int Porcierto, int Resto)
        {

            List<int> lista = new List<int>();

            for (int i = 5; i <= (Porcierto + Resto); i += 5)
                lista.Add(i);

            return lista;

        }

        partial class T_PalanquillaRow
        {
            public double GetArea()
            {
                var s = DSInterpreter.GetValuesfromParam(areapalanquilla, 'x');
                var r = 0.0;
                foreach (float f in s)
                    if (r == 0.0)
                        r = f;
                    else
                        r *= f;
                return r;
            }


            public double GetTamanho()
            {
                var s = DSInterpreter.GetValuesfromParam(areapalanquilla, 'x');
                var r = 0.0;
                foreach (float f in s)
                    if (r == 0.0)
                        r = f;
                    else
                        r = f;
                return r;
            }



            public double Area_Intercambio(double longitud)
            {

                if (double.Parse(Seccion_Palanquilla()) == 115)
                    return 0.414;
                if (double.Parse(Seccion_Palanquilla()) == 130)
                    return 0.468;
                return 0;
                //return 4 *( double.Parse(Seccion_Palanquilla())/1000 )* longitud;
            }

            public string Seccion_Palanquilla()
            {
                var s = DSInterpreter.GetValuesfromParam(areapalanquilla, 'x');
                var r = 0.0;
                foreach (float f in s)
                    if (r == 0.0)
                        r = f;
                    else
                        r = f;
                return r.ToString();


            }




        }

        partial class T_TecnologiaRow
        {
            public T_ParametroValorRow AddParameter(String name, decimal value,String um)
            {

                var i = ((DSMCC)Table.DataSet).T_Parametros.FindByName(name);
              
                if (i > 0)
                {
                    var r = ((DSMCC)Table.DataSet).T_ParametroValor.NewT_ParametroValorRow();
                    r.idparametro = i;
                    r.maquina = false;
                    r.idsource = idtecnologia;
                    r.valor = value.ToString();
                    r.um = um;
                    return r;
                }
                return null;
            }
            public  decimal  GetValor(String Name)
            {
                foreach (var VARIABLE in GetT_ParametroValorRows())
                    if (VARIABLE.T_ParametrosRow.nomparametro == Name)
                        return Convert.ToDecimal(VARIABLE.valor);
                return 0;
            }
            public void Reporte(int? types)
            {
                var s = new P_ReporteTecnologiaTableAdapter();
                s.ClearBeforeFill = true;
                s.Fill(((DSMCC) Table.DataSet).P_ReporteTecnologia, idtecnologia, types);
                var frmreport = 
                ((MasterForm) Application.OpenForms[MasterForm.Index]).ReporteForm;

                frmreport.ucReport1.LoadFromFile(Application.StartupPath + @"\Reportes\RepTecnologia.repx", ((DSMCC)Table.DataSet).P_ReporteTecnologia, null);
                frmreport.ShowDialog();
            }
        
        }
        partial class T_ParametrosDataTable
        {
            public int FindByName(String name)
            {
                for (int i =0;i<Rows.Count;i++)
                    if(((T_ParametrosRow)Rows[i]).nomparametro ==name)
                    return ((T_ParametrosRow)Rows[i]).idparametro;
                return -1;
            }
        }
        partial class T_MaquinaRow
        {
            /// <summary>
            /// LONGITUD METALURGICA
            /// </summary>
            /// <param name="value"></param>
            /// <returns></returns>            
            public double LargoTangencial(double value = -1)
            {

                if (value == -1)
                {
                    var s = GetParametroValue("rC");
                    return Math.PI * DSInterpreter.GetValuesfromParam(s, '-')[0] * 90 / 180;
                }
                else
                    return Math.PI * value * 90 / 180;
            }


            public double LargoMetalurgico()
            {
                return LargoTangencial() + 7.1;
            }




            /// <summary>
            /// VELOCIDAD DE COLADA
            /// </summary>
            /// <param name="diametro"></param>
            /// <param name="altura"></param>
            /// <returns></returns>
            public double FlujoAceroMolde(double diametro, double altura)
            {
                var g = GetParametroValue("g");

                return (Math.PI * Math.Pow(diametro, 2) / 4) * (Math.Sqrt(2 * DSInterpreter.GetValuesfromParam(g, '-')[0] * altura));
            }

            public double VelocidadColada(double diametro, double altura)
            {
                var d = GetParametroValue("pAliq");
                return FlujoAceroMolde(diametro, altura) * (DSInterpreter.GetValuesfromParam(d, '-')[0]);
            }




            /// <summary>
            /// VELOCIDAD DE EXTRACCIÓN
            /// </summary>
            /// <param name="diametro"></param>
            /// <param name="altura"></param>
            /// <param name="idpalanquilla"></param>
            /// <returns></returns>
            public double Velocidad_Extraccion(double diametro, double altura, int idpalanquilla)
            {
                var am = FlujoAceroMolde(diametro, altura);
                var palan = GetT_PalanquillaRows();
                foreach (T_PalanquillaRow palanquillaRow in palan)
                    if (palanquillaRow.idpalanquilla == idpalanquilla)

                        return am / (palanquillaRow.GetArea() / 1000000);

                return 0;
            }




            /// <summary>
            /// VELOCIDAD DE PRODUCCION
            /// </summary>
            /// <param name="diametro"></param>
            /// <param name="altura"></param>
            /// <param name="idpalanquilla"></param>
            /// <returns></returns>
            public double Velocidad_Produccion(double diametro, double altura, int idpalanquilla)
            {
                double am = 0;
                var palan = GetT_PalanquillaRows();
                foreach (T_PalanquillaRow palanquillaRow in palan)
                    if (palanquillaRow.idpalanquilla == idpalanquilla)

                        am = palanquillaRow.GetArea() / 1000000;

                var vc = Velocidad_Extraccion(diametro, altura, idpalanquilla); //la velocidad de extraccion puede cambiar debe ser parametro a elegir por el usuario
                var d = double.Parse(GetParametroValue("pSol"));

                return am * vc * d;
            }




            /// <summary>
            /// TIEMPO DE PERMANENCIA DEL ACERO EN LA CASUELA
            /// </summary>
            /// <param name="diametro"></param>
            /// <param name="altura"></param>
            /// <param name="idpalanquilla"></param>
            /// <param name="cantAcero"></param>
            /// <param name="NumLineas"></param>
            /// <returns></returns>
            public double PermanenciaCasuelayDistribuidor(double diametro, double altura, int idpalanquilla, int cantAcero, int NumLineas)
            {
                double VelocProd = Velocidad_Produccion(diametro, altura, idpalanquilla);
                return cantAcero / (VelocProd * NumLineas);
            }



            /// <summary>
            /// LONGITUD METALURGICA CALCULADA
            /// </summary>
            /// <param name="diametro"></param>
            /// <param name="altura"></param>
            /// <param name="idpalanquilla"></param>
            /// <param name="K"></param>
            /// <returns></returns>
            public double LongitudMetCalc(double diametro, double altura, int idpalanquilla, double K)
            {
                var palan = GetT_PalanquillaRows();
                foreach (T_PalanquillaRow palanquillaRow in palan)
                    if (palanquillaRow.idpalanquilla == idpalanquilla)

                        return Math.Pow((palanquillaRow.GetTamanho() / (2 * K)), 2) * (Velocidad_Extraccion(diametro, altura, idpalanquilla));

                return 0;
            }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="Valores"></param>
            /// <param name="pos"></param>
            /// <returns></returns>
            public double GetValor(Dictionary<string, double> Valores, String pos)
            {
                if (Valores.ContainsKey(pos))
                    return Valores[pos];
                return (DSInterpreter.GetValuesfromParam(GetParametroValue(pos), '-')[0]);
            }

            /// <summary>
            /// CALCULO DEL ENFRIAMIENTO PRIMARIO
            /// </summary>
            /// <param name="palanquillaRow"></param>
            /// <param name="longitud"></param>
            /// <param name="Valores"></param>
            /// <returns></returns>
            public List<double> CalorTotalTransferido(DSMCC.T_PalanquillaRow palanquillaRow, double longitud, Dictionary<string, double> Valores)
            {

                var res = new List<double>();


                double AI = palanquillaRow.Area_Intercambio(longitud);
                double X = palanquillaRow.GetTamanho() / 10000;
                double Y = GetValor(Valores, "y");
                double Z = GetValor(Valores, "z");
                double KX = GetValor(Valores, "Kx");
                double KY = GetValor(Valores, "Ky");
                double KZ = GetValor(Valores, "Kz");
                double DT = GetValor(Valores, "DT");
                res.Add((AI * DT / 60));
                res.Add(((X / KX + (Y / KY) + (Z / KZ))));
                res.Add(res[0] / res[1]);

                return res;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="palanquillaRow"></param>
            /// <param name="longitud"></param>
            /// <param name="Valores"></param>
            /// <returns></returns>
            public List<double> CantAguaMax_EP(DSMCC.T_PalanquillaRow palanquillaRow, double longitud, Dictionary<string, double> Valores)
            {
                List<double> res = new List<double>();

                res.Add(CalorTotalTransferido(palanquillaRow, longitud, Valores)[2]);
                res.Add(1 * 9);
                res.Add(res[0] / res[1]);
                return res;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="palanquillaRow"></param>
            /// <param name="longitud"></param>
            /// <param name="Valores"></param>
            /// <returns></returns>
            public double VelocidadAgua_EP(DSMCC.T_PalanquillaRow palanquillaRow, double longitud, Dictionary<string, double> Valores)
            {
                return (CantAguaMax_EP(palanquillaRow, longitud, Valores)[2] * 1000) /
                       (double.Parse(palanquillaRow.GetT_Circulacion_AMRows()[0].area_circulacion) * 60);
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="Valores"></param>
            /// <returns></returns>
            public double CalorNecesarioSolidificar(Dictionary<string, double> Valores)
            {

                return (GetValor(Valores, "pAliq") * (GetValor(Valores, "Ce")) * GetValor(Valores, "DTs")) + (GetValor(Valores, "oS") * GetValor(Valores, "pAliq"));
            }






            public bool EsVacio(List<String> Datos)
            {
                for (int i = 0; i < Datos.Count; i++)
                    if (Datos[i] == "")
                        return false;
                return true;
            }

            public bool EsMultp_3(int num)
            {
                if (num % 3 != 0)
                    return false;
                return true;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="diametro"></param>
            /// <param name="altura"></param>
            /// <param name="idpalanquilla"></param>
            /// <param name="palanquillaRow"></param>
            /// <param name="longitud"></param>
            /// <param name="Valores"></param>
            /// <returns></returns>
            public double EspesorCapa(double diametro, double altura, int idpalanquilla, DSMCC.T_PalanquillaRow palanquillaRow, double longitud, Dictionary<string, double> Valores)
            {
                return (CalorTotalTransferido(palanquillaRow, longitud, Valores)[2] / 1) /
                       (4 + (double.Parse(palanquillaRow.Seccion_Palanquilla()) / 1000) + CalorNecesarioSolidificar(Valores) +
                       Velocidad_Extraccion(diametro, altura, idpalanquilla));
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="diametro"></param>
            /// <param name="altura"></param>
            /// <param name="idpalanquilla"></param>
            /// <returns></returns>
            public double OscilacionMolde(double diametro, double altura, int idpalanquilla)
            {
                return Velocidad_Extraccion(diametro, altura, idpalanquilla) * 650 / 8;
            }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="diametro"></param>
            /// <param name="altura"></param>
            /// <param name="idpalanquilla"></param>
            /// <returns></returns>
            public double TiempoSanado(double diametro, double altura, int idpalanquilla)
            {
                return (1 / (Math.PI * OscilacionMolde(diametro, altura, idpalanquilla))) *
                       (Math.Acos(Velocidad_Extraccion(diametro, altura, idpalanquilla) /
                                  (Math.PI * OscilacionMolde(diametro, altura, idpalanquilla) * 8))) * 60;
            }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="diametro"></param>
            /// <param name="altura"></param>
            /// <param name="idpalanquilla"></param>
            /// <returns></returns>
            public double DistanciaMarcaOscilacion(double diametro, double altura, int idpalanquilla)
            {
                return Velocidad_Extraccion(diametro, altura, idpalanquilla) * 1000 / OscilacionMolde(diametro, altura, idpalanquilla);
            }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="diametro"></param>
            /// <param name="altura"></param>
            /// <param name="idpalanquilla"></param>
            /// <returns></returns>
            public double EnfriamientoSecZ1(double diametro, double altura, int idpalanquilla)
            {
                return Velocidad_Extraccion(diametro, altura, idpalanquilla) * 1.65 * 130 * 0.32;
            }

            public double EnfriamientoSecZ2(double diametro, double altura, int idpalanquilla)
            {
                return Velocidad_Extraccion(diametro, altura, idpalanquilla) * 1.65 * 130 * 0.43;
            }
            public double EnfriamientoSecZ3(double diametro, double altura, int idpalanquilla)
            {
                return Velocidad_Extraccion(diametro, altura, idpalanquilla) * 1.65 * 130 * 0.25;
            }


            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            public double AceiteLubricacion()
            {
                return 536.36 * 0.04;
            }



            public String GetParametroValue(string param)
            {

                foreach (var VARIABLE in this.GetT_ParametroValorRows())
                    if (VARIABLE.T_ParametrosRow.nomparametro == param)
                        return VARIABLE.valor;
                return "";
            }

            public String GetParametroUM(string param)
            {

                foreach (var VARIABLE in this.GetT_ParametroValorRows())
                    if (VARIABLE.T_ParametrosRow.nomparametro == param)
                        return VARIABLE.um;
                return "";
            }

            public double GetValueFromString(string str)
            {
                return 0;
            }

            private void AddRow(T_ParametroValorRow row)
            {
                if (row != null)
                    ((DSMCC) Table.DataSet).T_ParametroValor.AddT_ParametroValorRow(row);
            }

            public T_TecnologiaRow Calculate(int idmaquina, int idacero, int idpalanquilla, int longitud, int codigo)
            {

                var result = ((DSMCC)Table.DataSet).T_Tecnologia.NewT_TecnologiaRow();
                var maquina = ((DSMCC)Table.DataSet).T_Maquina.FindByidmaquina(idmaquina);
                var acero = ((DSMCC)Table.DataSet).T_Acero.FindByidacero(idacero);
                var palanquilla = ((DSMCC)Table.DataSet).T_Palanquilla.FindByidpalanquilla(idpalanquilla);

                result.idacero = idacero;
                result.idpalanquilla = idpalanquilla;
                result.idmaquina = idmaquina;
                result.codigo = codigo;
                
                result.longitud = longitud;
                ((DSMCC)Table.DataSet).T_Tecnologia.AddT_TecnologiaRow(result);
            //    result.AcceptChanges();
             
                double diametro;
                if (double.Parse(palanquilla.Seccion_Palanquilla()) == 115) diametro = 0.015;
                else
                    diametro = 0.0155;


                var temp = new Dictionary<string, double>();
                temp.Add("y", 0.012);
                temp.Add("z", 0.000021);
                temp.Add("DT", 1500);

               AddRow(result.AddParameter("lo", decimal.Round((decimal)LargoMetalurgico(), 6), "m"));
               AddRow(result.AddParameter("vc", decimal.Round((decimal)VelocidadColada(diametro, 0.6), 6), "Kg/min"));
               AddRow(result.AddParameter("ve", decimal.Round((decimal)Velocidad_Extraccion(diametro, 0.6, idpalanquilla), 6), "m"));
               AddRow(result.AddParameter("vp", decimal.Round((decimal)Velocidad_Produccion(diametro, 0.6, idpalanquilla), 6), "lineas/min"));
               AddRow(result.AddParameter("tipac", decimal.Round((decimal)PermanenciaCasuelayDistribuidor(diametro, 0.6, idpalanquilla, 75, 4), 6), "min"));
               AddRow(result.AddParameter("tipad", decimal.Round((decimal)PermanenciaCasuelayDistribuidor(diametro, 0.6, idpalanquilla, 10, 4), 6), "min"));
                AddRow(result.AddParameter("lmcal", decimal.Round((decimal)LongitudMetCalc(diametro, 0.6, idpalanquilla, 28.5), 6), "m"));
                AddRow(result.AddParameter("ctt", decimal.Round((decimal)CalorTotalTransferido(palanquilla, 1, temp)[2], 6), "Kcal/min"));
                AddRow(result.AddParameter("cmae", decimal.Round((decimal)CantAguaMax_EP(palanquilla, 1, temp)[2], 6), "L/min"));
                AddRow(result.AddParameter("vma", decimal.Round((decimal)VelocidadAgua_EP(palanquilla, 1, temp), 6), "m/s"));
                AddRow(result.AddParameter("ep", decimal.Round((decimal)EspesorCapa(diametro, 0.6, idpalanquilla, palanquilla, 1, temp), 6), "m"));
                AddRow(result.AddParameter("om", decimal.Round((decimal)OscilacionMolde(diametro, 0.6, idpalanquilla), 6), "opm"));
                AddRow(result.AddParameter("ts", decimal.Round((decimal)TiempoSanado(diametro, 0.6, idpalanquilla), 6), "s"));
                AddRow(result.AddParameter("dmo", decimal.Round((decimal)DistanciaMarcaOscilacion(diametro, 0.6, idpalanquilla), 6), "mm"));
                AddRow(result.AddParameter("esz1", decimal.Round((decimal)EnfriamientoSecZ1(diametro, 0.6, idpalanquilla), 6), "l/min"));
                AddRow(result.AddParameter("esz2", decimal.Round((decimal)EnfriamientoSecZ2(diametro, 0.6, idpalanquilla), 6), "l/min"));
                AddRow(result.AddParameter("esz3", decimal.Round((decimal)EnfriamientoSecZ3(diametro, 0.6, idpalanquilla), 6), "l/min"));
                AddRow(result.AddParameter("al", decimal.Round((decimal)AceiteLubricacion(), 6), "ml/min"));

                return result;
            }

            public string NoteCient(string srt)
            {
                double num = double.Parse(srt);
                int count = 0;
                var b = false;
                int pos = 0;
                var s = srt;
                if (num < 0)
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] != '0' && b)
                            break;
                        if (s[i] == '.')
                        {
                            b = true;
                            pos = i;
                        }

                        if (b) count++;
                    }
                    return ((Math.Pow(10, count) * num) + "x10-" + count);
                }
                else
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] != '.')
                            count++;
                        else
                            break;
                    }
                    return ((num / Math.Pow(10, count - 1)) + "x10+" + (count - 1)).ToString();
                }
                
            }


            private List<Ecuation> GetEcuacion(TLE tle, bool byparam)
            {

                var lista = new List<Ecuation>();
                if (tle == TLE.LargoMetalurgico)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("Lo=(Π*r*90)/180"));
                        lista.Add(new Ecuation("Lo=(3.14*p1*90)/180"));
                        lista.Add(new Ecuation("Lo=p2"));
                        lista.Add(new Ecuation("Lm=Lo+lm"));
                        lista.Add(new Ecuation("Lm=p2+p3"));
                        lista.Add(new Ecuation("Lm=p4"));
                    }
                    else
                    {
                        lista.Add(new Ecuation("Lo=(Π*r*90)/180"));
                        lista.Add(new Ecuation("Lm=p1"));
                    }
                }

                if (tle == TLE.VelocidadColada)
                {
                    if (byparam)
                    {
                        //Velocidad de Colada
                        lista.Add(new Ecuation("m=AB√(2gh)"));
                        lista.Add(new Ecuation("m=p4*p8"));
                        lista.Add(new Ecuation("m=p9"));
                    }
                    else
                    {
                        lista.Add(new Ecuation("m= AB√(2gh)"));
                        lista.Add(new Ecuation("m=p1"));
                    }
                }

                if (tle == TLE.VelocidadExtraccion)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("Vc= m/Am"));
                        lista.Add(new Ecuation("Vc=p1/p2"));
                        lista.Add(new Ecuation("Vc=p3"));
                    }
                    else
                    {
                        lista.Add(new Ecuation("Vc= m/Am"));
                        lista.Add(new Ecuation("Vc=p1"));
                    }
                }

                if (tle == TLE.VelocidadProduccion)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("Vp=Am*Vc*d"));
                        lista.Add(new Ecuation("Vp=p1*p2*p3"));
                        lista.Add(new Ecuation("Vp=p5"));
                    }
                    else
                    {
                        lista.Add(new Ecuation("Vp=Am*Vc*d"));
                        lista.Add(new Ecuation("Vp=p1"));
                    }
                }

                if (tle == TLE.TiempPermancAC)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("Tro=H/(n*Vp)"));
                        lista.Add(new Ecuation("Tro=p1/(p2*p3)"));
                        lista.Add(new Ecuation("Tro=p4"));
                    }
                    else
                    {
                        lista.Add(new Ecuation("Tro=H/(n*Vp)"));
                        lista.Add(new Ecuation("Tro=p1"));
                    }
                }

                if (tle == TLE.TiempPermancAD)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("Trd=C/(n*Vp)"));
                        lista.Add(new Ecuation("Trd=p1/(p2*p3)"));
                        lista.Add(new Ecuation("Trd=p4"));
                    }
                    else
                    {
                        lista.Add(new Ecuation("Trd=C/(n*Vp)"));
                        lista.Add(new Ecuation("Trd=p1"));
                    }
                }

                if (tle == TLE.Solidificacion)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("Lmcal=(LdoPQ/2*K)²*Vp"));
                        lista.Add(new Ecuation("Lmcal=(p1/(2*28.5))²*p2"));
                        lista.Add(new Ecuation("Lmcal=p3"));
                    }
                    else
                    {
                        lista.Add(new Ecuation("Lmcal=(LdoPQ/2*K)²*Vp"));
                        lista.Add(new Ecuation("Lmcal=p1"));
                    }

                }

                if (tle == TLE.CTT)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("Q=(A*DT/60)/((x/Kx) +(y/Ky) +(z/Kz))"));
                        lista.Add(new Ecuation("Q=(p1/p2"));
                        lista.Add(new Ecuation("Q=p3"));
                    }
                    else
                    {
                        lista.Add(new Ecuation("Q=((A*DT)/60)/((x/Kx)+(y/Ky)+(z/Kz))"));
                        lista.Add(new Ecuation("Q=p1"));
                    }
                }

                if (tle == TLE.CantAgua)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("Wh2o=Qt/(CeH2O*DT)"));
                        lista.Add(new Ecuation("Wh2o=p1/(p2*p3)"));
                        lista.Add(new Ecuation("Wh2o=p4"));
                    }
                    else
                    {
                        lista.Add(new Ecuation("Wh2o=Qt/(CeH2O*DT)"));
                        lista.Add(new Ecuation("Wh2o=p1"));
                    }
                }


                if (tle == TLE.VelocidadAgua)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("V=(Q*1000)/(a*60)"));
                        lista.Add(new Ecuation("V=(p1*1000)/(p2*60)"));
                        lista.Add(new Ecuation("V=p3"));
                    }
                    else
                    {
                        lista.Add(new Ecuation("V=(Q*100)/(a*60)"));
                        lista.Add(new Ecuation("V=p1"));
                    }
                }

                if (tle == TLE.EspesorPiel)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("e= (Q/1)/(4+L+q+v)"));
                        lista.Add(new Ecuation("e= (p1/1)/(4+p2+p3+p4)"));
                        lista.Add(new Ecuation("e= p5"));
                    }

                    else
                    {
                        lista.Add(new Ecuation("e= (Q/1)/(4+L+q+v)"));
                        lista.Add(new Ecuation("e= p1"));
                    }
                }

                if (tle == TLE.OscilacionMolde)
                {
                    if (byparam)
                    {

                        lista.Add(new Ecuation("N= (Vc*650)/C"));
                        lista.Add(new Ecuation("N= (p1*650)/p2"));
                        lista.Add(new Ecuation("N= p3"));
                    }

                    else
                    {
                        lista.Add(new Ecuation("N= (Vc*650)/C"));
                        lista.Add(new Ecuation("N= p1"));
                    }


                }




                if (tle == TLE.TiempoSanado)
                {
                    if (byparam)
                    {

                        lista.Add(new Ecuation("NTS=((1/Π*f)*(@(Vc/(Π*s*f)))*60)"));
                        lista.Add(new Ecuation("NTS= ((1/Π*p1)*(@(p2/(Π*p3*p1)))*60)"));
                        lista.Add(new Ecuation("NTS= ((1/Π*p1)*p6*60)"));
                        lista.Add(new Ecuation("NTS= p5"));
                    }

                    else
                    {
                        lista.Add(new Ecuation("NTS=((1/Π*f)*(@(Vc/(Π*s*f)))*60)"));
                        lista.Add(new Ecuation("NTS= p1"));
                    }


                }




                if (tle == TLE.DistanciaMarcaOscilacion)
                {
                    if (byparam)
                    {

                        lista.Add(new Ecuation("D= (Vc/f)"));
                        lista.Add(new Ecuation("D= (p1/p2)"));
                        lista.Add(new Ecuation("D= p3"));
                    }

                    else
                    {
                        lista.Add(new Ecuation("D= (Vc/f)"));
                        lista.Add(new Ecuation("D= p1"));
                    }


                }




                if (tle == TLE.EnfriamSecZona)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("Qt= Pm* τ + α *(Θ-Θ₀) * Vc"));
                        lista.Add(new Ecuation("Qt= 130* p1 + (0.007 *p2) * p3"));
                        lista.Add(new Ecuation("Qt= p4"));
                        lista.Add(new Ecuation("Qtz1= p5"));
                        lista.Add(new Ecuation("Qtz2= p6"));
                        lista.Add(new Ecuation("Qtz3= p7"));
                    }

                    else
                    {
                        lista.Add(new Ecuation("Qtz1= Pm* τ + α *(Θ-Θ₀) * Vc"));
                        lista.Add(new Ecuation("Qtz1= p1"));
                        lista.Add(new Ecuation("Qtz2= p2"));
                        lista.Add(new Ecuation("Qtz3= p3"));
                    }


                }


                if (tle == TLE.AceiteLubricacion)
                {
                    if (byparam)
                    {
                        lista.Add(new Ecuation("Q= P*f"));
                        lista.Add(new Ecuation("Q= p1*p2"));
                        lista.Add(new Ecuation("Q= p3"));
                    }

                    else
                    {
                        lista.Add(new Ecuation("Q= P*f"));
                        lista.Add(new Ecuation("Q= p1"));
                    }


                }


                return lista;
            }

            public void ShowFormulates(Dictionary<String, String> Datos, FormulateControl FCFormulate, TLE tle, bool byparam)
            {
                var lista = GetEcuacion(tle, byparam);
                FCFormulate.Ecuations.Clear();
                foreach (Ecuation ecuation in lista)
                {
                    var temp = ecuation.RightSide.Parameters.AsString();
                    foreach (var key in Datos.Keys)
                        temp = temp.Replace(key, Datos[key]);
                    FCFormulate.Ecuations.Add(new Ecuation(ecuation.LeftSide.Parameters.AsString() + ecuation.Sign + temp));

                }

                FCFormulate.Refresh();



            }



        }

        partial class T_AceroElementoDataTable
        {
            public void Ceq(int idacero, out double CARBeq, out string typec)
            {
                DefaultView.RowFilter = "idacero = " + idacero;

                double CARBD = 0;
                double CARBG = 0;
                double min = 0;
                double max = 0;
                foreach (DataRowView composicionQuimicaView in DefaultView)
                {
                    var composicionQuimicaRow = (DSMCC.T_AceroElementoRow)composicionQuimicaView.Row;
                    try
                    {
                        min = (double)composicionQuimicaRow.valorinicial;
                    }
                    catch (Exception)
                    {

                        min = 0;
                    }
                    try
                    {
                        max =(double) composicionQuimicaRow.valorfinal;
                    }
                    catch (Exception)
                    {

                        max = 0;
                    }

                    if (composicionQuimicaRow.T_ElementoRow.codelemento == "C")
                    {

                        CARBD +=
                                 ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 81.1);
                        CARBG +=
                                     ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 62.3);

                    }
                    else if (composicionQuimicaRow.T_ElementoRow.codelemento == "P")
                    {
                        CARBD +=
                              ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 33.5);
                        CARBG +=
                                   ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 33.5);

                    }
                    else if (composicionQuimicaRow.T_ElementoRow.codelemento == "S")
                    {
                        CARBD +=
                       ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 33.5);
                        CARBG +=
                            ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 33.5);

                    }
                    else if (composicionQuimicaRow.T_ElementoRow.codelemento == "Si")
                    {
                        CARBD +=
                        ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 18.7);
                        CARBG +=
                                 ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 18.7);

                    }
                    else if (composicionQuimicaRow.T_ElementoRow.codelemento == "Mn")
                    {
                        CARBD +=
                       ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 5.0);
                        CARBG +=
                                ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 5.0);
                    }
                    else if (composicionQuimicaRow.T_ElementoRow.codelemento == "Cu")
                    {
                        CARBD +=
                        ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 2.4);
                        CARBG +=
                                   ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 2.4);

                    }
                    else if (composicionQuimicaRow.T_ElementoRow.codelemento == "Cr")
                    {
                        CARBD +=
                            ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 1.8);
                        CARBG +=
                                   ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 1.8);
                    }
                    else if (composicionQuimicaRow.T_ElementoRow.codelemento == "Ni")
                    {
                        CARBD +=
                     ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 3.0);
                        CARBG +=
                              ACINOX.Functions.Math.Percent.Part((min +
                                 max) / 2, 3.0);

                    }
                }
                CARBD = CARBD / 81.1;
                CARBG = CARBG / 62.3;
                if (CARBD < 0.53)
                {
                    CARBeq = CARBD;
                    typec = "Ferritico";
                }
                else
                {

                    typec = "Austenitico";
                    CARBeq = CARBG;
                }
            }

            public void CalcularTemperaturas(int idmarca, out string typec, out double Tliq, out double Tsol)
            {
                Tliq = 0;
                Tsol = 0;
                typec = "";
               /* double CARBeq = 0;
                Ceq(idmarca, out CARBeq, out typec);
                if (CARBeq <= Constantes.Cp3)
                {
                    Tliq = 1538 - 81.1 * CARBeq;
                    if (CARBeq < Constantes.Cp1)
                        Tsol = 1538 - (81.1 / 0.17) * CARBeq;
                    else
                        if ((CARBeq >= Constantes.Cp1) && (CARBeq <= Constantes.Cp2))
                            Tsol = 1495;
                        else
                            Tsol = 1495 + 62.3 * Constantes.Cp3 - (62.3 / 0.34) * CARBeq;
                }
                else
                {
                    Tliq = 1495 + 62.3 * Constantes.Cp3 - 62.3 * CARBeq;
                    Tsol = 1495 + 62.3 * Constantes.Cp3 - (62.3 / 0.34) * CARBeq;
                }
                */
            }
        }

    }
}
namespace TMC.MCC.DSMCCTableAdapters
{


    public partial class T_Propiedad_TermodinamicaTableAdapter
    {
    }
}
