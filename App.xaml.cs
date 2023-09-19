using DaTiHuDong.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Prism.DryIoc;
using Prism.Ioc;
using System.Windows;
using DryIoc;
using DaTiHuDong.ViewModels;
using DaTiHuDong.Commom;
using Prism.Services.Dialogs;
using DaTiHuDong.Views.Dialogs;
using DaTiHuDong.ViewModels.Dialogs;

namespace DaTiHuDong
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void OnInitialized()
        {
            IConfigureService? service = App.Current.MainWindow.DataContext as IConfigureService;
            if (service != null)
            {
                service.Configure();
            }
            base.OnInitialized();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialog<ShezhiView>();

            containerRegistry.RegisterForNavigation<MainView, MainViewModel>();
            containerRegistry.RegisterForNavigation<IndexView, IndexViewModel>();
            containerRegistry.RegisterForNavigation<AnswerView, AnswerViewModel>();
            containerRegistry.RegisterForNavigation<ShezhiView, ShezhiViewModel>();
            containerRegistry.RegisterForNavigation<FenshuView, FenshuViewModel>();
        }
    }
}
