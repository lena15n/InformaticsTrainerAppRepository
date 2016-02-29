using InformaticsTrainerApp.Tools;
using InformaticsTrainerApp.View_Interfaces;

namespace InformaticsTrainerApp.Presenters
{
    public class MainPresenter : BasePresener<IMainView>
    {
        private readonly IMainView view;
        //model is absent, we needn't it

        public MainPresenter(IAppController controller, IMainView view) : base(controller, view)
        {
            this.view = view;

            view.StudentModeClicked += () => View_StudentModeClicked();
            view.TeacherModeClicked += () => View_TeacherModeClicked();
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
