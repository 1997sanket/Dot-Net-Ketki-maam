﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
   public class NameComparator : IComparer
    {

        public int Compare(Object x, Object y)
        {
            Account a1 = (Account)x;
            Account a2 = (Account)y;

            return String.Compare(a1.Name, a2.Name);

            //throw new NotImplementedException();
        }
    }
}
