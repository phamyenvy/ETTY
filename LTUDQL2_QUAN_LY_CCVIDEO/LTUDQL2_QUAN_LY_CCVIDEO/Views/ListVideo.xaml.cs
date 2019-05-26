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
        Profile pf;
        TaiKhoan tk;
        public ListVideo()
        {
            InitializeComponent();
            List<List<VideoInfo>> lst = new List<List<VideoInfo>>();

            lst.Add(DBProvider.getListVideo());

            DataContext = lst;
        }
        public ListVideo(int maLoai,TaiKhoan tk, Profile pf) //Mã 0 là myvideo, còn lại theo csdl là mã của cats, hiển thi dsach thuộc cats
        {
            InitializeComponent();
            List<List<VideoInfo>> lst = new List<List<VideoInfo>>();

            switch (maLoai)
            {
                case 0:
                    lst.Add(DBProvider.getMyVideo(pf));
                    this.pf = pf;
                    this.tk = tk;
                    break;
                case 1:
                    break;

                default:
                    lst.Add(DBProvider.getListVideo());


                    break;
                    
                    
            }
            

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

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wd = new MainWindow( tk, pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow wd = new MainWindow(tk, pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }

        private void btnHeart_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton a = sender as ToggleButton;
            int ID = Int32.Parse(a.Tag.ToString());
            if (a.IsChecked == true)
            {
                DBProvider.setYeuThichVideo(pf.MaProfile, ID, 2);
                DBProvider.setAddLike(ID);
            }
            else
            {
                DBProvider.removeYeuThichVideo(pf.MaProfile, ID, 2);
                DBProvider.setRemoveLike(ID);
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

        private void Grid_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            Grid a = sender as Grid;
            int ID = Int32.Parse(a.Tag.ToString());
            DetailVideo dv = new DetailVideo(DBProvider.getVideo(ID), tk, pf);
            dv.ShowDialog();
        }

        private void btnAddMyList_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton a = sender as ToggleButton;
            int ID = Int32.Parse(a.Tag.ToString());
            if (a.IsChecked == true)
            {
                DBProvider.setYeuThichVideo(pf.MaProfile, ID, 1);
            }
            else
            {
                DBProvider.removeYeuThichVideo(pf.MaProfile, ID, 1);
            }
        }

        private void btnAddMyList_Loaded(object sender, RoutedEventArgs e)
        {
            ToggleButton a = sender as ToggleButton;
            int ID = Int32.Parse(a.Tag.ToString());
            if (DBProvider.isYeuThichVideo(pf.MaProfile, ID, 1))
            {
                a.IsChecked = true;
            }
        }

    }
}
