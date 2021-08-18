using DemoSapientia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSapientia.ViewModels.Binding
{
    public class BasicBindingPageViewModel : BaseViewModel
    {
        private Item _item;

        public Item Item
        {
            get { return _item; }
            set { SetProperty(ref _item, value); }
        }
        private BasicItemViewModel _item2;
        public BasicItemViewModel Item2
        {
            get { return _item2; }
            set { SetProperty(ref _item2, value); }
        }
        public BasicBindingPageViewModel()
        {
            Item = new Item()
            {

                Id = "1",
                Text = "Item 1",
                Description = "Esta es la descripcion del Item 1"

            };
            Item2 = new BasicItemViewModel()
            {

                Id = "2",
                Text = "Item 2",
                Description = "Esta es la descripcion del Item 2"

            };
        }
    }
}
