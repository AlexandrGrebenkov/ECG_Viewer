using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ECG_Viewer.Service;
using ECG_Viewer.Models;
using ECG_Viewer.Service.Serial;
using ECG_Viewer.Views;

namespace ECG_Viewer
{
    public partial class Form1 : Form, IMainView
    {
        ISerial Serial = new Serial();
        int point_counter = 0;
        int pps_cnt = 0;

        List<double> data_Ch1 = new List<double>();
        List<double> data_Ch2 = new List<double>();

        List<double> SmoothDataCh1 = new List<double>();
        List<double> SmoothDataCh2 = new List<double>();

        Filtr FiltrCh1_30Hz = new Filtr(Filtr.FILTR_30_HZ);
        Filtr FiltrCh2_30Hz = new Filtr(Filtr.FILTR_30_HZ);

        Filtr FiltrCh1_50Hz = new Filtr(Filtr.FILTR_50_HZ);
        Filtr FiltrCh2_50Hz = new Filtr(Filtr.FILTR_50_HZ);

        Filtr FiltrCh1_80Hz = new Filtr(Filtr.FILTR_80_HZ);
        Filtr FiltrCh2_80Hz = new Filtr(Filtr.FILTR_80_HZ);

        Filtr FiltrCh1_100_150Hz = new Filtr(Filtr.FILTR_100_150_HZ);
        Filtr FiltrCh2_100_150Hz = new Filtr(Filtr.FILTR_100_150_HZ);

        Filtr FiltrCh1_Over_100Hz = new Filtr(Filtr.FILTR_Over100HZ);
        Filtr FiltrCh2_Over_100Hz = new Filtr(Filtr.FILTR_Over100HZ);

        iir AFiltrCh1_50_Hz = new iir();
        iir AFiltrCh2_50_Hz = new iir();

        double t_double = new double();

        const int ADCmax = 0xB96400;//0xC35000;//

        /// <summary>Состояние последовательного порта</summary>
        public bool IsConnected
        {
            set
            {
                if (value)
                {
                    OpenCloseConnectionButton.Text = "Закрыть";
                    ConnectionSpeedSelectTextBox.Enabled =
                    SelectPortCBox.Enabled =
                    RefreshPortsButton.Enabled = false;
                }
                else
                {
                    OpenCloseConnectionButton.Text = "Открыть";
                    ConnectionSpeedSelectTextBox.Enabled =
                    SelectPortCBox.Enabled =
                    RefreshPortsButton.Enabled = true;
                }
            }
        }

        /// <summary>Выбранный COM-порт</summary>
        public string ComPort => SelectPortCBox.Text;
        /// <summary>Скорость обмена по COM-Порту</summary>
        public int BaudRate => Int32.Parse(ConnectionSpeedSelectTextBox.Text);
        /// <summary>Доступные COM-Порты</summary>
        public IEnumerable<string> AvailablePorts
        {
            get => (IEnumerable<string>)SelectPortCBox.DataSource;
            set => SelectPortCBox.DataSource = value;
        }

        public Form1()
        {
            InitializeComponent();

            Serial.ConnectionChanged += state => IsConnected = state;
            AvailablePorts = Serial.AvailablePorts;
            comboBox1.Items.AddRange(new object[] { "Off", "x2", "x4", "x6", "x8" });
            comboBox1.SelectedIndex = 0;

            timer1.Start();
            timer2.Start();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Serial.Disconnect();
            this.Close();
        }

        #region Serial Port

        private void RefreshPortsButton_Click(object sender, EventArgs e)
        {
            AvailablePorts = Serial.AvailablePorts;
        }

