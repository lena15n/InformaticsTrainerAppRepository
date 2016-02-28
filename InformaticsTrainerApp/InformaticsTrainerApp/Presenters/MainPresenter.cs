using InformaticsTrainerApp.View_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticsTrainerApp.Presenters
{
    class MainPresenter : IPresenter
    {
        private readonly IMainView view;
        //model is absent, we needn't it

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
