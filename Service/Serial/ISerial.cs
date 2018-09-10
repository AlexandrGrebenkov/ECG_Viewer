using System;
using System.Collections.Generic;

namespace ECG_Viewer.Service.Serial
{
    /// <summary>
    /// Интерфейс для связи с прибором
    /// </summary>
    public interface ISerial
    {
        /// <summary>Состояние подключения</summary>
        bool IsConnected { get; }
        /// <summary>Список доступных портов</summary>
        IEnumerable<string> AvailablePorts { get; }

        /// <summary>Открытие порта</summary>
        /// <param name="portName">Имя порта</param>
        /// <param name="baudRate">Скорость обмена</param>
        /// <param name="ErrorHandler">Обработчик ошибок подключения</param>
        void Connect(string portName, int baudRate, Action<string> ErrorHandler = null);
        /// <summary>Закрытие порта</summary>
        /// <param name="ErrorHandler">Обработчик ошибок</param>
        void Disconnect(Action<string> ErrorHandler = null);

        /// <summary>Событие об изменении состояния подключения</summary>
        event Action<bool> ConnectionChanged;

        /// <summary>Индикатор новых полученных данных</summary>
        bool HasNewData { get; }
        /// <summary>Чтение данных из порта</summary>
        byte[] ReadData();

        /// <summary>Очистка буфера</summary>
        void FlushRxBuffer();

        /// <summary>Метод отправки данных в последовательный порт</summary>
        /// <param name="data">Байт-массив данных</param>
        void WriteData(byte[] data);
    }
}
