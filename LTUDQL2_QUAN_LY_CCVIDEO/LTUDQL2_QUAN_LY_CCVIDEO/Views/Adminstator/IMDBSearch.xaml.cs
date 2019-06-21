using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
    /// Interaction logic for IMDBSearch.xaml
    /// </summary>
    public partial class IMDBSearch : UserControl
    {
        TaiKhoan tk = null;
        Profile pf = null;
        
        public IMDBSearch(TaiKhoan tk, Profile pf)
        {
            InitializeComponent();
            this.tk = tk;
            this.pf = pf;
        }
        public IMDBSearch(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
        }

        public string page = "https://movie-database-imdb-alternative.p.rapidapi.com/?r=json&s={0}";
        public string pageID = "https://movie-database-imdb-alternative.p.rapidapi.com/?r=json&i={0}";

        private async void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            var http = new HttpClient();
            http.DefaultRequestHeaders.Add("X-RapidAPI-Host", "movie-database-imdb-alternative.p.rapidapi.com");
            http.DefaultRequestHeaders.Add("X-RapidAPI-Key", "d8d798510amsh2ebc64f76fa6172p1c7a93jsn61a803f12902");
            string url = CreateStringSearch(txtSearch.Text);
            HttpResponseMessage res = await http.GetAsync(url);
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    SearchResults results = JsonConvert.DeserializeObject<SearchResults>(data);
                    if (results.Response == false && results.Error == "Movie not found!")
                    {
                        MessageBox.Show("Can not search with " + txtSearch.Text);
                    }
                    else if(results.Response == false && results.Error == "Too many results.")
                    {
                        MessageBox.Show("Too many results!");
                    }
                    else
                        searchList.ItemsSource = results.Search;
                }
            }

        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        public string CreateStringSearch(string searchText)
        {
            var url = string.Format(page, searchText);
            return url;
        }

        public string CreateStringSearchID(string ID)
        {
            var url = string.Format(pageID, ID);
            return url;
        }

        private async void btnGet_ClickAsync(object sender, RoutedEventArgs e)
        {
            var btn = sender as Button;
            string url = CreateStringSearchID(btn.Tag.ToString());

            var http = new HttpClient();
            http.DefaultRequestHeaders.Add("X-RapidAPI-Host", "movie-database-imdb-alternative.p.rapidapi.com");
            http.DefaultRequestHeaders.Add("X-RapidAPI-Key", "d8d798510amsh2ebc64f76fa6172p1c7a93jsn61a803f12902");
            HttpResponseMessage res = await http.GetAsync(url);
            using (HttpContent content = res.Content)
            {
                string data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    IMDBVideo video = JsonConvert.DeserializeObject<IMDBVideo>(data);

                    Admin wd = null;
                    if (this.pf != null) {
                         wd = new Admin(video, tk, pf);
                    }
                    else
                    {
                        wd = new Admin(video, tk);
                    }
                    wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    wd.Show();
                    var gr = this.Parent as Grid;
                    var gr1 = gr.Parent as Grid;
                    var gr2 = gr1.Parent as Grid;
                    (gr2.Parent as Window).Close();

                }
            }

            // IMDBVideo video = searchList.SelectedItem as IMDBVideo;

           // MessageBox.Show(btn.Tag.ToString());
        }
    }


    public class IMDBVideo
    {
        //private string title
        //private string year;
        //private string imdbID;
        //private string poster;
        //private string plot;
        //private DateTime released;

        public string Title { get; set; }
        public string Year { get; set; }
        public string ImdbID { get; set; }
        public string Poster { get; set; }
        public string Plot { get; set; }
        public DateTime Released { get; set; }
    }
    public class SearchResults
    {
        public List<IMDBVideo> Search { get; set; }

        public string totalResults { get; set; }
        public bool Response { get; set; }
        public string Error { get; set; }

    }
}
