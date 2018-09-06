using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace ECG_Viewer.Service.Serial
{
    public class Serial : ISerial
    {
        SerialPort Port = new SerialPort();

        public bool IsConnected => Port.IsOpen;

        public IEnumerable<string> AvailablePorts => SerialPort.GetPortNames();

        public void Connect(string portName, int baudRate, Action<string> ErrorHandler = null)
        {
            Port.PortName = portName;
            Port.BaudRate = baudRate;
            try
            {
                Port.Open();
            }
            catch (UnauthorizedAccessException error)
            {
                ErrorHandler?.Invoke("Выбранный порт занят другим приложением");
            }
            catch (Exception error)
            {
                ErrorHandler?.Invoke(error.Message);
            }
        }

        public void Disconnect(Action<string> ErrorHandler = null)
        {
            try
            {
                Port.Close();
            }
            catch (Exception error)
            {
                ErrorHandler?.Invoke(error.Message);
            }
        }
    }
}
