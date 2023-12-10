﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Runtime.InteropServices;
using Tyuiu.SpirinAA.Sprint6.Task7.V23.Lib;

namespace Tyuiu.SpirinAA.Sprint6.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Sascha\source\repos\Tyuiu.SpirinAA.Sprint6\Tyuiu.SpirinAA.Sprint6.Task7.V23\bin\Debug\InPutFileTask7V23.csv";
            int[,] res = ds.GetMatrix(path);

            int[,] wait = { { 6, 15, -9, -11, -4, -20, -18, 6, 6, 2 },
                            { 18, -8, 6, -7, -10, -5, 5, 20, -18, 2 },
                            { -5, -8, 12, -14, 1, -20, -5, -20, -5, 2 },
                            { -20, 7, -7, 10, -13, -12, -18, 4, 4, 4 },
                            { -1, 19, 17, 3, -15, -1, -5, 15, -4, 2 },
                            { 4, -10, -17, 11, -1, -14, 6, 8, 3, 19 },
                            { 14, 4, -15, 19, -19, 11, -5, 13, 6, 7 },
                            { -8, 13, -6, -20, 17, -8, 19, 15, -15, 2 },
                            { 4, -18, -20, -12, 5, 20, -2, -10, -9, 10 },
                            { -8, -20, -8, -11, 7, 0, -7, 5, -20, 2} };
            
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
