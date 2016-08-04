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
        public static List<Client> getClients() {

            List<Client> clients = new List<Client>();
            clients.Add(new Client
            {
                Id = 1,
                Name = "Uno"
            });

            return clients.Where(c => c.Id > 0).ToList();

        }
        

    }
}
