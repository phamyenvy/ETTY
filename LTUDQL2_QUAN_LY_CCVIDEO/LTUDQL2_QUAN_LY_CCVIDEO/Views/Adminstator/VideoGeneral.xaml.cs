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
    /// Interaction logic for VideoGeneral.xaml
    /// </summary>
    public partial class VideoGeneral : UserControl
    {
        public VideoGeneral()
        {
            InitializeComponent();
        }

        private void btnEditVideo_Click(object sender, RoutedEventArgs e)
        {
            dtgVideo.IsReadOnly = false;
        }

        private void btnSaveVideo_Click(object sender, RoutedEventArgs e)
        {
            dtgVideo.IsReadOnly = true;
        }
    }
}
