using DaTiHuDong.Models;
using DaTiHuDong.Views.Dialogs;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTiHuDong.ViewModels
{
    public class AnswerViewModel : BindableBase
    {
        #region 属性
        private ObservableCollection<AnswerBar> _answerBars;
        public ObservableCollection<AnswerBar> AnswerBars { get { return _answerBars; } set { _answerBars = value;RaisePropertyChanged(); } }
        #endregion

        #region 命令
        public DelegateCommand<AnswerBar> AnswerCommand { get; private set; }
        public DelegateCommand GoBackCommand { get; private set; }
        public DelegateCommand EndCommand { get; private set; }
        #endregion

        #region 依赖
        private readonly IRegionManager _regionManager;
        #endregion

        public AnswerViewModel(IRegionManager regionManager)
        {
            AnswerBars = new ObservableCollection<AnswerBar>();
            CreateBars();

            GoBackCommand = new DelegateCommand(GoBack);
            AnswerCommand = new DelegateCommand<AnswerBar>(Answer);
            EndCommand = new DelegateCommand(End);
            _regionManager = regionManager;
        }

        private void End()
        {
            FenshuView fenshuView = new FenshuView(_regionManager);
            fenshuView.ShowDialog();
        }

        private void GoBack()
        {
            _regionManager.Regions["MainViewRegion"].RequestNavigate("IndexView");
        }

        private void Answer(AnswerBar bar)
        {
            throw new NotImplementedException();
        }

        void CreateBars()
        {
            AnswerBars.Add(new AnswerBar() { Title = "A" });
            AnswerBars.Add(new AnswerBar() { Title = "B" });
            AnswerBars.Add(new AnswerBar() { Title = "C" });
            AnswerBars.Add(new AnswerBar() { Title = "D" });

        }
    }
}
