using DaTiHuDong.Models;
using DaTiHuDong.Views.Dialogs;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

namespace DaTiHuDong.ViewModels
{
    public class IndexViewModel : BindableBase
    {
        #region 属性
        private ObservableCollection<LevelBar> _levelBars;
        public ObservableCollection<LevelBar> LevelBars{get { return _levelBars; }set { _levelBars = value; RaisePropertyChanged(); }}
        #endregion

        #region 命令
        public DelegateCommand<LevelBar> NavigateCommand { get; private set; }
        public DelegateCommand ShezhiCommand { get; private set; }
        #endregion

        #region 依赖
        private readonly IRegionManager _regionManager;
        private readonly IDialogService _dialogService;
        #endregion

        public IndexViewModel(IRegionManager regionManager, IDialogService dialogService)
        {
            LevelBars = new ObservableCollection<LevelBar>();
            CreateBars();
            _regionManager = regionManager;
            _dialogService = dialogService;
            NavigateCommand = new DelegateCommand<LevelBar>(Navigate);
            ShezhiCommand = new DelegateCommand(Shezhi);
        }

        private void Shezhi()
        {
            _dialogService.ShowDialog("ShezhiView");
            
        }

        void CreateBars()
        {
            LevelBars.Add(new LevelBar() { Title = "初级", Img = "/Images/1--anniu1.png" });
            LevelBars.Add(new LevelBar() { Title = "中级", Img = "/Images/1--anniu2.png" });
            LevelBars.Add(new LevelBar() { Title = "高级", Img = "/Images/1--anniu3.png" });

        }

        private void Navigate(LevelBar obj)
        {
            if (obj == null || string.IsNullOrWhiteSpace(obj.Title)) return;
            _regionManager.Regions["MainViewRegion"].RequestNavigate("AnswerView");
        }
    }
}
