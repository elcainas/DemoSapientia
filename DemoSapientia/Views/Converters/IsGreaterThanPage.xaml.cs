using DemoSapientia.ViewModels.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoSapientia.Views.Converters
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IsGreaterThanPage : ContentPage
    {
        public IsGreaterThanPage()
        {
            InitializeComponent();
            BindingContext = new IsGreaterThanPageViewModel();
        }
    }
}