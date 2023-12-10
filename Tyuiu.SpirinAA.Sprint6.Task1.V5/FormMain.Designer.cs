namespace Tyuiu.SpirinAA.Sprint6.Task1.V5
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
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxName2 = new System.Windows.Forms.TextBox();
            this.textBoxName1 = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.textBoxEndVarX = new System.Windows.Forms.TextBox();
            this.textBoxStartVarX = new System.Windows.Forms.TextBox();
            this.labelStartVarX = new System.Windows.Forms.Label();
            this.labelEndVarX = new System.Windows.Forms.Label();
            this.buttonInform = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxOutputData.SuspendLayout();
            this.groupBoxInputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBoxName2);
            this.groupBoxCondition.Controls.Add(this.textBoxName1);
            this.groupBoxCondition.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(380, 367);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // textBoxName2
            // 
            this.textBoxName2.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName2.Location = new System.Drawing.Point(20, 58);
            this.textBoxName2.Name = "textBoxName2";
            this.textBoxName2.Size = new System.Drawing.Size(190, 13);
            this.textBoxName2.TabIndex = 1;
            this.textBoxName2.TabStop = false;
            this.textBoxName2.Text = "Результат вывести в виде таблицы.";
            // 
            // textBoxName1
            // 
            this.textBoxName1.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName1.Location = new System.Drawing.Point(20, 39);
            this.textBoxName1.Name = "textBoxName1";
            this.textBoxName1.Size = new System.Drawing.Size(266, 13);
            this.textBoxName1.TabIndex = 0;
            this.textBoxName1.TabStop = false;
            this.textBoxName1.Text = "Протабулировать функцию на заданном диапазоне.";
            // 
            // groupBoxOutputData
            // 
            this.groupBoxOutputData.Controls.Add(this.textBoxResult);
            this.groupBoxOutputData.Controls.Add(this.labelResult);
            this.groupBoxOutputData.Location = new System.Drawing.Point(398, 12);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Size = new System.Drawing.Size(244, 367);
            this.groupBoxOutputData.TabIndex = 1;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(6, 39);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(232, 322);
            this.textBoxResult.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(7, 20);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(62, 13);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "Результат:";
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.textBoxEndVarX);
            this.groupBoxInputData.Controls.Add(this.textBoxStartVarX);
            this.groupBoxInputData.Controls.Add(this.labelStartVarX);
            this.groupBoxInputData.Controls.Add(this.labelEndVarX);
            this.groupBoxInputData.Location = new System.Drawing.Point(12, 385);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(210, 73);
            this.groupBoxInputData.TabIndex = 2;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод данных";
            // 
            // textBoxEndVarX
            // 
            this.textBoxEndVarX.Location = new System.Drawing.Point(104, 33);
            this.textBoxEndVarX.Name = "textBoxEndVarX";
            this.textBoxEndVarX.Size = new System.Drawing.Size(92, 20);
            this.textBoxEndVarX.TabIndex = 1;
            // 
            // textBoxStartVarX
            // 
            this.textBoxStartVarX.Location = new System.Drawing.Point(7, 33);
            this.textBoxStartVarX.Name = "textBoxStartVarX";
            this.textBoxStartVarX.Size = new System.Drawing.Size(91, 20);
            this.textBoxStartVarX.TabIndex = 1;
            // 
            // labelStartVarX
            // 
            this.labelStartVarX.AutoSize = true;
            this.labelStartVarX.Location = new System.Drawing.Point(6, 17);
            this.labelStartVarX.Name = "labelStartVarX";
            this.labelStartVarX.Size = new System.Drawing.Size(67, 13);
            this.labelStartVarX.TabIndex = 0;
            this.labelStartVarX.Text = "Старт шага:";
            // 
            // labelEndVarX
            // 
            this.labelEndVarX.AutoSize = true;
            this.labelEndVarX.Location = new System.Drawing.Point(101, 17);
            this.labelEndVarX.Name = "labelEndVarX";
            this.labelEndVarX.Size = new System.Drawing.Size(69, 13);
            this.labelEndVarX.TabIndex = 0;
            this.labelEndVarX.Text = "Конец шага:";
            // 
            // buttonInform
            // 
            this.buttonInform.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonInform.Location = new System.Drawing.Point(228, 391);
            this.buttonInform.Name = "buttonInform";
            this.buttonInform.Size = new System.Drawing.Size(70, 68);
            this.buttonInform.TabIndex = 3;
            this.buttonInform.Text = "Справка";
            this.buttonInform.UseVisualStyleBackColor = false;
            this.buttonInform.Click += new System.EventHandler(this.buttonInform_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonDone.Location = new System.Drawing.Point(304, 390);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(88, 68);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 470);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonInform);
            this.Controls.Add(this.groupBoxInputData);
            this.Controls.Add(this.groupBoxOutputData);
            this.Controls.Add(this.groupBoxCondition);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 1 | Вариант 5 | Спирин А.А.";
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxOutputData.ResumeLayout(false);
            this.groupBoxOutputData.PerformLayout();
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxName1;
        private System.Windows.Forms.TextBox textBoxName2;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.Label labelEndVarX;
        private System.Windows.Forms.TextBox textBoxStartVarX;
        private System.Windows.Forms.Label labelStartVarX;
        private System.Windows.Forms.TextBox textBoxEndVarX;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonInform;
        private System.Windows.Forms.Button buttonDone;
    }
}

