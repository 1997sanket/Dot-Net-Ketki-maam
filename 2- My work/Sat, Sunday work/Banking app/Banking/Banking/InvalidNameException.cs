using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class InvalidNameException : System.ApplicationException
    {
        public InvalidNameException(String msg)
            : base(msg)
        {

        }


    }
}
