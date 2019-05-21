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
        private bool mediaPlayerIsPlaying = false;
        private bool userIsDraggingSlider = false;

        public DetailVideo(VideoInfo vd)
        {
            InitializeComponent();
            DataContext = vd;



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
    }
}
