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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
            VideoGeneral a = new VideoGeneral();
            content.Children.Clear();
            content.Children.Add(a);
        }

        public Admin(IMDBVideo video)
        {
            InitializeComponent();
            UploadVideo a = new UploadVideo(video);
            content.Children.Clear();
            content.Children.Add(a);
        }

        private void UploadItem_Selected(object sender, RoutedEventArgs e)
        {
            UploadVideo  a = new UploadVideo();
            content.Children.Clear();
            content.Children.Add(a);

        }

        private void GeneralItem_Selected(object sender, RoutedEventArgs e)
        {
            VideoGeneral a = new VideoGeneral();
            content.Children.Clear();
            content.Children.Add(a);
        }

        private void AccountItem_Selected(object sender, RoutedEventArgs e)
        {
            AccountGeneral a = new AccountGeneral();
            content.Children.Clear();
            content.Children.Add(a);
        }

        private void SearchItem_Selected(object sender, RoutedEventArgs e)
        {
            IMDBSearch a = new IMDBSearch();
            content.Children.Clear();
            content.Children.Add(a);
        }
    }
}
