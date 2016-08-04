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

        public bool Delete(string id)
        {
            try
            {
                Client tmpClient = (from client in dataClasses.Clients
                                               where client.idClient == int.Parse(id)
                                               select client).Single();
                tmpClient.status = false; // not removed, only the state is changed
                dataClasses.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Client Get(string id)
        {
            try
            {
                Client tmpClient = (from client in dataClasses.Clients
                        where client.idClient == int.Parse(id)
                        select client).Single();
                return tmpClient;
            }
            catch
            {
                return null;
            }
        }

        public List<Client> GetList()
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
    }
}
