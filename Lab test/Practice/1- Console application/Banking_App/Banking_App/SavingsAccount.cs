using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    class SavingsAccount : Account
    {
        private const double minBal = 2000;

        public SavingsAccount(String name, double balance)
            : base(name, balance)
        {

        }

        public override void withdraw(double amount)
        {
            double temp = Balance;

            if ((temp -= amount) < minBal)
                throw new Exception("You are withdrawing too much, your account should have a minimum balance of 2000");

            else
            {
                Balance -= amount;
                onWithdraw(Name, Balance);
            }
         }
    }
}
