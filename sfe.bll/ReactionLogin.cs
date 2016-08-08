using sfe.dal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sfe.bll
{
    public class ReactionLogin
    {
        private static DataClassesDataContext db = Database.Instance;
        public static List<Reaction> Get()
        {
            try
            {
                return (from reactions in db.Reactions
                        select reactions).ToList();
            }
            catch (Exception e)
            {
                EventLog.WriteEntry(e.Source, e.Message);
                throw new ReactionListNotFoundException("Reaction list not found");
            }
        }
    }
}
