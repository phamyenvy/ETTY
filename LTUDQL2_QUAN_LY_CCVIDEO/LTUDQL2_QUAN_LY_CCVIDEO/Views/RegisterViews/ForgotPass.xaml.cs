using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    /// Interaction logic for ForgotPass.xaml
    /// </summary>
    public partial class ForgotPass : Window
    {
        public ForgotPass()
        {
            InitializeComponent();
        }

        string randomCode;
        public static string to;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                TaiKhoan tk = qlccv.TaiKhoans.Where(t => t.TenTaiKhoan == txtEmailForgotPass.Text).SingleOrDefault();
                if (tk != null)
                {
                    string from, pass, messageBody;
                    Random rand = new Random();
                    randomCode = (rand.Next(999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (txtEmailForgotPass.Text).ToString();
                    from = "ettysoftware@gmail.com";
                    pass = "ettypass";
                    messageBody = "Mã xác nhận: " + randomCode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Mã khôi phục tài khoản ETTY";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);
                    try
                    {
                        smtp.Send(message);
                        MessageBox.Show("Đã gởi mã, vui lòng kiểm tra email");
                        //Lưu mã vào DB ở cột mã xác nhận trong dòng có mail đó
                        tk.MaXacNhan = int.Parse(randomCode.ToString());
                        qlccv.SaveChanges();

                        newPass.Visibility = Visibility.Visible;
                        rpNewPass.Visibility = Visibility.Visible;
                        Code.Visibility = Visibility.Visible;
                        txtEmailForgotPass.IsEnabled = false;
                        btnSend.Visibility = Visibility.Collapsed;
                        btnXacNhan.Visibility = Visibility.Visible;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Lỗi", "Email chưa được đăng ký");
                }
            }
        }

        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                TaiKhoan tk = qlccv.TaiKhoans.Where(t => t.TenTaiKhoan == txtEmailForgotPass.Text).SingleOrDefault();
                int code = 0;
                if (!int.TryParse(txtCode.Text, out code))
                {
                    MessageBox.Show("Mã code phải là số", "Lỗi");
                    return;
                }
                if (tk.MaXacNhan != code)
                {
                    MessageBox.Show("Mã code sai", "Lỗi");
                    return;
                }
                else
                {
                    if (txtNewPassword.Password != txtRepeatNewPassword.Password)
                    {
                        MessageBox.Show("Lập lại password không khớp", "Lỗi");
                        return;
                    }
                    else
                    {
                        tk.Password = MaHoaChuoi.MaHoa(txtNewPassword.Password,"etty");
                        qlccv.SaveChanges();
                        MessageBox.Show("Thay đổi password thành công", "Xác nhận");
                        this.Close();
                    }
                }
            }
        }

        
    }
    public class EmailValidation : ValidationRule
    {
        
        public string ErrorMsg { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var vr = new ValidationResult(true, null);
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            
            if (regex.IsMatch(value.ToString()) == false || value.ToString() =="")
            {
                vr = new ValidationResult(false, ErrorMsg);
            }
            return vr;
        }
    }
}
