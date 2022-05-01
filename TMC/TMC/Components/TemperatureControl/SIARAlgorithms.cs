using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TMC.RD;
using TMC.RD.DSRDTableAdapters;

namespace TMC.Components.TemperatureControl
{
    public class SIARAlgorithm
    {
        private readonly List<DSRD.T_MaterialRow> _materiales = new List<DSRD.T_MaterialRow>();
        private readonly List<double> _spesor = new List<double>();
        private void AddList(List<double> list, int index, double value)
        {
            if (index < list.Count)
                list[index] = value;
            else
                list.Add(value);
        }

        private void Lamda(List<double> List, List<double> ListTMTP, List<List<string >> Temp,  int? CRPFind =null)
        {
            for (int i = 1; i <= Materiales.Count; i++)
                if (CRPFind != null)
                {
                    if (i != CRPFind)
                    {
                        var tempIntern = Temp[i - 1];
                        if (tempIntern.Count == 1)
                            AddList(List, i, double.Parse(tempIntern[0]));
                        if (tempIntern.Count == 2)
                            AddList(List, i, double.Parse(tempIntern[0]) + double.Parse(tempIntern[1])*ListTMTP[i]);
                        if (tempIntern.Count == 3)
                            AddList(List, i,
                                    double.Parse(tempIntern[0]) + double.Parse(tempIntern[1])*ListTMTP[i] +
                                    double.Parse(tempIntern[2])*Math.Pow(ListTMTP[i], 2));
                    }
                }
                else
                {
                    var tempIntern = Temp[i - 1];
                    if (tempIntern.Count == 1)
                        AddList(List, i, double.Parse(tempIntern[0]));
                    if (tempIntern.Count == 2)
                        AddList(List, i, double.Parse(tempIntern[0]) + double.Parse(tempIntern[1])*ListTMTP[i]);
                    if (tempIntern.Count == 3)
                        AddList(List, i,
                                double.Parse(tempIntern[0]) + double.Parse(tempIntern[1])*ListTMTP[i] +
                                double.Parse(tempIntern[2])*Math.Pow(ListTMTP[i], 2));
                }
        }

