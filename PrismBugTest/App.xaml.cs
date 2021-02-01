using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using PrismBugTest.ViewModels;
using PrismBugTest.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrismBugTest
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer) : base(initializer) { }

        public App() : this(null)
        {

        }

        protected override  async void OnStart()
        {
            var navigationResult = await NavigationService.NavigateAsync("NavigationPage/LoginPage");
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MasterDetailsPage>("MasterPage");
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<DashboardPage, DashboardPageViewModel>();
            containerRegistry.RegisterForNavigation<DetailsPage, DetailsPageViewModel>();
        }

        protected override void OnInitialized()
        {
            InitializeComponent();
        }
    }
}
