using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    public class BankingSystem
    {
        private List<User> _userList = new List<User>();
        private int _nextBSB = 000000;
        private int _nextAccNo = 00000000;

        public BankingSystem()
        {

        }

        public void AddUser(User user)
        {
            _userList.Add(user);
        }

        public void AccCreated()
        {
            _nextBSB += 1;
            _nextAccNo += 1;
        }
        public List<User> Users
        {
            get
            {
                return _userList;
            }
        }

        public int BSB
        {
            get
            {
                return _nextBSB;
            }
        }

        public int Acc
        {
            get
            {
                return _nextAccNo;
            }
        }


    }
}