using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class SilverAccount : Account
    {
        public SilverAccount(string accountNumber, string pin, string name, decimal balance) : base(accountNumber, pin, name, balance)
        {

        }
    }
}
