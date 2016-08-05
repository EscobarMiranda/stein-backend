using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace API
{
    [ServiceContract]
    public interface IClients
    {
        [OperationContract]
        bool Create(Client client);

        [OperationContract]
        [WebInvoke(
            Method = "GET",
            UriTemplate = "/{id}",
            ResponseFormat = WebMessageFormat.Json
            )]
        Client Get(string id);
        
        [OperationContract]
        [WebInvoke(
            Method = "DELETE",
            UriTemplate = "/{id}",
            ResponseFormat = WebMessageFormat.Json
            )]
        bool Delete(string id);

        [OperationContract]
        [WebInvoke(
            Method = "GET",
            UriTemplate = "/all",
            ResponseFormat = WebMessageFormat.Json
            )]
        List<Client> GetList();
    }
}
