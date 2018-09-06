
using System;

namespace ECG_Viewer.Views
{
    /// <summary>Общий интерфейс для всех View</summary>
    public interface IView
    {
        /// <summary>Метод запуска отображения окна</summary>
        void Show();
        /// <summary>Метод закрытия окна</summary>
        void Close();

        /// <summary>Обработчик ошибок</summary>
        /// <param name="title">Заголовок ошибки</param>
        /// <param name="message">Текст ошибки</param>
        void ErrorHandler(string title, string message);
    }
}
