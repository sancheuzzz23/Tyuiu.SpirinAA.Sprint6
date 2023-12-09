using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SpirinAA.Sprint6.Task5.V22.Lib
{
    public class DataService : ISprint6Task5V22
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;

                }
            }
            numsArray = numsArray.Where(var => var > 5).ToArray();

            double[] resArray = new double[numsArray.Length];
            for (int i = 0; i < numsArray.Length; i++)
            {
                if (numsArray[i].GetType().ToString() == "System.Double")
                {
                    resArray[i] = Math.Round(numsArray[i], 3);
                }
                else
                {
                    resArray[i] = numsArray[i];
                }
            }
            return resArray;
        }
    }
}
