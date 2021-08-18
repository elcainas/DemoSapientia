using DemoSapientia.Models;
using DemoSapientia.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoSapientia.ViewModels.Binding
{
    public class ObservableCollectionPageViewModel : BaseViewModel
    {
        public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();

        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        public ICommand _removeItemCommand;
        public ICommand RemoveItemCommand => _removeItemCommand ?? new Command<Item>(async (x) => await RemoveItem(x));
        public ICommand _loadAllItemsCommand;

        public ICommand LoadAllItemsCommand => _loadAllItemsCommand ?? new Command(LoadAllItems);

        private void LoadAllItems()
        {
            Items = new ObservableCollection<Item>(DataStore.GetItems());
        }

        private async Task RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public ObservableCollectionPageViewModel()
        {
            LoadAllItems();
        }
    }
}
