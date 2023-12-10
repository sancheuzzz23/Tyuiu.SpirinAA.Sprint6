using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.SpirinAA.Sprint6.Task7.V23.Lib;

namespace Tyuiu.SpirinAA.Sprint6.Task7.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }

        static string openFile;
        static int rows;
        static int columns;

        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonInform_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFile = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewIn.RowCount = rows;
            dataGridViewIn.ColumnCount = columns;
            dataGridViewOut.RowCount = rows;
            dataGridViewOut.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn.Columns[i].Width = 50;
                dataGridViewOut.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone.Enabled = true;
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut.RowCount;
            int columns = dataGridViewOut.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOut.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOut.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonInform_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn.RowCount = 50;
            dataGridViewOut.RowCount = 50;

            dataGridViewIn.ColumnCount = 50;
            dataGridViewOut.ColumnCount = 50;

            panel2.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn.Columns[i].Width = 25;
                dataGridViewOut.Columns[i].Width = 25;
            }
        }
    }
}
