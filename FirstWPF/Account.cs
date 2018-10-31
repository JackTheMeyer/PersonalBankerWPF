using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    public abstract class Account
    {
        private int _bsb;
        private int _accountNumber;
        private string _name;

        public Account(int bsb, int account)
        {
            _bsb = bsb;
            _accountNumber = account;

        }

        public int BSB
        {
            get
            {
                return _bsb;
            }
        }

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public abstract double Balance
        {
            get;
            set;
        }
    }
}
