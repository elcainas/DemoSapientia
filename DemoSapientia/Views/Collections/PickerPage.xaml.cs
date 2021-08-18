using DemoSapientia.Models;
using DemoSapientia.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoSapientia.Views.Collections
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerPage : ContentPage
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();
        public PickerPage()
        {
            InitializeComponent();
            picker.ItemsSource = DataStore.GetItems().ToList();
        }
    }
}