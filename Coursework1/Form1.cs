using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Coursework1
{
    public partial class MainWindow : Form
    {
        private Stopwatch stopWatch = new Stopwatch();
        private TimeSpan ts;
        private Manager manager;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ProgressGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CountWordsLabel_Click(object sender, EventArgs e)
        {

        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(PathTextBox.Text)) { MessageBox.Show("File not exists"); return; }
            manager = new Manager(PathTextBox.Text);
            OverviewButton.Enabled = false;
            GoButton.Enabled = false;
            PathTextBox.Enabled = false;

            ProgressBar.Maximum = manager.reader.StorageFilesCount;
            stopWatch.Start();
            timer.Start();

            manager.Run();
            manager.Clean();
            timer.Stop();
            stopWatch.Stop();
            File.Delete(Path.Combine(PathTextBox.Text, "FileInfo.txt"));

            OverviewButton.Enabled = true;
            GoButton.Enabled = true;
            PathTextBox.Enabled = true;
            BuildButton.Enabled = true;

            CountWordsTextLabel.Text = manager.dictionary.DifferentWords.ToString();

            MessageBox.Show("Dictionary is made");
            timer_Tick(null, null);
            ProgressBar.Value = 0;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value = manager.reader.StorageFilesProcessedCount;
            ts = stopWatch.Elapsed;
            TimeTextLabel.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            KeyValuePair<string, uint>[] chartdictionary;

            chartdictionary = manager.dictionary.Export().OrderByDescending(x => x.Value).ToArray();

            var series = chart1.Series.FindByName("Series1");
            if (series == null)
            {
                series = chart1.Series.Add("Series1");
                series.ChartType = SeriesChartType.Column;
                series.ChartArea = "ChartArea1";
            }
            else
            {
                series.Points.Clear();
            }
            foreach (var pair in chartdictionary.Take(int.Parse(CountWordsTextLabel.Text)))
            {
                series.Points.AddY(pair.Value);
            }
        }
    }
}
