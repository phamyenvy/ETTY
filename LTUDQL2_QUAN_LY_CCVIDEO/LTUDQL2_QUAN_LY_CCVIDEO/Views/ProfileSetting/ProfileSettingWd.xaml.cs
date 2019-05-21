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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting
{
    /// <summary>
    /// Interaction logic for ProfileSettingWd.xaml
    /// </summary>
    public partial class ProfileSettingWd : Window
    {
        public ProfileSettingWd()
        {
            InitializeComponent();
        }

        private void General_Selected(object sender, RoutedEventArgs e)
        {
            uc_General uc = new uc_General();
            content.Children.Clear();
            content.Children.Add(uc);
        }
    }
}
