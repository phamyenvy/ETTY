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
        public AccountGeneral()
        {
            InitializeComponent();
        }

        private void btnEditAcc_Click(object sender, RoutedEventArgs e)
        {
            dtgAcc.IsReadOnly = true;
        }

        private void btnSaveAcc_Click(object sender, RoutedEventArgs e)
        {
            dtgAcc.IsReadOnly = false;
        }
    }
}
