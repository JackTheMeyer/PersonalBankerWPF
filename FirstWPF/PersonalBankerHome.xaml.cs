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


namespace FirstWPF
{
    /// <summary>
    /// Interaction logic for PersonalBankerHome.xaml
    /// </summary>
    public partial class PersonalBankerHome : Page
    {
        private User bankManager = new User("BankManager", "Admin"); 
        public PersonalBankerHome()
        {
            InitializeComponent();
        }

        public void CreateUser(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(Manager.newUser);
        }

        public void LoginUser(object sender, RoutedEventArgs e)
        {
            foreach (User u in Manager.banker.Users)
            {
                if (UsernameTextBox.Text == u.Username && PasswordTextBox.Text == u.Password)
                {
                    this.NavigationService.Navigate(Manager.userPage);
                    Manager.currentUser = u;
                    break;
                }
                else this.NavigationService.Navigate(Manager.pbHome);
            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
