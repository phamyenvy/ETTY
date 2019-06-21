using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.Adminstator
{
    /// <summary>
    /// Interaction logic for Process.xaml
    /// </summary>
    public partial class Process : Window
    {
        public BackgroundWorker worker = new BackgroundWorker();

        public string source;
        public string target;
        public Process(string sourceVideoPath, string targetVideoPath)
        {
            InitializeComponent();
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            source = sourceVideoPath;
            target = targetVideoPath;

            worker.RunWorkerAsync();
        }
        private void btnOut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pbLoad.Value = e.ProgressPercentage;
            ProgressTextBlock.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            uploadFile(source, target);
        }


        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                pbLoad.Value = 0;
                ProgressTextBlock.Text = "0";
            }
            else
            {
                Uploading.Visibility = Visibility.Hidden;
                DoneUpload.Visibility = Visibility.Visible;
            }
        }

        void uploadFile(string source, string target)
        {
            FileStream fsOut = new FileStream(target, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);
            byte[] bt = new byte[1048756];
            int readByte;
            while ((readByte = fsIn.Read(bt, 0, bt.Length)) > 0)
            {
                fsOut.Write(bt, 0, readByte);
                worker.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
            }
            fsIn.Close();
            fsOut.Close();

        }
    }
}
