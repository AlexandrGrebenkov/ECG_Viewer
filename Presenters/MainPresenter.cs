using ECG_Viewer.Models;
using ECG_Viewer.Service;
using ECG_Viewer.Service.Serial;
using ECG_Viewer.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ECG_Viewer.Presenters
{
    public class MainPresenter
    {
        ISerial Serial;
        IMainView View;
        IFileWorker FileWorker;
        Requests Requests;

        Record Record;

        /// <summary>Время обновления данных, в секундах</summary>
        double TimeStep = 0.050;
        /// <summary>Частота дискретизации, в Гц</summary>
        int Fd = 800;

        const int ADCmax = 0xB96400;//0xC35000;//

        public MainPresenter(ISerial serial, IMainView view, IFileWorker fileWorker)
        {
            Serial = serial;
            View = view;
            FileWorker = fileWorker;

            Requests = new Requests(Serial);
            Record = new Record();

            var Ch1Packs = new List<double>();
            var Ch2Packs = new List<double>();
            object SyncObj = new object();

            Stopwatch stopwatch = new Stopwatch();
            Requests.MeasureDataHandler += data =>
            {
                stopwatch.Stop();
                var delta = stopwatch.ElapsedMilliseconds; // Время между посылками
                lock (SyncObj)
                {
                    Ch1Packs.Add(((data[0] - ADCmax / 2) * View.K_Ch1) / ADCmax);
                    Ch2Packs.Add(((data[1] - ADCmax / 2) * View.K_Ch2) / ADCmax);
                }
                stopwatch.Restart();
            };

            #region Serial Port
            int counter = 0;
            var timer = new Timer();
            timer.Interval = (int)(TimeStep * 1000);
            timer.Tick += (sender, args) =>
            {
                lock (SyncObj)
                {
                    int d;
                    if (!Serial.IsConnected)
                    {
                        Ch1Packs.Clear();
                        Ch2Packs.Clear();
                        d = (int)(TimeStep * Fd);
                        for (int i = 0; i < d; i++)
                        {
                            counter++;
                            Ch1Packs.Add(Math.Sin(counter * 4 * Math.PI / Record.Ch1.Length));
                            Ch2Packs.Add(Math.Cos(counter * 4 * Math.PI / Record.Ch1.Length));
                        }
                    }
                    else
                        d = Ch1Packs.Count;

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
                    Ch1Packs.Clear();
                    Ch2Packs.Clear();
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
                Requests.StartMeasure();
                timer.Start();
            };

            View.StopRecord += () =>
            {
                Requests.StopMeasure();
                timer.Stop();
            };
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
