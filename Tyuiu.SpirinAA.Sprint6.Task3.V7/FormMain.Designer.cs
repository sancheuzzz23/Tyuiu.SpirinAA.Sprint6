namespace Tyuiu.SpirinAA.Sprint6.Task3.V7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData = new System.Windows.Forms.GroupBox();
            this.labelOutputData = new System.Windows.Forms.Label();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.buttonInform = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.dataGridViewOutputData = new System.Windows.Forms.DataGridView();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxOutputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.textBoxTask);
            this.groupBoxCondition.Location = new System.Drawing.Point(13, 12);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(315, 281);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(275, 125);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.TabStop = false;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxOutputData
            // 
            this.groupBoxOutputData.Controls.Add(this.dataGridViewOutputData);
            this.groupBoxOutputData.Controls.Add(this.labelOutputData);
            this.groupBoxOutputData.Location = new System.Drawing.Point(582, 12);
            this.groupBoxOutputData.Name = "groupBoxOutputData";
            this.groupBoxOutputData.Size = new System.Drawing.Size(221, 244);
            this.groupBoxOutputData.TabIndex = 1;
            this.groupBoxOutputData.TabStop = false;
            this.groupBoxOutputData.Text = "Вывод данных";
            // 
            // labelOutputData
            // 
            this.labelOutputData.AutoSize = true;
            this.labelOutputData.Location = new System.Drawing.Point(7, 19);
            this.labelOutputData.Name = "labelOutputData";
            this.labelOutputData.Size = new System.Drawing.Size(62, 13);
            this.labelOutputData.TabIndex = 0;
            this.labelOutputData.Text = "Результат:";
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(334, 21);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(240, 235);
            this.dataGridViewMatrix.TabIndex = 2;
            // 
            // buttonInform
            // 
            this.buttonInform.Location = new System.Drawing.Point(657, 262);
            this.buttonInform.Name = "buttonInform";
            this.buttonInform.Size = new System.Drawing.Size(39, 31);
            this.buttonInform.TabIndex = 3;
            this.buttonInform.Text = "?";
            this.buttonInform.UseVisualStyleBackColor = true;
            this.buttonInform.Click += new System.EventHandler(this.buttonInform_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(702, 262);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(97, 31);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // dataGridViewOutputData
            // 
            this.dataGridViewOutputData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputData.Location = new System.Drawing.Point(-1, 35);
            this.dataGridViewOutputData.Name = "dataGridViewOutputData";
            this.dataGridViewOutputData.ReadOnly = true;
            this.dataGridViewOutputData.RowHeadersVisible = false;
            this.dataGridViewOutputData.Size = new System.Drawing.Size(221, 208);
            this.dataGridViewOutputData.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 305);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonInform);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.groupBoxOutputData);
            this.Controls.Add(this.groupBoxCondition);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 7 | Спирин А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxOutputData.ResumeLayout(false);
            this.groupBoxOutputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxOutputData;
        private System.Windows.Forms.Label labelOutputData;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.Button buttonInform;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DataGridView dataGridViewOutputData;
    }
}

