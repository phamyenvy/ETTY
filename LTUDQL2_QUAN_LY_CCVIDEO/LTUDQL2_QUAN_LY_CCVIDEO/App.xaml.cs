using LTUDQL2_QUAN_LY_CCVIDEO.Views;
using LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator;
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
<<<<<<< HEAD
            var wd = new Admin();
=======
            var wd = new StartWd();
>>>>>>> 20d6663c2a5ad37457c6468f467ac1d6624747c2
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
        }
    }
}
