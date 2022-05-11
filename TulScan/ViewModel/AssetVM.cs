using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TulScan.Model;
using TulScan.ViewModel.Commands;
using TulScan.ViewModel.Helpers;

namespace TulScan.ViewModel
{
    public class AssetVM : INotifyPropertyChanged
    {
        public NewAssetCommand NewAssetCommand { get; set; }
        public ObservableCollection<Log> Logs { get; set; }

        public AssetVM()
        {
            NewAssetCommand = new NewAssetCommand(this);

            Logs = new ObservableCollection<Log>();

            Asset = new Asset();
        }

        private Asset? _asset;
        public Asset? Asset
        {
            get { return _asset; }
            set 
            { 
                _asset = value;
                OnPropertyChanged(nameof(_asset));
            }
        }

        private string? _summary;
        public string? Summary
        {
            get { return _summary; }
            set 
            { 
                _summary = value;
                OnPropertyChanged(nameof(_summary));
            }
        }

        private string? _serialNumber;
        public string? SerialNumber
        {
            get { return _serialNumber; }
            set 
            { 
                _serialNumber = value;
                OnPropertyChanged(nameof(_serialNumber));
            }
        }

        private string? _location;
        public string? Location
        {
            get { return _location; }
            set 
            { 
                _location = value;
                OnPropertyChanged(nameof(_location));
            }
        }

        private string? _detailedLocation;
        public string? DetailedLocation
        {
            get { return _detailedLocation; }
            set 
            { 
                _detailedLocation = value;
                OnPropertyChanged(nameof(_detailedLocation));
            }
        }

        private string? _hardwareType;
        public string? HardwareType
        {
            get { return _hardwareType; }
            set 
            { 
                _hardwareType = value;
                OnPropertyChanged(nameof(_hardwareType));
            }
        }

        private string? _manafactureBrand;
        public string? ManafactureBrand
        {
            get { return _manafactureBrand; }
            set 
            { 
                _manafactureBrand = value;
                OnPropertyChanged(nameof(_manafactureBrand));
            }
        }

        private string? _model;
        public string? Model
        {
            get { return _model; }
            set 
            { 
                _model = value; 
                OnPropertyChanged(nameof(_model));
            }
        }

        private string? _assetSupplier;
        public string? AssetSupplier
        {
            get { return _assetSupplier; }
            set 
            { 
                _assetSupplier = value;
                OnPropertyChanged(nameof(_assetSupplier));
            }
        }

        private string? _supportContractDetails;
        public string? SupportContractDetails
        {
            get { return _supportContractDetails; }
            set 
            { 
                _supportContractDetails = value;
                OnPropertyChanged(nameof(_supportContractDetails));
            }
        }

        private bool? _retainInfo;
        public bool? RetainInfo
        {
            get { return _retainInfo; }
            set 
            { 
                _retainInfo = value; 
                OnPropertyChanged(nameof(_retainInfo));
            }
        }

