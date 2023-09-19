using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DaTiHuDong.Views.Dialogs
{
    /// <summary>
    /// FenshuView.xaml 的交互逻辑
    /// </summary>
    public partial class FenshuView : Window
    {
        private readonly IRegionManager _regionManager;
        public FenshuView(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            InitializeComponent();
            MouseLeftButtonDown += (s, e) =>
            {
                this.Close();
                GoBack();
            };
        }
        private void GoBack()
        {
            _regionManager.Regions["MainViewRegion"].RequestNavigate("IndexView");
        }
    }
}
