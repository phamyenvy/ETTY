﻿using LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews;
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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting
{
    /// <summary>
    /// Interaction logic for uc_General.xaml
    /// </summary>
    public partial class uc_General : UserControl
    {
        public uc_General()
        {
            InitializeComponent();
        }

        private void btnChagePass_Click(object sender, RoutedEventArgs e)
        {
            ForgotPass wd = new ForgotPass();
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            
        }
    }
}
