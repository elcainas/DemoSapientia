using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoSapientia.ViewModels.Binding
{
    public class ItemViewModel : BaseViewModel
    {

        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                SetProperty(ref _id, value);
            }
        }

        private string _text;
        public string Text
        {
            get => _text;
            set
            {
                SetProperty(ref _text, value);
            }
        }

        private string _description;
        public string Description
        {
            get => _description;
            set
            {
                SetProperty(ref _description, value);
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
