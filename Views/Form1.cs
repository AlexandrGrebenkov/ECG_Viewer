using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using ECG_Viewer.Models;
using ECG_Viewer.Views;

namespace ECG_Viewer
{
    public partial class Form1 : Form, IMainView
    {
        public event Action Exit;
        public event Action SaveRecord;
        public event Action LoadRecord;
        public event Action Clear;
        public event Action ConnectToDevice;
        public event Action RefreshPorts;
        public event Action StartRecord;
        public event Action StopRecord;

        /// <summary>Состояние последовательного порта</summary>
        public bool IsConnected
        {
            set
            {
                if (value)
                {
                    OpenCloseConnectionButton.Text = "Disconnect";
                    ConnectionSpeedSelectTextBox.Enabled =
                    SelectPortCBox.Enabled =
                    RefreshPortsButton.Enabled = false;
                }
                else
                {
                    OpenCloseConnectionButton.Text = "Connect";
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

            comboBox1.Items.AddRange(new object[] { "Off", "x2", "x4", "x6", "x8" });
            comboBox1.SelectedIndex = 0;
        }

        private void ExitButton_Click(object sender, EventArgs e) => Exit?.Invoke();

        #region Serial Port

        private void RefreshPortsButton_Click(object sender, EventArgs e) => RefreshPorts?.Invoke();

        /// <summary>Открыть/Закрыть порт</summary>
        private void OpenCloseConnectionButton_Click(object sender, EventArgs e) => ConnectToDevice?.Invoke();

        private void ConnectionSpeedSelectTextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char tmp = e.KeyChar;

            if ((!Char.IsDigit(tmp)) && (!Char.IsControl(tmp)))
            {
                e.KeyChar = '\0';
            }
        }
        #endregion

        private void ClearScreenButton_Click(object sender, EventArgs e) => Clear?.Invoke();

        public double K_Ch1
        {
            get
            {
                if (double.TryParse(K_Ch1_TextBox.Text.Replace(',', '.'),
                                    NumberStyles.Any,
                                    CultureInfo.InvariantCulture,
                                    out double res))
                    return res;
                res = 1;
                K_Ch1_TextBox.Text = res.ToString();
                return res;
            }
        }

        public double K_Ch2
        {
            get
            {
                if (double.TryParse(K_Ch2_TextBox.Text.Replace(',', '.'),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out double res))
                    return res;
                res = 1;
                K_Ch2_TextBox.Text = res.ToString();
                return res;
            }
        }

        public double RecordDuration
        {
            get
            {
                if (double.TryParse(tbRecordDuration.Text.Replace(',', '.'), 
                    NumberStyles.Any, 
                    CultureInfo.InvariantCulture, 
                    out double res))
                    return res;
                res = 1;
                tbRecordDuration.Text = res.ToString("F1");
                return res;
            }
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public void ErrorHandler(string title, string message)
        {
            MessageBox.Show(this, message, title,
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void UpdateChart(Record record)
        {
            chart1.ChartAreas[0].AxisX.Maximum = record.Ch1.Length;
            chart1.Series[0].Points.DataBindY(record.Ch1);
            chart1.Series[1].Points.DataBindY(record.Ch2);
            chart1.DataBind();
        }

        private void btnStart_Click(object sender, EventArgs e) => StartRecord?.Invoke();

        private void btnStop_Click(object sender, EventArgs e) => StopRecord?.Invoke();

        #region Работа с файлами
        /// <summary>Кнопка открытия файла</summary>
        private void btnOpen_Click(object sender, EventArgs e) => LoadRecord?.Invoke();
        /// <summary>Кнопка сохранения файла</summary>
        private void btnSave_Click(object sender, EventArgs e) => SaveRecord?.Invoke();
        #endregion
    }
}
