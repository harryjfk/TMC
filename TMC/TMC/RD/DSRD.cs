using System.Collections.Generic;
using System;
using System.Drawing;
using System.Linq;
using TMC.Components;
namespace TMC.RD {

    public enum TipoDensidad
    {
        Materiales_Extralivianos,
        Materiales_Medios_Livianos,
        Materiales_Medios_Pesados,
        Materiales_Convencionales,
        Materiales_Medios_Densos,
        Materiales_Extradensos

    } ;
    public partial class DSRD {
        partial class T_DegradeeDataTable
        {
            public Color GetColor(int pos)
            {
                try
                {
                    var D = FindByiddegrade(Properties.Settings.Default.DegradeSelect);
                    if (D != null)
                    {
                        var ms = D.scalemax - D.scalemin;
                        var ps = ACINOX.Functions.Math.Percent.Percen(ms, pos);
                        var img = ACINOX.Functions.File.BitmapFromArra(D.imgdegrade);
                        var pi = ACINOX.Functions.Math.Percent.Part(img.Width, ps);
                        if (pi >= img.Width)
                            pi = img.Width - 1;
                        return ((Bitmap)img).GetPixel((int)pi, 1);
                    }
                }
                catch (Exception)
                {


                }

                return Color.Transparent;
            }
        }
        partial class T_DegradeeRow
        {
            public Color GetColor(int pos)
            {
              /*  try
                {
                   */
                        var ms = scalemax - scalemin;
                        var ps = ACINOX.Functions.Math.Percent.Percen(ms, pos);
                        var img = ACINOX.Functions.File.BitmapFromArra(imgdegrade);
                        var pi = ACINOX.Functions.Math.Percent.Part(img.Width, ps);
                        if (pi >= img.Width)
                            pi = img.Width - 1;
                        return ((Bitmap)img).GetPixel((int)pi, 1);
                    
              /*  }
                catch (Exception)
                {


                }

                return Color.Transparent;*/
            }
        }

        partial class T_FormatoRow
        {
            public double Volumen()
            {
                return Largo1 * Largo2 * altura;
            }

        }

        partial class T_Propiedad_FisicaRow
        {
            public float Peso()
            {
                return 0; //T_MaterialRow.GetT_Propiedad_ProduccionRows()[0].GetT_FormatoRows()[] Volumen()*Den
            }
        }
        partial class T_Propiedad_ProduccionRow
        {
            public double getCostoProm()
            {
                var sum = 0.0;
                foreach (var c in GetT_FormatoRows())
                {
                    sum += c.Costo;
                }
                return sum / GetT_FormatoRows().Length;
            }
        }
        partial class T_Elemento_OxidoDataTable
        {
            public void FillNames()
            {
                foreach (T_Elemento_OxidoRow elementoOxidoRow in this)
                    elementoOxidoRow.nombre_elemento = elementoOxidoRow.T_ElementoRow.nameelemento;
            }
        }
     partial class T_MaterialDataTable
     {
         public T_MaterialRow FindByName(String name)
         {
             return this.FirstOrDefault(materialRow => materialRow.namematerial == name);
         }
     }
        partial class T_MaterialRow
        {
            public String GetFormula(String frm)
            {
                var s = GetT_FormulaRows();
                foreach (var t in s)
                    if (t.mi == frm)
                        return t.md;
                return "";
            }

            public double Estres(double espesor, double qpart, double lp, double t)
            {
                var p = new Dictionary<String, String>();
                p.Add("T", t.ToString());
                return ((new Ecuation(GetFormula("E"),"", p).RightSide.Parameters.AsDouble() * new Ecuation(GetFormula("A"),"", p).RightSide.Parameters.AsDouble() * qpart * espesor) / (lp * (1 - new Ecuation(GetFormula("P"), "", p).RightSide.Parameters.AsDouble())));

            }
            public List<double> GetEspesoresAll(int tipoformato)
            {
                var r = new List<double>();
                var table = (T_MaterialDataTable)Table;
                foreach (T_MaterialRow materialRow in table)
                {
                    var t = materialRow.GetT_Propiedad_ProduccionRows()[0];
                    foreach (T_FormatoRow tFormatoRow in t.GetT_FormatoRows())
                        if (tFormatoRow.idTipo_Formato == tipoformato && r.IndexOf(tFormatoRow.Espesor) == -1)
                            r.Add(tFormatoRow.Espesor);
                }



                return r;

            }
            

            public TipoDensidad GetDensidadMaterial()
            {
                var t = GetT_Propiedad_FisicaRows();
                if (t.Length == 0)
                    return TipoDensidad.Materiales_Convencionales;
                var PF = t[0];
                if (PF.Densidad < 800)
                    return TipoDensidad.Materiales_Extralivianos;

                if (PF.Densidad >= 800 && PF.Densidad < 1100)
                    return TipoDensidad.Materiales_Medios_Livianos;

                if (PF.Densidad >= 1100 && PF.Densidad < 1600)
                    return TipoDensidad.Materiales_Medios_Pesados;

                if (PF.Densidad >= 1600 && PF.Densidad < 2500)
                    return TipoDensidad.Materiales_Convencionales;

                if (PF.Densidad >= 2500 && PF.Densidad < 2900)
                    return TipoDensidad.Materiales_Medios_Densos;

                if (PF.Densidad >= 2900)
                    return TipoDensidad.Materiales_Extradensos;

                return 0;

            }


        }

        partial class T_FormulaDataTable
        {
            public string GetFormula(string str)
            {
                DefaultView.RowFilter = "MD = '" + str + "'";
                var t = DefaultView.Count;
                DefaultView.RowFilter = "";
                if (t > 0)
                    return ((T_FormulaRow)DefaultView[0].Row).mi;
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
        }
    }
}
