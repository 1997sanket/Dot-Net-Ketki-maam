using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServicepost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
         [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = "postData/")]
  int postData(Userlogin obj);


        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "getuser/")]
        List<Userlogin> getuser();

        // TODO: Add your service operations here
    }


  
}