        public async Task SubmitAsset()
        {
            JiraRequest request = new JiraRequest()
            {
                Fields = new()
                {
                    Summary = _summary,
                    Project = new()
                    {
                        Id = "10111" //id of the jira project
                    },
                    Issuetype = new()
                    {
                        Id = "10110" //id of the projects issue type
                    },
                    WarrantyDate = DateTime.Now.ToString("O"),
                    SupportContractDetails = _supportContractDetails,
                    AssetSupplier = _assetSupplier,
                    SerialNumber = _serialNumber,
                    Location = new()
                    {
                        Id = _location
                    },
                    DetailedLocation = _detailedLocation,
                    HardwareType = new()
                    {
                        Id = _hardwareType
                    },
                    ManafactureBrand = _manafactureBrand,
                    Model = _model
                }
            };

            if(Summary == "Godzilla" || Summary == "godzilla")
            {
                Log godzilla = new()
                {
                    Message = @"⠀⠀⠀⠀⠀⠀⠀⠀⢰⣶⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⣀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⣿⡟⠀⠀⠀⠀⠀⢀⣠⣾⣟⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⣀⣼⣿⠁⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣶⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣠⣴⣶⣿⣿⣿⣿⣿⣷⣤⠀⠀⠀⠙⠿⠛⠛⣩⣿⣿⣿⣿⣿⣿⣿⣧⡀⢰⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣾⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠛⠛⠉⢉⣉⣽⣿⠛⠻⢿⣿⣦⠀⠀⠀⠈⠿⠿⠿⣿⣿⣿⣿⣿⣿⣿⣿⡄⠛⠛⠁⣀⢀⣄⣠⡄⠀⠀⠀⠀⠀⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⢠⣾⣿⣿⣿⣶⡄⠀⠉⠛⠀⠀⠀⠀⠀⠀⠀⠸⠿⠿⠿⢿⣿⣿⣿⣿⣄⠀⢴⣿⣿⣿⣿⣿⣗⠀⠀⠀⢠⣿⣿⣯⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣶⣶⣶⣶⣶⣶⡌⢿⣿⣿⣿⣆⠈⢿⣿⣿⣿⣿⡏⠁⠀⠀⠀⣿⣿⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⢀⣀⣀⣴⣿⠿⠿⠟⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢸⣿⣿⣿⣿⣧⡀⠻⣿⣿⠉⠀⡀⢀⠀⠀⠹⣿⣿⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠉⠛⣿⡟⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⠙⠛⠛⠿⠿⣿⣿⣿⣿⣿⡿⢃⣼⣿⣿⣿⣿⣿⣷⡀⠀⣰⣶⣾⣿⣿⣶⠀⠀⠙⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠙⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣭⣉⣥⣶⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠻⣿⣿⣿⣿⣿⠁⠀⠀⠈⠻⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⠘⢿⣿⠏⢁⡀⣀⠀⠀⠀⠙⢿⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⡀⢠⣾⣾⣿⣿⣴⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⢻⣿⣿⣿⠿⠃⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⠿⠛⠛⠛⠻⢿⣿⣿⣿⣿⣿⣿⣿⣄⠙⠿⠇⠀⢀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⡿⠋⣡⣾⣿⣿⣿⣿⣶⣌⠻⣿⣿⣿⣿⣿⣿⣦⠀⢰⣿⣿⣿⣤⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠿⢋⣴⣾⣿⣿⣿⣿⣿⣿⣿⣿⡇⣿⣿⣿⣿⣿⣿⣿⣷⡄⠻⣿⡿⠃⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⣠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣤⣀⣀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⢁⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣿⣿⣿⣿⣿⣿⡿⠁⠾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⣿⣿⣿⡏⠀⠀⢠⣌⠙⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⣿⣿⣿⠀⠀⣀⣤⣿⣿⣷⣶⡌⠉⠛⠛⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⣴⣾⣿⣿⣿⣿⣿⠀⣾⣿⣿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢴⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀",
                    DateTime = @"







 ⣦⣄
 ⣿⣿⣶⣄
 ⣿⣿⣿⣿⣷⣦⡀
 ⠙⢿⣿⣿⣿⣿⣿⣦⣄
   ⠻⣿⣿⣿⣿⣿⣿⣶⡀
    ⠈⠻⣿⣿⣿⣿⣿⣿⡀
      ⠸⣿⣿⣿⣿⣿⡇
      ⢀⣿⣿⣿⣿⣿⡇
     ⢀⣾⣿⣿⣿⣿⣿⡇
 ⣀⣀⣠⣴⣿⣿⣿⣿⣿⣿⡟
 ⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁
 ⣿⣿⣿⣿⣿⣿⣿⣿⠟
⣿⣿⣿⣿⣿⣿⡿⠋
⡿⠿⠿⠛⠋⠁
"
                };
                Logs.Add(godzilla);
                return;
            }

            var response = await JiraHelper.CreateIssue(request);

            if(response.Key != null)
            {
                BrotherPrinterHelper brotherPrinterHelper = new();
                await brotherPrinterHelper.PrintAssetLabel(response.Key);


                if(_retainInfo is false)
                {
                    Summary = string.Empty;
                    Location = string.Empty;
                    DetailedLocation = string.Empty;
                    HardwareType = string.Empty;
                    ManafactureBrand = string.Empty;
                    Model = string.Empty;
                    AssetSupplier = string.Empty;
                    SupportContractDetails = string.Empty;
                }

                SerialNumber = string.Empty;

                Log logCompleted = new()
                {
                    DateTime = DateTime.Now.ToString("g"),
                    Message = $"{response.Key} was created successfully"
                };
                Logs.Add(logCompleted);
            }
            else
            {
                Log logError = new()
                {
                    DateTime= DateTime.Now.ToString("g"),
                    Message = "An error occurred, please try again."
                };
                Logs.Add(logError);

                SerialNumber = string.Empty;
                Summary = string.Empty;
                Location = string.Empty;
                DetailedLocation = string.Empty;
                HardwareType = string.Empty;
                ManafactureBrand = string.Empty;
                Model = string.Empty;
                AssetSupplier = string.Empty;
                SupportContractDetails = string.Empty;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
