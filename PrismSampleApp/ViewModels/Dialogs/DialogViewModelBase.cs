using Prism.Mvvm;
using Prism.Services.Dialogs;
using System;

namespace PrismSampleApp.ViewModels.Dialogs
{
    public class DialogViewModelBase : BindableBase, IDialogAware
    {
        public event Action<IDialogParameters> RequestClose;

        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private bool _isBusy;

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        protected void RaiseRequestClose(IDialogParameters parameters)
        {
            RequestClose?.Invoke(parameters);
        }

        public virtual bool CanCloseDialog() => true;

        public virtual void OnDialogClosed() { }

        public virtual void OnDialogOpened(IDialogParameters parameters) { }
    }
}
