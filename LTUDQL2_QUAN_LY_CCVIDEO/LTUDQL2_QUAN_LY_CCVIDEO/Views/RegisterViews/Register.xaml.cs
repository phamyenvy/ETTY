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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if(uc1.Visibility == Visibility.Visible)
            {
                uc1.Visibility = Visibility.Collapsed;
                uc2.Visibility = Visibility.Visible;
                uc3.Visibility = Visibility.Collapsed;
            }
            else
            {
                if (uc2.Visibility == Visibility.Visible)
                {
                    uc1.Visibility = Visibility.Collapsed;
                    uc2.Visibility = Visibility.Collapsed;
                    uc3.Visibility = Visibility.Visible;
                }
                else
                {
                    if (uc3.Visibility == Visibility.Visible)
                    {
                        uc1.Visibility = Visibility.Collapsed;
                        uc2.Visibility = Visibility.Collapsed;
                        uc3.Visibility = Visibility.Visible;
                    }
                }
                
            }
            
        }

        private void btnPre_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
