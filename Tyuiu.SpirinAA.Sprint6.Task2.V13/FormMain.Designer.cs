namespace Tyuiu.SpirinAA.Sprint6.Task2.V13
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.textBoxEndVarX = new System.Windows.Forms.TextBox();
            this.labelStartVarX = new System.Windows.Forms.Label();
            this.labelEndVarX = new System.Windows.Forms.Label();
            this.textBoxStartVarX = new System.Windows.Forms.TextBox();
            this.buttonInform = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.labelViewFunction = new System.Windows.Forms.Label();
            this.dataGridViewFunction = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBoxName2);
            this.groupBoxCondition.Controls.Add(this.textBoxName1);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(379, 353);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // textBoxName2
            // 
            this.textBoxName2.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName2.Location = new System.Drawing.Point(7, 39);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(332, 13);
            this.textBoxName2.TabIndex = 0;
            this.textBoxName2.Text = "Результат вывести в DataGridView и построить график функции.";
            // 
            // textBoxName1
            // 
            this.textBoxName1.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName1.Location = new System.Drawing.Point(7, 20);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(276, 13);
            this.textBoxName1.TabIndex = 0;
            this.textBoxName1.Text = "Протабулировать функцию на заданном промежутке.";
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.textBoxStartVarX);
            this.groupBoxInputData.Controls.Add(this.textBoxEndVarX);
            this.groupBoxInputData.Controls.Add(this.labelStartVarX);
            this.groupBoxInputData.Controls.Add(this.labelEndVarX);
            this.groupBoxInputData.Location = new System.Drawing.Point(13, 372);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(186, 66);
            this.groupBoxInputData.TabIndex = 1;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных";
            // 
            // textBoxEndVarX
            // 
            this.textBoxEndVarX.Location = new System.Drawing.Point(96, 32);
            this.textBoxEndVarX.Name = "textBoxEndVarX";
            this.textBoxEndVarX.Size = new System.Drawing.Size(84, 20);
            this.textBoxEndVarX.TabIndex = 1;
            // 
            // labelStartVarX
            // 
            this.labelStartVarX.AutoSize = true;
            this.labelStartVarX.Location = new System.Drawing.Point(3, 16);
            this.labelStartVarX.Name = "labelStartVarX";
            this.labelStartVarX.Size = new System.Drawing.Size(67, 13);
            this.labelStartVarX.TabIndex = 0;
            this.labelStartVarX.Text = "Старт шага:";
            // 
            // labelEndVarX
            // 
            this.labelEndVarX.AutoSize = true;
            this.labelEndVarX.Location = new System.Drawing.Point(93, 16);
            this.labelEndVarX.Name = "labelEndVarX";
            this.labelEndVarX.Size = new System.Drawing.Size(69, 13);
            this.labelEndVarX.TabIndex = 0;
            this.labelEndVarX.Text = "Конец шага:";
            // 
            // textBoxStartVarX
            // 
            this.textBoxStartVarX.Location = new System.Drawing.Point(6, 32);
            this.textBoxStartVarX.Name = "textBoxStartVarX";
            this.textBoxStartVarX.Size = new System.Drawing.Size(84, 20);
            this.textBoxStartVarX.TabIndex = 1;
            // 
            // buttonInform
            // 
            this.buttonInform.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonInform.Location = new System.Drawing.Point(205, 372);
            this.buttonInform.Name = "buttonInform";
            this.buttonInform.Size = new System.Drawing.Size(71, 66);
            this.buttonInform.TabIndex = 2;
            this.buttonInform.Text = "Справка";
            this.buttonInform.UseVisualStyleBackColor = false;
            this.buttonInform.Click += new System.EventHandler(this.buttonInform_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Green;
            this.buttonDone.Location = new System.Drawing.Point(282, 372);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(109, 66);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_MouseDown);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            this.buttonDone.MouseLeave += new System.EventHandler(this.buttonDone_MouseLeave);
            // 
            // groupBoxOutputData
            // 
            this.groupBoxOutputData.Controls.Add(this.chartFunction);
            this.groupBoxOutputData.Controls.Add(this.dataGridViewFunction);
            this.groupBoxOutputData.Controls.Add(this.labelViewFunction);
            this.groupBoxOutputData.Location = new System.Drawing.Point(397, 12);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Size = new System.Drawing.Size(590, 426);
            this.groupBoxOutputData.TabIndex = 3;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "Ввод данных";
            // 
            // labelViewFunction
            // 
            this.labelViewFunction.AutoSize = true;
            this.labelViewFunction.Location = new System.Drawing.Point(7, 20);
            this.labelViewFunction.Name = "labelViewFunction";
            this.labelViewFunction.Size = new System.Drawing.Size(62, 13);
            this.labelViewFunction.TabIndex = 1;
            this.labelViewFunction.Text = "Результат:";
            // 
            // dataGridViewFunction
            // 
            this.dataGridViewFunction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewFunction.Name = "dataGridViewFunction";
            this.dataGridViewFunction.RowHeadersVisible = false;
            this.dataGridViewFunction.Size = new System.Drawing.Size(103, 381);
            this.dataGridViewFunction.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.Width = 50;
            // 
            // chartFunction
            // 
            chartArea2.Name = "ChartArea1";
            this.chartFunction.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction.Legends.Add(legend2);
            this.chartFunction.Location = new System.Drawing.Point(125, 36);
            this.chartFunction.Name = "chartFunction";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction.Series.Add(series2);
            this.chartFunction.Size = new System.Drawing.Size(459, 290);
            this.chartFunction.TabIndex = 3;
            this.chartFunction.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 443);
            this.Controls.Add(this.groupBoxOutputData);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonInform);
            this.Controls.Add(this.groupBoxInputData);
            this.Controls.Add(this.groupBoxCondition);
            this.Name = "Form1";
            this.Text = "Спринт 6 | Таск 2 | Вариант 13 | Спирин А.А.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.groupBoxOutputData.ResumeLayout(false);
            this.groupBoxOutputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Label labelStartVarX;
        private System.Windows.Forms.Label labelEndVarX;
        private System.Windows.Forms.TextBox textBoxEndVarX;
        private System.Windows.Forms.TextBox textBoxStartVarX;
        private System.Windows.Forms.Button buttonInform;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.Label labelViewFunction;
        private System.Windows.Forms.DataGridView dataGridViewFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}

