using LTUDQL2_QUAN_LY_CCVIDEO.Model;
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
using System.Windows.Shapes;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views
{
    /// <summary>
    /// Interaction logic for AddPlayList.xaml
    /// </summary>
    public partial class AddPlayList : Window
    {
        int idVideo = 0;
        Profile pf = null;
        public AddPlayList(Profile pf, int idVideo)
        {
            InitializeComponent();
            this.idVideo = idVideo;
            this.pf = pf;
            DataContext = DBProvider.getDSPlayList(pf);
        }

       

        private void dsPlayList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = dsPlayList.SelectedItem.ToString();

            DBProvider.addVideoIntoPlayList(DBProvider.getIDPLByName(name).IDPlayList, idVideo, pf.MaProfile, name);

            this.Close();
        }

        private void btnNewPlayList_Click(object sender, RoutedEventArgs e)
        {

            DBProvider.addVideoIntoPlayList(DBProvider.countPL(this.pf) + 1, idVideo, pf.MaProfile, txtPlaylist.Text);

            this.Close();
        }
    }
}
