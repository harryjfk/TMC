using System.IO;
using System.Windows.Forms;
using TMC.Components.TemperatureControl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TMC.SIAR.DSRDTableAdapters;
using TMC.SIAR;


namespace Prueba_Sistema
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para SIARAlgorithmTest y se pretende que
    ///contenga todas las pruebas unitarias SIARAlgorithmTest.
    ///</summary>
    [TestClass()]
    public class SIARAlgorithmTest
    {
        private  T_MaterialTableAdapter Adapter = new T_MaterialTableAdapter();
        private T_FormulaTableAdapter formulaAdapter = new T_FormulaTableAdapter();
        private  T_ProjectTableAdapter project = new T_ProjectTableAdapter();
        
        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de la prueba que proporciona
        ///la información y funcionalidad para la ejecución de pruebas actual.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Atributos de prueba adicionales
        // 
        //Puede utilizar los siguientes atributos adicionales mientras escribe sus pruebas:
        //
        //Use ClassInitialize para ejecutar código antes de ejecutar la primera prueba en la clase 
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup para ejecutar código después de haber ejecutado todas las pruebas en una clase
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize para ejecutar código antes de ejecutar cada prueba
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup para ejecutar código después de que se hayan ejecutado todas las pruebas
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Una prueba de Constructor SIARAlgorithm
        ///</summary>
        [TestMethod()]

        public bool CompareTest(Dictionary<String, Object> algorith, Dictionary<String,Object> algorith_test)
        {
            foreach (KeyValuePair<string, object> keyValuePair in algorith)
            {
                if (keyValuePair.Value is double)
                    Assert.AreEqual(Math.Round(Convert.ToDouble(keyValuePair.Value),2) , Math.Round(Convert.ToDouble(algorith_test[keyValuePair.Key]),2));
                else
                    if(keyValuePair.Value is List<double>)
                    {
                        var t = (List<double>) keyValuePair.Value;
                        var t1 = (List<double>) algorith_test[keyValuePair.Key];
                        for (int i = 0; i < t.Count; i++)
                            Assert.AreEqual(Math.Round(t[i]), Math.Round(t[i]));
                    }

                 
            }
            return true;
        }
        /// <summary>
        ///Una prueba de ClearList
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TMC.exe")]
        public void SIARAlgorithmConstructorTest()
        {
            //SIARAlgorithm target = new SIARAlgorithm();
            
 

        }

     
        /// <summary>
        ///Una prueba de ClearList
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TMC.exe")]
        public void ClearListTest()
        {


            var t = new Dictionary<String, Object>();

           

            List<double> TMTP = new List<double>()
                                    {
                                        0.0,
                                        875.92583680879341,
                                        380.19287301783794
                                    };
            List<double> LP = new List<double>()
                                  {
                                        0.0,
                                        3.5,
                                        1.8626520757148162
                                  };
            List<double> TEXP = new List<double>()
                                    {
                                        0.0,
                                        551.44929920684035,
                                        208.12306216875231
                                    };
            List<double> TEXP_E = new List<double>()
                                      {
                                         1200.0,
                                         551.85167361758681,
                                         208.53407241808907
                                      };

            t.Add("VARIesp", 0);
            t.Add("EspesMinCap", 0);
            t.Add("EspesMaxCap", 0);
            t.Add("VARItempI", 0);
            t.Add("TempVmax", 0);
            t.Add("SSP", 1.01);
            t.Add("QPAR", 2880.61859489348);
            t.Add("ALFP", 53.2234962225878);
            t.Add("TMTP", TMTP);
            t.Add("LP", LP);
            t.Add("TEXP", TEXP);
            t.Add("TEXP_E", TEXP_E);


            SIARAlgorithm algorithm = new SIARAlgorithm();
            DSRD ds = new DSRD();

            Adapter.Fill(ds.T_Material);
            formulaAdapter.Fill(ds.T_Formula);



            project.FillBy(ds.T_Project, 6);

            var m = new MemoryStream(ds.T_Project[0].dataproject);
            var pr = Project.FromStream(m);
            algorithm.TDataSet = ds;
            algorithm.Project = ds.T_Project[0];
            algorithm.ProjectObject = pr;
            
            var t1 = algorithm.SiSParcial(1200, 154);
            CompareTest(t,t1);

        }

    }
}
