using InformaticsTrainerApp.Presenters;
using InformaticsTrainerApp.Vew_Interfaces;
using InformaticsTrainerApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformaticsTrainerApp
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





            MainView mainView = new MainView();
            MainPresenter mainPresenter = new MainPresenter(mainView);           
            Application.Run(mainView);
        }
    }
}
