using ECG_Viewer.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ECG_Viewer.Service
{
    public class FileWorker : IFileWorker
    {
        /// <summary>
        /// Сохранение записи в бинарный файл. <para/>
        /// Формат записи: Int32 - длина массива канала 1, далее double-массив канала 1. Затем так же второй канал
        /// </summary>
        /// <param name="record">Запись ЭКГ</param>
        /// <param name="ErrorHandler">Обработчик ошибок во время сохранения</param>
        public void SaveSeries(Record record, Action<string> ErrorHandler = null)
        {
            if (record == null || 
                record.Ch1 == null || record.Ch2 == null || 
                record.Ch1.Length == 0 || record.Ch2.Length == 0)
            {
                ErrorHandler?.Invoke("Отсутствуют данные для сохранения");
                return;
            }

            var dialog = new SaveFileDialog();
            dialog.Filter = "Запись ЭКГ *.ecgdat|*.ecgdat";
            dialog.Title = "Сохранение записи";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var fs = new FileStream(dialog.FileName, FileMode.Create))
                    using (var writer = new BinaryWriter(fs))
                    {
                        writer.Write(record.Ch1.Length);
                        for (int i = 0; i < record.Ch1.Length; i++)
                            writer.Write(record.Ch1[i]);

                        writer.Write(record.Ch2.Length);
                        for (int i = 0; i < record.Ch2.Length; i++)
                            writer.Write(record.Ch2[i]);
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandler?.Invoke(ex.Message);
                }
            }
        }

        /// <summary>
        /// Чтение записи ЭКГ из бинарного файла
        /// </summary>
        /// <param name="ErrorHandler">Обработчик ошибок во время чтения</param>
        /// <returns>Запись ЭКГ</returns>
        public Record LoadRecord(Action<string> ErrorHandler = null)
        {
            Record record = null;

            var dialog = new OpenFileDialog();
            dialog.Filter = "Запись ЭКГ *.ecgdat|*.ecgdat";
            dialog.Title = "Открытие записи";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var fs = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                    using (var reader = new BinaryReader(fs))
                    {
                        /*record = new Record();
                        int sizeCh1 = reader.ReadInt32();
                        record.Ch1 = new List<double>();
                        for (int i = 0; i < sizeCh1; i++)
                            record.Ch1.Add(reader.ReadDouble());

                        int sizeCh2 = reader.ReadInt32();
                        record.Ch2 = new List<double>();
                        for (int i = 0; i < sizeCh2; i++)
                            record.Ch2.Add(reader.ReadDouble());*/
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandler?.Invoke(ex.Message);
                }
            }

            return record;
        }
    }
}
