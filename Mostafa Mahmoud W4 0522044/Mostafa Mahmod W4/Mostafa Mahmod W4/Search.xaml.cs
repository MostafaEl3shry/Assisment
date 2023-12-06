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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Page
    {
        DesktopEntities db = new DesktopEntities();
        public Search()
        {
            InitializeComponent();
            grid.ItemsSource=db.userrs.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr user = new userr();
            if(gendercombo.SelectedItem != null && citycombo.SelectedItem !=null)
            {
                grid.ItemsSource= db.userrs.Where(x => x.city == citycombo.Text&& x.Gender== gendercombo.Text).ToList();
                
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }
        
    }
}
