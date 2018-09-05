using System;
using ECG_Viewer.Models;

namespace ECG_Viewer.Service
{
    public interface IFileWorker
    {
        /// <summary>
        /// Чтение записи ЭКГ из бинарного файла
        /// </summary>
        /// <param name="ErrorHandler">Обработчик ошибок во время чтения</param>
        /// <returns>Запись ЭКГ</returns>
        Record LoadRecord(Action<string> ErrorHandler = null);

        /// <summary>
        /// Сохранение записи в бинарный файл. <para/>
        /// Формат записи: Int32 - длина массива канала 1, далее double-массив канала 1. Затем так же второй канал
        /// </summary>
        /// <param name="record">Запись ЭКГ</param>
        /// <param name="ErrorHandler">Обработчик ошибок во время сохранения</param>
        void SaveSeries(Record record, Action<string> ErrorHandler = null);
    }
}