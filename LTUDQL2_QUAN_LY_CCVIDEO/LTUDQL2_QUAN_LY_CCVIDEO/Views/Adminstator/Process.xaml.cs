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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator
{
    /// <summary>
    /// Interaction logic for Process.xaml
    /// </summary>
    public partial class Process : Window
    {
        public Process()
        {
            InitializeComponent();
            tick.Visibility = Visibility.Collapsed;
            success.Visibility = Visibility.Collapsed;
        }
        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }
    }
}