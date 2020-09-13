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
                lbTimeForProcessFile.Text = fixedTime.Elapsed.ToString();
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
                    bool isFind = false;
                    fixedTime.Start();
                    if (fileText.Contains(tbWord.Text))
                        isFind = true;
                    fixedTime.Stop();
                    if (isFind)
                    {
                        listBoxOfFindWords.BeginUpdate();
                        listBoxOfFindWords.Items.Add(tbWord.Text);
                        listBoxOfFindWords.EndUpdate();
                    }
                    lbTimeForFindWord.Text = fixedTime.Elapsed.ToString();
                }
                else if (Int32.TryParse(comboBoxOfMaxDistance.Text, out maxDistance)) 
                {
                    fixedTime.Start();
                    foreach (string i in fileText)
                    {
                        if (LevinsteinVagner.CalculateDistance(i, tbWord.Text) <= maxDistance)
                        {
                            listBoxOfFindWords.BeginUpdate();
                            listBoxOfFindWords.Items.Add(i);
                            listBoxOfFindWords.EndUpdate();
                        }
                    }
                    fixedTime.Stop();
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
    }
}
