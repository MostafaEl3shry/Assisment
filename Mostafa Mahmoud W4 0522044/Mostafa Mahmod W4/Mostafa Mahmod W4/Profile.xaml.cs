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

namespace Mostafa_Mahmod_W4
{
    /// <summary>
    /// Interaction logic for Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        userr user = new userr();
        public Profile(userr user)
        {
            InitializeComponent();
            label.Content = user.Username + " profile";
            txtuser.Text = user.Username;
            txtid.Text = user.user_idd.ToString();
            txtage.Text=user.age.ToString();
            txtcity.Text=user.city;
            txtgender.Text = user.Gender;
            txtpass.Password = user.pasword;
            txtphone.Text = user.phone_number;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Log_in log= new Log_in();
            this.NavigationService.Navigate(log);
        } 
    }
}
