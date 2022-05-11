using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TulScan.ViewModel;

namespace TulScan.View
{
    /// <summary>
    /// Interaction logic for AssetWindow.xaml
    /// </summary>
    public partial class AssetWindow : Window
    {
        readonly AssetVM viewModel;

        public AssetWindow()
        {
            InitializeComponent();

            retainInfoCheckbox.IsChecked = true;
            viewModel = this.Resources["vm"] as AssetVM;
        }
    }
}
