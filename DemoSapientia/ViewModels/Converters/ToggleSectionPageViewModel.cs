using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoSapientia.ViewModels.Converters
{
    public class ToggleSectionPageViewModel : BaseViewModel
    {
        private bool _isVisible;

        public bool IsVisible
        {
            get { return _isVisible; }
            set { SetProperty(ref _isVisible, value); }
        }
        public ICommand _toggleCommand;
        public ICommand ToggleCommand => _toggleCommand ?? new Command(Toggle);

        private void Toggle()
        {
            IsVisible = !IsVisible;
        }
    }
}
