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
    /// Interaction logic for uc_PayHistory.xaml
    /// </summary>
    public partial class uc_PayHistory : UserControl
    {
        TaiKhoan tk = null;
        public uc_PayHistory(TaiKhoan tk)
        {
            InitializeComponent();

            this.tk = tk;
            List<ThanhToan> lst = DBProvider.getDSThanhToan(this.tk);
            DataContext = lst;
        }

        
    }
}
