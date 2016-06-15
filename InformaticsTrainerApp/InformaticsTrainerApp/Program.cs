using InformaticsTrainerApp.Presenters;
using InformaticsTrainerApp.Tools;
using InformaticsTrainerApp.View_Interfaces;
using InformaticsTrainerApp.Views;
using System;
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


            var controller = new AppController(new LightInjectAdapder())
                .RegisterView<ILoginView, LoginView>()
                .RegisterService<IMainView, MainView>()
                .RegisterView<IStudentModeView, StudentModeView>()
                .RegisterService<ITeacherModeView, TeacherModeView>()
                .RegisterInstance(new ApplicationContext()); 

            controller.Run<MainPresenter>();

        }
    }
}
