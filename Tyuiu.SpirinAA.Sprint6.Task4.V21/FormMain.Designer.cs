namespace Tyuiu.SpirinAA.Sprint6.Task4.V21
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.textBoxEndVarX = new System.Windows.Forms.TextBox();
            this.textBoxStartVarX = new System.Windows.Forms.TextBox();
            this.labelEndVarX = new System.Windows.Forms.Label();
            this.labelStartVarX = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonInform = new System.Windows.Forms.Button();
            this.groupBoxOutPutData = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxOutPutData.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBoxTask);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 8);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(425, 79);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(408, 50);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.TabStop = false;
            this.textBoxTask.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в te" +
    "xtBox. Построить график функции и сохранить в файл\r\nOutPutFileTask4V21.txt по на" +
    "жатию кнопки.";
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxInputData.Controls.Add(this.textBoxEndVarX);
            this.groupBoxInputData.Controls.Add(this.textBoxStartVarX);
            this.groupBoxInputData.Controls.Add(this.labelEndVarX);
            this.groupBoxInputData.Controls.Add(this.labelStartVarX);
            this.groupBoxInputData.Location = new System.Drawing.Point(448, 7);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(273, 79);
            this.groupBoxInputData.TabIndex = 1;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных";
            // 
            // textBoxEndVarX
            // 
            this.textBoxEndVarX.Location = new System.Drawing.Point(135, 36);
            this.textBoxEndVarX.Name = "textBoxEndVarX";
            this.textBoxEndVarX.Size = new System.Drawing.Size(123, 20);
            this.textBoxEndVarX.TabIndex = 1;
            // 
            // textBoxStartVarX
            // 
            this.textBoxStartVarX.Location = new System.Drawing.Point(6, 36);
            this.textBoxStartVarX.Name = "textBoxStartVarX";
            this.textBoxStartVarX.Size = new System.Drawing.Size(123, 20);
            this.textBoxStartVarX.TabIndex = 1;
            // 
            // labelEndVarX
            // 
            this.labelEndVarX.AutoSize = true;
            this.labelEndVarX.Location = new System.Drawing.Point(132, 20);
            this.labelEndVarX.Name = "labelEndVarX";
            this.labelEndVarX.Size = new System.Drawing.Size(69, 13);
            this.labelEndVarX.TabIndex = 0;
            this.labelEndVarX.Text = "Конец шага:";
            // 
            // labelStartVarX
            // 
            this.labelStartVarX.AutoSize = true;
            this.labelStartVarX.Location = new System.Drawing.Point(7, 20);
            this.labelStartVarX.Name = "labelStartVarX";
            this.labelStartVarX.Size = new System.Drawing.Size(67, 13);
            this.labelStartVarX.TabIndex = 0;
            this.labelStartVarX.Text = "Старт шага:";
            // 
            // buttonDone
            // 
            this.buttonDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Location = new System.Drawing.Point(727, 12);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(96, 73);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonSave.Location = new System.Drawing.Point(829, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 73);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonInform
            // 
            this.buttonInform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInform.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInform.Location = new System.Drawing.Point(931, 12);
            this.buttonInform.Name = "buttonInform";
            this.buttonInform.Size = new System.Drawing.Size(96, 73);
            this.buttonInform.TabIndex = 2;
            this.buttonInform.Text = "Справка";
            this.buttonInform.UseVisualStyleBackColor = false;
            this.buttonInform.Click += new System.EventHandler(this.buttonInform_Click);
            // 
            // groupBoxOutPutData
            // 
            this.groupBoxOutPutData.Controls.Add(this.textBoxOutPutData);
            this.groupBoxOutPutData.Location = new System.Drawing.Point(3, 3);
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.Size = new System.Drawing.Size(181, 506);
            this.groupBoxOutPutData.TabIndex = 3;
            this.groupBoxOutPutData.TabStop = false;
            this.groupBoxOutPutData.Text = "Вывод:";
            // 
            // textBoxOutPutData
            // 
            this.textBoxOutPutData.BackColor = System.Drawing.Color.White;
            this.textBoxOutPutData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOutPutData.Location = new System.Drawing.Point(0, 19);
            this.textBoxOutPutData.Multiline = true;
            this.textBoxOutPutData.Name = "textBoxOutPutData";
            this.textBoxOutPutData.ReadOnly = true;
            this.textBoxOutPutData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData.Size = new System.Drawing.Size(175, 481);
            this.textBoxOutPutData.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.groupBoxCondition);
            this.panel1.Controls.Add(this.buttonDone);
            this.panel1.Controls.Add(this.groupBoxInputData);
            this.panel1.Controls.Add(this.buttonInform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxOutPutData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(188, 516);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartFunction);
            this.panel3.Controls.Add(this.splitter1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(188, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(851, 516);
            this.panel3.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 516);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // chartFunction
            // 
            this.chartFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunction.Legends.Add(legend3);
            this.chartFunction.Location = new System.Drawing.Point(3, 0);
            this.chartFunction.Name = "chartFunction";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartFunction.Series.Add(series3);
            this.chartFunction.Size = new System.Drawing.Size(848, 516);
            this.chartFunction.TabIndex = 1;
            this.chartFunction.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.ForeColor = System.Drawing.Color.DodgerBlue;
            title3.Name = "Title1";
            title3.Text = "График функции";
            this.chartFunction.Titles.Add(title3);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 616);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 21 | Спирин А.А.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxOutPutData.ResumeLayout(false);
            this.groupBoxOutPutData.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.TextBox textBoxEndVarX;
        private System.Windows.Forms.TextBox textBoxStartVarX;
        private System.Windows.Forms.Label labelEndVarX;
        private System.Windows.Forms.Label labelStartVarX;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonInform;
        private System.Windows.Forms.GroupBox groupBoxOutPutData;
        private System.Windows.Forms.TextBox textBoxOutPutData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
        private System.Windows.Forms.Splitter splitter1;
    }
}