        /// <summary>Открыть/Закрыть порт</summary>
        private void OpenCloseConnectionButton_Click(object sender, EventArgs e)
        {
            if (!Serial.IsConnected)
            {// Открытие порта
                Serial.Connect(ComPort, BaudRate,
                    error => MessageBox.Show(this, error, "Ошибка открытия порта",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
            else
            {// Закрытие порта
                Serial.Disconnect(
                    error => MessageBox.Show(this, error, "Ошибка закрытия порта",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error));
            }
        }

        private void ConnectionSpeedSelectTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char tmp = e.KeyChar;

            if ((!Char.IsDigit(tmp)) && (!Char.IsControl(tmp)))
            {
                e.KeyChar = '\0';
            }
        }
        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Serial.IsConnected)
            {
                if (!Serial.HasNewData) return;

                byte[] rx_buff = Serial.ReadData();

                List<int> indexes = new List<int>();

                for (int i = 2; i < (rx_buff.Length - 8); i++)
                {
                    if ((rx_buff[i - 2] == 0xAA) && (rx_buff[i - 1] == 0xAB) && (rx_buff[i] == 0xAC) && (rx_buff[i + 5] == 0x55) && (rx_buff[i + 6] == 0x55))
                        indexes.Add(i + 1);
                }

                if (t_double > 5.0d)
                {
                    if (ScaleFromCh1CB.Checked || ScaleFromCh2CB.Checked)
                    {
                        double chart_max = new double();
                        double chart_min = new double();
                        if ((ScaleFromCh1CB.Checked) && (!ScaleFromCh2CB.Checked))
                        {
                            double delta = (data_Ch1.Max() - data_Ch1.Min()) / 2;
                            double MeanLevel = data_Ch1.Min() + delta;
                            chart_max = MeanLevel + delta * 1.5;
                            chart_min = MeanLevel - delta * 1.5;
                        }
                        else if ((!ScaleFromCh1CB.Checked) && (ScaleFromCh2CB.Checked))
                        {
                            double delta = (data_Ch2.Max() - data_Ch2.Min()) / 2;
                            double MeanLevel = data_Ch2.Min() + delta;
                            chart_max = MeanLevel + delta * 1.5;
                            chart_min = MeanLevel - delta * 1.5;
                        }
                        else if (ScaleFromCh1CB.Checked && ScaleFromCh2CB.Checked)
                        {
                            //chart_max = data_Ch1.Max() >= data_Ch2.Max() ? data_Ch1.Max() : data_Ch2.Max();
                            //chart_min = data_Ch1.Min() <= data_Ch2.Min() ? data_Ch1.Min() : data_Ch2.Min();
                            //double delta = (chart_max - chart_min) / 2;
                            //double MeanLevel = chart_min + delta;
                            //chart_max = MeanLevel + 1.5 * delta;
                            //chart_min = MeanLevel + 1.5 * delta;
                            chart1.ChartAreas[0].AxisY.Maximum = double.NaN;//data_Ch1.Max();//
                            chart1.ChartAreas[0].AxisY.Minimum = double.NaN;//data_Ch1.Min();//
                        }

                        if (chart_max != chart_min)
                        {
                            chart1.ChartAreas[0].AxisY.Maximum = chart_max;//data_Ch1.Max();//
                            chart1.ChartAreas[0].AxisY.Minimum = chart_min;//data_Ch1.Min();//
                        }
                    }
                    else
                    {
                        //chart1.ChartAreas[0].AxisY.Maximum = 1;
                        //chart1.ChartAreas[0].AxisY.Minimum = -1;
                        try
                        {
                            double tmp = double.Parse(MaxYTextBox.Text);
                            chart1.ChartAreas[0].AxisY.Maximum = tmp;
                        }
                        catch
                        {
                            MaxYTextBox.Text = "240.0";
                            chart1.ChartAreas[0].AxisY.Maximum = 1;
                        }
                        try
                        {
                            double tmp = double.Parse(MinYTextBox.Text);
                            chart1.ChartAreas[0].AxisY.Minimum = tmp;
                        }
                        catch
                        {
                            MinYTextBox.Text = "-240.0";
                            chart1.ChartAreas[0].AxisY.Minimum = -1;
                        }
                    }
                    data_Ch1.Clear();
                    data_Ch2.Clear();
                    SmoothDataCh1.Clear();
                    SmoothDataCh2.Clear();
                    (chart1.Series[0]).Points.Clear();
                    (chart1.Series[1]).Points.Clear();
                    t_double = 0;
                }

                foreach (int index in indexes)
                {
                    Int64 yCh1_int = (rx_buff[index + 1] << 16) + (rx_buff[index] << 8);
                    Int64 yCh2_int = (rx_buff[index + 3] << 16) + (rx_buff[index + 2] << 8);

                    double yCh1 = (double)(yCh1_int - ADCmax / 2) / (double)ADCmax;
                    double yCh2 = (double)(yCh2_int - ADCmax / 2) / (double)ADCmax;

                    //if (FiltrCheckBox.Checked)
                    //{
                    //    //yCh1 = HiPassCh1.Calc(yCh1);
                    //    yCh1 = FiltrCh1.Calc(yCh1);
                    //    //if (FiltrCheckBox.Checked)
                    //    //yCh2 = HiPassCh2.Calc(yCh2);
                    //    yCh2 = FiltrCh2.Calc(yCh2);
                    //}
                    if (Filtr30HzEn.Checked)
                    {
                        yCh1 = FiltrCh1_30Hz.Calc(yCh1);
                        yCh2 = FiltrCh2_30Hz.Calc(yCh2);
                    }
                    if (Filtr50HzEn.Checked)
                    {
                        yCh1 = FiltrCh1_50Hz.Calc(yCh1);
                        yCh2 = FiltrCh2_50Hz.Calc(yCh2);
                    }
                    if (Filtr80HzEn.Checked)
                    {
                        yCh1 = FiltrCh1_80Hz.Calc(yCh1);
                        yCh2 = FiltrCh2_80Hz.Calc(yCh2);
                    }
                    if (AFiltr50Hz.Checked)
                    {
                        yCh1 = AFiltrCh1_50_Hz.Calc(yCh1);
                        yCh2 = AFiltrCh2_50_Hz.Calc(yCh2);
                    }
                    yCh1 *= K_Ch1;
                    yCh2 *= K_Ch2;

                    data_Ch1.Add(yCh1);
                    data_Ch2.Add(yCh2);

                    if ((comboBox1.SelectedIndex != 0) && (data_Ch1.Count >= comboBox1.SelectedIndex * 2))
                    {
                        switch (comboBox1.SelectedIndex)
                        {
                            case 1:
                            SmoothDataCh1.Add((data_Ch1[data_Ch1.Count - 1] + data_Ch1[data_Ch1.Count - 2]) / 2);
                            break;
                            case 2:
                            SmoothDataCh1.Add((data_Ch1[data_Ch1.Count - 1] + data_Ch1[data_Ch1.Count - 2] + data_Ch1[data_Ch1.Count - 3] + data_Ch1[data_Ch1.Count - 4]) / 4);
                            break;
                            case 3:
                            SmoothDataCh1.Add((data_Ch1[data_Ch1.Count - 1] + data_Ch1[data_Ch1.Count - 2] + data_Ch1[data_Ch1.Count - 3] + data_Ch1[data_Ch1.Count - 4] + data_Ch1[data_Ch1.Count - 5] + data_Ch1[data_Ch1.Count - 6]) / 6);
                            break;
                            case 4:
                            SmoothDataCh1.Add((data_Ch1[data_Ch1.Count - 1] + data_Ch1[data_Ch1.Count - 2] + data_Ch1[data_Ch1.Count - 3] + data_Ch1[data_Ch1.Count - 4] + data_Ch1[data_Ch1.Count - 5] + data_Ch1[data_Ch1.Count - 6] + data_Ch1[data_Ch1.Count - 7] + data_Ch1[data_Ch1.Count - 8]) / 8);
                            break;
                            default:
                            break;

                        }
                    }

                    if (Ch1EnCB.Checked)
                        if (comboBox1.SelectedIndex == 0)
                            chart1.Series[0].Points.AddXY(t_double, yCh1);
                        else if (SmoothDataCh1.Count != 0)
                            chart1.Series[0].Points.AddXY(t_double, SmoothDataCh1.Last());

                    if (Ch2EnCB.Checked)
                        chart1.Series[1].Points.AddXY(t_double, yCh2);

                    t_double += 0.0025d;
                }

                pps_cnt++;
            }

        }

