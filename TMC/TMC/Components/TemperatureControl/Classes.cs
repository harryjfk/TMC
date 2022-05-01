using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using TMC.RD;
using TMC.RD.DSRDTableAdapters;

namespace TMC.Components.TemperatureControl
{
    [Serializable]
    public class Elemento
    {
        public Elemento(DSRD.T_ElementoRow t_ElementoRow)
        {
            Name = t_ElementoRow.nameelemento;
            Codigo = t_ElementoRow.codelemento;
        }
        public String Name { get; set; }
        public String Codigo { get; set; }

    }
    [Serializable]
    public class ElementoOxido
    {

        public Elemento Elemento { get; set; }
        public double NumElectrones { get; set; }
        public double GradoAcides { get; set; }
        public String Porciento { get; set; }
        public ElementoOxido (DSRD.T_Propiedad_Fisica_ElementoRow row)
        {
            Elemento = new Elemento(row.T_Elemento_OxidoRow.T_ElementoRow);
            Porciento = row.Porciento;
            NumElectrones = row.T_Elemento_OxidoRow.num_Electrones;
            GradoAcides = row.T_Elemento_OxidoRow.grado_acides;
       
            GradoPH = row.T_Elemento_OxidoRow.T_Grado_PHRow.Nombre;
        }

        public string GradoPH { get; set; }
    }
    [Serializable]
    public class TipoFormato
    {
        public TipoFormato(DSRD.T_Tipo_FormatoRow variable)
        {
            Name = variable.Nombre;
            Image = variable.Imagen;
        }

        public String Name { get; set; }
        public Byte[] Image { get; set; }

    }
    [Serializable]
    public class Formato
    {
     

        public Formato(DSRD.T_FormatoRow VARIABLE)
        {
            TipoFormato = new TipoFormato(VARIABLE.T_Tipo_FormatoRow);
            Altura = VARIABLE.altura;
            Espesor = VARIABLE.Espesor;
            Largo = VARIABLE.Largo1;
            Largo2 = VARIABLE.Largo2;
            Radio = VARIABLE.Radio;
            Costo = VARIABLE.Costo;
            Name = VARIABLE.Nombre;
        }
        public TipoFormato TipoFormato { get; set; }
        public double Altura { get; set; }
        public double Espesor { get; set; }
        public double Largo { get; set; }
        public double Largo2 { get; set; }
        public double Radio { get; set; }
        public double Costo { get; set; }
        public String Name { get; set; }
    }
    [Serializable] 
    public class Material
    {
        private List<Formato> _formatos =new List<Formato>();
        private List<ElementoOxido> _elementos =new List<ElementoOxido>();
        public String Name { get; set; }
        public String Comentario { get; set; }
        public byte[] Data { get; set; }
        //Propiedad Fisicas
        public double Densidad { get; set; }
        public double Porosidad { get; set; }
        public String NamePh { get; set; }
        public List<ElementoOxido> Elementos { get { return _elementos; } }
        public double IndiceSilacatacion { get; set; }
        //Produccion
        public double Costo { get; set; }
        public List<Formato> Formatos { get { return _formatos; } } 
        //termodinamica
        public String Temperatura { get; set; }

        public double Espesor { get; set; }
        public Material (DSRD.T_MaterialRow row)
        {
            Name = row.namematerial;
            Comentario = row.Comentario;
            Data = row.Img;
            Densidad = row.GetT_Propiedad_FisicaRows()[0].Densidad;
            Porosidad = row.GetT_Propiedad_FisicaRows()[0].Porocidad;
            NamePh =  row.GetT_Propiedad_FisicaRows()[0].T_Grado_PHRow.Nombre;
            IndiceSilacatacion = row.GetT_Propiedad_FisicaRows()[0].Indice_Silicatacion;
           // row.get
            foreach (var VARIABLE in row.GetT_Propiedad_FisicaRows()[0].GetT_Propiedad_Fisica_ElementoRows())
             Elementos.Add(new ElementoOxido(VARIABLE));
            Costo = row.GetT_Propiedad_ProduccionRows()[0].Costo;
            foreach (var VARIABLE in row.GetT_Propiedad_ProduccionRows()[0].GetT_FormatoRows())
                Formatos.Add(new Formato(VARIABLE));
            Temperatura = row.GetT_Propiedad_TermodinamicaRows()[0].Temperatura;
        }

