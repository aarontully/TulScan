using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TulScan.ViewModel.Commands
{
    public class ConfigSubmitCommand : ICommand
    {
        private readonly ConfigVM _vm;

        public ConfigSubmitCommand(ConfigVM vm)
        {
            _vm = vm;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _vm.SubmitConfig();
        }
    }
}
