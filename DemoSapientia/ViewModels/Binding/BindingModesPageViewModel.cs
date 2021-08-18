using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoSapientia.ViewModels.Binding
{
    public class BindingModesPageViewModel : BaseViewModel
    {
        private int _variableA;
        public int VariableA
        {
            get => _variableA;
            set => SetProperty(ref _variableA, value);
        }
        private int _variableB;
        public int VariableB
        {
            get => _variableB;
            set => SetProperty(ref _variableB, value);
        }
        public ICommand _incrementarVariable;

        public ICommand IncrementarVariable => _incrementarVariable ?? new Command<string>(Incrementar);

        private void Incrementar(string x)
        {
            switch (x)
            {
                case "A":
                    VariableA++;
                    break;
                case "B":
                    VariableB++;
                    break;
                default:
                    break;
            }
        }
    }
}
