using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views
{
    /// <summary>
    /// Interaction logic for uc_ListVideo.xaml
    /// </summary>
    public partial class uc_ListVideo : UserControl
    {
        public TaiKhoan tk = null;
        public Profile pf = null;
        public uc_ListVideo(TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            this.tk = tk;
            this.pf = pf;
            List<List<VideoInfo>> lst = new List<List<VideoInfo>>();

            lst.Add(DBProvider.getListVideo());

            DataContext = lst;
        }
        int timebegin = 500, timeDuration = 300;
        bool isEnter = false;
        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {


            var gr = sender as Grid;

            var heart = gr.FindName("btnHeart") as ToggleButton;
            heart.Visibility = Visibility.Visible;

            var me = gr.FindName("video") as MediaElement;
            me.Visibility = Visibility.Visible;



            timebegin = 1000;


            if (isEnter)
            {
                timebegin = 500;
            }

            Thread.Sleep(timebegin);
            if (me != null)
            {
                me.Play();
            }



        }
        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            var gr = sender as Grid;

            var heart = gr.FindName("btnHeart") as ToggleButton;
            heart.Visibility = Visibility.Collapsed;

            var me = gr.FindName("video") as MediaElement;
            me.Visibility = Visibility.Collapsed;
            if (me != null)
            {
                me.Stop();
            }

        }

        private void Grid_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            Grid a = sender as Grid;
            int ID = Int32.Parse(a.Tag.ToString());
            DetailVideo dv = new DetailVideo(DBProvider.getVideo(ID),tk,pf);
            dv.ShowDialog();
        }

        private void btnHeart_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton a = sender as ToggleButton;
            int ID = Int32.Parse(a.Tag.ToString());
            if (a.IsChecked == true)
            {
                DBProvider.setYeuThichVideo(pf.MaProfile, ID, 2);
            }
            else
            {
                DBProvider.removeYeuThichVideo(pf.MaProfile, ID, 2);
            }
        }

        private void btnHeart_Loaded(object sender, RoutedEventArgs e)
        {
            ToggleButton a = sender as ToggleButton;
            int ID = Int32.Parse(a.Tag.ToString());
            if (DBProvider.isYeuThichVideo(pf.MaProfile, ID, 2))
            {
                a.IsChecked = true;
            }
        }
    }
}
