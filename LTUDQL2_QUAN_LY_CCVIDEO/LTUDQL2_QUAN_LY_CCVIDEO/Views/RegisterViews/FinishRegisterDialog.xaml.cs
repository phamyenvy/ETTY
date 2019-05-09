using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews
{
    /// <summary>
    /// Interaction logic for FinishRegisterDialog.xaml
    /// </summary>
    public partial class FinishRegisterDialog : Window
    {
        public FinishRegisterDialog()
        {
            InitializeComponent();
            tick.Visibility = Visibility.Collapsed;
            success.Visibility = Visibility.Collapsed;
            
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            pbLoad.Value = 100;
            btnStop.Visibility = Visibility.Collapsed;
            tick.Visibility = Visibility.Visible;
            success.Visibility = Visibility.Visible;
        }

        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
