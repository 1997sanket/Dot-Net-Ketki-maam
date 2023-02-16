using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    class InvalidNameException : System.ApplicationException
    {
        public InvalidNameException(String message) : base(message)
        {
            
        }
    }

}
