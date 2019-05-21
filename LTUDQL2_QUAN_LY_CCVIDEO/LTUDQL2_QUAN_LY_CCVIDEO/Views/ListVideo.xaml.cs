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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views
{
    /// <summary>
    /// Interaction logic for ListVideo.xaml
    /// </summary>
    public partial class ListVideo : Window
    {
        public ListVideo()
        {
            InitializeComponent();
            List<List<VideoInfo>> lst = new List<List<VideoInfo>>();
            
            lst.Add(DBProvider.getTrendingVideo());

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
            DetailVideo dv = new DetailVideo(DBProvider.getVideo(ID));
            dv.ShowDialog();
        }

    }
}
