using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using COMP2003_2020_GroupF_Mobile.Services;
using COMP2003_2020_GroupF_Mobile.Views;

namespace COMP2003_2020_GroupF_Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
