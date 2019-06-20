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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator
{
    /// <summary>
    /// Interaction logic for AccountGeneral.xaml
    /// </summary>
    public partial class AccountGeneral : UserControl
    {
        QuanLyCCVEntities ccv;
        List<TaiKhoan> taiKhoans;
        public AccountGeneral()
        {
            InitializeComponent();
            ccv = new QuanLyCCVEntities();
            taiKhoans = ccv.TaiKhoans.ToList();
            DataContext = taiKhoans;
        }

        private void btnDeleteAcc_Click(object sender, RoutedEventArgs e)
        {
            ccv = new QuanLyCCVEntities();
            int ID = (dtgAcc.SelectedItem as TaiKhoan).MaTaiKhoan;
            // MessageBox.Show("ID: " + ID);
            try
            {
                TaiKhoan t = ccv.TaiKhoans.First(p => p.MaTaiKhoan == ID);
                ccv.TaiKhoans.Remove(t);
                ccv.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Can't Remove Account!");
            }

            taiKhoans = ccv.TaiKhoans.ToList();
            dtgAcc.ItemsSource = taiKhoans;
        }

       

        private void dtgAcc_CurrentCellChanged(object sender, EventArgs e)
        {
            List<TaiKhoan> tk = DataContext as List<TaiKhoan>;
            DBProvider.SaveChangeAccount(tk);
        }
    }
}
