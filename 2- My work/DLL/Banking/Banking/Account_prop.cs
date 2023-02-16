using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    /* 1- Declare Delegate
     * 2- Declare Event based on the delegate
     * 3- Subscribe to that event
     * 
     */



    [Serializable] //This is called as attribute
   public abstract partial class Account
    {
       public delegate void MyDelegate(String name, double amount);   //delegate
       public event MyDelegate myEvent;     //event


        private int id;
        private String name;
        private double balance;
        private static int countObjects;

        private static int _id = 0;

        static Account()
        {
            Console.WriteLine("Welcome to my Bank");
        }

        public Account(String name, double balance)
        {
            countObjects++;

            if (countObjects == 6)
            {
                throw new Exception("Maximum 5 Accounts are allowed");
            }

            //this.id = ++_id;
            Name = name;
            Balance = balance;
        }


       

    }

}
