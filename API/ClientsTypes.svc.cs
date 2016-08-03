using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace API
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ClientsTypes" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ClientsTypes.svc or ClientsTypes.svc.cs at the Solution Explorer and start debugging.
    public class ClientsTypes : IClientsTypes
    {
        DataClassesDataContext dataClasses = new DataClassesDataContext();

        public bool Create(ClientsType clientType)
        {
            try
            {
                dataClasses.ClientsTypes.InsertOnSubmit(clientType);
                dataClasses.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ClientsType get(int id)
        {
            try
            {
                return (from clientType in dataClasses.ClientsTypes
                        where clientType.idClientType == id
                        select clientType).Single();
            }
            catch
            {
                return null;
            }
        }

        public List<ClientsType> getList()
        {
            try
            {
                return (from clientsTypes in dataClasses.ClientsTypes
                        select clientsTypes).ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool Update(ClientsType clientType)
        {
            throw new NotImplementedException();
        }
    }
}
