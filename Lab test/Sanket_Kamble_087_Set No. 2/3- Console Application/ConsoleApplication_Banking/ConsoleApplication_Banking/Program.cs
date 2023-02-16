using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Account[] accounts = new Account[5];
            accounts[0] = new SavingsAccount("Sanket", 3000);
            accounts[1] = new SavingsAccount("Ashok", 5000);
            accounts[2] = new SavingsAccount("Martin", 6000);
            accounts[3] = new CurrentAccount("Shrikant", 7000);
            accounts[4] = new CurrentAccount("Prabhat", 8000);



            //Account temp = new SavingsAccount("abc", 100000);   Cannot create 6th object

            for (int i = 0; i < accounts.Length; i++)
            {
                //Subscribing using Lambda expression
                accounts[i].myDelegate += (name, balance) => Console.WriteLine("New SMS, {0} just withdrew some amount, current balance is {1}.", name, balance);
                accounts[i].myDelegate += (name, balance) => Console.WriteLine("New Email, {0} just withdrew some amount, current balance is {1}.", name, balance);

            }

            // accounts[0].Balance = 1000000;   not allowed because setter is protected

            Console.WriteLine(accounts[0]);

            accounts[0].deposit(7000);

            accounts[0].withdraw(2000);

            Console.WriteLine(accounts[0]);





            Console.Read();
        }
    }
}
