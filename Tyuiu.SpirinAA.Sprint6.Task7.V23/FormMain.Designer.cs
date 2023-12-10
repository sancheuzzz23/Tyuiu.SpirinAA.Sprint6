namespace Tyuiu.SpirinAA.Sprint6.Task7.V23
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonInform = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxInputData = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData = new System.Windows.Forms.GroupBox();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.dataGridViewIn = new System.Windows.Forms.DataGridView();
            this.dataGridViewOut = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxCondition.SuspendLayout();
            this.groupBoxInputData.SuspendLayout();
            this.groupBoxOutPutData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonDone);
            this.panel1.Controls.Add(this.buttonInform);
            this.panel1.Controls.Add(this.buttonOpenFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 84);
            this.panel1.TabIndex = 0;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile.Image")));
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 8);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(91, 69);
            this.buttonOpenFile.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonOpenFile, "Открыть файл\r\nВыберете нужный файл для обработки");
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            this.buttonOpenFile.MouseEnter += new System.EventHandler(this.buttonOpenFile_MouseEnter);
            // 
            // buttonDone
            // 
            this.buttonDone.Enabled = false;
            this.buttonDone.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone.Image")));
            this.buttonDone.Location = new System.Drawing.Point(109, 8);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(91, 69);
            this.buttonDone.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonDone, "Выполнить обработку данных\r\n");
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            this.buttonDone.MouseEnter += new System.EventHandler(this.buttonDone_MouseEnter);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
            this.buttonSave.Location = new System.Drawing.Point(206, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 69);
            this.buttonSave.TabIndex = 0;
            this.toolTipButton.SetToolTip(this.buttonSave, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            this.buttonSave.MouseEnter += new System.EventHandler(this.buttonSave_MouseEnter);
            // 
            // buttonInform
            // 
            this.buttonInform.Image = ((System.Drawing.Image)(resources.GetObject("buttonInform.Image")));
            this.buttonInform.Location = new System.Drawing.Point(793, 8);
            this.buttonInform.Name = "buttonInform";
            this.buttonInform.Size = new System.Drawing.Size(90, 69);
            this.buttonInform.TabIndex = 0;
            this.buttonInform.UseVisualStyleBackColor = true;
            this.buttonInform.Click += new System.EventHandler(this.buttonInform_Click);
            this.buttonInform.MouseEnter += new System.EventHandler(this.buttonInform_MouseEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxOutPutData);
            this.panel2.Controls.Add(this.groupBoxInputData);
            this.panel2.Controls.Add(this.groupBoxCondition);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(888, 439);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCondition.Controls.Add(this.textBoxTask);
            this.groupBoxCondition.Location = new System.Drawing.Point(2, 2);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(880, 100);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие:";
            // 
            // textBoxTask
            // 
            this.textBoxTask.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask.Location = new System.Drawing.Point(2, 19);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(879, 75);
            this.textBoxTask.TabIndex = 0;
            this.textBoxTask.TabStop = false;
            this.textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxInputData
            // 
            this.groupBoxInputData.Controls.Add(this.dataGridViewIn);
            this.groupBoxInputData.Location = new System.Drawing.Point(4, 102);
            this.groupBoxInputData.Name = "groupBoxInputData";
            this.groupBoxInputData.Size = new System.Drawing.Size(431, 334);
            this.groupBoxInputData.TabIndex = 1;
            this.groupBoxInputData.TabStop = false;
            this.groupBoxInputData.Text = "Ввод:";
            // 
            // groupBoxOutPutData
            // 
            this.groupBoxOutPutData.Controls.Add(this.dataGridViewOut);
            this.groupBoxOutPutData.Location = new System.Drawing.Point(441, 102);
            this.groupBoxOutPutData.Name = "groupBoxOutPutData";
            this.groupBoxOutPutData.Size = new System.Drawing.Size(442, 334);
            this.groupBoxOutPutData.TabIndex = 2;
            this.groupBoxOutPutData.TabStop = false;
            this.groupBoxOutPutData.Text = "Вывод:";
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            this.toolTipButton.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipButton.ToolTipTitle = "Помощь";
            // 
            // dataGridViewIn
            // 
            this.dataGridViewIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn.Location = new System.Drawing.Point(9, 19);
            this.dataGridViewIn.Name = "dataGridViewIn";
            this.dataGridViewIn.Size = new System.Drawing.Size(416, 309);
            this.dataGridViewIn.TabIndex = 0;
            // 
            // dataGridViewOut
            // 
            this.dataGridViewOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut.Location = new System.Drawing.Point(7, 19);
            this.dataGridViewOut.Name = "dataGridViewOut";
            this.dataGridViewOut.Size = new System.Drawing.Size(429, 309);
            this.dataGridViewOut.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 527);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 23 | Спирин А. А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.groupBoxInputData.ResumeLayout(false);
            this.groupBoxOutPutData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonInform;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxOutPutData;
        private System.Windows.Forms.GroupBox groupBoxInputData;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.DataGridView dataGridViewOut;
        private System.Windows.Forms.DataGridView dataGridViewIn;
    }
}

