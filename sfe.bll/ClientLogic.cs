
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
                        select clients).ToList();
            }
            catch
            {
                return null;
            }
        }
        

    }
}
