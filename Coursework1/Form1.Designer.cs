namespace Coursework1
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.InputFileGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.OverviewButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.ProgressGroupBox = new System.Windows.Forms.GroupBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeTextLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.CountWordsTextLabel = new System.Windows.Forms.Label();
            this.CountWordsLabel = new System.Windows.Forms.Label();
            this.BarChartGroupBox = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BuildButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.InputFileGroupBox.SuspendLayout();
            this.ProgressGroupBox.SuspendLayout();
            this.ResultsGroupBox.SuspendLayout();
            this.BarChartGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // InputFileGroupBox
            // 
            this.InputFileGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InputFileGroupBox.Controls.Add(this.GoButton);
            this.InputFileGroupBox.Controls.Add(this.OverviewButton);
            this.InputFileGroupBox.Controls.Add(this.PathTextBox);
            this.InputFileGroupBox.Location = new System.Drawing.Point(1, 1);
            this.InputFileGroupBox.Name = "InputFileGroupBox";
            this.InputFileGroupBox.Size = new System.Drawing.Size(430, 87);
            this.InputFileGroupBox.TabIndex = 0;
            this.InputFileGroupBox.TabStop = false;
            this.InputFileGroupBox.Text = "Input file";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(337, 37);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(81, 28);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // OverviewButton
            // 
            this.OverviewButton.Location = new System.Drawing.Point(11, 38);
            this.OverviewButton.Name = "OverviewButton";
            this.OverviewButton.Size = new System.Drawing.Size(82, 27);
            this.OverviewButton.TabIndex = 1;
            this.OverviewButton.Text = "Overview";
            this.OverviewButton.UseVisualStyleBackColor = true;
            this.OverviewButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(108, 40);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(211, 22);
            this.PathTextBox.TabIndex = 1;
            this.PathTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ProgressGroupBox
            // 
            this.ProgressGroupBox.Controls.Add(this.ProgressBar);
            this.ProgressGroupBox.Location = new System.Drawing.Point(1, 94);
            this.ProgressGroupBox.Name = "ProgressGroupBox";
            this.ProgressGroupBox.Size = new System.Drawing.Size(430, 98);
            this.ProgressGroupBox.TabIndex = 1;
            this.ProgressGroupBox.TabStop = false;
            this.ProgressGroupBox.Text = "Progress";
            this.ProgressGroupBox.Enter += new System.EventHandler(this.ProgressGroupBox_Enter);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(11, 44);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(407, 23);
            this.ProgressBar.TabIndex = 0;
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Controls.Add(this.TimeTextLabel);
            this.ResultsGroupBox.Controls.Add(this.TimeLabel);
            this.ResultsGroupBox.Controls.Add(this.CountWordsTextLabel);
            this.ResultsGroupBox.Controls.Add(this.CountWordsLabel);
            this.ResultsGroupBox.Location = new System.Drawing.Point(1, 198);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(430, 96);
            this.ResultsGroupBox.TabIndex = 2;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results";
            // 
            // TimeTextLabel
            // 
            this.TimeTextLabel.AutoSize = true;
            this.TimeTextLabel.Location = new System.Drawing.Point(325, 49);
            this.TimeTextLabel.Name = "TimeTextLabel";
            this.TimeTextLabel.Size = new System.Drawing.Size(84, 17);
            this.TimeTextLabel.TabIndex = 3;
            this.TimeTextLabel.Text = "00:00:00:00";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(272, 49);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(47, 17);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "Time :";
            // 
            // CountWordsTextLabel
            // 
            this.CountWordsTextLabel.AutoSize = true;
            this.CountWordsTextLabel.Location = new System.Drawing.Point(128, 49);
            this.CountWordsTextLabel.Name = "CountWordsTextLabel";
            this.CountWordsTextLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CountWordsTextLabel.Size = new System.Drawing.Size(16, 17);
            this.CountWordsTextLabel.TabIndex = 1;
            this.CountWordsTextLabel.Text = "0";
            // 
            // CountWordsLabel
            // 
            this.CountWordsLabel.AutoSize = true;
            this.CountWordsLabel.Location = new System.Drawing.Point(12, 49);
            this.CountWordsLabel.Name = "CountWordsLabel";
            this.CountWordsLabel.Size = new System.Drawing.Size(110, 17);
            this.CountWordsLabel.TabIndex = 0;
            this.CountWordsLabel.Text = "Count of words :";
            this.CountWordsLabel.Click += new System.EventHandler(this.CountWordsLabel_Click);
            // 
            // BarChartGroupBox
            // 
            this.BarChartGroupBox.Controls.Add(this.chart1);
            this.BarChartGroupBox.Controls.Add(this.BuildButton);
            this.BarChartGroupBox.Location = new System.Drawing.Point(437, 1);
            this.BarChartGroupBox.Name = "BarChartGroupBox";
            this.BarChartGroupBox.Size = new System.Drawing.Size(735, 516);
            this.BarChartGroupBox.TabIndex = 3;
            this.BarChartGroupBox.TabStop = false;
            this.BarChartGroupBox.Text = "Bar Chart";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 71);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(721, 424);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "Word frequency";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // BuildButton
            // 
            this.BuildButton.Enabled = false;
            this.BuildButton.Location = new System.Drawing.Point(602, 37);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(125, 28);
            this.BuildButton.TabIndex = 0;
            this.BuildButton.Text = "Build";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 520);
            this.Controls.Add(this.BarChartGroupBox);
            this.Controls.Add(this.ResultsGroupBox);
            this.Controls.Add(this.ProgressGroupBox);
            this.Controls.Add(this.InputFileGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Coursework";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.InputFileGroupBox.ResumeLayout(false);
            this.InputFileGroupBox.PerformLayout();
            this.ProgressGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
            this.BarChartGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InputFileGroupBox;
        private System.Windows.Forms.Button OverviewButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.GroupBox ProgressGroupBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
        private System.Windows.Forms.Label CountWordsLabel;
        private System.Windows.Forms.Label TimeTextLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label CountWordsTextLabel;
        private System.Windows.Forms.GroupBox BarChartGroupBox;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer;
    }
}

