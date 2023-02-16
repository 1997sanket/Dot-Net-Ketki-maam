using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfServicepost
{
    public class userlayer
    {
      public static  List<Userlogin> coll = new List<Userlogin>();

        public int adddata(Userlogin obj)
        {
            coll.Add(obj);
            return coll.Count;

        
        
        }
        public List<Userlogin> getdata()
        {

            return coll;
        }
    }
}