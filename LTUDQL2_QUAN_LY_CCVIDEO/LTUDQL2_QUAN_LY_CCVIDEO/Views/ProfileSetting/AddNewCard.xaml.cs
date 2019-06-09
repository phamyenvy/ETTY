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

namespace LTUDQL2_QUAN_LY_CCVIDEO.Views.ProfileSetting
{
    /// <summary>
    /// Interaction logic for AddNewCard.xaml
    /// </summary>
    public partial class AddNewCard : Window
    {
        int maTK;
        public AddNewCard(int maTK)
        {
            InitializeComponent();
            this.maTK = maTK;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string Pass = MaHoaChuoi.MaHoa(txtPass.Password, "etty");
                DBProvider.addNewCard(txtIDCard.Text, txtFName.Text, txtLName.Text, Pass, maTK);
                this.Close();
                
            }
            catch (Exception)
            {

                MessageBox.Show("Add fail!");
            }
        }
    }
}
