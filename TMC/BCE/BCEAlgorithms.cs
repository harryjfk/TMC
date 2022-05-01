using System;
using System.Collections.Generic;
using System.Linq;
using TMC.BCE.DSBCETableAdapters;

namespace TMC.BCE
{
    
    
    public class Algorithm
    {
       

        private DSBCE dsbce = new DSBCE();
        private Dictionary<String, double> GenerateList(List<String> list, String name, Dictionary<String, double> General, Dictionary<String, double> Metal, Dictionary<String, double> Carga,int i,Dictionary<String,double > anterior = null)
        {
            var r = new Dictionary<String, double>();
            foreach (string s in list)
            {
                double w = 0;
                if (i == 0)

                    w = Carga[s] * General["BaseAcero"] / General["AcLiquido"];

                else if (i == 1)
                    w = Metal[s] * General["BaseAcero"] / 100;
                else
                    if (i == 2)
                        if (name == "Fe")
                            w = (anterior[s + "_ACL"] * dsbce.Q_ElementosProject.SearchCarga("FeT", s, "Metalica")) ;
                        else
                            w = (anterior[s + "_ACL"] * dsbce.Q_ElementosProject.SearchCarga(name, s, "Metalica")) / 100;

                    else if (i == 3)
                        w = (anterior[s + "_Fe"] * dsbce.Q_ElementosProject.SearchCarga(name, s, "Metalica")) / 100;
                    else if (i == 4)
                    {
                        w = anterior.Sum(keyValuePair => s != "PieLiquido" ? ((keyValuePair.Value * dsbce.Q_ElementosProject.SearchCarga(s, keyValuePair.Key.Substring(0, keyValuePair.Key.IndexOf('_')), "Metalica")) / 100) : 0);
                        w += dsbce.Q_ElementosProject.SearchCarga(s, "LadrilloPared", "Carga Refractaria Fundente") * dsbce.T_Indice_Consumo.FindByName("LadrilloPared");
                        w += dsbce.Q_ElementosProject.SearchCarga(s, "CentroBobeda", "Carga Refractaria Fundente") * dsbce.T_Indice_Consumo.FindByName("CentroBobeda");
                        w += dsbce.Q_ElementosProject.SearchCarga(s, "Proyectable", "Carga Refractaria Fundente") * dsbce.T_Indice_Consumo.FindByName("Proyectable");
                        w += dsbce.Q_ElementosProject.SearchCarga(s, "Apisonable", "Carga Refractaria Fundente") * dsbce.T_Indice_Consumo.FindByName("Apisonable");
                        w += dsbce.Q_ElementosProject.SearchCarga(s, "EscoriaRemanente", "Carga Refractaria Fundente") * Carga["Peso_EscoriaRem"];
                        w += dsbce.Q_ElementosProject.SearchCarga(s, "Cal", "Carga Refractaria Fundente") * Carga["Peso_Cal"];
                        w += dsbce.Q_ElementosProject.SearchCarga(s, "Dolomita", "Carga Refractaria Fundente") * Carga["Peso_Dolomita"];
                        w += dsbce.Q_ElementosProject.SearchCarga(s, "CenizaElectrodo", "Carga Refractaria Fundente") * dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo");
                        if (s != "CaO" && s != "MgO" && s != "S" && s != "Otros") 
                            w += General[s];
                    }


                    else
                        w = Carga[s] + OxidosDeCargas("MnO", anterior); 
                
                      
                
                r.Add(s + "_"+name, w);
            }
            return r;
        }
        public double ValorPonderado(int ecuacion1, int ecuacion2, String concepto, double CO, double CO2)
        {
            var A = dsbce.T_Balance_Ecuacion.GetEcuacion(ecuacion1, concepto);
            var B = dsbce.T_Balance_Ecuacion.GetEcuacion(ecuacion2, concepto);
            return (CO*A)/100 + (CO2*B)/100;
        }

