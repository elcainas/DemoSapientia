using DemoSapientia.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DemoSapientia.Views
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