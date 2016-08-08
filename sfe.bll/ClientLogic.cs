
using sfe.bll.Exceptions;
using sfe.dal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll
{
    public class ClientLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        public static List<Client> Get()
        {
            try
            {
                return (from clients in db.Clients
                        where clients.active == true
                        select clients).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new ClientListNotFoundException("Client list not found");
            }
        }

        public static Client Get(int id)
        {
            try
            {
                return (from client in db.Clients
                        where client.idClient == id
                        select client).Single();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new ClientNotFoundException("Client not found");
            }
        }

        public static void Post(Client client)
        {
            try
            {
                db.Clients.InsertOnSubmit(client);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new PostClienException("Error creating client");
            }
        }
    }
}