        public Dictionary<String, double> GenerateList2(String nameelmento, String name2, List<String> Carga, object ACL, int i, Dictionary<String, Double> Result = null)
        {
            Dictionary<String, double> r = Result;
            if (Result == null)
                r = new Dictionary<string, double>();
            if (i == 0)
            {
                foreach (string s in Carga)

                    r.Add(s, (((Dictionary<String, double>) ACL)[s+ "_ACL"])*
                          dsbce.Q_ElementosProject.SearchCarga(name2, s, "Metalica")*
                          (dsbce.Q_ElementosProject.SearchCarga(nameelmento, "Peso Molecular", "Oxidos")/
                          dsbce.Q_ElementosProject.SearchCarga(nameelmento, "Peso Atomico", "Oxidos"))/100 != null ?
                          ((((Dictionary<String, double>) ACL)[s+ "_ACL"])*
                          dsbce.Q_ElementosProject.SearchCarga(name2, s, "Metalica")*
                          (dsbce.Q_ElementosProject.SearchCarga(nameelmento, "Peso Molecular", "Oxidos")/
                          dsbce.Q_ElementosProject.SearchCarga(nameelmento, "Peso Atomico", "Oxidos"))/100) : 0);
            }

            else
                foreach (KeyValuePair<string, String> keyValuePair in (Dictionary<String, String>) ACL)
                {
                    r.Add(keyValuePair.Key,
                          dsbce.Q_ElementosProject.SearchCarga("", keyValuePair.Value, "General")*
                          dsbce.Q_ElementosProject.SearchCarga(nameelmento, keyValuePair.Key,
                                                               "Carga Refractaria Fundente")*
                          (dsbce.Q_ElementosProject.SearchCarga(nameelmento, "Peso Molecular", "Oxidos")/
                           dsbce.Q_ElementosProject.SearchCarga(nameelmento, "Peso Atomico", "Oxidos")));
                }

            return r;
        }
        private void AddToDictionary(Dictionary<String,double > dictionary,String key,double value)
        {
            if (!dictionary.ContainsKey(key))
                dictionary.Add(key, value);
            else
                dictionary[key] = value;
        }
        private double GetFromDictionary(Dictionary<String,double > dictionary,String key)
        {
            if (dictionary.ContainsKey(key))
                return dictionary[key];
            return 0;
        }
        public Dictionary<String, double> Carga_Segun_Escoria_Metal(int idproject, Dictionary<String, double> General, Dictionary<String, double> Metal, Dictionary<String, double> Escoria, Dictionary<String, double> Carga, Dictionary<String , Double> Gases)
        {
            var elementos = new List<String>();
            var balance = new T_Balance_PropiedadTableAdapter();
            balance.Fill(dsbce.T_Balance_Propiedad);
       
            var elemtableapapter = new Q_ElementosProjectTableAdapter();
            elemtableapapter.Fill(dsbce.Q_ElementosProject, idproject);
            var ind = new T_Indice_ConsumoTableAdapter();
            ind.Fill(dsbce.T_Indice_Consumo);
            
            //AddToDictionary(Carga, "Peso_Carga_MetalicaTotal", Carga["Peso_Carga_MetalicaTotal"] * General["BaseAcero"] / General["AcLiquido"]);
            //AddToDictionary(Carga, "Peso_Cal", Carga["Cal_MasaTotal"] * General["BaseAcero"] / General["AcLiquido"]);
            //AddToDictionary(Carga, "Peso_Dolomita", Carga["Dolomita_MasaTotal"] * General["BaseAcero"] / General["AcLiquido"]);

            var flag = false;

            var Messages = new List<String>();
            var oxidos = new Dictionary<String, String>();
            oxidos.Add("SiO2", "Si");
            oxidos.Add("CaO", "Ca");
            oxidos.Add("MgO", "Mg");
            oxidos.Add("Al2O3", "Al");
            oxidos.Add("MnO", "Mn");
            oxidos.Add("FeO", "Fe");
            oxidos.Add("P2O5", "P");
            oxidos.Add("S", "S");
            oxidos.Add("Cr2O3","Cr");
            oxidos.Add("CO","C");

            var indices = new List<String>();
            indices.Add("LadrilloPared");
            indices.Add("CentroBobeda");
            indices.Add("Proyectable");
            indices.Add("Apisonable");
            var tipos = new List<String>();
            tipos.Add("Cal");
            tipos.Add("Dolomita");
            //tipos.Add("CenizaElectrodo");
            var oxidosres = new Dictionary<String, double>();
            foreach (var oxidow in oxidos)
            {
            
                var oxido = oxidow.Key;
                var pm = dsbce.Q_ElementosProject.SearchCarga(oxido, "Peso Molecular", "Oxidos");
                var pa = dsbce.Q_ElementosProject.SearchCarga(oxido, "Peso Atomico", "Oxidos");

                if(oxido == "CO")
                {
                    Gases["Peso"] = Gases["Masa"]*22.4;

                    oxidosres[oxido + "_Masa"] = 26*Gases["Masa"]/100;
                    oxidosres[oxido + "2_Masa"] = 12*Gases["Masa"]/100;
                    oxidosres[oxidow.Value + "_Carbono"] = (oxidosres[oxido + "_Masa"] * (dsbce.Q_ElementosProject.SearchCarga(oxido, "Peso Atomico", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga(oxido, "Peso Molecular", "Oxidos"))) +
                                                          (oxidosres[oxido + "2_Masa"] * (dsbce.Q_ElementosProject.SearchCarga(oxido+ "2", "Peso Atomico", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga(oxido+ "2", "Peso Molecular", "Oxidos")));
                }
                Jump:

                if (oxido == "SiO2" || oxido == "MnO" || oxido == "FeO" || oxido == "S" || oxido == "CO" )
                {
                    if (oxido != "FeO" && oxido != "S" && oxido != "CO")
                        oxidosres[oxido + "_ox"] = Escoria[oxido] * 0.5;
                    if (oxido != "S" && oxido != "CO")
                    oxidosres[oxido + "_AcLiq"] = (Metal[oxidow.Value] * General["BaseAcero"] / 100) * (pm / (pa));
                    else if(oxido == "S")
                    {
                        oxidosres[oxido + "_AcLiq"] = Metal[oxidow.Value]*General["BaseAcero"]/100;
                        oxidosres[oxido + "_ox"] = Escoria[oxido];
                    }
                    else if (oxido == "CO")
                        oxidosres[oxidow.Value + "_AcLiq"] = Metal[oxidow.Value] * General["BaseAcero"] / 100;
                }

                else if (oxido == "Al2O3" || oxido == "P2O5" || oxido == "Cr2O3")
                {
                    if (oxido != "Cr2O3")
                    oxidosres[oxido + "_ox"] = Escoria[oxido] * (pa/pm);
                    oxidosres[oxido + "_AcLiq"] = (Metal[oxidow.Value] * General["BaseAcero"] / 100) * (pm / (pa * 2));
                }

                if (oxido == "Cr2O3")
                    oxidosres[oxido + "_ox"] = Escoria[oxido] * (pa *2 / pm);

                if(oxido != "MnO" && oxido != "FeO")
                oxidosres.Add(oxido + "_ref",
                              indices.Sum(
                                  index =>
                                  dsbce.Q_ElementosProject.SearchCarga(oxido, index, "Carga Refractaria Fundente") *
                                  dsbce.T_Indice_Consumo.FindByName(index)));


                if (oxido == "CaO")
                    oxidosres.Add(oxido + "_Carga",
                                  Escoria[oxido] - (
                                  (((tipos
                                                                    .Sum(
                                                                        d =>
                                                                        ((dsbce.Q_ElementosProject.SearchCarga(oxido, d,
                                                                                                               "Carga Refractaria Fundente")) *
                                                                         GetFromDictionary(Carga, "Peso_" + d))

                                                                    ) +
                                                                dsbce.Q_ElementosProject.SearchCarga(oxido,
                                                                                                     "CenizaElectrodo",
                                                                                                     "Carga Refractaria Fundente") *
                                                                dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo"))) + oxidosres[oxido + "_ref"])));
                else if (oxido == "SiO2" )
                        oxidosres.Add(oxido + "_Carga",
                                      Escoria[oxido] + oxidosres[oxido + "_AcLiq"] - (
                                      (oxidosres[oxido + "_ox"] + ((tipos
                                                                        .Sum(
                                                                            t =>
                                                                            ((dsbce.Q_ElementosProject.SearchCarga(oxido, t,
                                                                                                                   "Carga Refractaria Fundente")) *
                                                                             GetFromDictionary(Carga, "Peso_" + t))

                                                                        ) +
                                                                    dsbce.Q_ElementosProject.SearchCarga(oxido,
                                                                                                         "CenizaElectrodo",
                                                                                                         "Carga Refractaria Fundente") *
                                                                    dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo"))) +
                                       oxidosres[oxido + "_ref"])));
                else if (oxido == "MgO")
                {
                    var sum = 0.0;
                    foreach (var t in tipos)
                    {
                        if (t != "CenizaElectrodo")
                            sum += dsbce.Q_ElementosProject.SearchCarga(oxido, t, "Carga Refractaria Fundente") * GetFromDictionary(Carga, "Peso_" + t);
                    }
                    oxidosres.Add(oxido + "_Carga", Escoria[oxido] - (sum + oxidosres[oxido + "_ref"]));
                }
                else if (oxido == "Al2O3")
                {
                    oxidosres.Add(oxido + "_Carga",
                               Escoria[oxido] + oxidosres[oxido + "_AcLiq"] - (oxidosres[oxido + "_ox"]+
                               (((tipos
                                                                 .Sum(
                                                                     t =>
                                                                     ((dsbce.Q_ElementosProject.SearchCarga(oxido, t,
                                                                                                            "Carga Refractaria Fundente")) *
                                                                      GetFromDictionary(Carga, "Peso_" + t))

                                                                 ) +
                                                             dsbce.Q_ElementosProject.SearchCarga(oxido,
                                                                                                  "CenizaElectrodo",
                                                                                                  "Carga Refractaria Fundente") *
                                                             dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo"))) + oxidosres[oxido + "_ref"])));
                }
                else if (oxido == "MnO" || oxido == "P2O5" || oxido == "Cr2O3")
                    oxidosres.Add(oxido + "_Carga", Escoria[oxido] + oxidosres[oxido + "_AcLiq"]);
                else if (oxido == "S")
                    oxidosres.Add(oxido + "_Carga", oxidosres[oxido + "_ox"] + oxidosres[oxido + "_AcLiq"]);
                else if(oxido == "FeO" && flag)
                {
                    oxidosres.Add(oxido + "_Carga", oxidosres[oxidow.Value + "_Carga"] * (pm/pa));
                    oxidosres.Add(oxido + "_Polvo", oxidosres[oxido + "_Carga"] - (oxidosres[oxido + "_AcLiq"] + Escoria[oxido]));

                }

                    

                //if (oxido == "Al203")
                //     oxidosres[oxidos + "_Carga"] = oxidosres[oxido + "_AcLiq"] - oxidosres[oxido + "_ox"] +
                //                                   oxidosres[oxido + "_ref"];
                // else
                //     oxidosres[oxido + "_Carga"] = GetFromDictionary(oxidosres, oxido + "_ox") + Metal[oxido];

                var s = 0.0;
                var e = 0.0;
                if (oxido != "CaO" && oxido != "MgO" && oxido != "Al2O3" && oxido != "MnO" && oxido!= "FeO" && oxido != "CO")
                {
                    s = Escoria[oxido] + oxidosres[oxido + "_AcLiq"];
                    e = oxidosres[oxido + "_ref"] + oxidosres[oxido + "_Carga"] + (tipos.Sum(
                       t =>
                       dsbce.Q_ElementosProject.SearchCarga(oxido, t, "Carga Refractaria Fundente") *
                       GetFromDictionary(Carga, "Peso_" + t)) +
                                                                                      dsbce.Q_ElementosProject.SearchCarga(
                                                                                          oxido, "CenizaElectrodo",
                                                                                          "Carga Refractaria Fundente") *
                                                                                      dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo"));
                }
                else if (oxido == "Al2O3")
                {
                    s = Escoria[oxido] + oxidosres[oxido + "_AcLiq"];
                    e = oxidosres[oxido + "_ref"] + oxidosres[oxido + "_Carga"] + oxidosres[oxido + "_ox"] +(tipos.Sum(
                       t =>
                       dsbce.Q_ElementosProject.SearchCarga(oxido, t, "Carga Refractaria Fundente") *
                       GetFromDictionary(Carga, "Peso_" + t)) +
                                                                                      dsbce.Q_ElementosProject.SearchCarga(
                                                                                          oxido, "CenizaElectrodo",
                                                                                          "Carga Refractaria Fundente") * dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo"));
                     
                }
                else if (oxido == "CaO")
                {
                    s = Escoria[oxido];
                    e = oxidosres[oxido + "_ref"] + oxidosres[oxido + "_Carga"] + (tipos.Sum(
                       t =>
                       dsbce.Q_ElementosProject.SearchCarga(oxido, t, "Carga Refractaria Fundente") *
                       GetFromDictionary(Carga, "Peso_" + t)) +
                                                                                      dsbce.Q_ElementosProject.SearchCarga(
                                                                                          oxido, "CenizaElectrodo",
                                                                                          "Carga Refractaria Fundente") *
                                                                                      dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo"));
                }
                else if (oxido == "MgO")
                {
                    var sum = 0.0;
                    foreach (var t in tipos)
                    {
                        if (t != "CenizaElectrodo")
                            sum += dsbce.Q_ElementosProject.SearchCarga(oxido, t, "Carga Refractaria Fundente") * GetFromDictionary(Carga, "Peso_" + t);
                    }
                    e = oxidosres[oxido + "_ref"] + oxidosres[oxido + "_Carga"] + sum;
                    s = Escoria[oxido];
                }
                
                else if (oxido == "MnO")
                {
                    e = oxidosres[oxido + "_Carga"] + oxidosres[oxido + "_ox"];
                    s = oxidosres[oxido + "_AcLiq"] + Escoria[oxido];

                }
                
                else if ((oxido == "FeO" && flag) || oxido == "P2O5" || oxido == "SO" || oxido =="Cr2O3")
                {
                    e = oxidosres[oxido + "_Carga"];

                    s = oxido == "FeO"
                            ? oxidosres[oxido + "_AcLiq"] + Escoria[oxido] + oxidosres[oxido + "_Polvo"]
                            : oxidosres[oxido + "_AcLiq"] + Escoria[oxido];
                }

                if (e != s)
                    Messages.Add("Balance de " + oxido + " Incorrecto");


                if (oxido == "FeO" && flag)
                {
                    oxidosres[oxido + "_Polvo"] = oxidosres[oxidow.Value + "_Carga"]*0.03*(pm/pa);
                    oxidosres[oxido + "_Carga"] = oxidosres[oxido + "_AcLiq"] + Escoria[oxido] +
                                                  oxidosres[oxido + "_Polvo"];
                    oxidosres[oxidow.Value + "_Carga"] = oxidosres[oxido + "_Carga"] * (pa / pm);
                }

                var c = (dsbce.Q_ElementosProject.SearchCarga(oxido, "Dolomita", "Carga Refractaria Fundente") * Carga["Peso_Dolomita"]);


                if (oxido == "CaO")
                    c +=
                        (dsbce.Q_ElementosProject.SearchCarga(oxido, "CenizaElectrodo", "General") *
                         dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo"));


                //////// Just FeO
                if (oxido == "FeO" && !flag)
                {
                    oxidosres[oxidow.Value + "_ox"] = Escoria[oxido] * (pa / pm);
                    oxidosres[oxidow.Value + "_Perdida"] = (oxidosres[oxidow.Value + "_ox"] * 100)/ 15;
                    oxidosres[oxidow.Value + "_Acero"] = Metal[oxidow.Value] * General["BaseAcero"] / 100;
                    oxidosres[oxidow.Value + "_Carga"] = oxidosres[oxidow.Value + "_Acero"] +
                                                         oxidosres[oxidow.Value + "_Perdida"];
                    flag = true;
                    goto Jump;
                }

                //////////////////
                if(oxido == "CO")
                {
                    oxidosres[oxidow.Value + "_Carga"] = oxidosres[oxidow.Value + "_AcLiq"] +
                                                         oxidosres[oxidow.Value + "_Carbono"] -
                                                         (Carga["Peso_Carbon"] +
                                                          dsbce.T_Indice_Consumo.FindByName("PuntaElectrodo"));
                    oxidosres[oxidow.Value + "_CargaPorciento"] = (oxidosres[oxidow.Value + "_Carga"]/
                                                                   (Carga["Peso_Carga_MetalicaTotal"] +
                                                                    Carga["Peso_Cal"] + Carga["Peso_Dolomita"] +
                                                                    Carga["Peso_Carbon"]))*100;
                    oxidosres[oxidow.Value + "_Perdida"] = oxidosres[oxidow.Value + "_Carga"] - oxidosres[oxidow.Value + "_AcLiq"];
                }
                if (oxido != "CaO" && oxido != "MgO" )
                {
                    if (oxido != "Al2O3" || oxido == "MnO" || oxido == "S" || oxido != "P2O5" || oxido != "Cr2O3")
                    {
                        if (oxido != "SO" && oxido != "CO")
                        {
                            oxidosres[oxidow.Value + "_Carga"] = oxidosres[oxido + "_Carga"]*pa/pm;
                            oxidosres[oxidow.Value + "_CargaPorciento"] = (oxidosres[oxidow.Value + "_Carga"]/
                                                                           (Carga["Peso_Carga_MetalicaTotal"] +
                                                                            Carga["Peso_Cal"] + Carga["Peso_Dolomita"]))*
                                                                          100;
                        }
                        if (oxido == "SO")
                            oxidosres[oxidow.Value + "_CargaPorciento"] = (oxidosres[oxido + "_Carga"] /
                                                                       (Carga["Peso_Carga_MetalicaTotal"] +
                                                                        Carga["Peso_Cal"] + Carga["Peso_Dolomita"])) * 100;
                    }

                
                    if (oxido == "Al2O3" || oxido == "P2O5" || oxido == "Cr2O3" )
                    {
                        if (oxido != "FeO" && oxido != "P2O5" && oxido != "Cr2O3")
                            oxidosres[oxidow.Value + "_ox"] = oxidosres[oxido + "_ox"]*(pa/pm);
                        else if ( oxido == "P2O5")
                        {
                            oxidosres[oxidow.Value + "_ox"] = Escoria[oxido] * (pa * 2 / pm);
                            oxidosres[oxidow.Value + "_Carga"] = oxidosres[oxido + "_Carga"] * (pa * 2 / pm);
                        }

                        if (oxido != "FeO" && oxido != "P2O5")
                            if(oxido != "Cr2O3")
                            oxidosres[oxidow.Value + "_Carga"] = oxidosres[oxidow.Value + "_ox"] + Metal[oxidow.Value];
                            else if (oxido == "Cr2O3")
                                oxidosres[oxidow.Value + "_Carga"] = oxidosres[oxido + "_ox"] + Metal[oxidow.Value];
                            oxidosres[oxidow.Value + "_CargaPorciento"] = (oxidosres[oxidow.Value + "_Carga"]/
                                                                           (Carga["Peso_Carga_MetalicaTotal"] +
                                                                            Carga["Peso_Cal"] + Carga["Peso_Dolomita"]))*
                                                                          100;
                        
                    }

                    if (oxido != "S" && oxido != "Cr2O3" && oxido != "CO")
                        oxidosres[oxidow.Value + "_Perdida"] = oxidosres[oxidow.Value + "_Carga"] -
                                                               ((Metal[oxidow.Value]*General["BaseAcero"])/100);
                    else if (oxido != "CO")oxidosres[oxidow.Value + "_Perdida"] = oxidosres[oxido + "_ox"];

                    if (oxido != "CO")
                    oxidosres[oxidow.Value + "_PerdidaPorciento"] = (oxidosres[oxidow.Value + "_Perdida"]/
                                                                     oxidosres[oxido + "_Carga"])*100;
                    if (oxido == "FeO")
                        oxidosres[oxidow.Value + "_PolvoPorciento"] = oxidosres[oxido + "_Polvo"]*100/
                                                                      (oxidosres[oxidow.Value + "_Carga"]*(pm/pa));

                }
                if(oxido != "CO")
                if (oxidosres[oxido + "_Carga"] > 0 )
                {
                    if (oxido == "MgO")
                        oxidosres[oxido + "_Cal"] = Escoria[oxido] - (dsbce.Q_ElementosProject.SearchCarga(oxido, "Dolomita", "Carga Refractaria Fundente") * GetFromDictionary(Carga, "Peso_" + "Dolomita") + oxidosres[oxido + "_ref"] + oxidosres[oxido + "_Carga"]);
                    else if (oxido == "Al2O3")
                    {
                        c += (dsbce.Q_ElementosProject.SearchCarga(oxido, "CenizaElectrodo", "Carga Refractaria Fundente") * dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo"));
                        oxidosres[oxido + "_Cal"] = Escoria[oxido] + oxidosres[oxido + "_AcLiq"] - (c + oxidosres[oxido + "_ref"] + oxidosres[oxido + "_Carga"] + oxidosres[oxido + "_ox"]);
                    }
                    else if (oxido != "SiO2" && oxido != "MnO" && oxido != "FeO" && oxido != "P2O5" && oxido != "S")
                        oxidosres[oxido + "_Cal"] = (Escoria[oxido] - (c + oxidosres[oxido + "_ref"] + oxidosres[oxido + "_Carga"]));
                    
                }
                else if (oxido != "CO")
                {
                    if (oxido == "MgO")
                        oxidosres[oxido + "_Cal"] = Escoria[oxido] - (dsbce.Q_ElementosProject.SearchCarga(oxido, "Dolomita", "Carga Refractaria Fundente") * GetFromDictionary(Carga, "Peso_" + "Dolomita") + oxidosres[oxido + "_ref"] );
                    else if (oxido == "Al2O3") 
                        oxidosres[oxido + "_Cal"] = (Escoria[oxido] + oxidosres[oxido + "_AcLiq"]- c + oxidosres[oxido + "_ref"]);
                    else if (oxido != "SiO2" && oxido != "MnO" && oxido != "FeO" && oxido !="P2O5" && oxido != "SO")
                        oxidosres[oxido + "_Cal"] = (Escoria[oxido] - c + oxidosres[oxido + "_ref"]);

                }

                if (oxido != "SiO2" && oxido != "MnO" && oxido != "FeO" && oxido != "P2O5" && oxido != "S" && oxido != "CO")
                    oxidosres[oxido + "_CalReal"] = (oxidosres[oxido + "_Cal"] * 100) / Carga["Peso_Cal"];

                    

               
            }
            

            return oxidosres;


        }

        public Dictionary<String, Dictionary<string, double>> Escoria_Segun_Carga_Metal(int idpatron, Dictionary<String, double> General, Dictionary<String, double> Metal, Dictionary<String, double> Carga, Dictionary<String, double> Gases, bool def)
        {
            var ecuc = new T_Balance_EcuacionTableAdapter();
            ecuc.Fill(dsbce.T_Balance_Ecuacion);
            var balance = new T_Balance_PropiedadTableAdapter();
            balance.Fill(dsbce.T_Balance_Propiedad);


            //VARIABLES K SE DEVUELVEN
            var r = new Dictionary<String, Dictionary<string, double>>();
            var Totales = new Dictionary<String, double>();
            var DevGases = new Dictionary<String, double>();
            var otros = new Dictionary<string, double>();
            var elemtableapapter = new Q_ElementosProjectTableAdapter();
            elemtableapapter.Fill(dsbce.Q_ElementosProject, idpatron);
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
            var Oxigeno_EficInyectado = 75.0;
            var Fe_Metal = 100 -
                           (Metal["Si"] + Metal["Al"] + Metal["Mn"] + Metal["P"] + Metal["S"] + Metal["Cr"] +
                            Metal["C"]);
            var Carga_Acl = GenerateList(Cargas, "ACL", General, Metal, Carga, 0);
            var Tot_Carga_T = Carga.Sum(t => t.Key.IndexOf("Peso") == -1 || t.Key.IndexOf("Masa") != -1 ? t.Value : 0);

            var Tot_Carga = Carga_Acl.Sum(t => t.Value);
            Totales.Add("Total de Carga en T", Tot_Carga_T);
            Totales.Add("Total de Carga en Kg", Tot_Carga);
            r.Add("Masa de la Carga", Carga_Acl);


            var MetalACL = GenerateList(Elementos, "Acl", General, Metal, Carga, 1);

            r.Add("Proporción de Elementos kg/TAC", MetalACL);

            if (MetalACL["Fe_Acl"] <= 0)
            {
                Metal["Fe"] = 100 - MetalACL.Sum(t => t.Value);
                MetalACL["Fe_Acl"] = (Metal["Fe"] * General["BaseAcero"]) / 100;
            }



            var res = Elementos.ToDictionary(elemento => elemento, elemento => GenerateList(Cargas, elemento, General, Metal, Carga, 2, Carga_Acl));





            var Perdida = new Dictionary<String, double>();
            var PerdidaP = new Dictionary<String, double>();
            var Fe_Escoria = 0.0;
            var m = 0.0;
            var value = 0.0;
            for (int index = 0; index < Elementos.Count; index++)
            {

                string elemento = Elementos[index];

                var tot = res[elemento].Sum(t => t.Value);


                m = MetalACL[elemento + "_Acl"];
                value = tot - m;
                if (elemento == "Fe")
                    Fe_Escoria = value * 0.15;

                Perdida.Add(elemento + "_Perdida", value);
                PerdidaP.Add(elemento + "_PorcPerdida", value / tot * 100);

            }



            var Polvo = GenerateList(Cargas, "PolvoFe", General, Metal, Carga, 3, res["Fe"]);
            var Tot_Fe_Polvo = Polvo.Sum(t => t.Value);
            var Fe_Total2 = res["Fe"].Sum(t => t.Key.IndexOf("Pie") == -1 ? t.Value : 0);
            var Tot_Fe_PolvoPorciento = (Tot_Fe_Polvo / Fe_Total2) * 100;
            var Total_FeOxidoPolvo = Tot_Fe_Polvo *
                                     (dsbce.Q_ElementosProject.SearchCarga("FeO", "Peso Molecular", "Oxidos") /
                                      dsbce.Q_ElementosProject.SearchCarga("FeO", "Peso Atomico", "Oxidos"));
            var Total_FeO_PolvoPorciento = (Total_FeOxidoPolvo / Perdida["Fe_Perdida"]) * 100;
            var Total_FeOoxigenoPolvo = Total_FeOxidoPolvo - Tot_Fe_Polvo;




            var oxidos = new Dictionary<String, String>();
            oxidos.Add("MnO", "Mn");
            oxidos.Add("SiO2", "Si");
            oxidos.Add("P2O5", "P");
            oxidos.Add("FeO", "Fe");
            oxidos.Add("Al2O3", "Al");
            oxidos.Add("Cr2O3", "Cr");
            var oxidosformados = new Dictionary<String, double>();
            var oxidosrequeridos = new Dictionary<String, double>();
            foreach (KeyValuePair<string, string> keyValuePair in oxidos)
            {
                var p1 = 0.0;
                var p2 = 0.0;

                p1 = Perdida[keyValuePair.Value + "_Perdida"];
                if (keyValuePair.Key == "MnO" || keyValuePair.Key == "SiO2" || keyValuePair.Key == "FeO")
                    p2 = (dsbce.Q_ElementosProject.SearchCarga(keyValuePair.Key, "Peso Molecular", "Oxidos") /
                          dsbce.Q_ElementosProject.SearchCarga(keyValuePair.Key, "Peso Atomico", "Oxidos"));
                else
                    p2 = (dsbce.Q_ElementosProject.SearchCarga(keyValuePair.Key, "Peso Molecular", "Oxidos") /
                          (dsbce.Q_ElementosProject.SearchCarga(keyValuePair.Key, "Peso Atomico", "Oxidos") * 2));
                if (keyValuePair.Key == "FeO")
                {
                    oxidosformados.Add(keyValuePair.Key, Fe_Escoria * p2);
                    oxidosrequeridos.Add(keyValuePair.Key, Fe_Escoria * p2 - Fe_Escoria);
                }
                else
                {
                    oxidosformados.Add(keyValuePair.Key, p1 * p2);
                    oxidosrequeridos.Add(keyValuePair.Key, p1 * p2 - p1);
                }

            }
            oxidos.Add("CaO", "");
            oxidos.Add("MgO", "");
            oxidos.Add("Otros", "");




            var Escoria = GenerateList(oxidos.Keys.ToList(), "Esc", oxidosformados, Metal, Carga, 4, Carga_Acl);
            var igniciond = new Dictionary<String, String>();
            igniciond.Add("HBI", "Carbon");
            igniciond.Add("ChatarraLigera", "Dolomita");
            igniciond.Add("Escarpa", "Cal");
            igniciond.Add("HierroFundido", "LadrilloPared");
            igniciond.Add("ChatarraPesada", "CentroBobeda");
            igniciond.Add("Paca", "");
            igniciond.Add("HRD", "");


            var Ignicion = new Dictionary<String, double>();
            foreach (KeyValuePair<string, string> keyValuePair in igniciond)

                Ignicion.Add(keyValuePair.Key + "_Ignicion",
                             Carga_Acl[keyValuePair.Key + "_ACL"] *
                             dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", keyValuePair.Key, "Metalica") / 100);
            igniciond.Clear();
            igniciond.Add("Cal", "Peso_Cal");
            igniciond.Add("Dolomita", "Peso_Dolomita");
            igniciond.Add("Carbon", "Peso_Carbon");
            foreach (KeyValuePair<string, string> keyValuePair in igniciond)
                Ignicion.Add(keyValuePair.Key + "_Ignicion",
                             Carga[keyValuePair.Value] *
                             dsbce.Q_ElementosProject.SearchCarga("P.Ignicion", keyValuePair.Key, "Carga Refractaria Fundente"));

            var Ignicion_Total = Ignicion.Sum(t => t.Value);

            var CO = Carga["CO"];
            var CO2 = Carga["CO2"];
            if (CO <= 0)
                CO = 85;
            if (CO2 <= 0)
                CO2 = 15;
            var valoresPonderados = new Dictionary<String, double>();
            valoresPonderados.Add("PCombCarbono", ValorPonderado(8, 9, "Concepto1", CO, CO2));
            if (Carga["HRD"] >= 0)
            {
                valoresPonderados.Add("PCombCementita", ValorPonderado(11, 12, "Concepto1", CO, CO2));
                valoresPonderados.Add("PesoFeO", ValorPonderado(2, 3, "Concepto1", CO, CO2));
                valoresPonderados.Add("PesoFe2O3", ValorPonderado(0, 1, "Concepto1", CO, CO2));
                valoresPonderados.Add("EnergiaFeO", ValorPonderado(2, 3, "Concepto4", CO, CO2));
                valoresPonderados.Add("EnergiaFe2O3", ValorPonderado(0, 1, "Concepto4", CO, CO2));
                valoresPonderados.Add("EnergiaFe2O3_2", ValorPonderado(4, 5, "Concepto4", CO, CO2));
                valoresPonderados.Add("EnergiaFeO_2", ValorPonderado(6, 7, "Concepto4", CO, CO2));
                valoresPonderados.Add("EnergiaFeO_3", ValorPonderado(4, 5, "Concepto4", CO, CO2));
                valoresPonderados.Add("EnergiaFe_3", ValorPonderado(6, 7, "Concepto4", CO, CO2));
            }
            else
            {
                valoresPonderados.Add("PesoFeO", ValorPonderado(6, 7, "Concepto2", CO, CO2));
                valoresPonderados.Add("PesoFe2O3", ValorPonderado(4, 5, "Concepto2", CO, CO2));
            }




            var FeO_Carga = GenerateList2("FeO", "Fe++", Cargas, Carga_Acl, 0);
            GenerateList2("FeO", "Fe++", Cargas, igniciond, 1, FeO_Carga);

            var Feo2O3_Carga = GenerateList2("Fe2O3", "Fe2O3", Cargas, Carga_Acl, 0);
            GenerateList2("Fe2O3", "Fe2O3", Cargas, igniciond, 1, Feo2O3_Carga);
            var CFEO_Reduc = new Dictionary<String, double>();
            var CFe2O3_Reduc = new Dictionary<String, double>();
            var C_Reduc = new Dictionary<String, double>();
            foreach (var carga in Cargas)
            {
                CFEO_Reduc.Add(carga, FeO_Carga[carga] / valoresPonderados["PesoFeO"]);
                CFe2O3_Reduc.Add(carga, Feo2O3_Carga[carga] / valoresPonderados["PesoFe2O3"]);
                C_Reduc.Add(carga, FeO_Carga[carga] + Feo2O3_Carga[carga]);
            }


            foreach (KeyValuePair<string, string> keyValuePair in igniciond)
            {
                CFEO_Reduc.Add(keyValuePair.Key, FeO_Carga[keyValuePair.Key] / valoresPonderados["PesoFeO"]);
                CFe2O3_Reduc.Add(keyValuePair.Key, Feo2O3_Carga[keyValuePair.Key] / valoresPonderados["PesoFe2O3"]);
                C_Reduc.Add(keyValuePair.Key, FeO_Carga[keyValuePair.Key] + Feo2O3_Carga[keyValuePair.Key]);
            }
            var OxFeo_Reduccon = new Dictionary<String, double>();
            var OxFeo2O3_Reduccon = new Dictionary<String, double>();
            var Ox_Reduccon = new Dictionary<String, double>();
            foreach (var carga in Cargas)
            {
                OxFeo_Reduccon.Add(carga, FeO_Carga[carga] * dsbce.Q_ElementosProject.SearchCarga("O", "Peso Atomico", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga("FeO", "Peso Molecular", "Oxidos"));
                OxFeo2O3_Reduccon.Add(carga, Feo2O3_Carga[carga] * dsbce.Q_ElementosProject.SearchCarga("O", "Peso Atomico", "Oxidos") != 0 ? Feo2O3_Carga[carga] * dsbce.Q_ElementosProject.SearchCarga("O", "Peso Atomico", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga("Fe2O3", "PesoMolecular", "Oxidos") : 0);
                Ox_Reduccon.Add(carga, OxFeo_Reduccon[carga] + OxFeo2O3_Reduccon[carga]);
            }
            foreach (KeyValuePair<string, string> keyValuePair in igniciond)
            {
                OxFeo_Reduccon.Add(keyValuePair.Key, FeO_Carga[keyValuePair.Key] * dsbce.Q_ElementosProject.SearchCarga("O", "Peso Atomico", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga("FeO", "Peso Molecular", "Oxidos"));
                OxFeo2O3_Reduccon.Add(keyValuePair.Key, Feo2O3_Carga[keyValuePair.Key] * dsbce.Q_ElementosProject.SearchCarga("O", "Peso Atomico", "Oxidos") != 0 ? Feo2O3_Carga[keyValuePair.Key] * dsbce.Q_ElementosProject.SearchCarga("O", "Peso Atomico", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga("Fe2O3", "Peso Molecular", "Oxidos") : 0);
                Ox_Reduccon.Add(keyValuePair.Key, OxFeo_Reduccon[keyValuePair.Key] + OxFeo2O3_Reduccon[keyValuePair.Key]);
            }



            var PesoCO_1 = dsbce.Q_ElementosProject.SearchCarga("CO", "Peso Molecular", "Oxidos");
            var PesoCO_2 = dsbce.Q_ElementosProject.SearchCarga("CO", "Peso Atomico", "Oxidos");
            var PesoCO2_1 = dsbce.Q_ElementosProject.SearchCarga("CO2", "Peso Molecular", "Oxidos");

            var PesoCO2_2 = dsbce.Q_ElementosProject.SearchCarga("CO2", "Peso Atomico", "Oxidos");
            var RelEsp_C_CO = (CO * (PesoCO_1 / PesoCO_2)) / 100;
            var RelEsp_C_CO2 = (CO2 * (PesoCO2_1 / PesoCO2_2)) / 100;
            var Cant_CO = Perdida["C" + "_Perdida"] * RelEsp_C_CO;
            var Cant_CO2 = Perdida["C" + "_Perdida"] * RelEsp_C_CO2;
            var PesoAtomicoO = dsbce.Q_ElementosProject.SearchCarga("O", "Peso Atomico", "Oxidos");
            var PesoMolecularO = dsbce.Q_ElementosProject.SearchCarga("O", "Peso Molecular", "Oxidos");
            var PesoAtomicoCO2 = dsbce.Q_ElementosProject.SearchCarga("CO", "Peso Atomico", "Oxidos");
            var PesoMolecularCO2 = dsbce.Q_ElementosProject.SearchCarga("CO", "Peso Molecular", "Oxidos");
            var PesoAtomicoCO = dsbce.Q_ElementosProject.SearchCarga("CO", "Peso Atomico", "Oxidos");
            var PesoMolecularCO = dsbce.Q_ElementosProject.SearchCarga("CO", "Peso Molecular", "Oxidos");
            var PesoAtomicoC = dsbce.Q_ElementosProject.SearchCarga("C", "Peso Atomico", "Oxidos");
            var PesoMolecularC = dsbce.Q_ElementosProject.SearchCarga("C", "Peso Molecular", "Oxidos");

            var Cant_CO_Electrodo = dsbce.T_Indice_Consumo.FindByName("PuntaElectrodo") * RelEsp_C_CO;
            var Cant_CO2_Electrodo = dsbce.T_Indice_Consumo.FindByName("PuntaElectrodo") * RelEsp_C_CO2;
            var Ox_form_C = (((Perdida["C" + "_Perdida"] * CO) / 100) * (PesoCO_1 / PesoCO_2)) +
                            (((Perdida["C" + "_Perdida"] * CO2) / 100) * (PesoCO2_1 / PesoCO2_2));
            var Ox_Req_C = Ox_form_C - Perdida["C" + "_Perdida"];

            var Ox_Reg_Carbon = (((Carga["Peso_Carbon"] * CO) / 100) * (PesoAtomicoO / PesoAtomicoC)) +
                                (((Carga["Peso_Carbon"] * CO2) / 100) * ((PesoAtomicoO * 2) / PesoAtomicoC));
            var Ox_Reg_Electrodo = (((dsbce.T_Indice_Consumo.FindByName("PuntaElectrodo") * CO) / 100) *
                                    (PesoMolecularC / PesoAtomicoC)) +
                                   (((dsbce.T_Indice_Consumo.FindByName("PuntaElectrodo") * CO2) / 100) *
                                    ((PesoAtomicoO * 2) / PesoAtomicoC));
            var Ox_Descarburacion = Ox_Req_C + Ox_Reg_Carbon + Ox_Reg_Electrodo;
            var Ox_Escoria = Escoria["FeO_Esc"] * (PesoAtomicoO / dsbce.Q_ElementosProject.SearchCarga("FeO", "Peso Atomico", "Oxidos"));
            var Sum_Ox_FeO = OxFeo_Reduccon.Sum(t => t.Value);

            var Sum_Ox_Fe2O3 = OxFeo2O3_Reduccon.Sum(t => t.Value);

            var Ox_FeOFe2O3_Cargado = Ox_Reduccon.Sum(t => t.Value);
            var Ox_Gas_Descarb = ((Ox_Descarburacion + Ox_Escoria) - Ox_FeOFe2O3_Cargado) / (Oxigeno_EficInyectado / 100);
            var Ox_Elementos = oxidosrequeridos.Sum(t => t.Value) + Ox_Reg_Electrodo;
            var AInfil_Aire = Gases["DensidadAire"] * Gases["VolumenAire"];
            var AInfil_Nitrogeno = Gases["DensidadNitrogeno"] * Gases["VolumenNitrogeno"];
            var AInfil_Oxigeno = Gases["DensidadOxigeno"] * Gases["VolumenOxigeno"];
            var Ox_Gas_Ox = (Ox_Elementos - (Ox_Escoria + AInfil_Oxigeno)) / (Oxigeno_EficInyectado / 100);
            var Ox_Gas_Total = Ox_Gas_Descarb + Ox_Gas_Ox;
            var Ox_Libre = Ox_Gas_Total * ((100 - Oxigeno_EficInyectado) / 100);




            var Messages = new List<String>();
            var Entradas = Sum_Ox_FeO + Sum_Ox_Fe2O3 + AInfil_Oxigeno + Ox_Gas_Total;
            var Salidas = Ox_Elementos + Ox_Req_C + Ox_Reg_Carbon + Ox_Libre;
            if (Entradas != Salidas) Messages.Add("Balance de Oxigeno incorrecto");
            var CaO_ref = (dsbce.Q_ElementosProject.SearchCarga("CaO", "LadrilloPared", "Carga Refractaria Fundente") *
                            dsbce.T_Indice_Consumo.FindByName("LadrilloPared"))
                          +
                          (dsbce.Q_ElementosProject.SearchCarga("CaO", "CentroBobeda", "Carga Refractaria Fundente") *
                            dsbce.T_Indice_Consumo.FindByName("CentroBobeda"))
                          +
                          (dsbce.Q_ElementosProject.SearchCarga("CaO", "Proyectable", "Carga Refractaria Fundente") *
                            dsbce.T_Indice_Consumo.FindByName("Proyectable"))
                          +
                          (dsbce.Q_ElementosProject.SearchCarga("CaO", "Apisonable", "Carga Refractaria Fundente") *
                            dsbce.T_Indice_Consumo.FindByName("Apisonable"));
            var CaO_Carga = Escoria["CaO_Esc"] -
                            ((dsbce.Q_ElementosProject.SearchCarga("CaO", "Cal", "Carga Refractaria Fundente") * Carga["Peso_Cal"])
                             +
                             (dsbce.Q_ElementosProject.SearchCarga("CaO", "Dolomita", "Carga Refractaria Fundente") *
                              Carga["Peso_Dolomita"])
                             +
                             (dsbce.Q_ElementosProject.SearchCarga("CaO", "CenizaElectrodo",
                                                                   "Carga Refractaria Fundente") *
                               dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo"))
                             + CaO_ref);

            Entradas = CaO_Carga + ((dsbce.Q_ElementosProject.SearchCarga("CaO", "Cal", "Carga Fundente") * Carga["Peso_Cal"])
                                    + (dsbce.Q_ElementosProject.SearchCarga("CaO", "Dolomita", "Carga Fundente") * Carga["Peso_Dolomita"])
                                    + (dsbce.Q_ElementosProject.SearchCarga("CaO", "CenizaElectrodo", "Carga Fundete") * dsbce.T_Indice_Consumo.FindByName("CenizaElectrodo"))
                                    + CaO_ref);
            Salidas = Escoria["CaO_Esc"];
            if (Entradas != Salidas) Messages.Add("Balance de Oxido de Calcio incorrecto");
            if (CaO_Carga < 0) CaO_Carga = 0;
            var Si_ConvSiO2 = res["Si"].Sum(t => t.Value) * (dsbce.Q_ElementosProject.SearchCarga("SiO2", "Peso Molecular", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga("SiO2", "Peso Atomico", "Oxidos"));
            var SiO2_Carga = OxidosDeCargas("SiO2", Carga_Acl);
            var SiO2_AcLiq = MetalACL["Si_Acl"] * (dsbce.Q_ElementosProject.SearchCarga("SiO2", "Peso Molecular", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga("SiO2", "Peso Atomico", "Oxidos"));
            Entradas = Si_ConvSiO2 + SiO2_Carga;
            Salidas = Escoria["SiO2_Esc"] + SiO2_AcLiq;
            if (Entradas != Salidas) Messages.Add("Balance de Oxido de Silicio incorrecto");


            var Al2O3_Carga = oxidosformados["SiO2"] +
                              OxidosDeCargas("Al2O3", Carga_Acl);
            var Al_ConvAl2O3 = res["Al"].Sum(t => t.Value) * (dsbce.Q_ElementosProject.SearchCarga("Al2O3", "Peso Molecular", "Oxidos") / (dsbce.Q_ElementosProject.SearchCarga("Al2O3", "Peso Atomico", "Oxidos") * 2));
            var Al2O3_AcLiq = MetalACL["Al_Acl"] * (dsbce.Q_ElementosProject.SearchCarga("Al2O3", "Peso Molecular", "Oxidos") / (dsbce.Q_ElementosProject.SearchCarga("Al2O3", "Peso Atomico", "Oxidos") * 2));
            Entradas = Al_ConvAl2O3 + Al2O3_Carga;
            Salidas = Escoria["Al2O3_Esc"] + Al2O3_AcLiq;
            if (Entradas != Salidas) Messages.Add("Balance de Alumina incorrecto");
            var MnO_Carga = OxidosDeCargas("MnO", Carga_Acl);
            var Mn_ConvMnO = res["Mn"].Sum(t => t.Value) * (dsbce.Q_ElementosProject.SearchCarga("MnO", "Peso Molecular", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga("MnO", "Peso Atomico", "Oxidos"));
            var MnO_AcLiq = MetalACL["Mn_Acl"] * (dsbce.Q_ElementosProject.SearchCarga("MnO", "Peso Molecular", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga("MnO", "Peso Atomico", "Oxidos"));
            Entradas = Mn_ConvMnO + MnO_Carga;
            Salidas = Escoria["MnO_Esc"] + MnO_AcLiq;
            if (Entradas != Salidas) Messages.Add("Balance de Oxido de Manganeso incorrecto");
            var FeO_Carga1 = OxidosDeCargas("FeO", Carga_Acl);
            var Fe_ConvFeO = res["Fe"].Sum(t => t.Value) * (dsbce.Q_ElementosProject.SearchCarga("FeO", "Peso Molecular", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga("FeO", "Peso Atomico", "Oxidos"));
            var FeO_AcLiq = MetalACL["Fe_Acl"] * (dsbce.Q_ElementosProject.SearchCarga("FeO", "Peso Molecular", "Oxidos") / dsbce.Q_ElementosProject.SearchCarga("FeO", "Peso Atomico", "Oxidos"));
            Entradas = Fe_ConvFeO + FeO_Carga1;
            Salidas = Escoria["FeO_Esc"] + FeO_AcLiq + Total_FeOxidoPolvo;
            if (Entradas != Salidas) Messages.Add("Balance de Oxido de Hierro incorrecto");
            var tw = new Dictionary<String, double>();
            foreach (string elemento in Elementos)
                tw.Add(elemento, res[elemento].Sum(t => t.Value) + OxidosDeCargas(elemento, Carga_Acl));

            foreach (KeyValuePair<string, Dictionary<string, double>> keyValuePair in res)
            {
                Totales.Add("Total del Elemento " + keyValuePair.Key + " en  kg/TAC", keyValuePair.Value.Sum(t => t.Value));
                Totales.Add("Total del Elemento " + keyValuePair.Key + " en  %", keyValuePair.Value.Sum(t => t.Value) / Tot_Carga * 100);

            }
            Totales.Add("Total de Hierro en Polvo", Tot_Fe_Polvo);
            Totales.Add("Total de Hierro en Polvo en Porciento ", Tot_Fe_PolvoPorciento);
            Totales.Add("Total de Ignicion ", Ignicion_Total);


            foreach (var reses in res)
                r.Add("Balance de Metal Fundido de " + reses.Key + " en %", reses.Value);

            r.Add("Perdida de Elements en kg/t AL", Perdida);
            r.Add("Perdida de Elementos en %", PerdidaP);

            r.Add("Concentración de Hierro en Polvo en Carga Metálica ", Polvo);
            r.Add("Oxidos en la escoria ", oxidosformados);
            r.Add("Cantidad de Oxigeno requerido por elemento ", oxidosrequeridos);
            r.Add("Composición de la Escoria por Elemento ", Escoria);
            r.Add("Determinación de Perdida por Ignicion ", Ignicion);
            r.Add("Ponderación de Hiero en Post Combustión ", valoresPonderados);
            r.Add("Carga de Óxido de Hierro en la Carga Metalica ", FeO_Carga);
            r.Add("Carga de Óxido de Hierro 3 en la Carga Metalica ", Feo2O3_Carga);
            r.Add("Carbono para Reduccion de Óxido de Hierro II", CFEO_Reduc);
            r.Add("Carbono para Reduccion de Óxido de Hierro III ", CFe2O3_Reduc);
            r.Add("Carbono para Reduccion de Hierro", C_Reduc);
            r.Add("Contenido de Oxigeno para Reduccion de Óxido de Hierro II", OxFeo_Reduccon);
            r.Add("Contenido de Oxigeno para Reduccion de Óxido de Hierro III", OxFeo2O3_Reduccon);
            r.Add("Contenido de Oxigeno para Reducir Hierro", Ox_Reduccon);
            DevGases.Add("Cantidad de Monóxido de Carbono ", Cant_CO);
            DevGases.Add("Cantidad de Dióxido de Carbono ", Cant_CO2);
            DevGases.Add("Cantidad de Electrodos de Monóxido de Carbono ", Cant_CO_Electrodo);
            DevGases.Add("Cantidad de Electrodos de Dióxido de Carbono ", Cant_CO2_Electrodo);
            DevGases.Add("Cantidad de Oxígeno formado en el Carbono ", Ox_form_C);
            DevGases.Add("Cantidad de Oxígeno requerido para la descarburación ", Ox_Descarburacion);
            DevGases.Add("Cantidad de Oxígeno en la escoria ", Ox_Escoria);
            DevGases.Add("Cantidad de Óxido requerido en el Carbono ", Ox_Req_C);
            otros.Add("Óxido de Calcio refractario ", CaO_ref);
            otros.Add("Óxido de Calcio en carga metálica ", CaO_Carga);
            otros.Add("Óxido de Silicio en carga metálica", SiO2_Carga);
            otros.Add("Óxido de Silicio en acero líquido", SiO2_AcLiq);
            otros.Add("Óxido de Aluminio en acero líquido", Al2O3_AcLiq);
            otros.Add("Óxido de Aluminio en carga metálica", Al2O3_Carga);
            otros.Add("Óxido de Manganeso en acero líquido", MnO_AcLiq);
            otros.Add("Óxido de Manganeso en carga metálica", MnO_Carga);
            otros.Add("Óxido de Hierro en carga metálica", FeO_Carga1);
            otros.Add("Óxido de Hierro en acero líquido", FeO_AcLiq);

            r.Add("Datos de los Gases", DevGases);
            r.Add("Datos de los Metales", otros);


            int i;

            foreach (KeyValuePair<string, Dictionary<string, double>> keyValuePair in r)
            {
                try
                {
                    foreach (KeyValuePair<string, double> valuePair in keyValuePair.Value)
                    {
                        try
                        {
                            if (valuePair.Value != 0)
                            {
                                keyValuePair.Value[valuePair.Key] = Math.Round(valuePair.Value, 4);
                            }
                        }
 catch (Exception) { }

                    }
                }
                catch (Exception) { }
               
            }
            return r;
        }



        private double OxidosDeCargas(string oxido,Dictionary<String,double> value)
        {
            return 0;
        }

       

     
        
    }
}