        private void ClearScreenButton_Click(object sender, EventArgs e)
        {
            data_Ch1.Clear();
            data_Ch2.Clear();
            (chart1.Series[0]).Points.Clear();
            (chart1.Series[1]).Points.Clear();
            t_double = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //ppsTextBox.Text = pps_cnt.ToString();
            pps_cnt = 0;
        }

        public double K_Ch1
        {
            get
            {

                double tmp = new double();
                try
                {
                    tmp = double.Parse(K_Ch1_TextBox.Text);
                    return tmp;
                }
                catch
                {
                    K_Ch1_TextBox.Text = "1371.4285714285714285714285714286";
                    return 1.0d;
                }
            }
        }

        public double K_Ch2
        {
            get
            {
                double tmp = new double();
                try
                {
                    tmp = double.Parse(K_Ch2_TextBox.Text);
                    return tmp;
                }
                catch
                {
                    K_Ch2_TextBox.Text = "1371.4285714285714285714285714286";
                    return 1.0d;
                }
            }
        }

        #region Работа с файлами
        /// <summary>Кнопка открытия файла</summary>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            var FileWorker = new FileWorker();

            var record = FileWorker.LoadRecord(
                error => MessageBox.Show(this, error, "Ошибка открытия файла",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error));

            if (record == null) return;

            data_Ch1 = record.Ch1; //Данные прочитали, но график сейчас не обновится
            data_Ch2 = record.Ch2;
        }

        /// <summary>Кнопка сохранения файла</summary>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var FileWorker = new FileWorker();

            var record = new Record() { Ch1 = data_Ch1, Ch2 = data_Ch2 };

            FileWorker.SaveSeries(record,
                error => MessageBox.Show(this, error, "Ошибка сохранения файла",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error));
        }
        #endregion

        public new void Show()
        {
            Application.Run(this);
        }
    }
}
