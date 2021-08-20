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
    public partial class ToggleSectionPage : ContentPage
    {
        public ToggleSectionPage()
        {
            InitializeComponent();
            BindingContext = new ToggleSectionPageViewModel();
        }
    }
}