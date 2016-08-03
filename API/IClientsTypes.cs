using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClientsTypes" in both code and config file together.
    [ServiceContract]
    public interface IClientsTypes
    {
        [OperationContract]
        bool Create(ClientsType clientType);

        [OperationContract]
        ClientsType get(int id);

        [OperationContract]
        bool Update(ClientsType clientType);

        [OperationContract]
        bool Delete(int id);

        [OperationContract]
        List<ClientsType> getList();
    }
}
