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
        IMainView view;

        public MainPresenter(IMainView view)
        {
            this.view = view;
            
            view.StudentModeClicked += View_StudentModeClicked;
        }

        private void View_StudentModeClicked()
        {
            view.OpenStudentMode();
        }
    }
}
