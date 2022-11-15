using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace multiple
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "GetProducts", BodyStyle = WebMessageBodyStyle.Wrapped, RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        List<Products> GetProducts();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class Products
    //{
    //    [DataMember]
    //    public int ProductID
    //    {
    //        get; set;
    //    }
    //    [DataMember]
    //    public string ProductName
    //    {
    //        get; set;
    //    }
    //    [DataMember]
    //    public string ProductOwner
    //    {
    //        get; set;
    //    }
    //    public int ID
    //    {
    //        get;set;
    //    }
    //    public string title
    //    {
    //        get;set;
    //    }

    //}
}
