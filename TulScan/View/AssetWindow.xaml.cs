using System;
using System.Windows;
using TulScan.ViewModel;

namespace TulScan.View
{
    /// <summary>
    /// Interaction logic for AssetWindow.xaml
    /// </summary>
    public partial class AssetWindow : Window
    {
        readonly AssetVM _viewModel;

        public AssetWindow()
        {
            InitializeComponent();

            retainInfoCheckbox.IsChecked = true;
            locationComboBox.IsReadOnly = true;
            locationComboBox.IsEditable = false;
            hardwareComboBox.IsReadOnly = true;
            hardwareComboBox.IsEditable = false;
            _viewModel = this.Resources["vm"] as AssetVM;
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            if(string.IsNullOrEmpty(Properties.Settings.Default.DomainName))
            {
                ConfigWindow configWindow = new ConfigWindow();
                configWindow.ShowDialog();
            }
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
