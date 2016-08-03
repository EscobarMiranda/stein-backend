using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace API
{
    public class Clients : IClients
    {
        DataClassesDataContext dataClasses = new DataClassesDataContext();

        public bool Create(Client client)
        {
            try
            {
                dataClasses.Clients.InsertOnSubmit(client);
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

        public Client get(int id)
        {
            try
            {
                return (from client in dataClasses.Clients
                        where client.idClient == id
                        select client).Single();
            }
            catch
            {
                return null;
            }
        }

        public List<Client> getList()
        {
            try
            {
                return (from clients in dataClasses.Clients
                        where clients.status == true
                        select clients).ToList();
            }
            catch
            {
                return null;
            }
        }

        public bool Update(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
