﻿using System;
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
        public ProfileSettingWd()
        {
            InitializeComponent();
        }
        public ProfileSettingWd(TaiKhoan tk) //đi từ register thành công
        {
            InitializeComponent();
            this.tk = tk;
            General.IsSelected = true;
        }
        private void General_Selected(object sender, RoutedEventArgs e)
        {
            uc_General uc = new uc_General(this.tk);
            General.Background = Brushes.White;
            content.Children.Clear();
            content.Children.Add(uc);
        }

        private void Profile_Selected(object sender, RoutedEventArgs e)
        {
            uc_EditProfile uc = new uc_EditProfile(this.tk);
            content.Children.Clear();
            content.Children.Add(uc);
        }
    }
}
