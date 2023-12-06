using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for Log_in.xaml
    /// </summary>
    public partial class Log_in : Page
    {
        DesktopEntities db =new DesktopEntities();
        public Log_in()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                userr user = new userr();
                user = db.userrs.First(x => x.Username == usertxt.Text && x.pasword == passtxt.Text);

                Profile profile = new Profile(user);
                this.NavigationService.Navigate(profile);
            }
            catch
            {
                MessageBox.Show("try agin");
            }
        }

        private void signbtn_Click(object sender, RoutedEventArgs e)
        {
            Sign_up signup = new Sign_up();
            this.NavigationService.Navigate(signup);
        }

        private void forgetbtn_Click(object sender, RoutedEventArgs e)
        {
            Forget_Password forget = new Forget_Password();
            this.NavigationService.Navigate(forget);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            adminlogin log = new adminlogin();
            this.NavigationService.Navigate(log);
        }
    }
}
