using LTUDQL2_QUAN_LY_CCVIDEO.Model;
using Microsoft.Win32;
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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting
{
    /// <summary>
    /// Interaction logic for uc_EditProfile.xaml
    /// </summary>
    public partial class uc_EditProfile : UserControl
    {
        public uc_EditProfile()
        {
            InitializeComponent();
        }
        TaiKhoan tk = null;
        List<Profile> lst = null;
        public uc_EditProfile(TaiKhoan tk)
        {
            InitializeComponent();
            this.tk = tk;
            lst = DBProvider.getPf(tk.MaTaiKhoan);
            name1.Text = lst[0].TenHienThi;
            name2.Text = lst[1].TenHienThi;
            name3.Text = lst[2].TenHienThi;
            name4.Text = lst[3].TenHienThi;
            img1.Source = new BitmapImage(new Uri(lst[0].AvatarLink));
            img2.Source = new BitmapImage(new Uri(lst[1].AvatarLink));
            img3.Source = new BitmapImage(new Uri(lst[2].AvatarLink));
            img4.Source = new BitmapImage(new Uri(lst[3].AvatarLink));
            url1.Tag = lst[0].AvatarLink;
            url2.Tag = lst[1].AvatarLink;
            url3.Tag = lst[2].AvatarLink;
            url4.Tag = lst[3].AvatarLink;
            if (lst[0].Status == 1)
            {
                Check1.IsChecked = true;
            }
            if (lst[1].Status == 1)
            {
                check2.IsChecked = true;
            }
            if (lst[2].Status == 1)
            {
                check3.IsChecked = true;
            }
            if (lst[3].Status == 1)
            {
                check4.IsChecked = true;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBProvider.updateProfile(lst[0].MaProfile, name1.Text, url1.Tag.ToString());
                DBProvider.updateProfile(lst[1].MaProfile, name2.Text, url2.Tag.ToString());
                DBProvider.updateProfile(lst[2].MaProfile, name3.Text, url3.Tag.ToString());
                DBProvider.updateProfile(lst[3].MaProfile, name4.Text, url4.Tag.ToString());
                MessageBox.Show("Update Success!");

            }
            catch
            {
                MessageBox.Show("Update Fail!");
            }
            
        }



        private void btnChage1_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg;*.png;*.jpeg;*.gif;*.bmp)|*.jpg;*.png;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                url1.Text = openFileDialog.SafeFileName.ToString();
                url1.Tag = openFileDialog.FileName.ToString();
                img1.Source = new BitmapImage(new Uri(url1.Tag.ToString()));

            }
        }

        private void btnChage2_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg;*.png;*.jpeg;*.gif;*.bmp)|*.jpg;*.png;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                url2.Text = openFileDialog.SafeFileName.ToString();
                url2.Tag = openFileDialog.FileName.ToString();
                img2.Source = new BitmapImage(new Uri(url2.Tag.ToString()));

            }
        }

        private void btnChage3_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg;*.png;*.jpeg;*.gif;*.bmp)|*.jpg;*.png;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                url3.Text = openFileDialog.SafeFileName.ToString();
                url3.Tag = openFileDialog.FileName.ToString();
                img3.Source = new BitmapImage(new Uri(url3.Tag.ToString()));

            }
        }

        private void btnChage4_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image files (*.jpg;*.png;*.jpeg;*.gif;*.bmp)|*.jpg;*.png;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
            {
                url4.Text = openFileDialog.SafeFileName.ToString();
                url4.Tag = openFileDialog.FileName.ToString();
                img4.Source = new BitmapImage(new Uri(url4.Tag.ToString()));

            }
        }
        private void Check1_Checked(object sender, RoutedEventArgs e)
        {
            DBProvider.checkProfileMain(lst[0].MaProfile);

        }

        private void check2_Checked(object sender, RoutedEventArgs e)
        {
            DBProvider.checkProfileMain(lst[1].MaProfile);

        }

        private void check3_Checked(object sender, RoutedEventArgs e)
        {
            DBProvider.checkProfileMain(lst[2].MaProfile);

        }

        private void check4_Checked(object sender, RoutedEventArgs e)
        {
            DBProvider.checkProfileMain(lst[3].MaProfile);

        }

        private void check4_Unchecked(object sender, RoutedEventArgs e)
        {
            DBProvider.uncheckProfileMain(lst[3].MaProfile);

        }

        private void check3_Unchecked(object sender, RoutedEventArgs e)
        {
            DBProvider.uncheckProfileMain(lst[2].MaProfile);

        }

        private void check2_Unchecked(object sender, RoutedEventArgs e)
        {
            DBProvider.uncheckProfileMain(lst[1].MaProfile);

        }

        private void Check1_Unchecked(object sender, RoutedEventArgs e)
        {
            DBProvider.uncheckProfileMain(lst[0].MaProfile);

        }
    }
}
