
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
        private static DataClassesDataContext dataClasses = new DataClassesDataContext();
        public static List<Client> getClients() {
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

        public static Client getClient(int id)
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

    }
}
