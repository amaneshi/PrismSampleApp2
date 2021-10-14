using Prism.Commands;
using Prism.Navigation;
using Prism.Services.Dialogs;
using PrismSampleApp.Views.Dialogs;
using System.Diagnostics;

namespace PrismSampleApp.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        public DelegateCommand OpenSessionCommand { get; }
        private IDialogService _dialogService { get; }

        public HomePageViewModel(
            INavigationService navigationService,
            IDialogService dialogService)
            : base(navigationService)
        {
            _dialogService = dialogService;
            Title = "Home Page";
            OpenSessionCommand = new DelegateCommand(OpenSession);
        }

        private async void OpenSession()
        {
            var result = await _dialogService.ShowDialogAsync(nameof(OpenSessionDialog));
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            // Triggered when dialog is closed
            Debug.WriteLine("OnNavigatedTo fired.");
        }

        public override void OnNavigatedFrom(INavigationParameters parameters)
        {
            // Not triggered on dialog open
            Debug.WriteLine("OnNavigatedFrom fired.");
        }
    }
}