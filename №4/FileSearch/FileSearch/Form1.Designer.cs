namespace FileSearch
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
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.btProcessFile = new System.Windows.Forms.Button();
            this.lbTimeForProcessFile = new System.Windows.Forms.Label();
            this.btFindWord = new System.Windows.Forms.Button();
            this.lbTimeForFindWord = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.listBoxOfFindWords = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // openFD
            // 
            this.openFD.Filter = "Текстовые файлы (*.txt)|";
            // 
            // btProcessFile
            // 
            this.btProcessFile.Location = new System.Drawing.Point(12, 12);
            this.btProcessFile.Name = "btProcessFile";
            this.btProcessFile.Size = new System.Drawing.Size(90, 23);
            this.btProcessFile.TabIndex = 0;
            this.btProcessFile.Text = "Выбрать файл";
            this.btProcessFile.UseVisualStyleBackColor = true;
            this.btProcessFile.Click += new System.EventHandler(this.btProcessFile_Click);
            // 
            // lbTimeForProcessFile
            // 
            this.lbTimeForProcessFile.AutoSize = true;
            this.lbTimeForProcessFile.Location = new System.Drawing.Point(123, 17);
            this.lbTimeForProcessFile.Name = "lbTimeForProcessFile";
            this.lbTimeForProcessFile.Size = new System.Drawing.Size(0, 16);
            this.lbTimeForProcessFile.TabIndex = 1;
            // 
            // btFindWord
            // 
            this.btFindWord.Location = new System.Drawing.Point(12, 76);
            this.btFindWord.Name = "btFindWord";
            this.btFindWord.Size = new System.Drawing.Size(90, 23);
            this.btFindWord.TabIndex = 2;
            this.btFindWord.Text = "Найти";
            this.btFindWord.UseVisualStyleBackColor = true;
            this.btFindWord.Click += new System.EventHandler(this.btFindWord_Click);
            // 
            // lbTimeForFindWord
            // 
            this.lbTimeForFindWord.AutoSize = true;
            this.lbTimeForFindWord.Location = new System.Drawing.Point(123, 81);
            this.lbTimeForFindWord.Name = "lbTimeForFindWord";
            this.lbTimeForFindWord.Size = new System.Drawing.Size(0, 16);
            this.lbTimeForFindWord.TabIndex = 3;
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(12, 46);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(90, 22);
            this.tbWord.TabIndex = 4;
            // 
            // listBoxOfFindWords
            // 
            this.listBoxOfFindWords.FormattingEnabled = true;
            this.listBoxOfFindWords.Location = new System.Drawing.Point(12, 132);
            this.listBoxOfFindWords.Name = "listBoxOfFindWords";
            this.listBoxOfFindWords.Size = new System.Drawing.Size(211, 160);
            this.listBoxOfFindWords.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 304);
            this.Controls.Add(this.listBoxOfFindWords);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.lbTimeForFindWord);
            this.Controls.Add(this.btFindWord);
            this.Controls.Add(this.lbTimeForProcessFile);
            this.Controls.Add(this.btProcessFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "FileSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button btProcessFile;
        private System.Windows.Forms.Label lbTimeForProcessFile;
        private System.Windows.Forms.Button btFindWord;
        private System.Windows.Forms.Label lbTimeForFindWord;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.ListBox listBoxOfFindWords;
    }
}

