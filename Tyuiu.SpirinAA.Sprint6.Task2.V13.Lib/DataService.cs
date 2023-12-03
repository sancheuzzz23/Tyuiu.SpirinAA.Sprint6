using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SpirinAA.Sprint6.Task2.V13.Lib
{
    public class DataService : ISprint6Task2V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x) + ((2.0 * x) / 3.0) - Math.Cos(x) * (4.0 * x)), 2);

                if (Math.Cos(x) + x == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    valueArray[count] = y;
                }
                count++;
            }
            return valueArray;
        }
    }
}
