using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Charts.Native;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraVerticalGrid;
using MCC;
using MCC.Codificadores;

using DevExpress.XtraVerticalGrid.Rows;
using TMC.BCE;
using TMC.BCE.DSBCETableAdapters;

namespace MCC
{


    public class BCEAlgorithms2
    {


        public double EnergReacQuimicas(int i, int k)
        {
            return 0;

        }

        private DSBCE dsbce = new DSBCE();
        private Dictionary<String, double> GenerateList(List<String> list, String name, Dictionary<String, double> General, Dictionary<String, double> Metal, Dictionary<String, double> Carga, int i, Dictionary<String, double> anterior = null)
        {
            var r = new Dictionary<String, double>();
            foreach (string s in list)
            {
                double w = 0;
                if (i == 0)

                    w = Carga[s] * General["BaseAcero"] / Metal["AcLiquido"];

                else if (i == 1)
                    w = Metal[s] * General["BaseAcero"] / 100;
                else
                    w = anterior[s + "ACL"] * dsbce.Q_ElementosProject.SearchCarga(name, s, "Metalica");




                r.Add(s + name, w);
            }
            return r;
        }
        public Dictionary<String, double> Escoria_Segun_Carga_Metal(int idproject, Dictionary<String, double> General, Dictionary<String, double> Metal, Dictionary<String, double> Carga)
        {
            var r = new Dictionary<String, double>();
            dsbce = new DSBCE();
            var elemtableapapter = new Q_ElementosProjectTableAdapter();
            elemtableapapter.Fill(dsbce.Q_ElementosProject, idproject);
            var ind = new T_Indice_ConsumoTableAdapter();
            ind.Fill(dsbce.T_Indice_Consumo);
            var Cargas = new List<String>();
            Cargas.Add("HBI");
            Cargas.Add("ChatarraLigera");
            Cargas.Add("Escarpa");
            Cargas.Add("HierroFundido");
            Cargas.Add("ChatarraPesada");
            Cargas.Add("Paca");
            Cargas.Add("PieLiquido");
            Cargas.Add("HRD");
            var Elementos = new List<String>();
            Elementos.Add("C");
            Elementos.Add("Mn");
            Elementos.Add("Si");
            Elementos.Add("P");
            Elementos.Add("S");
            Elementos.Add("Fe");
            Elementos.Add("Al");
            Elementos.Add("Ni");
            Elementos.Add("Cr");
            Elementos.Add("Cu");
            var Oxigeno_EficInyectado = 0.0;
            var Fe_Metal = 100 -
                           (Metal["Si"] + Metal["Al"] + Metal["Mn_Metal"] + Metal["P"] + Metal["S"] + Metal["Cr"] +
                            Metal["C"]);

            var Carga_Acl = GenerateList(Cargas, "ACL", General, Metal, Carga, 0);

            ////  kg / ton Ac liq
            //var HBI_AcL =            (Carga["HBI"]*General["BaseAcero"]/Metal["AcLiquido"]);
            //var ChatarraLigera_AcL = (Carga["ChatarraLigera"]*General["BaseAcero"]/Metal["AcLiquido"]);
            //var Escarpa_AcL =        (Carga["Escarpa"]*General["BaseAcero"]/Metal["AcLiquido"]);
            //var HierroFundido_AcL =  (Carga["HierroFundido"]*General["BaseAcero"]/Metal["AcLiquido"]);
            //var ChatarraPesada_AcL = (Carga["ChatarraPesada"]*General["BaseAcero"]/Metal["AcLiquido"]);
            //var Paca_AcL =           (Carga["Paca"]*General["BaseAcero"]/Metal["AcLiquido"]);
            //var PieLiquido_AcL =     (Carga["PieLiquido"]*General["BaseAcero"]/Metal["AcLiquido"]);
            //var HRD_AcL =            (Carga["HRD"]*General["BaseAcero"]/Metal["AcLiquido"]);
            //var Tot_Carga_enT = Carga["HBI"] + Carga["ChatarraLigera"] + Carga["Escarpa"] + Carga["HierroFundido"] +
            //                    Carga["ChatarraPesada"] +
            //                    Carga["Paca"] + Carga["PieLiquido"] + Carga["HRD"];

            var Tot_Carga = Carga_Acl.Sum(t => t.Value);

            var MetalACL = GenerateList(Elementos, "Acl", General, Metal, Carga, 1);


            //var C_AcL = (Metal["C"]*General["BaseAcero"]/100);
            //var Mn_AcL = (Metal["Mn"]*General["BaseAcero"]/100);
            //var Si_AcL = (Metal["Si"]*General["BaseAcero"]/100);
            //var P_AcL = (Metal["P"]*General["BaseAcero"]/100);
            //var S_AcL = (Metal["S"]*General["BaseAcero"]/100);
            //var Fe_AcL = (Metal["Fe"]*General["BaseAcero"]/100);
            //var Al_AcL = (Metal["Al"]*General["BaseAcero"]/100);
            //var Ni_AcL = (Metal["Ni"]*General["BaseAcero"]/100);
            //var Cr_AcL = (Metal["Cr"]*General["BaseAcero"]/100);
            //var Cu_AcL = (Metal["Cu"]*General["BaseAcero"]/100);


            if (Metal["Fe_AcL"] <= 0)
                Metal["Fe_AcL"] = 100 - MetalACL.Sum(t => t.Value) - Metal["Fe_AcL"];
            else
                Metal["Fe_AcL"] = (Fe_Metal * General["BaseAcero"]) / 100;

            var res = new Dictionary<String, Dictionary<String, double>>();
            foreach (string elemento in Elementos)
                res.Add(elemento, GenerateList(Cargas, elemento, General, Metal, Carga, 2, Carga_Acl));


            //var C_Carga = GenerateList(Cargas, "C", General, Metal, Carga, 2,Carga_Acl);
            ////var C_HBI = (HBI_AcL*dsbce.Q_ElementosProject.SearchCarga("C", "HBI", "Metalica"));
            ////var C_ChatarraLigera = (ChatarraLigera_AcL*
            ////                        dsbce.Q_ElementosProject.SearchCarga("C", "ChatarraLigera", "Metalica"));
            ////var C_Escarpa = (Escarpa_AcL*dsbce.Q_ElementosProject.SearchCarga("C", "Escarpa", "Metalica"));
            ////var C_HierroFundido = (HierroFundido_AcL*
            ////                       dsbce.Q_ElementosProject.SearchCarga("C", "HierroFundido", "Metalica"));
            ////var C_ChatarraPesada = (ChatarraPesada_AcL*
            ////                        dsbce.Q_ElementosProject.SearchCarga("C", "ChatarraPesada", "Metalica"));
            ////var C_Paca = (Paca_AcL*dsbce.Q_ElementosProject.SearchCarga("C", "Paca", "Metalica"))/100;
            ////var C_PieLiquido = (PieLiquido_AcL*dsbce.Q_ElementosProject.SearchCarga("C", "PieLiquido", "Metalica"));
            ////var C_HRD = (HRD_AcL*dsbce.Q_ElementosProject.SearchCarga("C", "7777", "Metalica"));

            //////   '' total en kg/ton ac liq

            //var C_Total = C_Carga.Sum(t=>t.Value);
            //var C_TotalPociento = (C_Total / Tot_Carga) * 100;

            //var Mn_Carga = GenerateList(Cargas, "Mn", General, Metal, Carga, 2, Carga_Acl);




            ////var Mn_HBI = (HBI_AcL * dsbce.Q_ElementosProject.SearchCarga("Mn", "HBI", "Metalica"));
            ////var Mn_ChatarraLigera = (ChatarraLigera_AcL * dsbce.Q_ElementosProject.SearchCarga("Mn", "ChatarraLigera", "Metalica"));
            ////var Mn_Escarpa = (Escarpa_AcL * dsbce.Q_ElementosProject.SearchCarga("Mn", "Escarpa", "Metalica"));
            ////var Mn_HierroFundido = (HierroFundido_AcL * dsbce.Q_ElementosProject.SearchCarga("Mn", "HierroFundido", "Metalica"));
            ////var Mn_ChatarraPesada = (ChatarraPesada_AcL * dsbce.Q_ElementosProject.SearchCarga("Mn", "ChatarraPesada", "Metalica"));
            ////var Mn_Paca = (Paca_AcL * dsbce.Q_ElementosProject.SearchCarga("Mn", "Paca", "Metalica"));
            ////var Mn_PieLiquido = (PieLiquido_AcL * dsbce.Q_ElementosProject.SearchCarga("Mn", "PieLiquido", "Metalica"));
            ////var Mn_HRD = (HRD_AcL * dsbce.Q_ElementosProject.SearchCarga("Mn", "777777777", "Metalica"));

            //////   '' total en kg/ton ac liq
            //var Mn_Total = Mn_Carga.Sum(t => t.Value);
            //var Mn_TotalPociento = (Mn_Total / Tot_Carga) * 100;


            ////var Peso_Cal = 0.0;
            ////var Peso_Carbon = 0.0;
            ////var Peso_Dolomita = 0.0;
            //////    ''' SILICIO en %
            //////v   Dim Si_HBI As Single, Si_ChatarraLigera As Single, Si_Escarpa As Single, Si_HierroFundido As Single, Si_ChatarraPesada As Single, Si_Paca As Single, Si_PieLiquido As Single, Si_HRD As Single
            //////   Dim Si_Total As Single, Si_TotalPociento As Single

            //var SI_Carga = GenerateList(Cargas, "Si", General, Metal, Carga, 2, Carga_Acl);

            ////var Si_HBI = (HBI_AcL * dsbce.Q_ElementosProject.SearchCarga("Si", "HBI", "Metalica"));
            ////var Si_ChatarraLigera = (ChatarraLigera_AcL * dsbce.Q_ElementosProject.SearchCarga("Si", "ChatarraLigera", "Metalica"));
            ////var Si_Escarpa = (Escarpa_AcL * dsbce.Q_ElementosProject.SearchCarga("Si", "Escarpa", "Metalica"));
            ////var Si_HierroFundido = (HierroFundido_AcL * dsbce.Q_ElementosProject.SearchCarga("Si", "HierroFundido", "Metalica"));
            ////var Si_ChatarraPesada = (ChatarraPesada_AcL * dsbce.Q_ElementosProject.SearchCarga("Si", "ChatarraPesada", "Metalica"));
            ////var Si_Paca = (Paca_AcL * dsbce.Q_ElementosProject.SearchCarga("Si", "Paca", "Metalica"));
            ////var Si_PieLiquido = (PieLiquido_AcL * dsbce.Q_ElementosProject.SearchCarga("Si", "PieLiquido", "Metalica"));
            ////var Si_HRD = (HRD_AcL * dsbce.Q_ElementosProject.SearchCarga("Si", "7", "Metalica"));

            //////   '' total en kg/ton ac liq
            //var Si_Total = SI_Carga.Sum(t=>t.Value);
            //var Si_TotalPociento = (Si_Total / Tot_Carga) * 100;



            //////    ''' FOSFORO en %
            //////    Dim P_HBI As Single, P_ChatarraLigera As Single, P_Escarpa As Single, P_HierroFundido As Single, P_ChatarraPesada As Single, P_Paca As Single, P_PieLiquido As Single, P_HRD As Single
            //////    Dim P_Total As Single, P_TotalPociento As Single
            //var P_Carga = GenerateList(Cargas, "P", General, Metal, Carga, 2, Carga_Acl);

            ////var P_HBI = (HBI_AcL * dsbce.Q_ElementosProject.SearchCarga("P", "HBI", "Metalica"));
            ////var P_ChatarraLigera = (ChatarraLigera_AcL * dsbce.Q_ElementosProject.SearchCarga("P", "", "Metalica"));
            ////var P_Escarpa = (Escarpa_AcL * dsbce.Q_ElementosProject.SearchCarga("P", 2, "Metalica"));
            ////var P_HierroFundido = (HierroFundido_AcL * dsbce.Q_ElementosProject.SearchCarga("P", 3, "Metalica"));
            ////var P_ChatarraPesada = (ChatarraPesada_AcL * dsbce.Q_ElementosProject.SearchCarga("P", 4, "Metalica"));
            ////var P_Paca = (Paca_AcL * dsbce.Q_ElementosProject.SearchCarga("P", 5, "Metalica"));
            ////var P_PieLiquido = (PieLiquido_AcL * dsbce.Q_ElementosProject.SearchCarga("P", 6, "Metalica"));
            ////var P_HRD = (HRD_AcL * dsbce.Q_ElementosProject.SearchCarga("P", 7, "Metalica"));

            //////    '' total en kg/ton ac liq
            //var P_Total = P_Carga.Sum(t=>t.Value);
            //var P_TotalPociento = (P_Total / Tot_Carga) * 100;




            //////''' ASUFRE en %
            //////Dim S_HBI As Single, S_ChatarraLigera As Single, S_Escarpa As Single, S_HierroFundido As Single, S_ChatarraPesada As Single, S_Paca As Single, S_PieLiquido As Single, S_HRD As Single
            //////Dim S_Total As Single, S_TotalPociento As Single
            //var S_Carga = GenerateList(Cargas, "S", General, Metal, Carga, 2, Carga_Acl);

            ////var S_HBI = (HBI_AcL*CargaMetalica("S", 0));
            ////var S_ChatarraLigera = (ChatarraLigera_AcL*CargaMetalica("S", 1));
            ////var S_Escarpa = (Escarpa_AcL*CargaMetalica("S", 2));
            ////var S_HierroFundido = (HierroFundido_AcL*CargaMetalica("S", 3));
            ////var S_ChatarraPesada = (ChatarraPesada_AcL*CargaMetalica("S", 4));
            ////var S_Paca = (Paca_AcL*CargaMetalica("S", 5));
            ////var S_PieLiquido = (PieLiquido_AcL*CargaMetalica("S", 6));
            ////var S_HRD = (HRD_AcL*CargaMetalica("S", 7));

            //////'' total en kg/ton ac liq
            //var S_Total = S_Carga.Sum(t=>t.Value);
            //var S_TotalPociento = (S_Total / Tot_Carga) * 100;




            //////''' HIERRO en  kg/ton ac liq
            //////Dim Fe_HBI As Single, Fe_ChatarraLigera As Single, Fe_Escarpa As Single, Fe_HierroFundido As Single, Fe_ChatarraPesada As Single, Fe_Paca As Single, Fe_PieLiquido As Single, Fe_HRD As Single
            //////Dim Fe_Total As Single, Fe_TotalPociento As Single
            //var Fe_Carga = GenerateList(Cargas, "Fe", General, Metal, Carga, 2, Carga_Acl);

            ////var Fe_HBI = (HBI_AcL*CargaMetalica("FeT", 0));
            ////var Fe_ChatarraLigera = (ChatarraLigera_AcL*CargaMetalica("FeT", 1));
            ////var Fe_Escarpa = (Escarpa_AcL*CargaMetalica("FeT", 2));
            ////var Fe_HierroFundido = (HierroFundido_AcL*CargaMetalica("FeT", 3));
            ////var Fe_ChatarraPesada = (ChatarraPesada_AcL*CargaMetalica("FeT", 4));
            ////var Fe_Paca = (Paca_AcL*CargaMetalica("FeT", 5));
            ////var Fe_PieLiquido = (PieLiquido_AcL*CargaMetalica("FeT", 6));
            ////var Fe_HRD = (HRD_AcL*CargaMetalica("FeT", 7));

            //////'' total en kg/ton ac liq
            //var Fe_Total = Fe_Carga.Sum(t=>t.Value);
            //var Fe_TotalPociento = (Fe_Total / Tot_Carga) * 100;




            //////''' ALUMINIO en kg/ton ac liq
            //////Dim Al_HBI As Single, Al_ChatarraLigera As Single, Al_Escarpa As Single, Al_HierroFundido As Single, Al_ChatarraPesada As Single, Al_Paca As Single, Al_PieLiquido As Single, Al_HRD As Single
            //////Dim Al_Total As Single, Al_TotalPociento As Single
            //var Al_Carga = GenerateList(Cargas, "Al", General, Metal, Carga, 2, Carga_Acl);

            ////var Al_HBI = (HBI_AcL * dsbce.Q_ElementosProject.SearchCarga("Al", 0));
            ////var Al_ChatarraLigera = (ChatarraLigera_AcL * dsbce.Q_ElementosProject.SearchCarga("Al", 1));
            ////var Al_Escarpa = (Escarpa_AcL * dsbce.Q_ElementosProject.SearchCarga("Al", 2));
            ////var Al_HierroFundido = (HierroFundido_AcL * dsbce.Q_ElementosProject.SearchCarga("Al", 3));
            ////var Al_ChatarraPesada = (ChatarraPesada_AcL * dsbce.Q_ElementosProject.SearchCarga("Al", 4));
            ////var Al_Paca = (Paca_AcL * dsbce.Q_ElementosProject.SearchCarga("Al", 5));
            ////var Al_PieLiquido = (PieLiquido_AcL * dsbce.Q_ElementosProject.SearchCarga("Al", 6));
            ////var Al_HRD = (HRD_AcL * dsbce.Q_ElementosProject.SearchCarga("Al", 7));

            //////'' total en kg/ton ac liq
            //var Al_Total = Al_HBI + Al_ChatarraLigera + Al_Escarpa + Al_HierroFundido + Al_ChatarraPesada + Al_Paca +
            //               Al_PieLiquido + Al_HRD;
            //var Al_TotalPociento = (Al_Total / Tot_Carga) * 100;






            //////''' NIQUE enkg/ton ac liq
            //////Dim Ni_HBI As Single, Ni_ChatarraLigera As Single, Ni_Escarpa As Single, Ni_HierroFundido As Single, Ni_ChatarraPesada As Single, Ni_Paca As Single, Ni_PieLiquido As Single, Ni_HRD As Single
            //////Dim Ni_Total As Single, Ni_TotalPociento As Single
            //var Ni_Carga = GenerateList(Cargas, "Ni", General, Metal, Carga, 2, Carga_Acl);

            ////var Ni_HBI = (HBI_AcL*CargaMetalica("Ni", 0));
            ////var Ni_ChatarraLigera = (ChatarraLigera_AcL*CargaMetalica("Ni", 1));
            ////var Ni_Escarpa = (Escarpa_AcL*CargaMetalica("Ni", 2));
            ////var Ni_HierroFundido = (HierroFundido_AcL*CargaMetalica("Ni", 3));
            ////var Ni_ChatarraPesada = (ChatarraPesada_AcL*CargaMetalica("Ni", 4));
            ////var Ni_Paca = (Paca_AcL*CargaMetalica("Ni", 5));
            ////var Ni_PieLiquido = (PieLiquido_AcL*CargaMetalica("Ni", 6));
            ////;
            ////var Ni_HRD = (HRD_AcL*CargaMetalica("Ni", 7));

            //////'' total en kg/ton ac liq
            ////var Ni_Total = Ni_HBI + Ni_ChatarraLigera + Ni_Escarpa + Ni_HierroFundido + Ni_ChatarraPesada + Ni_Paca +
            ////               Ni_PieLiquido + Ni_HRD;
            ////var Ni_TotalPociento = (Ni_Total/Tot_Carga)*100;




            //////''' CROMO en kg/ton ac liq
            //////Dim Cr_HBI As Single, Cr_ChatarraLigera As Single, Cr_Escarpa As Single, Cr_HierroFundido As Single, Cr_ChatarraPesada As Single, Cr_Paca As Single, Cr_PieLiquido As Single, Cr_HRD As Single
            //////Dim Cr_Total As Single, Cr_TotalPociento As Single

            ////var Cr_HBI = (HBI_AcL*CargaMetalica("Cr", 0));
            ////var Cr_ChatarraLigera = (ChatarraLigera_AcL*CargaMetalica("Cr", 1));
            ////var Cr_Escarpa = (Escarpa_AcL*CargaMetalica("Cr", 2));
            ////var Cr_HierroFundido = (HierroFundido_AcL*CargaMetalica("Cr", 3));
            ////var Cr_ChatarraPesada = (ChatarraPesada_AcL*CargaMetalica("Cr", 4));
            ////var Cr_Paca = (Paca_AcL*CargaMetalica("Cr", 5));
            ////var Cr_PieLiquido = (PieLiquido_AcL*CargaMetalica("Cr", 6));
            ////var Cr_HRD = (HRD_AcL*CargaMetalica("Cr", 7));

            //////'' total en kg/ton ac liq
            ////var Cr_Total = Cr_HBI + Cr_ChatarraLigera + Cr_Escarpa + Cr_HierroFundido + Cr_ChatarraPesada + Cr_Paca +
            ////               Cr_PieLiquido + Cr_HRD;
            ////var Cr_TotalPociento = (Cr_Total/Tot_Carga)*100;




            //////''' COBRE en kg/ton ac liq
            //////Dim Cu_HBI As Single, Cu_ChatarraLigera As Single, Cu_Escarpa As Single, Cu_HierroFundido As Single, Cu_ChatarraPesada As Single, Cu_Paca As Single, Cu_PieLiquido As Single, Cu_HRD As Single
            //////Dim Cu_Total As Single, Cu_TotalPociento As Single

            ////var Cu_HBI = (HBI_AcL*CargaMetalica("Cu", 0));
            ////var Cu_ChatarraLigera = (ChatarraLigera_AcL*CargaMetalica("Cu", 1));
            ////var Cu_Escarpa = (Escarpa_AcL*CargaMetalica("Cu", 2));
            ////var Cu_HierroFundido = (HierroFundido_AcL*CargaMetalica("Cu", 3));
            ////var Cu_ChatarraPesada = (ChatarraPesada_AcL*CargaMetalica("Cu", 4));
            ////var Cu_Paca = (Paca_AcL*CargaMetalica("Cu", 5));
            ////var Cu_PieLiquido = (PieLiquido_AcL*CargaMetalica("Cu", 6));
            ////var Cu_HRD = (HRD_AcL*CargaMetalica("Cu", 7));

            //////'' total en kg/ton ac liq
            ////var Cu_Total = Cu_HBI + Cu_ChatarraLigera + Cu_Escarpa + Cu_HierroFundido + Cu_ChatarraPesada + Cu_Paca +
            ////               Cu_PieLiquido + Cu_HRD;
            ////var Cu_TotalPociento = (Cu_Total/Tot_Carga)*100;





            ////'''  Calcular perdidas por elementos ***********************************
            ////Dim C_Perdida As Single, Mn_Perdida As Single, Si_Perdida As Single, P_Perdida As Single, S_Perdida As Single, Fe_Perdida As Single
            ////Dim Al_Perdida As Single, Ni_Perdida As Single, Cr_Perdida As Single, Cu_Perdida As Single
            ////Dim Fe_Escoria As Single
            ////Dim C_PorcPerdida As Single, Mn_PorcPerdida As Single, Si_PorcPerdida As Single, P_PorcPerdida As Single, S_PorcPerdida As Single, Fe_PorcPerdida As Single
            ////Dim Al_PorcPerdida As Single, Ni_PorcPerdida As Single, Cr_PorcPerdida As Single, Cu_PorcPerdida As Single
            var Perdida = new Dictionary<String, double>();
            var PerdidaP = new Dictionary<String, double>();
            for (int index = 0; index < Elementos.Count; index++)
            {
                string elemento = Elementos[index];
                var tot = res[elemento].Sum(t => t.Value);
                var m = res[elemento][elemento];
                Perdida.Add(elemento, tot - m);
                PerdidaP.Add(elemento, (tot - m) / tot * 100);
            }

            ////'' en kg/TAL ''' tambien son los ELEMENTOS OXIDADOS******************************
            //var C_Perdida = C_Total - C_AcL;
            //var Mn_Perdida = Mn_Total - Mn_AcL;
            //var Si_Perdida = Si_Total - Si_AcL;
            //var P_Perdida = P_Total - P_AcL;
            //var S_Perdida = S_Total - S_AcL;
            //var Fe_Perdida = Fe_Total - Fe_AcL;
            var Fe_Escoria = (res["Fe"].Sum(t => t.Value) - Carga_Acl["Fe"]) * 0.15;
            //var Al_Perdida = Al_Total - Al_AcL;
            //var Ni_Perdida = Ni_Total - Ni_AcL;
            //var Cr_Perdida = Cr_Total - Cr_AcL;
            //var Cu_Perdida = Cu_Total - Cu_AcL;

            ////'' en %
            //var C_PorcPerdida = (C_Perdida/C_Total)*100;
            //var Mn_PorcPerdida = (Mn_Perdida/Mn_Total)*100;
            //var Si_PorcPerdida = (Si_Perdida/Si_Total)*100;
            //var P_PorcPerdida = (P_Perdida/P_Total)*100;
            //var S_PorcPerdida = (S_Perdida/S_Total)*100;
            //var Fe_PorcPerdida = (Fe_Perdida/Fe_Total)*100;
            //var Al_PorcPerdida = (Al_Perdida/Al_Total)*100;
            //var Ni_PorcPerdida = (Ni_Perdida/Ni_Total)*100;
            //var Cr_PorcPerdida = (Cr_Perdida/Cr_Total)*100;
            //var Cu_PorcPerdida = (Cu_Perdida/Cu_Total)*100;

            ////''' CALCULO DEL HIERRO QUE VA A LA ESCORIA
            ////''' ???????????????????????????????????????????????????????????????????????????????????????

            ////'''POLVOS DE HIERRO A LOS GASES
            ////Dim Fe_HBI_Polvo As Single, Fe_ChatarraLigera_Polvo As Single, Fe_Escarpa_Polvo As Single
            ////Dim Fe_HierroFundido_Polvo As Single, Fe_ChatarraPesada_Polvo As Single, Fe_Paca_Polvo As Single, Fe_HRD_Polvo As Single
            var Polvo = GenerateList(Cargas, "Fe", General, Metal, Carga, 2, res["Fe"]);
            //var Fe_HBI_Polvo = (Fe_HBI*CargaMetalica("PolvoFe", 0));
            //var Fe_ChatarraLigera_Polvo = (Fe_ChatarraLigera*CargaMetalica("PolvoFe", 1));
            //var Fe_Escarpa_Polvo = (Fe_Escarpa*CargaMetalica("PolvoFe", 2));
            //var Fe_HierroFundido_Polvo = (Fe_HierroFundido*CargaMetalica("PolvoFe", 3));
            //var Fe_ChatarraPesada_Polvo = (Fe_ChatarraPesada*CargaMetalica("PolvoFe", 4));
            //var Fe_Paca_Polvo = (Fe_Paca*CargaMetalica("PolvoFe", 5));
            //var Fe_HRD_Polvo = (Fe_HRD*CargaMetalica("PolvoFe", 7));

            ////'''total polvo
            ////Dim Tot_Fe_Polvo As Single, Fe_Total2 As Single, Tot_Fe_PolvoPorciento As Single, Total_FeOxidoPolvo As Single
            ////Dim Total_FeO_PolvoPorciento As Single, Total_FeOoxigenoPolvo As Single
            ////'' fe total en polvo sin pie liquido
            var Tot_Fe_Polvo = Polvo.Sum(t => t.Value);
            ////'' para calculo auxiliar
            var Fe_Total2 = res["Fe"].Sum(t => t.Value);
            //'' porciento de fe en polvos
            var Tot_Fe_PolvoPorciento = (Tot_Fe_Polvo / Fe_Total2) * 100;
            //'' oxido de fe formado
            var Total_FeOxidoPolvo = Tot_Fe_Polvo * (dsbce.Q_ElementosProject.SearchCarga("FeO", "PesoMolecular", "Oxidos") * dsbce.Q_ElementosProject.SearchCarga("FeO", "PesoAtomico", "Oxidos"));
            //'//''' Porciento de oxido de herro en polvo
            var Total_FeO_PolvoPorciento = (Total_FeOxidoPolvo / Perdida["Fe"]) * 100;
            //'//'' oxigeno requerido para el oxido de fe en polvo
            var Total_FeOoxigenoPolvo = Total_FeOxidoPolvo - Tot_Fe_Polvo;


            var oxidos = new Dictionary<String, String>();
            oxidos.Add("MnO", "Mn");
            oxidos.Add("SiO2", "Si");
            oxidos.Add("P2O5", "P");
            oxidos.Add("FeO", "Fe");
            oxidos.Add("Al2O3", "Al");
            oxidos.Add("Cr203", "Cr");
            var oxidosformados = new Dictionary<String, double>();
            var oxidosrequeridos = new Dictionary<String, double>();
            foreach (KeyValuePair<string, string> keyValuePair in oxidos)
            {
                var p1 = 0.0;
                var p2 = 0.0;
                if (keyValuePair.Key == "Fe0")
                {
                    p1 = Fe_Escoria;
                    p2 = (dsbce.Q_ElementosProject.SearchCarga(keyValuePair.Key, "PesoMolecular", "Oxidos") /
                          dsbce.Q_ElementosProject.SearchCarga(keyValuePair.Key, "PesoAtomico", "Oxidos"));
                }
                else
                {
                    p1 = Perdida[keyValuePair.Value];
                    if (keyValuePair.Key == "Mn0" || keyValuePair.Key == "Si02")
                        p2 = (dsbce.Q_ElementosProject.SearchCarga(keyValuePair.Key, "PesoMolecular", "Oxidos") /
                             dsbce.Q_ElementosProject.SearchCarga(keyValuePair.Key, "PesoAtomico", "Oxidos"));
                    else
                        p2 = (dsbce.Q_ElementosProject.SearchCarga(keyValuePair.Key, "PesoMolecular", "Oxidos") /
         dsbce.Q_ElementosProject.SearchCarga(keyValuePair.Key, "PesoAtomico", "Oxidos")) * 2;
                }
                oxidosformados.Add(keyValuePair.Key, p1 * p2);
                oxidosrequeridos.Add(keyValuePair.Key, p1 * p2 - p1);
            }


            ////'''' OXIDOS FORMADOS que van a la escoria kg/TAL
            ////Dim MnO As Single
            //var MnO = Mn_Perdida*(OxidoRelacEsteq("MnO", 1)/OxidoRelacEsteq("MnO", 0));

            ////Dim SiO2 As Single
            //var SiO2 = Si_Perdida*(OxidoRelacEsteq("SiO2", 1)/OxidoRelacEsteq("SiO2", 0));

            ////Dim P2O5 As Single
            //var P2O5 = P_Perdida*(OxidoRelacEsteq("P2O5", 1)/(OxidoRelacEsteq("P2O5", 0)*2));

            ////Dim FeO As Single
            //var FeO = Fe_Escoria*(OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0));

            //var //Dim Al2O3 As Single
            //    Al2O3 = Al_Perdida*(OxidoRelacEsteq("Al2O3", 1)/(OxidoRelacEsteq("Al2O3", 0)*2));

            ////Dim Cr2O3 As Single
            //var Cr2O3 = Cr_Perdida*(OxidoRelacEsteq("Cr2O3", 1)/(OxidoRelacEsteq("Cr2O3", 0)*2));




            ////''' CALCULO DEL OXIGENO REQUERIDO
            ////Dim MnO_OReq As Single
            //var MnO_OReq = MnO - Mn_Perdida;

            ////Dim SiO2_OReq As Single
            //var SiO2_OReq = SiO2 - Si_Perdida;

            ////Dim P2O5_OReq As Single
            //var P2O5_OReq = P2O5 - P_Perdida;

            ////Dim FeO_OReq As Single
            //var FeO_OReq = FeO - Fe_Escoria;

            ////Dim Al2O3_OReq As Single
            //var Al2O3_OReq = Al2O3 - Al_Perdida;

            ////Dim Cr2O3_OReq As Single
            //var Cr2O3_OReq = Cr2O3 - Cr_Perdida;


            ////'''' CALCULO DE LA COMPOSICION DE LA ESCORIA
            ////'Dim Al2O3_Esc As Single, FeO_Esc As Single, S_Esc As Single, Cr2O3_Esc As Single
            ////'Dim CaO_Esc As Single, MgO_Esc As Single, C_Esc As Single

            //var MnO_Esc = MnO +
            //              OxidosDeCargas("MnO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                             ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //var SiO2_Esc = SiO2 +
            //               OxidosDeCargas("SiO2", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                              ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //var P2O5_Esc = P2O5 +
            //               OxidosDeCargas("P2O5", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                              ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //var CaO_Esc = OxidosDeCargas("CaO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                             ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //var MgO_Esc = OxidosDeCargas("MgO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                             ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //var Al2O3_Esc = Al2O3 +
            //                OxidosDeCargas("Al2O3", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                               ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //var Cr2O3_Esc = Cr2O3 +
            //                OxidosDeCargas("Cr2O3", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                               ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //var FeO_Esc = FeO +
            //              OxidosDeCargas("FeO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                             ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //var S_Esc = S_Perdida;

            //var Otros_Esc = OxidosDeCargas("Otros", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                               ChatarraPesada_AcL, Paca_AcL, HRD_AcL);


            ////'''DETERMINACION DE PERDIDAS POR IGNICION ( CALCINACION )
            ////Dim HBI_Ignicion As Single, ChatarraLigera_Ignicion As Single, Escarpa_Ignicion As Single
            ////Dim HierroFundido_Ignicion As Single, ChatarraPesada_Ignicion As Single, Paca_Ignicion As Single, HRD_Ignicion As Single
            ////Dim Cal_Ignicion As Single, Dolomita_Ignicion As Single, Carbon_Ignicion As Single
            ////Dim Ignicion_Total As Single

            //var HBI_Ignicion = (HBI_AcL * dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", "Carbon", "Metalica"));
            //var ChatarraLigera_Ignicion = (ChatarraLigera_AcL * dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", "Dolomita", "Metalica"));
            //var Escarpa_Ignicion = (Escarpa_AcL * dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", "Cal", "Metalica"));
            //var HierroFundido_Ignicion = (HierroFundido_AcL * dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", "LadrilloPared", "Metalica"));
            //var ChatarraPesada_Ignicion = (ChatarraPesada_AcL * dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", "CentroBobeda", "Metalica"));
            //var Paca_Ignicion = (Paca_AcL * dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", 5, "Metalica"));
            //var HRD_Ignicion = (HRD_AcL * dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", 7, "Metalica"));

            //var Cal_Ignicion = (Peso_Cal * dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", "Cal", "Metalica"));
            //var Dolomita_Ignicion = (Peso_Dolomita * dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", "Dolomita", "Metalica"));
            //var Carbon_Ignicion = (Peso_Carbon * dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", "Carbon", "Metalica"));

            ////'' total
            //var Ignicion_Total = HBI_Ignicion + ChatarraLigera_Ignicion + Escarpa_Ignicion + HierroFundido_Ignicion
            //                     + ChatarraPesada_Ignicion + Paca_Ignicion + HRD_Ignicion + Cal_Ignicion +
            //                     Dolomita_Ignicion + Carbon_Ignicion;

            ////''' PONDERACION PARA LA COMBUSTION DEL CARBONO CON RESPECTO A LA POST COMBUSTION
            ////Dim A As Single, B As Single
            ////'' de la tabla de las energias de reacciones quim
            //var CO = 0.0;
            //var CO2 = 0.0;
            //var A = EnergReacQuimicas(9, 1);
            //var B = EnergReacQuimicas(10, 1);

            ////''' asumir composicion de gases si no se da
            //if (CO <= 0)
            //    CO = 85;

            //if (CO2 <= 0)
            //    CO2 = 15;


            ////''' calculo de ponderado para la post-combustion
            ////Dim PComb_Ponderado_Carbono As Single
            //var PComb_Ponderado_Carbono = (CO*A)/100 + (CO2*B)/100;
            //var PComb_Ponderado_Cementita = 0.0;
            //if (Carga["HRD"] >= 0)
            //{
            //    //''' PONDERACION PARA LA COMBUSTION DE LA cementita CON RESPECTO A LA POST COMBUSTION
            //    //'' de la tabla de las energias de reacciones quim
            //    A = EnergReacQuimicas(12, 1);
            //    B = EnergReacQuimicas(13, 1);
            //    //''' calculo de ponderado para la post-combustion
            //    //Dim PComb_Ponderado_Cementita As Single
            //    PComb_Ponderado_Cementita = (CO*A)/100 + (CO2*B)/100;
            //}

            //var PesoFeO_Ponderado = 0.0;
            //var PesoFe2O3_Ponderado = 0.0;
            ////''' PONDERACION PARA la reduccion del Fe con respecto a la post combustion
            ////Dim PesoFeO_Ponderado  As Single, PesoFe2O3_Ponderado As Single
            ////''FeO
            //if (Carga["HRD"] >= 0)
            //{
            //    A = EnergReacQuimicas(3, 1);
            //    B = EnergReacQuimicas(4, 1);
            //    PesoFeO_Ponderado = (CO*A)/100 + (CO2*B)/100;

            //    A = EnergReacQuimicas(1, 1);
            //    B = EnergReacQuimicas(2, 1);
            //    PesoFe2O3_Ponderado = (CO*A)/100 + (CO2*B)/100;
            //}
            //else
            //{

            //    A = EnergReacQuimicas(7, 1);
            //    B = EnergReacQuimicas(8, 1);
            //    PesoFeO_Ponderado = (CO*A)/100 + (CO2*B)/100;

            //    A = EnergReacQuimicas(5, 1);
            //    B = EnergReacQuimicas(6, 1);
            //    PesoFe2O3_Ponderado = (CO*A)/100 + (CO2*B)/100;

            //}

            ////''=======================CALCULO DE LAS ENERGIAS=================================
            ////Dim EnergiaFeO_Ponderado As Single, EnergiaFe2O3_Ponderado As Single
            ////Dim EnergiaFeO_Ponderado2 As Single, EnergiaFe2O3_Ponderado2 As Single
            //var EnergiaFeO_Ponderado = 0.0;
            //var EnergiaFe2O3_Ponderado = 0.0;
            //var EnergiaFeO_Ponderado2 = 0.0;
            //var EnergiaFe2O3_Ponderado2 = 0.0;
            ////'' por ponderacion
            //if (Carga["HRD"] >= 0)
            //{

            //    A = EnergReacQuimicas(3, 4);
            //    B = EnergReacQuimicas(4, 4);
            //    EnergiaFeO_Ponderado = (CO*A)/100 + (CO2*B)/100;

            //    A = EnergReacQuimicas(1, 4);
            //    B = EnergReacQuimicas(2, 4);
            //    EnergiaFe2O3_Ponderado = (CO*A)/100 + (CO2*B)/100;

            //    A = EnergReacQuimicas(5, 4);
            //    B = EnergReacQuimicas(6, 4);
            //    EnergiaFe2O3_Ponderado2 = (CO*A)/100 + (CO2*B)/100;

            //    A = EnergReacQuimicas(7, 4);
            //    B = EnergReacQuimicas(8, 4);
            //    EnergiaFeO_Ponderado2 = (CO*A)/100 + (CO2*B)/100;

            //    A = EnergReacQuimicas(5, 4);
            //    B = EnergReacQuimicas(6, 4);
            //    EnergiaFe2O3_Ponderado = (CO*A)/100 + (CO2*B)/100;

            //    A = EnergReacQuimicas(7, 4);
            //    B = EnergReacQuimicas(8, 4);
            //    EnergiaFeO_Ponderado = (CO*A)/100 + (CO2*B)/100;

            //}


            ////''''' CANTIDAD DE OXIDO DE HIERRO CARGADO, CARBONO PARA SU REDUCCION Y CONTENIDO DE OXIGEN
            ////''' CALCULO DE OXIDO DE HIERRO EN LA CARGA   Fe++
            ////Dim FeO_Carga_HBI As Single, FeO_Carga_ChatarraLigera As Single, FeO_Carga_Escarpa As Single, FeO_Carga_HierroFundido As Single
            ////Dim FeO_Carga_ChatarraPesada As Single, FeO_Carga_Paca As Single, FeO_Carga_HRD As Single, FeO_Carga_Cal As Single
            ////Dim FeO_Carga_Dolomita As Single, FeO_Carga_Carbon As Single

            ////Dim Fe2O3_Carga_HBI As Single, Fe2O3_Carga_ChatarraLigera As Single, Fe2O3_Carga_Escarpa As Single, Fe2O3_Carga_HierroFundido As Single
            ////Dim Fe2O3_Carga_ChatarraPesada As Single, Fe2O3_Carga_Paca As Single, Fe2O3_Carga_HRD As Single, Fe2O3_Carga_Cal As Single
            ////Dim Fe2O3_Carga_Dolomita As Single, Fe2O3_Carga_Carbon As Single

            ////''FeO

            //var FeO_Carga_HBI = (HBI_AcL*CargaMetalica("Fe++", 0)*(OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0)));
            //var FeO_Carga_ChatarraLigera = (ChatarraLigera_AcL*CargaMetalica("Fe++", 1)*
            //                                (OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0)));
            //var FeO_Carga_Escarpa = (Escarpa_AcL*CargaMetalica("Fe++", 2)*
            //                         (OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0)));
            //var FeO_Carga_HierroFundido = (HierroFundido_AcL*CargaMetalica("Fe++", 3)*
            //                               (OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0)));

            //var FeO_Carga_ChatarraPesada = (ChatarraPesada_AcL*CargaMetalica("Fe++", 4)*
            //                                (OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0)));
            //var FeO_Carga_Paca = (Paca_AcL*CargaMetalica("Fe++", 5)*
            //                      (OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0)));
            //var FeO_Carga_HRD = (HRD_AcL*CargaMetalica("Fe++", 7)*(OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0)));

            //var FeO_Carga_Cal = (Peso_Cal*
            //                     dsbce.Q_ElementosProject.SearchCarga("Fe++", "Cal", "Carga Refractaria Fundente")*
            //                     (OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0)));
            //var FeO_Carga_Dolomita = (Peso_Dolomita*
            //                          dsbce.Q_ElementosProject.SearchCarga("Fe++", "Dolomita",
            //                                                               "Carga Refractaria Fundente")*
            //                          (OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0)));
            //var FeO_Carga_Carbon = (Peso_Carbon*
            //                        dsbce.Q_ElementosProject.SearchCarga("Fe++", "Carbon", "Carga Refractaria Fundente")*
            //                        (OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0)));

            ////''Fe2O3
            //var Fe2O3_Carga_HBI = (HBI_AcL * CargaMetalica("Fe2O3", 0, "Metalica") *
            //                       (OxidoRelacEsteq("Fe2O3", 1)/OxidoRelacEsteq("Fe2O3", 0)));
            //var Fe2O3_Carga_ChatarraLigera = (ChatarraLigera_AcL * CargaMetalica("Fe2O3", 1, "Metalica") *
            //                                  (OxidoRelacEsteq("Fe2O3", 1)/OxidoRelacEsteq("Fe2O3", 0)));
            //var Fe2O3_Carga_Escarpa = (Escarpa_AcL*CargaMetalica("Fe2O3", 2)*
            //                           (OxidoRelacEsteq("Fe2O3", 1)/OxidoRelacEsteq("Fe2O3", 0)));
            //var Fe2O3_Carga_HierroFundido = (HierroFundido_AcL * CargaMetalica("Fe2O3", 3, "Metalica") *
            //                                 (OxidoRelacEsteq("Fe2O3", 1)/OxidoRelacEsteq("Fe2O3", 0)));
            //var Fe2O3_Carga_ChatarraPesada = (ChatarraPesada_AcL * CargaMetalica("Fe2O3", 4, "Metalica") *
            //                                  (OxidoRelacEsteq("Fe2O3", 1)/OxidoRelacEsteq("Fe2O3", 0)));
            //var Fe2O3_Carga_Paca = (Paca_AcL * CargaMetalica("Fe2O3", 5, "Metalica") *
            //                        (OxidoRelacEsteq("Fe2O3", 1)/OxidoRelacEsteq("Fe2O3", 0)));
            //var Fe2O3_Carga_HRD = (HRD_AcL * CargaMetalica("Fe2O3", 7, "Metalica") *
            //                       (OxidoRelacEsteq("Fe2O3", 1)/OxidoRelacEsteq("Fe2O3", 0)));

            //var Fe2O3_Carga_Cal = (Peso_Cal*
            //                       dsbce.Q_ElementosProject.SearchCarga("Fe2O3", "Cal", "Carga Refractaria Fundente")*
            //                       (OxidoRelacEsteq("Fe2O3", 1)/OxidoRelacEsteq("Fe2O3", 0)));
            //var Fe2O3_Carga_Dolomita = (Peso_Dolomita*
            //                            dsbce.Q_ElementosProject.SearchCarga("Fe2O3", "Dolomita",
            //                                                                 "Carga Refractaria Fundente")*
            //                            (OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("Fe2O3", 0)));
            //var Fe2O3_Carga_Carbon = (Peso_Carbon*
            //                          dsbce.Q_ElementosProject.SearchCarga("Fe2O3", "Carbon",
            //                                                               "Carga Refractaria Fundente")*
            //                          (OxidoRelacEsteq("Fe2O3", 1)/OxidoRelacEsteq("Fe2O3", 0)));

            ////''' CALCULO DE CARBONO PARA LA REDUCCION DE HIERRO
            ////Dim CFeO_Reducc_HBI As Single, CFeO_Reducc_ChatarraLigera As Single, CFeO_Reducc_Escarpa As Single, CFeO_Reducc_HierroFundido As Single
            ////Dim CFeO_Reducc_ChatarraPesada As Single, CFeO_Reducc_Paca As Single, CFeO_Reducc_HRD As Single, CFeO_Reducc_Cal As Single
            ////Dim CFeO_Reducc_Dolomita As Single, CFeO_Reducc_Carbon As Single

            ////Dim CFe2O3_Reducc_HBI As Single, CFe2O3_Reducc_ChatarraLigera As Single, CFe2O3_Reducc_Escarpa As Single, CFe2O3_Reducc_HierroFundido As Single
            ////Dim CFe2O3_Reducc_ChatarraPesada As Single, CFe2O3_Reducc_Paca As Single, CFe2O3_Reducc_HRD As Single, CFe2O3_Reducc_Cal As Single
            ////Dim CFe2O3_Reducc_Dolomita As Single, CFe2O3_Reducc_Carbon As Single

            ////Dim C_Reducc_HBI As Single, C_Reducc_ChatarraLigera As Single, C_Reducc_Escarpa As Single, C_Reducc_HierroFundido As Single
            ////Dim C_Reducc_ChatarraPesada As Single, C_Reducc_Paca As Single, C_Reducc_HRD As Single, C_Reducc_Cal As Single
            ////Dim C_Reducc_Dolomita As Single, C_Reducc_Carbon As Single

            ////'' FeO
            //var CFeO_Reducc_HBI = FeO_Carga_HBI/PesoFeO_Ponderado;
            //var CFeO_Reducc_ChatarraLigera = FeO_Carga_ChatarraLigera/PesoFeO_Ponderado;
            //var CFeO_Reducc_Escarpa = FeO_Carga_Escarpa/PesoFeO_Ponderado;
            //var CFeO_Reducc_HierroFundido = FeO_Carga_HierroFundido/PesoFeO_Ponderado;
            //var CFeO_Reducc_ChatarraPesada = FeO_Carga_ChatarraPesada/PesoFeO_Ponderado;
            //var CFeO_Reducc_Paca = FeO_Carga_Paca/PesoFeO_Ponderado;
            //var CFeO_Reducc_HRD = FeO_Carga_HRD/PesoFeO_Ponderado;

            //var CFeO_Reducc_Cal = FeO_Carga_Cal/PesoFeO_Ponderado;
            //var CFeO_Reducc_Dolomita = FeO_Carga_Dolomita/PesoFeO_Ponderado;
            //var CFeO_Reducc_Carbon = FeO_Carga_Carbon/PesoFeO_Ponderado;
            ////''Fe2O3
            //var CFe2O3_Reducc_HBI = Fe2O3_Carga_HBI/PesoFe2O3_Ponderado;
            //var CFe2O3_Reducc_ChatarraLigera = Fe2O3_Carga_ChatarraLigera/PesoFe2O3_Ponderado;
            //var CFe2O3_Reducc_Escarpa = Fe2O3_Carga_Escarpa/PesoFe2O3_Ponderado;
            //var CFe2O3_Reducc_HierroFundido = Fe2O3_Carga_HierroFundido/PesoFe2O3_Ponderado;
            //var CFe2O3_Reducc_ChatarraPesada = Fe2O3_Carga_ChatarraPesada/PesoFe2O3_Ponderado;
            //var CFe2O3_Reducc_Paca = Fe2O3_Carga_Paca/PesoFe2O3_Ponderado;
            //var CFe2O3_Reducc_HRD = Fe2O3_Carga_HRD/PesoFe2O3_Ponderado;

            //var CFe2O3_Reducc_Cal = Fe2O3_Carga_Cal/PesoFe2O3_Ponderado;
            //var CFe2O3_Reducc_Dolomita = Fe2O3_Carga_Dolomita/PesoFe2O3_Ponderado;
            //var CFe2O3_Reducc_Carbon = Fe2O3_Carga_Carbon/PesoFe2O3_Ponderado;
            ////'Total
            //var C_Reducc_HBI = CFeO_Reducc_HBI + CFe2O3_Reducc_HBI;
            //var C_Reducc_ChatarraLigera = CFeO_Reducc_ChatarraLigera + CFe2O3_Reducc_ChatarraLigera;
            //var C_Reducc_Escarpa = CFeO_Reducc_Escarpa + CFe2O3_Reducc_Escarpa;
            //var C_Reducc_HierroFundido = CFeO_Reducc_HierroFundido + CFe2O3_Reducc_HierroFundido;
            //var C_Reducc_ChatarraPesada = CFeO_Reducc_ChatarraPesada + CFe2O3_Reducc_ChatarraPesada;
            //var C_Reducc_Paca = CFeO_Reducc_Paca + CFe2O3_Reducc_Paca;
            //var C_Reducc_HRD = CFeO_Reducc_HRD + CFe2O3_Reducc_HRD;

            //var C_Reducc_Cal = CFeO_Reducc_Cal + CFe2O3_Reducc_Cal;
            //var C_Reducc_Dolomita = CFeO_Reducc_Dolomita + CFe2O3_Reducc_Dolomita;
            //var C_Reducc_Carbon = CFeO_Reducc_Carbon + CFe2O3_Reducc_Carbon;

            ////''' CALCULO DEL CONTENIDO DE OXIGENO PARA LA REDUCCION DE HIERRO  Fe++
            ////Dim OxFeO_Reducc_HBI As Single, OxFeO_Reducc_ChatarraLigera As Single, OxFeO_Reducc_Escarpa As Single, OxFeO_Reducc_HierroFundido As Single
            ////Dim OxFeO_Reducc_ChatarraPesada As Single, OxFeO_Reducc_Paca As Single, OxFeO_Reducc_HRD As Single, OxFeO_Reducc_Cal As Single
            ////Dim OxFeO_Reducc_Dolomita As Single, OxFeO_Reducc_Carbon As Single

            ////Dim OxFe2O3_Reducc_HBI As Single, OxFe2O3_Reducc_ChatarraLigera As Single, OxFe2O3_Reducc_Escarpa As Single, OxFe2O3_Reducc_HierroFundido As Single
            ////Dim OxFe2O3_Reducc_ChatarraPesada As Single, OxFe2O3_Reducc_Paca As Single, OxFe2O3_Reducc_HRD As Single, OxFe2O3_Reducc_Cal As Single
            ////Dim OxFe2O3_Reducc_Dolomita As Single, OxFe2O3_Reducc_Carbon As Single

            ////Dim Ox_Reducc_HBI As Single, Ox_Reducc_ChatarraLigera As Single, Ox_Reducc_Escarpa As Single, Ox_Reducc_HierroFundido As Single
            ////Dim Ox_Reducc_ChatarraPesada As Single, Ox_Reducc_Paca As Single, Ox_Reducc_HRD As Single, Ox_Reducc_Cal As Single
            ////Dim Ox_Reducc_Dolomita As Single, Ox_Reducc_Carbon As Single

            ////'FeO
            //var OxFeO_Reducc_HBI = (FeO_Carga_HBI*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("FeO", 1);
            //var OxFeO_Reducc_ChatarraLigera = (FeO_Carga_ChatarraLigera*OxidoRelacEsteq("O", 0))/
            //                                  OxidoRelacEsteq("FeO", 1);
            //var OxFeO_Reducc_Escarpa = (FeO_Carga_Escarpa*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("FeO", 1);
            //var OxFeO_Reducc_HierroFundido = (FeO_Carga_HierroFundido*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("FeO", 1);
            //var OxFeO_Reducc_ChatarraPesada = (FeO_Carga_ChatarraPesada*OxidoRelacEsteq("O", 0))/
            //                                  OxidoRelacEsteq("FeO", 1);
            //var OxFeO_Reducc_Paca = (FeO_Carga_Paca*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("FeO", 1);
            //var OxFeO_Reducc_HRD = (FeO_Carga_HRD*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("FeO", 1);

            //var OxFeO_Reducc_Cal = (FeO_Carga_Cal*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("FeO", 1);
            //var OxFeO_Reducc_Dolomita = (FeO_Carga_Dolomita*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("FeO", 1);
            //var OxFeO_Reducc_Carbon = (FeO_Carga_Carbon*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("FeO", 1);
            ////''Fe2O3
            //var OxFe2O3_Reducc_HBI = (Fe2O3_Carga_HBI*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("Fe2O3", 1);
            //var OxFe2O3_Reducc_ChatarraLigera = (Fe2O3_Carga_ChatarraLigera*OxidoRelacEsteq("O", 0))/
            //                                    OxidoRelacEsteq("Fe2O3", 1);
            //var OxFe2O3_Reducc_Escarpa = (Fe2O3_Carga_Escarpa*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("Fe2O3", 1);
            //var OxFe2O3_Reducc_HierroFundido = (Fe2O3_Carga_HierroFundido*OxidoRelacEsteq("O", 0))/
            //                                   OxidoRelacEsteq("Fe2O3", 1);
            //var OxFe2O3_Reducc_ChatarraPesada = (Fe2O3_Carga_ChatarraPesada*OxidoRelacEsteq("O", 0))/
            //                                    OxidoRelacEsteq("Fe2O3", 1);
            //var OxFe2O3_Reducc_Paca = (Fe2O3_Carga_Paca*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("Fe2O3", 1);
            //var OxFe2O3_Reducc_HRD = (Fe2O3_Carga_HRD*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("Fe2O3", 1);

            //var OxFe2O3_Reducc_Cal = (Fe2O3_Carga_Cal*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("Fe2O3", 1);
            //var OxFe2O3_Reducc_Dolomita = (Fe2O3_Carga_Dolomita*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("Fe2O3", 1);
            //var OxFe2O3_Reducc_Carbon = (Fe2O3_Carga_Carbon*OxidoRelacEsteq("O", 0))/OxidoRelacEsteq("Fe2O3", 1);

            ////'Total
            //var Ox_Reducc_HBI = OxFeO_Reducc_HBI + OxFe2O3_Reducc_HBI;
            //var Ox_Reducc_ChatarraLigera = OxFeO_Reducc_ChatarraLigera + OxFe2O3_Reducc_ChatarraLigera;
            //var Ox_Reducc_Escarpa = OxFeO_Reducc_Escarpa + OxFe2O3_Reducc_Escarpa;
            //var Ox_Reducc_HierroFundido = OxFeO_Reducc_HierroFundido + OxFe2O3_Reducc_HierroFundido;
            //var Ox_Reducc_ChatarraPesada = OxFeO_Reducc_ChatarraPesada + OxFe2O3_Reducc_ChatarraPesada;
            //var Ox_Reducc_Paca = OxFeO_Reducc_Paca + OxFe2O3_Reducc_Paca;
            //var Ox_Reducc_HRD = OxFeO_Reducc_HRD + OxFe2O3_Reducc_HRD;

            //var Ox_Reducc_Cal = OxFeO_Reducc_Cal + OxFe2O3_Reducc_Cal;
            //var Ox_Reducc_Dolomita = OxFeO_Reducc_Dolomita + OxFe2O3_Reducc_Dolomita;
            //var Ox_Reducc_Carbon = OxFeO_Reducc_Carbon + OxFe2O3_Reducc_Carbon;



            ////''' CALCULO DE LA COMPOSICION QUIMICA DE LOS GASES ********************************
            ////''' relacion especifica de pesos
            ////Dim RelEsp_C_CO As Single, RelEsp_C_CO2 As Single

            //var RelEsp_C_CO = (CO*(OxidoRelacEsteq("CO", 1)/OxidoRelacEsteq("CO", 0)))/100;
            //var RelEsp_C_CO2 = (CO2*(OxidoRelacEsteq("CO2", 1)/OxidoRelacEsteq("CO2", 0)))/100;

            ////''' determinacion de la cantidad de CO y CO2
            ////Dim Cant_CO As Single, Cant_CO2 As Single, Cant_CO_Electrodo As Single, Cant_CO2_Electrodo As Single
            ////'Carbono
            //var Cant_CO = C_Perdida*RelEsp_C_CO;
            //var Cant_CO2 = C_Perdida*RelEsp_C_CO2;
            ////'Electrodos
            //var Cant_CO_Electrodo = IndiceConsumo("PuntaElectrodo")*RelEsp_C_CO;
            //var Cant_CO2_Electrodo = IndiceConsumo("PuntaElectrodo")*RelEsp_C_CO2;


            ////''' OXIDO FORMADO EN EL CARBONO **********************
            ////Dim Ox_form_C As Single;
            //var Ox_form_C = (((C_Perdida*CO)/100)*(OxidoRelacEsteq("CO", 1)/OxidoRelacEsteq("CO", 0))) +
            //                (((C_Perdida*CO2)/100)*(OxidoRelacEsteq("CO2", 1)/OxidoRelacEsteq("CO2", 0)));

            ////''' OXIGENO REQUERIDO DEL CARBONO **********************
            ////Dim Ox_Req_C As Single
            //var Ox_Req_C = Ox_form_C - C_Perdida;

            ////''' OXIGENO DEL CARBON --------------------------
            ////Dim Ox_Reg_Carbon As Single
            //var Ox_Reg_Carbon = (((Peso_Carbon*CO)/100)*(OxidoRelacEsteq("O", 0)/OxidoRelacEsteq("C", 0))) +
            //                    (((Peso_Carbon*CO2)/100)*((OxidoRelacEsteq("O", 0)*2)/OxidoRelacEsteq("C", 0)));

            ////''' OXIGENO DE  ELECTRODO --------------------------
            ////Dim Ox_Reg_Electrodo As Single
            //var Ox_Reg_Electrodo = (((IndiceConsumo("PuntaElectrodo")*CO)/100)*
            //                        (OxidoRelacEsteq("O", 0)/OxidoRelacEsteq("C", 0))) +
            //                       (((IndiceConsumo("PuntaElectrodo")*CO2)/100)*
            //                        ((OxidoRelacEsteq("O", 0)*2)/OxidoRelacEsteq("C", 0)));

            ////''' ANALISIS DE OXIGENO PARA DESCARBURIZACION  ***********************
            ////'' oxigeno total para descarburizacion
            ////Dim Ox_Descarburacion As Single
            //var Ox_Descarburacion = Ox_Req_C + Ox_Reg_Carbon + Ox_Reg_Electrodo;

            ////' oxigeno en la escoria
            ////Dim Ox_Escoria As Single
            //var Ox_Escoria = FeO_Esc*(OxidoRelacEsteq("O", 0)/OxidoRelacEsteq("FeO", 1));

            ////' oxigeno del oxido de hierro cargado
            ////Dim Ox_FeOFe2O3_Cargado As Single
            ////Dim Sum_Ox_FeO As Single, Sum_Ox_Fe2O3 As Single
            //var Sum_Ox_FeO = OxFeO_Reducc_HBI + OxFeO_Reducc_ChatarraLigera + OxFeO_Reducc_Escarpa +
            //                 OxFeO_Reducc_HierroFundido + OxFeO_Reducc_ChatarraPesada

            //                 + OxFeO_Reducc_Paca + OxFeO_Reducc_HRD + OxFeO_Reducc_Cal + OxFeO_Reducc_Dolomita +
            //                 OxFeO_Reducc_Carbon;

            //var Sum_Ox_Fe2O3 = OxFe2O3_Reducc_HBI + OxFe2O3_Reducc_ChatarraLigera + OxFe2O3_Reducc_Escarpa +
            //                   OxFe2O3_Reducc_HierroFundido + OxFe2O3_Reducc_ChatarraPesada

            //                   + OxFe2O3_Reducc_Paca + OxFe2O3_Reducc_HRD + OxFe2O3_Reducc_Cal + OxFe2O3_Reducc_Dolomita +
            //                   OxFe2O3_Reducc_Carbon;

            //var Ox_FeOFe2O3_Cargado = Ox_Reducc_HBI + Ox_Reducc_ChatarraLigera + Ox_Reducc_Escarpa +
            //                          Ox_Reducc_HierroFundido + Ox_Reducc_ChatarraPesada

            //                          + Ox_Reducc_Paca + Ox_Reducc_HRD + Ox_Reducc_Cal + Ox_Reducc_Dolomita +
            //                          Ox_Reducc_Carbon;

            ////''' oxigeno gaseoso para descaburizacion
            ////Dim Ox_Gas_Descarb As Single
            //var Ox_Gas_Descarb = ((Ox_Descarburacion + Ox_Escoria) - Ox_FeOFe2O3_Cargado)/(Oxigeno_EficInyectado/100);


            ////''' ANALISIS DE OXIGENO PARA LA OXIDACION DE ELEMENTOS  ***********************
            ////'' Oxigeno de elementos
            ////Dim Ox_Elementos As Single
            //var Ox_Elementos = MnO_OReq + SiO2_OReq + P2O5_OReq + FeO_OReq + Al2O3_OReq + Cr2O3_OReq + Ox_Reg_Electrodo;


            ////''' AIRE DE INFILTRACION
            ////Dim AInfil_Aire As Single, AInfil_Nitrogeno As Single, AInfil_Oxigeno As Single
            //var AInfil_Aire = General["Dens_Aire"]*General["Vol_Aire"];
            //var AInfil_Nitrogeno = General["Dens_Nitrogeno"]*General["Vol_Nitrogeno"];
            //var AInfil_Oxigeno = General["Dens_Oxigeno"]*General["Vol_Oxigeno"];

            ////'' ' OXIGENO GASEOSO PARA OXIDACION DE ELEMENTOS
            ////Dim Ox_Gas_Ox As Single
            //var Ox_Gas_Ox = (Ox_Elementos - (Ox_Escoria + AInfil_Oxigeno))/(Oxigeno_EficInyectado/100);

            ////'' ' OXIGENO GASEOSO TOTAL INYECTADO
            ////Dim Ox_Gas_Total As Single
            //var Ox_Gas_Total = Ox_Gas_Descarb + Ox_Gas_Ox;

            ////'' OXIGENO LIBRE
            ////Dim Ox_Libre As Single
            //var Ox_Libre = Ox_Gas_Total*((100 - Oxigeno_EficInyectado)/100);





            ////''******************************* EJECUCION DE LOS BALANCES DE OXIGENO *******************************
            ////    Entradas = Sum_Ox_FeO + Sum_Ox_Fe2O3 + AInfil_Oxigeno + Ox_Gas_Total
            ////    Salidas = Ox_Elementos + Ox_Req_C + Ox_Reg_Carbon + Ox_Libre
            ////    If Entradas <> Salidas Then MsgBox ("Balance de Oxigeno incorrecto")



            ////''******************************* EJECUCION DE LOS BALANCES DE OXIDO DE CALCIO *******************************
            ////Dim CaO_ref As Single, CaO_Carga As Single 'CaO_AcLiq As Single, CaO_Cal As Single, CaO_CalReal As Single
            ////    '' calculo del oxido de silicio de refractario
            //var CaO_ref = (dsbce.Q_ElementosProject.SearchCarga("CaO", "LadrilloPared", "Carga Refractaria Fundente")*
            //               IndiceConsumo("LadrilloPared"))
            //              +
            //              (dsbce.Q_ElementosProject.SearchCarga("CaO", "CentroBobeda", "Carga Refractaria Fundente")*
            //               IndiceConsumo("CentroBobeda"))
            //              +
            //              (dsbce.Q_ElementosProject.SearchCarga("CaO", "Proyectable", "Carga Refractaria Fundente")*
            //               IndiceConsumo("Proyectable"))
            //              +
            //              (dsbce.Q_ElementosProject.SearchCarga("CaO", "Apisonable", "Carga Refractaria Fundente")*
            //               IndiceConsumo("Apisonable"));

            ////'' calculo del Oxido de calcio de carga metalica
            //var CaO_Carga = CaO_Esc -
            //                ((dsbce.Q_ElementosProject.SearchCarga("CaO", "Cal", "Carga Refractaria Fundente")*Peso_Cal)
            //                 +
            //                 (dsbce.Q_ElementosProject.SearchCarga("CaO", "Dolomita", "Carga Refractaria Fundente")*
            //                  Peso_Dolomita)
            //                 +
            //                 (dsbce.Q_ElementosProject.SearchCarga("CaO", "CenizaElectrodo",
            //                                                       "Carga Refractaria Fundente")*
            //                  IndiceConsumo("CenizaElectrodo"))
            //                 + CaO_ref);


            ////'' comprobar balance calcio
            ////Entradas = CaO_Carga + ((CargaRefracFundente("CaO", 2) * Peso_Cal) _
            ////                      + (CargaRefracFundente("CaO", 1) * Peso_Dolomita) _
            ////                      + (CargaRefracFundente("CaO", 7) * IndiceConsumo("CenizaElectrodo")) _
            ////                      + CaO_ref)
            ////Salidas = CaO_Esc
            ////If Entradas <> Salidas Then MsgBox ("Balance de Oxido de Calcio incorrecto")
            ////'' no hay CaO en la Carga metalica
            //if (CaO_Carga < 0) CaO_Carga = 0;



            ////    ''******************************* EJECUCION DE LOS BALANCES DE OXIDO DE SILICIO *******************************
            ////Dim SiO2_Carga As Single

            ////' conversion del elemento de carga a oxido
            ////Dim Si_ConvSiO2 As Single
            //var Si_ConvSiO2 = Si_Total*(OxidoRelacEsteq("SiO2", 1)/OxidoRelacEsteq("SiO2", 0));

            ////' carga
            //var SiO2_Carga = OxidosDeCargas("SiO2", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                                ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            ////' conversion del silicio del acero a oxido
            ////Dim SiO2_AcLiq As Single
            //var SiO2_AcLiq = Si_AcL*(OxidoRelacEsteq("SiO2", 1)/OxidoRelacEsteq("SiO2", 0));

            ////''''''''''''''''''''''''''''''''''''''''''''''

            ////Entradas = Si_ConvSiO2 + SiO2_Carga
            ////Salidas = SiO2_Esc + SiO2_AcLiq
            ////If Entradas <> Salidas Then MsgBox ("Balance de Oxido de Silicio incorrecto")



            ////''******************************* EJECUCION DE LOS BALANCES DE OXIDO DE MAGNESIO *******************************
            ////Dim MgO_Carga As Single

            //////' carga
            ////MgO_Carga = MgO_Esc

            ////Entradas = MgO_Carga
            ////Salidas = MgO_Esc
            ////If Entradas <> Salidas Then MsgBox ("Balance de Oxido de MAGNESIO incorrecto")





            ////''******************************* EJECUCION DE LOS BALANCES DEL ALUMINA *******************************
            ////Dim Al2O3_Carga As Single

            ////'carga
            //var Al2O3_Carga = Al2O3 +
            //                  OxidosDeCargas("Al2O3", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                                 ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            ////' conversion del elemento de carga a oxido
            ////Dim Al_ConvAl2O3 As Single
            //var Al_ConvAl2O3 = Al_Total*(OxidoRelacEsteq("Al2O3", 1)/(OxidoRelacEsteq("Al2O3", 0)*2));

            ////' conversion del elemento del acero a oxido
            ////Dim Al2O3_AcLiq As Single
            //var Al2O3_AcLiq = Al_AcL*(OxidoRelacEsteq("Al2O3", 1)/(OxidoRelacEsteq("Al2O3", 0)*2));

            ////Entradas = Al_ConvAl2O3 + Al2O3_Carga
            ////Salidas = Al2O3_Esc + Al2O3_AcLiq
            ////If Entradas <> Salidas Then MsgBox ("Balance de Alumina incorrecto")





            ////    ''******************************* EJECUCION DE LOS BALANCES DEL OXIDO DE Mn *******************************
            ////Dim MnO_Carga As Single

            ////    ' carga
            //var MnO_Carga = OxidosDeCargas("MnO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                               ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            ////' conversion del elemento de carga a oxido
            ////Dim Mn_ConvMnO As Single
            //var Mn_ConvMnO = Mn_Total*(OxidoRelacEsteq("MnO", 1)/OxidoRelacEsteq("MnO", 0));

            ////' conversion del elemento del acero a oxido
            ////Dim MnO_AcLiq As Single
            //var MnO_AcLiq = Mn_AcL*(OxidoRelacEsteq("MnO", 1)/OxidoRelacEsteq("MnO", 0));

            ////Entradas = Mn_ConvMnO + MnO_Carga
            ////Salidas = MnO_Esc + MnO_AcLiq
            ////If Entradas <> Salidas Then MsgBox ("Balance de Oxido de Manganeso incorrecto")





            ////''******************************* EJECUCION DE LOS BALANCES DEL OXIDO DE Fe *******************************
            ////Dim FeO_Carga As Single

            ////' carga
            //var FeO_Carga = OxidosDeCargas("FeO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                               ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            ////' conversion del elemento de carga a oxido
            ////Dim Fe_ConvFeO As Single
            //var Fe_ConvFeO = Fe_Total*(OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0));

            ////' conversion del elemento del acero a oxido
            ////Dim FeO_AcLiq As Single
            //var FeO_AcLiq = Fe_AcL*(OxidoRelacEsteq("FeO", 1)/OxidoRelacEsteq("FeO", 0));

            ////Entradas = Fe_ConvFeO + FeO_Carga
            ////Salidas = FeO_Esc + FeO_AcLiq + Total_FeOxidoPolvo
            ////If Entradas <> Salidas Then MsgBox ("Balance de Oxido de Hierro incorrecto")


















            //MnO_Esc = MnO +
            //          OxidosDeCargas("MnO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                         ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //SiO2_Esc = SiO2 +
            //           OxidosDeCargas("SiO2", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                          ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //P2O5_Esc = P2O5 +
            //           OxidosDeCargas("P2O5", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                          ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //CaO_Esc = OxidosDeCargas("CaO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                         ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //MgO_Esc = OxidosDeCargas("MgO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                         ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //Al2O3_Esc = OxidosDeCargas("Al2O3", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                           ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //Cr2O3_Esc = Cr2O3 +
            //            OxidosDeCargas("Cr2O3", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                           ChatarraPesada_AcL, Paca_AcL, HRD_AcL);

            //FeO_Esc = FeO +
            //          OxidosDeCargas("FeO", HBI_AcL, ChatarraLigera_AcL, Escarpa_AcL, HierroFundido_AcL,
            //                         ChatarraPesada_AcL, Paca_AcL, HRD_AcL);););););););););););

            return r;
        }



