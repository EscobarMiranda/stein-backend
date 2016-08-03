using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IClients" in both code and config file together.
    [ServiceContract]
    public interface IClients
    {
        [OperationContract]
        bool Create(Client client);

        [OperationContract]
        Client get(int id);

        [OperationContract]
        bool Update(Client client);

        [OperationContract]
        bool Delete(int id);

        [OperationContract]
        List<Client> getList();
    }
}
