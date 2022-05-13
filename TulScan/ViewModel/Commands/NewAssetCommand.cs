using System;
using System.Windows.Input;

namespace TulScan.ViewModel.Commands
{
    public class NewAssetCommand : ICommand
    {
        public AssetVM _vm { get; set; }

        public NewAssetCommand(AssetVM vm)
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
            //Asset asset = parameter as Asset;

            //if(asset == null)
            //{
            //    return false;
            //}

            //if(string.IsNullOrEmpty(asset.Summary))
            //{
            //    return false;
            //}

            //if(string.IsNullOrEmpty(asset.SerialNumber))
            //{
            //    return false;
            //}

            //if(string.IsNullOrEmpty(asset.Location))
            //{
            //    return false;
            //}

            //if(string.IsNullOrEmpty(asset.DetailedLocation))
            //{
            //    return false;
            //}

            //if(string.IsNullOrEmpty(asset.HardwareType))
            //{
            //    return false;
            //}

            //if(string.IsNullOrEmpty(asset.ManafactureBrand))
            //{
            //    return false;
            //}

            //if(string.IsNullOrEmpty(asset.Model))
            //{
            //    return false;
            //}

            //if(string.IsNullOrEmpty(asset.AssetSupplier))
            //{
            //    return false;
            //}

            //if(string.IsNullOrEmpty(asset.SupportContractDetails))
            //{
            //    return false;
            //}
            
            return true;
        }

        public async void Execute(object parameter)
        {
            await _vm.SubmitAsset();
        }
    }
}
