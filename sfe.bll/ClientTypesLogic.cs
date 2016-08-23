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
    public class ClientTypesLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        public static List<ClientType> Read()
        {
            try
            {
                return (from types in db.ClientTypes
                        select types).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ClientTypesListNotFoundException("Client Types list not found");
            }
        }
    }
}
