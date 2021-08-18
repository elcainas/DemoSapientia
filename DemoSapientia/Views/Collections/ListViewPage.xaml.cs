﻿using DemoSapientia.Models;
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
    public partial class ListViewPage : ContentPage
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        public ListViewPage()
        {
            InitializeComponent();
            listviewsimple.ItemsSource = DataStore.GetItems();
        }
    }
}