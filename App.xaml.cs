using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MyFirstApp.Services;
using MyFirstApp.Views;

namespace MyFirstApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Display), typeof(Display));
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
