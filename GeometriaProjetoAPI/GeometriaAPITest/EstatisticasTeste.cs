using GeometriaAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometriaAPITest
{
    [TestClass]
    public class EstatisticasTeste
    {
        Estatistica estatistica = new Estatistica();

         [TestMethod]         
        public void MedianaSequenciaImpar()
        {
            double[] valores = {2,9,7,1,5};                 
            double esperado=5;
            double resultado = estatistica.mediana(valores);
           
            Assert.AreEqual(esperado,resultado);
                       
        }
        
    }
}