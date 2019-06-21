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
        Profile pf = null;
        public uc_General(TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            this.tk = tk;
            this.pf = pf;

            txtNameAcc.Text = tk.TenHienThi;
            tblLevel.Text = DBProvider.getLevelAcc(tk);
            tblDate.Text = tk.NgayHetHan.Value.Date.ToString();
            tbIDCard.Text = tk.IDThe;
        }

        private void btnChagePass_Click(object sender, RoutedEventArgs e)
        {
            ChangePass wd = new ChangePass(this.tk);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            
        }

        

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            Payment wd = new Payment(this.tk, this.pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();

            var gr = this.Parent as Grid;
            var gr1 = gr.Parent as Grid;
            var gr2 = gr1.Parent as Border;
            var gr3 = gr2.Parent as Grid;

            (gr3.Parent as Window).Close();
        }

        private void btnAddCard_Click(object sender, RoutedEventArgs e)
        {
            AddNewCard wd = new AddNewCard(this.tk, this.pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            var gr = this.Parent as Grid;
            var gr1 = gr.Parent as Grid;
            var gr2 = gr1.Parent as Border;
            var gr3 = gr2.Parent as Grid;

            (gr3.Parent as Window).Close();


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
