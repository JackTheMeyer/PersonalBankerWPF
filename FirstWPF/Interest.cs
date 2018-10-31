using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWPF
{
    public class Interest : Account
    {
        private double _balance;
        private double _interest;

        public Interest(int bsb, int account) : base(bsb, account)
        {
            Name = "Interest";
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

        public void gainInterest()
        {
            _interest += (_balance * 0.01);
        }

        public void lostInterest()
        {
            _interest = 0;
        }
    }
}
