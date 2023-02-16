using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class InsufficientBalanceException : System.ApplicationException
    {
        public InsufficientBalanceException(String msg)
            : base(msg)
        {

        }
    }
}
