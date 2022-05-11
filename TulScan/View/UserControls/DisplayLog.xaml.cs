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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TulScan.Model;

namespace TulScan.View.UserControls
{
    /// <summary>
    /// Interaction logic for DisplayLog.xaml
    /// </summary>
    public partial class DisplayLog : UserControl
    {
        public Log Log
        {
            get { return (Log)GetValue(LogProperty); }
            set { SetValue(LogProperty, value); }
        }

        public static readonly DependencyProperty LogProperty =
            DependencyProperty.Register("Log", typeof(Log), typeof(DisplayLog), new PropertyMetadata(null, SetValues));

        private static void SetValues(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            DisplayLog logUserControl = d as DisplayLog;

            if(logUserControl != null)
            {
                logUserControl.DataContext = logUserControl.Log;
            }
        }

        public DisplayLog()
        {
            InitializeComponent();
        }
    }
}
