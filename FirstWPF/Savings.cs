using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    public class Savings : Account
    {
        private double _balance;

        public Savings(int bsb, int account) : base(bsb, account)
        {
            Name = "Savings";
        }

        public override double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
            }
        }

        public void recieveTransaction()
        {

        }



    }
}
