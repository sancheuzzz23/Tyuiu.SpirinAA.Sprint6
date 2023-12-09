using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SpirinAA.Sprint6.Task5.V22.Lib;

namespace Tyuiu.SpirinAA.Sprint6.Task5.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string path = @"C:\Users\Sascha\source\repos\Tyuiu.SpirinAA.Sprint6\Tyuiu.SpirinAA.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewFunction.ColumnCount = 2;
            dataGridViewFunction.Columns[0].Width = 20;
            dataGridViewFunction.Columns[1].Width = 50;

            this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewFunction.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "Notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonInform_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСоиУб-23-2 Спирин Александр Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
