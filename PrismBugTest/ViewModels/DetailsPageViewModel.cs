using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismBugTest.ViewModels
{
    public class DetailsPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService navigationService;

        public DetailsPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            Console.WriteLine($"Navigated from on details page {navigationService.GetNavigationUriPath()}");
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            Console.WriteLine($"Navigated To on details page {navigationService.GetNavigationUriPath()}");
        }
    }
}
