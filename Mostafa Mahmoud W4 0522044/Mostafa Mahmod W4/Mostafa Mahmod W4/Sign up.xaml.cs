using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for Sign_up.xaml
    /// </summary>
    public partial class Sign_up : Page
    {
        DesktopEntities db = new DesktopEntities();
        public Sign_up()
        {
            InitializeComponent();
        }

        private void logbtn_Click(object sender, RoutedEventArgs e)
        {
            Log_in log = new Log_in();
            this.NavigationService.Navigate(log);
        }

        private bool isspass(string password)
        {
            return password.Any(char.IsDigit) && password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(c => !char.IsLetterOrDigit(c));
        }

        private void passtxt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void signbtn_Click(object sender, RoutedEventArgs e)
        {
            if (isspass(passtxt.Text))
            {
                userr user = new userr();
                
                if (comboc.SelectedItem != null)
                {
                    if (combo.SelectedItem != null)
                    {
                        int age = int.Parse(agetxt.Text);
                        if (age >= 18 && age <= 60)
                        {
                            if (phonetxt.Text.Length == 11)
                            {
                                user.Gender = combo.Text;
                                user.Username = usertxt.Text;
                                user.pasword = passtxt.Text;
                                user.phone_number = phonetxt.Text;
                                user.city = comboc.Text;
                                user.age = int.Parse(agetxt.Text);
                                db.userrs.Add(user);
                                db.SaveChanges();
                                Log_in log_In = new Log_in();
                                NavigationService.Navigate(log_In);
                            }
                            else
                            {
                                MessageBox.Show("enter 11 number");
                            }
                        }
                        else
                        {
                            MessageBox.Show("age between 18 and 60");
                        }
                    }
                    else
                    {
                        MessageBox.Show("choose one");
                    }
                }
                else
                {
                    MessageBox.Show("choose one");
                }
            }
            else
            {
                MessageBox.Show("Password not correct");
            }
        }
    }
}
