using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SpirinAA.Sprint6.Task4.V21.Lib
{
    public class DataService : ISprint6Task4V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            double y;
            for (int x = startValue, count = 0; x <= stopValue; x++, count++)
            {
                y = Math.Round((2 * Math.Cos(x) + 2) / (2 * x - 1) + Math.Cos(x) - 5 * x + 3, 2);
                valueArray[count] = y;

            }
            return valueArray;
        }
    }
}
