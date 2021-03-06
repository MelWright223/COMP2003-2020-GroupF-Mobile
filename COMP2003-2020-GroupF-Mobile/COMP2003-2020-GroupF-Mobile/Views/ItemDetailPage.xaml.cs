using System.ComponentModel;
using Xamarin.Forms;
using COMP2003_2020_GroupF_Mobile.ViewModels;

namespace COMP2003_2020_GroupF_Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}