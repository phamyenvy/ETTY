﻿using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using LTUDQL2_QUAN_LY_CCVIDEO.Views;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting;
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
        List<List<VideoInfo>> lst = new List<List<VideoInfo>>();
        public MainWindow(TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            this.tk = tk;
            this.pf = pf;
            lst.Add(DBProvider.getMyVideo(pf));
            lst.Add(DBProvider.getTrendingVideo());
            lst.Add(DBProvider.getNewVideo());
            lst.Add(DBProvider.getRecently(pf));
            lst.Add(DBProvider.getMainVideo_Phu()); // để lấy video main ra chuyển sang dạng videoinfo để bật full screen
            btnProfile.Background = new ImageBrush(new BitmapImage(new Uri(pf.AvatarLink)));

            DataContext = lst;
            List<String> lstVideo = DBProvider.getLoaiVideo();
            List<String> lstPlaylistProfile = DBProvider.getDSPlayList(this.pf);

            List<MenuItem> lstCats = new List<MenuItem>();
            List<MenuItem> lstplayList = new List<MenuItem>();

            foreach (String t in lstVideo)
            {
                MenuItem a = new MenuItem();
                a.Header = t;
                a.Tag = t;
                a.Click += new RoutedEventHandler(this.btnButton_Click);
                lstCats.Add(a);
            }
            cbCats.ItemsSource = lstCats;
            
            cbCats.DisplayMemberPath = "TenLoaiVideo";



            foreach (String t in lstPlaylistProfile)
            {
                MenuItem a = new MenuItem();
                a.Header = t;
                a.Tag = t;
                a.Click += new RoutedEventHandler(this.btnGetPlayList_Click);
                lstplayList.Add(a);
            }

            playList.ItemsSource = lstplayList;


            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            if (tk.LoaiTaiKhoan == 0)
            {
                Adminstator.Visibility = Visibility.Visible;
            }
            else
            {
                Adminstator.Visibility = Visibility.Collapsed;
            }
            
        }
        #region sự kiện zoom
        int timebegin = 500;
        bool isEnter = false;
        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        { 


            var gr = sender as Grid;

            var heart = gr.FindName("btnHeart") as ToggleButton;
            heart.Visibility = Visibility.Visible;

            var add = gr.FindName("btnAddMyList") as ToggleButton;
            add.Visibility = Visibility.Visible;
            var addpl = gr.FindName("btnAddPlayList") as ToggleButton;
            addpl.Visibility = Visibility.Visible;
            
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

            var heart = gr.FindName("btnHeart") as ToggleButton;
            heart.Visibility = Visibility.Collapsed;

            var add = gr.FindName("btnAddMyList") as ToggleButton;
            add.Visibility = Visibility.Collapsed;

            var addpl = gr.FindName("btnAddPlayList") as ToggleButton;
            addpl.Visibility = Visibility.Collapsed;

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
        #endregion

        void btnButton_Click(object sender, RoutedEventArgs e)
        {
            MenuItem a = sender as MenuItem;
            ListVideo wd1 = new ListVideo(DBProvider.getIDLoaiVByName(a.Tag.ToString()), tk, pf);
            wd1.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd1.Show();
            this.Close();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseEventArgs e)
        {
            Grid a = sender as Grid;
            int ID = Int32.Parse(a.Tag.ToString());
            if(DBProvider.comparePermissionVideo(tk,DBProvider.getVideoByID(ID)))
            {
                DetailVideo dv = new DetailVideo(DBProvider.getVideo(ID), tk, pf);
                dv.Show();
                this.Close();
                
            }
            else
            {
                
                Video vd = DBProvider.getVideoByID(ID);
                
                MessageBox.Show(string.Format("Vui lòng nâng cấp lên gói {0} để xem đc video",DBProvider.getNameLevel(vd)));
            }
            
        }
        #region Nhóm sự kiện cho video main
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

        private void sliderTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblProgressStatus.Text = TimeSpan.FromSeconds(sliderTime.Value).ToString(@"hh\:mm\:ss");
        }
        private void btnFullScreen_Click(object sender, RoutedEventArgs e)
        {
            mediaVideo.Stop();
            if (DBProvider.comparePermissionVideo(tk, DBProvider.getMainVideo()[0]))
            {
                VideoFullScreen wd = new VideoFullScreen(lst[4][0], mediaVideo.Position.TotalSeconds, tk, pf, 1);
                wd.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("Vui lòng nâng cấp lên gói {0} để xem đc video", DBProvider.getNameLevel(DBProvider.getMainVideo()[0])));

            }

        }

        private void btnExitFullScreen_Click(object sender, RoutedEventArgs e)
        {

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
        #endregion

        #region Nhóm sự kiện chọn popup
        private void lstItemLogOut_Selected(object sender, RoutedEventArgs e)
        {
            
            StartWd wd = new StartWd();
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }

        private void lstItemSelProfile_Selected(object sender, RoutedEventArgs e)
        {
            
            SelectProfile wd = new SelectProfile(tk);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }
        private void lstItemSetting_Selected(object sender, RoutedEventArgs e)
        {
            if (this.pf.Status == 1)
            {
                ProfileSettingWd wd = new ProfileSettingWd(this.tk, this.pf);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your profile not allow go to setting!");
            }
            
        }

        #endregion

        private void myList_Click(object sender, RoutedEventArgs e)
        {
            ListVideo wd = new ListVideo(0,tk, pf);
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

        private void btnGetPlayList_Click(object sender, RoutedEventArgs e)
        {
            MenuItem a = sender as MenuItem;
            ListVideo wd = new ListVideo(a.Tag.ToString(), this.tk, this.pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }

        private void btnAddMyList_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton a = sender as ToggleButton;
            int ID = Int32.Parse(a.Tag.ToString());
            if(a.IsChecked==true)
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

        

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string[] strSearch = txtSearch.Text.Split(' ');

            ListVideo wd = new ListVideo(strSearch, this.tk, this.pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }

        private void Adminstator_Click(object sender, RoutedEventArgs e)
        {
            Admin wd = new Admin(tk, pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();

            this.Close();
        }

        private void btnAddPlayList_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton a = sender as ToggleButton;
            int ID = Int32.Parse(a.Tag.ToString());
            AddPlayList wd = new AddPlayList(this.pf, ID);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.ShowDialog();
        }
    }
}