        public bool IsEqual(Material material)
        {
            return (material.Name == Name) && (material.Espesor == Espesor);
        }
    }
    [Serializable]
    public class Project
    {
        public Stream AsStream(Stream stream=null)
        {
            Stream t = stream;
            if (t == null)
                t = new MemoryStream();
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(t, this);

            return t;
        }
        private readonly List<Material> _materiales = new List<Material>();
        public String Name { get; set; }
        public double Area { get; set; }
        public double TemperaturaAmbiente { get; set; }
        public double TemperaturaDiseño { get; set; }
        public String TipoPared { get; set; }
        public double? ValuePared { get; set; }
        public double? CoefcienteIntercambio { get; set; }
        public int Formula { get; set; }
        public double VcFormula { get; set; }
        public double EmChapa { get; set; }
        public Degradee Degradde { get; set; }
        public double Presicion { get; set; }
        public List<Material> Materiales { get { return _materiales; } }
        public static Project ConvertFromDataSet(UCPropertyTempControl control)
        {
            var r = new Project();
            r.Name = control.Algorithm.Project.nameproject;
            r.Area = control.Algorithm.Project.area;
            if (control.Algorithm.Project.coefinintercambio is double)
                r.CoefcienteIntercambio = (double)control.Algorithm.Project.coefinintercambio;
            else
                r.CoefcienteIntercambio = null;
            r.TemperaturaAmbiente = control.Algorithm.Project.tempamb;
            r.TemperaturaDiseño = control.Algorithm.Project.tempdise;
            r.TipoPared = control.Algorithm.Project.T_Tipo_ParedRow.nametipopared;
            r.Presicion = control.Algorithm.Project.presicionest;
            try
            {
                r.ValuePared = control.Algorithm.Project.valuepared;
            }
            catch (Exception)
            {

                r.ValuePared = null;
            }
            
            r.VcFormula = control.Algorithm.Project.vcform;
            r.EmChapa = control.Algorithm.Project.emchapa;
            r.Formula = control.Algorithm.Project.formulat;
            r.Degradde  = new Degradee(control.Algorithm.Project.T_DegradeeRow);

            for (int index = 0; index < control.Algorithm.Materiales.Count; index++)
            {
                DSRD.T_MaterialRow materialRow = control.Algorithm.Materiales[index];
                var t = new Material(materialRow);
                t.Espesor = control.Algorithm.Spesor[index];
                r.Materiales.Add(t);
            }

            return r;
        }

        private int GetTipoPared()
        {
            var s = new T_Tipo_ParedTableAdapter();

            var i = s.Find(TipoPared);

            if (i==null)
            {
                 s.Insert(TipoPared);
                i = (int?) s.Last();
            }

            return (int) i;

        }
       
        public static bool CreateFromFile(string cAT)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                var stream = new FileStream(cAT, FileMode.Open);
                stream.Position = 0;
                var r = (Project) formatter.Deserialize(stream);
                var s = new T_ProjectTableAdapter();
                //if (s.ScalarQuery(r.Name) != null)
                //    return false;

                var dataset = new DSRD();
              //  var t = dataset.T_Project.NewT_ProjectRow();
              //  t.nameproject = r.Name;
              //  t.area = r.Area;
              //  t.coefinintercambio = r.CoefcienteIntercambio;
              //  t.tempamb = r.TemperaturaAmbiente;
              //  t.tempdise = r.TemperaturaDiseño;
              //  t.tipopared = r.GetTipoPared();
              //  if(r.ValuePared!=null)
              //  t.valuepared = (double)r.ValuePared;
              //  t.iddegrade = r.Degradde.GetDegradee();
              //  t.vcform = r.VcFormula;
              //  t.emchapa = r.EmChapa;
              //  t.formulat = r.Formula;
              ////  t.presicionest =r.p
              //  dataset.T_Project.AddT_ProjectRow(t);
              //  s.Update(dataset.T_Project);

                foreach (Material materiale in r.Materiales)
                {
                    
                }
                return true;
            }
            catch (Exception)
            {

                return false;


            }
            

         
        }

        public bool IsEqual(Project convertFromDataSet)
        {
            //var t = Name == convertFromDataSet.Name;
            //if (t)
            //    t = Area == convertFromDataSet.Area;
            //if (t)
           
            //    r.CoefcienteIntercambio = (double)control.Algorithm.Project.coefinintercambio;
            //if (t)
            //r.TemperaturaDiseño = control.Algorithm.Project.tempdise;
            //if (t)
            //r.TipoPared = control.Algorithm.Project.T_Tipo_ParedRow.nametipopared;
            //if (t)
            //r.Presicion = control.Algorithm.Project.presicionest;
            //  if(t)
            //    r.ValuePared = control.Algorithm.Project.valuepared;

            //  if (t)
            //r.VcFormula = control.Algorithm.Project.vcform;
            //  if (t)
            //r.EmChapa = control.Algorithm.Project.emchapa;
            //  if (t)
            //r.Formula = control.Algorithm.Project.formulat;
            //  if (t)
            //r.Degradde = new Degradee(control.Algorithm.Project.T_DegradeeRow);  
            var t = Materiales.Count == convertFromDataSet.Materiales.Count;
            if(t)
                for (int index = 0; index < Materiales.Count; index++)
                {
                    Material materiale = Materiales[index];
                    t = materiale.IsEqual(convertFromDataSet.Materiales[index]);
                    if(!t)
                        break;
                    ;
                }

            return t;
        }

        public static Project FromStream(MemoryStream memoryStream)
        {
            IFormatter formatter = new BinaryFormatter();
           return   (Project)formatter.Deserialize(memoryStream);
        }
    }
    [Serializable]
    public class Degradee
    {
        public String Name { get; set; }
        public double ScaleMax { get; set; }
        public double ScaleMin { get; set; }
        public byte[] Data { get; set; }
        public Degradee(DSRD.T_DegradeeRow row)
        {
            Name = row.namedegrade;
            ScaleMax = row.scalemax;
            ScaleMin = row.scalemin;
            Data = row.imgdegrade;
        }
        public int GetDegradee()
        {
            var s = new T_DegradeeTableAdapter();

            var i = s.Find(Name);

            if (i == null)
            {
               
                s.Insert(Name,Data,(int) ScaleMax,(int) ScaleMin);
                i = s.Last();
            }

            return (int)i;

        }
    }
}
