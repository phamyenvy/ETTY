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
    /// Interaction logic for TopViewed.xaml
    /// </summary>
    public partial class TopViewed : UserControl
    {
        QuanLyCCVEntities ccv;
        List<Video> videos;
        public TopViewed()
        {
            InitializeComponent();
        }

        private void UserControl_Initialized(object sender, EventArgs e)
        {
            ccv = new QuanLyCCVEntities();
            videos = ccv.Videos.OrderByDescending(p => p.LuotXem).Take(5).ToList();
            int views = int.Parse(ccv.Videos.Sum(s => s.LuotXem).ToString());
            Video v = new Video();
            v.TenVideo = "Others";
            v.LuotXem = views;
            foreach (Video l in videos)
            {
                v.LuotXem -= l.LuotXem;
            }
            videos.Add(v);
            SeriesCollection lst = new SeriesCollection();
            for (int i = 0; i < videos.Count; i++)
            {
                PieSeries a = new PieSeries();
                a.Title = videos[i].TenVideo;
                string x = videos[i].LuotXem.ToString();
                int k = int.Parse(x);
                a.Values = new ChartValues<int> { k };
                a.DataLabels = true;
                lst.Add(a);
            }
            pc.Series = lst;

        }

    }
}
