using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using Microsoft.Win32;
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
    /// Interaction logic for DetailVideo.xaml
    /// </summary>
    public partial class DetailVideo : Window
    {
        public  VideoInfo vd = null;
        private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;
        TaiKhoan tk = null;
        Profile pf = null;
        public DetailVideo(VideoInfo vd, TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            DataContext = vd;
            this.vd = vd;
            this.tk = tk;
            this.pf = pf;
            btnExitFullScreen.IsEnabled = false;
            DBProvider.setYeuThichVideo(pf.MaProfile, int.Parse(vd.ID), 3);


            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

        }
         //đi vào từ exit full screen
        
        public DetailVideo(VideoInfo vd, double time, TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            
            DataContext = vd;
            this.vd = vd;
            this.tk = tk;
            this.pf = pf;
            btnExitFullScreen.IsEnabled = false;
            mediaPlayerIsPlaying = true;
            mediaVideo.Play();
            mediaVideo.Position = TimeSpan.FromSeconds(time);
            

            DBProvider.setYeuThichVideo(pf.MaProfile, int.Parse(vd.ID), 3);

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }
        public DetailVideo(VideoInfo vd) 
        {
            InitializeComponent();
            DataContext = vd;
            this.vd = vd;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           mediaVideo.Volume = sliderVolume.Value;
           if(sliderVolume.Value == 0)
            {
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeMute;
            }
            if(sliderVolume.Value > 0 && sliderVolume.Value <20)
            {
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeLow;

            }
            if (sliderVolume.Value > 20 && sliderVolume.Value < 50)
            {
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeMedium;

            }
            if(sliderVolume.Value > 50)
            {
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeHigh;

            }
        }
        private void timer_Tick(object sender, EventArgs e)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(sliderVolume.Value != 0)
            {
                sliderVolume.Value = 0;
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeMute;
            }
            else
            {
                sliderVolume.Value = 49;
                icon.Kind = MaterialDesignThemes.Wpf.PackIconKind.VolumeMedium;

            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            
            MainWindow wd = new MainWindow(this.tk, this.pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }

        private void btnFullScreen_Click(object sender, RoutedEventArgs e)
        {
            mediaVideo.Pause();
            VideoFullScreen wd = new VideoFullScreen(vd, mediaVideo.Position.TotalSeconds, tk, pf);
            wd.Show();
            this.Close();
        }

        private void btnExitFullScreen_Click(object sender, RoutedEventArgs e)
        {
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
