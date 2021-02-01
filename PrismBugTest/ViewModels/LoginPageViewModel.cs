using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;

namespace PrismBugTest.ViewModels
{
    public class LoginPageViewModel
    {
        private readonly INavigationService navigationService;

        public DelegateCommand LoginCommand { get; }

        public LoginPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            LoginCommand = new DelegateCommand(async () => await GoToMasterDetailPage());
        }

        private async Task GoToMasterDetailPage()
        {
            var navigationResult = await this.navigationService.NavigateAsync($"app:///MasterPage/NavigationPage/{NavigationPageKeys.DashboardPage}");
            Console.WriteLine($"Login page navigation result {navigationResult.Success}");
            Console.WriteLine($"Login page navigation service uri {navigationService.GetNavigationUriPath()}");
        }
    }
}
