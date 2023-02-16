using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    
    public abstract partial class Account
    {
        //Read only property for ID
        public int ID
        {
            get { return id; }
        }

        //Accessible only in child class
        protected double Balance
        {



          set 
            {
                if (value < 1000) throw new Exception("Min balance should be 1000");

                else
                {
                   
                    balance = value;
                }
            }


           get { return balance; }
            
        }


        public double getBalance()
        {
            return Balance;
        }


        public String Name 
        {
            set
            {
                if (value.Length > 15 || value.Length < 3) throw new InvalidNameException("Name should be between 3 and 15 characters");

                else
                {
                    this.id = ++_id;
                    name = value;  
                }
            }

            get { return name; }
        }


        public void deposit(double amount)
        {
            balance += amount;
        }


        public abstract void withdraw(double amount);


        public override String ToString()
        {
            return id + " " + name + " " + balance;
        }


        public void onWithDraw(String name, double amount)
        {
            //If someone has subscribed
            if (myEvent != null)
            {
                myEvent(name, amount);  //then raise the event
            }
        }

    }
}
