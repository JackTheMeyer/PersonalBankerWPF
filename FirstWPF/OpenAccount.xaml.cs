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
    /// Interaction logic for OpenAccount.xaml
    /// </summary>
    public partial class OpenAccount : Page
    {
        public OpenAccount()
        {
            InitializeComponent();
        }

        public void CreateInterest()
        {
            InterestOpenBlock.Visibility = Visibility.Visible;
            InterestOpenBox.Visibility = Visibility.Visible;
            InterestOpenButton.Visibility = Visibility.Visible;

            if (!Manager.IsTextAllowed(InterestOpenBox.Text))
            {
                InterestOpenBlock.Text = "Please only enter numbers";
            }
        }
        public void OpenInterest(object sender, RoutedEventArgs e)
        {
            Interest intAcc = new Interest(Manager.banker.BSB, Manager.banker.Acc);
            Manager.banker.AccCreated();
            double bal = double.Parse(InterestOpenBox.Text);
            intAcc.Balance = bal;
            Manager.currentUser.AccountList.Add(intAcc);
        }

        public void OpenSavings(object sender, RoutedEventArgs e)
        {

        }

        public void CreateInterest(object sender, RoutedEventArgs e)
        {

        }

        public void CreateSavings(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
