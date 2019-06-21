using LTUDQL2_QUAN_LY_CCVIDEO.Model;
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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews
{
    /// <summary>
    /// Interaction logic for ChangePass.xaml
    /// </summary>
    public partial class ChangePass : Window
    {
        TaiKhoan tk = null;
        public ChangePass(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        private void btnXacNhan_Click(object sender, RoutedEventArgs e)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                if(txtOldPassword.Password == "" || txtNewPassword.Password == "" || txtRepeatNewPassword.Password == "")
                {
                    MessageBox.Show("Please enter all fields!", "Fail");
                    return;
                }
                
                string Pass = MaHoaChuoi.MaHoa(txtOldPassword.Password, "etty");
                TaiKhoan tk = qlccv.TaiKhoans.Where(t => t.TenTaiKhoan == this.tk.TenTaiKhoan && Pass == this.tk.Password).SingleOrDefault();
                if (tk == null)
                {
                    MessageBox.Show("Password incorrectly!", "Fail");
                    return;
                }
                if (txtNewPassword.Password != txtRepeatNewPassword.Password)
                {
                    MessageBox.Show("Repeat password incorrectly!", "Fail");
                    return;
                }
                else
                {
                    tk.Password = MaHoaChuoi.MaHoa(txtNewPassword.Password, "etty");
                    qlccv.SaveChanges();
                    MessageBox.Show("Change password successful!", "Accept");
                    this.Close();
                }
            }
        }
    }
}
