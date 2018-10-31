using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace FirstWPF
{
    public static class Manager
    {
        public static User currentUser = null;
        public static BankingSystem banker = new BankingSystem();
        public static PersonalBankerHome pbHome = new PersonalBankerHome();
        public static NewUser newUser = new NewUser();
        public static UserPage userPage = new UserPage();
        public static OpenAccount openAccount = new OpenAccount();

        private static readonly Regex _regex = new Regex("[^0-9.-]+");
        static Manager()
        {
            
        }

        public static bool IsTextAllowed(string text)
        {
           return !_regex.IsMatch(text);
        }
    }
}
