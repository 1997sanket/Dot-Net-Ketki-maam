using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    [Serializable] //This is called as attribute
    public class CurrentAccount : Account
    {
        public CurrentAccount(String name, double balance)
            : base(name, balance)
        {

        }

        //Overriding parent class abstract method
        public override void withdraw(double amount)
        {
            Balance -= amount;

            Console.WriteLine("CUrrent balance = " + Balance);

            //After withdrawing Display message who and how much amount withdrawn
            onWithDraw(this.Name, amount);
        }
    }

}
