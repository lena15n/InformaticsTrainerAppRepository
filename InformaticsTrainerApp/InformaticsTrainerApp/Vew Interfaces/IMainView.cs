using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticsTrainerApp.Vew_Interfaces
{
    interface IMainView : IView
    {
        event Action<string> StudentModeClicked;
        event Action TeacherModeClicked;
        event Action HelpClicked;
        event Action ExitClicked;

        

        void OpenStudentMode();
        void OpenTeacherMode();
        void OpenHelp();
        void Exit();
        void OpenStudentMode(string v);
    }
}
