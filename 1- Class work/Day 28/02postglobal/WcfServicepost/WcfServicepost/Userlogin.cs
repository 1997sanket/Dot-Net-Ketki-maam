using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServicepost
{ // [DataContract]
    public class Userlogin
    {
    //  [DataMember]
      public  int Id { get; set; }
    //[DataMember]
      public string Name { get; set; }
   // [DataMember]
      public string Password { get; set; }
    }
}