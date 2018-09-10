using ECG_Viewer.Models;
using ECG_Viewer.Service;
using ECG_Viewer.Service.Serial;
using ECG_Viewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ECG_Viewer.Presenters
{
    public class MainPresenter
    {
        ISerial Serial;
        IMainView View;
        IFileWorker FileWorker;

        Record Record;

        /// <summary>Время дискретизации в секундах</summary>
        double TimeStep = 0.050;

        public MainPresenter(ISerial serial, IMainView view, IFileWorker fileWorker)
        {
            Serial = serial;
            View = view;
            FileWorker = fileWorker;

            Record = new Record();

            int counter = 0;
            var timer = new Timer();
            timer.Interval = (int)(TimeStep*1000);
            timer.Tick += (sender, args) =>
            {
                counter++;
                for (int i = 0; i < Record.Ch1.Length - 1; i++)
                {
                    Record.Ch1[i] = Record.Ch1[i + 1];
                    Record.Ch2[i] = Record.Ch2[i + 1];
                }
                Record.Ch1[Record.Ch1.Length - 1] = Math.Sin(counter * 4 * Math.PI / Record.Ch1.Length);
                Record.Ch2[Record.Ch1.Length - 1] = Math.Cos(counter * 4 * Math.PI / Record.Ch1.Length);
                View.UpdateChart(Record);
            };
            

            View.AvailablePorts = Serial.AvailablePorts;
            View.RefreshPorts += () => View.AvailablePorts = Serial.AvailablePorts;

            View.ConnectToDevice += () =>
            {
                if (!Serial.IsConnected)
                {// Открытие порта
                    Serial.Connect(View.ComPort, View.BaudRate,
                        error => View.ErrorHandler("Ошибка открытия порта", error));
                }
                else
                {// Закрытие порта
                    Serial.Disconnect(
                        error => View.ErrorHandler("Ошибка закрытия порта", error));
                }
            };
            Serial.ConnectionChanged += state => View.IsConnected = state;

            View.Exit += () =>
            {
                Serial.Disconnect(error => View.ErrorHandler("Ошибка закрытия порта", error));
                View.Close();
            };

            View.LoadRecord += () =>
            {
                var record = FileWorker.LoadRecord(
                    error => View.ErrorHandler("Ошибка открытия файла", error));
                if (record == null) return;
                Record = record;
                View.UpdateChart(Record);
            };

            View.SaveRecord += () =>
            {
                FileWorker.SaveSeries(Record,
                    error => View.ErrorHandler("Ошибка сохранения файла", error));
            };

            View.StartRecord += () =>
            {
                var T = View.RecordDuration;
                Record.Ch1 = new double[(int)(T / TimeStep)];
                Record.Ch2 = new double[(int)(T / TimeStep)];
                Serial.FlushRxBuffer();
                timer.Start();
            };

            View.StopRecord += () => timer.Stop();
        }

        /// <summary>
        /// Метод запускает форму
        /// </summary>
        public void Run()
        {
            View.Show();
        }
    }
}
