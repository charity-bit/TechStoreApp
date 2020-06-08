using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TechStore.Views;
namespace TechStore
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new OverviewPage())
            {
                BarBackgroundColor = Color.Yellow,
                
                
            };
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
