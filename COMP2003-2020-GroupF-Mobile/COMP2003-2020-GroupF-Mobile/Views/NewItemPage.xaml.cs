using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using COMP2003_2020_GroupF_Mobile.Models;
using COMP2003_2020_GroupF_Mobile.ViewModels;

namespace COMP2003_2020_GroupF_Mobile.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}