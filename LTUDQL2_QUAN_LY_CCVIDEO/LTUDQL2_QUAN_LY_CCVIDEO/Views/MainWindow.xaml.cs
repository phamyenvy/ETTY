using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using LTUDQL2_QUAN_LY_CCVIDEO.Views;
using MaterialDesignThemes.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LTUDQL2_QUAN_LY_CCVIDEO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool mediaPlayerIsPlaying = false;
        public MainWindow(TaiKhoan tk, Profile pf)
        {
            InitializeComponent();

            List<List<VideoInfo>> lst = new List<List<VideoInfo>>();
            lst.Add(DBProvider.getMyVideo(pf));
            lst.Add(DBProvider.getTrendingVideo());
            lst.Add(DBProvider.getNewVideo());
            //lst.Add(DBProvider.getMainVideo());

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



            var sxDA = new DoubleAnimation();
            sxDA.To = 1.5;
            sxDA.BeginTime = TimeSpan.FromMilliseconds(0);
            sxDA.Duration = TimeSpan.FromMilliseconds(200);
            Storyboard.SetTarget(sxDA, gr);
            Storyboard.SetTargetProperty(sxDA, new PropertyPath("LayoutTransform.ScaleX"));

            var syDA = new DoubleAnimation();
            syDA.To = 1.5;
            syDA.BeginTime = TimeSpan.FromMilliseconds(0);
            syDA.Duration = TimeSpan.FromMilliseconds(200);
            Storyboard.SetTarget(syDA, gr);
            Storyboard.SetTargetProperty(syDA, new PropertyPath("LayoutTransform.ScaleY"));

            var sb = new Storyboard();
            sb.Children.Add(sxDA);
            sb.Children.Add(syDA);
            


            sb.Begin();
            Thread.Sleep(timebegin);
            if(me!= null)
            {
                me.Play();
            }
            


        }

        private void Scroll_MouseEnter(object sender, MouseEventArgs e)
        {
            isEnter = true;
        }

        private void Scroll_MouseLeave(object sender, MouseEventArgs e)
        {
            isEnter = true;
        }

        private void Scroll_ThinhHanh_MouseEnter(object sender, MouseEventArgs e)
        {
            isEnter = true;
        }

        private void Scroll_ThinhHanh_MouseLeave(object sender, MouseEventArgs e)
        {
            isEnter = true;
        }

        private void Scroll_MoiNhat_MouseEnter(object sender, MouseEventArgs e)
        {
            isEnter = true;
        }

        private void Scroll_MoiNhat_MouseLeave(object sender, MouseEventArgs e)
        {
            isEnter = true;
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            var gr = sender as Grid;

            var heart = gr.FindName("btnHeart") as ToggleButton                ;
            heart.Visibility = Visibility.Collapsed;

            var me = gr.FindName("video") as MediaElement;
            me.Visibility = Visibility.Collapsed;
            if(me!=null)
            {
                me.Stop();
            }
            
            var sxDA = new DoubleAnimation();
            sxDA.Duration = TimeSpan.FromMilliseconds(300);
            Storyboard.SetTarget(sxDA, gr);
            Storyboard.SetTargetProperty(sxDA, new PropertyPath("LayoutTransform.ScaleX"));

            var syDA = new DoubleAnimation();
            syDA.Duration = TimeSpan.FromMilliseconds(300);
            Storyboard.SetTarget(syDA, gr);
            Storyboard.SetTargetProperty(syDA, new PropertyPath("LayoutTransform.ScaleY"));

            var sb = new Storyboard();
            sb.Children.Add(sxDA);
            sb.Children.Add(syDA);
            sb.Begin();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            Grid a = sender as Grid;
            int ID = Int32.Parse(a.Tag.ToString());
            DetailVideo dv = new DetailVideo(DBProvider.getVideo(ID));
            dv.ShowDialog();
        }

        private void Play_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = (mediaVideo != null) && (mediaVideo.Source != null);
        }

        private void Play_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mediaVideo.Play();
            mediaPlayerIsPlaying = true;
        }

        private void Pause_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        private void Pause_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mediaVideo.Pause();
        }
    }
}
