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
using System.Windows.Threading;

namespace LTUDQL2_QUAN_LY_CCVIDEO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TaiKhoan tk = null;
        public Profile pf = null;
        private bool mediaPlayerIsPlaying = false;
        public MainWindow(TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            this.tk = tk;
            this.pf = pf;
            List<List<VideoInfo>> lst = new List<List<VideoInfo>>();
            lst.Add(DBProvider.getMyVideo(pf));
            lst.Add(DBProvider.getTrendingVideo());
            lst.Add(DBProvider.getNewVideo());
            //lst.Add(DBProvider.getMainVideo());

            DataContext = lst;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

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
            if(DBProvider.comparePermissionVideo(tk,DBProvider.getVideoByID(ID)))
            {
                DetailVideo dv = new DetailVideo(DBProvider.getVideo(ID));
                dv.ShowDialog();
            }
            else
            {
                //-Show cái gì đó khi cấp độ video không hổ trợ

                //-Code tạm
                Video vd = DBProvider.getVideoByID(ID);
                
                MessageBox.Show(string.Format("Vui lòng nâng cấp lên gói {0} để xem đc video",DBProvider.getNameLevel(vd)));
            }
            
        }
        //Nhóm sự kiện cho video main
        private bool userIsDraggingSlider = false;
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

        private void lstItemLogOut_Selected(object sender, RoutedEventArgs e)
        {
            this.Close();
            StartWd a = new StartWd();
            a.Show();
        }

        private void lstItemSelProfile_Selected(object sender, RoutedEventArgs e)
        {
            this.Close();
            SelectProfile a = new SelectProfile();
            a.Show();
        }

        private void sliderTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblProgressStatus.Text = TimeSpan.FromSeconds(sliderTime.Value).ToString(@"hh\:mm\:ss");
        }
    }
}
