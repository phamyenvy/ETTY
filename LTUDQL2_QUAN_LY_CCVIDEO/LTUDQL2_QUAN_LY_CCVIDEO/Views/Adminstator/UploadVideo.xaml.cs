using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator
{
    /// <summary>
    /// Interaction logic for UploadVideo.xaml
    /// </summary>
    public partial class UploadVideo : UserControl
    {
        QuanLyCCVEntities ccv;
        List<Video> videos;
        List<LoaiVideo> loaiVideos;
        List<CapDoTaiKhoan> capDoTaiKhoans;
        //Ten file poster, trailer, video
        string sourceImgName;
        string sourceTrailerName;
        string sourceVideoName;
        public UploadVideo()
        {
            InitializeComponent();

        }
        public UploadVideo(IMDBVideo video)
        {
            InitializeComponent();
            txtName.Text = video.Title;
            txtDes.Text = video.Plot;
            dpMFG.Text = video.Released.ToString();
            lblLinkPoster.Content = video.Poster;
        }
        private void UserControl_Initialized(object sender, EventArgs e)
        {
            ccv = new QuanLyCCVEntities();
            loaiVideos = ccv.LoaiVideos.ToList();
            cbCat.ItemsSource = loaiVideos;
            capDoTaiKhoans = ccv.CapDoTaiKhoans.ToList();
            cbLevel.ItemsSource = capDoTaiKhoans;

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();
        }
        private void UserControl_Initialized(object sender, EventArgs e, IMDBVideo video)
        {
            ccv = new QuanLyCCVEntities();
            loaiVideos = ccv.LoaiVideos.ToList();
            cbCat.ItemsSource = loaiVideos;
            capDoTaiKhoans = ccv.CapDoTaiKhoans.ToList();
            cbLevel.ItemsSource = capDoTaiKhoans;

            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();

            txtName.Text = video.Title;
            txtDes.Text = video.Plot;
            dpMFG.Text = video.Released.ToString();
            lblLinkPoster.Content = video.Poster;
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //   throw new NotImplementedException();
        }

        private void btnOpenPoster_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg;*.png;*.jpeg;*.gif;*.bmp)|*.jpg;*.png;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                lblLinkPoster.Content = openFileDialog.FileName.ToString();
                sourceImgName = openFileDialog.SafeFileName;
                // var a = openFileDialog.InitialDirectory;
                // MessageBox.Show(a);
            }
        }

        private void btnOpenTrailer_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV|All files (*.*)|*.*";

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                lblLinkTrailer.Content = openFileDialog.FileName;
                sourceTrailerName = openFileDialog.SafeFileName;
            }
        }

        private void btnOpenFilm_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                lblLinkFilm.Content = openFileDialog.FileName.ToString();
                sourceVideoName = openFileDialog.SafeFileName;
            }
        }

        void Refresh()
        {
            txtName.Clear();
            lblLinkFilm.Content = null;
            lblLinkPoster.Content = null;
            lblLinkTrailer.Content = null;
            cbCat.SelectedIndex = 0;
            txtDes.Clear();
            cbLevel.SelectedIndex = 0;

        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            ccv = new QuanLyCCVEntities();
            Video v = new Video();

            v.MoTa = txtDes.Text; //Mô tả (nếu có)
            try //Bắt buộc các thuộc tính có trên màn hình đều phải có dữ liệu
            {
                v.TenVideo = txtName.Text;
                v.LinkImage = lblLinkPoster.Content.ToString();
                v.LinkTrailer = lblLinkTrailer.Content.ToString();
                v.LinkVideo = lblLinkFilm.Content.ToString();
                v.NgaySanXuat = DateTime.Parse(dpMFG.SelectedDate.ToString());

                string tenLoai = cbCat.Text;
                var temp1 = ccv.LoaiVideos.First(p => p.TenLoaiVideo == tenLoai) as LoaiVideo;
                v.MaLoai_Video = temp1.MaLoaiVideo;
                string tenCapDo = cbLevel.Text;
                var temp2 = ccv.CapDoTaiKhoans.First(p => p.TenCapDo == tenCapDo) as CapDoTaiKhoan;
                v.CapDoVideo = temp2.MaCapDo;
                v.NgayUpload = DateTime.Now;
                v.LuotXem = 0;
                v.Like = 0;
                v.Dislike = 0;
                ccv.Videos.Add(v); //add video videoinfo vô database

                try
                {
                    string sourceImgPath = v.LinkImage;
                    string sourceTrailerPath = v.LinkTrailer;
                    string sourceVideoPath = v.LinkVideo;
                    string destinationPath = @"D:\LTUDQL2\Trailer\";
                    System.IO.File.Copy(sourceImgPath, destinationPath + sourceImgName, true);
                    System.IO.File.Copy(sourceTrailerPath, destinationPath + sourceTrailerName, true);
                    System.IO.File.Copy(sourceVideoPath, destinationPath + sourceVideoName, true);
                    Refresh();
                }
                catch
                {
                    MessageBox.Show("Can't Upload Movie!");
                }
            }
            catch
            {
                MessageBox.Show("Somethings Wrong! Please Check Again!");
            }

        }


    }
}
