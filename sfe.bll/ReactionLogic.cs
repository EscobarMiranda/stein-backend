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
    public class ReactionLogic
    {
        private static DataClassesDataContext db = Database.Instance;
        public static List<Reaction> Read()
        {
            try
            {
                return (from reactions in db.Reactions
                        select reactions).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry("sfe", e.StackTrace.ToString(), EventLogEntryType.Error);
                throw new ReactionListNotFoundException("Reaction list not found");
            }
        }
    }
}
