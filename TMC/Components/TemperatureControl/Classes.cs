using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using TMC.SIAR;
using TMC.SIAR.DSRDTableAdapters;

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

        public int GetTipoFormato(DSRD dataset)
        {
            var tp = new T_Tipo_FormatoTableAdapter();
            var i = AdapterHelper.Find("T_Tipo_Formato", "idTipo_Formato", "Nombre", Name.ToString());
            if (i == null)
            {
                var data = dataset.T_Tipo_Formato.NewT_Tipo_FormatoRow();
                data.Nombre = Name;
                data.Imagen = Image;


                dataset.T_Tipo_Formato.AddT_Tipo_FormatoRow(data);
                tp.Update(dataset.T_Tipo_Formato);
                i = AdapterHelper.Last("T_Tipo_Formato", "idTipo_Formato");
            }
            return (int)i;
        }
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
    public static class AdapterHelper
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(Properties.Settings.Default.TMCConnectionString);

        } 
        public static int? ExecuteScalar(String Script)
        {
            var s = GetConnection();
            try
            {
                if (s != null)
                {
                    s.Open();
                    var command = new SqlCommand(Script, s);

                    var w = command.ExecuteScalar();
                    return (int?)w;
                }
            }
            catch (Exception)
            {


            }
            return null;
        }
        public static int? Find(String Table, String search,String ret,String value)
        {
            return ExecuteScalar("SELECT " + search + " FROM " + Table + " WHERE " + ret + "='" + value + "'");

        }
        public static int? Last(String Table, String Search)
        {
            return ExecuteScalar("SELECT MAX(" + Search + ") FROM " + Table);
        }
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
        private int GetGradoPH(DSRD dataSet, string gradoPh)
        {
             var tp = new T_Grado_PHTableAdapter();
             var i = AdapterHelper.Find("T_Grado_PH", "idGrado_PH", "nombre", gradoPh.ToString());
            if (i == null)
            {
                var data = dataSet.T_Grado_PH.NewT_Grado_PHRow();
                data.Nombre = gradoPh;
               
                dataSet.T_Grado_PH.AddT_Grado_PHRow(data);
                tp.Update(dataSet.T_Grado_PH);
                i = AdapterHelper.Last("T_Grado_PH", "idGrado_PH");
            }
            return (int) i;
        }
        private void CreatePropFisicas(DSRD dataSet,int material)
        {
            var tp = new T_Propiedad_FisicaTableAdapter();
            var i = AdapterHelper.Find("T_Propiedad_Fisica", "idPropiedad_Fisica","idmaterial",material.ToString());
            if (i == null)
            {
                var data = dataSet.T_Propiedad_Fisica.NewT_Propiedad_FisicaRow();
                data.idMaterial =material;
                data.Densidad = Densidad;
                data.Indice_Silicatacion = IndiceSilacatacion;
                data.Porocidad = Porosidad;
                data.idGradoPH = GetGradoPH(dataSet,NamePh);
                
                dataSet.T_Propiedad_Fisica.AddT_Propiedad_FisicaRow(data);
                tp.Update(dataSet.T_Propiedad_Fisica);
                i = AdapterHelper.Last("T_Propiedad_Fisica", "idPropiedad_Fisica");
            }

            foreach (ElementoOxido elementoOxido in Elementos)
                CreatePropFisicaElemento(dataSet,elementoOxido,(int) i);
        }

        private void CreatePropFisicaElemento(DSRD dataSet,ElementoOxido elementoOxido,int propfisica)
        {
            var tp = new T_Propiedad_Fisica_ElementoTableAdapter();
            var i = AdapterHelper.Find("T_Propiedad_Fisica_Elemento", "idPropiedad_Fisica_Elemento", "idPropiedad_Fisica", propfisica.ToString());
            if (i == null)
            {
                var t = CreateElementoOxido(dataSet,elementoOxido);
                var data = dataSet.T_Propiedad_Fisica_Elemento.NewT_Propiedad_Fisica_ElementoRow();
                data.idPropiedad_Fisica = propfisica;
                data.idElemento = t;
                data.Porciento =elementoOxido.Porciento;
  
                dataSet.T_Propiedad_Fisica_Elemento.AddT_Propiedad_Fisica_ElementoRow(data);
                tp.Update(dataSet.T_Propiedad_Fisica_Elemento);
                i = AdapterHelper.Last("T_Propiedad_Fisica_Elemento", "idPropiedad_Fisica_Elemento");
            }

        }

        private int CreateElementoOxido(DSRD dataSet, ElementoOxido elementoOxido)
        {
            var tp = new T_Elemento_OxidoTableAdapter();
            var t = CreateElemento(dataSet, elementoOxido.Elemento);
            var i = AdapterHelper.Find("T_Elemento_Oxido", "idElementoOxido", "idElemento", t.ToString());
            if (i == null)
            {
                var data = dataSet.T_Elemento_Oxido.NewT_Elemento_OxidoRow();
                data.idElemento = t;
                data.idGrado_PH  = GetGradoPH(dataSet,elementoOxido.GradoPH);
                data.num_Electrones = (int) elementoOxido.NumElectrones;
                data.grado_acides = (int) elementoOxido.GradoAcides;
             
                dataSet.T_Elemento_Oxido.AddT_Elemento_OxidoRow(data);
                tp.Update(dataSet.T_Elemento_Oxido);
                i = AdapterHelper.Last("T_Elemento_Oxido", "idElementoOxido");
            }
            return (int) i;
        }
        private int CreateElemento(DSRD dataset,Elemento elementoOxido)
        {
            var t = new T_ElementoTableAdapter();
            var i = AdapterHelper.Find("T_Elemento", "idelemento", "namelemento",elementoOxido.Name);
            if(i==null)
            {
                var data = dataset.T_Elemento.NewT_ElementoRow();
                data.nameelemento =elementoOxido.Name;
                data.codelemento =elementoOxido.Codigo;
                dataset.T_Elemento.AddT_ElementoRow(data);
                t.Update(dataset.T_Elemento);
                i = AdapterHelper.Last("T_Elemento", "idelemento");
            }
            return (int) i;
        }

        private void CreatePropTermodinamicoas(DSRD dataset, int material)
        {
            var tp = new T_Propiedad_TermodinamicaTableAdapter();
            var i = AdapterHelper.Find("T_Propiedad_Termodinamica", "idPropiedad_Termica", "idMaterial",
                                       material.ToString());
            if (i == null)
            {
                var data = dataset.T_Propiedad_Termodinamica.NewT_Propiedad_TermodinamicaRow();
                data.idMaterial = material;
                data.Temperatura = Temperatura;

                dataset.T_Propiedad_Termodinamica.AddT_Propiedad_TermodinamicaRow(data);
                tp.Update(dataset.T_Propiedad_Termodinamica);
                i = AdapterHelper.Last("T_Propiedad_Termodinamica", "idPropiedad_Termica");
            }
        }

        private  void CreatePropProduccion(DSRD dataset,int material)
        {
            var tp = new T_Propiedad_ProduccionTableAdapter();
            var i = AdapterHelper.Find("T_Propiedad_Produccion", "idPropiedad_Produccion", "idmaterial", material.ToString());
            if (i == null)
            {
                var data = dataset.T_Propiedad_Produccion.NewT_Propiedad_ProduccionRow();
                data.idMateria = material;
                data.Costo = Costo;
               
                dataset.T_Propiedad_Produccion.AddT_Propiedad_ProduccionRow(data);
                tp.Update(dataset.T_Propiedad_Produccion);
                i = AdapterHelper.Last("T_Propiedad_Produccion", "idPropiedad_Produccion");
            }

            foreach (Formato formato in Formatos)
                CreateFormato(dataset, formato, (int) i);
        }

        private void CreateFormato(DSRD dataset, Formato formato, int idproduccion)
        {
            var tp = new T_FormatoTableAdapter();
            var i = AdapterHelper.Find("T_Formato", "idFormato", "Nombre", formato.Name.ToString());
            if (i == null)
            {
                var data = dataset.T_Formato.NewT_FormatoRow();
                data.idPropiedad_Produccion =  idproduccion;
                data.Costo = formato.Costo;
                data.Largo1 = formato.Largo;
                data.Largo2 = formato.Largo2;
                data.Nombre = formato.Name;
                data.Radio = formato.Radio;
                data.Espesor = formato.Espesor;
                data.altura = formato.Altura;
                data.idTipo_Formato = formato.TipoFormato.GetTipoFormato(dataset);

                dataset.T_Formato.AddT_FormatoRow(data);
                tp.Update(dataset.T_Formato);
                i = AdapterHelper.Last("T_Formato", "idFormato");
            }
        }

        public void CreateTables(DSRD dataset)
        {
             var ta = new T_MaterialTableAdapter();
            var i = AdapterHelper.Find("T_Material","idmaterial","namematerial",Name);
            if(i==null)
            {
                var data = dataset.T_Material.NewT_MaterialRow();
                data.namematerial = Name;
                data.Img = Data;
                
                data.Comentario = Comentario;
                dataset.T_Material.AddT_MaterialRow(data);
                ta.Update(dataset.T_Material);
                i = AdapterHelper.Last("T_Material","idmaterial");
            }
            
            
            CreatePropFisicas(dataset,(int) i);
            CreatePropTermodinamicoas(dataset,(int) i);
            CreatePropProduccion(dataset,(int) i);
           

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

            var i = AdapterHelper.Find("T_Tipo_Pared", "idtipopared", "nametipopared",TipoPared);

            if (i==null)
            {
                 s.Insert(TipoPared);
                 i = AdapterHelper.Last("T_Tipo_Pared", "idtipopared");
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
                if (s.ScalarQuery(r.Name) != null)
                    return false;

                var dataset = new DSRD();
                var t = dataset.T_Project.NewT_ProjectRow();
                t.nameproject = r.Name;
                t.area = r.Area;
                t.coefinintercambio = r.CoefcienteIntercambio;
                t.tempamb = r.TemperaturaAmbiente;
                t.tempdise = r.TemperaturaDiseño;
                t.tipopared = r.GetTipoPared();
                if (r.ValuePared != null)
                    t.valuepared = (double)r.ValuePared;
                t.iddegrade = r.Degradde.GetDegradee();
                t.vcform = r.VcFormula;
                t.emchapa = r.EmChapa;
                t.formulat = r.Formula;
                //  t.presicionest =r.p
                dataset.T_Project.AddT_ProjectRow(t);
                s.Update(dataset.T_Project);

                foreach (Material materiale in r.Materiales)
                    materiale.CreateTables( dataset);

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

            var i = AdapterHelper.Find("T_Degradee", "iddegradee", "namedegrade", Name);

            if (i == null)
            {
               
                s.Insert(Name,Data,(int) ScaleMax,(int) ScaleMin);
                i = AdapterHelper.Last("T_Degradee","iddegradee");
            }

            return (int)i;

        }
    }
}
