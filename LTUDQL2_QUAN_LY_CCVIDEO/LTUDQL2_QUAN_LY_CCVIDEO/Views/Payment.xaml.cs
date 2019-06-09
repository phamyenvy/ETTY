﻿using LTUDQL2_QUAN_LY_CCVIDEO.Model;
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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        string mail = "";
        public Payment(string idcard, string mail)
        {
            InitializeComponent();
            this.mail = mail;
            List<CapDoTaiKhoan> lst =  DBProvider.getCapDo();
            cbLevel.ItemsSource = lst;
            cbLevel.SelectedItem = lst[0];
            cbLevel.DisplayMemberPath = "TenCapDo";
            txtIDCard.Text = idcard;
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            if (DBProvider.checkExitsCard(txtIDCard.Text) == 1)
            {
                if (DBProvider.checkCodeCard(txtIDCard.Text, txtPass.Password) == 1)
                {
                    DBProvider.paySuccess(mail, cbLevel.SelectedValue as CapDoTaiKhoan);
                    MessageBox.Show("Thanh toán thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Thanh toán thành công!");
                this.Close();
            }
        }
    }
}
