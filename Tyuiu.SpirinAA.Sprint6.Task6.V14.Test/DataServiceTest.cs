using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SpirinAA.Sprint6.Task6.V14.Lib;

namespace Tyuiu.SpirinAA.Sprint6.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            var ds = new DataService();
            var path = @"C:\Users\Sascha\source\repos\Tyuiu.SpirinAA.Sprint6\Tyuiu.SpirinAA.Sprint6.Task6.V14\bin\Debug\InPutFileTask6V14.txt";
            var result = ds.CollectTextFromFile(path);
            Assert.AreEqual("GzTsc AucHJjziZ jiUFMDjMsEervIz ziwVyU ", result);
        }
    }
}
