using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting;
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
        TaiKhoan tk = null;
        Profile pf = null;
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
        public Payment(TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            this.tk = tk;
            this.pf = pf;
            this.mail = tk.TenTaiKhoan;


            List<CapDoTaiKhoan> lst = DBProvider.getCapDo();
            cbLevel.ItemsSource = lst;
            cbLevel.SelectedItem = lst[0];
            cbLevel.DisplayMemberPath = "TenCapDo";
            txtIDCard.Text = tk.IDThe;
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            if (DBProvider.checkExitsCard(txtIDCard.Text) == 1)
            {
                string Pass = MaHoaChuoi.MaHoa(txtPass.Password, "etty");
                if (DBProvider.checkCodeCard(txtIDCard.Text, Pass) == 1)
                {
                    TaiKhoan tks = DBProvider.paySuccess(mail, cbLevel.SelectedValue as CapDoTaiKhoan);
                    MessageBox.Show("Thanh toán thành công!");
                    if (pf != null)
                    {
                        ProfileSettingWd wd1 = new ProfileSettingWd(tks, pf);
                        wd1.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                        wd1.Show();
                        this.Close();
                    }
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
