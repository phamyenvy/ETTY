﻿using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting;
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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views
{
    /// <summary>
    /// Interaction logic for SelectProfile.xaml
    /// </summary>
    public partial class SelectProfile : Window
    {
        TaiKhoan tkMain = new TaiKhoan();
        public SelectProfile()
        {
            InitializeComponent();
        }
        public SelectProfile(TaiKhoan tk )
        {
            InitializeComponent();
            List<Profile> a = DBProvider.getProfile(tk);
            lbl1.Content = a[0].TenHienThi;
            lbl2.Content = a[1].TenHienThi;
            lbl3.Content = a[2].TenHienThi;
            lbl4.Content = a[3].TenHienThi;
            btnProfile1.Background = new ImageBrush(new BitmapImage(new Uri(a[0].AvatarLink)));
            btnProfile2.Background = new ImageBrush(new BitmapImage(new Uri(a[1].AvatarLink)));
            btnProfile3.Background = new ImageBrush(new BitmapImage(new Uri(a[2].AvatarLink)));
            btnProfile4.Background = new ImageBrush(new BitmapImage(new Uri(a[3].AvatarLink)));



            
            tkMain = tk;
            lst = a;
            if(tk.LoaiTaiKhoan == 0) //kiểm tra có phải admin hya ko
            {
                btnAdmin.Visibility = Visibility.Visible;
            }
            else
            {
                btnAdmin.Visibility = Visibility.Collapsed;
            }
        }
        
        List<Profile> lst = new List<Profile>();

        private void btnProfile1_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                MainWindow wd = new MainWindow(tkMain, lst[0]);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void btnProfile2_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                MainWindow wd = new MainWindow(tkMain, lst[1]);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void btnProfile3_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                MainWindow wd = new MainWindow(tkMain, lst[2]);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        private void btnProfile4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow wd = new MainWindow(tkMain, lst[3]);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Admin wd = new Admin(tkMain);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();

            this.Close();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            StartWd wd = new StartWd();
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }
    }
}
