using InformaticsTrainerApp.Tools;
using InformaticsTrainerApp.View_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticsTrainerApp.Presenters
{
    public class TeacherModePresenter : BasePresener<ITeacherModeView>
    {
        public TeacherModePresenter(IAppController controller, ITeacherModeView view) : base(controller, view)// model
        {
            //this.model= model
        }
    }
}
