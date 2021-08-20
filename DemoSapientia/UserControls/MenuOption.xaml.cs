using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoSapientia.UserControls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuOption : ContentView
    {
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(nameof(Title), typeof(string), typeof(MenuOption), string.Empty);
        public static readonly BindableProperty IconImageSourceProperty = BindableProperty.Create(nameof(IconImageSource), typeof(ImageSource), typeof(MenuOption), default(ImageSource));
        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }
        public ImageSource IconImageSource
        {
            get => (ImageSource)GetValue(IconImageSourceProperty);
            set => SetValue(IconImageSourceProperty, value);
        }
        public MenuOption()
        {
            InitializeComponent();
            //BindingContext = this;
        }
    }
}