        public Dictionary<String, Object> LastSisParcial;
        public Project ProjectObject { get; set; }
        private DSRD.T_ProjectRow _project;
        public DSRD.T_ProjectRow Project { get { return _project; } set { _project = value;
            var t = TDataSet.T_Material;
           
            var s = new MemoryStream(Project.dataproject);
            s.Position = 0;
            ProjectObject = TemperatureControl.Project.FromStream(s);
            for (int index = 0; index < ProjectObject.Materiales.Count; index++)
            {
                Material materiale = ProjectObject.Materiales[index];
                var w = t.FindByName(materiale.Name);
                Materiales.Add(w);
                Spesor.Add(materiale.Espesor);

            }
        } }
        public double GetAlphaExterno(double ts,double tamb)
        {
            //switch (Project.formulat)
            //{
                //case 1:
                //    return Project.vcform;
                //case 2:
                //    {
                //    //         return  double.Parse((1.842*(Math.Pow(( ((List<double>) LastSisParcial["TEXP_E"])[Materiales.Count] - TAMP), 0.55))).ToString())
               
                //        break;
                        
                //    }
                //case 3:
                //    {
                        var hr = Project.emchapa*Math.Pow(5.67, -8)*(Math.Pow(ts, 4) - Math.Pow(tamb, 4))/(ts - tamb);
                        double hc = 0;
                        switch (Project.T_Tipo_ParedRow.idtipopared)
                        {
                            case 0:
                                {
                                    hc = 1.842 * Math.Pow(ts - tamb, 1.25); break;
                                    
                                }
                            case 1:
                                {
                                    hc = 2.372 * Math.Pow(ts - tamb, 1.25); break;

                                }
                            case 2:
                                {
                                    hc = Math.Cos(Project.valuepared) * 1.842 * Math.Pow(ts - tamb, 1.25); break;

                                }
                            case 3:
                                {
                                    hc = 1.07*(9.462*Math.Sqrt(0.305+0.87*Project.valuepared)*(ts-tamb)); 
                                    break;

                                }
                            default:{break;}
                        
                        }
                        return hc + hr;
                          //ASTM))

                        //break;
                        
                //    }
                //case 4:
                //    {
                     
                //        var tf = ts + tamb/2;
                //        var hr = Project.emchapa*Math.Pow(5.67, -8)*(Math.Pow(ts, 4) - Math.Pow(tamb, 4))/(ts - tamb);
                //        var hc = 1.85 + 0.02316*tf - 0.00001047*Math.Pow(tf, 2);
                //        return hr + hc;
                //        //CHC
                //        break; ;
                //    }

            //}
            //return 0;

        }
        public Dictionary<String, Object> SiSParcial(double TINTPP, double TAMP)
        {

           LastSisParcial = new Dictionary<String, Object>
                        {
                            {"VARIesp", 0.0},
                            {"EspesMinCap", 0.0},
                            {"EspesMaxCap", 0.0},
                            {"VARItempI", 0.0},
                            {"TempVmax", 0.0},
                            {"SSP", 0.0},
                            {"QPAR", 0.0},
                            {"ALFP", 0.0},
                            {"TMTP", new List<double>(){0}},
                            {"LP", new List<double>(){0}},
                            {"TEXP", new List<double>(){0}},
                            {"TMTPC", new List<double>()},
                            {"TEXP_E", new List<double>()},
                            {"ERR_CAL",false}

                        };
            var formula = new List<List<string>>();
            for (int i = 0; i < Materiales.Count; i++)
                if (Materiales[i].GetT_FormulaRows().Length > 0)
                {
                    DSRD.T_FormulaRow k = Materiales[i].GetT_FormulaRows().FirstOrDefault(t => t.mi == "K");
                    if (k != null)
                        formula.Add(DSRD.T_FormulaRow.GetStringSeparated(k.md));
                }
            ClearList(formula);
            //var formula =
            //    Materiales.Select(t => t.GetT_FormulaRows()[0].GetStringSeparated(t.GetT_FormulaRows()[2].MI)).ToList();
            double INF_SLIR = 0;

            if (((List<double>)LastSisParcial["TEXP_E"]).Count == 0)
            ((List<double>) LastSisParcial["TEXP_E"]).Add(TINTPP);
            double EstimaT = 0;
            EstimaT = (TINTPP - (0.6 * TINTPP)) / Materiales.Count;
            for (int ZP = 1; ZP <= Materiales.Count; ZP++)
                ((List<double>)LastSisParcial["TEXP_E"]).Add(TINTPP - ((EstimaT * (ZP))));
            for (int ZP = 1; ZP <= Materiales.Count; ZP++)
                ((List<double>) LastSisParcial["TMTP"]).Add(
                    ((((List<double>) LastSisParcial["TEXP_E"])[ZP - 1]) + ((List<double>) LastSisParcial["TEXP_E"])[ZP])/2);
            var CLAVEP = true;
              do
              {
                  double ts = 0.0;
                  if(((List<double>) LastSisParcial["TEXP_E"]).Count>0)
                      ts =
                          ((List<double>) LastSisParcial["TEXP_E"])[((List<double>) LastSisParcial["TEXP_E"]).Count - 1];
                LastSisParcial["ALFP"]   = GetAlphaExterno(ts,TAMP);
                Lamda(((List<double>)LastSisParcial["LP"]), ((List<double>)LastSisParcial["TMTP"]), formula);
               LastSisParcial["SSP"]   = 0.0;
                  for (int XP = 1; XP <= Materiales.Count; XP++)
                      LastSisParcial["SSP"] = (double)LastSisParcial["SSP"] + Spesor[XP - 1] / ((List<double>)LastSisParcial["LP"])[XP];
                  LastSisParcial["QPAR"] = (TINTPP - TAMP) / (((double)LastSisParcial["SSP"]) + (1 / ((double)LastSisParcial["ALFP"])));

                LastSisParcial["SSP"] = 0.0;
                for (int XP1 = 1; XP1 <= Materiales.Count; XP1++)
                {
                    LastSisParcial["SSP"] = (double)LastSisParcial["SSP"] + Spesor[XP1 - 1] / ((List<double>)LastSisParcial["LP"])[XP1];
                    AddList((List<double>)LastSisParcial["TEXP"], XP1, TINTPP - ((double)LastSisParcial["QPAR"] * (double)LastSisParcial["SSP"]));

                }
                CLAVEP = true;
                  for (int ZP3 = 1; ZP3 <= Materiales.Count; ZP3++)

                      if (Math.Abs(((List<double>) LastSisParcial["TEXP_E"])[ZP3] - ((List<double>) LastSisParcial["TEXP"])[ZP3]) > 1)
                      {
                          CLAVEP = false;
                          break;
                      }

                  if (CLAVEP == false)
                {
                    for (int ZP = 1; ZP <= Materiales.Count; ZP++)
                        AddList(((List<double>) LastSisParcial["TEXP_E"]), ZP,
                                (((List<double>) LastSisParcial["TEXP"])[ZP] + ((List<double>) LastSisParcial["TEXP_E"])[ZP])/2);


                    for (int ZP4 = 1; ZP4 <= Materiales.Count; ZP4++)
                        AddList(((List<double>) LastSisParcial["TMTP"]), ZP4,
                                (((List<double>) LastSisParcial["TEXP_E"])[ZP4 - 1] + ((List<double>) LastSisParcial["TEXP_E"])[ZP4])/2);
                }
                INF_SLIR++;
                if (INF_SLIR > 100000)
                {
                    CLAVEP = true;
                    LastSisParcial["ERR_CAL"] = true;
                }

              } while (!CLAVEP);
              LastSisParcial["SSP"] = 0.0;
            for (int XP3 = 0; XP3 < Materiales.Count; XP3++)
                LastSisParcial["SSP"] = (double) LastSisParcial["SSP"] + Spesor[XP3];
            //MessageBox.Show("El coeficiente de intercambio por conveccion con el medio es: " + r["ALFP"] + " W/m^2 oC, el flujo calorico es de : " + r["QPAR"] + " W/m^2, la temperatura externa es: " + ((List<double>)r["TEXP"])[Materiales.Count] + " oC. ");
            return LastSisParcial;
        }

