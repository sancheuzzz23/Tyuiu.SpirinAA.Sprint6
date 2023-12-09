using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SpirinAA.Sprint6.Task5.V22.Lib;

namespace Tyuiu.SpirinAA.Sprint6.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\Sascha\source\repos\Tyuiu.SpirinAA.Sprint6\Tyuiu.SpirinAA.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
