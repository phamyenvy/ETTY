using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews;
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
    /// Interaction logic for uc_General.xaml
    /// </summary>
    public partial class uc_General : UserControl
    {
        public uc_General()
        {
            InitializeComponent();
        }
        TaiKhoan tk = null;
        public uc_General(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            txtNameAcc.Text = tk.TenHienThi;
            tblLevel.Text = DBProvider.getLevelAcc(tk);
            tblDate.Text = tk.NgayHetHan.Value.Date.ToString();
            tbIDCard.Text = tk.IDThe;
        }

        private void btnChagePass_Click(object sender, RoutedEventArgs e)
        {
            ForgotPass wd = new ForgotPass();
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            
        }

        

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            Payment wd = new Payment(tbIDCard.Text, tk.TenTaiKhoan);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
        }

        private void btnAddCard_Click(object sender, RoutedEventArgs e)
        {
            AddNewCard wd = new AddNewCard(tk.MaTaiKhoan);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            
        }
        
        private void btnSaveAll_Click(object sender, RoutedEventArgs e)
        {
            this.tk = DBProvider.reloadTK(tk);
            txtNameAcc.Text = tk.TenHienThi;
            tblLevel.Text = DBProvider.getLevelAcc(tk);
            tblDate.Text = tk.NgayHetHan.Value.Date.ToString();
            tbIDCard.Text = tk.IDThe;
        }
    }
}
