using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoSapientia.ViewModels.Converters
{
    public class IsGreaterThanPageViewModel : BaseViewModel
    {
        private int _variable;

        public int Variable
        {
            get { return _variable; }
            set { SetProperty(ref _variable, value); }
        }

        public ICommand _changeValueCommand;

        public ICommand ChangeValueCommand => _changeValueCommand ?? new Command<string>(x => ChangeValue(x));

        private void ChangeValue(string value)
        {
            switch (value)
            {
                case "-":
                    Variable--;
                    break;

                case "+":
                    Variable++;
                    break;
                default:
                    break;
            }
        }
    }
}