        private void ClearList(List<List<string>> formula)
        {

            var t = 0.0;
            foreach (var list in formula)
            {
                var i = 0;
                while (i < list.Count)
                    if (double.TryParse(list[i], out t))
                        i++;
                    else
                        list.RemoveAt(i);
            }

        }

        public Dictionary<String, object > EST_SEG_TEMP(double TINTPP, double TAMP, int TEXTERN)
        {
            var listado = new Dictionary<String, object>()    {
                            {"VARIesp", 0.5},
                            {"EspesMinCap", 0.0},
                            {"EspesMaxCap", Spesor[0] * 1000},
                            {"VARItempI", 0.0},
                            {"TempVmax", 0.0},
                            {"SSP", 0.0},
                            {"QPAR", 0.0},
                            {"ALFP", 0.0},
                            {"DeltaMin",0.5},
                              {"CntINTER",0.0}
 

                        };
            //// estimacion de la pared segun una temperatura
            listado["CntINTER"] = (((double)listado["EspesMaxCap"] - (double)listado["EspesMinCap"]) / (double)listado["VARIesp"]);
         
    
       
            var sisparcial = new Dictionary<String, object>();
            //TINTPP = TempVmax ' temperatura de trabajo en desgaste
            for (var hk = 1; hk <= ((double)listado["CntINTER"]); hk++)
            {
                if (hk == 1)
                    Spesor[0] = (double) listado["EspesMaxCap"]/1000;
                else
                    Spesor[0] = (Spesor[0]*1000 - (double) listado["VARIesp"])/1000;

                //Calculo
                sisparcial = SiSParcial(TINTPP, TAMP);
           

                if (((List<double>)sisparcial["TEXP"])[Materiales.Count] > TEXTERN + 1.5)
                {
                    listado.Add("Messages", "La temperatura externa estimada con el maximo de espesor es mayor que la temperatura externa indicada. La pared no cumple con sus requerimientos de estimación. ");
                    return listado;
                }

                if (Math.Abs(((List<double>)sisparcial["TEXP"])[Materiales.Count] - TEXTERN) <= (double)listado["DeltaMin"])
                {
                    if (((double)listado["EspesMaxCap"] - (Spesor[0]*1000)) <= 0)

                        listado.Add("Messages", "No hay desgaste significativo en la capa de trabajo.");
                      
                    else
                        listado.Add("Messages", "El espesor de la capa de trabajo es de: " + Spesor[0] * 1000 +
                                        " mm. El desgaste es de :" + ((double)listado["EspesMaxCap"] - (Spesor[0] * 1000)) +
                                        " mm para la temperatura externa de " + ((List<double>)sisparcial["TEXP"])[Materiales.Count] + " grados Celcius.");

                     
                    break;
                }
            }
            if (Math.Abs(((List<double>)sisparcial["TEXP"])[Materiales.Count] - TEXTERN) > (double)listado["DeltaMin"])
            {

                listado.Add("Messages", " La capa de material alcanzo su maximo desgaste con una temperaturatura exterior de: " + ((List<double>)sisparcial["TEXP"])[Materiales.Count] + " grados Celcius. La diferencia entre la temperatura externa de desgaste es de :" + Math.Abs(((List<double>)sisparcial["TEXP"])[Materiales.Count] - TEXTERN) + " grados Celcius.");
                return listado;
            }
            MessageBox.Show(listado["Messages"].ToString());
            listado.Add("TMTP", sisparcial["TMTP"]);
            listado.Add("TEXP", sisparcial["TEXP"]);
            return listado;
        }


