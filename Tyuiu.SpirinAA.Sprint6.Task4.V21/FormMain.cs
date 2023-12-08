using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SpirinAA.Sprint6.Task4.V21.Lib;
using System.IO;

namespace Tyuiu.SpirinAA.Sprint6.Task4.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonInform_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУб-23-2 Спирин Александр Алексеевич", "Сообщение");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V21.txt";
                File.WriteAllText(path, textBoxOutPutData.Text);

                DialogResult dialogResult = MessageBox.Show(this, $"Файл {path} сохранён успешно!\n Открыть его?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    //System.Diagnostics.Process.Start( path );
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "Notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartVarX.Text);
                int stopStep = Convert.ToInt32(textBoxEndVarX.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxOutPutData.Text = "";

                chartFunction.Series[0].Points.Clear();
                for (int i = 0; i < len; i++, startStep++)
                {
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxOutPutData.AppendText(valueArray[i] + Environment.NewLine);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
