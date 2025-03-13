using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB4
{
    public class Account
    {
        private string _accountNumber;
        private string _pin;
        private string _name;
        private decimal _balance;

        public Account(string accountNumber, string pin, string name, decimal balance)
        {
            _accountNumber = accountNumber;
            _pin = pin;
            _name = name;
            _balance = balance;
        }

        public String getAccountNumber()
        {
            return _accountNumber;
        }
        public String GetPin()
        {
            return _pin;
        }
        public String GetName()
        {
            return _name;
        }
        public decimal GetBalance()
        {
            return _balance;
        }

        public void makeDeposit(decimal amount)
        {
            _balance += amount;
        }

        public void makeWithdrawal(decimal taxedamount)
        {
            if (_balance >= taxedamount)
            {
                _balance -= taxedamount;
            }
        }
    }
}
