﻿using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting;
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
        public ListVideo(string[] searchText, TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            List<List<VideoInfo>> lst = new List<List<VideoInfo>>();
            lst.Add(DBProvider.getSearchVideo(searchText));

            List<String> lstVideo = DBProvider.getLoaiVideo();
            cbCats.ItemsSource = lstVideo;
            cbCats.DisplayMemberPath = "TenLoaiVideo";
            DataContext = lst;
            this.pf = pf;
            this.tk = tk;

            //xử lý string search



        }
        public ListVideo(int maLoai,TaiKhoan tk, Profile pf) //Mã 0 là myvideo, còn lại theo csdl là mã của cats, hiển thi dsach thuộc cats
        {
            InitializeComponent();
            List<List<VideoInfo>> lst = new List<List<VideoInfo>>();
            List<String> lstVideo = DBProvider.getLoaiVideo();
            this.pf = pf;
            this.tk = tk;
            List<MenuItem> lstCats = new List<MenuItem>();

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

            List<String> lstPlaylistProfile = DBProvider.getDSPlayList(pf);
            List<MenuItem> lstplayList = new List<MenuItem>();

            foreach (String t in lstPlaylistProfile)
            {
                MenuItem a = new MenuItem();
                a.Header = t;
                a.Tag = t;
                a.Click += new RoutedEventHandler(this.btnGetPlayList_Click);
                lstplayList.Add(a);
            }

            menuplayList.ItemsSource = lstplayList;
            switch (maLoai)
            {
                
                case 0:
                    lst.Add(DBProvider.getMyVideo(pf));
                    
                    break;
               
                default:
                    lst.Add(DBProvider.getListVideoByID(maLoai));


                    break;
                    
                    
            }
            

            DataContext = lst;
        }
        public ListVideo(string playList, TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            this.pf = pf;
            this.tk = tk;
            List<List<VideoInfo>> lst = new List<List<VideoInfo>>();

            List<String> lstVideo = DBProvider.getLoaiVideo();
            List<String> lstPlaylistProfile = DBProvider.getDSPlayList(pf);

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

            menuplayList.ItemsSource = lstplayList;

            lst.Add(DBProvider.getPlayListVideo(this.pf, DBProvider.getIDPLByName(playList).IDPlayList));

            DataContext = lst;
        }

        private void btnGetPlayList_Click(object sender, RoutedEventArgs e)
        {
            MenuItem a = sender as MenuItem;
            ListVideo wd = new ListVideo(a.Tag.ToString(), this.tk, this.pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }
        private void myList_Click(object sender, RoutedEventArgs e)
        {
            ListVideo wd = new ListVideo(0, tk, pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }
        void btnButton_Click(object sender, RoutedEventArgs e)
        {
            MenuItem a = sender as MenuItem;
            ListVideo wd1 = new ListVideo(DBProvider.getIDLoaiVByName(a.Tag.ToString()), tk, pf);
            wd1.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd1.Show();
            this.Close();
        }

        int timebegin = 500, timeDuration = 300;
        bool isEnter = false;
        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {


            var gr = sender as Grid;

            var heart = gr.FindName("btnHeart") as ToggleButton;
            heart.Visibility = Visibility.Visible;
            var add = gr.FindName("btnAddMyList") as ToggleButton;
            add.Visibility = Visibility.Visible;

            var me = gr.FindName("video") as MediaElement;
            me.Visibility = Visibility.Visible;

            timebegin = 1000;


            if (isEnter)
            {
                timebegin = 500;
            }

            //var sxDA = new DoubleAnimation();
            //sxDA.To = 1.1;
            //sxDA.BeginTime = TimeSpan.FromMilliseconds(0);
            //sxDA.Duration = TimeSpan.FromMilliseconds(200);
            //Storyboard.SetTarget(sxDA, gr);
            //Storyboard.SetTargetProperty(sxDA, new PropertyPath("LayoutTransform.ScaleX"));

            //var syDA = new DoubleAnimation();
            //syDA.To = 1.1;
            //syDA.BeginTime = TimeSpan.FromMilliseconds(0);
            //syDA.Duration = TimeSpan.FromMilliseconds(200);
            //Storyboard.SetTarget(syDA, gr);
            //Storyboard.SetTargetProperty(syDA, new PropertyPath("LayoutTransform.ScaleY"));

            //var sb = new Storyboard();
            //sb.Children.Add(sxDA);
            //sb.Children.Add(syDA);



            //sb.Begin();

            

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
            var add = gr.FindName("btnAddMyList") as ToggleButton;
            add.Visibility = Visibility.Collapsed;
            
            var me = gr.FindName("video") as MediaElement;
            me.Visibility = Visibility.Collapsed;
            if (me != null)
            {
                me.Stop();
            }
            //var sxDA = new DoubleAnimation();
            //sxDA.Duration = TimeSpan.FromMilliseconds(300);
            //Storyboard.SetTarget(sxDA, gr);
            //Storyboard.SetTargetProperty(sxDA, new PropertyPath("LayoutTransform.ScaleX"));

            //var syDA = new DoubleAnimation();
            //syDA.Duration = TimeSpan.FromMilliseconds(300);
            //Storyboard.SetTarget(syDA, gr);
            //Storyboard.SetTargetProperty(syDA, new PropertyPath("LayoutTransform.ScaleY"));

            //var sb = new Storyboard();
            //sb.Children.Add(sxDA);
            //sb.Children.Add(syDA);
            //sb.Begin();

        }
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
            if (pf.AvatarLink == "1")
            {
                ProfileSettingWd wd = new ProfileSettingWd(this.tk, this.pf);
                wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                wd.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Your profile not allowed go to setting!");
            }

        }

        #endregion
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
            dv.Show();
            this.Close();
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

        

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string[] strSearch = txtSearch.Text.Split(' ');
            ListVideo wd = new ListVideo(strSearch, this.tk, this.pf);
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
            this.Close();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnSearch_Click(sender, e);
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
