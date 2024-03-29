﻿using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        string TenHienThi = "", TenTaiKhoan = "", Password = "", IDCard = "", FirstName = "", LastName = "", Code = "";

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                btnNext_Click(sender, e);
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login wd = new Login();
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }

        int CapDo = 0;
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if(uc1.Visibility == Visibility.Visible)
            {
                if(uc1.txtNameRegister.Text=="")
                {
                    MessageBox.Show("Vui lòng nhập tên");
                    return;
                }
                if(!isEmail(uc1.txtMail.Text))
                {
                    MessageBox.Show("Email không hợp lệ");
                    return;
                }
                if(uc1.txtPassword.Password!=uc1.txtRpPassword.Password||uc1.txtPassword.Password=="")
                {
                    MessageBox.Show("Nhập Password và Repeat Password chưa trùng nhau");
                    return;
                }
                using (var qlccv = new QuanLyCCVEntities())
                {
                    TaiKhoan tk = qlccv.TaiKhoans.Where(t => t.TenTaiKhoan == uc1.txtMail.Text).SingleOrDefault();
                    if(tk!=null)
                    {
                        MessageBox.Show("Tài khoản này đã được đăng ký trước đó");
                        return;
                    }
                    else
                    {
                        TenHienThi = uc1.txtNameRegister.Text;
                        TenTaiKhoan = uc1.txtMail.Text;
                        Password = MaHoaChuoi.MaHoa(uc1.txtPassword.Password, "etty");
                    }
                }
                uc1.Visibility = Visibility.Collapsed;
                uc2.Visibility = Visibility.Visible;
                
            }
            else
            {
                if (uc2.Visibility == Visibility.Visible)
                {
                    //uc1.Visibility = Visibility.Collapsed;
                    using (var qlccv = new QuanLyCCVEntities())
                    {
                        CapDoTaiKhoan lv = qlccv.CapDoTaiKhoans.Where(t => t.TenCapDo == uc2.TenCapDo).SingleOrDefault();
                        if(lv!=null)
                        {
                            CapDo = lv.MaCapDo;
                        }
                        else
                        {
                            MessageBox.Show("Không có cấp độ tài khoản");
                            return;
                        }
                    }
                    uc2.Visibility = Visibility.Collapsed;
                    uc3.Visibility = Visibility.Visible;
                }
                else
                {
                    if (uc3.Visibility == Visibility.Visible)
                    {
                        if(!IsNumber(uc3.txtIDCard.Text))
                        {
                            MessageBox.Show("IDCard phải là số");
                            return;
                        }
                        if(uc3.txtFistName.Text=="")
                        {
                            MessageBox.Show("Vui lòng nhập First Name");
                            return;
                        }
                        if (uc3.txtLastName.Text == "")
                        {
                            MessageBox.Show("Vui lòng nhập Last Name");
                            return;
                        }
                        if(!IsNumber(uc3.txtCodeThe.Password))
                        {
                            MessageBox.Show("Code phải là số");
                            return;
                        }
                        using (var qlccv = new QuanLyCCVEntities())
                        {
                            The the = qlccv.Thes.Where(t => t.IDCard == uc3.txtIDCard.Text).SingleOrDefault();
                            if(the!=null)
                            {
                                string Pass = MaHoaChuoi.MaHoa(uc3.txtCodeThe.Password, "etty");
                                if(the.FirstName==uc3.txtFistName.Text&&the.LastName==uc3.txtLastName.Text&&the.Code==Pass)
                                {
                                    IDCard = the.IDCard;
                                }
                                else
                                {
                                    MessageBox.Show("Thẻ không hợp lệ");
                                    return;
                                }
                            }
                            else
                            {
                                IDCard = uc3.txtIDCard.Text;
                                FirstName = uc3.txtFistName.Text;
                                LastName = uc3.txtLastName.Text;
                                Code = MaHoaChuoi.MaHoa(uc3.txtCodeThe.Password, "etty");
                                The TheNew = new The() { IDCard = IDCard, FirstName = FirstName, LastName = LastName, Code = Code };
                                qlccv.Thes.Add(TheNew);
                                qlccv.SaveChanges();
                            }

                            TaiKhoan tk = new TaiKhoan() { TenTaiKhoan = TenTaiKhoan, LoaiTaiKhoan = 1, CapDo = CapDo, NgayHetHan = DateTime.Now.AddDays(30), Password = Password, TenHienThi = TenHienThi, IDThe = IDCard, MaXacNhan = 0 };
                            qlccv.TaiKhoans.Add(tk);
                            qlccv.SaveChanges();

                            int maTk = DBProvider.getIDAcc(TenTaiKhoan);
                            Profile pf0 = new Profile() { TenHienThi = "Strange", TaiKhoan = maTk, AvatarLink = @"D:\LTUDQL2\ava1.png" };
                            Profile pf1 = new Profile() { TenHienThi = "Steve", TaiKhoan = maTk, AvatarLink = @"D:\LTUDQL2\ava2.png" };
                            Profile pf2 = new Profile() { TenHienThi = "Scottlang", TaiKhoan = maTk, AvatarLink = @"D:\LTUDQL2\ava3.png" };
                            Profile pf3 = new Profile() { TenHienThi = "Banner", TaiKhoan = maTk, AvatarLink = @"D:\LTUDQL2\ava4.png" };
                            qlccv.Profiles.Add(pf0);
                            qlccv.Profiles.Add(pf1);
                            qlccv.Profiles.Add(pf2);
                            qlccv.Profiles.Add(pf3);
                            qlccv.SaveChanges();

                            MessageBox.Show("Tạo tài khoản thành công");


                            
                            var wd = new ProfileSettingWd(tk);
                            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                            wd.Show();
                            this.Close();
                        }

                    }
                }
                
            }
            
        }


        bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            uc2.lbLevel.SelectedIndex = 0;
        }
        
    }
}
