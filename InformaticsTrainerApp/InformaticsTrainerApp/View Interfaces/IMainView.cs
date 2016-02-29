using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticsTrainerApp.View_Interfaces
{
    public interface IMainView : IView
    {
        event Action StudentModeClicked;
        event Action TeacherModeClicked;
        event Action HelpClicked;
        event Action ExitClicked;

        

        void OpenStudentMode();
        void OpenTeacherMode();
        void OpenHelp();
        void Exit();
    }
}
