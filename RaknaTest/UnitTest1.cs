using System;
using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rakna;

namespace RaknaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            //skapa
            Matte ma=new Matte();
            double arvarde, borvarde = 10;

            //anropa
            arvarde = ma.Add(6, 4);

            //jämföra
            Assert.AreEqual(arvarde, borvarde);


        }

        [TestMethod]
        public void TestSub()
        {
            //skapa
            Matte ma = new Matte();
            double arvarde, borvarde = 10;

            //anropa
            arvarde = ma.Sub(20, 10);

            //jämföra
            Assert.AreEqual(arvarde, borvarde);


        }
    }
}
