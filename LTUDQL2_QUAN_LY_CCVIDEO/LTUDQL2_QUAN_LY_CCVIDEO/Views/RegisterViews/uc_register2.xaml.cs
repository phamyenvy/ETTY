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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews
{
    /// <summary>
    /// Interaction logic for uc_register2.xaml
    /// </summary>
    public partial class uc_register2 : UserControl
    {
        public uc_register2()
        {
            InitializeComponent();
            tblPremium.Visibility = Visibility.Collapsed;
            tblPremium_1.Visibility = Visibility.Collapsed;
            tblVIP.Visibility = Visibility.Collapsed;
            tblVIP_1.Visibility = Visibility.Collapsed;
            tblStandard_1.Visibility = Visibility.Collapsed;
            tblStandard.Visibility = Visibility.Collapsed;
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

            tblPremium.Visibility = Visibility.Collapsed;
            tblPremium_1.Visibility = Visibility.Collapsed;
            tblVIP.Visibility = Visibility.Collapsed;
            tblVIP_1.Visibility = Visibility.Collapsed;
            tblStandard_1.Visibility = Visibility.Visible;
            tblStandard.Visibility = Visibility.Visible;
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            tblPremium.Visibility = Visibility.Collapsed;
            tblPremium_1.Visibility = Visibility.Collapsed;
            tblVIP.Visibility = Visibility.Visible;
            tblVIP_1.Visibility = Visibility.Visible;
            tblStandard_1.Visibility = Visibility.Collapsed;
            tblStandard.Visibility = Visibility.Collapsed;
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            tblPremium.Visibility = Visibility.Visible;
            tblPremium_1.Visibility = Visibility.Visible;
            tblVIP.Visibility = Visibility.Collapsed;
            tblVIP_1.Visibility = Visibility.Collapsed;
            tblStandard_1.Visibility = Visibility.Collapsed;
            tblStandard.Visibility = Visibility.Collapsed;
        }
    }
}
