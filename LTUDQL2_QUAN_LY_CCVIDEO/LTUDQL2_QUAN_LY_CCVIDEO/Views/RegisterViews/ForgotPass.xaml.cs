using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for ForgotPass.xaml
    /// </summary>
    public partial class ForgotPass : Window
    {
        public ForgotPass()
        {
            InitializeComponent();
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            newPass.Visibility = Visibility.Visible;
            rpNewPass.Visibility = Visibility.Visible;
            Code.Visibility = Visibility.Visible;
            txtEmailForgotPass.IsEnabled = false;
            btnSend.Visibility = Visibility.Collapsed;
            btnXacNhan.Visibility = Visibility.Visible;
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
