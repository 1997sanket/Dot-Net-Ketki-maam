using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Banking
{
    class CurrentAccount : Account
    {
         public CurrentAccount(String name, double balance)
            : base(name, balance)
        {

        }

        public override void withdraw(double amount)
        {
            
                Balance -= amount;
                onWithdraw(Name, Balance);
            
        }
    }
}
