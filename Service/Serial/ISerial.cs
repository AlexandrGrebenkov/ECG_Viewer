using System;
using System.Collections.Generic;

namespace ECG_Viewer.Service.Serial
{
    public interface ISerial
    {
        bool IsConnected { get; }
        IEnumerable<string> AvailablePorts { get; }

        void Connect(string portName, int baudRate, Action<string> ErrorHandler = null);
        void Disconnect(Action<string> ErrorHandler = null);

        event Action<bool> ConnectionChanged;
    }
}
