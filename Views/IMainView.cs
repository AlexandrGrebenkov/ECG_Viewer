using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG_Viewer.Views
{
    public interface IMainView : IView
    {
        /// <summary>Отображение состояния подключения</summary>
        bool IsConnected { set; }
        /// <summary>Выбранный порт</summary>
        string ComPort { get; }
        /// <summary></summary>
        int BaudRate { get; }
        /// <summary></summary>
        IEnumerable<string> AvailablePorts { get; set; }

        /// <summary></summary>
        event Action Exit;
        /// <summary></summary>
        event Action SaveRecord;
        /// <summary></summary>
        event Action LoadRecord;
        /// <summary></summary>
        event Action Clear;

        /// <summary></summary>
        event Action ConnectToDevice;
        /// <summary></summary>
        event Action RefreshPorts;

        /// <summary></summary>
        void AddNewDataPoints(double ch1, double ch2, double t);
        /// <summary></summary>
        void ClearDataPoints();
    }
}
