using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KaffeeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new TabbedPage1())
            {
                BarBackgroundColor = Color.DarkGoldenrod,
                BarTextColor = Color.White,
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
