using InformaticsTrainerApp.Presenters;
using InformaticsTrainerApp.View_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticsTrainerApp.Tools
{
    public abstract class BasePresener<TView> : IPresenter
       where TView : IView
    {
        protected TView view { get; private set; }
        protected IAppController Controller { get; private set; }

        protected BasePresener(IAppController controller, TView view)
        {
            Controller = controller;
            this.view = view;
        }

        public void Run()
        {
            view.Show();
        }
    }

    public abstract class BasePresener<TView, TArg> : IPresenter<TArg>
        where TView : IView
    {
        protected TView view { get; private set; }
        protected IAppController Controller { get; private set; }

        protected BasePresener(IAppController controller, TView view)
        {
            Controller = controller;
            this.view = view;
        }

        public abstract void Run(TArg argument);
    }
}
