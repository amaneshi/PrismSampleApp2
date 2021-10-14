using Prism.Commands;
using Prism.Services.Dialogs;

namespace PrismSampleApp.ViewModels.Dialogs
{
    public class OpenSessionDialogViewModel : DialogViewModelBase
    {
        public DelegateCommand SubmitCommand { get; }

        public OpenSessionDialogViewModel()
        {
            SubmitCommand = new DelegateCommand(Submit);
        }

        private void Submit()
        {
            RaiseRequestClose(new DialogParameters());
        }
    }
}
