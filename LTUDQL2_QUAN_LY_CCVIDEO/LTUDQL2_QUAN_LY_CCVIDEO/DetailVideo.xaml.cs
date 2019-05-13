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

namespace LTUDQL2_QUAN_LY_CCVIDEO
{
    /// <summary>
    /// Interaction logic for DetailVideo.xaml
    /// </summary>
    public partial class DetailVideo : Window
    {
        public DetailVideo()
        {
            InitializeComponent();
        }
        int flag = 0;
        private void btnPlayorPause_Click(object sender, RoutedEventArgs e)
        {
            
            if(flag == 0)
            {
                if (mediaVideo != null)
                {
                    mediaVideo.Play();
                    flag = 1;
                }
            }
            else
            {
                if (mediaVideo != null)
                {
                    mediaVideo.Pause();
                    flag = 0;
                }
            }
            
        }

        private void mediaVideo_MouseLeave(object sender, MouseEventArgs e)
        {
            btnPlayorPause.Visibility = Visibility.Collapsed;

        }

        private void mediaVideo_MouseEnter(object sender, MouseEventArgs e)
        {
            btnPlayorPause.Visibility = Visibility.Visible;

        }
    }
}
