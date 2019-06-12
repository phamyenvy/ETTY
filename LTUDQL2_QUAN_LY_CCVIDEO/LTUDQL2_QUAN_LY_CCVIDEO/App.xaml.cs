using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using LTUDQL2_QUAN_LY_CCVIDEO.Views;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.RegisterViews;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LTUDQL2_QUAN_LY_CCVIDEO
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            //using(var qlccv =new QuanLyCCVEntities())
            //{
            //    TaiKhoan tk = qlccv.TaiKhoans.Where(t => t.MaTaiKhoan == 2).SingleOrDefault();
            //    Profile pf = qlccv.Profiles.Where(t => t.TaiKhoan == 2).SingleOrDefault();
            //    var wd = new MainWindow(tk,pf);
            //    wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //    wd.Show();
            //}
          //  var wd = new StartWd();
            var wd = new Admin();
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
        }
    }
}
