using TMC.BCE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace TestProject1
{
    
    
    /// <summary>
    ///Se trata de una clase de prueba para AlgorithmTest y se pretende que
    ///contenga todas las pruebas unitarias AlgorithmTest.
    ///</summary>
    [TestClass()]
    public class AlgorithmTest
    {


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
        ///Una prueba de Constructor Algorithm
        ///</summary>
        [TestMethod()]
        public void AlgorithmConstructorTest()
        {
            Algorithm target = new Algorithm();
            Assert.Inconclusive("TODO: Implementar código para comprobar el destino");
        }

        /// <summary>
        ///Una prueba de AddToDictionary
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TMC.exe")]
        public void AddToDictionaryTest()
        {
            Algorithm_Accessor target = new Algorithm_Accessor(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> dictionary = null; // TODO: Inicializar en un valor adecuado
            string key = string.Empty; // TODO: Inicializar en un valor adecuado
            double value = 0F; // TODO: Inicializar en un valor adecuado
            target.AddToDictionary(dictionary, key, value);
            Assert.Inconclusive("Un método que no devuelve ningún valor no se puede comprobar.");
        }

        /// <summary>
        ///Una prueba de Carga_Segun_Escoria_Metal
        ///</summary>
        [TestMethod()]
        public void Carga_Segun_Escoria_MetalTest()
        {
            //Algorithm target = new Algorithm(); // TODO: Inicializar en un valor adecuado
            //int idproject = 1; // TODO: Inicializar en un valor adecuado
            //Dictionary<string, double> General = new Dictionary<string, double>(){"Masa",0.0}; // TODO: Inicializar en un valor adecuado
            //Dictionary<string, double> Metal = null; // TODO: Inicializar en un valor adecuado
            //Dictionary<string, double> Escoria = null; // TODO: Inicializar en un valor adecuado
            //Dictionary<string, double> Carga = null; // TODO: Inicializar en un valor adecuado
            //Dictionary<string, double> Gases = null; // TODO: Inicializar en un valor adecuado
            //Dictionary<string, double> expected = new Dictionary<string, double>(){"aaaa",5}; // TODO: Inicializar en un valor adecuado
            //Dictionary<string, double> actual;
            //actual = target.Carga_Segun_Escoria_Metal(idproject, General, Metal, Escoria, Carga, Gases);
            //Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de Escoria_Segun_Carga_Metal
        ///</summary>
        [TestMethod()]
        public void Escoria_Segun_Carga_MetalTest()
        {
            Algorithm target = new Algorithm(); // TODO: Inicializar en un valor adecuado
            int idpatron = 0; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> General = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> Metal = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> Carga = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> Gases = null; // TODO: Inicializar en un valor adecuado
            bool def = false; // TODO: Inicializar en un valor adecuado
            Dictionary<string, Dictionary<string, double>> expected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, Dictionary<string, double>> actual;
            actual = target.Escoria_Segun_Carga_Metal(idpatron, General, Metal, Carga, Gases, def);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de GenerateList
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TMC.exe")]
        public void GenerateListTest()
        {
            Algorithm_Accessor target = new Algorithm_Accessor(); // TODO: Inicializar en un valor adecuado
            List<string> list = null; // TODO: Inicializar en un valor adecuado
            string name = string.Empty; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> General = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> Metal = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> Carga = null; // TODO: Inicializar en un valor adecuado
            int i = 0; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> anterior = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> expected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> actual;
            actual = target.GenerateList(list, name, General, Metal, Carga, i, anterior);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de GenerateList2
        ///</summary>
        [TestMethod()]
        public void GenerateList2Test()
        {
            Algorithm target = new Algorithm(); // TODO: Inicializar en un valor adecuado
            string nameelmento = string.Empty; // TODO: Inicializar en un valor adecuado
            string name2 = string.Empty; // TODO: Inicializar en un valor adecuado
            List<string> Carga = null; // TODO: Inicializar en un valor adecuado
            object ACL = null; // TODO: Inicializar en un valor adecuado
            int i = 0; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> Result = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> expected = null; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> actual;
            actual = target.GenerateList2(nameelmento, name2, Carga, ACL, i, Result);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de GetFromDictionary
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TMC.exe")]
        public void GetFromDictionaryTest()
        {
            Algorithm_Accessor target = new Algorithm_Accessor(); // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> dictionary = null; // TODO: Inicializar en un valor adecuado
            string key = string.Empty; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.GetFromDictionary(dictionary, key);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de OxidosDeCargas
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TMC.exe")]
        public void OxidosDeCargasTest()
        {
            Algorithm_Accessor target = new Algorithm_Accessor(); // TODO: Inicializar en un valor adecuado
            string oxido = string.Empty; // TODO: Inicializar en un valor adecuado
            Dictionary<string, double> value = null; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.OxidosDeCargas(oxido, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }

        /// <summary>
        ///Una prueba de ValorPonderado
        ///</summary>
        [TestMethod()]
        public void ValorPonderadoTest()
        {
            Algorithm target = new Algorithm(); // TODO: Inicializar en un valor adecuado
            int ecuacion1 = 0; // TODO: Inicializar en un valor adecuado
            int ecuacion2 = 0; // TODO: Inicializar en un valor adecuado
            string concepto = string.Empty; // TODO: Inicializar en un valor adecuado
            double CO = 0F; // TODO: Inicializar en un valor adecuado
            double CO2 = 0F; // TODO: Inicializar en un valor adecuado
            double expected = 0F; // TODO: Inicializar en un valor adecuado
            double actual;
            actual = target.ValorPonderado(ecuacion1, ecuacion2, concepto, CO, CO2);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Compruebe la exactitud de este método de prueba.");
        }
    }
}
