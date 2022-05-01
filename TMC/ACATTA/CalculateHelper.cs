using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.ACATTA
{
    public static class CalculateHelper
    {
        public static float VolumenLiquidoAContenerTanque(float p, float c1, float c2, int tim, int tfm, float cl, int tfl, int til, float d)
        {
            return (p * (c1 * tim - c2 * tfm)) / (cl * (tfl- til) * d);
        }

        public static double VolumenLiquidoEmpujado(double P, double p)
        {
            return (P/p);
        }
        public static double VolumenTotalMinimoTanque(double vl, double ve, double vc)
        {
            return vl + vc + ve;
        }


        public static DSACATTA.T_TipoMaterialRow GetTypeAceroByElement(DSACATTA.T_TipoMaterialDataTable aceros, DSACATTA.T_ElementoRow elemento, float inicomp)
        {
            var element = elemento.codelemento.ToUpper();
            var a = "";
            if ((element == "CR" && inicomp >= 0.1) ||
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
               (element == "BA" && inicomp >= 0.1))
            {
                a = "Carbono";
            }
            else
                a = "Aleación";

            foreach (var item in aceros)
            {
                if (item.nametipomaterial.ToUpper().IndexOf(a.ToUpper()) > 0)
                    return item;
            }
            return null;

        }
        public static String GetTypeByPercent(float percent)
        {
        if(percent<0.08)
            return "Hipoeutectoide";
        return "Hipereutectoide";

        }
        public static double GetTimeOfHeatByTT(DSACATTA.T_TipoMaterialRow acero, float H)
        {
            if (acero.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                return 1.25 * H;
            return 1.8 * H;
        }
        public static double GetTimeOfHeatByHorno(DSACATTA.T_TipoMaterialRow acero, float H, float temp)
        {
            if (temp <= 600)
            {
                if (acero.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                    return 0.15 * H;
                return 0.2 * H;
            }
            return 0.35 * H;
        }
        public static double GetTimeOfHeatByPieceType1(DSACATTA.T_TipoMaterialRow acero, DSACATTA.T_TipoPiezaRow pieza, float H, float temp)
        {
            if (pieza.nametipopieza == "Pieza Simple")
            {
                if (acero.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                    return 1 * H;
                return 1.4 * H;
            }
            if (pieza.nametipopieza == "Para Herramientas")
            {
                if (acero.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                    return 1.8 * H;
                return 2 * H;
            }
            else
                if (pieza.nametipopieza == "Pieza Compleja")
                {
                    if (temp <= 600)
                    {
                        if (acero.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                            return 1.25 * H;
                        return 1.6 * H;
                    }

                    else
             
                    {
                        if (acero.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                            return 0.75 * H;
                        return 1.1 * H;
                    }
                }
                else

                    //     if (pieza.nametipopieza.IndexOf("Pieza Simple No larga") > 0)
                {
                    if (temp <= 900)
                    {
                        if (acero.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                            return 1.25 * H;
                        return 1.6 * H;
                    }

                    else
                    {
                        if (acero.nametipomaterial.ToUpper().IndexOf("CARBONO") > 0)
                            return 0.75 * H;
                        return 1.1 * H;
                    }
                }
        }

        public static double GetTimeOfHeatByPieceType2(DSACATTA.T_TipoPiezaRow pieza, DSACATTA.T_TipoPiezaGeometriaRow geo, float H, float temp, float K1)
        {
            var Fa = 0;






            var Z = Fa * H / 60;

            return Z;
            
//            -Para pieza simple no larga (se usa en sales)
//    Temperatura <= 900  0C 
//Fa=16.5        para pieza cuadrada
//Fa=20           para pieza rectangular
//Fa=13.5        para pieza redonda

//   Temperatura > 900  0C
//Fa=9        para pieza cuadrada
//Fa=11           para pieza rectangular
//Fa=7        para pieza redonda

//  Otro tipo de pieza
//Fa=55        para pieza cuadrada
//Fa=65           para pieza rectangular
//Fa=45        para pieza redonda

//-Para pieza compleja larga
//Fa=0.1

//Formula:       Z=(Fa×H)/60

//*Para piezas con diferentes secciones que se calientan en diferentes medios.
//Z=0.1×K_1×K_(2×) K_(3 )×H


//Estos coeficientes son válidos para :
//-cilindro, paralepípedo, placa con longitud y ancho infinitos cuya relación entre longitud/diámetro  y longitud/grosor sea mayor a 3.
//-si esa relación es 1.5-2.5, el coeficiente debe multiplicarse por 0.75

//K_2-  factor de forma:
//1    para la esfera 
//2    para el cilindro 
//2.5     para el paralepípedo
//4       para la placa o lámina con longitud y ancho infinitos

//K_3- coeficiente de uniformidad del calentamiento
//1   si es por todas partes
//4   si es unilateral

//H- dimensión característica.


        }


        public static double VolumenIncrementado(float vl, double p1, double p2)
        {
            return vl*(p1 - p2)/p2;
        }
    }
}
