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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        DesktopEntities db = new DesktopEntities();
        public Delete()
        {
            InitializeComponent();
        }

        private void dltbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                userr user = new userr();
                user = db.userrs.First(x => x.phone_number == dlttxt.Text);
                db.userrs.Remove(user);
                db.SaveChanges();
            }
            catch 
            {
                MessageBox.Show("Wrong phone numbder");
            }
        }
    }
}
