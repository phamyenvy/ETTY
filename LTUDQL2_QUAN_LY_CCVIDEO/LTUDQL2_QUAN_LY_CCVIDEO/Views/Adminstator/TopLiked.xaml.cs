using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for TopLiked.xaml
    /// </summary>
    public partial class TopLiked : UserControl
    {
        QuanLyCCVEntities ccv;
        List<Video> videos;
        public TopLiked()
        {
            InitializeComponent();
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            ccv = new QuanLyCCVEntities();
            videos = ccv.Videos.OrderByDescending(p => p.Like).Take(5).ToList();
            int likes = ccv.Videos.Sum(s => s.Like);
            Video v = new Video();
            v.TenVideo = "Others";
            v.Like = likes;
            foreach (Video l in videos)
            {
                v.Like -= l.Like;
            }
            videos.Add(v);
            SeriesCollection lst = new SeriesCollection();
            for (int i = 0; i < videos.Count; i++)
            {
                PieSeries a = new PieSeries();
                a.Title = videos[i].TenVideo;
                a.Values = new ChartValues<int> { videos[i].Like };
                a.DataLabels = true;
                lst.Add(a);
            }
            pc.Series = lst;
        }
    }
}
