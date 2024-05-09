using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using AlgoritmoC;

namespace CTestProject
{
    [TestClass]
    public class UnitTest1
    {
        public void mcd_Dos_Positivos()
        {
            int nro1 = 12;
            int nro2 = 18;
            int esperado = 6;
            int prueba = AlgoritmoCsharp.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Un_Positivo_Un_Negativo()
        {
            int nro1 = 12;
            int nro2 = -18;
            int esperado = 6;
            int prueba = AlgoritmoCsharp.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Ambos_Negativos()
        {
            int nro1 = -12;
            int nro2 = -18;
            int esperado = 6;
            int prueba = AlgoritmoCsharp.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Cero_Positivo()
        {
            int nro1 = 0;
            int nro2 = 12;
            int esperado = 12;
            int prueba = AlgoritmoCsharp.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Cero_Negativo()
        {
            int nro1 = 0;
            int nro2 = -12;
            int esperado = 12;
            int prueba = AlgoritmoCsharp.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
        public void MCD_Mismo_Numero()
        {
            int nro1 = 12;
            int nro2 = 12;
            int esperado = 12;
            int prueba = AlgoritmoCsharp.mcd(nro1, nro2);
            Assert.AreEqual(esperado, prueba);
        }
    }
}