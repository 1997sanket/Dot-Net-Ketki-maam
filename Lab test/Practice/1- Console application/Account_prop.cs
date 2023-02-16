using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public abstract partial class Account
    {
        private int id;
        private String name;
        private double balance;

        private static int _id = 0;

        //Delegate
        public delegate void withdrawDelegate(String name, double balance);
        public event withdrawDelegate myDelegate;


    }
}
