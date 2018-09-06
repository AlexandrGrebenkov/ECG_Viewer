using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG_Viewer.Views
{
    public interface IMainView : IView
    {
        bool IsConnected { set; }
        string ComPort { get; }
        int BaudRate { get; }
        IEnumerable<string> AvailablePorts { get; set; }

        event Action Exit;
        event Action SaveRecord;
        event Action LoadRecord;
        event Action Clear;

        event Action ConnectToDevice;
        event Action RefreshPorts;
    }
}
