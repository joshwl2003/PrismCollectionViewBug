using System;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace PrismBugTest.ViewModels
{
    public class DashboardPageViewModel:BindableBase
    {
        private readonly INavigationService navigationSerivce;

        public DelegateCommand GoToDetailsPageCommand { get; }

        public ItemsCollectionViewModel CollectionsView { get; }

        public DashboardPageViewModel(INavigationService navigationSerivce)
        {
            this.navigationSerivce = navigationSerivce;

            GoToDetailsPageCommand = new DelegateCommand(async () => await GoToDetailsPage());

            CollectionsView = new ItemsCollectionViewModel(navigationSerivce);
        }

        private async Task GoToDetailsPage()
        {
            var navigationResult = await navigationSerivce.NavigateAsync(NavigationPageKeys.DetailsPage, null, false,false) ;

            Console.WriteLine($"Dashboard page navigation uri {navigationSerivce.GetNavigationUriPath()}");
        }
    }
}
