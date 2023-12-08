using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SpirinAA.Sprint6.Task4.V21.Lib;

namespace Tyuiu.SpirinAA.Sprint6.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startStep = -5;
            int stopStep = 5;
            int len = (stopStep - startStep) + 1;
            double[] res = new double[len];
            res = ds.GetMassFunction(startStep, stopStep);
            double[] wait = new double[len];
            wait[0] = 28.05;
            wait[1] = 22.27;
            wait[2] = 17.01;
            wait[3] = 12.35;
            wait[4] = 7.51;
            wait[5] = 0;
            wait[6] = 1.62;
            wait[7] = -7.03;
            wait[8] = -12.99;
            wait[9] = -17.55;
            wait[10] = -21.43;
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
