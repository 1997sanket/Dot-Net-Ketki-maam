using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new SavingsAccount("S", 3000);
            a1.myDelegate += (name, balance) => Console.WriteLine("{0} just withdrew some amount, current balance is {1}.", name, balance);

            Console.WriteLine(a1);

            a1.deposit(7000);

            a1.withdraw(2000);

            Console.WriteLine(a1);

            Console.Read();
        }
    }
}
