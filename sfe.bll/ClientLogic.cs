
using sfe.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll
{
    public class ClientLogic
    {
        private static DataClassesDataContext db = new DataClassesDataContext();
        public static List<Client> Get() {
            try
            {
                return (from clients in db.Clients
                        where clients.active == true
                        select clients).ToList();
            }
            catch
            {
                return null;
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
            catch
            {
                return null;
            }
        }

        public static void Post(Client client)
        {
            try
            {
                db.Clients.InsertOnSubmit(client);
                db.SubmitChanges();
            }
            catch
            {
                throw new Exception(); // TODO: custom exception
            }
        }
    }
}
