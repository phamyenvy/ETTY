using LTUDQL2_QUAN_LY_CCVIDEO.Model;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var wd = new ForgotPass();
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.ShowDialog();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!isEmail(txtNameRegister.Text))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            using (var qlccv = new QuanLyCCVEntities())
            {
                TaiKhoan tk = qlccv.TaiKhoans.Where(t => t.TenTaiKhoan == txtNameRegister.Text && txtPassword.Password==t.Password).SingleOrDefault();
                if (tk == null)
                {
                    MessageBox.Show("Sai email hoặc password");
                    return;
                }
                else
                {
                    if(DBProvider.isPaid(tk))
                    {
                        var wd = new SelectProfile(tk);
                        wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                        wd.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mở trang thanh toán");
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

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register re = new Register();
            re.ShowDialog();
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
