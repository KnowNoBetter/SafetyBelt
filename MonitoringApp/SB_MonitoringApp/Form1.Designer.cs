namespace SB_MonitoringApp
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sidePan = new System.Windows.Forms.Panel();
            this.Classification = new System.Windows.Forms.Button();
            this.Connection = new System.Windows.Forms.Button();
            this.Databoard = new System.Windows.Forms.Button();
            this.logoPan = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.headerPan = new System.Windows.Forms.Panel();
            this.TabTitle = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Label();
            this.databoardPanel = new System.Windows.Forms.Panel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.connectPanel = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.classificationPanel = new System.Windows.Forms.Panel();
            this.PredictionScore = new System.Windows.Forms.Label();
            this.Target = new System.Windows.Forms.Label();
            this.DownstairIcon = new System.Windows.Forms.PictureBox();
            this.UpstairIcon = new System.Windows.Forms.PictureBox();
            this.RunningIcon = new System.Windows.Forms.PictureBox();
            this.WalkingIcon = new System.Windows.Forms.PictureBox();
            this.StandingIcon = new System.Windows.Forms.PictureBox();
            this.StatusList = new System.Windows.Forms.TextBox();
            this.Minimize = new System.Windows.Forms.Label();
            this.Maximized = new System.Windows.Forms.Label();
            this.sidePan.SuspendLayout();
            this.logoPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerPan.SuspendLayout();
            this.databoardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.connectPanel.SuspendLayout();
            this.classificationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DownstairIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpstairIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkingIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StandingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePan
            // 
            this.sidePan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidePan.Controls.Add(this.Classification);
            this.sidePan.Controls.Add(this.Connection);
            this.sidePan.Controls.Add(this.Databoard);
            this.sidePan.Controls.Add(this.logoPan);
            this.sidePan.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sidePan.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePan.Location = new System.Drawing.Point(0, 0);
            this.sidePan.Name = "sidePan";
            this.sidePan.Size = new System.Drawing.Size(282, 669);
            this.sidePan.TabIndex = 0;
            // 
            // Classification
            // 
            this.Classification.Cursor = System.Windows.Forms.Cursors.Default;
            this.Classification.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Classification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Classification.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Classification.ForeColor = System.Drawing.Color.White;
            this.Classification.Location = new System.Drawing.Point(0, 113);
            this.Classification.Name = "Classification";
            this.Classification.Padding = new System.Windows.Forms.Padding(0, 0, 80, 0);
            this.Classification.Size = new System.Drawing.Size(282, 39);
            this.Classification.TabIndex = 3;
            this.Classification.Text = "Classification";
            this.Classification.UseVisualStyleBackColor = true;
            this.Classification.Click += new System.EventHandler(this.Classification_Click);
            // 
            // Connection
            // 
            this.Connection.Cursor = System.Windows.Forms.Cursors.Default;
            this.Connection.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connection.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection.ForeColor = System.Drawing.Color.White;
            this.Connection.Location = new System.Drawing.Point(0, 158);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(0, 0, 85, 0);
            this.Connection.Size = new System.Drawing.Size(282, 39);
            this.Connection.TabIndex = 2;
            this.Connection.Text = "Connection";
            this.Connection.UseVisualStyleBackColor = true;
            this.Connection.Click += new System.EventHandler(this.Connection_Click);
            // 
            // Databoard
            // 
            this.Databoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.Databoard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.Databoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Databoard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Databoard.ForeColor = System.Drawing.Color.White;
            this.Databoard.Location = new System.Drawing.Point(0, 68);
            this.Databoard.Name = "Databoard";
            this.Databoard.Padding = new System.Windows.Forms.Padding(0, 0, 90, 0);
            this.Databoard.Size = new System.Drawing.Size(282, 39);
            this.Databoard.TabIndex = 1;
            this.Databoard.Text = "Databoard";
            this.Databoard.UseVisualStyleBackColor = true;
            this.Databoard.Click += new System.EventHandler(this.Databoard_Click);
            // 
            // logoPan
            // 
            this.logoPan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.logoPan.Controls.Add(this.pictureBox1);
            this.logoPan.Controls.Add(this.Title);
            this.logoPan.Cursor = System.Windows.Forms.Cursors.Default;
            this.logoPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPan.Location = new System.Drawing.Point(0, 0);
            this.logoPan.Name = "logoPan";
            this.logoPan.Size = new System.Drawing.Size(282, 67);
            this.logoPan.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Cursor = System.Windows.Forms.Cursors.Default;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(73, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(180, 25);
            this.Title.TabIndex = 2;
            this.Title.Text = "Smart Safety Belt";
            // 
            // headerPan
            // 
            this.headerPan.BackColor = System.Drawing.Color.White;
            this.headerPan.Controls.Add(this.Maximized);
            this.headerPan.Controls.Add(this.Minimize);
            this.headerPan.Controls.Add(this.TabTitle);
            this.headerPan.Controls.Add(this.Exit);
            this.headerPan.Cursor = System.Windows.Forms.Cursors.Default;
            this.headerPan.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPan.Location = new System.Drawing.Point(282, 0);
            this.headerPan.Name = "headerPan";
            this.headerPan.Size = new System.Drawing.Size(968, 67);
            this.headerPan.TabIndex = 1;
            // 
            // TabTitle
            // 
            this.TabTitle.AutoSize = true;
            this.TabTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.TabTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabTitle.Location = new System.Drawing.Point(39, 22);
            this.TabTitle.Name = "TabTitle";
            this.TabTitle.Size = new System.Drawing.Size(112, 23);
            this.TabTitle.TabIndex = 3;
            this.TabTitle.Text = "Databoard";
            // 
            // Exit
            // 
            this.Exit.AutoSize = true;
            this.Exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Exit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(934, 8);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(19, 22);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "x";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // databoardPanel
            // 
            this.databoardPanel.Controls.Add(this.chart);
            this.databoardPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.databoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databoardPanel.Location = new System.Drawing.Point(282, 67);
            this.databoardPanel.Name = "databoardPanel";
            this.databoardPanel.Size = new System.Drawing.Size(968, 602);
            this.databoardPanel.TabIndex = 2;
            // 
            // chart
            // 
            this.chart.BackColor = System.Drawing.Color.Gainsboro;
            this.chart.BorderlineColor = System.Drawing.Color.LightGray;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            this.chart.Cursor = System.Windows.Forms.Cursors.Default;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(0, 17);
            this.chart.Name = "chart";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "gx";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "gy";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Legend = "Legend1";
            series9.Name = "gz";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "ax";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "ay";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "az";
            this.chart.Series.Add(series7);
            this.chart.Series.Add(series8);
            this.chart.Series.Add(series9);
            this.chart.Series.Add(series10);
            this.chart.Series.Add(series11);
            this.chart.Series.Add(series12);
            this.chart.Size = new System.Drawing.Size(975, 573);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart";
            // 
            // connectPanel
            // 
            this.connectPanel.Controls.Add(this.StatusList);
            this.connectPanel.Controls.Add(this.status);
            this.connectPanel.Controls.Add(this.connectButton);
            this.connectPanel.Controls.Add(this.statusLabel);
            this.connectPanel.Controls.Add(this.portTextBox);
            this.connectPanel.Controls.Add(this.IPTextBox);
            this.connectPanel.Controls.Add(this.portLabel);
            this.connectPanel.Controls.Add(this.IPLabel);
            this.connectPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.connectPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connectPanel.Location = new System.Drawing.Point(282, 67);
            this.connectPanel.Name = "connectPanel";
            this.connectPanel.Size = new System.Drawing.Size(968, 602);
            this.connectPanel.TabIndex = 0;
            this.connectPanel.Visible = false;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Cursor = System.Windows.Forms.Cursors.Default;
            this.status.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.status.Location = new System.Drawing.Point(186, 149);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 19);
            this.status.TabIndex = 6;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.connectButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.connectButton.FlatAppearance.BorderSize = 0;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.ForeColor = System.Drawing.Color.White;
            this.connectButton.Location = new System.Drawing.Point(414, 46);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(111, 69);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.statusLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(106, 145);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(74, 23);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "Status :";
            this.statusLabel.UseWaitCursor = true;
            // 
            // portTextBox
            // 
            this.portTextBox.BackColor = System.Drawing.Color.LightGray;
            this.portTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.portTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.portTextBox.Location = new System.Drawing.Point(167, 88);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(225, 27);
            this.portTextBox.TabIndex = 3;
            // 
            // IPTextBox
            // 
            this.IPTextBox.BackColor = System.Drawing.Color.LightGray;
            this.IPTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.IPTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTextBox.Location = new System.Drawing.Point(167, 46);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(225, 27);
            this.IPTextBox.TabIndex = 2;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.portLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(106, 88);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(55, 23);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "Port :";
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.IPLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.Location = new System.Drawing.Point(106, 46);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(36, 23);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP :";
            // 
            // classificationPanel
            // 
            this.classificationPanel.Controls.Add(this.PredictionScore);
            this.classificationPanel.Controls.Add(this.Target);
            this.classificationPanel.Controls.Add(this.DownstairIcon);
            this.classificationPanel.Controls.Add(this.UpstairIcon);
            this.classificationPanel.Controls.Add(this.RunningIcon);
            this.classificationPanel.Controls.Add(this.WalkingIcon);
            this.classificationPanel.Controls.Add(this.StandingIcon);
            this.classificationPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.classificationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classificationPanel.Location = new System.Drawing.Point(282, 67);
            this.classificationPanel.Name = "classificationPanel";
            this.classificationPanel.Size = new System.Drawing.Size(968, 602);
            this.classificationPanel.TabIndex = 1;
            // 
            // PredictionScore
            // 
            this.PredictionScore.AutoSize = true;
            this.PredictionScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.PredictionScore.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PredictionScore.Location = new System.Drawing.Point(489, 295);
            this.PredictionScore.Name = "PredictionScore";
            this.PredictionScore.Size = new System.Drawing.Size(67, 25);
            this.PredictionScore.TabIndex = 6;
            this.PredictionScore.Text = "score";
            // 
            // Target
            // 
            this.Target.AutoSize = true;
            this.Target.Cursor = System.Windows.Forms.Cursors.Default;
            this.Target.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target.Location = new System.Drawing.Point(399, 295);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(93, 25);
            this.Target.TabIndex = 5;
            this.Target.Text = "Target : ";
            // 
            // DownstairIcon
            // 
            this.DownstairIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.DownstairIcon.Image = ((System.Drawing.Image)(resources.GetObject("DownstairIcon.Image")));
            this.DownstairIcon.Location = new System.Drawing.Point(403, 91);
            this.DownstairIcon.Name = "DownstairIcon";
            this.DownstairIcon.Size = new System.Drawing.Size(174, 171);
            this.DownstairIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownstairIcon.TabIndex = 4;
            this.DownstairIcon.TabStop = false;
            this.DownstairIcon.Visible = false;
            // 
            // UpstairIcon
            // 
            this.UpstairIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.UpstairIcon.Image = ((System.Drawing.Image)(resources.GetObject("UpstairIcon.Image")));
            this.UpstairIcon.Location = new System.Drawing.Point(403, 91);
            this.UpstairIcon.Name = "UpstairIcon";
            this.UpstairIcon.Size = new System.Drawing.Size(174, 171);
            this.UpstairIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpstairIcon.TabIndex = 3;
            this.UpstairIcon.TabStop = false;
            this.UpstairIcon.Visible = false;
            // 
            // RunningIcon
            // 
            this.RunningIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.RunningIcon.Image = ((System.Drawing.Image)(resources.GetObject("RunningIcon.Image")));
            this.RunningIcon.Location = new System.Drawing.Point(403, 91);
            this.RunningIcon.Name = "RunningIcon";
            this.RunningIcon.Size = new System.Drawing.Size(174, 171);
            this.RunningIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RunningIcon.TabIndex = 2;
            this.RunningIcon.TabStop = false;
            this.RunningIcon.Visible = false;
            // 
            // WalkingIcon
            // 
            this.WalkingIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.WalkingIcon.Image = ((System.Drawing.Image)(resources.GetObject("WalkingIcon.Image")));
            this.WalkingIcon.Location = new System.Drawing.Point(403, 91);
            this.WalkingIcon.Name = "WalkingIcon";
            this.WalkingIcon.Size = new System.Drawing.Size(174, 171);
            this.WalkingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WalkingIcon.TabIndex = 1;
            this.WalkingIcon.TabStop = false;
            this.WalkingIcon.Visible = false;
            // 
            // StandingIcon
            // 
            this.StandingIcon.Cursor = System.Windows.Forms.Cursors.Default;
            this.StandingIcon.Image = ((System.Drawing.Image)(resources.GetObject("StandingIcon.Image")));
            this.StandingIcon.Location = new System.Drawing.Point(403, 91);
            this.StandingIcon.Name = "StandingIcon";
            this.StandingIcon.Size = new System.Drawing.Size(174, 171);
            this.StandingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StandingIcon.TabIndex = 0;
            this.StandingIcon.TabStop = false;
            // 
            // StatusList
            // 
            this.StatusList.BackColor = System.Drawing.SystemColors.Menu;
            this.StatusList.Location = new System.Drawing.Point(110, 188);
            this.StatusList.Multiline = true;
            this.StatusList.Name = "StatusList";
            this.StatusList.Size = new System.Drawing.Size(778, 376);
            this.StatusList.TabIndex = 7;
            // 
            // Minimize
            // 
            this.Minimize.AutoSize = true;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Location = new System.Drawing.Point(885, 9);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(16, 22);
            this.Minimize.TabIndex = 4;
            this.Minimize.Text = "-";
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Maximized
            // 
            this.Maximized.AutoSize = true;
            this.Maximized.Cursor = System.Windows.Forms.Cursors.Default;
            this.Maximized.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Maximized.Location = new System.Drawing.Point(907, 9);
            this.Maximized.Name = "Maximized";
            this.Maximized.Size = new System.Drawing.Size(21, 22);
            this.Maximized.TabIndex = 5;
            this.Maximized.Text = "+";
            this.Maximized.Click += new System.EventHandler(this.Maximized_Click);
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1250, 669);
            this.Controls.Add(this.classificationPanel);
            this.Controls.Add(this.connectPanel);
            this.Controls.Add(this.databoardPanel);
            this.Controls.Add(this.headerPan);
            this.Controls.Add(this.sidePan);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "mainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.sidePan.ResumeLayout(false);
            this.logoPan.ResumeLayout(false);
            this.logoPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerPan.ResumeLayout(false);
            this.headerPan.PerformLayout();
            this.databoardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.connectPanel.ResumeLayout(false);
            this.connectPanel.PerformLayout();
            this.classificationPanel.ResumeLayout(false);
            this.classificationPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DownstairIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpstairIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WalkingIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StandingIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePan;
        private System.Windows.Forms.Panel logoPan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel headerPan;
        private System.Windows.Forms.Button Databoard;
        private System.Windows.Forms.Button Connection;
        private System.Windows.Forms.Label Exit;
        private System.Windows.Forms.Panel databoardPanel;
        private System.Windows.Forms.Panel connectPanel;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label TabTitle;
        private System.Windows.Forms.Button Classification;
        private System.Windows.Forms.Panel classificationPanel;
        private System.Windows.Forms.PictureBox DownstairIcon;
        private System.Windows.Forms.PictureBox UpstairIcon;
        private System.Windows.Forms.PictureBox RunningIcon;
        private System.Windows.Forms.PictureBox WalkingIcon;
        private System.Windows.Forms.PictureBox StandingIcon;
        private System.Windows.Forms.Label PredictionScore;
        private System.Windows.Forms.Label Target;
        private System.Windows.Forms.TextBox StatusList;
        private System.Windows.Forms.Label Minimize;
        private System.Windows.Forms.Label Maximized;
    }
}

