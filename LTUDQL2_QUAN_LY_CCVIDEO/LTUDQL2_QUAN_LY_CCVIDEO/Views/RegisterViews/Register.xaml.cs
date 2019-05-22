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
                        Password = uc1.txtPassword.Password;
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
                                if(the.FirstName==uc3.txtFistName.Text&&the.LastName==uc3.txtLastName.Text&&the.Code==uc3.txtCodeThe.Password)
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
                                Code = uc3.txtCodeThe.Password;
                                The TheNew = new The() { IDCard = IDCard, FirstName = FirstName, LastName = LastName, Code = Code };
                                qlccv.Thes.Add(TheNew);
                                qlccv.SaveChanges();
                            }

                            TaiKhoan tk = new TaiKhoan() { TenTaiKhoan = TenTaiKhoan, LoaiTaiKhoan = 1, CapDo = CapDo, NgayHetHan = DateTime.Now.AddDays(4), Password = Password, TenHienThi = TenHienThi, IDThe = IDCard, MaXacNhan = 0 };
                            qlccv.TaiKhoans.Add(tk);
                            qlccv.SaveChanges();

                            MessageBox.Show("Tạo tài khoản thành công");


                            Profile pf = tk.Profiles.SingleOrDefault();
                            var wd = new MainWindow(tk,pf);
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
