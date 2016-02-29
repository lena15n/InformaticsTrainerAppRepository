﻿using InformaticsTrainerApp.Presenters;
using InformaticsTrainerApp.View_Interfaces;

namespace InformaticsTrainerApp.Tools
{
    public interface IAppController
    {
        IAppController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : IView;

        IAppController RegisterInstance<TArgument>(TArgument instance);

        IAppController RegisterService<TService, TImplementation>()
            where TImplementation : class, TService;

        void Run<TPresenter>()
            where TPresenter : class, IPresenter;

        void Run<TPresenter, TArgumnent>(TArgumnent argumnent)
            where TPresenter : class, IPresenter<TArgumnent>;
    }
}