        /// <summary>
        ///  Estimacion de la pared segun una temperatura
        /// </summary>
        /// <param name="TAMP"></param>
        /// <param name="TEXTERN"></param>
        /// <param name="Materiales"></param>
        /// <param name="SP"></param>
        /// <returns></returns>
        public Dictionary<String,object > EST_INTER_TEMP(double TAMP, int TEXTERN)
        {
            var listado = new Dictionary<String, object>()    {
                            {"VARIesp", 0.5},
                            {"EspesMinCap", 0.0},
                            {"EspesMaxCap", 200.0},
                            {"VARItempI", 0.5},
                            {"TempVmax", 0.0},
                            {"SSP", 0.0},
                            {"QPAR", 0.0},
                            {"ALFP", 0.0},
                            {"DeltaMin",1.0},
                              {"CntINTER",0.0}
                              ,{"TCRIT", new List<double>{1700.0}}
 

                        };
            bool planaex = true ;
            double CntINTER = 0.0,  TINTPP = 0.0; 
            listado["TempVmax"] = ((List<double>)listado["TCRIT"])[0];

            //// cantidad de intervalos de busqueda
            CntINTER = (( (double)listado["TempVmax"] - TEXTERN) /  (double) listado["VARItempI"]);

            if(planaex)
            Spesor[0] = (double)listado["EspesMaxCap"] / 1000;
     
            var sisparcial = new Dictionary<String, object>();
            for (var hk = 1; hk <= CntINTER; hk++)
            {
                //Application.DoEvents();
                TINTPP = TEXTERN + (hk * (double)listado["VARItempI"]);

               sisparcial= SiSParcial(TINTPP, TAMP);

                if ((bool)sisparcial["ERR_CAL"])
                    return listado;

                if (Math.Abs(((List<double>)sisparcial["TEXP"])[Materiales.Count] - TEXTERN) <= (double)listado["DeltaMin"])
                {
                    listado.Add("Messages", " La TEMPERATURA INTERNA estimada es de " + TINTPP + " grados Celcius para una temperatura externa de :" + ((List<double>)sisparcial["TEXP"])[Materiales.Count] + " grados Celcius.");
                    
                    break;
                }

            }

            

            if (TINTPP > ((List<double>)listado["TCRIT"])[0])
            {
                listado.Add("Messages", " La temperatura interna superó la temperatura de trabajo del material:" + ((List<double>)listado["TCRIT"])[0] + " grados Celcius.");
            return listado;
            }

            listado.Add("TMTP", sisparcial["TMTP"]);
            listado.Add("TEXP", sisparcial["TEXP"]);

            return listado;

        }



