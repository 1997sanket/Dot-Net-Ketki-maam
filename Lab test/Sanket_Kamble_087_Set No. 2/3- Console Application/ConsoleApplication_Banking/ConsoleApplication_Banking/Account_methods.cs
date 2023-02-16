using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Banking
{
    public abstract partial class Account
    {
        static Account()
        {
            Console.WriteLine("Welcome to my  Banking Application");
        }


        public Account(String name, double balance)
        {
            if (_id < 5)
            {
                Balance = balance;
                Name = name;
                id = ++_id;
            }

            else
                throw new Exception("Only 5 accounts are allowed.");
        }

        public double Balance
        {
            get
            {
                return balance;
            }

            protected set
            {
                //if balance is atleast 1k then only add
                if (value >= 1000)
                {
                    balance = value;
                }
                else throw new Exception("Balance should be minimum 1000");

            }
        }


        public String Name
        {

            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }


        public void deposit(double amount)
        {
            balance += amount;
        }


        public abstract void withdraw(double amount);


        public void onWithdraw(String name, double balance)
        {
            //If someone has subcribed to our event, then raise it on withdraw
            if (myDelegate != null)
            {
                myDelegate(name, balance);
            }
        }



        public override string ToString()
        {
            return Id + "  " + Name + "  " + Balance;
        }
    }
}
