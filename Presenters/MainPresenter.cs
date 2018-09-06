using ECG_Viewer.Service;
using ECG_Viewer.Service.Serial;
using ECG_Viewer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECG_Viewer.Presenters
{
    public class MainPresenter
    {
        ISerial Serial;
        IMainView View;
        IFileWorker FileWorker;

        public MainPresenter(ISerial serial, IMainView view, IFileWorker fileWorker)
        {
            Serial = serial;
            View = view;
            FileWorker = fileWorker;
        }

        public void Run()
        {
            View.Show();
        }
    }
}
