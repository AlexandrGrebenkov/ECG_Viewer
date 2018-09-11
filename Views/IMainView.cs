using ECG_Viewer.Models;
using System;
using System.Collections.Generic;

namespace ECG_Viewer.Views
{
    /// <summary>Интерфейс отображения главного окна</summary>
    public interface IMainView : IView
    {
        /// <summary>Отображение состояния подключения</summary>
        bool IsConnected { set; }
        /// <summary>Выбранный порт</summary>
        string ComPort { get; }
        /// <summary>Скорость обмена</summary>
        int BaudRate { get; }
        /// <summary>Список доступных портов</summary>
        IEnumerable<string> AvailablePorts { get; set; }

        /// <summary>Выход из приложения</summary>
        event Action Exit;
        /// <summary>Сохранить запись</summary>
        event Action SaveRecord;
        /// <summary>Открыть запись</summary>
        event Action LoadRecord;

        /// <summary>Подключиться/отключиться от устройства</summary>
        event Action ConnectToDevice;
        /// <summary>Обновить список доступных портов</summary>
        event Action RefreshPorts;

        /// <summary>Обновление графика</summary>
        /// <param name="record">Данные для графика</param>
        void UpdateChart(Record record);

        /// <summary>Время записи</summary>
        double RecordDuration { get; }

        /// <summary>Начать запись</summary>
        event Action StartRecord;
        /// <summary>Остановить запись</summary>
        event Action StopRecord;

        /// <summary></summary>
        double K_Ch1 { get; }
        /// <summary></summary>
        double K_Ch2 { get; }
    }
}
