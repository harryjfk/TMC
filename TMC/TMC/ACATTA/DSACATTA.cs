using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

namespace TMC.ACATTA
{
    public enum MedioCalentamiento { HE, HL, BS, BP };
    public class  Strings
    {
        private static int CompareDinosByLength(string x, string y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal. 
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater. 
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the 
                    // lengths of the two strings.
                    //
                    //int retval = x.Length.CompareTo(y.Length);

                    if (x.Length != y.Length)
                    {
                        // If the strings are not of equal length,
                        // the longer string is greater.
                        //
                        if (x.Length < y.Length)
                            return 1;
                        else
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        // If the strings are of equal length,
                        // sort them with ordinary string comparison.
                        //
                        return x.CompareTo(y);
                    }
                }
            }
        }
        public static Dictionary<String,double > OrderDictionary(Dictionary<string ,double > src)
        {
            var res = new Dictionary<string, double>();

            var t = new List<string>();
                foreach (string item in src.Keys)
                    t.Add(item);
                t.Sort(CompareDinosByLength);
             
                foreach (string s in t)
                {
                    var item = src[s];
                    res.Add(s, item);
                }
            return res;
        }
    }
    public class AMath
    {
        public static double Interpolation(double x, double x0, double x1, double y0, double y1)
        {
            return (y0 + (((y1 - y0) / (x1 - x0)) * (x - x0)));
        }

    }
    public class CalculoTT
    {

      
              
  
    }
    public partial class DSACATTA {
        partial class T_ConstanteRow
        {
            public  double Value()
            {

                return double.Parse( new NCalc.Expression(valorconst).Evaluate().ToString());
            }
        }
    
        partial class AceroPredecDataTable
        {
           
            //private DSDatos.AceroPredecRow GetItem(String str)
            //{
            //    foreach (AceroPredecRow aceroPredecRow in this)
            //        if (aceroPredecRow.T_ElementoRow.codelemento == str)
            //            return aceroPredecRow;
            //    return null;
            //}
            public Dictionary<String, double> AsDictionary()
            {
            
                var res = new Dictionary<string, double>();
                foreach (AceroPredecRow item in this)

                    res.Add(item.T_ElementoRow.codelemento, item.valor);
                res = Strings.OrderDictionary(res);
                return res;
            }

            public double FeValue()
            {
                double r = 0;
                foreach (DSACATTA.AceroPredecRow item in this)
                    r += item.valor;
                return 100- r;
            }
            public double? GetCarbono()
            {
                double? r = null;
                foreach (AceroPredecRow aceroPredecRow in this)
                    if (aceroPredecRow.T_ElementoRow.codelemento == "C")
                      r=  aceroPredecRow.valor;

                return r;

            }
            public void FillNames()
            {
                foreach (AceroPredecRow aceroPredecRow in this)
                    aceroPredecRow.nameelemento = aceroPredecRow.T_ElementoRow.nameelemento;
            }
            public List<string> PausibleCurves()
            {
                var r = new List<string>();
                var c = GetCarbono();
                if (c != null)
                {
                    if (c <= 0.25)
                    {
                        r.Add("Ferrita Start");
                        r.Add("Ferrita End");
                    }
                    else if (c > 0.25 && c <= 0.8)
                    {
                        r.Add("Ferrita Start");
                        //r.Add("Ferrita End");
                        r.Add("Perlita Start");
                        r.Add("Perlita End");
                        r.Add("Bainita Start");
                        r.Add("Bainita End");
                    }
                    if (c > 0.8)
                    {

                        r.Add("Perlita Start");
                        r.Add("Perlita End");
                        r.Add("Bainita Start");
                        r.Add("Bainita End");
                    }
                }

                return r;

            }

        }
    
        partial class T_FormulaRow
        {
            internal double ExecuteCalc(System.Collections.Generic.Dictionary<string, double> DB)
            {
                var s = md;
                s = s.Replace("Sqrt", "@");
                foreach (KeyValuePair<string, double> keyValuePair in DB)
                    s = s.Replace(keyValuePair.Key, keyValuePair.Value.ToString());

                s = s.Replace("@", "Sqrt");
                return (double) new NCalc.Expression(s).Evaluate();
            }
        }
    
        partial class  T_TipoPiezaGeometriaRow
        {
            public Size GetSize(DSACATTA.T_ColocacionPiezaRow col, DSACATTA.T_HornoRow horno, double largo, double ancho)
            {
                var size = new Size(-1,-1);
                if(col!=null)
                if (col.namecolocacion == "Acentada en su altura")
                {
                    if(idtipopiezageo ==2  || idtipopiezageo ==3  && idtipopiezageo ==4 )
                        if(largo>horno.Altura)
                            if (largo < horno.Largo && ancho < horno.Ancho_Diametro)
                               size = new Size((int)largo,(int) ancho);
                          
                    }
                return size;
            }
        }
        partial class T_TipoTratamientoRow
        {

            public double GetTiempoPermanencia(double z, DSACATTA.T_AceroRow a, DSACATTA.T_TipoPiezaRow pieza)
            {
                if (idtratamiento == 1)
                {
                    if (!a.IsAleado())
                        return 1 * z;
                    return 1.5 * z;
                }
                else
                    if (idtratamiento == 4)

                        return 2.3 * z;

                    else
                        if (idtratamiento == 3)

                            return 1.2 * z;

                        else
                        {
                            var s = 0.0;

                            if (a.T_TipoMaterialRow.idtipomaterial == 2)
                                s = 1.25 * z;
                            else
                                if (a.T_TipoMaterialRow.idtipomaterial == 3)
                                    s = 1.8 * z;

                            if (s < 30)
                                s = 30;
                            return s;
                        }
            }

        }
        partial class T_TipoPiezaRow
        {
            public double TiempoCalentamiento(double h, T_AceroRow acero, T_HornoRow horno, T_TipoPiezaGeometriaRow piezageo, bool useSalt = false)
            {
                if (useSalt)
                {
                    var Fa = 0.0;
                    if (nametipopieza.IndexOf("Pieza Simple No Larga") != -1)
                    {
                        if (horno.TempMaxima <= 900)
                        {
                            if (piezageo.idtipopiezageo == 1)

                                Fa = 16.5;
                            else
                                if (piezageo.idtipopiezageo == 2)
                                    Fa = 20;
                                else
                                    if (piezageo.idtipopiezageo == 2)
                                        Fa = 13.5;

                                    else
                                    {
                                        if (piezageo.idtipopiezageo == 1)

                                            Fa = 9;
                                        else
                                            if (piezageo.idtipopiezageo == 2)
                                                Fa = 11;
                                            else
                                                if (piezageo.idtipopiezageo == 2)
                                                    Fa = 7;
                                    }


                        }


                    }
                    else
                        if (nametipopieza == "Pieza Compleja Larga")
                            Fa = 0.1;
                        else
                            if (nametipopieza == "Otro Tipo")
                            {
                                if (piezageo.idtipopiezageo == 1)

                                    Fa = 55;
                                else
                                    if (piezageo.idtipopiezageo == 2)
                                        Fa = 64;
                                    else
                                        if (piezageo.idtipopiezageo == 2)
                                            Fa = 45;

                            }
                    return Fa * h / 60;
                }
                else
                {
                    if (nametipopieza == "Pieza Simple")
                    {
                        if (acero.T_TipoMaterialRow.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                            return 1 * h;
                        return 1.4 * h;
                    }
                    if (nametipopieza == "Para Herramientas")
                    {
                        if (acero.T_TipoMaterialRow.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                            return 1.8 * h;
                        return 2 * h;
                    }
                    else
                        if (nametipopieza == "Pieza Compleja")
                        {
                            if (horno.TempMaxima <= 600)
                            {
                                if (acero.T_TipoMaterialRow.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                                    return 1.25 * h;
                                return 1.6 * h;
                            }

                            else
                            {
                                if (acero.T_TipoMaterialRow.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                                    return 0.75 * h;
                                return 1.1 * h;
                            }
                        }
                        else

                        //     if (pieza.nametipopieza.IndexOf("Pieza Simple No larga") > 0)
                        {
                            if (horno.TempMaxima <= 900)
                            {
                                if (acero.T_TipoMaterialRow.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                                    return 1.25 * h;
                                return 1.6 * h;
                            }

                            else
                            {
                                if (acero.T_TipoMaterialRow.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                                    return 0.75 * h;
                                return 1.1 * h;
                            }
                        }
                }
            }
        }
        partial class T_MedioEnfriamientoRow
        {
            public float? CapacidadCalorifica(float TF)
            {

                switch (idmedioenf)
                {
                    case 1:
                        {
                            if (TF >= 20 && TF <= 40)
                                return 1;
                            return null;
                        }
                    case 2:
                        {
                            if (TF >= 20 && TF <= 100)
                                return (float?)0.47;
                            return null;
                        }
                    case 3:
                        {
                            if (TF >= 20 && TF <= 100)
                                return (float?)0.84;
                            return null;
                        }

                }
                return null;
            }


            public float? Densidad()
            {
                switch (idmedioenf)
                {
                    case 1:
                        {

                            return 1;
                        }
                    case 2:
                        {
                            return (float?)0.9;
                        }
                    case 3:
                        {
                            return 1;
                        }

                }
                return null;

            }
        }
        partial class T_AceroRow
        {
            public  Dictionary<string,object> Calculate(DSACATTA.T_HornoRow horno, double h, DSACATTA.T_TipoPiezaRow pieza, DSACATTA.T_TipoPiezaGeometriaRow piezageo, DSACATTA.T_TipoTratamientoRow tratamiento, MedioCalentamiento mc, DSACATTA.T_ColocacionPiezaRow col, DSACATTA.T_SeparacionPiezaRow seppieza, double largo, double ancho, double altura, double sepp, double seph, DSACATTA.T_RegimenCalentamientoRow Regimen)
            {

                var r =  new Dictionary<string, object>();
              //  var m = Is();
                var s = "";
                if(IsAleado())
                    s="Aleado";
                else
                    s="Al Carbono";
                var c = IsHipo();
                var th = horno.T_TipoHornoRow;
                var za = GetZeta(h);
                var zh = horno.GetZeta(h, this);
                var tc = pieza.TiempoCalentamiento(h, this, horno, piezageo, mc == MedioCalentamiento.BS);
               
                
                var tp = tratamiento.GetTiempoPermanencia(tc, this, pieza);
                var cp1 = piezageo.GetSize(col, horno, largo, ancho);
                var cp = horno.CantPiezas(ancho, largo, altura, seph, sepp);
                var tr =  TiempoRelativoCalentamiento(piezageo, seppieza)*tp;

                r.Add("tt", tratamiento.nametratamiento);
                r.Add("ta", s);
                r.Add("ma", nameacero);
                r.Add("hr", horno.namehorno);
                r.Add("mc", mc.ToString());
                r.Add("dc", h);
                r.Add("tc", tc);
                r.Add("tp", tp);
                r.Add("tr", tr);
                return r;
            }
            public  double TiempoRelativoCalentamiento( DSACATTA.T_TipoPiezaGeometriaRow piezageo, DSACATTA.T_SeparacionPiezaRow seppieza)
            {
                var r = 0.0;
                if (piezageo.nametipopiezageo == "Cuadrada" || piezageo.nametipopiezageo == "Rectangular")
                {
                    if (seppieza.nameseparacion == "Una Pieza")
                        r = 1.4;
                    else
                        if (seppieza.nameseparacion == "Unidas")
                            r = 4;
                        else if (seppieza.nameseparacion == "Separadas a X")
                            r = 2;
                        else
                            r = 1.8;
                }
                else
                {
                    if (seppieza.nameseparacion == "Una Pieza")
                        r = 1;
                    else
                        if (seppieza.nameseparacion == "Unidas")
                            r = 2;
                        else if (seppieza.nameseparacion == "Separadas a X")
                            r = 1.4;
                        else
                            r = 1.3;
                }

                if (isOnePercentCarbon() || nameacero == "Al Carbono")
                    r *= 2;
                return r;
            }
            public bool isOnePercentCarbon()
            {

                var s = GetT_AceroElementoRows();
                foreach (DSACATTA.T_AceroElementoRow item in s)

                    if (item.idelemento == 1 && item.valorinicial == (decimal)0.01)
                        return true;
                return false;
            }
            public double GetZeta(double H)
            {
                if (T_TipoMaterialRow.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                    return 1.25 * H;
                return 1.8 * H;
            }
            public bool IsHipo()
            {
                var percent = 0.0;
                var elem = GetT_AceroElementoRows();
                foreach (T_AceroElementoRow item in elem)
                {
                    if (item.T_ElementoRow.codelemento == "C")
                    {
                        percent = (double)item.valorinicial;
                        break;
                    }
                }

                return percent < 0.8;


            }
            private bool IsAleadoElement(DSACATTA.T_ElementoRow elemento, double inicomp)
            {
                var element = elemento.codelemento.ToUpper();

                return ((element == "CR" && inicomp >= 0.1) ||
                 (element == "NI" && inicomp >= 0.3) ||
                 (element == "MN" && inicomp >= 4.5) ||
                 (element == "MG" && inicomp >= 0.15) ||
                 (element == "W" && inicomp >= 0.15) ||
                 (element == "B" && inicomp >= 0.001) ||
                 (element == "AL" && inicomp >= 0.35) ||
                 (element == "ZR" && inicomp >= 0.15) ||
                     (element == "MO" && inicomp >= 0.15) ||
                 (element == "V" && inicomp >= 0.08) ||
                 (element == "NB" && inicomp >= 0.2) ||
                 (element == "TI" && inicomp >= 0.03) ||
                         (element == "CE" && inicomp >= 0.025) ||
                 (element == "CU" && inicomp >= 0.5) ||
                 (element == "BA" && inicomp >= 0.1));
                
       
            }


            public bool IsAleado()
            {
                var s = GetT_AceroElementoRows();
                foreach (T_AceroElementoRow item in s)
                {
                    var t = IsAleadoElement(item.T_ElementoRow, (double)item.valorinicial);
                    if (t != false)
                        return true;
                }

                return false;

            }



            internal double GetTempMax(T_TipoTratamientoRow Tratamiento)
            {
               var r = GetT_TratamientoRows();
               foreach (DSACATTA.T_TratamientoRow trat in r)
               {
                   if (trat.T_TipoTratamientoRow == Tratamiento)
                       return trat.tempmax;
               }
               return 0;
            }

        }
        partial class T_HornoRow
        {
            public int CantPiezas(double h, double w, double a, double seph, double sepp)
            {
                if ((Ancho_Diametro - h) / 2 < seph)
                    return -1;
                if ((Largo - w) / 2 < seph)
                    return -1;
                var height = (Ancho_Diametro - seph) / (h + sepp);
                var width = (Largo - seph) / (w + sepp);
                //var altura = (Altura - seph) / (a + sepp);
                return (int)(height * width /** altura*/);
            }
            public double GetZeta(double h, DSACATTA.T_AceroRow acero)
            {
                if (TempMaxima <= 600)
                {
                    if (acero.T_TipoMaterialRow.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                        return 0.15 * h;
                    return 0.2 * h;
                }
                return 0.35 * h;
            }

           
            public List<float> EvaluarPieza(T_TipoMaterialRow material,int ti,int tf,float peso,float eficiencia)
            {
                var q = peso * material.CapacidadCalorifica(tf) * (tf - ti);
                var kwh = q / 860;
                var e = kwh / eficiencia * 100;
                var res = new List<float> {(float) kwh, (float) e}; 
                return res;
            }

            public Dictionary<string,object> Evaluate(T_TipoMaterialRow material,int cantpiezas, int TI,int TF, float Potencia,float Eficiencia,float Peso)
            {
                float temppeso = Peso;
                int cantpiezasres = 0;
                float q = 0;
                float e = 0;
                float qr = 0;
                float er = 0;
                float ql = 0;
                float el = 0;
                while (q<=Potencia)
                {
                    var evaluacion = EvaluarPieza(material,TI, TF, temppeso,Eficiencia);             
             
                    temppeso += Peso;
             
                    q = evaluacion[0];
                    e = evaluacion[1];
                    if (q < Potencia)
                    {
                        ql = q;
                        el = e;
                        cantpiezasres++;
                    }
                    if (cantpiezasres <= cantpiezas)
                    {
                        qr = q;
                        er = e;
                    }
                }

                var res = new Dictionary<string, object>();
                if (Potencia <= PowerRating)
                {
                    res.Add("cantpiezasres", cantpiezasres);
                    res.Add("cantpiezas", cantpiezas);
                    res.Add("q", ql);
                    res.Add("porig", Potencia);
                    res.Add("Eficiencia", Eficiencia);
                    res.Add("qr", qr);
                    res.Add("er", er);
                    res.Add("e", el);
                    res.Add("pesoc", Peso*cantpiezas);
                    res.Add("pesop", Peso);
                    res.Add("material", material.nametipomaterial);
                    res.Add("horno", namehorno);
                    var s = "aqui la va la parte";

                    res.Add("observaciones", s);
                }
                else
                    if (Potencia > PowerRating)
                        res.Add("mess", "La energia para calentar las piezas es pequeña. Se recomienda de ser posible un horno con mas potencia.");
                return res;
            }
        }
    partial class T_TipoMaterialRow
    {
        public double CapacidadCalorifica(float TF)
        {
            DSACATTA.T_CapacidadDeslozeRow inicial = null;
            DSACATTA.T_CapacidadDeslozeRow final = null;
            var cap = GetT_CapacidadCalorificaRows();
            if (cap.Length > 0)
            {
                var desloze = cap[0].GetT_CapacidadDeslozeRows();
                foreach (T_CapacidadDeslozeRow capacidadDeslozeRow in desloze)
                {
                    if (capacidadDeslozeRow.temperatura < TF)
                        if (inicial == null)
                            inicial = capacidadDeslozeRow;
                        else

                            if (capacidadDeslozeRow.temperatura > inicial.temperatura)
                                inicial = capacidadDeslozeRow;
                
                    if (TF <= capacidadDeslozeRow.temperatura && inicial != capacidadDeslozeRow && inicial != null)
                        if(final==null )
                        {
                        final = capacidadDeslozeRow;
                        break;
                            ;
                        }
                    //if(final!=null && inicial!=null)
                    //    break;
                    
                }

            }

if(inicial!=null && final != null)
            return  AMath.Interpolation(TF,inicial.temperatura,final.temperatura,inicial.valor,final.valor);
            return 0;
        }
    }
        partial class T_CalculoTanqueTTDataTable
        {
          
        }
    
        partial class T_CurvaDataTable
        {
            
        }
        partial class T_AceroRow
        {
            public DSACATTA.DeterminarTTDataTable DeterminarTT(T_TipoPropiedadSolRow propiedad, int valor)
            {
                   var dataset = (DSACATTA) Table.DataSet;
                var dtt = dataset.DeterminarTT;
                dtt.Clear();
                DSACATTA.T_TipoTratamientoRow ttr = null;
                 
                    dataset.T_Tratamiento.DefaultView.RowFilter = "idtipotrat = 1 and idacero = "+idacero;

                    foreach (DataRowView  VARIABLE in dataset.T_Tratamiento.DefaultView)
                    {
                        var row = (DSACATTA.T_TratamientoRow) VARIABLE.Row;
                        var props = row.GetT_TratamientoDeslozeRows();
                        foreach (T_TratamientoDeslozeRow tratamientoDeslozeRow in props)
                            if (tratamientoDeslozeRow.T_TipoPropiedadSolRow == propiedad &&
                                valor >= tratamientoDeslozeRow.valormax)
                                ttr = tratamientoDeslozeRow.T_TratamientoRow.T_TipoTratamientoRow;
                    }
                    dataset.T_Tratamiento.DefaultView.RowFilter = "idtipotrat = 2 and idacero = " + idacero;
                       foreach (DataRowView VARIABLE in dataset.T_Tratamiento.DefaultView)
                       {
                           var row = (DSACATTA.T_TratamientoRow)VARIABLE.Row;
                           var props = row.GetT_TratamientoDeslozeRows();
                           foreach (T_TratamientoDeslozeRow tratamientoDeslozeRow in props)
                               if (tratamientoDeslozeRow.T_TipoPropiedadSolRow == propiedad &&
                                  valor >= tratamientoDeslozeRow.valormin && valor <= tratamientoDeslozeRow.valormax)
                                   ttr = tratamientoDeslozeRow.T_TratamientoRow.T_TipoTratamientoRow;
                       }

                       dataset.T_Tratamiento.DefaultView.RowFilter = "idtipotrat = 3 and idacero = " + idacero;
                       foreach (DataRowView VARIABLE in dataset.T_Tratamiento.DefaultView)
                       {
                           var row = (DSACATTA.T_TratamientoRow)VARIABLE.Row;
                           var props = row.GetT_TratamientoDeslozeRows();
                           foreach (T_TratamientoDeslozeRow tratamientoDeslozeRow in props)
                               if (tratamientoDeslozeRow.T_TipoPropiedadSolRow == propiedad &&
                                  valor >= tratamientoDeslozeRow.valormin && valor <= tratamientoDeslozeRow.valormax)
                                   ttr = tratamientoDeslozeRow.T_TratamientoRow.T_TipoTratamientoRow;
                       }
                       dataset.T_Tratamiento.DefaultView.RowFilter = "idtipotrat = 4 and idacero = " + idacero;
                       foreach (DataRowView VARIABLE in dataset.T_Tratamiento.DefaultView)
                       {
                           var row = (DSACATTA.T_TratamientoRow)VARIABLE.Row;
                           var props = row.GetT_TratamientoDeslozeRows();
                           foreach (T_TratamientoDeslozeRow tratamientoDeslozeRow in props)
                               if (tratamientoDeslozeRow.T_TipoPropiedadSolRow == propiedad &&
                                  valor >= tratamientoDeslozeRow.valormin && valor <= tratamientoDeslozeRow.valormax)
                                   ttr = tratamientoDeslozeRow.T_TratamientoRow.T_TipoTratamientoRow;
                       }

                if (ttr!=null)
                {
                    var temptemple = "";
                    if (ttr.idtratamiento == 2)
                    {
                        dataset.T_Tratamiento.DefaultView.RowFilter = "idtipotrat = 1 and idacero = " + idacero;
                        if (dataset.T_Tratamiento.DefaultView.Count > 0)
                            temptemple =
                                ((DSACATTA.T_TratamientoRow) ((DataRowView) dataset.T_Tratamiento.DefaultView[0]).Row).
                                    tempmin + " - " +
                                ((DSACATTA.T_TratamientoRow) ((DataRowView) dataset.T_Tratamiento.DefaultView[0]).Row).
                                    tempmax;
                    }



                    dataset.T_Tratamiento.DefaultView.RowFilter = "idtipotrat = "+ ttr.idtratamiento +" and idacero = " + idacero;
                   
                    foreach (DataRowView VARIABLE in dataset.T_Tratamiento.DefaultView)
                    {var row = (DSACATTA.T_TratamientoRow)
                        VARIABLE.Row;
                        var dttr = dtt.NewDeterminarTTRow();
                        dttr.acero = nameacero;
                        dttr.temptemple = temptemple;
                        dttr.tipotratamiento = ttr.nametratamiento;
                        dttr.propiedadsel = propiedad.nametipopropiedad;
                        dttr.tempmax = row.tempmax.ToString();
                        dttr.tempmin = row.tempmin.ToString();
                        dttr.valor = valor.ToString();
                        var props = row.GetT_TratamientoDeslozeRows();
                        foreach (T_TratamientoDeslozeRow tratamientoDeslozeRow in props)
                            if(tratamientoDeslozeRow.T_TipoPropiedadSolRow == propiedad)
                            {
                                dttr.propmax = tratamientoDeslozeRow.valormax.ToString();
                                dttr.propmin = tratamientoDeslozeRow.valormin.ToString();
                            }
                        dtt.AddDeterminarTTRow(dttr);
                    }
                }
               
                dtt.AcceptChanges();
                return dtt;
            }
        }
    
        public  class T_Tanque
        {
            public static Dictionary<string, object> CalculateRect(DSACATTA.T_TipoMaterialRow Material, DSACATTA.T_MedioEnfriamientoRow MedioEnfriamiento, int inimetal, int finmetal, int iniliq, int finliq,float cantpiez,float peso,float dimension)
            {
                var res = new Dictionary<string, object>();
                var c1 = 0.110/*Material.CapacidadCalorifica(inimetal)*/;
                var c2 = 0.164/*Material.CapacidadCalorifica(finmetal)*/;
                var cl = MedioEnfriamiento.CapacidadCalorifica(iniliq);
                var d = MedioEnfriamiento.Densidad();
                var p =cantpiez *
                       peso;
                var vl = CalculateHelper.VolumenLiquidoAContenerTanque(p, (float)c1, (float)c2,
                                                                      inimetal,
                                                                      finmetal,
                                                                       (float)cl,
                                                                      finliq,
                                                                       iniliq,
                                                          (float)d);
                double vle = 0;
                double vc = 0;
                if (MedioEnfriamiento.idmedioenf != 3)
                {
                    vle = CalculateHelper.VolumenLiquidoEmpujado(p, 7.8);
                    if (MedioEnfriamiento.idmedioenf == 2)
                    {
                        vc = CalculateHelper.VolumenIncrementado(vl, 0.9, 0.87);
                        vle += vc;
                    }
                }
                var l = dimension;
                var vt = vl + vle + vc;
                var at = vt / l;
        
                var hl = 2 * l;
                var ht = hl + 100;

              
                res.Add("material", Material.nametipomaterial);
                res.Add("volliq", vl);
                res.Add("vle", vle);
                res.Add("vt", vt);
                res.Add("ht", ht);
                res.Add("medio", MedioEnfriamiento.namemedioenf);
                res.Add("cantpiez", cantpiez);
                res.Add("vi", vc);
                res.Add("dimens", ht);
                res.Add("rebosadero", hl);
           
                return res;
            }
            public static double Diametro(double Area)
            {
                return 2*Math.Sqrt(Area/Math.PI)*100;
            }
            public static double  Area(double vt,float ht)
            {
                return vt/(ht/100);
            }
             public static Dictionary<string, object> CalculateCircular(DSACATTA.T_TipoMaterialRow Material, DSACATTA.T_MedioEnfriamientoRow MedioEnfriamiento, int inimetal, int finmetal, int iniliq, int finliq,float cantpiez,float peso,float dimension)

             {
                 var res = CalculateRect(Material, MedioEnfriamiento, inimetal, finmetal, iniliq, finliq, cantpiez, peso,
                                         dimension);
                 res["vle"] = Math.Round((double)res["vle"], 1);
                 var n = 18;
                 var Are = Area((double)res["vt"], (float)res["ht"]);
                 var r = Diametro(Are)/2;
                 var dh = r/n;
                 var i = 1;
                 var v = 0.00;
                 var vc = (double)res["vle"];
                 while (v<vc)
                 {

                     var h = i*dh;

                     var c = 2*Math.Sqrt(h*(2*r - h));
                     var g1 = Math.Pow(r, 2) - Math.Pow(c, 2);
                     var a = Math.Acos((g1 - Math.Pow(r, 2)) / (2 * Math.Pow(r, 2)))*180/Math.PI;
                     var l = 0.01745*r*a;
                     var A = (r*l - c*(r - h))/2;
                     v = A* (float)res["dimens"] ;

                     if(h>r)
                         break;
                     

                     i++;
                 }








           

                 return res;
             }
        }
        partial class T_AceroDataTable
        {
            public void FillName(int idnorma)
            {
            
              
                foreach (DSACATTA.T_AceroRow aceroRow in Rows)
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
    }
}

namespace TMC.ACATTA.DSACATTATableAdapters
{
    
    
    public partial class T_AceroNormaTableAdapter {
    }
}
