using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TulScan.ViewModel.Commands;

namespace TulScan.ViewModel
{
    public class ConfigVM : INotifyPropertyChanged
    {
        public ConfigSubmitCommand ConfigSubmitCommand { get; set; }

        private string domainName;
        public string DomainName
        {
            get { return domainName; }
            set 
            { 
                domainName = value;
                OnPropertyChanged("domainName");
            }
        }

        public ConfigVM()
        {
            ConfigSubmitCommand = new ConfigSubmitCommand(this);
        }
        
        public void SubmitConfig()
        {
            Properties.Settings.Default.DomainName = domainName;
            Properties.Settings.Default.Save();

            Confirmed?.Invoke(this, new EventArgs());
        }

        public event EventHandler Confirmed;
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
