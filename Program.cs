using ECG_Viewer.Presenters;
using ECG_Viewer.Service;
using ECG_Viewer.Service.Serial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ECG_Viewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var presenter = new MainPresenter(new Serial(), new Form1(), new FileWorker());
            presenter.Run();
        }
    }
}
