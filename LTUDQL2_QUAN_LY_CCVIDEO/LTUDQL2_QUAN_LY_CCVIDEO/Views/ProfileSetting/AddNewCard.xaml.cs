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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting
{
    /// <summary>
    /// Interaction logic for AddNewCard.xaml
    /// </summary>
    public partial class AddNewCard : Window
    {
        TaiKhoan tk = null;
        Profile pf = null;
        public AddNewCard(TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            this.tk = tk;
            this.pf = pf;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Pass = MaHoaChuoi.MaHoa(txtPass.Password, "etty");
                TaiKhoan tks = DBProvider.addNewCard(txtIDCard.Text, txtFName.Text, txtLName.Text, Pass, this.tk.MaTaiKhoan);
                ProfileSettingWd wd1 = new ProfileSettingWd(tks, pf);
                wd1.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd1.Show();
                this.Close();
                
                

            }
            catch (Exception)
            {

                MessageBox.Show("Add fail!");
            }
        }
    }
}
