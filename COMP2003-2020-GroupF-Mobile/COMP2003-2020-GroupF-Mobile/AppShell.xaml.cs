using System;
using System.Collections.Generic;
using COMP2003_2020_GroupF_Mobile.ViewModels;
using COMP2003_2020_GroupF_Mobile.Views;
using Xamarin.Forms;

namespace COMP2003_2020_GroupF_Mobile
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
