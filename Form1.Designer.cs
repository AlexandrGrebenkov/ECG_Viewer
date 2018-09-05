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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MinYTextBox = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.MaxYTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearScreenButton = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.RefreshPortsButton = new System.Windows.Forms.Button();
            this.OpenCloseConnectionButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ConnectionSpeedSelectTextBox = new System.Windows.Forms.TextBox();
            this.SelectPortCBox = new System.Windows.Forms.ComboBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.K_Ch1_TextBox = new System.Windows.Forms.TextBox();
            this.K_Ch2_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FiltrCheckBox = new System.Windows.Forms.CheckBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Ch1EnCB = new System.Windows.Forms.CheckBox();
            this.Ch2EnCB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScaleFromCh1CB = new System.Windows.Forms.CheckBox();
            this.ScaleFromCh2CB = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Filtr30HzEn = new System.Windows.Forms.CheckBox();
            this.Filtr50HzEn = new System.Windows.Forms.CheckBox();
            this.Filtr80HzEn = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AFiltr50Hz = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MinYTextBox
            // 
            this.MinYTextBox.Location = new System.Drawing.Point(11, 185);
            this.MinYTextBox.Name = "MinYTextBox";
            this.MinYTextBox.Size = new System.Drawing.Size(82, 20);
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
            this.MaxYTextBox.Location = new System.Drawing.Point(10, 155);
            this.MaxYTextBox.Name = "MaxYTextBox";
            this.MaxYTextBox.Size = new System.Drawing.Size(83, 20);
            this.MaxYTextBox.TabIndex = 274;
            this.MaxYTextBox.Text = "240.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 270;
            this.label1.Text = "Debug";
            // 
            // ClearScreenButton
            // 
            this.ClearScreenButton.Location = new System.Drawing.Point(13, 534);
            this.ClearScreenButton.Name = "ClearScreenButton";
            this.ClearScreenButton.Size = new System.Drawing.Size(113, 25);
            this.ClearScreenButton.TabIndex = 269;
            this.ClearScreenButton.Text = "Clear";
            this.ClearScreenButton.UseVisualStyleBackColor = true;
            this.ClearScreenButton.Click += new System.EventHandler(this.ClearScreenButton_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 100000;
            this.serialPort1.PortName = "COM6";
            this.serialPort1.ReadBufferSize = 2048;
            // 
            // RefreshPortsButton
            // 
            this.RefreshPortsButton.Location = new System.Drawing.Point(12, 72);
            this.RefreshPortsButton.Name = "RefreshPortsButton";
            this.RefreshPortsButton.Size = new System.Drawing.Size(121, 23);
            this.RefreshPortsButton.TabIndex = 266;
            this.RefreshPortsButton.Text = "Refresh";
            this.RefreshPortsButton.UseVisualStyleBackColor = true;
            this.RefreshPortsButton.Click += new System.EventHandler(this.RefreshPortsButton_Click);
            // 
            // OpenCloseConnectionButton
            // 
            this.OpenCloseConnectionButton.Location = new System.Drawing.Point(12, 101);
            this.OpenCloseConnectionButton.Name = "OpenCloseConnectionButton";
            this.OpenCloseConnectionButton.Size = new System.Drawing.Size(121, 25);
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
            this.ConnectionSpeedSelectTextBox.Location = new System.Drawing.Point(13, 46);
            this.ConnectionSpeedSelectTextBox.Name = "ConnectionSpeedSelectTextBox";
            this.ConnectionSpeedSelectTextBox.Size = new System.Drawing.Size(121, 20);
            this.ConnectionSpeedSelectTextBox.TabIndex = 264;
            this.ConnectionSpeedSelectTextBox.Text = "100000";
            this.ConnectionSpeedSelectTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConnectionSpeedSelectTextBox_KeyPress_1);
            // 
            // SelectPortCBox
            // 
            this.SelectPortCBox.FormattingEnabled = true;
            this.SelectPortCBox.Location = new System.Drawing.Point(13, 19);
            this.SelectPortCBox.Name = "SelectPortCBox";
            this.SelectPortCBox.Size = new System.Drawing.Size(121, 21);
            this.SelectPortCBox.TabIndex = 263;
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExitButton.Location = new System.Drawing.Point(13, 565);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 30);
            this.ExitButton.TabIndex = 268;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(13, 504);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(113, 25);
            this.SaveButton.TabIndex = 277;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 279;
            this.label4.Text = "K_Ch1";
            // 
            // K_Ch1_TextBox
            // 
            this.K_Ch1_TextBox.Location = new System.Drawing.Point(48, 393);
            this.K_Ch1_TextBox.Name = "K_Ch1_TextBox";
            this.K_Ch1_TextBox.Size = new System.Drawing.Size(56, 20);
            this.K_Ch1_TextBox.TabIndex = 280;
            this.K_Ch1_TextBox.Text = "1371.4285714285714285714285714286";
            // 
            // K_Ch2_TextBox
            // 
            this.K_Ch2_TextBox.Location = new System.Drawing.Point(48, 433);
            this.K_Ch2_TextBox.Name = "K_Ch2_TextBox";
            this.K_Ch2_TextBox.Size = new System.Drawing.Size(56, 20);
            this.K_Ch2_TextBox.TabIndex = 282;
            this.K_Ch2_TextBox.Text = "1371.4285714285714285714285714286";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 281;
            this.label5.Text = "K_Ch2";
            // 
            // FiltrCheckBox
            // 
            this.FiltrCheckBox.AutoSize = true;
            this.FiltrCheckBox.Enabled = false;
            this.FiltrCheckBox.Location = new System.Drawing.Point(27, 472);
            this.FiltrCheckBox.Name = "FiltrCheckBox";
            this.FiltrCheckBox.Size = new System.Drawing.Size(102, 17);
            this.FiltrCheckBox.TabIndex = 283;
            this.FiltrCheckBox.Text = "Подавить 50Гц";
            this.FiltrCheckBox.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea7.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea7.AxisX.MajorGrid.Interval = 1D;
            chartArea7.AxisX.MajorTickMark.Interval = 1D;
            chartArea7.AxisX.Maximum = 5D;
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisX.MinorGrid.Enabled = true;
            chartArea7.AxisY.MinorGrid.Enabled = true;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(140, 15);
            this.chart1.Name = "chart1";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Legend = "Legend1";
            series13.Name = "Ch1";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series14.Legend = "Legend1";
            series14.Name = "Ch2";
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 284;
            this.chart1.Text = "chart1";
            // 
            // Ch1EnCB
            // 
            this.Ch1EnCB.AutoSize = true;
            this.Ch1EnCB.Checked = true;
            this.Ch1EnCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Ch1EnCB.Location = new System.Drawing.Point(27, 396);
            this.Ch1EnCB.Name = "Ch1EnCB";
            this.Ch1EnCB.Size = new System.Drawing.Size(15, 14);
            this.Ch1EnCB.TabIndex = 285;
            this.Ch1EnCB.UseVisualStyleBackColor = true;
            // 
            // Ch2EnCB
            // 
            this.Ch2EnCB.AutoSize = true;
            this.Ch2EnCB.Location = new System.Drawing.Point(27, 436);
            this.Ch2EnCB.Name = "Ch2EnCB";
            this.Ch2EnCB.Size = new System.Drawing.Size(15, 14);
            this.Ch2EnCB.TabIndex = 285;
            this.Ch2EnCB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 286;
            this.label2.Text = "Масштаб по:";
            // 
            // ScaleFromCh1CB
            // 
            this.ScaleFromCh1CB.AutoSize = true;
            this.ScaleFromCh1CB.Checked = true;
            this.ScaleFromCh1CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ScaleFromCh1CB.Location = new System.Drawing.Point(15, 31);
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
            this.ScaleFromCh2CB.Location = new System.Drawing.Point(71, 31);
            this.ScaleFromCh2CB.Name = "ScaleFromCh2CB";
            this.ScaleFromCh2CB.Size = new System.Drawing.Size(45, 17);
            this.ScaleFromCh2CB.TabIndex = 287;
            this.ScaleFromCh2CB.Text = "Ch2";
            this.ScaleFromCh2CB.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ScaleFromCh2CB);
            this.panel1.Controls.Add(this.ScaleFromCh1CB);
            this.panel1.Location = new System.Drawing.Point(10, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 59);
            this.panel1.TabIndex = 288;
            // 
            // Filtr30HzEn
            // 
            this.Filtr30HzEn.AutoSize = true;
            this.Filtr30HzEn.Checked = true;
            this.Filtr30HzEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Filtr30HzEn.Location = new System.Drawing.Point(12, 235);
            this.Filtr30HzEn.Name = "Filtr30HzEn";
            this.Filtr30HzEn.Size = new System.Drawing.Size(15, 14);
            this.Filtr30HzEn.TabIndex = 289;
            this.Filtr30HzEn.UseVisualStyleBackColor = true;
            // 
            // Filtr50HzEn
            // 
            this.Filtr50HzEn.AutoSize = true;
            this.Filtr50HzEn.Checked = true;
            this.Filtr50HzEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Filtr50HzEn.Location = new System.Drawing.Point(50, 235);
            this.Filtr50HzEn.Name = "Filtr50HzEn";
            this.Filtr50HzEn.Size = new System.Drawing.Size(15, 14);
            this.Filtr50HzEn.TabIndex = 289;
            this.Filtr50HzEn.UseVisualStyleBackColor = true;
            // 
            // Filtr80HzEn
            // 
            this.Filtr80HzEn.AutoSize = true;
            this.Filtr80HzEn.Checked = true;
            this.Filtr80HzEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Filtr80HzEn.Location = new System.Drawing.Point(87, 235);
            this.Filtr80HzEn.Name = "Filtr80HzEn";
            this.Filtr80HzEn.Size = new System.Drawing.Size(15, 14);
            this.Filtr80HzEn.TabIndex = 289;
            this.Filtr80HzEn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 290;
            this.label3.Text = "30Hz";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 290;
            this.label6.Text = "50Hz";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(79, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 290;
            this.label7.Text = "80Hz";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 291;
            this.label8.Text = "Ymax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 291;
            this.label9.Text = "Ymin";
            // 
            // AFiltr50Hz
            // 
            this.AFiltr50Hz.AutoSize = true;
            this.AFiltr50Hz.Location = new System.Drawing.Point(10, 280);
            this.AFiltr50Hz.Name = "AFiltr50Hz";
            this.AFiltr50Hz.Size = new System.Drawing.Size(15, 14);
            this.AFiltr50Hz.TabIndex = 292;
            this.AFiltr50Hz.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 277);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 21);
            this.comboBox1.TabIndex = 293;
            this.comboBox1.Text = "Off";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 294;
            this.label10.Text = "Усреднение";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AFiltr50Hz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Filtr80HzEn);
            this.Controls.Add(this.Filtr50HzEn);
            this.Controls.Add(this.Filtr30HzEn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Ch2EnCB);
            this.Controls.Add(this.Ch1EnCB);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.FiltrCheckBox);
            this.Controls.Add(this.K_Ch2_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.K_Ch1_TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.MinYTextBox);
            this.Controls.Add(this.MaxYTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearScreenButton);
            this.Controls.Add(this.RefreshPortsButton);
            this.Controls.Add(this.OpenCloseConnectionButton);
            this.Controls.Add(this.ConnectionSpeedSelectTextBox);
            this.Controls.Add(this.SelectPortCBox);
            this.Controls.Add(this.ExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECG_Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MinYTextBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox MaxYTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearScreenButton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button RefreshPortsButton;
        private System.Windows.Forms.Button OpenCloseConnectionButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox ConnectionSpeedSelectTextBox;
        private System.Windows.Forms.ComboBox SelectPortCBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox K_Ch1_TextBox;
        private System.Windows.Forms.TextBox K_Ch2_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox FiltrCheckBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox Ch1EnCB;
        private System.Windows.Forms.CheckBox Ch2EnCB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ScaleFromCh1CB;
        private System.Windows.Forms.CheckBox ScaleFromCh2CB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox Filtr30HzEn;
        private System.Windows.Forms.CheckBox Filtr50HzEn;
        private System.Windows.Forms.CheckBox Filtr80HzEn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox AFiltr50Hz;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;

    }
}

