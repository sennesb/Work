using Prism.Commands;
using Prism.Services.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaTiHuDong.ViewModels.Dialogs
{
    public class ShezhiViewModel : IDialogAware
    {
        public DelegateCommand CloseCommand { get; private set; }

        public ShezhiViewModel()
        {
            CloseCommand = new DelegateCommand(ClickNo);
        }

        public string Title => throw new NotImplementedException();

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog()
        {
            return true;
        }

        public void OnDialogClosed()
        {
            
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {

        }
        private void ClickNo()
        {
            RequestClose?.Invoke(new DialogResult(ButtonResult.Cancel));
        }
    }
}
