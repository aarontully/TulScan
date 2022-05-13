using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

        private Asset asset;
        public Asset Asset
        {
            get { return asset; }
            set 
            { 
                asset = value;
                OnPropertyChanged("asset");
            }
        }

        private string summary;
        public string Summary
        {
            get { return summary; }
            set 
            { 
                summary = value;
                OnPropertyChanged("summary");
            }
        }

        private string serialNumber;
        public string SerialNumber
        {
            get { return serialNumber; }
            set 
            { 
                serialNumber = value;
                OnPropertyChanged("serialNumber");
            }
        }

        private string location;
        public string Location
        {
            get { return location; }
            set 
            { 
                location = value;
                OnPropertyChanged("location");
            }
        }

        private string detailedLocation;
        public string DetailedLocation
        {
            get { return detailedLocation; }
            set 
            { 
                detailedLocation = value;
                OnPropertyChanged("detailedLocation");
            }
        }

        private string hardwareType;
        public string HardwareType
        {
            get { return hardwareType; }
            set 
            { 
                hardwareType = value;
                OnPropertyChanged("hardwareType");
            }
        }

        private string manafactureBrand;
        public string ManafactureBrand
        {
            get { return manafactureBrand; }
            set 
            { 
                manafactureBrand = value;
                OnPropertyChanged("manafactureBrand");
            }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set 
            { 
                model = value; 
                OnPropertyChanged("model");
            }
        }

        private string assetSupplier;
        public string AssetSupplier
        {
            get { return assetSupplier; }
            set 
            { 
                assetSupplier = value;
                OnPropertyChanged("assetSupplier");
            }
        }

        private string supportContractDetails;
        public string SupportContractDetails
        {
            get { return supportContractDetails; }
            set 
            { 
                supportContractDetails = value;
                OnPropertyChanged("supportContractDetails");
            }
        }

        private bool retainInfo;
        public bool RetainInfo
        {
            get { return retainInfo; }
            set 
            { 
                retainInfo = value; 
                OnPropertyChanged("retainInfo");
            }
        }

        public async Task SubmitAsset()
        {
            JiraRequest request = new JiraRequest()
            {
                Fields = new()
                {
                    Summary = summary,
                    Project = new()
                    {
                        Id = "10111" //id of the jira project
                    },
                    Issuetype = new()
                    {
                        Id = "10110" //id of the projects issue type
                    },
                    WarrantyDate = DateTime.Now.ToString("O"),
                    SupportContractDetails = supportContractDetails,
                    AssetSupplier = assetSupplier,
                    SerialNumber = serialNumber,
                    Location = new()
                    {
                        Id = location
                    },
                    DetailedLocation = detailedLocation,
                    HardwareType = new()
                    {
                        Id = hardwareType
                    },
                    ManafactureBrand = manafactureBrand,
                    Model = model
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

            JiraResponse response = await JiraHelper.CreateIssue(request);

            if(response.Key != null)
            {
                BrotherPrinterHelper brotherPrinterHelper = new();
                await brotherPrinterHelper.PrintAssetLabel(response.Key);

                Log logCompleted = new()
                {
                    DateTime = DateTime.Now.ToString("g"),
                    Message = $"{response.Key} was created successfully"
                };
                Logs.Add(logCompleted);

                if(retainInfo == false)
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

            }
            else
            {
                Log logError = new()
                {
                    DateTime = DateTime.Now.ToString("g"),
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

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
