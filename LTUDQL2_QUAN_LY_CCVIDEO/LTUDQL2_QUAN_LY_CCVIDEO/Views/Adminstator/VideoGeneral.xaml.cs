using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
    /// Interaction logic for VideoGeneral.xaml
    /// </summary>
    public partial class VideoGeneral : UserControl
    {
        QuanLyCCVEntities ccv;
        List<Video> videos;
        public VideoGeneral()
        {
            InitializeComponent();
            ccv = new QuanLyCCVEntities();
            this.DataContext = ccv.Videos.ToList();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            ccv = new QuanLyCCVEntities();
            int ID = (dtgVideo.SelectedItem as Video).MaVideo;
            // MessageBox.Show("ID: " + ID);
            try
            {
                Video t = ccv.Videos.First(p => p.MaVideo == ID);
                ccv.Videos.Remove(t);
                ccv.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Can't Remove!");
            }

            videos = ccv.Videos.ToList();
            dtgVideo.ItemsSource = videos;
        }

        private void dtgVideo_CurrentCellChanged(object sender, EventArgs e)
        {
            List<Video> vd = DataContext as List<Video>;
            DBProvider.SaveChangeVideo(vd);
        }
    }
}
