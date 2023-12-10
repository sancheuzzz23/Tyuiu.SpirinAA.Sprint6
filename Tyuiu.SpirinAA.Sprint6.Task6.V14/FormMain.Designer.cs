namespace Tyuiu.SpirinAA.Sprint6.Task6.V14
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInform = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData = new System.Windows.Forms.TextBox();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.textBoxInputData = new System.Windows.Forms.TextBox();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.groupBoxCondition.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxOutPutData.SuspendLayout();
            this.groupBoxInputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.buttonInform);
            this.panel1.Controls.Add(this.buttonDone);
            this.panel1.Controls.Add(this.buttonOpenFile);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 79);
            this.panel1.TabIndex = 0;
            // 
            // buttonInform
            // 
            this.buttonInform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInform.Image = ((System.Drawing.Image)(resources.GetObject("buttonInform.Image")));
            this.buttonInform.Location = new System.Drawing.Point(861, 3);
            this.buttonInform.Name = "buttonInform";
            this.buttonInform.Size = new System.Drawing.Size(82, 62);
            this.buttonInform.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonInform, "Сведение о программе");
            this.buttonInform.UseVisualStyleBackColor = true;
            this.buttonInform.Click += new System.EventHandler(this.buttonInform_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Enabled = false;
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.Location = new System.Drawing.Point(92, 3);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(83, 62);
            this.buttonDone.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonDone, "Производит поиск в файле вхождение символа \"z\"\r\nи конкатенирует слова в которых н" +
        "аходится\r\nэтот символ");
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(3, 3);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(83, 62);
            this.buttonOpenFile.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonOpenFile, "Открыть файл\r\nВыберете нужный файл для обработки");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCondition.BackColor = System.Drawing.Color.Coral;
            this.groupBoxCondition.Controls.Add(this.textBoxTask);
            this.groupBoxCondition.Location = new System.Drawing.Point(0, 0);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(948, 75);
            this.groupBoxCondition.TabIndex = 1;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxTask.Location = new System.Drawing.Point(6, 20);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(941, 46);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.TabStop = false;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.groupBoxOutPutData);
            this.panel2.Controls.Add(this.groupBoxInputData);
            this.panel2.Controls.Add(this.groupBoxCondition);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(946, 432);
            this.panel2.TabIndex = 2;
            // 
            // groupBoxOutPutData
            // 
            this.groupBoxOutPutData.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxOutPutData.Controls.Add(this.textBoxOutPutData);
            this.groupBoxOutPutData.Location = new System.Drawing.Point(485, 72);
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.Size = new System.Drawing.Size(463, 360);
            this.groupBoxOutPutData.TabIndex = 3;
            this.groupBoxOutPutData.TabStop = false;
            this.groupBoxOutPutData.Text = "Вывод:";
            // 
            // textBoxOutPutData
            // 
            this.textBoxOutPutData.Location = new System.Drawing.Point(0, 41);
            this.textBoxOutPutData.Multiline = true;
            this.textBoxOutPutData.Name = "textBoxOutPutData";
            this.textBoxOutPutData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData.Size = new System.Drawing.Size(462, 307);
            this.textBoxOutPutData.TabIndex = 0;
            this.textBoxOutPutData.TabStop = false;
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxInputData.Controls.Add(this.textBoxInputData);
            this.groupBoxInputData.Location = new System.Drawing.Point(0, 72);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(485, 360);
            this.groupBoxInputData.TabIndex = 2;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод: C:\\Users\\Sascha\\source\\repos\\Tyuiu.SpirinAA.Sprint6\\Tyuiu.SpirinAA.Sprint6." +
    "Task6.V14\\bin\\Debug\\InPutFileTask6V14.txt";
            // 
            // textBoxInputData
            // 
            this.textBoxInputData.Location = new System.Drawing.Point(0, 41);
            this.textBoxInputData.Multiline = true;
            this.textBoxInputData.Name = "textBoxInputData";
            this.textBoxInputData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInputData.Size = new System.Drawing.Size(473, 307);
            this.textBoxInputData.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 510);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 14 | Спирин А.А. ";
            this.panel1.ResumeLayout(false);
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxOutPutData.ResumeLayout(false);
            this.groupBoxOutPutData.PerformLayout();
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxInputData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxOutPutData;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.TextBox textBoxInputData;
        private System.Windows.Forms.Button buttonInform;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxOutPutData;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

