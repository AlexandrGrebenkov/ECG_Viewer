using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace ECG_Viewer.Service.Serial
{
    /// <summary>
    /// Класс работы с последовательным портом
    /// </summary>
    public class Serial : ISerial
    {
        SerialPort Port = new SerialPort();

        public bool IsConnected => Port.IsOpen;

        public IEnumerable<string> AvailablePorts => SerialPort.GetPortNames();

        public bool HasNewData => Port.BytesToRead > 0;

        public event Action<bool> ConnectionChanged;

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
            finally
            {
                ConnectionChanged?.Invoke(IsConnected);
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
            finally
            {
                ConnectionChanged?.Invoke(IsConnected);
            }
        }

        public byte[] ReadData()
        {
            var rx_buff = Port.BytesToRead >= 9 ? new byte[Port.BytesToRead] : new byte[9];
            int i = 0;
            while (i < rx_buff.Length)//(i < 3)//
            {
                int RxByte = Port.ReadByte();
                if (RxByte >= 0)
                    rx_buff[i++] = (byte)RxByte;
                else break;
            }
            return rx_buff;
        }
    }
}