        /// <summary>
        /// Calculo de Estimacion de la conductividad termica para una capa.
        /// </summary>
        /// <param name="TINTPP"></param>
        /// <param name="TAMP"></param>
        /// <param name="TEXTERN"></param>
        /// <param name="CRPBuscar"></param>
        /// <param name="Materiales"></param>
        /// <param name="SP"></param>
        /// <returns></returns>
        public Dictionary<String, object > EST_LAMB_TEMP(double TINTPP, double TAMP, int TEXTERN, int CRPBuscar)
        {
            bool CLAVEP;
            
            var listado = new Dictionary<String, object> { {"ALFP", 0.0} ,{"QPAR",0.0},{"SSP",0.0},{"TMTP", new List<double>()},
                            {"LP", new List<double>{0,0,0,0}},
                            {"TEXP", new List<double>()},
                            {"TMTPC", new List<double>()},
                            {"TEXP_E", new List<double>()},
                            
            };
            int INF_SLIR;
            bool ERR_CAL;
            double Exilo = 0, SBolfman = 0, QCONV = 0, QRAD = 0, RRT = 0, SSPo = 0, Qperm = 0, QPART;
            
            SBolfman = 5.6704 * (Math.Pow(10, (-8)));
            Exilo = 0.8;
            QRAD = 0;
            QCONV = 0;
           
            var formula =
                  Materiales.Select(t =>DSRD.T_FormulaRow.GetStringSeparated(t.GetT_FormulaRows()[2].mi)).ToList();
            ClearList(formula);

            if (TEXTERN > 600)
                QRAD = SBolfman*Exilo*((Math.Pow((TEXTERN + 273.16), 4)) - (Math.Pow((TAMP + 273.16), 4)));
            else
            {
                listado["ALFP"] = 1.842*(Math.Pow((TEXTERN - TAMP), 0.56));

                QCONV = (double) listado["ALFP"]*(TEXTERN - TAMP);
            }
            // calor total
            
            QPART = QRAD + QCONV;
            // presicion para el flujo
            Qperm = 0.5;

            //TEMP MEDIA ESTIMADA POR CAPA --> primera estimacion
            double EstimaT = 0;
            EstimaT = (TINTPP - TEXTERN) / Materiales.Count;
            for (int ZP = 1; ZP <= Materiales.Count; ZP++)
                AddList((List<double>) listado["TMTP"], ZP, TINTPP - ((EstimaT*ZP) - (EstimaT/2)));

            do
            {

                Lamda((List<double>) listado["LP"], (List<double>) listado["TMTP"], formula, CRPBuscar);

                RRT = (TINTPP - TAMP) / QPART;

                listado["SSP"] = RRT - (1 / (double)listado["ALFP"]);
                SSPo = 0;

                for (int XP = 1; XP <= Materiales.Count; XP++)
                {
                    if (XP != CRPBuscar)
                        SSPo += Spesor[XP - 1] / ((List<double >)listado["LP"])[XP];
                }



                ((List<double>)listado["LP"])[CRPBuscar] = Spesor[CRPBuscar - 1] / ((double)listado["SSP"] - SSPo);

                if (((List<double>)listado["LP"])[CRPBuscar] < 0)
                    ((List<double>)listado["LP"])[CRPBuscar] = 1E-07;

                listado["SSP"] = 0.0;
                for (int XP1 = 1; XP1 <= Materiales.Count; XP1++)
                {
                    listado["SSP"] = (double)listado["SSP"] + Spesor[XP1 - 1] / ((List<double>)listado["LP"])[XP1];
                    AddList((List<double>) listado["TEXP"], XP1, TINTPP - (QPART * (double)listado["SSP"]));
                }

                for (int ZP2 = 1; ZP2 <= Materiales.Count; ZP2++)
                {
                    if (ZP2 == 1)
                    {
                        AddList(((List<double>)listado["TMTPC"]), ZP2, (((List<double>)listado["TEXP"])[ZP2-1] + TINTPP) / 2);
                    }
                    else
                    {
                        AddList(((List<double>)listado["TMTPC"]), ZP2, (((List<double>)listado["TEXP"])[ZP2-1] + ((List<double>)listado["TEXP"])[ZP2 - 2]) / 2);
                    }
                }

                CLAVEP = true;
                for (var ZP3 = 1; ZP3 <= Materiales.Count; ZP3++)
                {
                    if (Math.Abs((((List<double>)listado["TMTP"])[ZP3-1] - ((List<double>)listado["TMTPC"])[ZP3-1])) > 0.5)
                    {
                        CLAVEP = false;
                        break;
                    }
                }

                listado["QPAR"] = (TINTPP - TAMP) / ((double)listado["SSP"] + (1 / (double)listado["ALFP"]));

                if (Math.Abs((double)listado["QPAR"] - QPART) > Qperm)
                    CLAVEP = false;
                QPART = (QPART + (double) listado["QPAR"]) / 2;

                if (CLAVEP == false)
                {
                   // ((List<double>) listado["TMTP"])[0] = 0;
                    for (int ZP4 = 1; ZP4 <= Materiales.Count; ZP4++)
                    {
                        AddList((List<double>)listado["TMTP"], (ZP4-1), (((List<double>)listado["TMTPC"])[ZP4-1] + ((List<double>)listado["TMTP"])[ZP4-1]) / 2);
                    }
                }

            } while (!CLAVEP );
        //    MessageBox.Show("La conductividad térmica de la capa es: " + ((List<double>)listado["LP"])[CRPBuscar] + " W/m oC, el flujo calorico es de : " + QPART + " W/m^2. ");

            listado["SSP"] = 0.0;
            for (int XP3 = 1; XP3 <= Materiales.Count; XP3++)
                listado["SSP"] = (double) listado["SSP"] + Spesor[XP3-1];

            return listado;
        }

        public List<DSRD.T_MaterialRow> Materiales { get { return _materiales; } }
        public List<double> Spesor { get { return _spesor; } }

        public DSRD TDataSet
        {
            get;
            set;
        }
    }
}
