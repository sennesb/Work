using DaTiHuDong.Commom;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTiHuDong.ViewModels
{
    class MainViewModel : BindableBase, IConfigureService
    {

        private readonly IRegionManager _regionManager;

        public MainViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Configure()
        {
            _regionManager.Regions["MainViewRegion"].RequestNavigate("IndexView");
        }
    }
}
