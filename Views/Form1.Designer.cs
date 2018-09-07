namespace ECG_Viewer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MinYTextBox = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.MaxYTextBox = new System.Windows.Forms.TextBox();
            this.ClearScreenButton = new System.Windows.Forms.Button();
            this.RefreshPortsButton = new System.Windows.Forms.Button();
            this.OpenCloseConnectionButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ConnectionSpeedSelectTextBox = new System.Windows.Forms.TextBox();
            this.SelectPortCBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.K_Ch1_TextBox = new System.Windows.Forms.TextBox();
            this.K_Ch2_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FiltrCheckBox = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Ch1EnCB = new System.Windows.Forms.CheckBox();
            this.Ch2EnCB = new System.Windows.Forms.CheckBox();
            this.ScaleFromCh1CB = new System.Windows.Forms.CheckBox();
            this.ScaleFromCh2CB = new System.Windows.Forms.CheckBox();
            this.Filtr30HzEn = new System.Windows.Forms.CheckBox();
            this.Filtr50HzEn = new System.Windows.Forms.CheckBox();
            this.Filtr80HzEn = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AFiltr50Hz = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.tbRecordDuration = new System.Windows.Forms.ToolStripTextBox();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinYTextBox
            // 
            this.MinYTextBox.Location = new System.Drawing.Point(103, 44);
            this.MinYTextBox.Name = "MinYTextBox";
            this.MinYTextBox.Size = new System.Drawing.Size(73, 20);
            this.MinYTextBox.TabIndex = 273;
            this.MinYTextBox.Text = "-240.0";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MaxYTextBox
            // 
            this.MaxYTextBox.Location = new System.Drawing.Point(103, 22);
            this.MaxYTextBox.Name = "MaxYTextBox";
            this.MaxYTextBox.Size = new System.Drawing.Size(73, 20);
            this.MaxYTextBox.TabIndex = 274;
            this.MaxYTextBox.Text = "240.0";
            // 
            // ClearScreenButton
            // 
            this.ClearScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearScreenButton.Location = new System.Drawing.Point(46, 501);
            this.ClearScreenButton.Name = "ClearScreenButton";
            this.ClearScreenButton.Size = new System.Drawing.Size(113, 25);
            this.ClearScreenButton.TabIndex = 269;
            this.ClearScreenButton.Text = "Clear";
            this.ClearScreenButton.UseVisualStyleBackColor = true;
            this.ClearScreenButton.Click += new System.EventHandler(this.ClearScreenButton_Click);
            // 
            // RefreshPortsButton
            // 
            this.RefreshPortsButton.Location = new System.Drawing.Point(6, 72);
            this.RefreshPortsButton.Name = "RefreshPortsButton";
            this.RefreshPortsButton.Size = new System.Drawing.Size(80, 23);
            this.RefreshPortsButton.TabIndex = 266;
            this.RefreshPortsButton.Text = "Refresh";
            this.RefreshPortsButton.UseVisualStyleBackColor = true;
            this.RefreshPortsButton.Click += new System.EventHandler(this.RefreshPortsButton_Click);
            // 
            // OpenCloseConnectionButton
            // 
            this.OpenCloseConnectionButton.Location = new System.Drawing.Point(99, 72);
            this.OpenCloseConnectionButton.Name = "OpenCloseConnectionButton";
            this.OpenCloseConnectionButton.Size = new System.Drawing.Size(80, 25);
            this.OpenCloseConnectionButton.TabIndex = 265;
            this.OpenCloseConnectionButton.Text = "Open";
            this.OpenCloseConnectionButton.UseVisualStyleBackColor = true;
            this.OpenCloseConnectionButton.Click += new System.EventHandler(this.OpenCloseConnectionButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ConnectionSpeedSelectTextBox
            // 
            this.ConnectionSpeedSelectTextBox.Location = new System.Drawing.Point(75, 46);
            this.ConnectionSpeedSelectTextBox.Name = "ConnectionSpeedSelectTextBox";
            this.ConnectionSpeedSelectTextBox.Size = new System.Drawing.Size(104, 20);
            this.ConnectionSpeedSelectTextBox.TabIndex = 264;
            this.ConnectionSpeedSelectTextBox.Text = "100000";
            this.ConnectionSpeedSelectTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConnectionSpeedSelectTextBox_KeyPress_1);
            // 
            // SelectPortCBox
            // 
            this.SelectPortCBox.FormattingEnabled = true;
            this.SelectPortCBox.Location = new System.Drawing.Point(75, 19);
            this.SelectPortCBox.Name = "SelectPortCBox";
            this.SelectPortCBox.Size = new System.Drawing.Size(104, 21);
            this.SelectPortCBox.TabIndex = 263;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExitButton.Location = new System.Drawing.Point(46, 530);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 25);
            this.ExitButton.TabIndex = 268;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 279;
            this.label4.Text = "K_Ch1";
            // 
            // K_Ch1_TextBox
            // 
            this.K_Ch1_TextBox.Location = new System.Drawing.Point(30, 39);
            this.K_Ch1_TextBox.Name = "K_Ch1_TextBox";
            this.K_Ch1_TextBox.Size = new System.Drawing.Size(56, 20);
            this.K_Ch1_TextBox.TabIndex = 280;
            this.K_Ch1_TextBox.Text = "1371.4285714285714285714285714286";
            // 
            // K_Ch2_TextBox
            // 
            this.K_Ch2_TextBox.Location = new System.Drawing.Point(123, 39);
            this.K_Ch2_TextBox.Name = "K_Ch2_TextBox";
            this.K_Ch2_TextBox.Size = new System.Drawing.Size(56, 20);
            this.K_Ch2_TextBox.TabIndex = 282;
            this.K_Ch2_TextBox.Text = "1371.4285714285714285714285714286";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 281;
            this.label5.Text = "K_Ch2";
            // 
            // FiltrCheckBox
            // 
            this.FiltrCheckBox.AutoSize = true;
            this.FiltrCheckBox.Enabled = false;
            this.FiltrCheckBox.Location = new System.Drawing.Point(74, 24);
            this.FiltrCheckBox.Name = "FiltrCheckBox";
            this.FiltrCheckBox.Size = new System.Drawing.Size(102, 17);
            this.FiltrCheckBox.TabIndex = 283;
            this.FiltrCheckBox.Text = "Подавить 50Гц";
            this.FiltrCheckBox.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea3.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea3.AxisX.MajorGrid.Interval = 1D;
            chartArea3.AxisX.MajorTickMark.Interval = 1D;
            chartArea3.AxisX.Maximum = 5D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.MinorGrid.Enabled = true;
            chartArea3.AxisY.MinorGrid.Enabled = true;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "Ch1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.Name = "Ch2";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(596, 575);
            this.chart1.TabIndex = 284;
            this.chart1.Text = "chart1";
            // 
            // Ch1EnCB
            // 
            this.Ch1EnCB.AutoSize = true;
            this.Ch1EnCB.Checked = true;
            this.Ch1EnCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ch1EnCB.Location = new System.Drawing.Point(9, 42);
            this.Ch1EnCB.Name = "Ch1EnCB";
            this.Ch1EnCB.Size = new System.Drawing.Size(15, 14);
            this.Ch1EnCB.TabIndex = 285;
            this.Ch1EnCB.UseVisualStyleBackColor = true;
            // 
            // Ch2EnCB
            // 
            this.Ch2EnCB.AutoSize = true;
            this.Ch2EnCB.Location = new System.Drawing.Point(102, 42);
            this.Ch2EnCB.Name = "Ch2EnCB";
            this.Ch2EnCB.Size = new System.Drawing.Size(15, 14);
            this.Ch2EnCB.TabIndex = 285;
            this.Ch2EnCB.UseVisualStyleBackColor = true;
            // 
            // ScaleFromCh1CB
            // 
            this.ScaleFromCh1CB.AutoSize = true;
            this.ScaleFromCh1CB.Checked = true;
            this.ScaleFromCh1CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ScaleFromCh1CB.Location = new System.Drawing.Point(10, 24);
            this.ScaleFromCh1CB.Name = "ScaleFromCh1CB";
            this.ScaleFromCh1CB.Size = new System.Drawing.Size(45, 17);
            this.ScaleFromCh1CB.TabIndex = 287;
            this.ScaleFromCh1CB.Text = "Ch1";
            this.ScaleFromCh1CB.UseVisualStyleBackColor = true;
            // 
            // ScaleFromCh2CB
            // 
            this.ScaleFromCh2CB.AutoSize = true;
            this.ScaleFromCh2CB.Checked = true;
            this.ScaleFromCh2CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ScaleFromCh2CB.Location = new System.Drawing.Point(10, 46);
            this.ScaleFromCh2CB.Name = "ScaleFromCh2CB";
            this.ScaleFromCh2CB.Size = new System.Drawing.Size(45, 17);
            this.ScaleFromCh2CB.TabIndex = 287;
            this.ScaleFromCh2CB.Text = "Ch2";
            this.ScaleFromCh2CB.UseVisualStyleBackColor = true;
            // 
            // Filtr30HzEn
            // 
            this.Filtr30HzEn.AutoSize = true;
            this.Filtr30HzEn.Checked = true;
            this.Filtr30HzEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Filtr30HzEn.Location = new System.Drawing.Point(6, 24);
            this.Filtr30HzEn.Name = "Filtr30HzEn";
            this.Filtr30HzEn.Size = new System.Drawing.Size(53, 17);
            this.Filtr30HzEn.TabIndex = 289;
            this.Filtr30HzEn.Text = "30 Гц";
            this.Filtr30HzEn.UseVisualStyleBackColor = true;
            // 
            // Filtr50HzEn
            // 
            this.Filtr50HzEn.AutoSize = true;
            this.Filtr50HzEn.Checked = true;
            this.Filtr50HzEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Filtr50HzEn.Location = new System.Drawing.Point(6, 46);
            this.Filtr50HzEn.Name = "Filtr50HzEn";
            this.Filtr50HzEn.Size = new System.Drawing.Size(53, 17);
            this.Filtr50HzEn.TabIndex = 289;
            this.Filtr50HzEn.Text = "50 Гц";
            this.Filtr50HzEn.UseVisualStyleBackColor = true;
            // 
            // Filtr80HzEn
            // 
            this.Filtr80HzEn.AutoSize = true;
            this.Filtr80HzEn.Checked = true;
            this.Filtr80HzEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Filtr80HzEn.Location = new System.Drawing.Point(6, 68);
            this.Filtr80HzEn.Name = "Filtr80HzEn";
            this.Filtr80HzEn.Size = new System.Drawing.Size(53, 17);
            this.Filtr80HzEn.TabIndex = 289;
            this.Filtr80HzEn.Tag = "";
            this.Filtr80HzEn.Text = "80 Гц";
            this.Filtr80HzEn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 291;
            this.label8.Text = "Ymax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(68, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 291;
            this.label9.Text = "Ymin";
            // 
            // AFiltr50Hz
            // 
            this.AFiltr50Hz.AutoSize = true;
            this.AFiltr50Hz.Location = new System.Drawing.Point(74, 46);
            this.AFiltr50Hz.Name = "AFiltr50Hz";
            this.AFiltr50Hz.Size = new System.Drawing.Size(74, 17);
            this.AFiltr50Hz.TabIndex = 292;
            this.AFiltr50Hz.Text = "AFiltr50Hz";
            this.AFiltr50Hz.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(120, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 21);
            this.comboBox1.TabIndex = 293;
            this.comboBox1.Text = "Off";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(72, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 294;
            this.label10.Text = "Усред.";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.ExitButton);
            this.splitContainer1.Panel1.Controls.Add(this.ClearScreenButton);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 575);
            this.splitContainer1.SplitterDistance = 200;
            this.splitContainer1.TabIndex = 295;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.K_Ch1_TextBox);
            this.groupBox4.Controls.Add(this.Ch1EnCB);
            this.groupBox4.Controls.Add(this.K_Ch2_TextBox);
            this.groupBox4.Controls.Add(this.Ch2EnCB);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 308);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(185, 71);
            this.groupBox4.TabIndex = 298;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Filtr30HzEn);
            this.groupBox3.Controls.Add(this.Filtr50HzEn);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Filtr80HzEn);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.FiltrCheckBox);
            this.groupBox3.Controls.Add(this.AFiltr50Hz);
            this.groupBox3.Location = new System.Drawing.Point(6, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 100);
            this.groupBox3.TabIndex = 297;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтрация";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ScaleFromCh1CB);
            this.groupBox2.Controls.Add(this.ScaleFromCh2CB);
            this.groupBox2.Controls.Add(this.MaxYTextBox);
            this.groupBox2.Controls.Add(this.MinYTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(6, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 81);
            this.groupBox2.TabIndex = 296;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Масштаб";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.SelectPortCBox);
            this.groupBox1.Controls.Add(this.OpenCloseConnectionButton);
            this.groupBox1.Controls.Add(this.RefreshPortsButton);
            this.groupBox1.Controls.Add(this.ConnectionSpeedSelectTextBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 104);
            this.groupBox1.TabIndex = 295;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 267;
            this.label12.Text = "Скорость:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 267;
            this.label11.Text = "Порт:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnSave,
            this.btnStart,
            this.btnStop,
            this.tbRecordDuration});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 296;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnStart
            // 
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(23, 22);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(23, 22);
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbRecordDuration
            // 
            this.tbRecordDuration.Name = "tbRecordDuration";
            this.tbRecordDuration.Size = new System.Drawing.Size(40, 25);
            this.tbRecordDuration.Text = "5";
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "Открыть файл";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "Сохранить файл";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECG_Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MinYTextBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox MaxYTextBox;
        private System.Windows.Forms.Button ClearScreenButton;
        private System.Windows.Forms.Button RefreshPortsButton;
        private System.Windows.Forms.Button OpenCloseConnectionButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox ConnectionSpeedSelectTextBox;
        private System.Windows.Forms.ComboBox SelectPortCBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox K_Ch1_TextBox;
        private System.Windows.Forms.TextBox K_Ch2_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox FiltrCheckBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox Ch1EnCB;
        private System.Windows.Forms.CheckBox Ch2EnCB;
        private System.Windows.Forms.CheckBox ScaleFromCh1CB;
        private System.Windows.Forms.CheckBox ScaleFromCh2CB;
        private System.Windows.Forms.CheckBox Filtr30HzEn;
        private System.Windows.Forms.CheckBox Filtr50HzEn;
        private System.Windows.Forms.CheckBox Filtr80HzEn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox AFiltr50Hz;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.ToolStripTextBox tbRecordDuration;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
    }
}

