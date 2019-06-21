using LTUDQL2_QUAN_LY_CCVIDEO.Model;
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
        TaiKhoan tk = null;
        Profile pf = null;
        public ProfileSettingWd()
        {
            InitializeComponent();
        }
        public ProfileSettingWd(TaiKhoan tk) // đi từ register thành công
        {
            InitializeComponent();
            this.tk = tk;
            General.IsSelected = true;
            btnGoToMain.Visibility = Visibility.Visible;
            

        }
        public ProfileSettingWd(TaiKhoan tk, Profile pf) // đi từ mainwwindow
        {
            InitializeComponent();

            
                this.tk = tk;
                this.pf = pf;
                General.IsSelected = true;
                btnBack.Visibility = Visibility.Visible;
            
        }
        private void General_Selected(object sender, RoutedEventArgs e)
        {
            uc_General uc = new uc_General(this.tk, this.pf);
            General.Background = Brushes.White;
            content.Children.Clear();
            content.Children.Add(uc);
            General.Foreground = Brushes.Yellow;
            General.FontWeight = FontWeights.Bold;
            PayHistory.Foreground = Brushes.Gray;
            PayHistory.FontWeight = FontWeights.Regular;
            Profile.Foreground = Brushes.Gray;
            Profile.FontWeight = FontWeights.Regular;
        }

        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            uc_EditProfile uc = new uc_EditProfile(this.tk);
            content.Children.Clear();
            content.Children.Add(uc);
            Profile.Foreground = Brushes.Yellow;
            Profile.FontWeight = FontWeights.Bold;
            General.Foreground = Brushes.Gray;
            General.FontWeight = FontWeights.Regular;
            PayHistory.Foreground = Brushes.Gray;
            PayHistory.FontWeight = FontWeights.Regular;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wd = new MainWindow(this.tk, this.pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }

        private void btnGoToMain_Click(object sender, RoutedEventArgs e)
        {
            SelectProfile wd = new SelectProfile(this.tk);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();

        }

        private void PayHistory_Selected(object sender, RoutedEventArgs e)
        {
            uc_PayHistory uc = new uc_PayHistory(this.tk);
            content.Children.Clear();
            content.Children.Add(uc);
            PayHistory.Foreground = Brushes.Yellow;
            PayHistory.FontWeight = FontWeights.Bold;
            General.Foreground = Brushes.Gray;
            General.FontWeight = FontWeights.Regular;
            Profile.Foreground = Brushes.Gray;
            Profile.FontWeight = FontWeights.Regular;
        }
    }
}
