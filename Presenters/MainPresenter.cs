using ECG_Viewer.Models;
using ECG_Viewer.Service;
using ECG_Viewer.Service.Serial;
using ECG_Viewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG_Viewer.Presenters
{
    public class MainPresenter
    {
        ISerial Serial;
        IMainView View;
        IFileWorker FileWorker;

        Record Record;

        public MainPresenter(ISerial serial, IMainView view, IFileWorker fileWorker)
        {
            Serial = serial;
            View = view;
            FileWorker = fileWorker;

            Record = new Record();
            Record.Ch1 = new double[200];
            Record.Ch2 = new double[200];

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
                Record = FileWorker.LoadRecord(
                    error => View.ErrorHandler("Ошибка открытия файла", error));
                View.UpdateChart(Record);
            };

            View.SaveRecord += () =>
            {
                FileWorker.SaveSeries(Record,
                    error => View.ErrorHandler("Ошибка сохранения файла", error));
            };
        }

        public void Run()
        {
            View.Show();
        }
    }
}
