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
    /// Interaction logic for adminlogin.xaml
    /// </summary>
    public partial class adminlogin : Page
    {
        DesktopEntities db = new DesktopEntities();
        public adminlogin()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, RoutedEventArgs e)
        {
            adminn admin = new adminn();
            try
            {
                admin = db.adminns.First(x => x.admin_username == usertxt.Text && x.admin_pass == passtxt.Text);

                Page1 page = new Page1();
                this.NavigationService.Navigate(page);
            }
            catch
            {
                MessageBox.Show("try agin");
            }
        }
    }
}
