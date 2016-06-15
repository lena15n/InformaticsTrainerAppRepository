using InformaticsTrainerApp.Presenters;
using InformaticsTrainerApp.View_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticsTrainerApp.Tools
{
    public class AppController : IAppController
    {
        private readonly IContainer container;

        public AppController(IContainer container)
        {
            this.container = container;
            this.container.RegisterInstance<IAppController>(this);
        }

        public IAppController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView
        {
            container.Register<TView, TImplementation>();
            return this;
        }

        public IAppController RegisterInstance<TInstance>(TInstance instance)
        {
            container.RegisterInstance(instance);
            return this;
        }

        public IAppController RegisterService<TModel, TImplementation>()
            where TImplementation : class, TModel
        {
            container.Register<TModel, TImplementation>();
            return this;
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            if (!container.IsRegistered<TPresenter>())
                container.Register<TPresenter>();

            var presenter = container.Resolve<TPresenter>();
            presenter.Run();
        }

        public void Run<TPresenter, TArgument>(TArgument argumnent) where TPresenter : class, IPresenter<TArgument>
        {
            if (!container.IsRegistered<TPresenter>())
                container.Register<TPresenter>();

            var presenter = container.Resolve<TPresenter>();
            presenter.Run(argumnent);
        }
    }
}
