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
        Dictionary<string, uint> main_dic;
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
        private void AddToListBox()
        {
            foreach (var b in main_dic.OrderByDescending(x => x.Value).Select(t => $"{t.Key} - {t.Value}"))
                listBox1.Items.Add(b);
        }
        private async void AsyncAddToListBox()
        {
            await Task.Run(()=>AddToListBox());
        }
        private async void GoButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!Directory.Exists(PathTextBox.Text)) { MessageBox.Show("File not exists"); return; }
            manager = new Manager(PathTextBox.Text);
            OverviewButton.Enabled = false;
            GoButton.Enabled = false;
            PathTextBox.Enabled = false;
            FirstWordsTextBox.Enabled = false;

            ProgressBar.Maximum = manager.reader.StorageFilesCount;
            stopWatch.Start();
            timer.Start();
            main_dic = await manager.Run();
            manager.Clean();
            timer.Stop();
            stopWatch.Stop();
            File.Delete(Path.Combine(PathTextBox.Text, "FileInfo.txt"));
            OverviewButton.Enabled = true;
            GoButton.Enabled = true;
            PathTextBox.Enabled = true;
            BuildButton.Enabled = true;
            FirstWordsTextBox.Enabled = true;

            CountWordsTextLabel.Text = manager.dictionary.DifferentWords.ToString();
            CountAllWordsTextLabel.Text = manager.dictionary.All.ToString();
            MessageBox.Show("Dictionary is made");
            timer_Tick(null, null);
            ProgressBar.Value = 0;

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (manager.reader.StorageFilesProcessedCount <= ProgressBar.Maximum)
            {
                ProgressBar.Value = manager.reader.StorageFilesProcessedCount;
                ts = stopWatch.Elapsed;
                TimeTextLabel.Text = string.Format("{0:00}:{1:00}:{2:00}:{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            KeyValuePair<string, uint>[] chartdictionary;
            chartdictionary = main_dic.OrderByDescending(x => x.Value).ToArray();
            AsyncAddToListBox();
            var series = chart1.Series.FindByName("Word");
            if (series == null)
            {
                series = chart1.Series.Add("Word");
                series.Color = Color.LightGray;
                series.ChartType = SeriesChartType.Column;
                series.ChartArea = "ChartArea1";
            }
            else
            {
                series.Points.Clear();
            }
            var zipf = chart1.Series.FindByName("Zipf");
            if (zipf == null)
            {
                zipf = chart1.Series.Add("Zipf");
                zipf.Color = Color.Red;
                zipf.ChartType = SeriesChartType.Line;
                zipf.ChartArea = "ChartArea1";
            }
            else
            {
                zipf.Points.Clear();
            }
            for(int i = 1 ; i <= int.Parse(FirstWordsTextBox.Text);i++)
            {
                zipf.Points.AddY(chartdictionary[0].Value/i);
            }
            foreach (var pair in chartdictionary.Take(int.Parse(FirstWordsTextBox.Text)))
            {
                series.Points.AddY(pair.Value);
            }
            chart1.ChartAreas[0].RecalculateAxesScale();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CountAllWordsTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
