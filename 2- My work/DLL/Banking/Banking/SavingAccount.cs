using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;


namespace Banking
{
    [Serializable] //This is called as attribute
    public class SavingAccount : Account
    {
        private const int minBal = 1000;


        public SavingAccount(String name, double balance)
            : base(name, balance)
        {

        }

        //Overriding parent class abstract method
        public override void withdraw(double amount)
        {
            if ((amount > Balance - 1000))
            {
                //Write name , ID and Balance in a file whose name should be name of the user.
                using (StreamWriter sw = new StreamWriter(new FileStream(Name + ".txt", FileMode.Create, FileAccess.Write)))    
                {
                    String str = this.ToString();

                    sw.Write(str);  //File will be created in Console Application folder.
                }


                throw new InsufficientBalanceException("Min balance must be 1000 in the account"); //then throw exception


            }

            else
            {
                Balance -= amount;

                Console.WriteLine("CUrrent balance = " + Balance);

                //After withdrawing Display message who and how much amount withdrawn
                onWithDraw(this.Name, amount);

            }
        }

    }
}
