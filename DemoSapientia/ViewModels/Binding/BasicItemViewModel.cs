using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoSapientia.ViewModels.Binding
{
    public class BasicItemViewModel : INotifyPropertyChanged
    {

        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _text;
        public string Text
        {
            get => _text; set
            {
                _text = value;
                OnPropertyChanged();
            }
        }

        private string _description;
        public string Description
        {
            get => _description; set
            {
                _description = value;
                OnPropertyChanged();
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
