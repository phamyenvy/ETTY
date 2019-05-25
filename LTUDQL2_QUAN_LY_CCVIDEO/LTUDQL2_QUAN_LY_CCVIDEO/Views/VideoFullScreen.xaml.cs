using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views
{
    /// <summary>
    /// Interaction logic for VideoFullScreen.xaml
    /// </summary>
    
    public partial class VideoFullScreen : Window
    {
        private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;
        double timeplaying = 0;
        VideoInfo vdMain;
        TaiKhoan tk = null;
        Profile pf = null;
        int i = 0;
        public VideoFullScreen(VideoInfo vd, double time, TaiKhoan tk, Profile pf) //đây là hàm khởi tạo cho đi từ detailVideo
        {
            InitializeComponent();
            this.vdMain = vd;
            this.tk = tk;
            this.pf = pf;

            DataContext = vd;
            this.timeplaying = time;

            mediaVideo.Position = TimeSpan.FromSeconds(time);
            mediaVideo.Play();
            mediaPlayerIsPlaying = true;
            btnFullScreen.IsEnabled = false;
            btnExitFullScreen.IsEnabled = true;

            
            
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick_Full;
            timer.Start();

        }
        public VideoFullScreen(VideoInfo vd, double time, TaiKhoan tk, Profile pf, int i) // đây là hàm khởi tạo cho nhấp full screen tại main window, để nhấp nút back cho hợp lý
        {
            InitializeComponent();
            this.i = i;
            this.vdMain = vd;
            this.tk = tk;
            this.pf = pf;

            DataContext = vd;
            this.timeplaying = time;
            
            mediaVideo.Position = TimeSpan.FromSeconds(time);
            mediaVideo.Play();
            mediaPlayerIsPlaying = true;

            btnFullScreen.IsEnabled = false;
            btnExitFullScreen.IsEnabled = true;



            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick_Full;
            timer.Start();

        }
        private void btnPlayorPause_MouseEnter(object sender, MouseEventArgs e)
        {
            btnPlayorPause.Visibility = Visibility.Visible;
            stusBar.Visibility = Visibility.Visible;
        }

        private void mediaVideo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            btnPlayorPause.Visibility = Visibility.Visible;
            stusBar.Visibility = Visibility.Visible;

        }

        private void mediaVideo_MouseLeave(object sender, MouseEventArgs e)
        {
            if (mediaPlayerIsPlaying)
            {
                btnPlayorPause.Visibility = Visibility.Collapsed;
                stusBar.Visibility = Visibility.Collapsed;
            }
            else
            {
                btnPlayorPause.Visibility = Visibility.Visible;
                stusBar.Visibility = Visibility.Visible;
            }
        }

        private void btnPlayorPause_Click(object sender, RoutedEventArgs e)
        {
            if (mediaPlayerIsPlaying == false)
            {
                mediaVideo.Play();
                mediaPlayerIsPlaying = true;

            }
            else
            {
                mediaVideo.Pause();
                mediaPlayerIsPlaying = false;

            }

        }

        
        private void timer_Tick_Full(object sender, EventArgs e)
        {
            if ((mediaVideo.Source != null) && (mediaVideo.NaturalDuration.HasTimeSpan) && (!userIsDraggingSlider))
            {
                sliderTime.Minimum = 0;
                sliderTime.Maximum = mediaVideo.NaturalDuration.TimeSpan.TotalSeconds;
                sliderTime.Value = mediaVideo.Position.TotalSeconds;
            }
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

        private void Stop_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mediaPlayerIsPlaying;
        }

        private void Stop_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mediaVideo.Stop();
            mediaPlayerIsPlaying = false;
        }

        private void sliderTime_DragStarted(object sender, DragStartedEventArgs e)
        {
            userIsDraggingSlider = true;
        }

        private void sliderTime_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            userIsDraggingSlider = false;
            mediaVideo.Position = TimeSpan.FromSeconds(sliderTime.Value);
        }

        private void sliderTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblProgressStatus.Text = TimeSpan.FromSeconds(sliderTime.Value).ToString(@"hh\:mm\:ss");
        }

        
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnFullScreen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExitFullScreen_Click(object sender, RoutedEventArgs e)
        {
            if (i == 0)
            {
                DetailVideo wd = new DetailVideo(vdMain, mediaVideo.Position.TotalSeconds, tk, pf);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
            }
            else //i sẽ bằng 1
            {
                MainWindow wd = new MainWindow(tk, pf);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
            }
            this.Close();
           
        }
    }
}
