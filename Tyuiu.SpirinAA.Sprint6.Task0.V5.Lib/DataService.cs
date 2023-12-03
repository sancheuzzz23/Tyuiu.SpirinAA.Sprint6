using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SpirinAA.Sprint6.Task0.V5.Lib
{
    public class DataService : ISprint6Task0V5
    {
        public double Calculate(int x)
        {
            double res = ((-1.4 * Math.Pow(x, 3)) + (2.3 * Math.Pow(x, 2)) + (0.6 * x));
            return Math.Round(res, 3);
        }
    }
}
