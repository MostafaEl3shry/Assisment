using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        DesktopEntities db = new DesktopEntities();
        public Page1()
        {
            InitializeComponent();
            grid.ItemsSource=db.userrs.ToList();
        }

        private void searchbtn_Click(object sender, RoutedEventArgs e)
        {
            grid.ItemsSource = db.userrs.Where(x => x.city == searchtxt.Text).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Delete delete = new Delete();
            this.NavigationService.Navigate(delete);
        }
    }
}
