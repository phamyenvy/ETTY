using LTUDQL2_QUAN_LY_CCVIDEO.Views;
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
            var wd = new FinishRegisterDialog();
            wd.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            wd.Show();
        }
    }
}
