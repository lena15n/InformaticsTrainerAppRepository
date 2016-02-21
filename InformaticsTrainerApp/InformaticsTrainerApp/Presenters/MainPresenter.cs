using InformaticsTrainerApp.Vew_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticsTrainerApp.Presenters
{
    class MainPresenter
    {
        private readonly IMainView view;
        //model is absent, we need not it

        public MainPresenter(IMainView view)
        {
            this.view = view;
            
            view.StudentModeClicked += () => View_StudentModeClicked();
            view.TeacherModeClicked += () => View_TeacherModeClicked();

        }

        public void Run()
        {
            view.Show();
        }


        private void View_StudentModeClicked()
        {
            view.OpenStudentMode();
        }

        private void View_TeacherModeClicked()
        {
            view.OpenStudentMode();
        }
    }
}
