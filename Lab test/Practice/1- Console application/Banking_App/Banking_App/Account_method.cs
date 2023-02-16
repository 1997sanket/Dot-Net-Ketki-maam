using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    public abstract partial class Account 
    {
        public Account(String name, double balance)
        {
            Balance = balance;
            Name = name;
            id = ++_id;
        }

        public double Balance
        {
            get
            {
                return balance;
            }

            protected set
            {
                //if balance is atleast 2k then only add
                if (value >= 2000)
                {
                    balance = value;
                }
                else throw new Exception("Balance should be minimum 2000");

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
                if (value.Length < 3 || value.Length > 15)
                    throw new InvalidNameException("Name should be between 3 and 15 characters");

                else
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
