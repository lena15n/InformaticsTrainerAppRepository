using InformaticsTrainerApp.Tools;
using InformaticsTrainerApp.View_Interfaces;

namespace InformaticsTrainerApp.Presenters
{
    public class StudentModePresenter : BasePresener<IStudentModeView>
    {
        //model:   private readonly IModel model;

        public StudentModePresenter(IAppController controller, IStudentModeView view) : base(controller, view)// model
        {
            //this.model= model
        }

        //public method(){
        //  Controller.Run<MainPresener, User>(user);// open new Form through the PRESENTER with a parameter
        //}
    }
}
