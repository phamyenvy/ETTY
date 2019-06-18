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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        TaiKhoan tk = null;
        Profile pf = null;
        public Admin(TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            this.tk = tk;
            this.pf = pf;
            VideoGeneral a = new VideoGeneral();
            content.Children.Clear();
            content.Children.Add(a);
        }
        public Admin(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            VideoGeneral a = new VideoGeneral();
            content.Children.Clear();
            content.Children.Add(a);
        }

        public Admin(IMDBVideo video, TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            this.tk = tk;
            this.pf = pf;
            UploadVideo a = new UploadVideo(video);
            content.Children.Clear();
            content.Children.Add(a);
        }
        public Admin(IMDBVideo video, TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            UploadVideo a = new UploadVideo(video);
            content.Children.Clear();
            content.Children.Add(a);
        }
        private void UploadItem_Selected(object sender, RoutedEventArgs e)
        {
            UploadVideo  a = new UploadVideo();
            content.Children.Clear();
            content.Children.Add(a);

        }

        private void GeneralItem_Selected(object sender, RoutedEventArgs e)
        {
            VideoGeneral a = new VideoGeneral();
            content.Children.Clear();
            content.Children.Add(a);
        }

        private void AccountItem_Selected(object sender, RoutedEventArgs e)
        {
            AccountGeneral a = new AccountGeneral();
            content.Children.Clear();
            content.Children.Add(a);
        }

        private void SearchItem_Selected(object sender, RoutedEventArgs e)
        {
            IMDBSearch a = new IMDBSearch(tk, pf);
            content.Children.Clear();
            content.Children.Add(a);
        }

        private void btnBackToHome_Click(object sender, RoutedEventArgs e)
        {
            if (pf != null)
            {
                MainWindow wd = new MainWindow(tk, pf);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
            }
            else
            {
                SelectProfile wd = new SelectProfile(tk);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
            }
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (pf != null)
            {
                MainWindow wd = new MainWindow(tk, pf);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
            }
            else
            {
                SelectProfile wd = new SelectProfile(tk);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
            }
            this.Close();
        }

        private void TopLiked_Selected(object sender, RoutedEventArgs e)
        {
            TopLiked a = new TopLiked();
            content.Children.Clear();
            content.Children.Add(a);
        }

        private void TopViewed_Selected(object sender, RoutedEventArgs e)
        {
            TopViewed a = new TopViewed();
            content.Children.Clear();
            content.Children.Add(a);
        }
    }
}
