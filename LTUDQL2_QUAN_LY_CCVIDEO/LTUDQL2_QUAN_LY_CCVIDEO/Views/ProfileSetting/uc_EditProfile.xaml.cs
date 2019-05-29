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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting
{
    /// <summary>
    /// Interaction logic for uc_EditProfile.xaml
    /// </summary>
    public partial class uc_EditProfile : UserControl
    {
        public uc_EditProfile()
        {
            InitializeComponent();
        }
        TaiKhoan tk = null;
        List<Profile> lst = null;
        public uc_EditProfile(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            lst = DBProvider.getPf(tk.MaTaiKhoan);
            name1.Text = lst[0].TenHienThi;
            name2.Text = lst[1].TenHienThi;
            name3.Text = lst[2].TenHienThi;
            name4.Text = lst[3].TenHienThi;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBProvider.updateProfile(lst[0].MaProfile, name1.Text);
                DBProvider.updateProfile(lst[1].MaProfile, name2.Text);
                DBProvider.updateProfile(lst[2].MaProfile, name3.Text);
                DBProvider.updateProfile(lst[3].MaProfile, name4.Text);
            }
            catch
            {
                MessageBox.Show("Update Fail!");
            }
            
        }
    }
}