        private double OxidosDeCargas(string mgo, double hbiAcL, double chatarraLigeraAcL, double escarpaAcL, double hierroFundidoAcL, double chatarraPesadaAcL, double pacaAcL, double hrdAcL)
        {
            throw new NotImplementedException();
        }



        private double IndiceConsumo(string puntaelectrodo)
        {
            throw new NotImplementedException();
        }




        /*   private DSDatosTableAdapters.T_Proyecto_BalanceTableAdapter ProyectoTA = new DSDatosTableAdapters.T_Proyecto_BalanceTableAdapter();
        private DSDatosTableAdapters.T_ElementoTableAdapter ElementoTA = new DSDatosTableAdapters.T_ElementoTableAdapter();
        private DSDatosTableAdapters.T_Prop_HAETableAdapter Prop_HAETA = new DSDatosTableAdapters.T_Prop_HAETableAdapter();
        private DSDatosTableAdapters.T_Balance_PropiedadTableAdapter Balc_PropTA = new DSDatosTableAdapters.T_Balance_PropiedadTableAdapter();
        private DSDatosTableAdapters.T_Carga_Refractario_FundenteTableAdapter CRFTA = new DSDatosTableAdapters.T_Carga_Refractario_FundenteTableAdapter();
        private DSDatosTableAdapters.QueriesTableAdapter QueriesTA = new DSDatosTableAdapters.QueriesTableAdapter();
        private DSDatosTableAdapters.p_ELEMENT_OX_PROPTableAdapter Element_Ox_Prop = new DSDatosTableAdapters.p_ELEMENT_OX_PROPTableAdapter();
        private DSDatosTableAdapters.p_ELEMENT_PROPTableAdapter Element_Prop = new DSDatosTableAdapters.p_ELEMENT_PROPTableAdapter();
        private DSDatosTableAdapters.p_ELEMENT_PROP_3TableAdapter Element_Prop_3 = new DSDatosTableAdapters.p_ELEMENT_PROP_3TableAdapter();
        private DSDatosTableAdapters.p_ELEMENT_PROP_2TableAdapter Element_Prop_2 = new DSDatosTableAdapters.p_ELEMENT_PROP_2TableAdapter();
        private DSDatosTableAdapters.p_ELEMENT_PROP_4TableAdapter Element_Prop_4 = new DSDatosTableAdapters.p_ELEMENT_PROP_4TableAdapter();
        private DSDatosTableAdapters.p_ELEMENT_PROP_5TableAdapter Element_Prop_5 = new DSDatosTableAdapters.p_ELEMENT_PROP_5TableAdapter();
        private DSDatosTableAdapters.p_ELEMENT_OX_PROP_2TableAdapter Element_Ox_Prop_2 = new DSDatosTableAdapters.p_ELEMENT_OX_PROP_2TableAdapter();
        private DSDatosTableAdapters.p_ELEMENT_OX_PROP_3TableAdapter Element_Ox_Prop_3 = new DSDatosTableAdapters.p_ELEMENT_OX_PROP_3TableAdapter();
        
    
        private DSDatos dSDatos =  new DSDatos();
      
        public Dictionary<String, Object> variables_int_calc = new Dictionary<String, Object> { 
            
                            
                            {"Carga_MetalicaTotal", 75.1},
                            {"Peso_Cal", 0.0},
                            {"Peso_Dolomita", 0.0},
                            {"Peso_Carbon", 0.0},
                            {"Peso_EscoriaRem", 0.0},
                            {"BaseAcero", 1000.0},
                            {"BaseEscoria", 0.0},
                            {"AcLiquido", 70.0},
                            {"Cal_MasaTotal", 3.1},
                            {"Dolomita_MasaTotal", 0.075},
                            {"Carbon_MasaTotal", 0.14},
                            
                            {"PieL_MasaTotal", 0.0},
                            {"EscoriaRem_MasaTotal", 0.0}

                           
        };

        public Dictionary<String, Object> variables_Al_prop = new Dictionary<String, Object>
        {
            {"Al_ox", 0.0},
            {"Al_Carga", 0.0},
            {"Al_Metal", 0.0},
            {"Al_Perdida", 0.0},
            {"Al_CargaPorciento", 0.0},
            {"Al_PerdidaPorciento", 0.0},
        };

        public Dictionary<String, Object> variables_MnO_prop = new Dictionary<String, Object>
        {
            {"MnO_ox", 0.0},
            {"MnO_Carga", 0.0},
            {"MnO_Metal", 0.0},
            {"MnO_Perdida", 0.0},
            {"MnO_CargaPorciento", 0.0},
            {"MnO_PerdidaPorciento", 0.0},
            {"MnO_AcLiq",  1.291227 },
            {"MnO_Esc", 5.7},
        };

        public Dictionary<String, Object> variables_Mn_prop = new Dictionary<String, Object>
        {
            {"Mn_ox", 0.0},
            {"Mn_Carga", 0.0},
            {"Mn_Metal", 0.1},
            {"Mn_Perdida", 0.0},
            {"Mn_CargaPorciento", 0.0},
            {"Mn_PerdidaPorciento", 0.0},
        };

        public Dictionary<String, Object> variables_FeO_prop = new Dictionary<String, Object>
        {
            {"FeO_ox", 0.0},
            {"FeO_Carga", 0.0},
            {"FeO_Metal", 99.64},
            {"FeO_Perdida", 0.0},
            {"FeO_CargaPorciento", 0.0},
            {"FeO_PerdidaPorciento", 0.0},
            {"FeO_AcLiq", 1281.85},
            {"FeO_Esc", 20.58},
            {"FeO_Polvo", 0.0},
            {"FeO_PolvoPorciento", 0.0},
            
        };

        public Dictionary<String, Object> variables_Fe_prop = new Dictionary<String, Object>
        {
            {"Fe_ox", 0.0},
            {"Fe_Carga", 0.0},
            {"Fe_Metal", 99.64},
            {"Fe_Perdida", 0.0},
            {"Fe_CargaPorciento", 0.0},
            {"Fe_PerdidaPorciento", 0.0},
            {"Fe_AcLiq", 0.0},
            {"Fe_Esc", 0.0},
        };

        public Dictionary<String, Object> variables_P2O5_prop = new Dictionary<String, Object>
        {
            {"P2O5_ox", 0.0},
            {"P2O5_Carga", 0.0},
            {"P2O5_Metal", 0.0},
            {"P2O5_Perdida", 0.0},
            {"P2O5_CargaPorciento", 0.0},
            {"P2O5_PerdidaPorciento", 0.0},
            {"P2O5_AcLiq", 0.0},
            {"P2O5_Esc", 0.0},
            {"P2O5_Polvo", 0.0},
            {"P2O5_PolvoPorciento", 0.0},
            {"P2O5_ParticionEscMet", 0.0},
            
        };

        public Dictionary<String, Object> variables_P_prop = new Dictionary<String, Object>
        {
            {"P_ox", 0.0},
            {"P_Carga", 0.0},
            {"P_Metal", 0.02},
            {"P_Perdida", 0.0},
            {"P_CargaPorciento", 0.0},
            {"P_PerdidaPorciento", 0.0},
            {"P_AcLiq", 0.0},
            {"P_Esc", 0.0},
            {"P_Polvo", 0.0},
            {"P_PolvoPorciento", 0.0},
        };


        public Dictionary<String, Object> variables_S_prop = new Dictionary<String, Object>
        {
            {"S_ox", 0.0},
            {"S_Carga", 0.0},
            {"S_Metal", 0.05},
            {"S_Perdida", 0.0},
            {"S_CargaPorciento", 0.0},
            {"S_PerdidaPorciento", 0.0},
            {"S_AcLiq", 0.0},
            {"S_Esc", 0.0},
            {"S_Polvo", 0.0},
            {"S_PolvoPorciento", 0.0},
            {"S_ParticionEscMet", 0.0},
            
        };
        public Dictionary<String, Object> variables_Cr2O3_prop = new Dictionary<String, Object>
        {
            {"Cr2O3_ox", 0.0},
            {"Cr2O3_Carga", 0.0},
            {"Cr2O3_Metal", 0.0},
            {"Cr2O3_Perdida", 0.0},
            {"Cr2O3_CargaPorciento", 0.0},
            {"Cr2O3_PerdidaPorciento", 0.0},
            {"Cr2O3_AcLiq", 0.0},
            {"Cr2O3_Esc", 0.0},
            {"Cr2O3_Polvo", 0.0},
            {"Cr2O3_PolvoPorciento", 0.0},
            {"Cr2O3_ParticionEscMet", 0.0},
            {"Cr2O3_Esc_ParticionEscMet", 0.0},
            
            
        };


        public Dictionary<String, Object> variables_Cr_prop = new Dictionary<String, Object>
        {
            {"Cr_ox", 0.0},
            {"Cr_Carga", 0.0},
            {"Cr_Carga2", 0.0},            
            {"Cr_Metal", 0.09},
            {"Cr_Perdida", 0.0},
            {"Cr_CargaPorciento", 0.0},
            {"Cr_PerdidaPorciento", 0.0},
            {"Cr_AcLiq", 0.0},
            {"Cr_Esc", 0.0},
            {"Cr_Polvo", 0.0},
            {"Cr_PolvoPorciento", 0.0},
            {"Cr_ParticionEscMet", 0.0},
            
        };


        public Dictionary<String, Object> variables_Gases_prop = new Dictionary<String, Object>
        {
            {"CO", 26.0},
            {"CO2", 12.0},
            {"Masa_Gases", 187.5},            
            {"Peso_Gases", 0.0},
            {"CO_masa", 48.75},
            {"CO2_masa", 0.0},
            {"C_Carbono", 0.0},
            {"C_AcLiq", 0.0},
            {"C_Carga", 0.0},
            {"Cr_Polvo", 0.0},
            {"C_Metal", 0.09},
            {"C_ParticionEscMet", 0.0},
            {"C_CargaPorciento", 0.0},
            {"C_Perdida", 0.0},
            {"C_PerdidaPorciento", 0.0},
            
        };
        

        


        public Dictionary<String, Object> ES = new Dictionary<String, Object> { 

            {"Entrada", new List<double>()},
            {"Salida", new List<double>()}
                                     

        };

        


        public void Carga_Segun_Escoria_Metal()
        {
            


            
            var variables = new Dictionary<String, Object>
                        {//elementos de entrada
                            {"BaseAcero",1000.0},
                            {"Peso_Cal", 0.0},
                            {"Peso_Dolomita", 0.0},
                            {"Peso_Carbon", 2.0},
                            {"Peso_Carga_MetalicaTotal",0.0},
                            {"Cal_MasaTotal", 3.1},
                            {"SiO2_Esc", 19.9},
                            {"Si_Metal", 0.01},
                            {"CaO_Esc", 33.0},
                            {"MgO_Esc", 6.8},
                            {"Al2O3_Esc", 7.3},
                            {"Al_Metal", 0.0},
                            {"MnO_Esc", 5.7},
                            {"Mn_Metal", 0.1},
                            {"FeO_Esc", 20.58},
                            {"Fe_Metal", 0.0},
                            {"P2O5_Esc", 0.0},
                            {"P_Metal", 0.02},
                            {"S_Esc", 0.0},
                            {"S_Metal",0.05},
                            {"Cr2O3_Esc",0.0},
                            {"Cr_Metal",0.9},
                            {"SiO2_ox",0.0},
                            {"SiO2_ref",0.0},
                            {"SiO2_Carga",0.0},
                            {"SiO2_AcLiq",0.0},
                            {"SiO2_Ox_Carga",0.0},
                            {"CaO_ref",0.0},
                            {"CaO_Carga",0.0},
                            {"CaO_AcLiq",0.0},
                            {"CaO_Cal",0.0},
                            {"CaO_CalReal",0.0},
                           
                            {"MgO_ref",0.0},
                            {"MgO_Carga",0.0},
                            {"MgO_Cal",0.0},
                            {"MgO_CalReal",0.0},  
                                                       
                           
                            {"Al2O3_ref",0.0},
                            {"Al2O3_ox",0.0},
                            {"Al2O3_Carga",0.0},
                            {"Al2O3_AcLiq",0.0},
                            {"Al2O3_Cal",0.0},
                            {"Al2O3_CalReal",0.0},                           

                            
                            //elementos fijos
                            {"C_Esc", 0.0},
                            {"C_Metal", 0.09}

                        };

            var variables_perdidas = new Dictionary<String, Object> { 
                            {"Si_Carga", 0.0},
                            {"Si_CargaPorciento", 0.0},
                            {"Si_Perdida", 0.0},
                            {"Si_PerdidaPorciento",0.0}
            };

            
            

            variables["Fe_Metal"] = 100 - (double)variables["Si_Metal"]
                                    + (double)variables["Al_Metal"]
                                    + (double)variables["Mn_Metal"]
                                    + (double)variables["P_Metal"] 
                                    + (double)variables["S_Metal"] 
                                    + (double)variables["Cr_Metal"] 
                                    + (double)variables["C_Metal"];          


          

        }
        */

    }
}
