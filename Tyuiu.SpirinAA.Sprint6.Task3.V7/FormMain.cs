using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SpirinAA.Sprint6.Task3.V7.Lib;

namespace Tyuiu.SpirinAA.Sprint6.Task3.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { 31, 25, -18, 12, 9 },
                                           { 6, 34, -2, 2, -18 },
                                           { -5, 4, 27, 4, -1 },
                                           { 4, 15, 34, -6, -10 },
                                           { 0, 8, 5, 14, -17 } };
        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] matrixres = ds.Calculate(matrix);

            int rows = matrixres.GetUpperBound(0) + 1;
            int columns = matrixres.Length / rows;

            dataGridViewOutputData.ColumnCount = columns;
            dataGridViewOutputData.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutputData.Columns[i].Width = 50;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutputData.Rows[i].Cells[j].Value = Convert.ToString(matrixres[i, j]);
                }
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix.ColumnCount = columns;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }

            }
        }

        private void buttonInform_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-2 Спирин Александр Алексеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
