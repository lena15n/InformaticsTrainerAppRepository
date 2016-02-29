using InformaticsTrainerApp.Tools;
using InformaticsTrainerApp.View_Interfaces;

namespace InformaticsTrainerApp.Presenters
{
    public class LoginPresenter : BasePresener<ILoginView>
    {
        //model:   private readonly IModel model;

        public LoginPresenter(IAppController controller, ILoginView view) : base(controller, view)// model
        {
            //this.model= model
        }

    }
}
