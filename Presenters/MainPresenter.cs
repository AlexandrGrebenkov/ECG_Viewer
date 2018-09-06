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

        public MainPresenter(ISerial serial, IMainView view, IFileWorker fileWorker)
        {
            Serial = serial;
            View = view;
            FileWorker = fileWorker;

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

            View.Clear += () =>
            {
                View.ClearDataPoints();
            };

            View.LoadRecord += () =>
            {

            };

            View.SaveRecord += () =>
            {

            };
        }

        public void Run()
        {
            View.Show();
        }
    }
}
