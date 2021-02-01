using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Navigation;

namespace PrismBugTest.ViewModels
{
    public class ItemsCollectionViewModel
    {
        private readonly INavigationService navigationService;

        public ObservableCollection<string> Items { get; }

        public DelegateCommand GoToDetailsPageCommand { get; }

        public ItemsCollectionViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;

            Items = new ObservableCollection<string>();

            GoToDetailsPageCommand = new DelegateCommand(async () => await GoToDetailsPage());

            for (int i=0; i<10; i++)
            {
                Items.Add($"Item {i}");
            }
        }

        private async Task GoToDetailsPage()
        {
            var navigationResult = await navigationService.NavigateAsync(NavigationPageKeys.DetailsPage, null, false, false);

            Console.WriteLine($"Dashboard page navigation uri {navigationService.GetNavigationUriPath()}");
        }
    }
}
