using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using VagnerFisherAlgorithmlib;

namespace FileSearch
{
    public partial class Form1 : Form
    {
        List<string> fileText = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btProcessFile_Click(object sender, EventArgs e)
        {
            fileText.Clear();
            Stopwatch fixedTime = new Stopwatch();
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                fixedTime.Start();
                string[] text = File.ReadAllText(openFD.FileName).Split(' ');
                foreach (string i in text)
                    if (!fileText.Contains(i))
                        fileText.Add(i);
                fixedTime.Stop();
                lbTimeForFindWord.Text = fixedTime.Elapsed.ToString();
            }
        }

        private void btFindWord_Click(object sender, EventArgs e)
        {
            if (tbWord.Text != "" && fileText.Count != 0)
            {
                Stopwatch fixedTime = new Stopwatch();
                int maxDistance;
                if (rbPreciseMatch.Checked)
                {
                    fixedTime.Start();
                    int countOfThreads = Int32.Parse(domainCountOfThreads.Text), countOfWords = fileText.Count / countOfThreads;
                    Task<bool>[] tasks = new Task<bool>[countOfThreads];
                    for (int i = 0; i < countOfThreads; i++)
                    {
                        List<string> tempTaskList = fileText.GetRange(i * countOfWords, (i == countOfThreads - 1 ? fileText.Count - i * countOfWords : countOfWords));
                        tasks[i] = new Task<bool>(() => (tempTaskList.Contains(tbWord.Text)));
                        tasks[i].Start();
                    }
                    Task.WaitAll(tasks);
                    fixedTime.Stop();
                    foreach (Task<bool> i in tasks)
                    {
                        if (i.Result)
                        {
                            listBoxOfFindWords.BeginUpdate();
                            listBoxOfFindWords.Items.Add(tbWord.Text + " - " + fixedTime.ElapsedMilliseconds.ToString());
                            listBoxOfFindWords.EndUpdate();
                        }
                    }
                    lbTimeForFindWord.Text = fixedTime.Elapsed.ToString();
                }
                else if (Int32.TryParse(comboBoxOfMaxDistance.Text, out maxDistance)) 
                {
                    fixedTime.Start();
                    int countOfThreads = Int32.Parse(domainCountOfThreads.Text), countOfWords = fileText.Count / countOfThreads;
                    Task<List<string>>[] tasks = new Task<List<string>>[countOfThreads];
                    for (int i = 0; i < countOfThreads; i++)
                    {
                        List<string> tempTaskList = fileText.GetRange(i * countOfWords, (i == countOfThreads - 1 ? fileText.Count - i * countOfWords : countOfWords));
                        tasks[i] = new Task<List<string>>(() => FindLevinsteinDistanceInThread(tempTaskList, tbWord.Text, maxDistance));
                        tasks[i].Start();
                    }
                    Task.WaitAll(tasks);
                    fixedTime.Stop();
                    foreach (Task<List<string>> i in tasks)
                    {
                        foreach (string j in i.Result)
						{
                            listBoxOfFindWords.BeginUpdate();
                            listBoxOfFindWords.Items.Add(j + " - " + maxDistance.ToString() + " - " + fixedTime.ElapsedMilliseconds.ToString());
                            listBoxOfFindWords.EndUpdate();
                        }
                    }
                    lbTimeForFindWord.Text = fixedTime.Elapsed.ToString();
                }
            }
            tbWord.Text = "";
        }
        private void rbPercentMatch_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxOfMaxDistance.Visible = rbPercentMatch.Checked;
        }
        private void btClearListBox_Click(object sender, EventArgs e)
        {
            listBoxOfFindWords.Items.Clear();
        }

		private void btSaveResults_Click(object sender, EventArgs e)
		{
            if (saveFD.ShowDialog() == DialogResult.OK)
            {
                File.Create(saveFD.FileName).Close();
                foreach (string i in listBoxOfFindWords.Items)
                    File.AppendAllText(saveFD.FileName, i + "\n");
            }
        }
        static List<string> FindLevinsteinDistanceInThread(List<string> strList, string word, int maxDistance)
		{
            List<string> ResultList = new List<string>();
            foreach (string i in strList)
                if (LevinsteinVagner.CalculateDistance(i, word) <= maxDistance)
                    ResultList.Add(i);
            return ResultList;
		}
	}
}
