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

        /// <summary>Время обновления данных, в секундах</summary>
        double TimeStep = 0.050;
        /// <summary>Частота дискретизации, в Гц</summary>
        int Fd = 800;

        public MainPresenter(ISerial serial, IMainView view, IFileWorker fileWorker)
        {
            Serial = serial;
            View = view;
            FileWorker = fileWorker;

            Record = new Record();

            #region Serial Port
            int counter = 0;
            var timer = new Timer();
            timer.Interval = (int)(TimeStep*1000);
            timer.Tick += (sender, args) =>
            {
                var Ch1Packs = new List<double>();
                var Ch2Packs = new List<double>();
                int d = (int)(TimeStep * Fd);
                for (int i = 0; i < d; i++)
                {
                    counter++;
                    Ch1Packs.Add(Math.Sin(counter * 4 * Math.PI / Record.Ch1.Length));
                    Ch2Packs.Add(Math.Cos(counter * 4 * Math.PI / Record.Ch1.Length));
                }
                for (int i = 0; i < Record.Ch1.Length - d; i++)
                {
                    Record.Ch1[i] = Record.Ch1[i + d];
                    Record.Ch2[i] = Record.Ch2[i + d];
                }
                for (int i = 0; i < d; i++)
                {
                    Record.Ch1[Record.Ch1.Length - d + i] = Ch1Packs[i];
                    Record.Ch2[Record.Ch1.Length - d + i] = Ch2Packs[i];
                }

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
            #endregion

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
                Record.Ch1 = new double[(int)(T * Fd)];
                Record.Ch2 = new double[(int)(T * Fd)];
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
