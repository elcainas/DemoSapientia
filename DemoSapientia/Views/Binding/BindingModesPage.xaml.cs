using DemoSapientia.ViewModels.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoSapientia.Views.Binding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingModesPage : ContentPage
    {
        public BindingModesPage()
        {
            InitializeComponent();
            BindingContext = new BindingModesPageViewModel();
        }
    }
}