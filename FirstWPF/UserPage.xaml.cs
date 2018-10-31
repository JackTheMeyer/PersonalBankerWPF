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
    /// Interaction logic for PersonalBankerUserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            populateAccounts();
        }

        public void populateAccounts()
        {
            foreach (Account a in Manager.currentUser.AccountList)
            {
                TextBlock txt = new TextBlock();
                txt.Text = a.Name;
                rootGrid.Children.Add(txt);
            }
        }

        public void CreateNewAccount(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(Manager.openAccount);
        }
    }
}
