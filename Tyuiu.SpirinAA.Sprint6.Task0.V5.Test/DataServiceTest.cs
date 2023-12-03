using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using Tyuiu.SpirinAA.Sprint6.Task0.V5.Lib;

namespace Tyuiu.SpirinAA.Sprint6.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(5);
            double wait = -114.5;
            Assert.AreEqual(wait, res);
        }
    }
}
