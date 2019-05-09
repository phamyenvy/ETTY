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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews
{
    /// <summary>
    /// Interaction logic for Register_02.xaml
    /// </summary>
    public partial class Register_02 : Window
    {
        public Register_02()
        {
            InitializeComponent();
            tblStandard.Visibility = Visibility.Collapsed;
            tblStandard_1.Visibility = Visibility.Collapsed;
            tblPremium.Visibility = Visibility.Collapsed;
            tblPremium_1.Visibility = Visibility.Collapsed;
            tblVIP.Visibility = Visibility.Collapsed;
            tblVIP_1.Visibility = Visibility.Collapsed;
        }
        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            tblStandard.Visibility = Visibility.Visible;
            tblStandard_1.Visibility = Visibility.Visible;
            tblPremium.Visibility = Visibility.Collapsed;
            tblPremium_1.Visibility = Visibility.Collapsed;
            tblVIP.Visibility = Visibility.Collapsed;
            tblVIP_1.Visibility = Visibility.Collapsed;

        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            tblPremium.Visibility = Visibility.Visible;
            tblPremium_1.Visibility = Visibility.Visible;
            tblStandard.Visibility = Visibility.Collapsed;
            tblStandard_1.Visibility = Visibility.Collapsed;
            tblVIP.Visibility = Visibility.Collapsed;
            tblVIP_1.Visibility = Visibility.Collapsed;
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            tblVIP.Visibility = Visibility.Visible;
            tblVIP_1.Visibility = Visibility.Visible;
            tblStandard.Visibility = Visibility.Collapsed;
            tblStandard_1.Visibility = Visibility.Collapsed;
            tblPremium.Visibility = Visibility.Collapsed;
            tblPremium_1.Visibility = Visibility.Collapsed;
        }
    }
}
