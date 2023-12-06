using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Forget_Password.xaml
    /// </summary>
    public partial class Forget_Password : Page
    {
        DesktopEntities db = new DesktopEntities();
        public Forget_Password()
        {
            InitializeComponent();
        }
        private static bool isspass(string password)
        {
            return password.Any(char.IsDigit) && password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(c => !char.IsLetterOrDigit(c));
        } 
        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            userr user= new userr();
            if (phonetxt.Text == "")
            {
                MessageBox.Show("this user name not found");
            }
            else
            {
                if (newtxt.Text == "")
                {
                    MessageBox.Show("please enter value");
                }
                else
                {
                    if (isspass(newtxt.Text))
                    {
                        userr darsh = db.userrs.FirstOrDefault(x => x.phone_number == phonetxt.Text);
                        darsh.pasword = newtxt.Text;
                        if (newtxt.Text == confirmtxt.Text)
                        {
                            db.userrs.AddOrUpdate(darsh);
                            db.SaveChanges();
                            Log_in log = new Log_in();
                            this.NavigationService.Navigate(log);
                        }
                        else if (newtxt.Text != confirmtxt.Text)
                        {
                            MessageBox.Show("check that confirm password equal password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password not correct");
                    }
                }
            }
        }
    }
}
