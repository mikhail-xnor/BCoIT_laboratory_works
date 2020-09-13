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
            this.rbPreciseMatch = new System.Windows.Forms.RadioButton();
            this.rbPercentMatch = new System.Windows.Forms.RadioButton();
            this.comboBoxOfMaxDistance = new System.Windows.Forms.ComboBox();
            this.btClearListBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFD
            // 
            this.openFD.Filter = "Текстовые файлы (*.txt)|";
            // 
            // btProcessFile
            // 
            this.btProcessFile.Location = new System.Drawing.Point(16, 15);
            this.btProcessFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btProcessFile.Name = "btProcessFile";
            this.btProcessFile.Size = new System.Drawing.Size(120, 28);
            this.btProcessFile.TabIndex = 0;
            this.btProcessFile.Text = "Выбрать файл";
            this.btProcessFile.UseVisualStyleBackColor = true;
            this.btProcessFile.Click += new System.EventHandler(this.btProcessFile_Click);
            // 
            // lbTimeForProcessFile
            // 
            this.lbTimeForProcessFile.AutoSize = true;
            this.lbTimeForProcessFile.Location = new System.Drawing.Point(144, 21);
            this.lbTimeForProcessFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeForProcessFile.Name = "lbTimeForProcessFile";
            this.lbTimeForProcessFile.Size = new System.Drawing.Size(0, 16);
            this.lbTimeForProcessFile.TabIndex = 3;
            // 
            // btFindWord
            // 
            this.btFindWord.Location = new System.Drawing.Point(16, 94);
            this.btFindWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btFindWord.Name = "btFindWord";
            this.btFindWord.Size = new System.Drawing.Size(120, 28);
            this.btFindWord.TabIndex = 2;
            this.btFindWord.Text = "Найти";
            this.btFindWord.UseVisualStyleBackColor = true;
            this.btFindWord.Click += new System.EventHandler(this.btFindWord_Click);
            // 
            // lbTimeForFindWord
            // 
            this.lbTimeForFindWord.AutoSize = true;
            this.lbTimeForFindWord.Location = new System.Drawing.Point(144, 100);
            this.lbTimeForFindWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeForFindWord.Name = "lbTimeForFindWord";
            this.lbTimeForFindWord.Size = new System.Drawing.Size(0, 16);
            this.lbTimeForFindWord.TabIndex = 4;
            // 
            // tbWord
            // 
            this.tbWord.AccessibleDescription = "";
            this.tbWord.AccessibleName = "";
            this.tbWord.Location = new System.Drawing.Point(16, 57);
            this.tbWord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(119, 22);
            this.tbWord.TabIndex = 1;
            // 
            // listBoxOfFindWords
            // 
            this.listBoxOfFindWords.FormattingEnabled = true;
            this.listBoxOfFindWords.ItemHeight = 16;
            this.listBoxOfFindWords.Location = new System.Drawing.Point(16, 130);
            this.listBoxOfFindWords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxOfFindWords.Name = "listBoxOfFindWords";
            this.listBoxOfFindWords.Size = new System.Drawing.Size(343, 212);
            this.listBoxOfFindWords.TabIndex = 5;
            // 
            // rbPreciseMatch
            // 
            this.rbPreciseMatch.AutoSize = true;
            this.rbPreciseMatch.Checked = true;
            this.rbPreciseMatch.Location = new System.Drawing.Point(142, 50);
            this.rbPreciseMatch.Name = "rbPreciseMatch";
            this.rbPreciseMatch.Size = new System.Drawing.Size(105, 36);
            this.rbPreciseMatch.TabIndex = 6;
            this.rbPreciseMatch.TabStop = true;
            this.rbPreciseMatch.Text = "Точное\r\nсовпадение";
            this.rbPreciseMatch.UseVisualStyleBackColor = true;
            // 
            // rbPercentMatch
            // 
            this.rbPercentMatch.AutoSize = true;
            this.rbPercentMatch.Location = new System.Drawing.Point(253, 50);
            this.rbPercentMatch.Name = "rbPercentMatch";
            this.rbPercentMatch.Size = new System.Drawing.Size(115, 36);
            this.rbPercentMatch.TabIndex = 6;
            this.rbPercentMatch.Text = "Расстояние\r\nЛевенштейна\r\n";
            this.rbPercentMatch.UseVisualStyleBackColor = true;
            this.rbPercentMatch.CheckedChanged += new System.EventHandler(this.rbPercentMatch_CheckedChanged);
            // 
            // comboBoxOfMaxDistance
            // 
            this.comboBoxOfMaxDistance.FormattingEnabled = true;
            this.comboBoxOfMaxDistance.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxOfMaxDistance.Location = new System.Drawing.Point(273, 92);
            this.comboBoxOfMaxDistance.Name = "comboBoxOfMaxDistance";
            this.comboBoxOfMaxDistance.Size = new System.Drawing.Size(86, 24);
            this.comboBoxOfMaxDistance.TabIndex = 7;
            this.comboBoxOfMaxDistance.Visible = false;
            // 
            // btClearListBox
            // 
            this.btClearListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClearListBox.Location = new System.Drawing.Point(16, 344);
            this.btClearListBox.Name = "btClearListBox";
            this.btClearListBox.Size = new System.Drawing.Size(343, 24);
            this.btClearListBox.TabIndex = 8;
            this.btClearListBox.Text = "Отчистить";
            this.btClearListBox.UseVisualStyleBackColor = true;
            this.btClearListBox.Click += new System.EventHandler(this.btClearListBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 374);
            this.Controls.Add(this.btClearListBox);
            this.Controls.Add(this.comboBoxOfMaxDistance);
            this.Controls.Add(this.rbPercentMatch);
            this.Controls.Add(this.rbPreciseMatch);
            this.Controls.Add(this.listBoxOfFindWords);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.lbTimeForFindWord);
            this.Controls.Add(this.btFindWord);
            this.Controls.Add(this.lbTimeForProcessFile);
            this.Controls.Add(this.btProcessFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.RadioButton rbPreciseMatch;
        private System.Windows.Forms.RadioButton rbPercentMatch;
        private System.Windows.Forms.ComboBox comboBoxOfMaxDistance;
        private System.Windows.Forms.Button btClearListBox;
    }
}

